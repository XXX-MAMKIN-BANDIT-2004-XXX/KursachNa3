using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursachNa3
{
    [Serializable]
    internal class Cathedral : ReligiousBuilding
    {
        public Cathedral(int date, double footprint, int placesCount, double servicePrice) : base(date, footprint, placesCount, servicePrice) { }

        public Cathedral(int date, double footprint, int placesCount, double servicePrice, int monksNumber) : base(date, footprint, placesCount, servicePrice) => MonksNumber = monksNumber;

        public int MonksNumber { get; private set; }

        public override string Ministry()
        {
            MonksNumber+=2;
            ServicePrice*=1.3;
            return "Служение в соборе прошло на ура, цены на услуги подскочили на 30%, Количество монахов увеличилось на 2";
        }
        public override string SellStuff()
        {
            return $"Вы продали много крестов и свечек";
 
        }
        public override string DogmaAnnouncement()
        {
            return $"С нами {MonksNumber} монахов, мы захватим этот мир!";
        }
        public override string ToString()
        {
            return base.ToString() + $"Количество монахов: {MonksNumber}";
        }
    }
}
