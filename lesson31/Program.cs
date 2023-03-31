using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace lesson31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Task:2
            //Num();

            ////Task:8
            //Sait();

            ////Task:4
            //Console.WriteLine("Ededi daxil edin:");
            //string text = Console.ReadLine();
            //if (Tip(text))
            //{
            //    Console.WriteLine("Daxil edilmis eded Integer tipindedir: ");
            //}
            //else
            //{
            //    Console.WriteLine("Daxil edilmis eded Double tipindedir: ");
            //}

            ////Task:3
            //Show();

            ////Task:1
            //Print();

            ////Task:7
            ///
            //Ternary();

        }

        ////Task:8 İstifadəçidən cümlə qəbul edən və sonra cümlədəki saitlərin sayını hesablayan proqram yazın.Sonra saitlərin sayını ekrana çıxarın.
        //static void Sait()
        //{
        //    char[] herfler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü', 'ə' };
        //    string cumle;
        //    int say = 0;
        //    Console.WriteLine("Cümləni daxil edin : ");
        //    cumle = Console.ReadLine();
        //    for (int i = 0; i<herfler.Length; i++)
        //    {
        //        for (int j = 0; j<cumle.Length; j++)
        //        {
        //            if (cumle[j] == herfler[i])
        //            {
        //                say++;
        //            }
        //        }
        //    }
        //    Console.WriteLine(say);
        //    Console.ReadLine();
        //}

        ////Task:2 Tam ədədlər array’i yaradan və sonra elementlərin cəmini hesablayan proqram yazın.
        //static void Num()
        //    {
        //        int[] num = { 3, 5, 8, 12, 14, 17 };
        //        int sum = 0;
        //        for(int i=0; i<num.Length; i++)
        //        { 
        //            sum += num[i];
        //        }
        //        Console.WriteLine(sum);
        //    }

        // //Task:4 İstifadəçidən string ədəd qəbul edən və dəyərindən asılı olaraq sətri integer və ya double tipinə çevirən proqram yazin.
        //static bool Tip(string s)
        //{
        //    for (int i = 0; i < s.Length; i++)
        //        if (char.IsDigit(s[i]) == false)
        //            return false;
        //    return true;

        //}

        ////Task:3 İstifadəçidən cümlə qəbul edən və sonra hər sözün ilk hərfini böyük hərflə yazan proqram yaradın.Sonra dəyişdirilmiş cümləni ekrana çıxarın.
        //static void Show()
        //{
        //    Console.Write("Cumleni daxil edin: ");
        //    string cumle= Console.ReadLine();
        //    string Herf = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(cumle);
        //    string[] sira=cumle.Split(',');
        //    for(int i=0; i<sira.Length; i++)
        //    {
        //        sira[i] = sira[i].Trim();
        //    }
        //    Console.WriteLine(Herf);
        //}

        ////Task:1 İstifadəçidən string qəbul edən və sonra string’i sözlər array’inə ayıran proqram yaradın.Sonra array’dəki sözlərin sayını çıxarın.
        //static void Print()
        //{
        //    string text = null;
        //    string[] textArr = null;
        //    int count = 0;
        //    text =  "Which is where logic and compelling argument meet vested interest and political error." ;
        //    char[] chars = { ' ', ',','.' };
        //    textArr = text.Split(chars);
        //    for (count = 0; count < textArr.Length; count++)
        //    {
        //        Console.WriteLine(textArr[count]);
        //    }
        //}

        ////Task:7 İstifadəçidən ədəd qəbul edən proqram yaradın və sonra “ternary operator” istifadə edərək ədədin cüt və ya tək olduğunu yoxlayın.Sonra,nəticəni ekrana çıxarın.
        //static void Ternary()
        //{
        //    Console.WriteLine("Ededi daxil edin: ");
        //    int number=int.Parse(Console.ReadLine());
        //    bool isEven;

        //    isEven = (number % 2 == 0) ? true : false;
        //    Console.WriteLine(isEven);

        //}
    }
}
