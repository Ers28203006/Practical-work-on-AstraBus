using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstraPlat
{
    class Program
    {
        static void Main(string[] args)
        {
            bool enterSelection = true;
            double transportWallet = 0;

            while (enterSelection == true)
            {
                Console.WriteLine("         Стоимость тарифов составляет: \n\n\n" +
                    "   1. Городской месячный проездной                7 500 тенге \n\n" +
                    "   2. Городской месячный проездной (детский)      1 500 тенге \n\n" +
                    "   3. Пригородный месячный проезной               9 500 тенге \n\n" +
                    "   4. Пригородный месячный проезной (детский)     2 000 тенге \n\n" +
                    "   5. Городской трехмесячный проезной             20 000 тенге \n\n" +
                    "   6. Городской трехмесячный проезной (детский)   4 000 тенге \n\n\n" +
                    "Выберите тариф и пополните Транспортный кошелек (от 1 до 6)");

                int choiceOfTariff = int.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (choiceOfTariff)
                {
                    case 1:
                        transportWallet = 7500;
                        Console.WriteLine("Вы преобрели городской месячный проездной");
                        enterSelection = false;
                        break;
                    case 2:
                        transportWallet = 1500;
                        Console.WriteLine("Вы преобрели городской месячный проездной (детский)");
                        enterSelection = false;
                        break;
                    case 3:
                        transportWallet = 9500;
                        Console.WriteLine("Вы преобрели пригородный месячный проезной");
                        enterSelection = false;
                        break;
                    case 4:
                        transportWallet = 2000;
                        Console.WriteLine("Вы преобрели пригородный месячный проезной (детский)");
                        enterSelection = false;
                        break;
                    case 5:
                        transportWallet = 20000;
                        Console.WriteLine("Вы преобрели городской трехмесячный проезной");
                        enterSelection = false;
                        break;
                    case 6:
                        transportWallet = 4000;
                        Console.WriteLine("Вы преобрели городской трехмесячный проезной (детский)");
                        enterSelection = false;
                        break;
                    default:
                        System.Console.Clear();
                        Console.WriteLine("Введено не верное значение, ввeдите от 1 до 6");
                        Console.ReadLine();
                        System.Console.Clear();
                        break;
                }
            }

            Console.WriteLine();
            TransportCard transportCard = new TransportCard(transportWallet);
            Console.WriteLine("Остаток на счете: "+ transportCard.TransportWallet);

            double adultRouteFee = 90;
            double routeFeeForChildren = 40;
            double experssAdultRouteFee = 180;
            double experssRouteFeeForChildren=90;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("На каком автобусе осуществляете оплату через валидатор? \n" +
                "0. Обычный гороской маршрут \n" +
                "1. Экспресс маршрут");
            int routeType = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine();

            if ((transportWallet==7500 || transportWallet == 1500 ||
                transportWallet == 20000) && routeType==0)
            {
                Console.WriteLine("Проезд на автобесе стоит - "+ adultRouteFee+" тенге");
                transportCard = transportCard - adultRouteFee;
            }

            if ((transportWallet == 7500 || transportWallet == 9500 ||
               transportWallet == 20000) && routeType>0)
            {
                Console.WriteLine("Проезд на автобесе стоит - " + experssAdultRouteFee+" тенге");
                transportCard = transportCard - experssAdultRouteFee;
            }

            if ((transportWallet == 1500 || transportWallet == 2000 ||
               transportWallet == 4000) && routeType==0)
            {
                Console.WriteLine("Проезд на автобесе стоит - " + routeFeeForChildren + " тенге");
                transportCard = transportCard - routeFeeForChildren;
            }

            if ((transportWallet == 1500 || transportWallet == 2000 ||
               transportWallet == 4000) && routeType>0)
            {
                Console.WriteLine("Проезд на автобесе стоит - " + experssRouteFeeForChildren + " тенге");
                transportCard = transportCard - experssRouteFeeForChildren;
            }
            Console.Write("Остаток на счете: " + transportCard.TransportWallet);

            Console.ReadLine();
        }
    }
}
