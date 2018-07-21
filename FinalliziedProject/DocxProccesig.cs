using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xceed.Words.NET;

namespace FinalliziedProject
{
    class DocxProccesig
    {
        public void writeText(string path, string data)
        {
            DocX doc;
            // Create a document in memory:
            if (File.Exists(path) == true){
                doc = DocX.Load(path);
            }else{
                doc = DocX.Create(path);
            }
            // Insert a paragrpah:
            doc.InsertParagraph(data);

            // Save to the output directory:
            doc.Save();

            // bun BİR çözüm bulalım daha sonra   
            // Open in Word:
            Process.Start("WINWORD.EXE", path);

        }
    }
}
