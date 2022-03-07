using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MyTwitter;
using MyTwitter.JanelaMyTwitter;
using MyTwitter.ClassesMyTwitter.Perfis;
using MyTwitter.ClassesMyTwitter.Twitter;
using MyTwitter.ClassesMyTwitter.Twitter.Interface;
using MyTwitter.ClassesMyTwitter.Aquivos.Abrir;
using MyTwitter.ClassesMyTwitter.Aquivos.Salvar;
using MyTwitter.ClassesMyTwitter.Aquivos;


namespace MyTwitter.JanelaMyTwitter
{
    public partial class MyTwitterC : Form
    {
        Thread janela;
        private string nome;
        
        static Repositorio repositorio = new RepositorioUsuario();
        static Mytwitter mytwitter = new CTwitter(repositorio);

        public MyTwitterC()
        { 
            InitializeComponent();
            PegandoNome pegandoNome = new PegandoNome();
            this.nome = pegandoNome.Pegando();
            JanelaDoUsuario();  
        }



        private void JanelaDoUsuario()
        {
            bool boolean = false;
            foreach(Perfil i in repositorio.GetListUsuarios())
            { if (i.Ativo && i.Usuario == this.nome) boolean = true; }

            this.labelNome.Text = this.nome;

            if (boolean)
            {
                this.labelNome.ForeColor = System.Drawing.Color.Green;
                this.checkAtivo.ForeColor = System.Drawing.Color.Green;
                this.checkAtivo.Text = "On-line";
                this.checkAtivo.CheckState = CheckState.Checked;
            }
            else
            {
                this.labelNome.ForeColor = System.Drawing.Color.Red;
                this.checkAtivo.ForeColor = System.Drawing.Color.Red;
                this.checkAtivo.Text = "Off-line";
                this.checkAtivo.CheckState = CheckState.Unchecked;
            }
        }






        private void checkAtivo_CheckedChanged(object sender, EventArgs e)
        {

            if (checkAtivo.Checked)
            {
                mytwitter.AtivarPerfil(this.nome); 
                this.labelNome.ForeColor= System.Drawing.Color.Green;
                this.checkAtivo.ForeColor = System.Drawing.Color.Green;
                this.checkAtivo.Text = "On-line";
            }
            else
            {
                mytwitter.cancelarPerfil(this.nome);
                this.labelNome.ForeColor = System.Drawing.Color.Red;
                this.checkAtivo.ForeColor = System.Drawing.Color.Red;
                this.checkAtivo.Text = "Off-line";
            }

        }





        private void buttonTwettar_Click(object sender, EventArgs e)
        {
            abrirForms(new Tweetar());
        }

        private bool Ativo()
        {
            foreach (Perfil i in repositorio.GetListUsuarios())
            {
                if (i.Usuario == this.nome && i.Ativo) return true;

                if (i.Usuario == this.nome && i.Ativo == false) return false;
            }
            return false;
        }

        private void buttonAmigos_Click(object sender, EventArgs e)
        {
            abrirForms(new Amigos());
        }




        private void buttonSair_Click(object sender, EventArgs e) 
        {
            System.IO.File.WriteAllBytes(@"C:\Users\mateu\source\repos\MyTwitter\MyTwitter\ArquivosTxt\Name.txt", new byte[0]);
            this.Close();
            janela = new Thread(JanelaMain);
            janela.SetApartmentState(ApartmentState.STA);
            janela.Start();
        }


        private void JanelaMain(object obj) 
        {
            Application.Run(new Form1());
        } 






  

        private void MyTwitterC_FormClosed(object sender, FormClosedEventArgs e)
        {

            PerfilArquivoGravar a = new PerfilArquivoGravar(repositorio.GetListUsuarios());
            TimelineArquivoGravar b = new TimelineArquivoGravar(mytwitter.gettweetall());
            SeguidosArquivoGravar c = new SeguidosArquivoGravar(repositorio.GetListUsuarios());
            System.IO.File.WriteAllBytes(@"C:\Users\mateu\source\repos\MyTwitter\MyTwitter\ArquivosTxt\Name.txt", new byte[0]);


        }

        private void abrirForms(object obj)
        {
            if (this.PainelMain.Controls.Count > 0) this.PainelMain.Controls.RemoveAt(0);

            Form aba = obj as Form;
            aba.TopLevel = false;
            aba.Dock = DockStyle.Fill;
            this.PainelMain.Controls.Add(aba);
            this.PainelMain.Tag = aba;
            aba.Show();
        }

        private void buttonTimeLine_Click(object sender, EventArgs e)
        {
            abrirForms(new TimeLine());
        }
    }
}
