using System;
using System.IO;

namespace WHDDUM
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("vezeteknev.txt");

            sw.WriteLine("Siska Dávid");
            sw.WriteLine("Gazdaságinformatikus");
            sw.WriteLine("WHDDUM");
           

            sw.Close();
            
           
            StreamReader sr = new StreamReader("vezeteknev.txt");


            string text = sr.ReadLine();
            while (text != null)
            {
                Console.WriteLine(text);

                text = sr.ReadLine();

            }
            sr.Close();


           

        }
    }
}
