using System;

namespace _4
{
    class Program
    {
        //Используя Visual Studio, создайте проект по шаблону Console Application.
        //Создайте статический класс с методом void Print(string stroka, int color), который выводит на
        //экран строку заданным цветом.Используя перечисление, создайте набор цветов, доступных
        //пользователю.Ввод строки и выбор цвета предоставьте пользователю.
        static void Main(string[] args)
        {
            Console.Write($"\tМеню \nBlue = 1 \tYellow = 2 \nRed = 3 \t Green = 4 \nВведите цифру: ");
            int ColorM = int.Parse(Console.ReadLine());
            Console.Write("Введите свой текст: ");
            string StrokaM = Console.ReadLine();
            PrintColor.Print(StrokaM, ColorM);
        }//Загадка для меня почему Green табуляция не рабоатет ???? Можно овтет :)
    }
    static class PrintColor
    {
        public static void Print(string Stroka,int color)
        {
            if (color == 1){
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(Stroka);
                Console.ResetColor();
            }
            else if (color == 2) {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(Stroka);
                Console.ResetColor();
            }
            else if (color == 3) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(Stroka);
                Console.ResetColor();
            }
            else if (color == 4){
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(Stroka);
                Console.ResetColor();
            }
            
            
        }
    }
}
