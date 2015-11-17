namespace ScreenTimeClient
{
	partial class MainForm
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
			this.bRegisterTimeChunk = new System.Windows.Forms.Button();
			this.bLogin = new System.Windows.Forms.Button();
			this.lHello = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// bRegisterTimeChunk
			// 
			this.bRegisterTimeChunk.Location = new System.Drawing.Point(12, 76);
			this.bRegisterTimeChunk.Name = "bRegisterTimeChunk";
			this.bRegisterTimeChunk.Size = new System.Drawing.Size(156, 23);
			this.bRegisterTimeChunk.TabIndex = 0;
			this.bRegisterTimeChunk.Text = "Register some Time Chunk";
			this.bRegisterTimeChunk.UseVisualStyleBackColor = true;
			this.bRegisterTimeChunk.Click += new System.EventHandler(this.bRegisterTimeChunk_Click);
			// 
			// bLogin
			// 
			this.bLogin.Location = new System.Drawing.Point(12, 47);
			this.bLogin.Name = "bLogin";
			this.bLogin.Size = new System.Drawing.Size(156, 23);
			this.bLogin.TabIndex = 1;
			this.bLogin.Text = "Login";
			this.bLogin.UseVisualStyleBackColor = true;
			this.bLogin.Click += new System.EventHandler(this.bLogin_Click);
			// 
			// label1
			// 
			this.lHello.AutoSize = true;
			this.lHello.Location = new System.Drawing.Point(9, 9);
			this.lHello.Name = "lHello";
			this.lHello.Size = new System.Drawing.Size(63, 13);
			this.lHello.TabIndex = 2;
			this.lHello.Text = "please login";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(1031, 1053);
			this.Controls.Add(this.lHello);
			this.Controls.Add(this.bLogin);
			this.Controls.Add(this.bRegisterTimeChunk);
			this.Name = "MainForm";
			this.Text = "ScreenTimeClient";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button bRegisterTimeChunk;
		private System.Windows.Forms.Button bLogin;
		private System.Windows.Forms.Label lHello;
	}
}

