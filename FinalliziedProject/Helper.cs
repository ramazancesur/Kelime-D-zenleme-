
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Controls;
using System.Windows.Forms;

namespace FinalliziedProject
{
    public class Helper
    {
        public static string getCurrentPath()
        {
            var dir = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            return dir;
        }

  

   
    }
}
