using System;

namespace HomeWork13
{
    class Program
    {
        static void Main(string[] args)
        {
            //Medthood Pop
            // string[] numbers = { "1", "2", "3", "4", "5" };
            
            // foreach (var y in numbers)
            // {
            //     Console.WriteLine(y);
            // }
            // Console.WriteLine("------------------------------");
            // ArrayHelper<string> ar = new ArrayHelper<string>();
            // ar.Pop(ref numbers);
            // foreach (var y in numbers)
            // {
            //     Console.WriteLine(y);
            // }


            //Medthood Push
            // string[] numbers = { "1", "2", "3", "4", "5",  };
            // foreach (var y in numbers) 
            // {
            //     Console.WriteLine(y);
            // }
            // Console.WriteLine("------------------------------");

            // ArrayHelper<string> ar = new ArrayHelper<string>();
            // ar.Push(ref numbers, "6");
            // foreach (var y in numbers)
            // {
            //     Console.WriteLine(y);
            // }

            //Medthood Shift
            // string[] numbers = { "1", "2", "3", "4", "5",  };
            // foreach (var y in numbers) 
            // {
            //     Console.WriteLine(y);
            // }
            // Console.WriteLine("------------------------------");
            // ArrayHelper<string> ar = new ArrayHelper<string>();
            // ar.Shift(ref numbers); 
            // //ArrayHelper.Shift(ref numbers);
            // foreach (var y in numbers)
            // {
            //     Console.WriteLine(y);
            // }

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

        public void Push(ref T[] stringArr,T mac)
        {

            T[] arr = new T[stringArr.Length + 1];
            for (int i = 0; i < stringArr.Length; i++)
            {
                arr[i] = stringArr[i];

            }
            arr[arr.Length - 1] = mac;
            stringArr = arr;
        }

        public  T Shift(ref T[] stringArr)
        {

            T[] arr = new T[stringArr.Length-1];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = stringArr[i+1];

            }
            T s = stringArr[0];
            stringArr = arr;
            return s;
        }

    }


}
