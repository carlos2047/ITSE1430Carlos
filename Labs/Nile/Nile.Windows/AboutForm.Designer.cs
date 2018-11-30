namespace Nile.Windows
{
	partial class AboutForm
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
            this.OnOk = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // OnOk
            // 
            this.OnOk.Location = new System.Drawing.Point(73, 84);
            this.OnOk.Margin = new System.Windows.Forms.Padding(2);
            this.OnOk.Name = "OnOk";
            this.OnOk.Size = new System.Drawing.Size(56, 19);
            this.OnOk.TabIndex = 3;
            this.OnOk.Text = "OK";
            this.OnOk.UseVisualStyleBackColor = true;
            this.OnOk.Click += new System.EventHandler(this.OnOk_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Carlos Fuentes",
            "Fall 2018",
            "ITSE 1430"});
            this.listBox1.Location = new System.Drawing.Point(32, 10);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(138, 56);
            this.listBox1.TabIndex = 4;
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(201, 122);
            this.ControlBox = false;
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.OnOk);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(217, 161);
            this.MinimumSize = new System.Drawing.Size(217, 161);
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button OnOk;
		private System.Windows.Forms.ListBox listBox1;
	}
}