using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyTwitter.ClassesMyTwitter.Perfis;
using MyTwitter.ClassesMyTwitter.Twitter;
using MyTwitter.ClassesMyTwitter.Twitter.Interface;


namespace MyTwitter.ClassesMyTwitter.Aquivos
{
    class PerfilArquivoAbrir
    {
        public PerfilArquivoAbrir()
        {
            Repositorio repositorio = new RepositorioUsuario();
            Mytwitter mytwitter = new CTwitter(repositorio);

            string line;
            using var path = new StreamReader(@"C:\Users\mateu\source\repos\MyTwitter\MyTwitter\ArquivosTxt\Usuario.txt");

            try
            {
                
                
                //Read the first line of text

                //Continue to read until you reach end of file

                line = path.ReadToEnd();
                string valores;
                string[] p = line.Split('\n');
                foreach(string dados in p)
                {
                    valores = dados;
                    
                    if (valores.Contains('\r')) valores =  valores.Replace('\r',' '); 
                    string[] caracteres = valores.Split(',');




                    if (caracteres[1] != "none" && caracteres[2] == "none")
                    {
                        PessoaFisica perfil = new PessoaFisica(caracteres[0]);
                        ulong cpf  = ulong.Parse(caracteres[1]);
                        bool ativo = bool.Parse(caracteres[3]);
                        perfil.Cpf = cpf;
                        perfil.Ativo = ativo;
                        perfil.Senha = caracteres[4];
                      

                        if (mytwitter.criarPerfil(perfil)) ;
                        
                    }
                    else if (caracteres[1] == "none" && caracteres[2] != "none")
                    {
                        PessoaJuridica perfil = new PessoaJuridica(caracteres[0]);
                        ulong cnpj = ulong.Parse(caracteres[2]);
                        bool ativo = bool.Parse(caracteres[3]);
                        perfil.Cnpj = cnpj;
                        perfil.Ativo = ativo;
                        perfil.Senha = caracteres[4];
                        mytwitter.criarPerfil(perfil);
                    }
             
                }
                //close the file
                path.Close();
               

            }
            catch (Exception)
            {
            }
        }
    }
}
