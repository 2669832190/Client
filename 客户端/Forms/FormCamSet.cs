using Cognex.VisionPro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 客户端.Class;

namespace 客户端.Forms {
	public partial class FormCamSet : Form {

		CogLoad cogLoad;

		CogAcqFifoTool CamTool;

		public FormCamSet(Class.CogLoad cogLoad) {
			InitializeComponent();
			this.cogLoad = cogLoad;
		}

		private void FormCamSet_Load(object sender , EventArgs e) {
			CamTool = CogSerializer.LoadObjectFromFile(cogLoad.CamPath) as CogAcqFifoTool;
			cogAcqFifoEditV21.Subject = CamTool;
		}

		private void 保存ToolStripMenuItem_Click(object sender , EventArgs e) {
			CogSerializer.SaveObjectToFile(CamTool,cogLoad.CamPath);
		}

		private void 保存并推出ToolStripMenuItem_Click(object sender , EventArgs e) {
			CogSerializer.SaveObjectToFile(CamTool , cogLoad.CamPath);
			this.Close();
		}

		private void FormCamSet_FormClosing(object sender , FormClosingEventArgs e) {
			if ( CamTool != null && CamTool.Operator.FrameGrabber != null ) {
				CamTool.Operator.FrameGrabber.Disconnect(false);
			}
		}
	}
}
