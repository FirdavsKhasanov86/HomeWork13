using System;

namespace HomeWork13
{
    class Program
    {
        static void Main(string[] args)
        {
            //Medthood Pop
            string[] numbers = { "1", "2", "3", "4", "5" };
            
            foreach (var y in numbers)
            {
                Console.WriteLine(y);
            }
            Console.WriteLine("------------------------------");
            ArrayHelper<string> ar = new ArrayHelper<string>();
            ar.Pop(ref numbers);
            foreach (var y in numbers)
            {
                Console.WriteLine(y);
            }

        }
    }

    class ArrayHelper<T>
    {
        public T Pop(ref T[] stringArr)
        {

            T[] arr = new T[stringArr.Length - 1];
            for (int i = 0; i < stringArr.Length - 1; i++)
            {
                arr[i] = stringArr[i];

            }
            T a = stringArr[stringArr.Length - 1];
            stringArr = arr;
            return a;
        }
    }
}
