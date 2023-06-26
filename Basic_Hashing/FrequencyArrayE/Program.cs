using System.Numerics;

namespace Example {
    class Example {

        public static void Main(string[] args){
            System.Console.WriteLine("Enter size of array : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            Dictionary<int,int> d = new Dictionary<int, int>();
            for(int i=0;i<n;i++)
            {
                a[i]=Convert.ToInt32(Console.ReadLine());
                if(!d.ContainsKey(a[i]))
                    d.Add(a[i],1);
                else
                    d[a[i]]++;
            }
            System.Console.WriteLine("Frequency : ");
            foreach(var i in d)
            {
                System.Console.WriteLine(i.Key+" : "+i.Value);
            }
        }
    }
}