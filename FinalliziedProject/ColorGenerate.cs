using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalliziedProject
{
    class ColorGenerate
    {
        private Random rnd = new Random();

        public Color generateColor()
        {

            Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            return randomColor;
        }
    }
}
