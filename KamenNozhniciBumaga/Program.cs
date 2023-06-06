using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace KamenNozhniciBumaga
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            // Span<byte> bytes = new Span<byte>(bytes1);
            // RandomNumberGenerator.Fill(bytes);
            bytes2 = RandomNumberGenerator.GetBytes(bytes2.Length);
            */

            string play = "пенис";
            int ScorePlay = 0;
            int ScorePc = 0;
            int i;
            Random rnd = new Random();

            for (i = 1;
            play != "нет" && play != "Нет";
            i = 1
            )

            {

                int a = rnd.Next(69000, 276000);
                int b = rnd.Next(69000, 276000);
                int c = rnd.Next(69000, 276000);
                int d = (a + b + c) / 3;

                int pc = d / 69000;
                //Console.WriteLine(pc);
                //Console.WriteLine(pc);
                Console.WriteLine("Введи свой выбор");
                play = Console.ReadLine();
                //int pc = RandomNumberGenerator.GetInt32(1,3);
                /*
                1 - камень,
                2-ножницы,
                3 - бумага
                */

                if ((play == "камень" || play == "Камень") && pc == 1)
                    Console.WriteLine("Тоже камень. Ничья");
                else if ((play == "камень" || play == "Камень") && pc == 2)
                {
                    Console.WriteLine("Ножницы, я проиграл");
                    ScorePlay = ScorePlay + 1;
                }
                else if ((play == "камень" || play == "Камень") && pc == 3)
                {
                    Console.WriteLine("У меня бумага, я выиграл");
                    ScorePc = ScorePc + 1;
                }
                else if ((play == "ножницы" || play == "Ножницы") && pc == 1)
                {
                    Console.WriteLine("Камень, я выиграь");
                    ScorePc = ScorePc + 1;
                }
                else if ((play == "ножницы" || play == "Ножницы") && pc == 2)
                    Console.WriteLine("Тоже ножницы, ничья");
                else if ((play == "ножницы" || play == "Ножницы") && pc == 3)
                {
                    Console.WriteLine("Бумага, я проиграл");
                    ScorePlay = ScorePlay + 1;
                }
                else if ((play == "Бумага" || play == "бумага") && pc == 1)
                {
                    Console.WriteLine("Камень, я проиграл");
                    ScorePlay = ScorePlay + 1;
                }
                else if ((play == "Бумага" || play == "бумага") && pc == 2)
                {
                    Console.WriteLine("У меня ножнтцы, я выиграь");
                    ScorePc = ScorePc + 1;
                }
                else if ((play == "Бумага" || play == "бумага") && pc == 3)
                    Console.WriteLine("Тоже бумага, ничья");
                else
                    Console.WriteLine("нихуя не понял,но очень интересно");
                Console.Write("Теперь счет ");
                Console.Write(ScorePlay);
                Console.Write("-");
                Console.WriteLine(ScorePc);
                if (ScorePlay > ScorePc)
                    Console.WriteLine("В твою пользу");
                else if (ScorePlay < ScorePc)
                    Console.WriteLine("В мою пользу");
                else
                    Console.WriteLine("Ноздря в ноздрю");
                Console.WriteLine(" ");

            }

            if (
            play == "нет" || play == "Нет"
            )
            {
                Console.Clear();
                Console.WriteLine("ну и пошел нахцй");



            }
        }
}
}

