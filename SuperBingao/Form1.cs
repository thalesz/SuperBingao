using System;
//using System.Timers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
//using System.Threading;
//using System.Threading;


namespace SuperBingao
{
    public partial class Form1 : Form
    {

        public int[] bolas = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75 };
        private object bolaSorteada;
        public int[] sorteadas = { };
        public bool sorteioIniciado = false;


        //implementar o cronometro
        private Timer timer, timerxcx;
        private int segundos = 0;
        


        public Form1()
        {
            InitializeComponent();
            timer = new Timer();
            timerxcx = new Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer_Tick);

            
            

        }
        private void timer_Tick(object sender, EventArgs e)
        {
            segundos++;
            TimeSpan tempo = TimeSpan.FromSeconds(segundos);
            TempoDecorrido.Text = tempo.ToString(@"hh\:mm\:ss");
        }


        private void  Form1_Load(object sender, EventArgs e)
        {
            string path = @"C:\SuperBingao\Dados\Validadas1.CSV";

            // This text is added only once to the file.
            if (!File.Exists(path))
            {
                // Create a file to write to.
                string[] createText = { "NUMERO;DIGITO;LOTE;LAN;D1;D2;D3;D4;D5;D6;D7;D8;D9;D10;D11;D12;D13;D14;D15" };
                File.WriteAllLines(path, createText);
            }

            // This text is always added, making the file longer over time
            // if it is not deleted.
            //string appendText = "This is extra text" + Environment.NewLine;
            //File.AppendAllText(path, appendText);

            // Open the file to read from.
            //string[] readText = File.ReadAllLines(path);
            //foreach (string s in readText)
            //{
            //    Console.WriteLine(s);
            //}
        }

    

        private void button76_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Lancar(Button clickedButton, int number)
        {
            //tira a bola dos que não foram sorteadas e coloca nas sorteadas
            if (sorteioIniciado)
            {

                this.bolas = this.bolas.Where(val => val != number).ToArray();
                this.sorteadas = this.sorteadas.Append(number).ToArray();

                //coloca na lista de sorteadas na tela
                if (String.IsNullOrEmpty(OrdemSorteio.Text))
                    OrdemSorteio.Text = Convert.ToString(number);
                else
                    OrdemSorteio.Text += ", " + Convert.ToString(number);

                //coloca na imagem de bola
                ///this.sorteadas = this.sorteadas.Append(number).ToArray();
                TextoUltimaBola.Text = Convert.ToString(number).PadLeft(2, '0');

                //Muda a cor da bola no botao do painel
                clickedButton.ForeColor = Color.Red;

                //Reproduz o som da bola
                if (checkBox_Som.Checked == true)
                {
                    System.Media.SoundPlayer myPlayer = new System.Media.SoundPlayer();
                    myPlayer.SoundLocation = @"C:\SuperBingao\Sons\sp" + number.ToString("D2") + ".wav";
                    myPlayer.Play();
                }
                if(checkBox_img.Checked == true)
                {
                  Form3 Form3 = new Form3();
                  Form3.ShowDialog();
                }

                //this.bolas = this.bolas.Where(val => val != number).ToArray();

                //atualiza o valor de cada
                TotalSorteadas.Text = sorteadas.Length.ToString();
                TotalRestantes.Text = (bolas.Length).ToString();
            }
            
        }
        private void Sortear_Click(object sender, EventArgs e)
        {
            
            if (this.RadioBotaoPedraPedra.Checked == true && this.sorteioIniciado)
            {   
                
                Random rnd = new Random();

                if (this.bolas.Length > 0)
                {
                    int indexAleatorio = rnd.Next(0, this.bolas.Length);
                    int bolaSorteada = this.bolas[indexAleatorio];
                    Button botaoSorteado = this.Controls.Find("BotaoBola" + bolaSorteada.ToString(), true).FirstOrDefault() as Button;
                    Lancar( botaoSorteado, bolaSorteada);

                }
            }
                        
        }

        

        private void Button_Click(object sender, EventArgs e)
        {
            if (this.RadioBotaoManual.Checked == true && this.sorteioIniciado)
            {
                Button clickedButton = (Button)sender; // obter o botão clicado
                int number = Convert.ToInt32(clickedButton.Name.Substring(9)); // extrair o número do nome do botão

                if (this.sorteadas.Contains(number))
                {
                    MessageBox.Show("Este número já foi sorteado!");
                    return;
                }
                else
                {
                    Lancar( clickedButton, number);
                }
            }
            

            
        }


        private void EntradaManual_TextChanged(object sender, EventArgs e)
        {
            if (this.sorteioIniciado)
            {
                string EntradaManual;
                EntradaManual = CaixaInsercaoManual.Text;
                //imprime o numero na TextBox Ordem de sorteio
                if (String.IsNullOrEmpty(OrdemSorteio.Text))
                    OrdemSorteio.Text = EntradaManual;
                else
                    OrdemSorteio.Text += ", " + EntradaManual;
                EntradaManual = "  ";
            }
            
        }
    
        
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13 )
            {
                int EntradaManual;
                EntradaManual = int.Parse(CaixaInsercaoManual.Text);

                //remove do bola sorteada e coloca no sorteadas
                if (sorteioIniciado){
                    if (this.sorteadas.Contains(EntradaManual))
                    {
                        MessageBox.Show("Este número já foi sorteado!");
                        return;
                    }
                    else
                    {
                        Button botaoSorteado = this.Controls.Find("BotaoBola" + EntradaManual.ToString(), true).FirstOrDefault() as Button;
                        Lancar(botaoSorteado, EntradaManual);
                    }
                }
                
                //imprime o numero na TextBox Ordem de sorteio
            }
        }

        private void numericUpDown1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //tecla maior e menor funcionando corretamente
            if (e.KeyChar == (char)43) //tecla +
            {
                AjustarTempoBola.UpButton();
            }
            if (e.KeyChar == (char)45) //tecla -
            {
                AjustarTempoBola.DownButton();
            }
        }


        private void RadioBotaoManual_CheckedChanged(object sender, EventArgs e)
        {
            this.CaixaInsercaoManual.Enabled = !this.CaixaInsercaoManual.Enabled;
            if (!this.AjustarTempoBola.Enabled)
            {
                this.AjustarTempoBola.Enabled=false;
            }
        }


        

        private void BotaoIniciarPausarSorteio_Click(object sender, EventArgs e)
        {
            //modifica os botões
            this.BotaoEncerrarSorteio.Enabled = true;
            this.BotaoPrepararSorteio.Enabled = false;
            this.BotaoConferirCartela.Enabled = true;
            this.BotaoBrindes.Enabled = true;
            this.sorteioIniciado = !this.sorteioIniciado;
            if (this.sorteioIniciado)
            {
                timer.Start();
                this.BotaoIniciarPausarSorteio.Text = "Pausar sorteio";
                if(radioButton3RadioBotaoAutomatico.Checked)
                {
                    this.AjustarTempoBola.Enabled = !this.AjustarTempoBola.Enabled;
                    int tempo = int.Parse(AjustarTempoBola.Text);
                    tempo = tempo * 1000;
                    timerxcx.Interval = tempo;
                    timerxcx.Tick += new EventHandler(aleatorio);
                    timerxcx.Start();
                }
            }
            else
            {
                
                timer.Stop();
                this.BotaoIniciarPausarSorteio.Text = "Continuar sorteio";
                if (radioButton3RadioBotaoAutomatico.Checked)
                {
                    this.AjustarTempoBola.Enabled = !this.AjustarTempoBola.Enabled;
                    timerxcx.Stop();
                }
            }


        }
        

        private void Form1_Load_1(object sender, EventArgs e)
        {
            //Desativas todos os botões
            this.BotaoIniciarPausarSorteio.Enabled = false;
            this.BotaoEncerrarSorteio.Enabled=false; 
            this.BotaoConferirCartela.Enabled=false;
            this.BotaoBrindes.Enabled = false;
            

            //atribui valores iniciais
            this.TotalRestantes.Text = (bolas.Length).ToString();
            this.textBox1.Text = "INSIRA OS DETALHES DO SORTEIO";

            //modifica e desativa os groupbox 
            this.groupBox4.Visible = false;
            this.groupBox1.Enabled = false;
            this.groupBox2.Enabled = false;
            this.groupBox3.Enabled = false;



        }

        private void BotaoPrepararSorteio_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2();
            Form2.ShowDialog();


        }
        public void AtualizarInfo(string evento, string edicao, string numero, string descricao)
        {

            this.textBox1.Text = "DETALHES DO SORTEIO";
            this.groupBox4.Enabled = true;
            this.groupBox4.Visible = true;
            this.NomeEvento.Text = evento;
            this.EdicaoEvento.Text = edicao;
            this.NumeroPremio.Text = numero;
            this.DescricaoPremio.Text = descricao;


            //ativar o botão de iniciar
            this.BotaoIniciarPausarSorteio.Enabled = true;

            //ativar os groupbox
            this.groupBox1.Enabled = true;
            this.groupBox2.Enabled = true;
            this.groupBox3.Enabled = true;

            //modificar texto do botao
            this.BotaoPrepararSorteio.Text = "Modificar sorteio";
        }
                    

       
        private void aleatorio(object sender, EventArgs e)
        {
            if (radioButton3RadioBotaoAutomatico.Checked)
            {
                if (this.bolas.Length > 0)
                {
                    Random rnd = new Random();
                    //tempo = this.AjustarTempoBola.Text;
                    int indexAleatorio = rnd.Next(0, this.bolas.Length);
                    int bolaSorteada = this.bolas[indexAleatorio];
                    Button botaoSorteado = this.Controls.Find("BotaoBola" + bolaSorteada.ToString(), true).FirstOrDefault() as Button;
                    Lancar(botaoSorteado, bolaSorteada);
                    //Thread.Sleep(int.Parse(tempo));
                }
            }
            else
            {
                timerxcx.Stop();
            }
            
            //string tempo;

            
        }
    

        private void radioButton3RadioBotaoAutomatico_CheckedChanged(object sender, EventArgs e)
        {
            this.AjustarTempoBola.Enabled = !this.AjustarTempoBola.Enabled;
            if (radioButton3RadioBotaoAutomatico.Checked)
            {
                //this.AjustarTempoBola.Enabled = !this.AjustarTempoBola.Enabled;
                int tempo = int.Parse(AjustarTempoBola.Text);
                tempo = tempo * 1000;
                timerxcx.Interval = tempo;
                timerxcx.Tick += new EventHandler(aleatorio);
                timerxcx.Start();
            }

        }

        private void RadioBotaoPedraPedra_CheckedChanged(object sender, EventArgs e)
        {
            this.BotaoSortearBola.Enabled= !this.BotaoSortearBola.Enabled;
            if (!this.AjustarTempoBola.Enabled)
            {
                this.AjustarTempoBola.Enabled = false;
            }
        }

        
    }
}

