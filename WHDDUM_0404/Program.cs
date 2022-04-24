using System;
using System.IO;

namespace gyak9
{
    class Program
    {
        static void Main(string[] args)
        {

            Fajlbair();
            read();
            lseek();
        }


        static void Fajlbair()
        {
            StreamWriter sw = new StreamWriter("WHDDUM.txt");

            sw.WriteLine("Név: Siska Dávid");
            sw.WriteLine("Szak: Gazdaságinformatikus");
            sw.WriteLine("Neptunkód: WHDDUM");

            sw.Close();

        }

     
         

        static void read()
        {
            StreamReader sr = new StreamReader("WHDDUM.txt");

            string sor = sr.ReadLine();

            int meret = 0;
            while(sor != null)
            {
                Console.WriteLine(sor);

                meret += sor.Length;
                sor = sr.ReadLine();
               
             

            }
            Console.WriteLine("A fájl mérete: {0} byte.",meret);
           

            sr.Close();


          
        }



        static void lseek()
        {
           
          
            Console.WriteLine("X: {0}, Y: {0}", Console.CursorLeft,Console.CursorTop);
        }
    }
}
