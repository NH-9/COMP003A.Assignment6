using System.Xml.Serialization;

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
            int choice = 0;

            while (choice != 3)
            {
                Console.Write("\nEnter Choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        {
                            Console.Write($"Item 1 - ");
                            book1.DisplayValues();
                            Console.Write($"Item 2 - ");
                            book2.DisplayValues();
                            Console.Write($"Item 3 - ");
                            book3.DisplayValues();
                            break;
                        }

                    case 2:
                        {
                            Console.Write($"Selete Item (1-3): ");
                            int item = int.Parse(Console.ReadLine());
                            switch (item)
                            {
                                case 1:
                                    {
                                        book1.UpdateValue();
                                        break;
                                    }

                                case 2:
                                    {
                                        book2.UpdateValue();
                                        break;
                                    }

                                case 3:
                                    {
                                        book3.UpdateValue();
                                        break;
                                    }
                            }
                            Console.WriteLine($"Updated Item {item}");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Program Ended.");
                            break;
                        }
                }
            }
        }
    }
}
