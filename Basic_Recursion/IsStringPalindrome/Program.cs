namespace Example {
    class Example {

        static bool IsStringPalindrome(string? s,int i)
        {
            if(i>(s.Length/2))
                return true;
            if(s[i]!=s[(s.Length)-i-1])
                return false;
            return IsStringPalindrome(s,i+1);
        }
        public static void Main(string[] args){
            string? s = Console.ReadLine();
            if(IsStringPalindrome(s,0))
                System.Console.WriteLine("String is Palindrome");
            else 
                System.Console.WriteLine("String is not palindrome");

        }
    }
}