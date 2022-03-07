using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyTwitter.ClassesMyTwitter.Perfis;
using MyTwitter.ClassesMyTwitter.Twitter;
using MyTwitter.ClassesMyTwitter.Twitter.Interface;

namespace MyTwitter.ClassesMyTwitter.Aquivos.Salvar
{
    class TimelineArquivoGravar
    {
        public TimelineArquivoGravar(List<Tweet> tweets)
        {
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamWriter sr = new StreamWriter(@"C:\Users\mateu\source\repos\MyTwitter\MyTwitter\ArquivosTxt\Timeline.txt");

                if (tweets.Capacity != 0) foreach (Tweet i in tweets) sr.WriteLine(i.Usuario + ":" + i.Mensagem+"|"+"\n"); 
                 

                //close the file
                sr.Close();

            }
            catch (Exception)
            {
            }
        }
    }
}
