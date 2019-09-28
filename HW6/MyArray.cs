using System;

namespace HW6
{
    public class MyArray
    {
        private int[] _array;
        public int Length { get; set; }

        public MyArray()
        {
            Length = 0;
            _array = new int[Length];
        }

        public MyArray(int Length)
        {
            Length = Length;
            _array = new int[Length];
        }

        public int this[int i]
        {
            get
            {
                return _array[i];
            }
            set
            {
                _array[i] = (int)Math.Pow(value, 2);
            }
        }

        public void Add(int number)
        {
            int[] newArray = new int[++Length];
            for(int i = 0; i < newArray.Length; i++)
            {
                if (i == Length - 1) //последняя итерация
                {
                    newArray[i] = number;
                    break;
                }
                newArray[i] = _array[i];
            }
            _array = newArray;
        }
    }
}
