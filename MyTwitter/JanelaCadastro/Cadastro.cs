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
using MyTwitter.ClassesMyTwitter.Perfis;
using MyTwitter.ClassesMyTwitter.Twitter;
using MyTwitter.ClassesMyTwitter.Twitter.Interface;
using MyTwitter.ClassesMyTwitter.Aquivos;
using MyTwitter.ClassesMyTwitter.Aquivos.Abrir;
using MyTwitter.ClassesMyTwitter.Aquivos.Salvar;

namespace MyTwitter.JanelaCadastro
{
    public partial class Cadastro : Form
    {
        Thread janela;
        static RepositorioUsuario repositorio = new RepositorioUsuario();
        static Mytwitter mytwitter = new CTwitter(Cadastro.repositorio);



        public Cadastro()
        {
            InitializeComponent();
        }


        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            janela = new Thread(JanelaMain);
            janela.SetApartmentState(ApartmentState.STA);
            janela.Start();
        }

        private void checkCpf_CheckedChanged(object sender, EventArgs e)
        {
            this.textIdentidade.MaxLength = 11;
        }

        private void checkCnpj_CheckedChanged(object sender, EventArgs e)
        {
            this.textIdentidade.MaxLength = 4;
        }

        private void checkMostrar_CheckedChanged(object sender, EventArgs e)
        {
            this.textSenha.PasswordChar = '\0';
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) { e.Handled = true; }
           
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)) { e.Handled = true; }
        }



        private void buttonContinuar_Click(object sender, EventArgs e)
        {
            
            if (checkCpf.Checked && !checkCnpj.Checked)
            {
                PessoaFisica user = new PessoaFisica(textNome.Text);
                user.Senha = textSenha.Text;
                user.Cpf = ulong.Parse(textIdentidade.Text);

                if (repositorio.Cadastrar(user)) MessageBox.Show("Cadastrado");
                else MessageBox.Show("Nao cadastrado , usuario ja exitente");
                
            }
            else if ( !checkCpf.Checked && checkCnpj.Checked)
            {
                PessoaJuridica user = new PessoaJuridica(textNome.Text);
                user.Senha = textSenha.Text;
                user.Cnpj = ulong.Parse(textIdentidade.Text);

                if (repositorio.Cadastrar(user)) MessageBox.Show("Cadastrado");
                else MessageBox.Show("Nao cadastrado , usuario ja exitente");
            }
            else MessageBox.Show("Invalida Operaçao");
            


        }
      
        private void JanelaMain(object obj)
        {
            Application.Run(new Form1());
        }

        private void Cadastro_FormClosed(object sender, FormClosedEventArgs e)
        {
            PerfilArquivoGravar  a = new PerfilArquivoGravar(repositorio.GetListUsuarios());
            TimelineArquivoGravar b = new TimelineArquivoGravar(mytwitter.gettweetall());
        }
    }
}
