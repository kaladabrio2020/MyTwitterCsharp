using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyTwitter.ClassesMyTwitter.Perfis;
using MyTwitter.ClassesMyTwitter.Twitter.Interface;

namespace MyTwitter.ClassesMyTwitter.Twitter
{
	class CTwitter : Mytwitter
	{
		private Perfil valor;
		private bool boolean;
		private Repositorio repository;
		private static List<Tweet> tweetall = new List<Tweet>();


		public CTwitter(Repositorio repositorio)
		{
			this.repository = repositorio;
		}



		public bool criarPerfil(Perfil usuario)
		{
			return repository.Cadastrar(usuario);

		}

		public bool cancelarPerfil(String usuario)
		{
			valor = repository.Buscar(usuario);


			if (valor != null)
			{
				boolean = valor.Ativo;

				if (boolean)
				{
					repository.Buscar(usuario).Ativo = false;
					return true;
				}return false;
			}
			else return false;

		}

		public bool AtivarPerfil(String usuario)
		{
			valor = repository.Buscar(usuario);


			if (valor != null)
			{
				boolean = valor.Ativo;

				if (!boolean)
				{
					repository.Buscar(usuario).Ativo = true;
					return true;
				}
				return false;
			}
			else return false;

		}




		public bool tweetar(String usuario, String mensangem)
		{
			Tweet tweet = new Tweet();
			valor = repository.Buscar(usuario);
			boolean = (mensangem.Length >= 1 && mensangem.Length <= 140);




			if (valor != null)
			{
				List<Perfil> seguidores = valor.Seguidores;
				if (boolean)
				{
					tweet.Usuario = usuario;
					tweet.Mensagem = mensangem;
					valor.addTweet(tweet);
					tweetall.Add(tweet);

					if (seguidores.Capacity != 0)
					{
						foreach (Perfil perfil in seguidores)
						{
							repository.Buscar(perfil.Usuario).addTweet(tweet);
						}
					}return true;
				} else return false;
			} return false;
		}
		public List<Tweet> timeline(String usuario)
		{
			valor = repository.Buscar(usuario);
			if (valor != null) return repository.Buscar(usuario).Timeline;
			return null;
		}



		public List<Tweet>? tweets(String usuario)
		{
			valor = repository.Buscar(usuario);

			if (valor != null)
			{
				boolean = valor.Ativo;
				if (boolean)
				{
					List<Tweet> tweetsPessoal = new List<Tweet>();

					foreach (Tweet tweet in valor.Timeline)
					{
						if (tweet.Usuario == usuario) tweetsPessoal.Add(tweet);
					} return tweetsPessoal;
				} else return null;
			} else return null;
		}




		public bool seguir(String seguidor, String seguido)
		{	
			Perfil Pseguidor = repository.Buscar(seguidor);
			Perfil Pseguido = repository.Buscar(seguido);

			if (repository.BuscarSeguidores(seguidor,seguido)) { return false; }

			if (Pseguidor != null && Pseguido != null)
			{
				if (Pseguidor.Ativo && Pseguido.Ativo)
				{
					if (seguidor != seguido)
					{
						Pseguido.addSeguidores(Pseguidor);
						Pseguidor.addSeguidos(Pseguido);
						return true;
					}else return false;
				}else return false;
			} else return false;
		}

		public int numeroSeguidores(String usuario)
		{
			valor = repository.Buscar(usuario);


			if (valor != null)
			{
				boolean = valor.Ativo;
				if (boolean)
				{
					List<Perfil> seguidores = repository.Buscar(usuario).Seguidores;
					return seguidores.Capacity;
				}else return 0;
			}else return 0;
		}




		public List<Perfil>? seguidores(String usuario)
		{
			valor = repository.Buscar(usuario);
			if (valor != null)
			{
				boolean  = valor.Ativo;
				if (boolean)
				{
					List<Perfil> seguidores = repository.Buscar(usuario).Seguidores;
					List<Perfil> seguidoresAtivos = new List<Perfil>();

					foreach (Perfil perfil in seguidores)
					{
						if (perfil.Ativo) seguidoresAtivos.Add(perfil);
					}return seguidoresAtivos;
				} else return null;
			} else return null;
		}




		public List<Perfil>? seguidos(String usuario)
		{
			valor = repository.Buscar(usuario);
			if (valor != null)
			{
				boolean = valor.Ativo;
				if (boolean)
				{
					List<Perfil> seguidos = repository.Buscar(usuario).Seguidos;
					List<Perfil> seguidosAtivos = new List<Perfil>();

					foreach (Perfil perfil in seguidos)
					{
						if (perfil.Ativo)
						{
							seguidosAtivos.Add(perfil);
						}
					}return seguidosAtivos;
				} else return null;
			} else return null;
		}

		public List<Tweet> gettweetall(){ return tweetall; }
	
    }

}
