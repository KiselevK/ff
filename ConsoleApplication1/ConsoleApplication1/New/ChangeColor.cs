using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.New
{
    class ChangeColor
    {
        public delegate void ColorHandler(string mess);

       

       
        public ColorHandler colorDel;

        public void AddColor(ColorHandler del)
        {
            colorDel += del;
        }

        public void DeleteColor(ColorHandler del)
        {
            colorDel -= del;
        }
    }
}

