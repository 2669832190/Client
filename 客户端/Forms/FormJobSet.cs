using Cognex.VisionPro;
using Cognex.VisionPro.ToolBlock;
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
	public partial class FormJobSet : Form {
		CogLoad cogLoad;
		public FormJobSet(CogLoad cogLoad) {
			InitializeComponent();
			this.cogLoad = cogLoad;
		}
		CogToolBlock toolBlock;
		private void FormJobSet_Load(object sender , EventArgs e) {
			toolBlock = CogSerializer.LoadObjectFromFile(cogLoad.TBPath) as CogToolBlock;
			cogToolBlockEditV21.Subject = toolBlock;
		}

		private void 保存ToolStripMenuItem_Click(object sender , EventArgs e) {
			CogSerializer.SaveObjectToFile(toolBlock,cogLoad.TBPath);
		}

		private void 保存并推出ToolStripMenuItem_Click(object sender , EventArgs e) {
			CogSerializer.SaveObjectToFile(toolBlock , cogLoad.TBPath);
			this.Close();
		}

		private void FormJobSet_FormClosing(object sender , FormClosingEventArgs e) {
			cogLoad.CloseCam();
		}
	}
}
