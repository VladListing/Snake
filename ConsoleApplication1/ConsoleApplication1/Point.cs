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

        
        //======================= Полиморфизм ===(перегрузка методов)=== обьявление двух методов с одним именем и разными параметрами ===========================================================   
        //---------------------------- конструктор для класса "Point" --------(с присвоением )-------  (вариант-2) ---------------------------------------
        //принимает в качестве параметров  значения для  координат будующей точки , а также символ который будет выведен в этих координатах 
        public Point(int _X, int _Y, char _sym )
        {
            X = _X;
            Y = _Y;
          sym = _sym;

        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------

        //-------------------------- конструктор для класса "Point" KKKKKKKKK(с присвоением )KKKKKKKKK  (вариант-3   )-------------------------------------
        //принимает в качестве параметра точку далее разбирает ее на координаты 
        public Point(Point p)
        {
            X = p.X;
            Y = p.Y;
            sym = p.sym;

        }
        //---------------------------------------------------------------------------------------------------------------------------------------------------
        //========================================================================================================================================================================================== 


        //MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM МЕТОД  ,процедура вывода заданного символа в заданной координате %%%%%%%%%%(Метод, функция , класса "Point" )MMMMMMMMMMMMMMMMMMMMMMMMMMMMM
        //public void Draww(int X, int Y, char sym)
        public void Draww()
        {

            Console.SetCursorPosition(X, Y);//задаем координаты для последующего вывода символа
            Console.Write(sym); //выводим символ на экран в заданных координатах

        }
        //MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM

        //MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM МЕТОД  ,процедура вывода заданного пробела символа в заданной координате %%%%%%%%%%(Метод, функция , класса "Point" )MMMMMMMMMMMMMMMMMMMMMMMMMMMMM
        
        public void Clear()
        {
            sym = ' '; //символом хвостовой точки станомиться пробел, пусто

            Draww();// выводим пробел на экран
        }
        //MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM


        //MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM МЕТОД , сдвигает точку на заданное колличество позиций по осям координат  ,MMMMMMMMMMMMMMMMMMMMMMMMMMMMM
        //public void Draww(int X, int Y, char sym)
        public void Move(int offset /*растояние сдвига*/, Direction direction /*направление сдвига*/)
        {
            
            if (direction == Direction.RIGHT)
            {
                X = X + offset;
            }

            else if (direction == Direction.LEFT)
            {
                X = X - offset;
            }

            else if (direction == Direction.UP)
            {
                Y = Y - offset;
            }

            else if (direction == Direction.DOWN)
            {
                Y = Y + offset;
            }


        }
        //MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM

        //----------------------------------------------------------------------Метод----(сравниваю совпадают ли координаты точек)-------------------------------------------------
        public bool IsHit(Point p)
        {
            return p.X == this.X && p.Y == this.Y;

        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------




    }
}
