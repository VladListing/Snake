using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Point   // класс "Point"
    {


        //пппппппппппппппппппппппппппппппп поля класса "Point" пппппппппппппппппппппппппп
        public int X;

        public int Y;

        public char sym;
        //пппппппппппппппппппппппппппппппппппппппппппппппппппппппппппппппппппппппппппп

        //KKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKK конструктор для класса "Point" KKKKKKKKK(пустой - по умолчанию )KKKKKKK(вариант-1)KKKKKKKKKKKKKKKKKKKK
        //public Point()
        //{

        //}
        //KKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKK

        //KKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKK конструктор для класса "Point" KKKKKKKKK(с присвоением )KKKKKKKKK(вариант-2)KKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKK
        public Point(int _X, int _Y, char _sym )
        {
            X = _X;
            Y = _Y;
          sym = _sym;

        }
        //KKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKK



        //MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM процедура вывода заданного символа в заданной координате %%%%%%%%%%(Метод, функция , класса "Point" )MMMMMMMMMMMMMMMMMMMMMMMMMMMMM
        //public void Draww(int X, int Y, char sym)
        public void Draww()
        {

            Console.SetCursorPosition(X, Y);//задаем координаты курсора
            Console.Write(sym); //выводим курсор на экран в заданных координатах

        }
        //MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM

    }
}
