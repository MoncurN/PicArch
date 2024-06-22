using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PicArch.ConsoleApp.Screens;

public class InitConfigScreens
{
    public string? AskUserForExcelPath()
    {
        Console.WriteLine("Path to Excel file is not know.");
        Console.WriteLine("Would you like to specify an Excel directory path? Or just use the default location?");
        Console.WriteLine("Please enter a valid directory path, or leave blank for default:");
        Console.WriteLine("(Note - just specify the directory where you want to store the Excel file. I'll get the file name in a minute.)");
        Console.Write("> ");
        var directoryPath = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(directoryPath))
        {
            Console.WriteLine("You specified the default path. Will create an Excel file there.");
        }
        else
        {
            var directoryExists = Directory.Exists(directoryPath);
            if (!directoryExists)
            {
                Console.WriteLine("The directory you specified does not exist. Would you like me to create it?");
                Console.WriteLine("(Y)es or (N)o: ");
                Console.Write("> ");
                var shouldCreate = Console.ReadLine();
            }
        }
        return directoryPath;
    }
}