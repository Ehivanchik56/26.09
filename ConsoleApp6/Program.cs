using System;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // //f11 - поэтапно (можно смотреть что храанится) 

            // //Console.WriteLine(array[2] + array [0]);  
            // int[] array = new int[5];

            // Random rnd = new Random();                    /*Обьявление рандома */


            // for (int i = 0; i < array.Length; i++)    /*Пока i < Меньше Длины массива  (Length) - Работает */
            // {
            //    array[i] = rnd.Next(556,1876);              /*Заносит в массив ранд.числа*/

            //    Console.WriteLine(array[i]);            /*Выводит на экран все индексы массива */

            // }
            // //foreach (var item in array)
            // //{
            // //    Console.Write($"{item},");           Второй способ :)
            // //}
            ////Console.WriteLine(array[1]);


            // Console.ReadLine();



            //string[] cities =
            //{
            //    "Самара" , "Москва", "Санкт-Петербург", "Донбасс", "Ульяновск", "Алтай"    /*Массив из городов (строки)*/

            //};

            //Random rnd = new Random();

            //int index = rnd.Next(0,cities.Length);      /*Рандомно вытаскивает*/

            //Console.WriteLine(cities[index]);       /*Выводит на экран индекс*/

            ////Console.WriteLine(cities[rnd.Next(0, cities.Length)]);  43 и 45 строчка в одной

            ////Console.WriteLine(cities[3]);  /*Вывод 3ей ячейки массива */

            ////cities[3] = "бузулук"; 

            ////Console.WriteLine(cities [3]);       

            

            Console.WriteLine("Введите 1е и 2е число");


           int a = Convert.ToInt32(Console.ReadLine());
           int b = Convert.ToInt32(Console.ReadLine());

            int result = Summ(a,b);

            Console.WriteLine(result);




        }

        static public int Summ(int a, int b)
        {
              
            return a + b;
        }

        static public string Hello(string lang)
        {
          
            switch (lang)
            {
                case "ru":
                    return "Привет мир!";
                case "en":
                    return "Hello world!";
                    
            }
            return "Ошибка";
        }


    }
}
