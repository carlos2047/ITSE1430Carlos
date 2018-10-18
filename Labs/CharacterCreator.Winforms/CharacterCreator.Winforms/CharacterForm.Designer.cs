namespace CharacterCreator.Winforms
{
    partial class CharacterForm
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
            this.labelName = new System.Windows.Forms.Label();
            this._txtName = new System.Windows.Forms.TextBox();
            this.labelProfession = new System.Windows.Forms.Label();
            this.labelRace = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._txtAgility = new System.Windows.Forms.TextBox();
            this.labelIntelligence = new System.Windows.Forms.Label();
            this._txtIntel = new System.Windows.Forms.TextBox();
            this.labelStrength = new System.Windows.Forms.Label();
            this._txtStrength = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this._txtDesc = new System.Windows.Forms.TextBox();
            this.labelCharisma = new System.Windows.Forms.Label();
            this._txtCharisma = new System.Windows.Forms.TextBox();
            this.labelConstitution = new System.Windows.Forms.Label();
            this._txtConst = new System.Windows.Forms.TextBox();
            this._cbxProf = new System.Windows.Forms.ComboBox();
            this._cbxRace = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this._errors = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this._errors)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(42, 15);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Name";
            // 
            // _txtName
            // 
            this._txtName.Location = new System.Drawing.Point(95, 12);
            this._txtName.Name = "_txtName";
            this._txtName.Size = new System.Drawing.Size(155, 20);
            this._txtName.TabIndex = 2;
            this._txtName.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidateName);
            // 
            // labelProfession
            // 
            this.labelProfession.AutoSize = true;
            this.labelProfession.Location = new System.Drawing.Point(21, 54);
            this.labelProfession.Name = "labelProfession";
            this.labelProfession.Size = new System.Drawing.Size(56, 13);
            this.labelProfession.TabIndex = 5;
            this.labelProfession.Text = "Profession";
            // 
            // labelRace
            // 
            this.labelRace.AutoSize = true;
            this.labelRace.Location = new System.Drawing.Point(44, 97);
            this.labelRace.Name = "labelRace";
            this.labelRace.Size = new System.Drawing.Size(33, 13);
            this.labelRace.TabIndex = 7;
            this.labelRace.Text = "Race";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Agility";
            // 
            // _txtAgility
            // 
            this._txtAgility.Location = new System.Drawing.Point(95, 206);
            this._txtAgility.Name = "_txtAgility";
            this._txtAgility.Size = new System.Drawing.Size(35, 20);
            this._txtAgility.TabIndex = 12;
            this._txtAgility.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidateAttributes);
            // 
            // labelIntelligence
            // 
            this.labelIntelligence.AutoSize = true;
            this.labelIntelligence.Location = new System.Drawing.Point(16, 166);
            this.labelIntelligence.Name = "labelIntelligence";
            this.labelIntelligence.Size = new System.Drawing.Size(61, 13);
            this.labelIntelligence.TabIndex = 11;
            this.labelIntelligence.Text = "Intelligence";
            // 
            // _txtIntel
            // 
            this._txtIntel.Location = new System.Drawing.Point(95, 163);
            this._txtIntel.Name = "_txtIntel";
            this._txtIntel.Size = new System.Drawing.Size(35, 20);
            this._txtIntel.TabIndex = 10;
            this._txtIntel.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidateAttributes);
            // 
            // labelStrength
            // 
            this.labelStrength.AutoSize = true;
            this.labelStrength.Location = new System.Drawing.Point(30, 130);
            this.labelStrength.Name = "labelStrength";
            this.labelStrength.Size = new System.Drawing.Size(47, 13);
            this.labelStrength.TabIndex = 9;
            this.labelStrength.Text = "Strength";
            // 
            // _txtStrength
            // 
            this._txtStrength.Location = new System.Drawing.Point(95, 127);
            this._txtStrength.Name = "_txtStrength";
            this._txtStrength.Size = new System.Drawing.Size(35, 20);
            this._txtStrength.TabIndex = 8;
            this._txtStrength.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidateAttributes);
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(17, 325);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(60, 13);
            this.labelDescription.TabIndex = 19;
            this.labelDescription.Text = "Description";
            // 
            // _txtDesc
            // 
            this._txtDesc.Location = new System.Drawing.Point(95, 325);
            this._txtDesc.Multiline = true;
            this._txtDesc.Name = "_txtDesc";
            this._txtDesc.Size = new System.Drawing.Size(240, 107);
            this._txtDesc.TabIndex = 18;
            // 
            // labelCharisma
            // 
            this.labelCharisma.AutoSize = true;
            this.labelCharisma.Location = new System.Drawing.Point(27, 285);
            this.labelCharisma.Name = "labelCharisma";
            this.labelCharisma.Size = new System.Drawing.Size(50, 13);
            this.labelCharisma.TabIndex = 17;
            this.labelCharisma.Text = "Charisma";
            // 
            // _txtCharisma
            // 
            this._txtCharisma.Location = new System.Drawing.Point(95, 282);
            this._txtCharisma.Name = "_txtCharisma";
            this._txtCharisma.Size = new System.Drawing.Size(35, 20);
            this._txtCharisma.TabIndex = 16;
            this._txtCharisma.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidateAttributes);
            // 
            // labelConstitution
            // 
            this.labelConstitution.AutoSize = true;
            this.labelConstitution.Location = new System.Drawing.Point(15, 249);
            this.labelConstitution.Name = "labelConstitution";
            this.labelConstitution.Size = new System.Drawing.Size(62, 13);
            this.labelConstitution.TabIndex = 15;
            this.labelConstitution.Text = "Constitution";
            // 
            // _txtConst
            // 
            this._txtConst.Location = new System.Drawing.Point(95, 246);
            this._txtConst.Name = "_txtConst";
            this._txtConst.Size = new System.Drawing.Size(35, 20);
            this._txtConst.TabIndex = 14;
            this._txtConst.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidateAttributes);
            // 
            // _cbxProf
            // 
            this._cbxProf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbxProf.FormattingEnabled = true;
            this._cbxProf.Location = new System.Drawing.Point(95, 51);
            this._cbxProf.Name = "_cbxProf";
            this._cbxProf.Size = new System.Drawing.Size(121, 21);
            this._cbxProf.TabIndex = 20;
            this._cbxProf.SelectedIndexChanged += new System.EventHandler(this._cbxProf_SelectedIndexChanged);
            // 
            // _cbxRace
            // 
            this._cbxRace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbxRace.FormattingEnabled = true;
            this._cbxRace.Location = new System.Drawing.Point(95, 94);
            this._cbxRace.Name = "_cbxRace";
            this._cbxRace.Size = new System.Drawing.Size(121, 21);
            this._cbxRace.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(179, 459);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OnSave);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(260, 459);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 23;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.OnCancel);
            // 
            // _errors
            // 
            this._errors.ContainerControl = this;
            // 
            // CharacterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(349, 500);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this._cbxRace);
            this.Controls.Add(this._cbxProf);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this._txtDesc);
            this.Controls.Add(this.labelCharisma);
            this.Controls.Add(this._txtCharisma);
            this.Controls.Add(this.labelConstitution);
            this.Controls.Add(this._txtConst);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._txtAgility);
            this.Controls.Add(this.labelIntelligence);
            this.Controls.Add(this._txtIntel);
            this.Controls.Add(this.labelStrength);
            this.Controls.Add(this._txtStrength);
            this.Controls.Add(this.labelRace);
            this.Controls.Add(this.labelProfession);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this._txtName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CharacterForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create New Character";
            ((System.ComponentModel.ISupportInitialize)(this._errors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox _txtName;
        private System.Windows.Forms.Label labelProfession;
        private System.Windows.Forms.Label labelRace;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _txtAgility;
        private System.Windows.Forms.Label labelIntelligence;
        private System.Windows.Forms.TextBox _txtIntel;
        private System.Windows.Forms.Label labelStrength;
        private System.Windows.Forms.TextBox _txtStrength;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox _txtDesc;
        private System.Windows.Forms.Label labelCharisma;
        private System.Windows.Forms.TextBox _txtCharisma;
        private System.Windows.Forms.Label labelConstitution;
        private System.Windows.Forms.TextBox _txtConst;
        private System.Windows.Forms.ComboBox _cbxProf;
        private System.Windows.Forms.ComboBox _cbxRace;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.ErrorProvider _errors;
    }
}