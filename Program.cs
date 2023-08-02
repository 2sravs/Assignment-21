using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConAppAssignment21
{
    public class Program
    {
        public static void NameofDays(List<string> days)
        {
            Console.WriteLine("Days of Week");
            foreach(var day in days)
            {
                Console.WriteLine(day);
                Thread.Sleep(2000);
            }


        }
        public static void AllMonths(List<string> months)
        {
            Console.WriteLine("Months of Year");
            foreach (var month in months)
            {
                Console.WriteLine(month);
                Thread.Sleep(2000);
            }

        }
        public static void DisplayFruits(List<string> fruits)
        {
            Console.WriteLine("fruits");
            foreach (var fruit in fruits)
            {
                Console.WriteLine(fruit);
                Thread.Sleep(2000);
            }

        }
        public static void DisplayMeanings(Dictionary<string,string> meanings)
        {
            Console.WriteLine("Words with Meanings ");
            foreach (var meaning in meanings)
            {
                Console.WriteLine(meaning);
                Thread.Sleep(2000);
            }

        }
        static void Main(string[] args)
        {
            List<string> fruits = new List<string>()
            { "Apple","orange","Mango","Strawberry","Kiwi","Banana","Papaya","Watermelon","Gauva","Fig"};
            List<string> Days = new List<string>()
            {
                "Monday","Tuesday","wednesday","thursday","friday","Saturday","Sunday"
            };
            List<string> Months = new List<string>()
            {
                 "January", "Febrary", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"
            };
            Dictionary<string, string> meanings = new Dictionary<string, string>();
            meanings.Add("Public", "A public member can be accessed by other classes. ");
            meanings.Add("Internal", "The internal keyword is an access modifier for types and type members.");
            meanings.Add("Handlin", "An exception is thrown from an area of code where a problem has occurred.");
            meanings.Add("Exception", "a problem that arises during the execution of a program");
            meanings.Add("List", "a collection of strongly typed objects. ");
            Console.WriteLine("-----------------Welcome to Learning-------------------");
            var startTime = DateTime.Now;
            NameofDays(Days);
            var endTime = DateTime.Now;
            Console.WriteLine("Start time: " + startTime + " end time: " + endTime);
            Thread.Sleep(5000);
            var startTime1 = DateTime.Now;
            AllMonths(Months);
            var endTime1 = DateTime.Now;
            Console.WriteLine("Start time: " + startTime1 + " end time: " + endTime1);
            Thread thread1 = new Thread(() => DisplayFruits(fruits));
            Thread thread2 = new Thread(() => DisplayMeanings(meanings));
            thread1.Start();
            thread2.Start();
            Console.ReadKey();
        }

       
    }

}
