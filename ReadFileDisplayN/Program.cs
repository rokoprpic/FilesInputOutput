namespace ReadFileDisplayN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var path = "text.txt";
            try
            {
                Console.WriteLine(File.ReadAllText(path).Split(' ').Count());
            } catch(Exception ex)
            {
                Console.WriteLine("error");
            }
        }
    }
}