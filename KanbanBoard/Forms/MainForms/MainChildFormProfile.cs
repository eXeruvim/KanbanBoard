using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace KanbanBoard.Forms
{
    public partial class MainChildFormProfile : Form
    {

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "EalE4Ra04uGQuLuA0zEhemNqzL2q0kAxzhJxHZrt",
            BasePath = "https://kanbanboard-c892f-default-rtdb.europe-west1.firebasedatabase.app/"
        };
        IFirebaseClient client;

        public MainChildFormProfile()
        {
            InitializeComponent();
        }

       /* protected override void OnPaint(PaintEventArgs e)
        {
            Bitmap temp = new Bitmap(cur, 500, 500);
            GraphicsPath clipPath = new GraphicsPath();
            clipPath.AddPolygon(new Point[] { new Point(0, temp.Height / 2), new Point(temp.Width / 2, 0), new Point(temp.Width, temp.Height / 2), new Point(temp.Width / 2, temp.Height) });
            e.Graphics.SetClip(clipPath, CombineMode.Intersect);
            e.Graphics.DrawImage(temp, 0, 0);
        } */

        
    }
}
