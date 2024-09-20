using System.Xml.Serialization;

namespace Bibliotekssystem;

public class Program
{

    static void Main(string[] args)
    {
        Choice Method1 = new Choice();
        Book Book = new Book();
        Library Library = new Library();

        bool loop = true;
        while (loop)
        {
            Console.Clear();
            Console.WriteLine("==== LIBRARY OF DOOM ====");

            Console.WriteLine("1. Add a new book:");
            Console.WriteLine("2. Search after a book:");
            Console.WriteLine("3. Lend out a book:");
            Console.WriteLine("4. Show borrowed books:");
            Console.WriteLine("5. Quit:");

            Method1.ChoiceOfUser();

            switch (Method1.choice)
            {
                case 1:
                    Console.Clear();
                    Book.Books();
                    break;
                case 2:
                    Console.Clear();
                    Library.SearchingForBook();
                    break;
                case 3:
                    Console.Clear();
                    Book.LendOut();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Borrowed books:");
                    for (int i = 0; i < Book.BorrowedBooks.Count; i++)
                    {
                        Console.WriteLine($"{Book.BorrowedBooks[i]}");
                    }
                    Console.ReadKey();
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("The library now closes, good bye!");
                    loop = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }

    }
}
public class Choice()
{
    public int choice { get; set; }

    public void ChoiceOfUser()
    {
        Console.WriteLine("Press the number on your keyboard for the menu you want to enter:");
        ConsoleKey key = Console.ReadKey(true).Key;

        if (key == ConsoleKey.D1 || key == ConsoleKey.NumPad1)
        {
            choice = 1;
        }
        else if (key == ConsoleKey.D2 || key == ConsoleKey.NumPad2)
        {
            choice = 2;
        }
        else if (key == ConsoleKey.D3 || key == ConsoleKey.NumPad3)
        {
            choice = 3;
        }
        else if (key == ConsoleKey.D4 || key == ConsoleKey.NumPad4)
        {
            choice = 4;
        }
        else if (key == ConsoleKey.D5 || key == ConsoleKey.NumPad5)
        {
            choice = 5;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Invalid input, try again!");
            ChoiceOfUser();
        }
    }
}
