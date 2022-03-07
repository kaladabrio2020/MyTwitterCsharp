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
    public partial class Tweetar : Form
    {
        PegandoNome dado = new PegandoNome();
        static Repositorio repositorio = new RepositorioUsuario();
        static Mytwitter mytwitter = new CTwitter(repositorio);

        public Tweetar()
        {
            InitializeComponent();
        }

        private void buttonEnviar_Click(object sender, EventArgs e)
        {
            if (mytwitter.tweetar(dado.Pegando(), this.textTweet.Text))
            {
                MessageBox.Show("Concluido");
                this.textTweet.Text = "";
            }
        }
    }
}
