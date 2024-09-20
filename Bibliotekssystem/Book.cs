using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotekssystem;
public class Book
{
    public static List<string> TitleName { get; set; } = new List<string>();
    public static List<string> WriterName { get; set; } = new List<string>();
    public static List<string> IsbnNumber { get; set; } = new List<string>();
    public static List<string> LendOutName { get; set; } = new List<string>();
    public static List<string> BorrowedBooks { get; set; } = new List<string>();
    public static bool found = true;
    public void Books()
    {
        Console.Write("Whats the Title of the book?: ");
        string? book = Console.ReadLine();

        while (string.IsNullOrWhiteSpace(book))
        {
            Console.WriteLine("You need to enter a Title of the book");
            book = Console.ReadLine();
        }  
        TitleName.Add(book);       
        
        Console.Write("What is the Writer's name?: ");
        string? writer = Console.ReadLine();

        while (string.IsNullOrWhiteSpace(writer))
        {
            Console.WriteLine("You need to enter the Writer's name of the book");
            writer = Console.ReadLine();            
        }
        WriterName.Add(writer);

        Console.Write("Whats it the ISBN-Number?: ");
        string? isbn = Console.ReadLine();

        while (string.IsNullOrWhiteSpace(isbn))
        {
            Console.WriteLine("You need to enter the ISBN-Number of the book");
            isbn = Console.ReadLine();
        }
        IsbnNumber.Add(isbn);
    }

    public void LendOut()
    {
        Console.Clear();
        Console.Write("Enter the ISBN-Number on the book you want to borrow: ");
        string? isbnCheck = Console.ReadLine()!;        

        while (string.IsNullOrWhiteSpace(isbnCheck))
        {
            Console.WriteLine("You need to enter the ISBN-Number of the book.");
            isbnCheck = Console.ReadLine()!;
        }

        for (int i = 0; i < IsbnNumber.Count; i++)
        {
            if (IsbnNumber[i].Contains(isbnCheck))
            {
                if (found)  //Kollar om bool är sann (Om den inte är utlånad redan)
                {
                    Console.Write("Enter your name: ");
                    LendOutName.Add(Console.ReadLine()!);
                    Console.WriteLine($"Title name: {TitleName[i]}, Writer name: {WriterName[i]}, ISBN-Number: {IsbnNumber[i]} is now borrowed to {LendOutName[i]}");
                    BorrowedBooks.Add($"Title name: {TitleName[i]}, Writer name: {WriterName[i]}, ISBN-Number: {IsbnNumber[i]}");
                    Console.ReadKey();
                    found = false;
                }else
                {
                    Console.WriteLine("The book is already lent out");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("There is no such book");
                Console.ReadKey();
            }
        }
    }
}
