using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursachNa3
{
    [Serializable]
    internal sealed class Church:ReligiousBuilding, ICandle
    {
        public Church(int date, double footprint, int placesCount, double servicePrice) : base(date, footprint, placesCount, servicePrice) { }
        public Church(int date, double footprint, int placesCount, double servicePrice, int believersNumber) : base(date, footprint, placesCount, servicePrice) => BelieversNumber = believersNumber;
        public int BelieversNumber { get; private set; }

        public string BuyCandles()
        {
            return "Свечи были закуплены";
        }

        public override string Ceremony()
        {
            BelieversNumber*=2;
            ServicePrice*=1.1;
            return "Церемония в церкви прошла успешно, цены на услуги подскочили на 10%, Количество прихожан увеличилось на 100%";
        }
        public override string SellStuff()
        {
            return $"Вы продали много крестов и свечек";
        }
        public override string DogmaAnnouncement()
        {
            return $"Нас уже {BelieversNumber} верующих в Христианство, мы захватим этот мир!";
        }
        public override string ToString()
        {
            return base.ToString() + $"Количество верующих: {BelieversNumber}";
        }
    }
}
