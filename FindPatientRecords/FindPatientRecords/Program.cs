using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace FindPatientRecords
{
    //The main class
    class Program
    {
        //The main
        static void Main(string[] args)
        {
            // Read and show each line from the file.
            string line = "";
            int id;
            Console.WriteLine("Enter ID to be searched:");
            id = Convert.ToInt32(Console.ReadLine());
            //Try
            try
            {
                //text reader
                using (StreamReader sr = new StreamReader("PatientRecords.txt"))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        //split the line and extract the id
                        string[] tokens = line.Split(' ');
                        //if id's are the same
                        if (Convert.ToInt32(tokens[0]) == id)
                            Console.WriteLine(line);
                    }
                }
            }
            //Exception handling
            catch
            {
                Console.WriteLine("ERROR - The file is invalid");
            }
            Console.ReadKey();
        }
    }
}