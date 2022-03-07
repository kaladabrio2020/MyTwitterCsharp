using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyTwitter.ClassesMyTwitter.Perfis;

namespace MyTwitter.ClassesMyTwitter.Aquivos.Salvar
{
    class SeguidosArquivoGravar
    {
        public SeguidosArquivoGravar(List<Perfil> usuario)
        {
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamWriter sr = new StreamWriter(@"C:\Users\mateu\source\repos\MyTwitter\MyTwitter\ArquivosTxt\Seguidos.txt");

                foreach(Perfil i in usuario)
                {
                    if (i.Seguidos.Capacity != 0)
                    {
                        sr.Write(i.Usuario + ":");
                        foreach (Perfil e in i.Seguidos)
                        {
                            sr.Write(e.Usuario + ",");
                        }sr.WriteLine();
                    }
                    else sr.WriteLine(i.Usuario + ":none");
                }


                //close the file
                sr.Close();

            }
            catch (Exception)
            {
            }


        }
    }
}
