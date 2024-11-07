namespace 客户端.Forms {
	partial class FormCommumicationSet {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if ( disposing && ( components != null ) ) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.Tab = new System.Windows.Forms.TabControl();
			this.TCPTab = new System.Windows.Forms.TabPage();
			this.label7 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.port = new System.Windows.Forms.TextBox();
			this.ip = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.TCPIsOn = new System.Windows.Forms.CheckBox();
			this.PortTab = new System.Windows.Forms.TabPage();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.StopBits = new System.Windows.Forms.TextBox();
			this.Parity = new System.Windows.Forms.TextBox();
			this.DataBits = new System.Windows.Forms.TextBox();
			this.BaudRate = new System.Windows.Forms.TextBox();
			this.spname = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.PortIsOn = new System.Windows.Forms.CheckBox();
			this.Tab.SuspendLayout();
			this.TCPTab.SuspendLayout();
			this.PortTab.SuspendLayout();
			this.SuspendLayout();
			// 
			// Tab
			// 
			this.Tab.Controls.Add(this.TCPTab);
			this.Tab.Controls.Add(this.PortTab);
			this.Tab.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Tab.Location = new System.Drawing.Point(0, 0);
			this.Tab.Name = "Tab";
			this.Tab.SelectedIndex = 0;
			this.Tab.Size = new System.Drawing.Size(800, 450);
			this.Tab.TabIndex = 0;
			// 
			// TCPTab
			// 
			this.TCPTab.Controls.Add(this.label7);
			this.TCPTab.Controls.Add(this.button2);
			this.TCPTab.Controls.Add(this.port);
			this.TCPTab.Controls.Add(this.ip);
			this.TCPTab.Controls.Add(this.label2);
			this.TCPTab.Controls.Add(this.TCPIsOn);
			this.TCPTab.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.TCPTab.Location = new System.Drawing.Point(4, 22);
			this.TCPTab.Name = "TCPTab";
			this.TCPTab.Padding = new System.Windows.Forms.Padding(3);
			this.TCPTab.Size = new System.Drawing.Size(792, 424);
			this.TCPTab.TabIndex = 0;
			this.TCPTab.Text = "TCP";
			this.TCPTab.UseVisualStyleBackColor = true;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label7.Location = new System.Drawing.Point(181, 192);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(64, 20);
			this.label7.TabIndex = 5;
			this.label7.Text = "Port:";
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.button2.Location = new System.Drawing.Point(311, 279);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(163, 90);
			this.button2.TabIndex = 4;
			this.button2.Text = "保存";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// port
			// 
			this.port.Location = new System.Drawing.Point(267, 189);
			this.port.Name = "port";
			this.port.Size = new System.Drawing.Size(279, 30);
			this.port.TabIndex = 3;
			// 
			// ip
			// 
			this.ip.Location = new System.Drawing.Point(267, 120);
			this.ip.Name = "ip";
			this.ip.Size = new System.Drawing.Size(279, 30);
			this.ip.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label2.Location = new System.Drawing.Point(201, 123);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(42, 20);
			this.label2.TabIndex = 4;
			this.label2.Text = "IP:";
			// 
			// TCPIsOn
			// 
			this.TCPIsOn.AutoSize = true;
			this.TCPIsOn.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.TCPIsOn.Location = new System.Drawing.Point(51, 41);
			this.TCPIsOn.Name = "TCPIsOn";
			this.TCPIsOn.Size = new System.Drawing.Size(70, 24);
			this.TCPIsOn.TabIndex = 1;
			this.TCPIsOn.Text = "启用";
			this.TCPIsOn.UseVisualStyleBackColor = true;
			// 
			// PortTab
			// 
			this.PortTab.Controls.Add(this.label6);
			this.PortTab.Controls.Add(this.label5);
			this.PortTab.Controls.Add(this.label4);
			this.PortTab.Controls.Add(this.label3);
			this.PortTab.Controls.Add(this.button1);
			this.PortTab.Controls.Add(this.StopBits);
			this.PortTab.Controls.Add(this.Parity);
			this.PortTab.Controls.Add(this.DataBits);
			this.PortTab.Controls.Add(this.BaudRate);
			this.PortTab.Controls.Add(this.spname);
			this.PortTab.Controls.Add(this.label1);
			this.PortTab.Controls.Add(this.PortIsOn);
			this.PortTab.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.PortTab.Location = new System.Drawing.Point(4, 22);
			this.PortTab.Name = "PortTab";
			this.PortTab.Padding = new System.Windows.Forms.Padding(3);
			this.PortTab.Size = new System.Drawing.Size(792, 424);
			this.PortTab.TabIndex = 1;
			this.PortTab.Text = "串口";
			this.PortTab.UseVisualStyleBackColor = true;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label6.Location = new System.Drawing.Point(192, 310);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(93, 20);
			this.label6.TabIndex = 11;
			this.label6.Text = "停止位：";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label5.Location = new System.Drawing.Point(192, 247);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(93, 20);
			this.label5.TabIndex = 10;
			this.label5.Text = "校验位：";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label4.Location = new System.Drawing.Point(192, 192);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(93, 20);
			this.label4.TabIndex = 9;
			this.label4.Text = "数据位：";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label3.Location = new System.Drawing.Point(192, 133);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(93, 20);
			this.label3.TabIndex = 8;
			this.label3.Text = "波特率：";
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.button1.Location = new System.Drawing.Point(571, 293);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(151, 84);
			this.button1.TabIndex = 7;
			this.button1.Text = "保存";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// StopBits
			// 
			this.StopBits.Location = new System.Drawing.Point(298, 307);
			this.StopBits.Name = "StopBits";
			this.StopBits.Size = new System.Drawing.Size(208, 30);
			this.StopBits.TabIndex = 6;
			// 
			// Parity
			// 
			this.Parity.Location = new System.Drawing.Point(298, 244);
			this.Parity.Name = "Parity";
			this.Parity.Size = new System.Drawing.Size(208, 30);
			this.Parity.TabIndex = 5;
			// 
			// DataBits
			// 
			this.DataBits.Location = new System.Drawing.Point(298, 189);
			this.DataBits.Name = "DataBits";
			this.DataBits.Size = new System.Drawing.Size(208, 30);
			this.DataBits.TabIndex = 4;
			// 
			// BaudRate
			// 
			this.BaudRate.Location = new System.Drawing.Point(298, 130);
			this.BaudRate.Name = "BaudRate";
			this.BaudRate.Size = new System.Drawing.Size(208, 30);
			this.BaudRate.TabIndex = 3;
			// 
			// spname
			// 
			this.spname.Location = new System.Drawing.Point(298, 68);
			this.spname.Name = "spname";
			this.spname.Size = new System.Drawing.Size(208, 30);
			this.spname.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label1.Location = new System.Drawing.Point(192, 71);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(93, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "串口名：";
			// 
			// PortIsOn
			// 
			this.PortIsOn.AutoSize = true;
			this.PortIsOn.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.PortIsOn.Location = new System.Drawing.Point(49, 37);
			this.PortIsOn.Name = "PortIsOn";
			this.PortIsOn.Size = new System.Drawing.Size(70, 24);
			this.PortIsOn.TabIndex = 1;
			this.PortIsOn.Text = "启用";
			this.PortIsOn.UseVisualStyleBackColor = true;
			// 
			// FormCommumicationSet
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.Tab);
			this.Name = "FormCommumicationSet";
			this.Text = "FormCommumicationSet";
			this.Load += new System.EventHandler(this.FormCommumicationSet_Load);
			this.Tab.ResumeLayout(false);
			this.TCPTab.ResumeLayout(false);
			this.TCPTab.PerformLayout();
			this.PortTab.ResumeLayout(false);
			this.PortTab.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl Tab;
		private System.Windows.Forms.TabPage TCPTab;
		private System.Windows.Forms.TabPage PortTab;
		private System.Windows.Forms.TextBox ip;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox TCPIsOn;
		private System.Windows.Forms.TextBox StopBits;
		private System.Windows.Forms.TextBox Parity;
		private System.Windows.Forms.TextBox DataBits;
		private System.Windows.Forms.TextBox BaudRate;
		private System.Windows.Forms.TextBox spname;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox PortIsOn;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox port;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button1;
	}
}