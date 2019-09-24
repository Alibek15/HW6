using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Class1
    {
        private int[] _array;

        public Class1()
        {
            Size = 1;
            _array = new int[Size];
        }

        public Class1(int size)
        {
            Size = size;
            _array = new int[Size];
        }

        public int Size { get; set; }

        public int this[int i]
        {
            get
            {
                return _array[i];
            }
            set
            {
                _array[i] = (int)Math.Pow((double)value, 2);
            }
        }
    }
}
