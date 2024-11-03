namespace PropertyListsPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Block block1 = new Block();
            Block block2 = new Block(50, 100, "brick");
            Block block3 = new Block(25, 300, "question");
            Block block4 = block2;

            block2.BlockType = "hidden";

            int[] myNumbers = { 10, 30, 50 };
            int valueFromArray = myNumbers[1];
        }
    }
}