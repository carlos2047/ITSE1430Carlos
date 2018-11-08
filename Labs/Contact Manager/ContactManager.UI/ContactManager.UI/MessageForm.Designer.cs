namespace ContactManager.UI
{
	partial class MessageForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this._txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._txtSubject = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this._txtMessage = new System.Windows.Forms.TextBox();
            this.OnSend = new System.Windows.Forms.Button();
            this.OnCancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this._txtEmailAddress = new System.Windows.Forms.TextBox();
            this._errors = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this._errors)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // _txtName
            // 
            this._txtName.Location = new System.Drawing.Point(22, 28);
            this._txtName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._txtName.Name = "_txtName";
            this._txtName.ReadOnly = true;
            this._txtName.Size = new System.Drawing.Size(182, 20);
            this._txtName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Subject";
            // 
            // _txtSubject
            // 
            this._txtSubject.Location = new System.Drawing.Point(22, 117);
            this._txtSubject.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._txtSubject.Name = "_txtSubject";
            this._txtSubject.Size = new System.Drawing.Size(182, 20);
            this._txtSubject.TabIndex = 0;
            this._txtSubject.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidatingSubject);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 145);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Message";
            // 
            // _txtMessage
            // 
            this._txtMessage.Location = new System.Drawing.Point(22, 162);
            this._txtMessage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._txtMessage.Multiline = true;
            this._txtMessage.Name = "_txtMessage";
            this._txtMessage.Size = new System.Drawing.Size(182, 76);
            this._txtMessage.TabIndex = 1;
            // 
            // OnSend
            // 
            this.OnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OnSend.Location = new System.Drawing.Point(24, 254);
            this.OnSend.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OnSend.Name = "OnSend";
            this.OnSend.Size = new System.Drawing.Size(75, 26);
            this.OnSend.TabIndex = 2;
            this.OnSend.Text = "Send";
            this.OnSend.UseVisualStyleBackColor = true;
            this.OnSend.Click += new System.EventHandler(this.OnSend_Click);
            // 
            // OnCancel
            // 
            this.OnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OnCancel.Location = new System.Drawing.Point(128, 254);
            this.OnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OnCancel.Name = "OnCancel";
            this.OnCancel.Size = new System.Drawing.Size(75, 26);
            this.OnCancel.TabIndex = 3;
            this.OnCancel.Text = "Cancel";
            this.OnCancel.UseVisualStyleBackColor = true;
            this.OnCancel.Click += new System.EventHandler(this.OnCancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 55);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Email Address";
            // 
            // _txtEmailAddress
            // 
            this._txtEmailAddress.Location = new System.Drawing.Point(22, 72);
            this._txtEmailAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._txtEmailAddress.Name = "_txtEmailAddress";
            this._txtEmailAddress.ReadOnly = true;
            this._txtEmailAddress.Size = new System.Drawing.Size(182, 20);
            this._txtEmailAddress.TabIndex = 6;
            // 
            // _errors
            // 
            this._errors.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this._errors.ContainerControl = this;
            // 
            // MessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(230, 305);
            this.Controls.Add(this._txtEmailAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.OnCancel);
            this.Controls.Add(this.OnSend);
            this.Controls.Add(this._txtMessage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._txtSubject);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._txtName);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(246, 344);
            this.Name = "MessageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Send Message";
            this.Load += new System.EventHandler(this.MessageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this._errors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox _txtSubject;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox _txtMessage;
		private System.Windows.Forms.Button OnSend;
		private System.Windows.Forms.Button OnCancel;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox _txtEmailAddress;
		private System.Windows.Forms.TextBox _txtName;
		private System.Windows.Forms.ErrorProvider _errors;
	}
}