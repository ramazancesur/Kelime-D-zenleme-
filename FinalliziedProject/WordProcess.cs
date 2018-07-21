using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalliziedProject
{
    public class WordProcess
    {
        public string kelimeAyır(string applicantext)
        {
            return applicantext.Replace(" ", "+");
        }

        public List<string> getKelimeList(string kelime)
        {
            try
            {
                return kelime.Split(' ').ToList();
            }
            catch (Exception ex)
            {
                return new List<string>();
            }
        }
        public string cumlelereAyir(string applicantext)
        {

            return applicantext.Replace(".", "  +  ").Trim();

        }

        public string noktalamalariKaldir(string applicantext)
        {
            var sb = new StringBuilder();

            foreach (char c in applicantext)
            {
                if (!char.IsPunctuation(c))
                {
                    sb.Append(c);
                }
                else
                {
                    sb.Append("( )");
                }
                  
            }
            applicantext = sb.ToString();
            return applicantext;
        }


        public string harflereAyır(string applicantext)
        {
            string tempStr = "";
            foreach (var item in applicantext)
            {
                tempStr = tempStr + " " + item;
            }
            return tempStr;
        }

    }
}
