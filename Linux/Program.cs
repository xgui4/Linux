namespace Linux
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            OS linux = new OS(
                "Linux", 
                "Linux", 
                "6.10",
                "6", 
                "X64",
                "PC", 
                true, 
                true);
            Console.WriteLine(linux.ToString());
        }
    }
}