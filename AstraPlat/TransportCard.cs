using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstraPlat
{
    class TransportCard
    {
        private double bonus;
        private int freeRide;
        public TransportCard(double transportWallet)
        {
            bonus = 0;
            freeRide = 0;
            TransportWallet = transportWallet;
        }
        public double TransportWallet { get; set; }

        
        public double GetBonus()
        {
            return bonus;
        }
        public int GetFreeRide()
        {
            return freeRide;
        }
        public static TransportCard operator+(TransportCard transportCard, double replenishment)
        {
            transportCard.bonus += 3.5;
            transportCard.TransportWallet += (replenishment);
            return transportCard;
        }

        public static TransportCard operator -(TransportCard transportCard, double fare)
        {
            transportCard.bonus += 3.5;
            ++transportCard.freeRide;
            if (transportCard.bonus >= 140 || transportCard.freeRide == 10)
            {
                return transportCard;
            }
            else
            {
                transportCard.TransportWallet -= fare;
                return transportCard;
            }
           
        }
    }
}
