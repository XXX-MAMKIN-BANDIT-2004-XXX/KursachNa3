using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursachNa3
{
    [Serializable]
    internal class Sinagoga : ReligiousBuilding
    {
        public Sinagoga(int date, double footprint, int placesCount, double servicePrice) : base(date, footprint, placesCount, servicePrice) { }
        public Sinagoga(int date, double footprint, int placesCount, double servicePrice, int believersNumber) : base(date, footprint, placesCount, servicePrice) => BelieversNumber = believersNumber;
        public int BelieversNumber { get; private set; }
        public override string Ceremony()
        {
            BelieversNumber*=2;
            ServicePrice*=1.1;
            return "Церемония в синагоге прошла успешно, цены на услуги подскочили на 10%, Количество прихожан увеличилось на 100%";
        }
        public override string SellStuff()
        {
            return $"Вы продали много мацы";
        }
        public override string DogmaAnnouncement()
        {
            return "Яву это супер круто!";
        }
        public override string ToString()
        {
            return base.ToString() + $"Количество верующих: {BelieversNumber}";
        }
    }
}
