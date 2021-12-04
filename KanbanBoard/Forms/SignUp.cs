using System;
using System.Drawing;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace KanbanBoard.Forms
{
    public partial class SignUp : Form
    {
        public bool connectionState = false;
        IFirebaseConfig firebaseConfig = new FirebaseConfig()
        {
            AuthSecret = "EalE4Ra04uGQuLuA0zEhemNqzL2q0kAxzhJxHZrt",
            BasePath = "https://kanbanboard-c892f-default-rtdb.europe-west1.firebasedatabase.app/"
        };
        IFirebaseClient client;
        public bool makeConnection()
        {
            client = new FireSharp.FirebaseClient(firebaseConfig);

            if (client == null)
            {
                MessageBox.Show("Connection to server not established!");
                return false;
            }

            return true;
        }
        public async void sendData(Object data, String login)
        {

            if (makeConnection())
                try
                {
                    // Отправка на сервер
                    SetResponse response = await client.SetTaskAsync("Users/" + login, data);
                    Data result = response.ResultAs<Data>();

                    connectionState = true;
                    MessageBox.Show("Регистрация прошла успешно, " + result.login);
                    name_textBox.Text = string.Empty;
                    login_textBox.Text = string.Empty;
                    email_textBox.Text = string.Empty;
                    pass_textBox.Text = string.Empty;
                    pictureBox1.Image = this.CreateImage(pictureBox1.Width, pictureBox1.Height);
                    captcha_textBox.Text = string.Empty;
                    Form auth = Application.OpenForms[0];
                    auth.Show();
                    this.Close();
                }
                catch
                {
                    connectionState = false;
                    MessageBox.Show("Не удалось соединиться с сервером");
                }
        }

        // ---------------
        private String text;
        public SignUp()
        {
            InitializeComponent();
        }

        private void acceptBtn(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(name_textBox.Text) && !string.IsNullOrEmpty(login_textBox.Text) && !string.IsNullOrEmpty(email_textBox.Text) && !string.IsNullOrEmpty(pass_textBox.Text))
                if (captcha_textBox.Text == this.text)
                {
                    String login = login_textBox.Text;
                    var data = new Data
                    {
                        name = name_textBox.Text,
                        login = login_textBox.Text,
                        email = email_textBox.Text,
                        password = pass_textBox.Text,
                    };
                    sendData(data, login);
                }
                else
                {
                    MessageBox.Show("Неправильная капча!");

                }
            else
                MessageBox.Show("Не все поля заполнены!");
        }

        private Bitmap CreateImage(int Width, int Height)
        {
            Random rnd = new Random();
            //Создадим изображение
            Bitmap result = new Bitmap(Width, Height);

            //Вычислим позицию текста
            int Xpos = 10;
            int Ypos = 10;

            //Добавим различные цвета ддя текста
            Brush[] colors = {
                            Brushes.Black,
                            Brushes.Red,
                            Brushes.RoyalBlue,
                            Brushes.Green,
                            Brushes.Yellow,
                            Brushes.White,
                            Brushes.Tomato,
                            Brushes.Sienna,
                            Brushes.Pink };

            //Добавим различные цвета линий
            Pen[] colorpens = {
                            Pens.Black,
                            Pens.Red,
                            Pens.RoyalBlue,
                            Pens.Green,
                            Pens.Yellow,
                            Pens.White,
                            Pens.Tomato,
                            Pens.Sienna,
                            Pens.Pink };

            //Делаем случайный стиль текста
            FontStyle[] fontstyle = {
                            FontStyle.Bold,
                            FontStyle.Italic,
                            FontStyle.Regular,
                            FontStyle.Strikeout,
                            FontStyle.Underline};

            //Добавим различные углы поворота текста
            Int16[] rotate = { 1, -1, 2, -2, 3, -3, 4, -4, 5, -5, 6, -6 };

            //Укажем где рисовать
            Graphics g = Graphics.FromImage((Image)result);

            //Пусть фон картинки будет серым
            g.Clear(Color.Gray);

            //Делаем случайный угол поворота текста
            g.RotateTransform(rnd.Next(rotate.Length));

            //Генерируем текст
            text = String.Empty;
            string ALF = "7890QWERTYUIOPASDFGHJKLZXCVBNM";
            for (int i = 0; i < 5; ++i)
                text += ALF[rnd.Next(ALF.Length)];

            //Нарисуем сгенирируемый текст
            g.DrawString(text,
            new Font("Arial", 25, fontstyle[rnd.Next(fontstyle.Length)]),
            colors[rnd.Next(colors.Length)],
            new PointF(Xpos, Ypos));

            //Добавим немного помех
            //Линии из углов
            g.DrawLine(colorpens[rnd.Next(colorpens.Length)],
            new Point(0, 0),
            new Point(Width - 1, Height - 1));
            g.DrawLine(colorpens[rnd.Next(colorpens.Length)],
            new Point(0, Height - 1),
            new Point(Width - 1, 0));

            //Белые точки
            for (int i = 0; i < Width; ++i)
                for (int j = 0; j < Height; ++j)
                    if (rnd.Next() % 20 == 0)
                        result.SetPixel(i, j, Color.White);

            return result;
        }

        private void reloadCaptcha(object sender, EventArgs e)
        {
            reloadCaptcha();
        }

        public void reloadCaptcha()
        {
            pictureBox1.Image = this.CreateImage(pictureBox1.Width, pictureBox1.Height);
            captcha_textBox.Text = "";
        }

        private void LogUp_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = this.CreateImage(pictureBox1.Width, pictureBox1.Height);
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Form auth = Application.OpenForms[0];
            auth.Show();
            this.Close();
        }

        private void SignUp_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form auth = Application.OpenForms[0];
            auth.Show();
            this.Close();
        }
    }
}
