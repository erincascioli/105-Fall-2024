namespace Book
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book firstBook = new Book();

            firstBook.Owner = "Me";
            C.WL(firstBook.IsUsed)
            bool isUsed = firstBook.IsUsed;
        }
    }
}