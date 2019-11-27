using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZmienneTypyDanych
{
    class Program
    {
        static void Main(string[] args)
        {
            //string  /*typ danych*/ nazwaZmiennej /* nazwa zmiennej*/;

            //nazwaZmiennej = "abcd";

            //Console.WriteLine(nazwaZmiennej);
            //Console.ReadKey();

            // Typy liczbowe - liczby całkowite

            byte vByte = 255;
            Console.WriteLine($"vByte: {vByte}");
            Console.WriteLine($"byte min: {Byte.MinValue.ToString()},  byte max: {Byte.MaxValue.ToString()}");

            sbyte vSbyte = 7;
            Console.WriteLine($"vSbyte: {vSbyte}");
            Console.WriteLine($"sbyte min: {SByte.MinValue.ToString()},  sbyte max: {SByte.MaxValue.ToString()}");

            short vShort = 255;
            Console.WriteLine($"vShort: {vShort}");
            Console.WriteLine($"short min: {Int16.MinValue.ToString()},  short max: {Int16.MaxValue.ToString()}");

            ushort vUshort = 255;
            Console.WriteLine($"vUshort: {vUshort}");
            Console.WriteLine($"ushort min: {UInt16.MinValue.ToString()},  ushort max: {UInt16.MaxValue.ToString()}");

            int vInt = 255;
            Console.WriteLine($"vInt: {vInt}");
            Console.WriteLine($"int min: {Int32.MinValue.ToString()},  int max: {Int32.MaxValue.ToString()}");

            uint vUint = 255;
            Console.WriteLine($"vUint: {vUint}");
            Console.WriteLine($"uint min: {UInt32.MinValue.ToString()},  uint max: {UInt32.MaxValue.ToString()}");

            long vLong = 255;
            Console.WriteLine($"vLong: {vLong}");
            Console.WriteLine($"long min: {Int64.MinValue.ToString()},  long max: {Int64.MaxValue.ToString()}");

            ulong vUlong = 255;
            Console.WriteLine($"vUlong: {vUlong}");
            Console.WriteLine($"ulong min: {UInt64.MinValue.ToString()},  ulong max: {UInt64.MaxValue.ToString()}");

            //Typy liczbowe - Zmienno przecinkowe
            Console.WriteLine("----------------------------------Zmienno przecinkowe----------------------------------");


            float vFloat = 0.455f;
            Console.WriteLine($"vFloat: {vFloat}");
            Console.WriteLine($"float min: {Single.MinValue.ToString()},  float max: {Single.MaxValue.ToString()}");

            Console.WriteLine($"Wartość float po formatowaniu {vFloat.ToString("0.00")}");
            Console.WriteLine($"Wartość float po formatowaniu {vFloat.ToString("#.00")}");

            double vDouble = 0.455;
            Console.WriteLine($"vDouble: {vDouble}");
            Console.WriteLine($"double min: {Double.MinValue.ToString()},  double max: {Double.MaxValue.ToString()}");

            decimal vDecimal = 0.455m;
            Console.WriteLine($"vDecimal: {vDecimal}");
            Console.WriteLine($"decimal min: {Decimal.MinValue.ToString()},  double max: {Decimal.MaxValue.ToString()}");

            //Typ logiczny - bool
            Console.WriteLine("----------------------------------Bool----------------------------------");

            bool vBool = true;
            Console.WriteLine($"vBool: {vBool}");

            Console.WriteLine();
            //Nullable
            int? zmienna = null;
            Console.WriteLine();
            //Typ znakowy
            char vChar = 'a';
            Console.WriteLine($"vChar: {vChar}");

            //Łańcuch znaków - string
            Console.WriteLine();
            string imie = "Jan";
            string nazwisko = "   Kowalski   ";
            string nazwisko2 = "Kowalski";
            Console.WriteLine($"duzymi znakami: {imie.ToUpper()}");
            Console.WriteLine($"malymi znakami: {nazwisko.ToLower()}");
            Console.WriteLine($"{imie} {nazwisko}");
            Console.WriteLine($"{imie.Trim()} {nazwisko.Trim()}");
            Console.WriteLine($" {nazwisko2.Substring(2, 2)}");

            string sciezka1 = "c:\\windows\\Users\\student";
            Console.WriteLine(sciezka1);
            string sciezka2 = $@"c:\windows\Users\student";
            Console.WriteLine(sciezka2);

            // Typ var
            Console.WriteLine();
            var zmiennaVar = 0;
            Console.WriteLine($"zmiennaVar: {zmiennaVar.GetType()}");

            //Typ dynamic
            Console.WriteLine();
            dynamic zmiennaDynamic = 0;
            Console.WriteLine($"zmiennaDynamic: {zmiennaDynamic} {zmiennaDynamic.GetType()}");
            zmiennaDynamic = "sssss";
            Console.WriteLine($"zmiennaDynamic: {zmiennaDynamic} {zmiennaDynamic.GetType()}");
            // Typ object
            Console.WriteLine();
            object obiekt = 0;
            Console.WriteLine($"obiekt: {obiekt} typ: {obiekt.GetType() }");
            obiekt = "hello world";
            Console.WriteLine($"obiekt: {obiekt} typ: {obiekt.GetType() }");

            //DataTime
            Console.WriteLine();
            Console.WriteLine($"teraz: {DateTime.Now}");
            Console.WriteLine($"dzis: {DateTime.Today}");
            Console.WriteLine($"wczoraj: {DateTime.Today.AddDays(-1)}");
            Console.WriteLine($"jutro: {DateTime.Today.AddDays(1)}");
            Console.WriteLine($"dayofyear: {DateTime.Today.DayOfYear}");
            Console.WriteLine($"utcnow: {DateTime.UtcNow}");
            
            
            Console.WriteLine();
            DateTime date1 = DateTime.Now;
            DateTime date2 = DateTime.UtcNow;

            Console.WriteLine($"konwersja utc to local {date2} => {date2.ToLocalTime()}");

            Console.WriteLine($"data krotki format {date1.ToShortDateString()}");
            Console.WriteLine($"data dlugi format {date1.ToLongDateString()}");

            Console.WriteLine($"czas krotki format {date1.ToShortTimeString()}");
            Console.WriteLine($"czas dlugi format {date1.ToLongTimeString()}");

            Console.WriteLine($"nasz wybrany format {date1.ToString("yyyy/MM/dd  HH:mm:ss")}");
            Console.WriteLine($"nasz wybrany format {date1.ToString("yyyy/MM/dd  hh:mm:ss")}");

            
            DateTime dateTime = new DateTime(2017,9,18);
            Console.WriteLine($"dateTime long format {dateTime.ToLongDateString()}");

            // typof
            Console.WriteLine();
            Console.WriteLine($"string: {typeof(string)}");
            Console.WriteLine($"decimal: {typeof(decimal)}");
            Console.WriteLine($"int: {typeof(int)}");
            Console.WriteLine($"DateTime: {typeof(DateTime)}");


            Console.WriteLine();
            DateTime aktualnaData = DateTime.Today;
            Console.WriteLine($"Aktualna data: {aktualnaData}");
            Console.WriteLine($"Obecny dzien: {aktualnaData.DayOfYear}");
            Console.WriteLine($"Rok przestępny: { DateTime.IsLeapYear(aktualnaData.Year)}");
            
            Console.WriteLine();
            DateTime data_zadanie = DateTime.Today;
            data_zadanie= data_zadanie.AddDays(1);
            Console.WriteLine($"dzien tygodnia: {data_zadanie.DayOfWeek}");

            Console.WriteLine();
            Console.WriteLine($"Podaj imie");
            string vImie = Console.ReadLine();
            Console.WriteLine($"Podaj nazwisko");
            string vNazwisko = Console.ReadLine();
            Console.WriteLine($"Inicjały: {vImie.Substring(0,1).ToUpper()}{vNazwisko.Substring(0,1).ToUpper()}");

            Console.WriteLine();
            int vLiczba1=1, vLiczba0=0;
            //Console.WriteLine($"dzielenie przez 0 int: { vLiczba1/vLiczba0}");
            float vFLiczba1=1f, vFLiczba0=0f;
            Console.WriteLine($"dzielenie przez 0 float: {vFLiczba1 / vFLiczba0}");

            Console.ReadKey();

        }
    }
}
