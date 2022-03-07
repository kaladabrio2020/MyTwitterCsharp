using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTwitter.ClassesMyTwitter.Perfis
{
    class Tweet
    {
        private String usuario;
	    private String mensagem;
	
	    public String Usuario {
			get { return this.usuario;  }
			set { this.usuario = value; }
	    }
	

	    public String Mensagem {
			get { return this.mensagem;  }
			set { this.mensagem = value; }
	    }

    }
}
