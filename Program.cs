using System;

namespace HomeWork13
{
    class Program
    {
        static void Main(string[] args)
        {
            //Medthod Pop
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


            //Medthod Push
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

            //Medthod Shift
            // string[] numbers = { "1", "2", "3", "4", "5",  };
            // foreach (var y in numbers) 
            // {
            //     Console.WriteLine(y);
            // }
            // Console.WriteLine("------------------------------");
            // ArrayHelper<string> ar = new ArrayHelper<string>();
            // ar.Shift(ref numbers); 
            
            // foreach (var y in numbers)
            // {
            //     Console.WriteLine(y);
            // }


            //Medthod UnShift
            // string[] numbers = { "1", "2", "3", "4", "5",  };
            // foreach (var y in numbers) 
            // {
            //     Console.WriteLine(y);
            // }
            // Console.WriteLine("------------------------------");
            //  ArrayHelper<string> ar = new ArrayHelper<string>();
            //  ar.UnShift(ref numbers, "0");
            // foreach (var y in numbers)
            // {
            //     Console.WriteLine(y);
            // }

            //Medthod Slice
            
            string[] alphabets = { "A","B","C","D","E","F","G","H"};
            ArrayHelper<string> ar = new ArrayHelper<string>();
             //ar.Slice(ref alphabet, 3);
             ar.Slice(ref alphabets, 1, -5);
             

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

         public  void UnShift(ref T[] stringArr, T mac)
        {
            T[] arr = new T[stringArr.Length + 1];
            arr[0] = mac;
            for (int i = 0; i < arr.Length-1; i++)
            {
                arr[i+1] = stringArr[i];
            }
            stringArr = arr;
        }

        public T[] Slice(ref T[] arr, int k)
        {
        if (k < 0)
        {
            T[] Arr = new T[Math.Abs(k)];
            int cn = 0;
            bool ch = true;
            for (int i = arr.Length - 1; ch; i--)
            {
                ch = !(cn == Math.Abs(k) - 1);
                Arr[cn] = arr[i];
                cn++;
            }
            return Arr;
        }
        else if (k > 0)
        {
            T[] Arr = new T[arr.Length - k + 1];
            int cn = 0;
            for (int i = 0; i <= k; i++)
            {
                Arr[cn] = arr[i];
                cn++;
            }
            return Arr;
        }
        else
        {
            return arr;
        }
    }
    public T[] Slice(ref T[] arr, int x, int y)
    {
        if (x > 0 && y > 0)
        {
            T[] Arr = new T[y - x + 1];
            int cn = 0;
            for (int i = x; i <= y; i++)
            {
                Arr[cn] = arr[i];
                cn++;
            }
            return Arr;
        }
        else if (x > 0 && y < 0)
        {
            T[] Arr = new T[arr.Length - Math.Abs(y) - 1];
            int cn = 0;
            for (int i = x; i <= Arr.Length; i++)
            {
                Arr[cn] = arr[i];
                cn++;
            }
            return Arr;
        }
        else
        {
            return arr;
        }


    }


  }
}
