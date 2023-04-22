using System;

namespace _3
{
    class Program
    {
        //Используя Visual Studio, создайте проект по шаблону Console Application.
        //Создайте класс MyClass и структуру MyStruct, которые содержат в себе поля public string change.
        //В классе Program создайте два метода:
        //- static void ClassTaker(MyClass myClass), который присваивает полю change экземпляра myClass
        //значение «изменено».
        //- static void StruktTaker(MyStruct myStruct), который присваивает полю change экземпляра
        //myStruct значение «изменено».
        //Продемонстрируйте разницу в использовании классов и структур, создав в методе Main()
        //экземпляры структуры и класса.Измените, значения полей экземпляров на «не изменено», а
        //затем вызовите методы ClassTaker и StruktTaker.Выведите на экран значения полей экземпляров.
        //Проанализируйте полученные результаты.
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            myClass.change = "Не изменено";
            MyStruct myStruct = new MyStruct();
            myStruct.change = "Не изменено";
            ClassTaker(myClass);
            StruktTaker(myStruct);
            Console.WriteLine(myClass.change);
            Console.WriteLine(myStruct.change);
            //Разница в том что структуре изменнено а в классе нет
        }
        static void StruktTaker(MyStruct myStruct)
        {
            myStruct.change = "изменено";
        }
        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "изменено";
        }
    }
    class MyClass
    {
        public string change;
    }
    struct MyStruct
    {
        public string change;
    }
}
