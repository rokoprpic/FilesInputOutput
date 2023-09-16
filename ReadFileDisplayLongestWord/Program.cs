namespace ReadFileDisplayLongestWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var path = "text.txt";
            try
            {
                var words = File.ReadAllText(path).Split(' ');
                var max = words[0];
                foreach (var word in words)
                {
                    if(word.Length>max.Length)
                        max = word;
                }
                Console.WriteLine(max);
            }
            catch (Exception)
            {
                Console.WriteLine("error");
            }
        }
    }
}