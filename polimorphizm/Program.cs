namespace polimorphizm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Group group = new Group();
            restart:
            Console.WriteLine("1.Student elave edin");
            Console.WriteLine("2.Student siyahısı");
            string result = Console.ReadLine();
            if (result == "1")
            {
                Console.Clear();
                group.AddStudent();
                goto restart;
            }
            else if (result == "2")
            {
                Console.Clear();
                group.GetStudent();
                goto restart;
            }
            else
            {
                Console.WriteLine("Dogru reqem daxil edin");
            }

        }
    }
}