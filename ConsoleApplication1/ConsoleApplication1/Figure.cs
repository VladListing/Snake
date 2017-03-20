using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Figure
    {

         protected List<Point> pList; //обьявляем список "pList" состоящий из обьектов класса "Point"

        //.........................................................Создаем метод Выводящий содержимое списка "pList" на экран консоли.........................................

        public void Drow()//создаем метод "Drow" который выводит содержимое списка "pList" на экран
        {

            foreach (Point element_spiska in pList)
            {
                element_spiska.Draww();
            }
        }
        //.....................................................................................................................................................................


    }
}
