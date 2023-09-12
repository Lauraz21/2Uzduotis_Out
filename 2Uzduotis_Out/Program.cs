namespace _2Uzduotis_Out
{
    public class Program
    {
        public static void Main(string[] args)
        {
            GetUserData(out string name, out string surname);
            Console.WriteLine(name + " " + surname);
        }
        public static void GetUserData(out string name, out string surname)
        {
            name = Console.ReadLine();
            surname = Console.ReadLine();
        }
    }
}