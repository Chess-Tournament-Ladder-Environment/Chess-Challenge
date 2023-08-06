namespace ChessChallenge.Application
{
    static class Program
    {
        public static void Main()
        {
            var bot = new MyBot();
            new UCI(bot).StartUciMessageLoop();
        }
    }
}