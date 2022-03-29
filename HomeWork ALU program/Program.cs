using System;

namespace HomeWork_ALU_program
{
        class Program
 {
            static void Main(string[] args)
  {

                int firstNum;
                int secondNum;
            int first4byte;
            int second4byte;
            string operation;
          
                int answer;
            int logicanswer;
                string firstselection;
                string logicselection;

                Console.WriteLine("Basic ALU // calculator");
                Console.Write("yapmak istediğiniz işlem türünü yazınız (mantık yada hesaplama) ");
            firstselection = Console.ReadLine();
            if (firstselection == "hesaplama")
            {
                Console.Write("işleme sokmak istediğiniz ilk sayıyı giriniz: ");
                firstNum = Convert.ToInt32(Console.ReadLine());
                Console.Write("işleme sokmak istediğiniz diğer sayıyı giriniz ");
                secondNum = Convert.ToInt32(Console.ReadLine());
                Console.Write("yapmak istediğiniz işlemi seçiniz");
                operation = Console.ReadLine();

                if (operation == "x")
                {
                    answer = firstNum * secondNum;
                    Console.WriteLine(firstNum + " x " + secondNum + " = " + answer);
                    string answerb = Convert.ToString(answer, 2);
                    string firstnumb = Convert.ToString(firstNum, 2);
                    string secondnumb = Convert.ToString(secondNum, 2);
                    Console.WriteLine("cevabımızın 2 lik tabandaki hali" + "   " + firstnumb + "x" + secondnumb + "=" + answerb);
                    Console.ReadLine();
                }
                else if (operation == "/")
                {
                    answer = firstNum / secondNum;
                    Console.WriteLine(firstNum + " / " + secondNum + " = " + answer);
                    string answerb = Convert.ToString(answer, 2);
                    string firstnumb = Convert.ToString(firstNum, 2);
                    string secondnumb = Convert.ToString(secondNum, 2);
                    Console.WriteLine("cevabımızın 2 lik tabandaki hali" + "   " + firstnumb + "/" + secondnumb + "=" + answerb);
                    Console.ReadLine();
                }
                else if (operation == "+")
                {
                    answer = firstNum + secondNum;
                    Console.WriteLine(firstNum + " + " + secondNum + " = " + answer);
                    string answerb = Convert.ToString(answer, 2);
                    string firstnumb = Convert.ToString(firstNum, 2);
                    string secondnumb = Convert.ToString(secondNum, 2);
                    Console.WriteLine("cevabımızın 2 lik tabandaki hali" + "   " + firstnumb + "+" + secondnumb + "=" + answerb);
                    Console.ReadLine();
                }
                else if (operation == "-")
                {
                    answer = firstNum - secondNum;
                    Console.WriteLine(firstNum + " - " + secondNum + " = " + answer);
                    string answerb = Convert.ToString(answer, 2);
                    string firstnumb = Convert.ToString(firstNum, 2);
                    string secondnumb = Convert.ToString(secondNum, 2);
                    Console.WriteLine("cevabımızın 2 lik tabandaki hali" + "   " + firstnumb + "-" + secondnumb + "=" + answerb);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("yanlış girdi lütfen tekrar deneyiniz");
                    Console.ReadLine();
                }
            }
            else if (firstselection == "mantık")
            {
                Console.WriteLine("değil operatörü bağlamak istiyor musunuz (evet / hayır)");
                string notselection = Console.ReadLine();
                if (notselection == "hayır")
                {

                    Console.WriteLine("lütfen yapmak istediğiniz işlemi seçiniz ( and / or / xor / xnor )");
                    logicselection = Console.ReadLine();
                    if (logicselection == "and")
                    {



                        Console.WriteLine("lütfen ilk 4 bitlik sayınızın 10 luk taban karşılığını giriniz");
                        first4byte = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(first4byte);
                        Console.WriteLine("lütfen ikinci 4 bitlik sayınızın 10 luk taban karşılığını giriniz");
                        second4byte = Convert.ToInt32(Console.ReadLine());

                        if (first4byte <= 15 & second4byte <= 15)
                        {
                            logicanswer = first4byte & second4byte;
                            string logicanswerb = Convert.ToString(logicanswer, 2);

                            if (logicanswerb.Length == 3)
                            {
                                Console.WriteLine("0" + logicanswerb);
                            }
                            else if (logicanswerb.Length == 2)
                            {
                                Console.WriteLine("00" + logicanswerb);
                            }
                            else if (logicanswerb.Length == 1)
                            {
                                Console.WriteLine("000" + logicanswerb);
                            }
                            else
                            {
                                Console.WriteLine(logicanswerb);
                            }
                        }
                        else
                        {

                            Console.WriteLine("girdiğiniz metin 0 ve 1 harici değer taşımaktadır");

                        }
                    }
                    else if (logicselection == "or")
                    {
                        Console.WriteLine("lütfen ilk 4 bitlik sayınızın 10 luk taban karşılığını giriniz");
                        first4byte = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(first4byte);
                        Console.WriteLine("lütfen ikinci 4 bitlik sayınızın 10 luk taban karşılığını giriniz");
                        second4byte = Convert.ToInt32(Console.ReadLine());
                        if (first4byte <= 15 & second4byte <= 15)
                        {
                            logicanswer = first4byte | second4byte;
                            string logicanswerb = Convert.ToString(logicanswer, 2);

                            if (logicanswerb.Length == 3)
                            {
                                Console.WriteLine("0" + logicanswerb);
                            }
                            else if (logicanswerb.Length == 2)
                            {
                                Console.WriteLine("00" + logicanswerb);
                            }
                            else if (logicanswerb.Length == 1)
                            {
                                Console.WriteLine("000" + logicanswerb);
                            }
                            else
                            {
                                Console.WriteLine(logicanswerb);
                            }
                        }
                        else
                        {

                            Console.WriteLine("girdiğiniz metin 0 ve 1 harici değer taşımaktadır");

                        }
                    }
                    else if (logicselection == "xor")
                    {

                        Console.WriteLine("lütfen ilk 4 bitlik sayınızın 10 luk taban karşılığını giriniz");
                        first4byte = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(first4byte);
                        Console.WriteLine("lütfen ikinci 4 bitlik sayınızın 10 luk taban karşılığını giriniz");
                        second4byte = Convert.ToInt32(Console.ReadLine());
                        if (first4byte <= 15 & second4byte <= 15)
                        {
                            logicanswer = first4byte ^ second4byte;
                            string logicanswerb = Convert.ToString(logicanswer, 2);

                            if (logicanswerb.Length == 3)
                            {
                                Console.WriteLine("0" + logicanswerb);
                            }
                            else if (logicanswerb.Length == 2)
                            {
                                Console.WriteLine("00" + logicanswerb);
                            }
                            else if (logicanswerb.Length == 1)
                            {
                                Console.WriteLine("000" + logicanswerb);
                            }
                            else
                            {
                                Console.WriteLine(logicanswerb);
                            }
                        }
                        else
                        {

                            Console.WriteLine("girdiğiniz metin 0 ve 1 harici değer taşımaktadır");

                        }
                    }
                    else if (logicselection == "xnor")
                    {

                        Console.WriteLine("lütfen ilk 4 bitlik sayınızın 10 luk taban karşılığını giriniz");
                        first4byte = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(first4byte);
                        Console.WriteLine("lütfen ikinci 4 bitlik sayınızın 10 luk taban karşılığını giriniz");
                        second4byte = Convert.ToInt32(Console.ReadLine());
                        if (first4byte <= 15 & second4byte <= 15)
                        {
                            logicanswer = first4byte ^ second4byte;
                            string logicanswerb = Convert.ToString(logicanswer, 2);
                            logicanswerb = logicanswerb.Replace("0", "a");
                            logicanswerb = logicanswerb.Replace("1", "b");
                            logicanswerb = logicanswerb.Replace("a", "1");
                            logicanswerb = logicanswerb.Replace("b", "0");
                            if (logicanswerb.Length == 3)
                            {

                                Console.WriteLine("0" + logicanswerb);
                            }
                            else if (logicanswerb.Length == 2)
                            {


                                Console.WriteLine("00" + logicanswerb);
                            }
                            else if (logicanswerb.Length == 1)
                            {

                                Console.WriteLine("000" + logicanswerb);
                            }
                            else
                            {

                                Console.WriteLine(logicanswerb);
                            }
                        }
                        else
                        {

                            Console.WriteLine("girdiğiniz metin 0 ve 1 harici değer taşımaktadır");

                        }
                    }

                }
                else if (notselection == "evet")
                {
                    Console.WriteLine("lütfen yapmak istediğiniz işlemi seçiniz ( and / or / xor / xnor )");
                    logicselection = Console.ReadLine();
                    if (logicselection == "and")
                    {



                        Console.WriteLine("lütfen ilk 4 bitlik sayınızın 10 luk taban karşılığını giriniz");
                        first4byte = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(first4byte);
                        Console.WriteLine("lütfen ikinci 4 bitlik sayınızın 10 luk taban karşılığını giriniz");
                        second4byte = Convert.ToInt32(Console.ReadLine());

                        if (first4byte <= 15 & second4byte <= 15)
                        {
                            logicanswer = first4byte & second4byte;
                            string logicanswerb = Convert.ToString(logicanswer, 2);
                            logicanswerb = logicanswerb.Replace("0", "a");
                            logicanswerb = logicanswerb.Replace("1", "b");
                            logicanswerb = logicanswerb.Replace("a", "1");
                            logicanswerb = logicanswerb.Replace("b", "0");

                            if (logicanswerb.Length == 3)
                            {
                                Console.WriteLine("0" + logicanswerb);
                            }
                            else if (logicanswerb.Length == 2)
                            {
                                Console.WriteLine("00" + logicanswerb);
                            }
                            else if (logicanswerb.Length == 1)
                            {
                                Console.WriteLine("000" + logicanswerb);
                            }
                            else
                            {
                                Console.WriteLine(logicanswerb);
                            }
                        }
                        else
                        {

                            Console.WriteLine("girdiğiniz metin 0 ve 1 harici değer taşımaktadır");

                        }
                    }
                    else if (logicselection == "or")
                    {
                        Console.WriteLine("lütfen ilk 4 bitlik sayınızın 10 luk taban karşılığını giriniz");
                        first4byte = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(first4byte);
                        Console.WriteLine("lütfen ikinci 4 bitlik sayınızın 10 luk taban karşılığını giriniz");
                        second4byte = Convert.ToInt32(Console.ReadLine());
                        if (first4byte <= 15 & second4byte <= 15)
                        {
                            logicanswer = first4byte | second4byte;
                            string logicanswerb = Convert.ToString(logicanswer, 2);
                            logicanswerb = logicanswerb.Replace("0", "a");
                            logicanswerb = logicanswerb.Replace("1", "b");
                            logicanswerb = logicanswerb.Replace("a", "1");
                            logicanswerb = logicanswerb.Replace("b", "0");

                            if (logicanswerb.Length == 3)
                            {
                                Console.WriteLine("0" + logicanswerb);
                            }
                            else if (logicanswerb.Length == 2)
                            {
                                Console.WriteLine("00" + logicanswerb);
                            }
                            else if (logicanswerb.Length == 1)
                            {
                                Console.WriteLine("000" + logicanswerb);
                            }
                            else
                            {
                                Console.WriteLine(logicanswerb);
                            }
                        }
                        else
                        {

                            Console.WriteLine("girdiğiniz metin 0 ve 1 harici değer taşımaktadır");

                        }
                    }
                    else if (logicselection == "xor")
                    {

                        Console.WriteLine("lütfen ilk 4 bitlik sayınızın 10 luk taban karşılığını giriniz");
                        first4byte = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(first4byte);
                        Console.WriteLine("lütfen ikinci 4 bitlik sayınızın 10 luk taban karşılığını giriniz");
                        second4byte = Convert.ToInt32(Console.ReadLine());
                        if (first4byte <= 15 & second4byte <= 15)
                        {
                            logicanswer = first4byte ^ second4byte;
                            string logicanswerb = Convert.ToString(logicanswer, 2);
                            logicanswerb = logicanswerb.Replace("0", "a");
                            logicanswerb = logicanswerb.Replace("1", "b");
                            logicanswerb = logicanswerb.Replace("a", "1");
                            logicanswerb = logicanswerb.Replace("b", "0");

                            if (logicanswerb.Length == 3)
                            {
                                Console.WriteLine("0" + logicanswerb);
                            }
                            else if (logicanswerb.Length == 2)
                            {
                                Console.WriteLine("00" + logicanswerb);
                            }
                            else if (logicanswerb.Length == 1)
                            {
                                Console.WriteLine("000" + logicanswerb);
                            }
                            else
                            {
                                Console.WriteLine(logicanswerb);
                            }
                        }
                        else
                        {

                            Console.WriteLine("girdiğiniz metin 0 ve 1 harici değer taşımaktadır");

                        }
                    }
                    else if (logicselection == "xnor")
                    {

                        Console.WriteLine("lütfen ilk 4 bitlik sayınızın 10 luk taban karşılığını giriniz");
                        first4byte = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(first4byte);
                        Console.WriteLine("lütfen ikinci 4 bitlik sayınızın 10 luk taban karşılığını giriniz");
                        second4byte = Convert.ToInt32(Console.ReadLine());
                        if (first4byte <= 15 & second4byte <= 15)
                        {
                            logicanswer = first4byte ^ second4byte;
                            string logicanswerb = Convert.ToString(logicanswer, 2);
                            if (logicanswerb.Length == 3)
                            {

                                Console.WriteLine("0" + logicanswerb);
                            }
                            else if (logicanswerb.Length == 2)
                            {


                                Console.WriteLine("00" + logicanswerb);
                            }
                            else if (logicanswerb.Length == 1)
                            {

                                Console.WriteLine("000" + logicanswerb);
                            }
                            else
                            {

                                Console.WriteLine(logicanswerb);
                            }
                        }
                        else
                        {

                            Console.WriteLine("girdiğiniz metin 0 ve 1 harici değer taşımaktadır");

                        }
                    }

                }
            
            }
        }

    }
}
