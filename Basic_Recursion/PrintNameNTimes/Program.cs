using System;

namespace Example {
    class Example {

        static void PrintNameNTimes(string name,int i)
        {
            if(i==0)
                return;
            System.Console.WriteLine(name);
            PrintNameNTimes(name,i-1);
        }
        public static void Main(string[] args){
            string name = Convert.ToString(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());
            PrintNameNTimes(name,n);
        }
    }
 }