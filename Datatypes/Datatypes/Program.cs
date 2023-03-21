using System;

namespace Datatypes
{ 
    class Program
    {
        static void Main(string[] args)
        {
            // Koodi tulee tänne
            // Syntaksi - syntaksi
            // syntax error
            // Tämä on kommentti
            // Kommentit eivät suorita mitään

            // Datatypes - datatyypit
            // Numeroita
            // 35 - kokonaisluku - integer
            // 13.5 - liuluku - floating point
            // Merkkejä - char (yksimerkki) / merkkijono - string (useampimerkki) 
            // 't' / "word"
            // Bool
            // true / walse  voidaan kuvata myös 1/0
            // Literals 
            // data on tallessa muuttujissa - variable
            // <data_type> <variable name> (datatyyppi ja muutuja nimi)
            //
            // int
            int apu = 5;
            int integerValue = 10; //puolipiste rivin loppuun 
            integerValue = 15;
            // double - liukuluku
            double doubleValue;
            doubleValue = 3.14;
            char characterValue = 'r';
            // strig
            string stringValue = "Word";
            //bool
            bool boolValue = false;

            // kommunikointi sovelluksen kanssa
            // käyttäjänä

            // luokaa muuttuja nimeltä message
            // ja antakaa sille arvoksi "Hello"

            string message = "Hello";
            Console.WriteLine(message);
            string input;
            input = Console.ReadLine();
            // "vastasi x", jossa x on käyttäjän syöte(input).
            Console.WriteLine("Vastasit {0}", input);
            Console.WriteLine($"Interpolating {input}");
            Console.WriteLine("Vastasit " + input);

            #region 3 C# Perus: Ikä-tehtävä
            Console.Write("Kerro ikäs: ");
            string userInput = Console.ReadLine();
            int age = int.Parse(userInput);
            Console.WriteLine($"Olet {age} vuotta!");
            int sum = age * 12;
            Console.WriteLine($" Olet siis {sum} kuukautta vanha!");
            // matemaattiset laskut luku muuttujille +,-,*,/,%

            //int sum = 5 + 4;
            // sum = 9
            // sum = 7 + age;
            // sum = sum + age;
            // sum += age;
            // voidaan laittaa eri merkkejä 

            


        }
    }
}
