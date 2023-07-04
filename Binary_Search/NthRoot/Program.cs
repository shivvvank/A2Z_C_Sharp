using System.Numerics;

namespace Example {
    class Example {

        static int mult(int a,int n,int m)
        {
            int i = 1;
            int ans = 1; 
            int flag=0;
            while(i<=n)
            {
                ans=ans*a;
                i++;
                if(ans>m||ans<=0)
                {
                    flag=1;
                    break;
                }
            }
            if(flag==1)
                return Int32.MaxValue;
            else
                return ans;
        }
        static int sqrt(int n,int m)
        {
            int i=1,j=m;
            while(i<=j)
            {
                int mid = i+(j-i)/2;
                int x = mult(mid,n,m);
                System.Console.WriteLine(mid+" "+x);
                if(x==m)
                {
                    return mid;
                }
                else if(x<m)
                {
                    i=mid+1;
                    System.Console.WriteLine("going right");
                }
                else
                {
                    j=mid-1;
                    System.Console.WriteLine("going left");
                }
            }
            return -1;
        }
        public static void Main(string[] args){
            Console.WriteLine("Enter times : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number : ");
            int m = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine(n+"th root of "+m+" is "+sqrt(n,m));
        }
    }
}