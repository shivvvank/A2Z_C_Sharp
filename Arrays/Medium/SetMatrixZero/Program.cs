using System.Buffers;
using System.Numerics;

namespace Example {
    class Example {

        static void SetMatrixZero(ref int[,] ma,int n,int m )
        {
            int col0 = 0;
            for(int i=0;i<n;i++)
            {
                for(int j = 0;j<m;j++)
                {
                    if(ma[i,0]==0)
                    {
                        col0=1;
                    }
                }
            }
            for(int i=0;i<n;i++)
            {
                for(int j = 0;j<m;j++)
                {
                    if(ma[i,j]==0)
                    {
                        ma[i,0]=0;
                        ma[0,j]=0;
                    }
                }
            }
            // setting rows zero
            for(int i=1;i<n;i++)
            {
                if(ma[i,0]==0)
                {
                    for(int j=1;j<m;j++)
                    {
                        ma[i,j]=0;
                    }
                }
            }
            // setting columns zero
            for(int j=1;j<m;j++)
            {
                if(ma[0,j]==0)
                {
                    for(int i=1;i<n;i++)
                    {
                        ma[i,j]=0;
                    }
                }
            }
            if(ma[0,0]==0)
            {
                for(int j=0;j<m;j++)
                {
                    ma[0,j]=0;
                }
            }
            if(col0==1)
            {
                for(int i=0;i<n;i++)
                {
                    ma[i,0]=0;
                }
            }
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
            SetMatrixZero(ref ma,n,m);
            for(int i = 0;i<n;i++)
            {
                for(int j = 0;j<m;j++)
                {
                    Console.Write(ma[i,j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}