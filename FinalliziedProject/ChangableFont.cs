using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalliziedProject
{
    public class ChangableFont
    {
        public enum RENKLENDIRME_SECENEGI
        {
            ARKA,ON
        }
        public void setFontColor(Color color, TextBoxBase txtbase)
        {
            txtbase.ForeColor = color;
        }
        public void changeFontAboutLetter(string searchableText, RichTextBox txtSpeling,Color color, RENKLENDIRME_SECENEGI renklendirme)
        {
            String findingText = searchableText ;
            int startIndex = 0;
         

            while (startIndex < txtSpeling.TextLength)
            {
                int wordCountText = txtSpeling.Find(findingText, startIndex, RichTextBoxFinds.None);
                if (wordCountText != -1)
                {
                    txtSpeling.SelectionStart = wordCountText;
                    txtSpeling.SelectionLength = findingText.Length;
                    if( renklendirme== RENKLENDIRME_SECENEGI.ON)
                    {
                        txtSpeling.SelectionColor = color;
                    }
                    else
                    {
                        txtSpeling.SelectionBackColor = color;
                    }
                    

                }
                else
                {
                    break;
                }
                startIndex = wordCountText + findingText.Length;
            }

        }



    }
}
