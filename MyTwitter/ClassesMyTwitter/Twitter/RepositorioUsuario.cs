using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyTwitter.ClassesMyTwitter.Perfis;
using MyTwitter.ClassesMyTwitter.Twitter.Interface;

namespace MyTwitter.ClassesMyTwitter.Twitter
{
    class RepositorioUsuario : Repositorio
    {
        static List<Perfil> usuarios = new List<Perfil>();

        public bool Cadastrar(Perfil usuario)
        {
            if (Buscar(usuario.Usuario) == null)
            {
                usuarios.Add(usuario);
                return true;
                
            }
            else return false;

        }
        public Perfil Buscar(string usuario)
        {
            foreach (Perfil i in usuarios){
                if (i.Usuario == usuario) return i;
            }return null;
        }

        public bool BuscarSeguidores(string seguidor,string seguido)
        {
            foreach(Perfil i in usuarios)
            {
                if (i.Usuario == seguido)
                {
                    foreach(Perfil e in i.Seguidores)
                    {
                        if (e.Usuario == seguidor) return true;
                    }
                }
            }return false;
        }

        public void Atualizar(Perfil usuario)
        {
            Perfil perfilAntigo = Buscar(usuario.Usuario);
            if (perfilAntigo != null)
            {
                int index = usuarios.IndexOf(perfilAntigo);
                usuarios.Remove(perfilAntigo);
                usuarios.Insert(index, usuario);
            } 
        }
        public List<Perfil> GetListUsuarios()
        {
            return usuarios;
        }
    }
}
