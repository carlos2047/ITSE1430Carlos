using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterCreator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void OnExit(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Close", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Carlos Fuentes\nITSE 1430\nCharacter Creator", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
