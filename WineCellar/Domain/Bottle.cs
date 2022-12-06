using WineCellar.Domain.Enums;

namespace WineCellar.Domain
{
    public class Bottle
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public int Year { get; set; }

        public Grape Grape { get; set; }

        public Bottle(string name, int year, Grape grape)
        {
            Name = name;
            Year = year;
            Grape = grape;
        }

        public override string ToString()
        {
            return $"Bottle of Wine -> Name: {Name} - Year:{Year} - Grape:{Grape}";
        }
    }
}
