using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyTwitter.ClassesMyTwitter.Perfis;

namespace MyTwitter.ClassesMyTwitter.Twitter.Interface
{
    interface Mytwitter
    {
		public bool criarPerfil(Perfil usuario);

		public bool cancelarPerfil(String usuario);
		public bool AtivarPerfil(string usuario);
		public bool tweetar(String usuario, String mensangem);

		public List<Tweet>? timeline(String usuario);
		public List<Tweet>? tweets(String usuario);

		public bool seguir(String seguidor, String seguido);

		public int numeroSeguidores(String usuario);

		public List<Perfil>? seguidores(String usuario);
		public List<Perfil>? seguidos(String usuario);

		public List<Tweet> gettweetall();

	}
}
