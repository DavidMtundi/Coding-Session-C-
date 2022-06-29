namespace TutorsEquity.Principles
{
    class receiveinputs
    {
        public static string getString(string nametoinput)
        {
            Console.WriteLine($"Please input {nametoinput}");
            return Console.ReadLine();

        }
        public static int getint(string nametoinput)

        {
            Console.WriteLine($"Please input {nametoinput}");
            return int.Parse(Console.ReadLine());
        }
    }
}
