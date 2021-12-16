using System.Windows.Forms;

namespace KanbanBoard.Utils
{
    public static class Util
    {
        public static void ToCenter(this Control control, Control where)
        {
            control.Left = (where.Width - control.Width) / 2;
            control.Top = (where.Height - control.Height) / 2;
        }
    }
}
