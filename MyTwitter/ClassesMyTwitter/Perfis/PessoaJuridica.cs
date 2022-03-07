using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTwitter.ClassesMyTwitter.Perfis
{
    class PessoaJuridica : Perfil
    {
        private ulong cnpj;
        public PessoaJuridica(string usuario) : base(usuario) { }
        public ulong Cnpj
        {
            get { return this.cnpj;  }
            set { this.cnpj = value; }
        }
    }
}
