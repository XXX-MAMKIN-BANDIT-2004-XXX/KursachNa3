using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursachNa3
{
    [Serializable]
    internal abstract class ReligiousBuilding : IBuilding
    {
        protected readonly int date;
        public int Date => date;

        public double Footprint { get; set; }

        public int PlacesCount { get; set; }

        public double ServicePrice { get; set; }

        public ReligiousBuilding(int date, double footprint, int placesCount, double servicePrice)
        {
            this.date = date;
            Footprint = footprint;
            PlacesCount = placesCount;
            ServicePrice = servicePrice;
        }

        public string ResizePlace()
        {
            return "Вы подали заявку на увеличение площади строения в прокуратуру, но вам так и не ответили";
        }

        public virtual string SellStuff() { return ""; }

        public virtual string DogmaAnnouncement() { return""; }

        public override string ToString()
        {
            return string.Format($"Тип: {GetType().Name}\nДата постройки: {date}\nПлощадь: {Footprint}\nКоличество мест: {PlacesCount}\nЦена сервиса: {ServicePrice}\n");
        }


        public virtual string Ceremony() { return"Здесь не проводятся церемонии"; }
        public virtual string Ministry() { return"Здесь не проводятся служения"; }
        public virtual string aeaeaeaSinging() { return"Здесь не поют"; }
    }
}
