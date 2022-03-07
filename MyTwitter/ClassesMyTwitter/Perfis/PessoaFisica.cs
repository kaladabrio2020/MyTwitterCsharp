using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTwitter.ClassesMyTwitter.Perfis
{
    internal class PessoaFisica : Perfil
    {
        private ulong cpf;
        public PessoaFisica(string usuario) : base(usuario) { }
        public ulong Cpf
        {
            get { return this.cpf;  }
            set { this.cpf = value; }
        }
    }
}
