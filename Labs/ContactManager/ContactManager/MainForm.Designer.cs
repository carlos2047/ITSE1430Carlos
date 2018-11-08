namespace ContactManager.UI
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.OnFileExit = new System.Windows.Forms.ToolStripMenuItem();
			this.contactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.OnContactNew = new System.Windows.Forms.ToolStripMenuItem();
			this.OnSendMessage = new System.Windows.Forms.ToolStripMenuItem();
			this.OnContactEdit = new System.Windows.Forms.ToolStripMenuItem();
			this.OnContactDelete = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.OnHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.panel1 = new System.Windows.Forms.Panel();
			this._listContacts = new System.Windows.Forms.ListBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this._sentMessages = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.contactToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(520, 28);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OnFileExit});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// OnFileExit
			// 
			this.OnFileExit.Name = "OnFileExit";
			this.OnFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
			this.OnFileExit.Size = new System.Drawing.Size(161, 26);
			this.OnFileExit.Text = "Exit";
			this.OnFileExit.Click += new System.EventHandler(this.OnFileExit_Click);
			// 
			// contactToolStripMenuItem
			// 
			this.contactToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OnContactNew,
            this.OnSendMessage,
            this.OnContactEdit,
            this.OnContactDelete});
			this.contactToolStripMenuItem.Name = "contactToolStripMenuItem";
			this.contactToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
			this.contactToolStripMenuItem.Text = "&Contact";
			// 
			// OnContactNew
			// 
			this.OnContactNew.Name = "OnContactNew";
			this.OnContactNew.ShortcutKeys = System.Windows.Forms.Keys.Insert;
			this.OnContactNew.Size = new System.Drawing.Size(179, 26);
			this.OnContactNew.Text = "New";
			this.OnContactNew.Click += new System.EventHandler(this.OnContactNew_Click);
			// 
			// OnSendMessage
			// 
			this.OnSendMessage.Name = "OnSendMessage";
			this.OnSendMessage.Size = new System.Drawing.Size(179, 26);
			this.OnSendMessage.Text = "Send Message";
			this.OnSendMessage.Click += new System.EventHandler(this.OnSendMessage_Click);
			// 
			// OnContactEdit
			// 
			this.OnContactEdit.Name = "OnContactEdit";
			this.OnContactEdit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.OnContactEdit.Size = new System.Drawing.Size(179, 26);
			this.OnContactEdit.Text = "Edit";
			this.OnContactEdit.Click += new System.EventHandler(this.OnContactEdit_Click);
			// 
			// OnContactDelete
			// 
			this.OnContactDelete.Name = "OnContactDelete";
			this.OnContactDelete.Size = new System.Drawing.Size(179, 26);
			this.OnContactDelete.Text = "Delete";
			this.OnContactDelete.Click += new System.EventHandler(this.OnContactDelete_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OnHelpAbout});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
			this.helpToolStripMenuItem.Text = "&Help";
			// 
			// OnHelpAbout
			// 
			this.OnHelpAbout.Name = "OnHelpAbout";
			this.OnHelpAbout.ShortcutKeys = System.Windows.Forms.Keys.F1;
			this.OnHelpAbout.Size = new System.Drawing.Size(149, 26);
			this.OnHelpAbout.Text = "About";
			this.OnHelpAbout.Click += new System.EventHandler(this.OnHelpAbout_Click);
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.panel1.AutoScroll = true;
			this.panel1.Controls.Add(this._listContacts);
			this.panel1.Location = new System.Drawing.Point(13, 70);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(183, 208);
			this.panel1.TabIndex = 1;
			// 
			// _listContacts
			// 
			this._listContacts.Dock = System.Windows.Forms.DockStyle.Fill;
			this._listContacts.FormattingEnabled = true;
			this._listContacts.ItemHeight = 16;
			this._listContacts.Location = new System.Drawing.Point(0, 0);
			this._listContacts.Name = "_listContacts";
			this._listContacts.Size = new System.Drawing.Size(183, 208);
			this._listContacts.TabIndex = 0;
			this._listContacts.DoubleClick += new System.EventHandler(this.OnContactDoubleClick);
			// 
			// panel3
			// 
			this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel3.AutoScroll = true;
			this.panel3.Controls.Add(this._sentMessages);
			this.panel3.Location = new System.Drawing.Point(207, 70);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(302, 208);
			this.panel3.TabIndex = 3;
			// 
			// _sentMessages
			// 
			this._sentMessages.Dock = System.Windows.Forms.DockStyle.Fill;
			this._sentMessages.FormattingEnabled = true;
			this._sentMessages.ItemHeight = 16;
			this._sentMessages.Location = new System.Drawing.Point(0, 0);
			this._sentMessages.Name = "_sentMessages";
			this._sentMessages.Size = new System.Drawing.Size(302, 208);
			this._sentMessages.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(13, 47);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(76, 20);
			this.label1.TabIndex = 4;
			this.label1.Text = "Contacts";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(207, 47);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(125, 20);
			this.label2.TabIndex = 5;
			this.label2.Text = "Messages Sent";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(520, 282);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.menuStrip1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MainMenuStrip = this.menuStrip1;
			this.MinimumSize = new System.Drawing.Size(538, 329);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Contact Manager";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem OnFileExit;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem OnHelpAbout;
		private System.Windows.Forms.ToolStripMenuItem contactToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem OnContactNew;
		private System.Windows.Forms.ToolStripMenuItem OnContactEdit;
		private System.Windows.Forms.ToolStripMenuItem OnContactDelete;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.ListBox _listContacts;
		private System.Windows.Forms.ListBox _sentMessages;
		private System.Windows.Forms.ToolStripMenuItem OnSendMessage;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}

