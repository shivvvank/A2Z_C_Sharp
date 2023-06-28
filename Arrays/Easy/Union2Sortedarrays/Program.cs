namespace Example {
    class Example {

        static HashSet<int> Union(int[] a,int n,int[] b,int m)
        {  
            int i = 0,j=0;
            HashSet<int> s = new HashSet<int>();
            while(i<n)
            {
                s.Add(a[i++]);
            }
            while(j<m)
            {
                s.Add(b[j++]);
            }
            return s;
        }
        static List<int> Union2(int[] a,int n, int[] b,int m)
        {
            int i=0,j=0;
            List<int> ans = new List<int>();
            while(i<n&&j<m)
            {
                if(a[i]<b[j])
                {
                    if(ans.IndexOf(a[i])==-1)
                    {
                        ans.Add(a[i++]);
                    }
                    else
                    {
                        i++;
                    }
                }
                else if(a[i]>b[j])
                {
                    if(ans.IndexOf(b[j])==-1)
                    {
                        ans.Add(b[j++]);
                    }
                    else
                    {
                        j++;
                    }
                }
                else
                {
                    if(ans.IndexOf(a[i])==-1)
                    {
                        ans.Add(a[i++]);
                        j++;
                    }
                    else
                    {
                        i++;
                        j++;
                    }
                }
            }
            while(i<n)
            {
                if(ans.IndexOf(a[i])==-1)
                {
                    ans.Add(a[i++]);
                }
                else
                {
                    i++;
                }
            }
            while(j<m)
            {
                if(ans.IndexOf(b[j])==-1)
                {
                    ans.Add(b[j++]);
                }
                else
                {
                    j++;
                }
            }
            return ans;
        }
        public static void Main(string[] args){

            Console.WriteLine("Enter size of array 1");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            System.Console.WriteLine("Enter Array elements");
            for(int i=0;i<n;i++)
            {
                a[i]=Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Enter size of array 2");
            int m = Convert.ToInt32(Console.ReadLine());
            int[] b = new int[m];
            System.Console.WriteLine("Enter Array elements");
            for(int i=0;i<m;i++)
            {
                b[i]=Convert.ToInt32(Console.ReadLine());
            }
            
            System.Console.WriteLine("Union of two Arrays");
            List<int> c= Union2(a,n,b,m);
            foreach(int i in c)
            {
                System.Console.Write(i+" ");
            }
            System.Console.WriteLine();
        }
    }
}