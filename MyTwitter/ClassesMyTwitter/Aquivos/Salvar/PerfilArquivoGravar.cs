using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using MyTwitter.ClassesMyTwitter.Perfis;
using MyTwitter.ClassesMyTwitter.Twitter;
using MyTwitter.ClassesMyTwitter.Twitter.Interface;


namespace MyTwitter.ClassesMyTwitter.Aquivos.Salvar
{
    internal class PerfilArquivoGravar
    {
        public PerfilArquivoGravar(List<Perfil> usuario)
        {
            String line;
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                using var path = new StreamWriter("C:\\Users\\mateu\\source\\repos\\MyTwitter\\MyTwitter\\ArquivosTxt\\Usuario.txt");

                if (usuario.Capacity != 0)
                {
                    foreach (Perfil i in usuario)
                    {
                        if (i is PessoaFisica)
                        {
                            path.WriteLine(i.Usuario + "," + ((PessoaFisica)i).Cpf + ",none," + i.Ativo + "," + i.Senha+",");
                        }
                        else if (i is PessoaJuridica)
                        {
                            path.WriteLine(i.Usuario + ",none," + ((PessoaJuridica)i).Cnpj + "," + i.Ativo + "," + i.Senha+",");
                        }
                    }
                }
        
                //close the file
                path.Close();
              
            }
            catch (Exception i)
            {
               
            }
        }
    }
}
