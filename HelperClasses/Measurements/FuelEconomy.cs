namespace HelperClasses.Measurements
{
    public class FuelEconomy
    {
        //Base value is 1 mile/gallon

        private const decimal _KILOMETRE_GALLON = 1.609344M;
        private const decimal _MILE_LITRE = 0.2199692M;
        private const decimal _KILOMETRE_LITRE = 0.3540062M;
        private decimal _fuelEconomy;

        public decimal milesPerGallon
        {
            get
            {
                return _fuelEconomy;
            }
            set
            {
                _fuelEconomy = value;
            }
        }

        public decimal kilometresPerGallon
        {
            get
            {
                return (_fuelEconomy * _KILOMETRE_GALLON);
            }
            set
            {
                _fuelEconomy = (value / _KILOMETRE_GALLON);
            }
        }

        public decimal milesPerLitre
        {
            get
            {
                return (_fuelEconomy * _MILE_LITRE);
            }
            set
            {
                _fuelEconomy = (value / _MILE_LITRE);
            }
        }

        public decimal kilometrePerLitre
        {
            get
            {
                return (_fuelEconomy * _KILOMETRE_LITRE);
            }
            set
            {
                _fuelEconomy = (value / _KILOMETRE_LITRE);
            }
        }
    }
}