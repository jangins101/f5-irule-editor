namespace iRuler.Dialogs
{
	partial class IndentionSettingsDialog
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IndentionSettingsDialog));
			this.checkBox_AutoIndent = new System.Windows.Forms.CheckBox();
			this.checkBox_UseTabs = new System.Windows.Forms.CheckBox();
			this.numericUpDown_TabSize = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.numericUpDown_IndentSize = new System.Windows.Forms.NumericUpDown();
			this.button_OK = new System.Windows.Forms.Button();
			this.button_Cancel = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_TabSize)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_IndentSize)).BeginInit();
			this.SuspendLayout();
			// 
			// checkBox_AutoIndent
			// 
			this.checkBox_AutoIndent.AutoSize = true;
			this.checkBox_AutoIndent.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox_AutoIndent.Location = new System.Drawing.Point(43, 68);
			this.checkBox_AutoIndent.Name = "checkBox_AutoIndent";
			this.checkBox_AutoIndent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.checkBox_AutoIndent.Size = new System.Drawing.Size(84, 17);
			this.checkBox_AutoIndent.TabIndex = 4;
			this.checkBox_AutoIndent.Text = "Auto Indent";
			this.checkBox_AutoIndent.UseVisualStyleBackColor = true;
			// 
			// checkBox_UseTabs
			// 
			this.checkBox_UseTabs.AutoSize = true;
			this.checkBox_UseTabs.Location = new System.Drawing.Point(57, 91);
			this.checkBox_UseTabs.Name = "checkBox_UseTabs";
			this.checkBox_UseTabs.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.checkBox_UseTabs.Size = new System.Drawing.Size(70, 17);
			this.checkBox_UseTabs.TabIndex = 5;
			this.checkBox_UseTabs.Text = "Use Tabs";
			this.checkBox_UseTabs.UseVisualStyleBackColor = true;
			// 
			// numericUpDown_TabSize
			// 
			this.numericUpDown_TabSize.Location = new System.Drawing.Point(79, 16);
			this.numericUpDown_TabSize.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
			this.numericUpDown_TabSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown_TabSize.Name = "numericUpDown_TabSize";
			this.numericUpDown_TabSize.Size = new System.Drawing.Size(45, 21);
			this.numericUpDown_TabSize.TabIndex = 1;
			this.numericUpDown_TabSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(21, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(51, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tab Size:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(10, 44);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(65, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Indent Size:";
			// 
			// numericUpDown_IndentSize
			// 
			this.numericUpDown_IndentSize.Location = new System.Drawing.Point(79, 42);
			this.numericUpDown_IndentSize.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
			this.numericUpDown_IndentSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown_IndentSize.Name = "numericUpDown_IndentSize";
			this.numericUpDown_IndentSize.Size = new System.Drawing.Size(45, 21);
			this.numericUpDown_IndentSize.TabIndex = 3;
			this.numericUpDown_IndentSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// button_OK
			// 
			this.button_OK.Location = new System.Drawing.Point(147, 28);
			this.button_OK.Name = "button_OK";
			this.button_OK.Size = new System.Drawing.Size(75, 23);
			this.button_OK.TabIndex = 6;
			this.button_OK.Text = "OK";
			this.button_OK.UseVisualStyleBackColor = true;
			this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
			// 
			// button_Cancel
			// 
			this.button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button_Cancel.Location = new System.Drawing.Point(147, 57);
			this.button_Cancel.Name = "button_Cancel";
			this.button_Cancel.Size = new System.Drawing.Size(75, 23);
			this.button_Cancel.TabIndex = 7;
			this.button_Cancel.Text = "Cancel";
			this.button_Cancel.UseVisualStyleBackColor = true;
			this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
			// 
			// IndentionSettingsDialog
			// 
			this.AcceptButton = this.button_OK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.button_Cancel;
			this.ClientSize = new System.Drawing.Size(259, 116);
			this.Controls.Add(this.button_Cancel);
			this.Controls.Add(this.button_OK);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.numericUpDown_IndentSize);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.numericUpDown_TabSize);
			this.Controls.Add(this.checkBox_UseTabs);
			this.Controls.Add(this.checkBox_AutoIndent);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "IndentionSettingsDialog";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Indention Settings";
			this.Load += new System.EventHandler(this.IndentionSettings_Load);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_TabSize)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_IndentSize)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox checkBox_AutoIndent;
		private System.Windows.Forms.CheckBox checkBox_UseTabs;
		private System.Windows.Forms.NumericUpDown numericUpDown_TabSize;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown numericUpDown_IndentSize;
		private System.Windows.Forms.Button button_OK;
		private System.Windows.Forms.Button button_Cancel;
	}
}