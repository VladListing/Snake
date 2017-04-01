using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Foodcreator  //класс  FoodCreator
    {
        //----------------------------------поля класса------------------------
        int mapWidht;
        int mapHeight;
        char sym;

        Random random = new Random();
        //--------------------------------------------------------------------

        //--------------------------------конструктор-----(метод в котором присваиваем значения полям класса)-------------------------
        public  Foodcreator(int mapWidht, int mapHeight, char sym) //поля конструктора

        {
            this.mapWidht = mapWidht;     //присвоение полям класса  значений полей конструктора
            this.mapHeight = mapHeight;  //там где приставка "this" это поля класса
            this.sym = sym;             //
        }
        //----------------------------------------------------------------------------------------------------------------------------

        //--------------------------------метод------------------------------------
        public Point CreateFood() //метод который по итогам работы возвращает тип Point
        {
            int x = random.Next(2, mapWidht-2);
            int y = random.Next(2, mapHeight - 2);

            return new Point(x, y, sym);
        }
        //--------------------------------------------------------------------------









    }
}
