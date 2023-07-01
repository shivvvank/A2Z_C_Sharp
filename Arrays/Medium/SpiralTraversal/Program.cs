using System.Buffers;
using System.Diagnostics;
using System.Numerics;
using System.Runtime;
using System.Threading.Tasks.Sources;

namespace Example {
    class Example {

        static List<int> SpiralTraversal(ref int[,] ma,int n,int m )
        {   
            // transpose
            List<int> l = new List<int>();
            int top = 0, left = 0,right = m-1, bottom=n-1;
            while(left<=right&&top<=bottom)
            {
                for(int i=left;i<=right;i++)
                {
                    l.Add(ma[top,i]);
                }
                top++;
                for(int i=top;i<=bottom;i++)
                {
                    l.Add(ma[i,right]);
                }
                right--;
                if(left<=right)
                {
                    for(int j=right;j>=left;j--)
                    {
                        l.Add(ma[bottom,j]);
                    }
                    bottom--;
                }
                if(top<=bottom)
                {
                    for(int i=bottom;i>=top;i--)
                    {
                        l.Add(ma[i,left]);
                    }
                    left++;
                }
            }
            return l;
        }
        static void swap(ref int a,ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }
        public static void Main(string[] args){
            Console.WriteLine("Enter number of rows : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number of Columns : ");
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] ma = new int[n,m];
            for(int i=0;i<n;i++)
            {
                for(int j = 0;j<m;j++)
                {
                    ma[i,j]=Convert.ToInt32(Console.ReadLine());
                }
            }
            List<int> l = SpiralTraversal(ref ma,n,m);
            foreach(var i in l)
            {
                System.Console.Write(i+" ");
            }
            System.Console.WriteLine();
        }
    }
}