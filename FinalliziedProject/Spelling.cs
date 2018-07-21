using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalliziedProject
{
    class Spelling
    {

        public string getSpellingText(string text)
        {

            SyllableLibrary syllble = new SyllableLibrary();
            Syllables ss = syllble.GetSyllableWords(text);
            string newText = "";
            foreach (var hece in ss)
            {
                if (newText.Equals(""))
                {
                    newText = hece.Value;
                }
                else
                {
                    newText += "-" + hece.Value;
                }



            }
            return newText;
        }
    }
}
