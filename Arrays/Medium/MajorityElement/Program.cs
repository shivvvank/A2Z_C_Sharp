namespace Example {
    class Example {

        static int MajorityElement(int[] a,int n)
        {
            int e = 0,c=0;
            for(int i=0;i < n;i++)
            {
                if(c == 0)
                {
                    e = a[i];
                }
                if(e==a[i])
                {
                    c++;
                }
                else
                {
                    c--;
                }
            }
            return e;
        }

        public static void Main(string[] args){
            Console.WriteLine("Enter size of array");
            int n = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter Array elements");
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i]=Convert.ToInt32(Console.ReadLine());
            }
            System.Console.WriteLine("Majority element : "+MajorityElement(a,n));
        }
    }
}