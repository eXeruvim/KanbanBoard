using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;

namespace KanbanBoard.Forms
{
    public partial class OurBoards : Form
    {
        public static string choice { get; set; }

        public OurBoards()
        {
            InitializeComponent();
            
        }

       IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "EalE4Ra04uGQuLuA0zEhemNqzL2q0kAxzhJxHZrt",
            BasePath = "https://kanbanboard-c892f-default-rtdb.europe-west1.firebasedatabase.app/"
        };
        IFirebaseClient client;

        private void OurBoards_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(config);
            }
            catch
            {
                MessageBox.Show("Ошибка соединения");
            }
        }


        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            FirebaseResponse res = client.Get(@"Projects/");
            Dictionary<string, UserBoards> data = JsonConvert.DeserializeObject<Dictionary<string, UserBoards>>(res.Body.ToString());
            UpdateRTB(data);
        }

        async void LiveCall()
        {
            while (true)
            {
                await Task.Delay(1000);
                
            }
        }

        void UpdateRTB(Dictionary<string, UserBoards> record)
        {
            comboBox1.Items.Clear();

            foreach (var item in record)
            {
                comboBox1.Items.Add(item.Value.projectKey);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String choice = comboBox1.Text;
        }

    }
}
