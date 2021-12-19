using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KanbanBoard.Forms
{
    public partial class CreationForm : Form
    {
        string key;
        public CreationForm()
        {
            InitializeComponent();
        }

        private void AC_button_Click(object sender, EventArgs e)
        {
            key = Encrypting.sha256(PN_textBox.Text + Auth.log);
            key_richTextBox.Text = key;
        }
    }
}
