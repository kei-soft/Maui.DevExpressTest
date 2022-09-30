namespace Maui.DevExpressTest.Models
{
    public class PopulationModel
    {
        public DateTime Year { get; }
        public double Population { get; }

        public PopulationModel(DateTime year, double population)
        {
            this.Year = year;
            this.Population = population;
        }
    }
}
