using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class Amigos : Form
    {
        PegandoNome dado = new PegandoNome();
        static Repositorio repositorio = new RepositorioUsuario();
        static Mytwitter mytwitter = new CTwitter(repositorio);
        public Amigos()
        {
            InitializeComponent();
            TextoSeguidos();
            TextoSeguidores();

        }

        private void buttonAdcionar_Click(object sender, EventArgs e)
        {
            string seguir = this.textAmigo.Text;
            if (mytwitter.seguir(dado.Pegando(), seguir))
            {
                MessageBox.Show("Feito");
            }
            else MessageBox.Show("Nao adicionado");

        }

        private void TextoSeguidos()
        {
            string texto = "";
            List<Perfil> seguidos = mytwitter.seguidos(dado.Pegando());
            if (seguidos != null)
            {
                foreach (Perfil i in seguidos)
                {
                    texto += i.Usuario + "\n";
                }
            }
            else texto = "none";
            this.TextSeguidos.Text = texto;
        }

        private void TextoSeguidores()
        {
            string texto = "";
            List<Perfil> seguidores = mytwitter.seguidores(dado.Pegando());
            if (seguidores != null)
            {
                foreach (Perfil i in seguidores)
                {
                    texto += i.Usuario + "\n";
                }
            }
            else texto = "none";
            this.TextSeguidores.Text = texto;
        }



    }
}
