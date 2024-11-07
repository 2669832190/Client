namespace 客户端.Forms {
	partial class FormSaveSet {
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
			this.SavePicture = new System.Windows.Forms.CheckBox();
			this.AutoDeletion = new System.Windows.Forms.CheckBox();
			this.AutoDeletionDay = new System.Windows.Forms.TextBox();
			this.PicturePath = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SaveData = new System.Windows.Forms.CheckBox();
			this.DataPath = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// SavePicture
			// 
			this.SavePicture.AutoSize = true;
			this.SavePicture.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.SavePicture.Location = new System.Drawing.Point(76, 82);
			this.SavePicture.Name = "SavePicture";
			this.SavePicture.Size = new System.Drawing.Size(129, 28);
			this.SavePicture.TabIndex = 1;
			this.SavePicture.Text = "保存图片";
			this.SavePicture.UseVisualStyleBackColor = true;
			// 
			// AutoDeletion
			// 
			this.AutoDeletion.AutoSize = true;
			this.AutoDeletion.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.AutoDeletion.Location = new System.Drawing.Point(270, 81);
			this.AutoDeletion.Name = "AutoDeletion";
			this.AutoDeletion.Size = new System.Drawing.Size(129, 28);
			this.AutoDeletion.TabIndex = 2;
			this.AutoDeletion.Text = "自动删除";
			this.AutoDeletion.UseVisualStyleBackColor = true;
			// 
			// AutoDeletionDay
			// 
			this.AutoDeletionDay.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.AutoDeletionDay.Location = new System.Drawing.Point(418, 80);
			this.AutoDeletionDay.Name = "AutoDeletionDay";
			this.AutoDeletionDay.Size = new System.Drawing.Size(163, 30);
			this.AutoDeletionDay.TabIndex = 3;
			this.AutoDeletionDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// PicturePath
			// 
			this.PicturePath.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.PicturePath.Location = new System.Drawing.Point(197, 135);
			this.PicturePath.Name = "PicturePath";
			this.PicturePath.Size = new System.Drawing.Size(370, 30);
			this.PicturePath.TabIndex = 4;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.button1.Location = new System.Drawing.Point(580, 139);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(60, 31);
			this.button1.TabIndex = 5;
			this.button1.Text = "...";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// SaveData
			// 
			this.SaveData.AutoSize = true;
			this.SaveData.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.SaveData.Location = new System.Drawing.Point(76, 246);
			this.SaveData.Name = "SaveData";
			this.SaveData.Size = new System.Drawing.Size(129, 28);
			this.SaveData.TabIndex = 6;
			this.SaveData.Text = "保存数据";
			this.SaveData.UseVisualStyleBackColor = true;
			// 
			// DataPath
			// 
			this.DataPath.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.DataPath.Location = new System.Drawing.Point(188, 297);
			this.DataPath.Name = "DataPath";
			this.DataPath.Size = new System.Drawing.Size(370, 30);
			this.DataPath.TabIndex = 7;
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.button2.Location = new System.Drawing.Point(580, 298);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(60, 29);
			this.button2.TabIndex = 8;
			this.button2.Text = "...";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label1.Location = new System.Drawing.Point(596, 82);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 24);
			this.label1.TabIndex = 9;
			this.label1.Text = "天前";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label2.Location = new System.Drawing.Point(81, 139);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(110, 24);
			this.label2.TabIndex = 10;
			this.label2.Text = "保存路径";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label3.Location = new System.Drawing.Point(72, 301);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(110, 24);
			this.label3.TabIndex = 11;
			this.label3.Text = "保存路径";
			// 
			// FormSaveSet
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.DataPath);
			this.Controls.Add(this.SaveData);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.PicturePath);
			this.Controls.Add(this.AutoDeletionDay);
			this.Controls.Add(this.AutoDeletion);
			this.Controls.Add(this.SavePicture);
			this.Name = "FormSaveSet";
			this.Text = "FormSaveSet";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSaveSet_FormClosing);
			this.Load += new System.EventHandler(this.FormSaveSet_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox SavePicture;
		private System.Windows.Forms.CheckBox AutoDeletion;
		private System.Windows.Forms.TextBox AutoDeletionDay;
		private System.Windows.Forms.TextBox PicturePath;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.CheckBox SaveData;
		private System.Windows.Forms.TextBox DataPath;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
	}
}