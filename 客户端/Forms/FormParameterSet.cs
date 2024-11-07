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
	public partial class FormParameterSet : Form {
		string iniPath;
		public FormParameterSet(string iniPath) {
			InitializeComponent();
			this.iniPath = iniPath + "\\init.ini";
		}

		private void FormParameterSet_Load(object sender , EventArgs e) {
			DatumPointX.Text = Ini.IniAPI.GetPrivateProfileDouble("Argument" , "DatumPointX" , 0 , iniPath).ToString();
			DatumPointY.Text = Ini.IniAPI.GetPrivateProfileDouble("Argument" , "DatumPointY" , 0 , iniPath).ToString();
			DatumPointA.Text = Ini.IniAPI.GetPrivateProfileDouble("Argument" , "DatumPointA" , 0 , iniPath).ToString();
			FitX.Text = Ini.IniAPI.GetPrivateProfileDouble("Argument" , "FitX" , 0 , iniPath).ToString();
			FitY.Text = Ini.IniAPI.GetPrivateProfileDouble("Argument" , "FitY" , 0 , iniPath).ToString();
			FitA.Text = Ini.IniAPI.GetPrivateProfileDouble("Argument" , "FitA" , 0 , iniPath).ToString();
			CenterOfRotationX.Text = Ini.IniAPI.GetPrivateProfileDouble("Argument" , "CenterOfRotationX" , 0 , iniPath).ToString();
			CenterOfRotationY.Text = Ini.IniAPI.GetPrivateProfileDouble("Argument" , "CenterOfRotationY" , 0 , iniPath).ToString();
		}

		private void button1_Click(object sender , EventArgs e) {
			Ini.IniAPI.INIWriteValue(iniPath, "Argument" , "DatumPointX" , DatumPointX.Text);
			Ini.IniAPI.INIWriteValue(iniPath, "Argument" , "DatumPointY" , DatumPointY.Text);
			Ini.IniAPI.INIWriteValue(iniPath, "Argument" , "DatumPointA" , DatumPointA.Text);
			Ini.IniAPI.INIWriteValue(iniPath, "Argument" , "FitX" , FitX.Text);
			Ini.IniAPI.INIWriteValue(iniPath, "Argument" , "FitY" , FitY.Text);
			Ini.IniAPI.INIWriteValue(iniPath, "Argument" , "FitA" , FitA.Text);
			Ini.IniAPI.INIWriteValue(iniPath, "Argument" , "CenterOfRotationX" , CenterOfRotationX.Text);
			Ini.IniAPI.INIWriteValue(iniPath, "Argument" , "CenterOfRotationY" , CenterOfRotationY.Text);
		}

		private void button2_Click(object sender , EventArgs e) {
			this.Close();
		}
	}
}
