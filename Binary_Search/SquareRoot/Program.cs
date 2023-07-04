using System.Numerics;

namespace Example {
    class Example {

        static int sqrt(int n )
        {
            int i = 1,j=n;
            int ans = -1;
            while(i<=j)
            {
                int mid = i+(j-i)/2;
                if(mid*mid==n)
                {
                    return mid;
                }
                else if(mid*mid<n)
                {
                    i=mid+1;
                    ans=mid;
                }
                else
                {
                    j=mid-1;  
                }
            }
            return ans;
        }
        public static void Main(string[] args){
            Console.WriteLine("Enter the number : ");
            int n = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("rount of Square root of "+n+" is "+sqrt(n));
        }
    }
}