using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTwitter.ClassesMyTwitter.Perfis
{
    abstract class Perfil
    {
     
		private String usuario,senha;
		private List<Perfil> seguidos   ;
		private List<Perfil> seguidores ;
		private List<Tweet>  timeline   ;
		private bool ativo;

		public Perfil(String usuario){
			Usuario = usuario;

			seguidos   = new List<Perfil>();
			seguidores = new List<Perfil>();
			timeline   = new List<Tweet>();

			Ativo = true;
		}

		public List<Perfil> Seguidores
        {
			get { return this.seguidores; }
        }

		public List<Perfil> Seguidos
		{
			get { return this.seguidos; }
		}

		public List<Tweet> Timeline
        {
			get { return this.timeline; }
        }


		public void addSeguidores(Perfil usuario){
			seguidores.Add(usuario);
		}
		public void addSeguidos(Perfil usuario)
        {
			seguidos.Add(usuario);
        }
		public void addTweet(Tweet tweet){
			timeline.Add(tweet);
		}

		public string Usuario
        {
			get { return this.usuario;  }
			set { this.usuario = value; }
        }

		public bool Ativo{ 
			get { return this.ativo;  }
			set { this.ativo = value; } 
		}
		public string Senha
        {
			get { return this.senha;  }
			set { this.senha = value; }
        }

    }
}

