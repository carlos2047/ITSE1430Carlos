using System;
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

        private void OnSave(object sender, EventArgs e)
        {
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
    }
}
