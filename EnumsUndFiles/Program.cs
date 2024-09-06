using System;
using System.IO;

namespace EnumsUndFiles
{
    // Define an enum representing months of the year, with integer values starting from 1 for January
    enum Months
    {
        Jan = 1,
        Feb,
        Mar,
        Apr,
        May,
        Jun,
        Jul,
        Aug,
        Sep,
        Oct,
        Nov,
        Dec
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Assigning my birth month (December) using the Months enum
            int myBirthMonth = (int)Months.Dec;
            int myBirthDay = 23;  // Set birth day
            int myBirthYear = 1997;  // Set birth year

            // Create a string with the full birth date formatted as MM/DD/YYYY
            string myBirthDate = $"My birthday is on {myBirthMonth}/{myBirthDay}/{myBirthYear}";

         
            File.WriteAllText("myfile.txt", "this is my text file!\n");
            
            Console.WriteLine(File.ReadAllText("myfile.txt"));


            File.AppendAllText("myfile.txt", "WooHoo more text added to file!\n");
         
            Console.WriteLine(File.ReadAllText("myfile.txt"));

            // Check if "newFile.txt" already exists
            if (!File.Exists("newFile.txt"))
            {
                
                File.Copy("myFile.txt", "newFile.txt");
            }
            else
            {
                
                File.Replace("newFile.txt", "myFile.txt", "backupFile.txt");
            }

            
            File.AppendAllText("newFile.txt", myBirthDate);
           
            Console.WriteLine(File.ReadAllText("newFile.txt"));
        }
    }
}