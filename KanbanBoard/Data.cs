using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanbanBoard
{
    class Data
    {
        public string Name { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        private static string error = "Неправильный логин";

        public static void ShowError()
        {
            System.Windows.Forms.MessageBox.Show(error);
        }
        public static bool isEquals(Data data1, Data data2)
        {
            if (data1 == null || data2 == null)
            {
                return false;
            }
            if (data1.Login != data2.Login)
            {
                return false;
            }
            if (data1.Password != data2.Password)
            {
                error = "Неправильный пароль";
                return false;
            }

            return true;
        }
    }
}
