using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOO_Test
{
    public partial class FormAuthorization : Form
    {
        private static string valueCaptcha;
        public FormAuthorization()
        {
            InitializeComponent();
            if (SQLHelper.IsConnected() == false)
                Application.Exit();
            string[] symbols = GenerateSymbols(4);
            CreateCaptcha(symbols);
            valueCaptcha = CaptchaToString(symbols);
            
        }

        private void CreateCaptcha(string[] captcha)
        {
            int fontSize = 18;
            int amountSymbols = captcha.Length;
            int placeSymbolX = 0;
            int placeSymbolY = 0;
            int widthCaptcha = pictureBoxCaptcha.Width;
            int heightCaptcha = pictureBoxCaptcha.Height;

            Random randomPlaceSymbol = new Random();
            Bitmap bitmapCaptcha = new Bitmap(widthCaptcha, heightCaptcha);
            Graphics paintCaptcha = Graphics.FromImage(bitmapCaptcha);
            Font fontCaptcha = new Font("Georgia", fontSize);

            paintCaptcha.Clear(Color.White);
            paintCaptcha.SmoothingMode = SmoothingMode.AntiAlias;
            for (int i = 0; i < amountSymbols; i++)
            {
                placeSymbolX = randomPlaceSymbol.Next(placeSymbolX + (fontSize / 2), placeSymbolX + fontSize * 2);
                placeSymbolY = randomPlaceSymbol.Next(0, heightCaptcha - fontSize * 2);
                paintCaptcha.DrawString(captcha[i], fontCaptcha, Brushes.Black, placeSymbolX, placeSymbolY);
                paintCaptcha.DrawLine(Pens.Black, placeSymbolX, placeSymbolY, 
                    randomPlaceSymbol.Next(placeSymbolX, widthCaptcha), randomPlaceSymbol.Next(placeSymbolY, heightCaptcha));
            }
            
            paintCaptcha.Flush();
            pictureBoxCaptcha.Image = bitmapCaptcha;
        }

        private string[] GenerateSymbols(int amountSymbols)
        {
            string[] symbols = new string[amountSymbols];
            string stringSymbols = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random randomNumberSymbol = new Random();
            for (int i = 0; i < amountSymbols; i++)
            {
                symbols[i] = stringSymbols[randomNumberSymbol.Next(0, stringSymbols.Length)].ToString();
            }
            return symbols;

        }

        private string CaptchaToString(string[] captcha)
        {
            string stringCaptcha = "";
            foreach (string symbol in captcha)
                stringCaptcha += symbol;
            return stringCaptcha;
        }

        private void buttonAuthExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonAuthGuest_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Произведён вход в гостевой аккаунт", "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonAuth_Click(object sender, EventArgs e)
        {
            string[] user = new string[7];
            user = SQLHelper.ReadOneLine("[User]", "[UserLogin]", textBoxLogin.Text, "*");
            if (user == null)
            {
                MessageBox.Show("Пользователь не найден", "Ошибка входа в аккаунт", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (user[5] == textBoxPassword.Text)
            {
                MessageBox.Show("Произведен вход в аккаунт", "Вход в аккаунт", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
