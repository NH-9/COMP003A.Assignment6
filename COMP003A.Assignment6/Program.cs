namespace COMP003A.Assignment6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("No Longer Human", 177, true);
            Book book2 = new Book("Thus Spoke Zarathustra", 336, false);
            Book book3 = new Book("The Divine Comedy", 895, false);

            Console.WriteLine("1. Display all \n2. Update One Item \n3. Exit");
        }
    }
}
