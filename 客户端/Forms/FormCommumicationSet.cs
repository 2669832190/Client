using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 客户端.Forms {
	public partial class FormCommumicationSet : Form {
		string iniPath;
		public FormCommumicationSet(string iniPath) {
			InitializeComponent();
			this.iniPath = iniPath + "\\init.ini";
		}

		private void FormCommumicationSet_Load(object sender , EventArgs e) {
			//判断是否开启TCP和串口
			/*if ( Ini.IniAPI.GetPrivateProfileInt("TCP" , "IsOn" , -1 , iniPath) == 1 ) {
				//开启TCP
			
			} else { 
				
			}
			if ( Ini.IniAPI.GetPrivateProfileInt("SPort" , "IsOn" , -1 , iniPath) == 1 ) {
				//开启串口
			
			} else { 
			
			}*/


			//TCP获取值
			TCPIsOn.Checked = Ini.IniAPI.GetPrivateProfileInt("TCP","IsOn",-1,iniPath) == 1 ? true : false;
			ip.Text = Ini.IniAPI.GetPrivateProfileString("TCP","ip","",iniPath);
			port.Text = Ini.IniAPI.GetPrivateProfileString("TCP" , "port" , "" , iniPath);
			//串口获取值
			PortIsOn.Checked = Ini.IniAPI.GetPrivateProfileInt("SPort" , "IsOn" , -1 , iniPath) == 1 ? true : false;
			spname.Text = Ini.IniAPI.GetPrivateProfileString("SPort" , "spname" , "" , iniPath);
			BaudRate.Text = Ini.IniAPI.GetPrivateProfileString("SPort" , "BaudRate" , "" , iniPath);
			DataBits.Text = Ini.IniAPI.GetPrivateProfileString("SPort" , "DataBits" , "" , iniPath);
			Parity.Text = Ini.IniAPI.GetPrivateProfileString("SPort" , "Parity" , "" , iniPath);
			StopBits.Text = Ini.IniAPI.GetPrivateProfileString("SPort" , "StopBits" , "" , iniPath);
		}
		/// <summary>
		/// TCP保存按钮
		/// </summary>
		private void button2_Click(object sender , EventArgs e) {
			Ini.IniAPI.INIWriteValue(iniPath , "TCP" , "IsOn" , TCPIsOn.Checked ? "1" : "0");
			Ini.IniAPI.INIWriteValue(iniPath , "TCP" , "ip" , ip.Text);
			Ini.IniAPI.INIWriteValue(iniPath , "TCP" , "port" , port.Text);
		}
		/// <summary>
		/// 串口保存按钮
		/// </summary>
		private void button1_Click(object sender , EventArgs e) {
			Ini.IniAPI.INIWriteValue(iniPath , "SPort" , "IsOn" , PortIsOn.Checked ? "1" : "0");
			Ini.IniAPI.INIWriteValue(iniPath , "SPort" , "spname" , spname.Text);
			Ini.IniAPI.INIWriteValue(iniPath , "SPort" , "BaudRate" , BaudRate.Text);
			Ini.IniAPI.INIWriteValue(iniPath , "SPort" , "DataBits" , DataBits.Text);
			Ini.IniAPI.INIWriteValue(iniPath , "SPort" , "Parity" , Parity.Text);
			Ini.IniAPI.INIWriteValue(iniPath , "SPort" , "StopBits" , StopBits.Text);
		}
	}
}
