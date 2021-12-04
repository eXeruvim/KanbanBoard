using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanbanBoard
{
    class Data
    {
        public string name { get; set; }
        public string login { get; set; }
        public string email { get; set; }
        public string password { get; set; }

        private static string error = "Ошибка";

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
            if (data1.login != data2.login)
            {
                error = "Пользователь " + data1.login + " не найден.";
                return false;
            }
            if (data1.password != data2.password)
            {
                error = "Неправильный пароль";
                return false;
            }

            return true;
        }
    }
}
