using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Far
{
    class Program
    {
        static void ShowInfo(DirectoryInfo directory, int cursor) // function to get information 
        {
            Console.BackgroundColor = ConsoleColor.White; // color of background where cursor is set
            int index = 0; // index for files
            foreach (FileSystemInfo fileInfo in directory.GetFileSystemInfos()) //cycle to show info about content
            {
                if (index == cursor) 
                    Console.ForegroundColor = ConsoleColor.Magenta; // paints chosen file into gray
                else
                    Console.ForegroundColor = ConsoleColor.DarkYellow; //the same
                index++;
                if (fileInfo.GetType() == typeof(FileInfo)) // to identify whether it is file or order
                {
                    Console.Write("This is file: ");
                }
                if (fileInfo.GetType() == typeof(DirectoryInfo))
                {
                    Console.Write("This is folder: ");
                }
                Console.WriteLine(fileInfo.Name); // name of files
            }
        }

        static void Main(string[] args)
        {
            int cursor = 0; // at the beginning
            DirectoryInfo directory = new DirectoryInfo(@"C:\Users\HOME\Desktop\programing technologies"); //our directory
            while (true)
            {
                Console.Clear(); // we should always clear our console because there will be another information after entering or escaping
                ShowInfo(directory, cursor); // our function 
                ConsoleKeyInfo button = Console.ReadKey();
                if (button.Key == ConsoleKey.UpArrow)
                    if(cursor>0)
                    cursor--;
                if (button.Key == ConsoleKey.DownArrow)
                    if (cursor < directory.GetFileSystemInfos().Length-1)
                    cursor++;
                if (button.Key == ConsoleKey.Enter)
                {
                    FileSystemInfo fsi = directory.GetFileSystemInfos()[cursor];
                    if (fsi.GetType() == typeof(DirectoryInfo))
                    {
                        directory = new DirectoryInfo(fsi.FullName);
                        cursor = 0;
                    }
                    if (fsi.GetType() == typeof(FileInfo))
                    {
                        StreamReader sr = new StreamReader(fsi.FullName);
                        Console.Clear();
                        Console.WriteLine(sr.ReadToEnd());
                        sr.Close();
                        Console.ReadKey();
                    }
                }
                if (button.Key == ConsoleKey.Backspace)
                {
                    directory = Directory.GetParent(directory.FullName);
                }
                if (button.Key == ConsoleKey.Escape)
                    break;
            }
        }
    }
}