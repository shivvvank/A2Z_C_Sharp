namespace Example {

    class StackQ{

        Queue<int> st;
        public StackQ()
        {
            st = new Queue<int>();
        }
        public bool push(int val)
        {
            int n = st.Count;
            st.Enqueue(val);
            while(n>0)
            {
                int temp = st.Peek();
                st.Dequeue();
                st.Enqueue(temp);
                n--;
            }
            System.Console.WriteLine("Pushed : "+val);
            return true;
        }
        public bool pop()
        {
            if(st.Count==0)
                return false;
            int n = st.Peek();
            st.Dequeue();
            System.Console.WriteLine("Popped : "+n);
            return true;
        }
        public void peek()
        {
            if(st.Count==0)
                return;
            System.Console.WriteLine("Top Element : "+st.Peek());
        }
    }
    class Example {
        public static void Main(string[] args){
            char ch = 'y';
            StackQ st  = new StackQ();
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