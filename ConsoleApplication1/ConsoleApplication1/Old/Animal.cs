using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Animal:IDescription
    {
        protected string name;
        private int size;

        protected void SetSize(int s)
        {
            size = s;
        }


        protected string ShowSize {
            get
            {
                if (size <= 10 && size>0) return "small";
                if (size >= 11 && size <= 20) return "medium";
                return size >= 21 ? "large" : "size not exist";

            }
        }


        protected void GetName(string N) {
            name = N;
        }

        public void SetData(string n, int s)
        {
            GetName(n);
            SetSize(s);
        }

        public virtual string ShowData() => "Name is " + name + "\nSize is " + ShowSize;
    }
}
