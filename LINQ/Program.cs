namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> game = new List<string>()
            {
                "Gta 5", "Red Dead Redemption", "Fortnite", "Rainbow Six Siege"
            };

            game.OrderBy(x => x.Length).ToList().ForEach(Console.WriteLine);

            //var lengthOfName = game.OrderBy(x => x.Length).ToList();
            //foreach (var item in lengthOfName)
            //{
            //    Console.WriteLine(item);
            //}

            
        }
    }
}
