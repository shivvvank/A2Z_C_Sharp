using System.Numerics;
using System.Reflection.Emit;

namespace Example {

    class StackE{
        int[] ds;
        int count;
        public StackE()
        {
            ds = new int[10000];
            count = 0;
        }
        public bool push(int a)
        {
            if(count>=10000)
                return false;
            ds[count++]=a;
            return true;
        }
        public bool pop()
        {
            if(count==0)
                return false;
            count--;
            return true;
        }
        public void peek()
        {
            if(count==0)
            {
                System.Console.WriteLine("No Element Present in Stack !");
                return;
            }
            System.Console.WriteLine("Top : "+ds[count-1]);
        }
    }
    class StackExample {

        public static void Main(string[] args){
            char ch = 'y';
            StackE st  = new StackE();
            while(ch=='y')
            {
                System.Console.WriteLine("Stack Menu : ");
                System.Console.WriteLine("  1. Push");
                System.Console.WriteLine("  2. Pop");
                System.Console.WriteLine("  3. Peek");
                System.Console.WriteLine("Enter Choice : ");
                
                int t = Convert.ToInt32(Console.ReadLine());
                switch(t)
                {
                    case 1 : 
                    System.Console.WriteLine("Enter element to push : ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    if(st.push(n))
                        System.Console.WriteLine("Element Pushed");
                    else
                        System.Console.WriteLine("Overflow!!");
                    System.Console.WriteLine("Enter y to begin again : ");
                    ch = Convert.ToChar(Console.ReadLine());
                    break;
                    case 2 :
                    if(st.pop())
                        System.Console.WriteLine("Popped from stack");
                    else
                        System.Console.WriteLine("Underflow!");
                    System.Console.WriteLine("Enter y to begin again : ");
                    ch = Convert.ToChar(Console.ReadLine());
                    break;
                    case 3 :
                    st.peek();
                    System.Console.WriteLine("Enter y to begin again : ");
                    ch = Convert.ToChar(Console.ReadLine());
                    break;
                    default : 
                    System.Console.WriteLine("Enter y to begin again : ");
                    ch = Convert.ToChar(Console.ReadLine());
                    break;
                }
            }
        }
    }
}
