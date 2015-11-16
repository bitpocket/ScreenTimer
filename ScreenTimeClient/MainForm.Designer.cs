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
			this.SuspendLayout();
			// 
			// bRegisterTimeChunk
			// 
			this.bRegisterTimeChunk.Location = new System.Drawing.Point(12, 12);
			this.bRegisterTimeChunk.Name = "bRegisterTimeChunk";
			this.bRegisterTimeChunk.Size = new System.Drawing.Size(156, 23);
			this.bRegisterTimeChunk.TabIndex = 0;
			this.bRegisterTimeChunk.Text = "bRegisterTimeChunk";
			this.bRegisterTimeChunk.UseVisualStyleBackColor = true;
			this.bRegisterTimeChunk.Click += new System.EventHandler(this.bRegisterTimeChunk_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(853, 288);
			this.Controls.Add(this.bRegisterTimeChunk);
			this.Name = "MainForm";
			this.Text = "ScreenTimeClient";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button bRegisterTimeChunk;
	}
}

