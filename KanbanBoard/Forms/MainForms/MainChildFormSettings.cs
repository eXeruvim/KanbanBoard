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
    public partial class MainChildFormSettings : Form
    {
        public MainChildFormSettings()
        {
            InitializeComponent();

            label8.Text = (Auth.mail);
            label7.Text = (Auth.usname);
            label9.Text = (Auth.log);
        }

   
    }
}
