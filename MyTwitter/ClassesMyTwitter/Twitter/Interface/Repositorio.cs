using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MyTwitter.ClassesMyTwitter.Perfis;


namespace MyTwitter.ClassesMyTwitter.Twitter.Interface
{
     interface Repositorio
    {
        public bool Cadastrar(Perfil usuario);
        public Perfil Buscar(string usuario);
        public bool BuscarSeguidores(string seguidor,string seguido);
        public void Atualizar(Perfil usuario);
        public List<Perfil> GetListUsuarios();
    }
}
