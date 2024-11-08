using Cognex.VisionPro.CalibFix;
using Cognex.VisionPro.PMAlign;
using Cognex.VisionPro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 九点标定;
using System.IO;

namespace 客户端.Forms {
	public partial class CameraCalibration : Form {
		public CameraCalibration() {
			InitializeComponent();
		}

		Vision Vision = new Vision();

		private string img_path = Directory.GetCurrentDirectory() + "\\images";
		//所有标定图片
		string[] imgs;
		//表示图片的下标
		int index = 0;

		List<CalibNpoint> list = new List<CalibNpoint>();

		//主程序接收到C1数据以后 会调用这个方法
		//9点标定
		public void NPointFunc(string msg) {
			//拍照 这里使用图片
			//Vision.FifoTool.Run();

			Bitmap bmp = new Bitmap(imgs[index]);
			index++;

			CogImage8Grey cogImage8Grey = new CogImage8Grey(bmp);


			//放到TB里运行 拍照换成读取的灰度图
			Vision.NPointTB.Inputs["OutputImage"].Value = cogImage8Grey;
			Vision.NPointTB.Run();
			//拿到模板匹配工具
			CogPMAlignTool pmaTool = Vision.NPointTB.Tools["CogPMAlignTool1"] as CogPMAlignTool;

			//msg == C1,100,100
			string[] pointStr = msg.Split(',');
			//世界坐标
			double worldX = double.Parse(pointStr[1]);
			double worldY = double.Parse(pointStr[2]);
			//像素坐标
			double pixX = pmaTool.Results[0].GetPose().TranslationX;
			double pixY = pmaTool.Results[0].GetPose().TranslationY;

			//把坐标封装起来
			CalibNpoint calibNpoint = new CalibNpoint();
			calibNpoint.pixX = pixX;
			calibNpoint.pixY = pixY;
			calibNpoint.WorldX = worldX;
			calibNpoint.WorldY = worldY;
			//保存到list
			list.Add(calibNpoint);
			//更新数据
			UpdataDgv();
			//显示结果
			cogRecordDisplay1.Record = Vision.NPointTB.CreateLastRunRecord().SubRecords[0];
			cogRecordDisplay1.Fit();

			//已经有了9条数据 校正
			if ( list.Count == 9 ) {
				//拿到9点标定工具
				CogCalibNPointToNPointTool NPointTool = Vision.NPointTB.Tools["CogCalibNPointToNPointTool1"] as CogCalibNPointToNPointTool;
				//填入数据
				for ( int i = 0; i < list.Count; i++ ) {
					NPointTool.Calibration.AddPointPair(list[i].pixX , list[i].pixY , list[i].WorldX , list[i].WorldY);
				}
				//校准
				NPointTool.Calibration.Calibrate();


				UpdataResult(NPointTool);

			}
		}

		private void CameraCalibration_Load(object sender , EventArgs e) {
			Vision.Load();
			//加载图片
			imgs = Directory.GetFiles(img_path);
		}


		//数旋转中心拍照了几次
		int RCindex = 0;
		//主窗体接收到RC后执行的方法
		//旋转中心
		public void RotationFunc(string msg) {
			//会发送3次数据
			//RC,X坐标,Y坐标
			Vision.FifoTool.Run();
			CogImage8Grey cogImage8Grey = (CogImage8Grey)Vision.FifoTool.OutputImage;

			Vision.NPointTB.Inputs["OutputImage"].Value = cogImage8Grey;
			Vision.NPointTB.Run();

			//拿到第二个模板匹配的结果
			CogPMAlignTool pmaTool = Vision.NPointTB.Tools["CogPMAlignTool2"] as CogPMAlignTool;
			//拿到拟合圆工具
			CogFitCircleTool cogFitCircleTool = Vision.NPointTB.Tools["CogFitCircleTool1"] as CogFitCircleTool;

			cogFitCircleTool.RunParams.AddPoint(pmaTool.Results[0].GetPose().TranslationX , pmaTool.Results[0].GetPose().TranslationY);
			RCindex++;

			if ( RCindex == 3 ) {
				cogFitCircleTool.Run();
				//拿到旋转中心XY
				//cogFitCircleTool.Result.GetCircle().CenterX;
				//cogFitCircleTool.Result.GetCircle().CenterY;
			}

			//3次传来的XY坐标 传入拟合圆工具
			//运行拟合圆

			//拟合圆结果是个圆 圆心就表示旋转中心
		}

		private void UpdataDgv() {
			Invoke(new MethodInvoker(() => {
				//清空
				dgvNPoint.Columns.Clear();
				//绑定数据源
				dgvNPoint.DataSource = null;
				dgvNPoint.DataSource = list;
			}));
		}
		private void UpdataResult(CogCalibNPointToNPointTool NPointTool) {
			Invoke(new MethodInvoker(() => {
				CogTransform2DLinear cogTransform2DLinear = (CogTransform2DLinear)NPointTool.Calibration.GetComputedUncalibratedFromCalibratedTransform();

				//修改窗体显示的结果
				TranslationX.Text = "平移X : " + cogTransform2DLinear.TranslationX.ToString("0.00");
				TranslationY.Text = "平移Y : " + cogTransform2DLinear.TranslationY.ToString("0.00");

				RotationX.Text = "旋转中心X : " + cogTransform2DLinear.RotationX.ToString("0.00");
				RotationY.Text = "旋转中心Y : " + cogTransform2DLinear.RotationY.ToString("0.00");

				Scaling.Text = "缩放 : " + cogTransform2DLinear.Scaling.ToString("0.00");
				Rotation.Text = "旋转 : " + cogTransform2DLinear.Rotation.ToString("0.00");

				Skew.Text = "倾斜 : " + cogTransform2DLinear.Skew.ToString("0.00");
				RMS.Text = "RMS : " + NPointTool.Calibration.ComputedRMSError.ToString("0.00");
			}));
		}
	}
}


/*
C1,100,100
C1,200,100
C1,300,100
C1,300,200
C1,200,200
C1,100,200
C1,100,300
C1,200,300
C1,300,300
 */