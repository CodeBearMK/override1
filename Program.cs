namespace override1
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal dog  = new Animal();
            dog.Mammal = "狗";
            dog.display();
            Console.WriteLine("--------------------");
            Person per = new Person();
            per.display();
            Console.Read();
        }
    }
}