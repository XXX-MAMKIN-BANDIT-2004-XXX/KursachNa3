using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursachNa3
{
    [Serializable]
    internal class Pool : IBuilding
    {

        protected readonly int date;
        public int Date => date;
        public double Footprint { get; set; }
        public Pool(int date, double footprint)
        {
            this.date = date;
            Footprint = footprint;
        }
        public string ResizePlace()
        {
            return $"Вы попытались изменить площадь бассеина, но вам не хватило финансов";
        }

        public override string ToString()
        {
            return $"Тип: {GetType().Name}\nДата постройки:{date}\nПлощадь:{Footprint}";
        }
    }
}
