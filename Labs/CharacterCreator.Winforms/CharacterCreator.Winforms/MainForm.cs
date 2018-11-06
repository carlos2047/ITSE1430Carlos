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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OnFileExit(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?",
                        "Close", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            Close();
        }

        private void OnHelpAbout(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Carlos Fuentes\nITSE1430\nCharacter Creator", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void OnCharacterNew(object sender, EventArgs e)
        {
            var form = new CharacterForm();

            if (form.ShowDialog(this) == DialogResult.Cancel)
                return;
            _database.Add(form.Character);
            RefreshCharacters();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            _listCharacters.DisplayMember = "Name";
            RefreshCharacters();
        }
        private void RefreshCharacters()
        {
            var characters = _database.GetAll();

            _listCharacters.Items.Clear();
            _listCharacters.Items.AddRange(characters);
        }

        private CharacterDatabase _database = new CharacterDatabase();

        private void OnCharacterEdit(object sender, EventArgs e)
        {
            EditCharacter();
        }
        private void OnCharacterDelete(object sender, EventArgs e)
        {
            DeleteCharacter();
        }
        private Character GetSelectedCharacter()
        {
            return _listCharacters.SelectedItem as Character;
        }
        private void OnDoubleClick(object sender, EventArgs e)
        {
            EditCharacter();
        }
        private void EditCharacter()
        {
            // Get selected name, if any
            var item = GetSelectedCharacter();
            if (item == null)
                return;

            // Show form with selected name
            var form = new CharacterForm();
            form.Character = item;
            if (form.ShowDialog(this) == DialogResult.Cancel)
                return;

            // Update database and refresh
            _database.Edit(item.Name, form.Character);
            RefreshCharacters();
        }

        private void DeleteCharacter()
        {
            // Get selected name, if any
            var itemName = GetSelectedCharacter();
            if (itemName == null)
                return;

            if (MessageBox.Show($"Do you want to delete {itemName.Name}?", "Delete Character", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            // Remove from database and refresh
            _database.Remove(itemName.Name);
            RefreshCharacters();
        }

        private void _listCharacters_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                DeleteCharacter();
            }
        }
    }
}
