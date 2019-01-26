using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstraPlat
{
    class TransportCard
    {
        public TransportCard(double transportWallet)
        {
            TransportWallet = transportWallet;
        }
        public double TransportWallet { get; set; }

        public static TransportCard operator+(TransportCard transportCard, double replenishment)
        {
            transportCard.TransportWallet += replenishment;
            return transportCard;
        }

        public static TransportCard operator -(TransportCard transportCard, double fare)
        {
            transportCard.TransportWallet -= fare;
            return transportCard;
        }
    }
}
