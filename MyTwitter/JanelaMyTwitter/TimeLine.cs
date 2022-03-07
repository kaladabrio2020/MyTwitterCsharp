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
    public partial class TimeLine : Form
    {
        PegandoNome pegandoNome = new PegandoNome();
        static Repositorio repositorio = new RepositorioUsuario();
        static Mytwitter mytwitter = new CTwitter(repositorio);

        public TimeLine()
        {
            InitializeComponent();
            this.checkBox1.CheckState = CheckState.Checked;
            Timeline();
        }

        private void Timeline()
        {
            string text = "";
            string usuario = pegandoNome.Pegando();
            List<Tweet> timelineTotal = mytwitter.timeline(usuario);

            foreach (Tweet i in timelineTotal)
            {
                if (i.Usuario == usuario) text += i.Usuario + ":" + i.Mensagem + "\n";
                else text += "                      " + i.Mensagem + ":" + i.Usuario + "\n";
            }
            this.labelTimeline.Text = text;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            string text = "";
            string usuario = pegandoNome.Pegando();
            if (checkBox1.Checked)
            {
                this.checkBox1.Text = "Total";
                List<Tweet> timelineTotal = mytwitter.timeline(usuario);

                foreach(Tweet i in timelineTotal)
                {
                    if (i.Usuario == usuario) text += i.Usuario + ":" + i.Mensagem + "\n";
                    else text += "                      " + i.Mensagem + ":" + i.Usuario + "\n";
                }
                this.labelTimeline.Text = text;

            }
            else
            {
                this.checkBox1.Text = "Pessoal";
                List<Tweet> timelinePessoal = mytwitter.tweets(usuario);

                foreach (Tweet i in timelinePessoal)
                {
                    if (i.Usuario == usuario) text += i.Usuario + ":" + i.Mensagem + "\n";
                }
                this.labelTimeline.Text = text;

            }
        }
    }
}
