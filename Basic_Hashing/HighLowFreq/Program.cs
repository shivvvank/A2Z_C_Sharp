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
            int high = Int32.MinValue;
            int low = Int32.MaxValue;
            int high_e = 0, low_e = 0;
            foreach(var i in d)
            {
                if(i.Value>high)
                {
                    high = i.Value;
                    high_e = i.Key;
                }
                if(i.Value<low)
                {
                    low = i.Value;
                    low_e = i.Key;
                }
            }
            System.Console.WriteLine("Highest Frequency Element : "+high_e+" Frequency : "+high);
            System.Console.WriteLine("Lowest Frequency Element : "+low_e+" Frequency : "+low);
        }
    }
}