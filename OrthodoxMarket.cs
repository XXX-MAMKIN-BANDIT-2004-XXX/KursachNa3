using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursachNa3
{
    [Serializable]
    internal class OrthodoxMarket:ICandle
    {
        public OrthodoxMarket(int placesCount)
        {
            PlacesCount=placesCount;
        }

        public int PlacesCount { get; set; }
        public string BuyCandles()
        {
            return "Свечи были успешно закуплены";
        }

        public string MakeAds()
        {
            return "Мы прорекламировали наш прекрасный рынок на местном тв! Но никто этого не увидел...";
        }

        public override string ToString()
        {
            return $"Класс: {GetType().Name}\nКоличество мест: {PlacesCount}";
        }
    }
}
