using System;
using System.Windows.Forms;

namespace KanbanBoard.Utils
{
    public static class Extensions
    {
        public static void ToCenter(this Control control, Control where)
        {
            control.Left = (where.Width - control.Width) / 2;
            control.Top = (where.Height - control.Height) / 2;
        }

        public static string FirstCharToUpper(this string input)
        {
            switch (input) 
            {
                case null: throw new ArgumentNullException(nameof(input));
                case "": throw new ArgumentException($"{nameof(input)}", nameof(input));
                default: return input[0].ToString().ToUpper() + input.Substring(1);
            }
        }
    }
}
