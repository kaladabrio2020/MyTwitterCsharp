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
    class TimelineArquivoAbrir
    {
        public TimelineArquivoAbrir()
        {

            Repositorio repositorio = new RepositorioUsuario();
            Mytwitter mytwitter = new CTwitter(repositorio);


            string line;
            try
            {
       
                using var path = new StreamReader(@"C:\Users\mateu\source\repos\MyTwitter\MyTwitter\ArquivosTxt\Timeline.txt");
              
                line = path.ReadToEnd();
                string[] valores = line.Split('|');

                foreach (string caracteres in valores)
                {
                    string[] parte1 = caracteres.Split(':');
                   
                    mytwitter.tweetar(parte1[0], parte1[1]);
                 }
     
                path.Close();
                

            }
            catch (Exception)
            {
            }
        }
    }
   }

