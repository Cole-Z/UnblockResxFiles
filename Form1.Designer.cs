namespace UnblockResxFiles
{
	partial class Form1
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
			this.browseButton = new System.Windows.Forms.Button();
			this.directoryTextBox = new System.Windows.Forms.TextBox();
			this.unblockButton = new System.Windows.Forms.Button();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.btnProgressLbl = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// browseButton
			// 
			this.browseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.browseButton.Location = new System.Drawing.Point(49, 55);
			this.browseButton.Name = "browseButton";
			this.browseButton.Size = new System.Drawing.Size(84, 26);
			this.browseButton.TabIndex = 0;
			this.browseButton.Text = "Open Dir";
			this.browseButton.UseVisualStyleBackColor = true;
			this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
			// 
			// directoryTextBox
			// 
			this.directoryTextBox.BackColor = System.Drawing.SystemColors.Menu;
			this.directoryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.directoryTextBox.Location = new System.Drawing.Point(142, 57);
			this.directoryTextBox.Multiline = true;
			this.directoryTextBox.Name = "directoryTextBox";
			this.directoryTextBox.Size = new System.Drawing.Size(219, 20);
			this.directoryTextBox.TabIndex = 1;
			this.directoryTextBox.TextChanged += new System.EventHandler(this.directoryTextBox_TextChanged);
			// 
			// unblockButton
			// 
			this.unblockButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.unblockButton.Location = new System.Drawing.Point(49, 105);
			this.unblockButton.Name = "unblockButton";
			this.unblockButton.Size = new System.Drawing.Size(84, 27);
			this.unblockButton.TabIndex = 2;
			this.unblockButton.Text = "Unblock";
			this.unblockButton.UseVisualStyleBackColor = true;
			this.unblockButton.Click += new System.EventHandler(this.unblockButton_Click_1);
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(49, 138);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(312, 23);
			this.progressBar1.TabIndex = 3;
			this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
			// 
			// btnProgressLbl
			// 
			this.btnProgressLbl.AutoSize = true;
			this.btnProgressLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnProgressLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnProgressLbl.Location = new System.Drawing.Point(139, 114);
			this.btnProgressLbl.Name = "btnProgressLbl";
			this.btnProgressLbl.Size = new System.Drawing.Size(56, 20);
			this.btnProgressLbl.TabIndex = 4;
			this.btnProgressLbl.Text = "Status";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(65)))));
			this.ClientSize = new System.Drawing.Size(411, 188);
			this.Controls.Add(this.btnProgressLbl);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.unblockButton);
			this.Controls.Add(this.directoryTextBox);
			this.Controls.Add(this.browseButton);
			this.Name = "Form1";
			this.Text = "Resx Restore";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button browseButton;
		private System.Windows.Forms.TextBox directoryTextBox;
		private System.Windows.Forms.Button unblockButton;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Label btnProgressLbl;
	}
}

