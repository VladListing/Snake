using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Point   // класс "Point"
    {


        //------------------------поля класса "Point"----------------------------
        public int X;

        public int Y;

        public char sym;
        //-----------------------------------------------------------------------

        //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% процедура вывода заданного символа в заданной координате %%%%%%%%%%(Метод, функция , класса "Point" )%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        //public void Draww(int X, int Y, char sym)
        public void Draww()
        {

            Console.SetCursorPosition(X, Y);//задаем координаты курсора
            Console.Write(sym); //выводим курсор на экран в заданных координатах

        }
        //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

    }
}
