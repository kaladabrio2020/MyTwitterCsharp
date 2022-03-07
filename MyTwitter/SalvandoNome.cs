using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTwitter
{
    class SalvandoNome
    {

        public SalvandoNome(string nome)
        {
            try
            {
                using var path = new StreamWriter(@"C:\Users\mateu\source\repos\MyTwitter\MyTwitter\ArquivosTxt\Name.txt");
                path.WriteLine(nome);
                path.Close();
            }
            catch (Exception) { }
            
        }
    }
    class PegandoNome
    {
        public string Pegando()
        {
            string nome;
            try
            {
                using var path = new StreamReader(@"C:\Users\mateu\source\repos\MyTwitter\MyTwitter\ArquivosTxt\Name.txt");
                nome = path.ReadLine();
                path.Close();
                return nome;
            }
            catch (Exception) { }
            return null;


        }
    }
}
