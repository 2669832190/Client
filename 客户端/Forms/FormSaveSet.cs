using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 客户端.Forms {
	public partial class FormSaveSet : Form {
		string iniPath;
		public FormSaveSet(string iniPath) {
			InitializeComponent();
			this.iniPath = iniPath + "\\init.ini";
		}

		#region think
		/*ini文件写入：	自动删除的状态 , 及天数 , 保存文件的路径！, 保存数据的状态！*/
		/*
		 * 保存图片：当勾选保存图片后		需要选择保存图片路径，通过按钮的点击进行选择文件夹
		 *								当勾选后关闭窗体时检查路径是否为空
		 *								关闭窗体时自动创建相应的文件夹！！！
		 *								（img-->年月日原图,年月日结果图）
		 *	
		 *	
		 * 保存数据：当勾选的时候，程序运行完以后！
		 * 将运行结果（时间，数据，结果） 保存到对应路径的csv文件中
		 * 
		 */
		

		#endregion


		private void button1_Click(object sender , EventArgs e) {
			FolderBrowserDialog f = new FolderBrowserDialog();
			if ( f.ShowDialog() == DialogResult.OK ) {
				String DirPath = f.SelectedPath;
				this.PicturePath.Text = DirPath;
			}
		}

		private void button2_Click(object sender , EventArgs e) {
			FolderBrowserDialog f = new FolderBrowserDialog();
			if ( f.ShowDialog() == DialogResult.OK ) {
				String DirPath = f.SelectedPath;
				this.DataPath.Text = DirPath;
			}
		}

		private void FormSaveSet_Load(object sender , EventArgs e) {
			if ( Ini.IniAPI.GetPrivateProfileString("Status" , "SavePicture" , "fal" , iniPath).Contains("true") ) {
				SavePicture.Checked = true;
				PicturePath.Text = Ini.IniAPI.GetPrivateProfileString("Status", "PicturePath" , "",iniPath);
			}
			if ( Ini.IniAPI.GetPrivateProfileString("Status" , "AutoDeletion" , "false" , iniPath).Contains("true") ) { 
				AutoDeletion.Checked = true;
				AutoDeletionDay.Text = Ini.IniAPI.GetPrivateProfileInt("Status", "AutoDeletionDay",0,iniPath).ToString();
			}
			if ( Ini.IniAPI.GetPrivateProfileString("Status" , "SaveData" , "false" , iniPath).Contains("true") ) {
				SaveData.Checked = true;
				DataPath.Text = Ini.IniAPI.GetPrivateProfileString("Status" , "DataPath" , "" , iniPath);
			}
		}

		private void FormSaveSet_FormClosing(object sender , FormClosingEventArgs e) {
			if ( SavePicture.Checked == false ) {
				Ini.IniAPI.INIWriteValue(iniPath , "Status" , "SavePicture" , "false");
			} else {
				Ini.IniAPI.INIWriteValue(iniPath , "Status" , "PicturePath" , PicturePath.Text);
			}
			if ( AutoDeletion.Checked == false ) {
				Ini.IniAPI.INIWriteValue(iniPath , "Status" , "AutoDeletion" , "false");
			} else {
				Ini.IniAPI.INIWriteValue(iniPath , "Status" , "AutoDeletionDay" , AutoDeletionDay.Text);
			}
			if ( SaveData.Checked == false ) {
				Ini.IniAPI.INIWriteValue(iniPath , "Status" , "SaveData" , "false");
			} else {
				Ini.IniAPI.INIWriteValue(iniPath , "Status" , "DataPath" , DataPath.Text);
			}

			//新建文件夹及CSV文件？
		}
	}
}
