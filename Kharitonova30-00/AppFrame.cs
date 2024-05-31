using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Kharitonova30_00
{
    class AppFrame
    {
        public static Frame frameMain;
        static Cars car1 = new Cars()
        {
            id = 1,
            carNumber = "А123НР47",
            carStatus = "Оплачен",
            carType = "Превышение скорости",
            carCost = 250
        };
        static Cars car2 = new Cars()
        {
            id = 1,
            carNumber = "П277ЛВ47",
            carStatus = "Оплачен",
            carType = "Проезд под знак Разворот запрещен",
            carCost = 1000
        };
        static Cars car3 = new Cars()
        {
            id = 1,
            carNumber = "Н184ГР48",
            carStatus = "Не оплачен",
            carType = "Вождение без страховки",
            carCost = 2000
        };
        static Cars car4 = new Cars()
        {
            id = 1,
            carNumber = "Г222ВО90",
            carStatus = "Оплачен",
            carType = "Вождение в нетрезвом виде",
            carCost = 10000
        };
        static Cars car5 = new Cars()
        {
            id = 1,
            carNumber = "Н404ЕО47",
            carStatus = "Не оплачен",
            carType = "Помогите, я застрял в матрице",
            carCost = 404
        };

        public static List<Cars> carList = new List<Cars>() { car1, car2, car3, car4, car5 };
    }
}
