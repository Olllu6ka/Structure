using System;

namespace _2
{
    class Program
    {
        //Используя Visual Studio, создайте проект по шаблону Console Application.
        //Создайте программу, в которой создайте структуру именем Train(Поезд) ), структура должна
        //содержать следующие поля: название пункта назначения, номер поезда, время отправления.
        //В программе необходимо реализовать следующую логику: Пользователь должен с клавиатуры
        //вводить данные с клавиатуры в массив, который содержит упорядоченные номера поездов,
        //количество поездов сделать равным 5 шт.После чего пользователь должен иметь возможность
        //вывести информацию о поезде по номеру поезда.
        static void Main(string[] args)
        {
            Console.Write("Введите номер какого поезда вас интересует: ");
            int Number = int.Parse(Console.ReadLine());
            Train train = new Train();
            train.TrainNumber(Number);
            train.DepartureTime(Number);
            train.Destination(Number);
            
        }
    }
    struct Train{
        public void TrainNumber(int NumberP){
            int[] TrainN = new int[5] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Номер - "+TrainN[NumberP - 1]);
        }
        public void DepartureTime(int NumberP)
        {
            string [] DepartureT = new string[5] {"18:00", "14:00", "20:00", "16:30", "10:00" };
            Console.WriteLine("Время поезда - " + DepartureT[NumberP - 1]);
        }
        public void Destination(int NumberP)
        {
            string[] Destination = new string[5] { "Львов", "Киев", "Харьков", "Чернигов","Боярка" };
            Console.WriteLine("Куда отправляется - " + Destination[NumberP - 1]);
        }
    }
}
