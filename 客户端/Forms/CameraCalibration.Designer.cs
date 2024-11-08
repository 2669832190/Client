namespace 客户端.Forms {
	partial class CameraCalibration {
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CameraCalibration));
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dgvNPoint = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.button1 = new System.Windows.Forms.Button();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.cogRecordDisplay1 = new Cognex.VisionPro.CogRecordDisplay();
			this.RotationY = new System.Windows.Forms.Label();
			this.RotationX = new System.Windows.Forms.Label();
			this.RMS = new System.Windows.Forms.Label();
			this.Skew = new System.Windows.Forms.Label();
			this.Rotation = new System.Windows.Forms.Label();
			this.Scaling = new System.Windows.Forms.Label();
			this.TranslationY = new System.Windows.Forms.Label();
			this.TranslationX = new System.Windows.Forms.Label();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvNPoint)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cogRecordDisplay1)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1199, 767);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 1;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.groupBox2, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.groupBox3, 0, 2);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 3;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.17603F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.82397F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 137F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(593, 761);
			this.tableLayoutPanel2.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dgvNPoint);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.groupBox1.Location = new System.Drawing.Point(3, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(587, 363);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "标定参数";
			// 
			// dgvNPoint
			// 
			this.dgvNPoint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvNPoint.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
			this.dgvNPoint.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvNPoint.Location = new System.Drawing.Point(3, 31);
			this.dgvNPoint.Name = "dgvNPoint";
			this.dgvNPoint.RowTemplate.Height = 23;
			this.dgvNPoint.Size = new System.Drawing.Size(581, 329);
			this.dgvNPoint.TabIndex = 0;
			// 
			// Column1
			// 
			this.Column1.HeaderText = "Column1";
			this.Column1.Name = "Column1";
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Column2";
			this.Column2.Name = "Column2";
			// 
			// Column3
			// 
			this.Column3.HeaderText = "Column3";
			this.Column3.Name = "Column3";
			// 
			// Column4
			// 
			this.Column4.HeaderText = "Column4";
			this.Column4.Name = "Column4";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.dataGridView2);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox2.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.groupBox2.Location = new System.Drawing.Point(3, 372);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(587, 248);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "旋转中心";
			// 
			// dataGridView2
			// 
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6});
			this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView2.Location = new System.Drawing.Point(3, 31);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.RowTemplate.Height = 23;
			this.dataGridView2.Size = new System.Drawing.Size(581, 214);
			this.dataGridView2.TabIndex = 1;
			// 
			// Column5
			// 
			this.Column5.HeaderText = "Column5";
			this.Column5.Name = "Column5";
			// 
			// Column6
			// 
			this.Column6.HeaderText = "Column6";
			this.Column6.Name = "Column6";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.button1);
			this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox3.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.groupBox3.Location = new System.Drawing.Point(3, 626);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(587, 132);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "编辑";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(68, 50);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(176, 60);
			this.button1.TabIndex = 0;
			this.button1.Text = "保存";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 1;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel3.Controls.Add(this.groupBox4, 0, 1);
			this.tableLayoutPanel3.Controls.Add(this.cogRecordDisplay1, 0, 0);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(602, 3);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 2;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(594, 761);
			this.tableLayoutPanel3.TabIndex = 1;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.RotationY);
			this.groupBox4.Controls.Add(this.RotationX);
			this.groupBox4.Controls.Add(this.RMS);
			this.groupBox4.Controls.Add(this.Skew);
			this.groupBox4.Controls.Add(this.Rotation);
			this.groupBox4.Controls.Add(this.Scaling);
			this.groupBox4.Controls.Add(this.TranslationY);
			this.groupBox4.Controls.Add(this.TranslationX);
			this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox4.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.groupBox4.Location = new System.Drawing.Point(3, 383);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(588, 375);
			this.groupBox4.TabIndex = 0;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "标定结果";
			// 
			// cogRecordDisplay1
			// 
			this.cogRecordDisplay1.ColorMapLowerClipColor = System.Drawing.Color.Black;
			this.cogRecordDisplay1.ColorMapLowerRoiLimit = 0D;
			this.cogRecordDisplay1.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
			this.cogRecordDisplay1.ColorMapUpperClipColor = System.Drawing.Color.Black;
			this.cogRecordDisplay1.ColorMapUpperRoiLimit = 1D;
			this.cogRecordDisplay1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cogRecordDisplay1.DoubleTapZoomCycleLength = 2;
			this.cogRecordDisplay1.DoubleTapZoomSensitivity = 2.5D;
			this.cogRecordDisplay1.Location = new System.Drawing.Point(3, 3);
			this.cogRecordDisplay1.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
			this.cogRecordDisplay1.MouseWheelSensitivity = 1D;
			this.cogRecordDisplay1.Name = "cogRecordDisplay1";
			this.cogRecordDisplay1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("cogRecordDisplay1.OcxState")));
			this.cogRecordDisplay1.Size = new System.Drawing.Size(588, 374);
			this.cogRecordDisplay1.TabIndex = 1;
			// 
			// RotationY
			// 
			this.RotationY.AutoSize = true;
			this.RotationY.Font = new System.Drawing.Font("宋体", 15F);
			this.RotationY.Location = new System.Drawing.Point(356, 220);
			this.RotationY.Name = "RotationY";
			this.RotationY.Size = new System.Drawing.Size(109, 20);
			this.RotationY.TabIndex = 15;
			this.RotationY.Text = "旋转中心Y:";
			// 
			// RotationX
			// 
			this.RotationX.AutoSize = true;
			this.RotationX.Font = new System.Drawing.Font("宋体", 15F);
			this.RotationX.Location = new System.Drawing.Point(114, 228);
			this.RotationX.Name = "RotationX";
			this.RotationX.Size = new System.Drawing.Size(109, 20);
			this.RotationX.TabIndex = 14;
			this.RotationX.Text = "旋转中心X:";
			// 
			// RMS
			// 
			this.RMS.AutoSize = true;
			this.RMS.Font = new System.Drawing.Font("宋体", 15F);
			this.RMS.Location = new System.Drawing.Point(406, 171);
			this.RMS.Name = "RMS";
			this.RMS.Size = new System.Drawing.Size(59, 20);
			this.RMS.TabIndex = 13;
			this.RMS.Text = "RMS：";
			// 
			// Skew
			// 
			this.Skew.AutoSize = true;
			this.Skew.Font = new System.Drawing.Font("宋体", 15F);
			this.Skew.Location = new System.Drawing.Point(406, 127);
			this.Skew.Name = "Skew";
			this.Skew.Size = new System.Drawing.Size(69, 20);
			this.Skew.TabIndex = 12;
			this.Skew.Text = "倾斜：";
			// 
			// Rotation
			// 
			this.Rotation.AutoSize = true;
			this.Rotation.Font = new System.Drawing.Font("宋体", 15F);
			this.Rotation.Location = new System.Drawing.Point(263, 171);
			this.Rotation.Name = "Rotation";
			this.Rotation.Size = new System.Drawing.Size(69, 20);
			this.Rotation.TabIndex = 11;
			this.Rotation.Text = "旋转：";
			// 
			// Scaling
			// 
			this.Scaling.AutoSize = true;
			this.Scaling.Font = new System.Drawing.Font("宋体", 15F);
			this.Scaling.Location = new System.Drawing.Point(263, 127);
			this.Scaling.Name = "Scaling";
			this.Scaling.Size = new System.Drawing.Size(69, 20);
			this.Scaling.TabIndex = 10;
			this.Scaling.Text = "缩放：";
			// 
			// TranslationY
			// 
			this.TranslationY.AutoSize = true;
			this.TranslationY.Font = new System.Drawing.Font("宋体", 15F);
			this.TranslationY.Location = new System.Drawing.Point(114, 171);
			this.TranslationY.Name = "TranslationY";
			this.TranslationY.Size = new System.Drawing.Size(79, 20);
			this.TranslationY.TabIndex = 9;
			this.TranslationY.Text = "平移Y：";
			// 
			// TranslationX
			// 
			this.TranslationX.AutoSize = true;
			this.TranslationX.Font = new System.Drawing.Font("宋体", 15F);
			this.TranslationX.Location = new System.Drawing.Point(114, 127);
			this.TranslationX.Name = "TranslationX";
			this.TranslationX.Size = new System.Drawing.Size(79, 20);
			this.TranslationX.TabIndex = 8;
			this.TranslationX.Text = "平移X：";
			// 
			// CameraCalibration
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1199, 767);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "CameraCalibration";
			this.Text = "CameraCalibration";
			this.Load += new System.EventHandler(this.CameraCalibration_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvNPoint)).EndInit();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.cogRecordDisplay1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.DataGridView dgvNPoint;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.Button button1;
		private Cognex.VisionPro.CogRecordDisplay cogRecordDisplay1;
		private System.Windows.Forms.Label RotationY;
		private System.Windows.Forms.Label RotationX;
		private System.Windows.Forms.Label RMS;
		private System.Windows.Forms.Label Skew;
		private System.Windows.Forms.Label Rotation;
		private System.Windows.Forms.Label Scaling;
		private System.Windows.Forms.Label TranslationY;
		private System.Windows.Forms.Label TranslationX;
	}
}