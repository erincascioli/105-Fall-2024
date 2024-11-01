namespace ClassesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random myRNG = new Random();

            // Instance of the Cookie class using the default constructor
            Cookie myDefaultCookie = new Cookie();

            // Instance of the class using the parameterized constructor
            Cookie myParamCookie1 = new Cookie("choc chip", 3.50, 3, true, null);
            Cookie myParamCookie2 = new Cookie("pumpkin", 3.50, 3, true, new string[1] {"cinnamon"});

            Console.WriteLine(myParamCookie1.flavor);
            Console.WriteLine(myParamCookie2.flavor);
        }
    }
}
