using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;


namespace Practice1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Task 1");
            //int x, x1, x2, x3;
            //Console.WriteLine("Enter a number");
            //x = int.Parse(Console.ReadLine());
            //x1 = int.Parse(Console.ReadLine());
            //x2 = int.Parse(Console.ReadLine());
            //x3 = int.Parse(Console.ReadLine());
            //for (int i = x3; i > 0; i--)
            //{
            //    Console.WriteLine(i);
            //}


            //Console.WriteLine("Task 2");
            //Console.WriteLine("Enter a 6 digit number");
            //string x_task2 = Console.ReadLine();
            //for (int i = 1; i < x_task2.Length; i += 2)
            //{
            //    Console.WriteLine(i);
            //}



            Console.WriteLine("Task 3");



            //Stopwatch time = new Stopwatch();
            //Console.WriteLine("Press Enter");
            //Console.ReadLine();
            //time.Start();
            //Console.WriteLine("Press Space");
            //while (true)
            //{
            //    Console.ReadLine();
            //    time.Stop();
            //    Console.WriteLine(time.Elapsed);


            //Работа со временем


            while (true)
            {
                ConsoleKey key = Console.ReadKey().Key;
                int keyCode = (int)key;
                Console.WriteLine($"\t Enum {key} \t key code {keyCode}");

            }
                DateTime startTime = DateTime.Now;
                Console.WriteLine(startTime.ToString(("yyy.MM.dd hh:mm:ss:ffff")));
                Console.ReadKey();
                DateTime stopTime = DateTime.Now;
                TimeSpan timeSpan = stopTime - startTime;
                Console.WriteLine($"\nПрошло {timeSpan.ToString("fgdgdg")} секунд и {timeSpan.ToString()} милисекунд");





            Console.WriteLine("Task 4");




            Console.WriteLine("Task 4");

            //работа с файловой системой
            //var - аналог auto

            var streamWriter = new StreamWriter("file.txt");
            streamWriter.WriteLine("TEST");
            streamWriter.Close();

            var streamReader = new StreamReader("file.txt");
            Console.WriteLine(streamReader.ReadLine());
            streamReader.Close();







            Console.ReadKey();

            }
        }


    }

