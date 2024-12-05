namespace HelloWorld01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                Console.WriteLine("Hello World : " + args[0]);
            }
            else
            {
                Console.WriteLine("Hello World args.Lengh = 0 ");
            }
        }
    }
}
