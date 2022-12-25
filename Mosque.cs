using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursachNa3
{
    [Serializable]
    internal class Mosque : ReligiousBuilding
{
        public Mosque(int date, double footprint, int placesCount, double servicePrice) : base(date, footprint, placesCount, servicePrice) { }

        public Mosque(int date, double footprint, int placesCount, double servicePrice, int monksNumber) : base(date, footprint, placesCount, servicePrice) => MonksNumber = monksNumber;

        public int MonksNumber { get; private set; }

        public override string aeaeaeaSinging()
        {
            MonksNumber*=2;
            return "В мечети прошли лютые песнопения, количество служителей увеличилось в 2 раза";
        }

        public override string SellStuff()
        {
            return "В мечети ничего не продают.";
        }
        public override string DogmaAnnouncement()
        {
            return "Мы любим петь";
        }
        public override string ToString()
        {
            return base.ToString() + $"Количество служителей: {MonksNumber}";
        }
    }
}
