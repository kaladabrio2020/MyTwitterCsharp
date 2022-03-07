using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using MyTwitter.JanelaCadastro;

using MyTwitter.JanelaMyTwitter;
using MyTwitter.ClassesMyTwitter.Perfis;
using MyTwitter.ClassesMyTwitter.Twitter;
using MyTwitter.ClassesMyTwitter.Twitter.Interface;
using MyTwitter.ClassesMyTwitter.Aquivos.Abrir;
using MyTwitter.ClassesMyTwitter.Aquivos.Salvar;
using MyTwitter.ClassesMyTwitter.Aquivos;

namespace MyTwitter
{
    public partial class Form1 : Form
    {

        Thread janela;
        static SalvandoNome name;
        static Repositorio repositorio = new RepositorioUsuario();
        static Mytwitter mytwitter = new CTwitter(Form1.repositorio);
        
        public Form1()
        {
            PerfilArquivoAbrir a = new PerfilArquivoAbrir();
            TimelineArquivoAbrir b = new TimelineArquivoAbrir();
            SeguidosArquivoAbrir c = new SeguidosArquivoAbrir();
            InitializeComponent();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            this.Close();
            janela = new Thread(CadastroUser);
            janela.SetApartmentState(ApartmentState.STA);
            janela.Start();

        }

        private void buttonContinuar_Click(object sender, EventArgs e)
        {
            bool boolean = false;
       
            foreach(Perfil i in repositorio.GetListUsuarios())
            {
                if (i.Usuario == this.textNome.Text && i.Senha == this.textSenha.Text)
                {
                    SalvandoNome salvandoNome = new SalvandoNome(this.textNome.Text);
                    boolean = true;
                    break; 
                }
            }

            if (boolean)
            {
                this.Close();
                janela = new Thread(MyTwitterC);
                janela.SetApartmentState(ApartmentState.STA);
                janela.Start();
            }
            else MessageBox.Show("Invalido");

        }

        private void MostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            this.textSenha.PasswordChar = '\0';
        }

        private void MyTwitterC(object obj)
        {
            Application.Run(new MyTwitterC());
        }
        private void CadastroUser(object obj)
        {
            Application.Run(new Cadastro());
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            PerfilArquivoGravar a = new PerfilArquivoGravar(repositorio.GetListUsuarios());
            TimelineArquivoGravar b = new TimelineArquivoGravar(mytwitter.gettweetall());
            SeguidosArquivoGravar c = new SeguidosArquivoGravar(repositorio.GetListUsuarios());
        }
    }
}
