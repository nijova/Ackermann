namespace Ackermann
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var max = 5;
            for (var i = 0; i <= max; i++)
                for (var j = 0; j <= max; j++)
            {
                Ackermann.Wrapper(i, j);
            }
        }
    }
}
