using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;



namespace ConsoleApp2
{
    class Program
    {
        ArrayList Beowulf;


        static void Main(string[] args)
        {

            Program p = new Program();

            p.Beowulf = new ArrayList();

            p.ReadTextFiles();

        }
        public void Run()
        {



            this.ReadTextFiles();
        }

        public void ReadTextFiles()
        {
            using (StreamReader file = new StreamReader(@"U:\Users\731555\beowulf.txt"))
            {
                int counter = 0;

                int number = 0;

                string line;

                while ((line = file.ReadLine()) != null)

                {

                    if (line.Contains("Sea") && line.Contains("Fare") || line.Contains("sea") && line.Contains("fare"))

                    {

                        int x = counter - 1;

                        number++;

                    }

                    counter++;

                }

                Console.WriteLine($"The number of lines that contains *Sea* and *Fare* are {number}");



                file.Close();


                Console.WriteLine($"File has {counter} lines. ");


            }
        }

        public int FindNumberOfBlankSpaces(string line)
        {
            int counterletters = 0;

            int countSpaces = 0;

           
            return countSpaces;
        }
    }

}

