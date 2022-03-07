using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyTwitter.ClassesMyTwitter.Perfis;
using MyTwitter.ClassesMyTwitter.Twitter;
using MyTwitter.ClassesMyTwitter.Twitter.Interface;
namespace MyTwitter.ClassesMyTwitter.Aquivos.Abrir
{
    class SeguidosArquivoAbrir
    {
        public SeguidosArquivoAbrir() { 
            Repositorio repositorio = new RepositorioUsuario();
            Mytwitter mytwitter = new CTwitter(repositorio);

            string line;
            using var path = new StreamReader(@"C:\Users\mateu\source\repos\MyTwitter\MyTwitter\ArquivosTxt\Seguidos.txt");

            try
            {
               

                line = path.ReadToEnd();
                
                string[] valores = line.Split('\n');
                foreach (string caracteres in valores)
                {

                    string[] parte1 = caracteres.Split(':');

                    if (parte1[1] == "none") break;
                    
                    string[] parte2 = parte1[1].Split(',');
                    foreach(string i in parte2)
                    {
                        mytwitter.seguir(parte1[0], i);
                    }
                }



                path.Close();
               

            }
            catch (Exception) { }

        }
    }
}
