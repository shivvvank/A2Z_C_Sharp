namespace Example {
    class Example {

        static void RotateMatrix(ref int[,] ma,int n,int m )
        {   
            // transpose
           for(int i=0;i<n;i++)
           {
                for(int j=0;j<=i;j++)
                {
                    swap(ref ma[i,j],ref ma[j,i]);
                }
           }
           //reverse rows
           for(int i=0;i<n;i++)
           {
                int ji=0,je=m-1;
                while(ji<=je)
                {
                    swap(ref ma[i,je],ref ma[i,ji]);
                    ji++;
                    je--;
                }
           }
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
            RotateMatrix(ref ma,n,m);
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