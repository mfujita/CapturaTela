using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;
using System.Threading;
//https://pplware.sapo.pt/tutoriais/tutorial-c-printscreen/

namespace capturaTela
{
    public partial class Form1 : Form
    {
        Thread th;
        delegate void AtualizaContagem(string texto);
        string diretorio;
        TextBox txtEsquerdo;
        TextBox txtSuperior;
        TextBox txtLargura;
        TextBox txtAltura;
        TextBox txtMilissegundos;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            diretorio = @"C:\capturas";
            if (!Directory.Exists(diretorio))
                Directory.CreateDirectory(diretorio);
        }

        private void CapturaTelas()
        {
            int i = 0;

            while (i < 5000)
            {
                Rectangle todaTela = Screen.PrimaryScreen.WorkingArea;

                int largura = int.Parse(txtLargura.Text);
                int altura = int.Parse(txtAltura.Text);

                Bitmap capturaTela = new Bitmap(largura, altura);

                Graphics g = Graphics.FromImage(capturaTela as Image);

                int esquerda = int.Parse(txtEsquerdo.Text);
                int topo = int.Parse(txtSuperior.Text);

                g.CopyFromScreen(esquerda, topo, 0, 0, capturaTela.Size);

                if (lblID.InvokeRequired)
                {
                    AtualizaContagem ac = new AtualizaContagem(SetText);
                    Invoke(ac, new object[] { i.ToString() });
                }

                capturaTela.Save(diretorio + "\\t" + i.ToString("0000") + ".jpg", ImageFormat.Jpeg);
                capturaTela.Dispose();
                g.Dispose();
                Thread.Sleep(int.Parse(txtMilissegundos.Text));
                i++;
            }
            MessageBox.Show("Fim");
        }

        private void SetText(string texto)
        {
            lblID.Text = texto;
        }

        private void btnEstrobo_Click(object sender, EventArgs e)
        {
            th = new Thread(new ThreadStart(CapturaTelas));
            th.Start();
        }

        private void Btn_Abortar_Click(object sender, EventArgs e)
        {
            th.Abort();
            MessageBox.Show("Captura de telas abortada!");
            lblID.Text = "0";
        }

        private void BtnConfigurar_Click(object sender, EventArgs e)
        {
            Size = new Size(280, 400);

            txtEsquerdo = new TextBox();
            txtEsquerdo.Size = new Size(Width - 50, 26);
            txtEsquerdo.Location = new Point(btn_Abortar.Left, btn_Abortar.Bottom + 15);
            txtEsquerdo.Text = "Esquerdo";
            Controls.Add(txtEsquerdo);
            txtEsquerdo.Click += Esquerdo_Click;

            txtSuperior = new TextBox();
            txtSuperior.Size = new Size(Width - 50, 26);
            txtSuperior.Location = new Point(btn_Abortar.Left, txtEsquerdo.Bottom + 15);
            txtSuperior.Text = "Superior";
            Controls.Add(txtSuperior);
            txtSuperior.Click += Superior_Click;

            txtLargura = new TextBox();
            txtLargura.Size = new Size(Width - 50, 26);
            txtLargura.Location = new Point(btn_Abortar.Left, txtSuperior.Bottom + 15);
            txtLargura.Text = "largura";
            Controls.Add(txtLargura);
            txtLargura.Click += Largura_Click;

            txtAltura = new TextBox();
            txtAltura.Size = new Size(Width - 50, 26);
            txtAltura.Location = new Point(btn_Abortar.Left, txtLargura.Bottom + 15);
            txtAltura.Text = "altura";
            Controls.Add(txtAltura);
            txtAltura.Click += Altura_Click;

            txtMilissegundos = new TextBox();
            txtMilissegundos.Size = new Size(Width - 50, 26);
            txtMilissegundos.Location = new Point(btn_Abortar.Left, txtAltura.Bottom + 15);
            txtMilissegundos.Text = "milissegundos";
            Controls.Add(txtMilissegundos);
            txtMilissegundos.Click += Milissegundos_Click;

            Button btnOk = new Button();
            btnOk.Size = new Size(89, 23);
            btnOk.Location = new Point((Width - btnOk.Width) / 2, txtMilissegundos.Bottom + 15);
            btnOk.Text = "Ok";
            Controls.Add(btnOk);
            btnOk.Click += BtnOk_Click;
        }

        private void Milissegundos_Click(object sender, EventArgs e)
        {
            TextBox milissegundos = (TextBox)sender;
            milissegundos.Text = "";
        }

        private void Altura_Click(object sender, EventArgs e)
        {
            TextBox altura = (TextBox)sender;
            altura.Text = "";
        }

        private void Largura_Click(object sender, EventArgs e)
        {
            TextBox largura = (TextBox)sender;
            largura.Text = "";
        }

        private void Superior_Click(object sender, EventArgs e)
        {
            TextBox superior = (TextBox)sender;
            superior.Text = "";
        }

        private void Esquerdo_Click(object sender, EventArgs e)
        {
            TextBox esquerdo = (TextBox)sender;
            esquerdo.Text = "";
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            Size = new Size(280, 166);
        }
    }
}
