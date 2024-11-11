using 客户端.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using 客户端.Forms;
using Cognex.VisionPro;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace 客户端 {
	public partial class FormIndex : Form {
		public FormIndex() {
			InitializeComponent();
			MessageBox.Show("程序启动！");
			//AddRuningMessages("程序启动！");
			RuningMessages.Items.Add("程序启动！");
		}

		#region think
		/* 
		 * 项目启动，提示程序启动
		 * 读取配置信息（统计信息,Socket连接信息），完成后提示读取配置文件完成！
		 * 加载VPP， 完成后提示加载VPP完成！
		 * 建立Socket连接 连接后提示连接服务器, 修改状态栏，计时器时刻检查连接状态，修改文本
		 * 
		 * RuningMessages添加信息导致线程跨越！！！
		 * 
		 * 
		 */

		#endregion


		#region 程序所需变量声明
		/// <summary>
		/// ini路径
		/// </summary>
		string iniFilePath = Directory.GetCurrentDirectory() + "\\ini";
		
		

		/// <summary>
		/// IP终结点
		/// </summary>
		IPEndPoint iPEndPoint;

		/// <summary>
		/// 连接服务端
		/// </summary>
		public Socket Socket;
		
		/// <summary>
		/// 接受数据线程
		/// </summary>
		public Thread t1;

		/// <summary>
		/// VPP加载
		/// </summary>
		public CogLoad cogLoad = new CogLoad();

		List<IndexDataTable> list = new List<IndexDataTable>();

		bool SavePic = false;
		string Path = Directory.GetCurrentDirectory() + "\\img\\" + DateTime.Now.ToString("yyyy-MM-dd") + "_Former";
		string path = Directory.GetCurrentDirectory() + "\\img\\" + DateTime.Now.ToString("yyyy-MM-dd") + "_New";

		#endregion


		private void FormIndex_Load(object sender , EventArgs e) {
			#region 加载配置
			RuningMessages.Items.Add("开始加载配置文件...");
			BeginMonitor();
			RuningMessages.Items.Add("加载配置文件完成！");
			#endregion

			#region 加载VPP
			RuningMessages.Items.Add("开始加载VPP...");
			LoadVPP();
			RuningMessages.Items.Add("加载VPP完成！");
			#endregion

			#region 连接服务器
			RuningMessages.Items.Add("开始建立连接...");
			try {
				Socket.Connect(iPEndPoint);
				RuningMessages.Items.Add("连接成功！");
				t1 = new Thread(Recive);
				t1.IsBackground = true;
				t1.Start(Socket);
			} catch ( Exception ex  ) {
				MessageBox.Show(ex.Message , "连接服务器引发异常");
			}
			#endregion

			#region 连接成功后检测状态
			//项目加载过程中开启计时器
			timer1.Start();
			#endregion

			#region ！！！检测自动删除图片状态，保存图片，数据的状态及其目录的创建
			 /*
			 保存数据
			 */
			if ( Ini.IniAPI.GetPrivateProfileString("Status" , "SavePicture" , "" , iniFilePath + "\\init.ini").Contains("true") ) {
				SavePic = true;
				//检测保存图片的目录是否创建

				#region 判断文件夹是否存在
				
				if ( !Directory.Exists(Path) ) {
					//创建文件夹
					try {
						Directory.CreateDirectory(Path);
					} catch ( Exception ex ) {
					}
				}
				if ( !Directory.Exists(path) ) {
					//创建文件夹
					try {
						Directory.CreateDirectory(path);
					} catch ( Exception ex ) {
					}
				}
				#endregion

				//检测自动删除图片状态是否开启
				if ( Ini.IniAPI.GetPrivateProfileString("Status", "AutoDeletion", "", iniFilePath + "\\init.ini").Contains("true") ) {
					//对超出日期进行删除！
					DeleterF(Path , Ini.IniAPI.GetPrivateProfileInt("Status", "AutoDeletionDay", 0 , iniFilePath + "\\init.ini"));
					DeleterF(path , Ini.IniAPI.GetPrivateProfileInt("Status" , "AutoDeletionDay" , 0 , iniFilePath + "\\init.ini"));
				}
				
			} else { 
				//未开启保存图片功能
			}

			//检测是否开启保存数据
			if ( Ini.IniAPI.GetPrivateProfileString("Status" , "SaveData" , "" , iniFilePath + "\\init.ini").Contains("true") ) {
				//检测CSV文件夹是否创建（文件）
				if ( !File.Exists(Directory.GetCurrentDirectory() + "\\CSV\\data.csv") ) {
					try {
						File.Create(Directory.GetCurrentDirectory() + "\\CSV\\data.csv");
					} catch ( Exception ex ) {
					}
				}
			} else { 
				//未开启数据保存功能
			}
			#endregion

			#region ！！！检测TCP及串口是否开启并确认是否连接成功

			#endregion
		}
		/// <summary>
		/// 定时器检测客户端及PLC的连接状态
		/// </summary>
		private void timer1_Tick(object sender , EventArgs e) {
			if ( Socket == null ) {
				ClientStatus.Text = "未连接";
				ClientStatus.ForeColor = Color.Red;
			} else if(Socket.Poll(1000,SelectMode.SelectRead)){
				byte[] bytes = new byte[1024];
				int len = Socket.Receive(bytes);
				if ( len == 0 ) {
					//RuningMessages.Items.Add("服务器断开连接！");
					ClientStatus.Text = "已断开";
					ClientStatus.ForeColor = Color.Red;
					/*
					#region 重新连接
					int j = 0;
					for ( int i = 0; j < 5; i++ ) {
						j++;
						RuningMessages.Items.Add("开始尝试重新建立连接...（" + j + "）");
						try {
							Socket.Connect(iPEndPoint);
							RuningMessages.Items.Add("连接成功！");
							t1 = new Thread(Recive);
							t1.IsBackground = true;
							t1.Start(Socket);
						} catch ( Exception ex ) {
							//MessageBox.Show(ex.Message , "连接服务器引发异常");
						}
					}
					#endregion
					*/
				}
			} else {
				ClientStatus.Text = "已连接";
				ClientStatus.ForeColor = Color.Green;
			}
		}

		
		/// <summary>
		/// 接收消息
		/// </summary>
		/// <param name="state"></param>
		private void Recive(object state) { 
			Socket Rsocket = state as Socket;
			while ( true ) {
				try {
					byte[] buffer = new byte[1024 * 1024];
					int len = Rsocket.Receive(buffer);
					if ( len == 0 ) break;
					string msg = Encoding.Default.GetString(buffer, 0, len);
					AddRuningMessages("接收到数据 -> " + msg);

					#region C1标定信号
					if ( msg.Contains("T1") ) {

						#region 开始拍照

						cogLoad.CamTool.Run();
						AddRuningMessages("开始拍照！");
						cogRecordDisplay1.Image = cogLoad.CamTool.OutputImage;
						cogRecordDisplay1.Fit();
						AddRuningMessages("拍照完成！");
						#endregion
						#region 开始检测
						AddRuningMessages("开始检测！");
						cogLoad.ToolBlock.Inputs["InputImg"].Value = cogLoad.CamTool.OutputImage;
						cogLoad.ToolBlock.Run();

						//这里总数加加？？？

						if ( cogLoad.ToolBlock.RunStatus.Result == CogToolResultConstants.Accept ) {
							//label1.Text = "Width:" + loadVpp.ToolBlock.Outputs["Width"].Value.ToString();
							//有结果的时候进行总数加加

							#region MyRegion
							/*
							SumShow.Text = Ini.IniAPI.GetPrivateProfileString("Statistics" , "Sum" , "" , iniFilePath + "\\init.ini");
							GoodProductsShow.Text = Ini.IniAPI.GetPrivateProfileString("Statistics" , "GoodProducts" , "" , iniFilePath + "\\init.ini");
							Double Yield = Double.Parse(GoodProductsShow.Text) / Double.Parse(SumShow.Text) * 100;
							YieldNum.Text = Yield.ToString() == "NaN" ? "0" + "%" : Yield.ToString() + "%";
							*/
							#endregion

							int Sum = Ini.IniAPI.GetPrivateProfileInt("Statistics" , "Sum" , -1 , iniFilePath + "\\init.ini");
							Sum++;
							Ini.IniAPI.INIWriteValue(iniFilePath + "\\init.ini" , "Statistics" , "Sum" , Sum.ToString());
							int GP = Ini.IniAPI.GetPrivateProfileInt("Statistics" , "GoodProducts" , -1 , iniFilePath + "\\init.ini");
							bool Isok = false;
							if ( (Double)cogLoad.ToolBlock.Outputs["Width"].Value >= 240 ) {
								//🆗
								AddRuningMessages("检测完成：OK！");
								Isok = true;
								GP++;
								Ini.IniAPI.INIWriteValue(iniFilePath + "\\init.ini" , "Statistics" , "GoodProducts" , GP.ToString());
							} else {
								//NG
								AddRuningMessages("检测完成：NG！！！");
								
							}
							IndexDataTable indexDataTable = new IndexDataTable();
							indexDataTable.dateTime = DateTime.Now;
							indexDataTable.width = double.Parse(cogLoad.ToolBlock.Outputs["Width"].Value.ToString());
							indexDataTable.data = Isok ? "OK" : "NG";
							list.Add(indexDataTable);
							UpdataDgv();
							UpNum(Sum , GP,Isok);


						} else {
							MessageBox.Show("运行失败，请检查相机配置，或产品位置！");
							AddRuningMessages("运行失败，请检查相机配置，或产品位置！");
						}


						cogRecordDisplay2.Record = cogLoad.ToolBlock.CreateLastRunRecord().SubRecords["CogPMAlignTool1.InputImage"];
						cogRecordDisplay2.Fit();
						#endregion
						#region 运行后保存图片
						if ( SavePic ) {
							int i = 0;
							Bitmap BitMap = cogLoad.CamTool.OutputImage.ToBitmap();
							BitMap.Save(Path + i + ".bmp" , System.Drawing.Imaging.ImageFormat.Bmp);
							Bitmap bitmap = cogRecordDisplay2.CreateContentBitmap(Cognex.VisionPro.Display.CogDisplayContentBitmapConstants.Image) as Bitmap;
							bitmap.Save(path + i + ".bmp" , System.Drawing.Imaging.ImageFormat.Bmp);
						}
						
						#endregion
					}

					if ( msg.Contains("C1") ) {
						cameraCalibration.NPointFunc(msg);
					} else if ( msg.Contains("RC") ) {
						cameraCalibration.RotationFunc(msg);
					}
					#endregion


				} catch ( Exception ex ) {
					MessageBox.Show(ex.Message,"接收信息触发异常");
				}
			}
		}
		/// <summary>
		/// 更新总计，良品，良率！！！
		/// </summary>
		private void UpNum(int Sum,int GP,bool Isok) {
			Invoke(new MethodInvoker(() => {
				if ( Isok ) {
					IsOK.Text = "OK";
					IsOK.BackColor = Color.Green;
				} else {
					IsOK.Text = "NG";
					IsOK.BackColor = Color.Red;
				}

				//良率计算
				Double YieldNumm = Math.Round((Double.Parse(GP.ToString()) /Double.Parse(Sum.ToString())),2)  * 100;
				//Ini.IniAPI.INIWriteValue(iniFilePath , "Statistics" , "Yield" , YieldNumm.ToString());
				//Ini.IniAPI.GetPrivateProfileDouble("lv","Yield",-1,loadVpp.iniFilePath);

				SumShow.Text = Ini.IniAPI.GetPrivateProfileInt("Statistics" , "Sum" , -1 , iniFilePath + "\\init.ini").ToString();
				GoodProductsShow.Text = Ini.IniAPI.GetPrivateProfileInt("Statistics" , "GoodProducts" , -1 , iniFilePath + "\\init.ini").ToString();
				YieldNum.Text = YieldNumm.ToString() + "%";
			}));
		}

		/// <summary>
		/// RuningMessages添加信息导致线程跨越！！！
		/// </summary>
		/// <param name="megs">需要添加的信息（自动添加时间）</param>
		private void AddRuningMessages(string megs) {
			Invoke(new MethodInvoker( () => {
				RuningMessages.Items.Add(DateTime.Now.ToString("HH:mm:ss") + "：" + megs);
			}));
		}

		/// <summary>
		/// //更新数据（统计信息 and Socket的连接信息）
		/// </summary>
		private void BeginMonitor() {
			//初始化
			Socket = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);
			//更新数据（统计信息 and Socket的连接信息）
			try {
				SumShow.Text = Ini.IniAPI.GetPrivateProfileString("Statistics" , "Sum" , "" , iniFilePath + "\\init.ini");
				GoodProductsShow.Text = Ini.IniAPI.GetPrivateProfileString("Statistics" , "GoodProducts" , "" , iniFilePath + "\\init.ini");
				Double Yield = Double.Parse(GoodProductsShow.Text) / Double.Parse(SumShow.Text) * 100;
				YieldNum.Text = Yield.ToString() == "NaN" ? "0" + "%" : Yield.ToString() + "%";
				//IP终结点
				iPEndPoint = new IPEndPoint(IPAddress.Parse(Ini.IniAPI.GetPrivateProfileString("SocketmMessages","ipPath","",iniFilePath+"\\init.ini")),Ini.IniAPI.GetPrivateProfileInt("SocketmMessages","portNum",0,iniFilePath+"\\init.ini"));
			} catch ( Exception ex ) {
				MessageBox.Show(ex.Message,"配置信息加载触发异常！");
				//throw;
			}
		}

		/// <summary>
		/// 加载VPP
		/// </summary>
		private void LoadVPP() { 
			//相机连接，工具盒加载
			if ( !cogLoad.LoadVpp() ) {
				RuningMessages.Items.Add("VPP加载失败！");
			}
		}
		/// <summary>
		/// 更新表格数据
		/// </summary>
		private void UpdataDgv() {
			Invoke(new MethodInvoker(() => {
				//清空
				datatable.Columns.Clear();
				//绑定数据源
				datatable.DataSource = null;
				datatable.DataSource = list;
			}));
		}

		private void DeleterF(string Path , int Day) {
			DirectoryInfo dir = new DirectoryInfo(Path);
			if ( dir.Exists ) {
				DirectoryInfo[] childs = dir.GetDirectories();
				foreach ( DirectoryInfo child in childs ) {
					//文件夹名转为时间格式
					DateTime dt2 = DateTime.Parse(child.Name);
					//时间差
					TimeSpan ts = DateTime.Now - dt2;
					if ( ts.Days >= Day )
						child.Delete(true);
				}
			}

		}

		#region 菜单栏设置！！！

		private void 退出ToolStripMenuItem_Click(object sender , EventArgs e) {
			this.Close();
			//释放资源！！！
		}

		private void 相机1ToolStripMenuItem_Click(object sender , EventArgs e) {
			Forms.FormCamSet formCamSet = new Forms.FormCamSet(cogLoad);
			formCamSet.ShowDialog();
			//重新加载相机获取使用权限
			cogLoad.LoadVpp();
		}

		private void 作业1ToolStripMenuItem_Click(object sender , EventArgs e) {
			Forms.FormJobSet formJobSet = new Forms.FormJobSet(cogLoad);
			formJobSet.ShowDialog();
			//重新加载作业获取使用权限
			cogLoad.LoadVpp();
		}

		private void 参数ToolStripMenuItem_Click(object sender , EventArgs e) {
			Forms.FormParameterSet formParameterSet = new Forms.FormParameterSet(iniFilePath);
			formParameterSet.ShowDialog();

			/*这里参数窗口访问ini文件后ini文件是否可以被index继续访问？？？*/


		}

		private void 通化讯设置ToolStripMenuItem_Click(object sender , EventArgs e) {
			Forms.FormCommumicationSet formCommumicationSet = new Forms.FormCommumicationSet(iniFilePath);
			formCommumicationSet.ShowDialog();

			/*这里通讯设置进入窗体后需要加载ini文件中的通讯方式，同时可能进行修改*/
			/*当窗体被关闭时，需要注意 重新连接 ！！！*/
		}

		private void 保存图片ToolStripMenuItem_Click(object sender , EventArgs e) {
			Forms.FormSaveSet formSaveSet = new Forms.FormSaveSet(iniFilePath);
			formSaveSet.ShowDialog();
		}


		Forms.CameraCalibration cameraCalibration = new Forms.CameraCalibration();
		private void 下相机标定ToolStripMenuItem_Click(object sender , EventArgs e) {

			cameraCalibration.ShowDialog();
		}

		private void 编辑标定作业ToolStripMenuItem_Click(object sender , EventArgs e) {

		}
		#endregion

	}
}



/*
 串口通讯开启...
 

 相机标定！！！保存
 相机标定保存后的数据进行保存到对应ini文件
 编辑相机标定窗口
 退出程序时的相机释放
 */