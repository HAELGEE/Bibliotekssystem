using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Bibliotekssystem;
public class Library
{
    public void SearchingForBook()
    {
        Choice Method1 = new Choice();

        bool loop = true;
        while (loop)
        {
            Console.Clear();
            Console.WriteLine("1. If you would like to search for a book by its TitleName");
            Console.WriteLine("2. If you would like to search for a book by its Writer");
            Console.WriteLine("3. If you would like to search for a book by its ISBN-Number");
            Console.WriteLine("4. To go back");
            Method1!.ChoiceOfUser();
            
            string text;
            switch (Method1.choice)
            {
                case 1:
                    Console.Clear();
                    Console.Write("What is the name of the book you want to search for?: ");
                    text = Console.ReadLine()!;
                    for (int i = 0; i < Book.TitleName.Count; i++)
                    {
                        if (Book.TitleName[i].Contains(text))
                        {
                            Console.WriteLine("\nSearching for books...");
                            Thread.Sleep(400);
                            Console.WriteLine("Found books...");
                            Thread.Sleep(200);
                            Console.WriteLine($"Title: {Book.TitleName[i]}, Writer: {Book.WriterName[i]}, ISBN-Number: {Book.IsbnNumber[i]}");
                        }
                        else
                        {
                            Console.WriteLine("The book is not in the list");
                        }
                    }
                    Console.ReadKey();
                    break;

                case 2:
                    Console.Clear();
                    Console.Write("What is the name of the writer you want to search for?: ");
                    text = Console.ReadLine()!;
                    for (int i = 0; i < Book.WriterName.Count; i++)
                    {
                        if (Book.WriterName[i].Contains(text))
                        {
                            Console.WriteLine("\nSearching for books...");
                            Thread.Sleep(400);
                            Console.WriteLine("Found books...");
                            Thread.Sleep(200);
                            Console.WriteLine($"Title: {Book.TitleName[i]}, Writer: {Book.WriterName[i]}, ISBN-Number: {Book.IsbnNumber[i]}");
                        }
                        else
                        {
                            Console.WriteLine("The book is not in the list");
                        }
                    }
                    Console.ReadKey();
                    break;

                case 3:
                    Console.Clear();
                    Console.Write("What is the name of the ISBN-number you want to search for?: ");
                    text = Console.ReadLine()!;
                    for (int i = 0; i < Book.IsbnNumber.Count; i++)
                    {
                        if (Book.IsbnNumber[i].Contains(text))
                        {
                            Console.WriteLine("\nSearching for books...");
                            Thread.Sleep(400);
                            Console.WriteLine("Found books...");
                            Thread.Sleep(200);
                            Console.WriteLine($"Title: {Book.TitleName[i]}, Writer: {Book.WriterName[i]}, ISBN-Number: {Book.IsbnNumber[i]}");
                        }
                        else
                        {
                            Console.WriteLine("The book is not in the list");
                        }
                    }
                    Console.ReadKey();
                    break;

                case 4:
                    Console.Clear();
                    loop = false;
                    break;
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
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid input, try again!");
                ChoiceOfUser();
            }
        }
    }
}
