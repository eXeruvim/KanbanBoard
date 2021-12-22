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
    public partial class OurBoards : Form
    {

        public OurBoards()
        {
            InitializeComponent();
            
        }

       

        private void OurBoards_Load(object sender, EventArgs e)
        {
            
        }


        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            
        }

        async void LiveCall()
        {
            while (true)
            {
                await Task.Delay(1000);
                
            }
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            String choice = comboBox1.Text;
            this.Close();
        }

     

    }
}
