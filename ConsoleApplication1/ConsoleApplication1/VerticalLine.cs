using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class VerticalLine:Figure //указывает на то что класс"VerticalLine" является наследником (производной )(диреванивом) класса "Figure"
    {                        //на этом основании класс "VerticalLine" имеет доступ к переменным (полям) и методам класса "Figure"

        //===========(с возможн.задания произвольных параметров)===== конструктор (метод вызываемый при создании обьекта  класса "HorizontalLine", определяет состояние обьекта тоесть значения переменных )=================
        public VerticalLine(int nachalo_po_x, int konec_po_y, int nachalo_po_y, char sym)
        {
            pList = new List<Point>();//создаем пустой список"pList"

            int dlinna = konec_po_y - nachalo_po_y;//высчитываем количество элементов в линии

            for (int i = 0; i < dlinna; i++)
            {
                Point P = new Point(nachalo_po_x , nachalo_po_y+i, sym);//создаем обект класса "Point", в свою очередь при создании обьектов пользуемся (инкапсулированным)  
                                                                        //конструктором содержащимся в нутри класса "Point"
                pList.Add(P);//добавляем созданную точку в список
            }
        }
        //======================================================================= конец конструктора ======================================================================================================

    }
}
