using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading;
using System.Windows.Forms;


namespace SuperBingao
{
    public partial class Form3 : Form
    {
        private Timer timer;
        public Form3()
        {
            InitializeComponent();
            

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Form1 Mform1 = (Form1)Application.OpenForms.OfType<Form1>().FirstOrDefault();
            int number = int.Parse(Mform1.TextoUltimaBola.Text);
            string caminho = @"C:\SuperBingao\Bolas\im" + number.ToString("D2") + ".jpg";
            //LogoImage.BackgroundImage(caminho);
            Image imagem = Image.FromFile(caminho);

            // Define a imagem como a imagem de fundo do controle de imagem
            ImageLogo.Image = imagem;


            //Thread n funcionou no computador
            //Thread.Sleep(6000);
            //Close();

            timer = new Timer();
            timer.Interval = 6000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            Close();
            //timer.Stop();

        }

        private void ImageLogo_Click(object sender, EventArgs e)
        {

        }

        
    }
}
