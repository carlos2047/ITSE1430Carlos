﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterCreator.Winforms
{
    public partial class CharacterForm : Form
    {
        public CharacterForm()
        {
            InitializeComponent();
        }

        public Character Character { get; set; }

        private void OnCancel(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
                private void CharacterForm_Load(object sender, EventArgs e)
        {
            if (Character != null)
            {
                _txtName.Text = Character.Name;
                _cbxProf.Text = Character.Profession;
                _cbxRace.Text = Character.Race;
                _txtStrength.Text = Character.Strength.ToString();
                _txtIntel.Text = Character.Intelligence.ToString();
                _txtAgility.Text = Character.Agility.ToString();
                _txtConst.Text = Character.Constitution.ToString();
                _txtCharisma.Text = Character.Charisma.ToString();
                _txtDesc.Text = Character.Description;
            };

            ValidateChildren();
        }

        private void OnSave(object sender, EventArgs e)
        {
            if (!ValidateChildren())
                return;

            var character = new Character();
            character.Name = _txtName.Text;
            character.Profession = _cbxProf.Text;
            character.Race = _cbxRace.Text;
            character.Strength = GetInt32(_txtStrength);
            character.Intelligence = GetInt32(_txtIntel);
            character.Agility = GetInt32(_txtAgility);
            character.Constitution = GetInt32(_txtConst);
            character.Charisma = GetInt32(_txtCharisma);
            character.Description = _txtDesc.Text;

            Character = character;
            DialogResult = DialogResult.OK;
            Close();

        }
        private int GetInt32(TextBox textBox)
        {
            if (String.IsNullOrEmpty(textBox.Text))
                return 0;

            if (Int32.TryParse(textBox.Text, out var value))
                return value;

            return -1;
        }
        private void OnValidateName(object sender, CancelEventArgs e)
        {
            var control = sender as TextBox;
            if (String.IsNullOrEmpty(control.Text))
            {
                _errors.SetError(control, "Name is Required");
                e.Cancel = true;
            }
            else
                _errors.SetError(control, "");
        }
        private void OnValidateAttributes(object sender, CancelEventArgs e)
        {
            var control = sender as TextBox;
            var result = GetInt32(control);
            if (result < 0 || result > 100 || String.IsNullOrEmpty(control.Text))
            {
                _errors.SetError(control, "Must be between 0 and 100");
                e.Cancel = true;
            }
            else
                _errors.SetError(control, "");
        }
        private void OnValidateDropDown(object sender, CancelEventArgs e)
        {
            var control = sender as ComboBox;
            if (String.IsNullOrEmpty(control.Text))
            {
                _errors.SetError(control, "Choice is Required");
                e.Cancel = true;
            }
            else
                _errors.SetError(control, "");
        }
    }
}
