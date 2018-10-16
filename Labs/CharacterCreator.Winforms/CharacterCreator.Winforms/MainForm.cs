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
            //aboutToolStripMenuItem.
            MessageBox.Show(this, "Carlos Fuentes\nITSE1430\nCharacter Creator", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void OnCharacterNew(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Carlos Fuentes\nITSE 1430\nCharacter Creator", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
