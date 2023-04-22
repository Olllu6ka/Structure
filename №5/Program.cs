using System;

namespace _5
{
    class Program
    {
        //Используя Visual Studio, создайте проект по шаблону Console Application.
        //Создайте перечисление, в котором будут содержаться должности сотрудников как имена
        //констант.Присвойте каждой константе значение, задающее количество часов, которые должен
        //отработать сотрудник за месяц. Создайте класс Accauntant с методом bool AskForBonus(Post
        //worker, int hours), отражающее давать или нет сотруднику премию. Если сотрудник отработал
        //больше положеных часов в месяц, то ему положена премия.
        static void Main(string[] args)
        {
            People people = new People();
            Accauntant accauntant = new Accauntant();
            for (int i = 0; i < 5; i++)
            {
                string Name = people.NameWorker[i];
                Console.Write($"Введите пост {Name} сотрудника: ");
                string PostWorkerM = Console.ReadLine();
                Console.Write("Введите время сколько ваш сотрдник отработал в часах в день: ");
                int HoursM = int.Parse(Console.ReadLine());
                accauntant.AskForBonus(PostWorkerM, HoursM,i);
            }
            
        }
    }
    class Accauntant:People{
        People people = new People();
        public bool AskForBonus(string Postworker, int hours,int g){
            bool YesOrNot = false;
            for (int i = 0; i < 1; i++)
            {
                people.PostWorkerName[g] = Postworker;
                int result = WorkingtimeInHours[i]; 
                if ( result < hours )
                {
                    YesOrNot = true;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{people.NameWorker[i]} "+" - "+$" {people.PostWorkerName[i]} " + "    " + YesOrNot +   " = Заслужил премию" );
                    Console.ResetColor();
                }
                else if (result > hours)
                {
                    YesOrNot = false;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{people.NameWorker[i]} " + " - " + $" {people.PostWorkerName[i]} " + "    " + YesOrNot + " = Заслужил премию");
                    Console.ResetColor();
                }
            }
            return YesOrNot;
            
        }
    }
    public class People
    {
        public string[] NameWorker = new string[5] { "Vova", "Vlad", "Artem", "Pety", "Oleg" };
        public int[] WorkingtimeInHours = new int[5] { 6, 2, 7, 10, 11 };
        public string[] PostWorkerName = new string[5];
    }
}
