
// Erin Cascioli
// 9/4/24
// Playing with variables in-class 


namespace VariablesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Experimenting with line breaks and multiple lines in the editor
            Console.WriteLine("I love the color green and my favorite food " +
                "is stuffed shells.");

            Console.WriteLine(
                "I love the color green and my favorite food is stuffed shells.");

            // Printing a series of characters to "break up" the output
            // One way to break this for the console window is with a new line character \n
            Console.WriteLine("_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+\n" +
                "_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+");

            // Or you can use multiple C.WL statements
            Console.WriteLine("_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+");
            Console.WriteLine("_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+");


            Console.WriteLine("My character's name is Gertrude Stevens the seventh, " +
                "Toaster of Toast, First of her name, Ruler of Butter and Jelly, " +
                "Chocolatier of Denmark, Bane of those Gluten Free, HRH");

            Console.WriteLine("She has 2 XP.");

            Console.WriteLine("She has -9001 gold and owes the bank of Denmark.");

            Console.WriteLine("She has 2.4 health and close to death.");

            Console.WriteLine("Her special skill is to make an opera cake.");
        }
    }
}
