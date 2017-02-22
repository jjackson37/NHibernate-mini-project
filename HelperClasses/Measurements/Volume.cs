namespace HelperClasses.Measurements
{
    public class Volume
    {
        //Base value is 1 cubic metre

        private const decimal _CUBIC_CENTIMETRE = 1000;
        private const decimal _CUBIC_FOOT = 35.314666721M;
        private const decimal _CUBIC_INCH = 61023.744095M;
        private const decimal _CUBIC_KILOMETRE = 0.000000001M;
        private const decimal _CUBIC_MILLIMETRE = 1000000000;
        private const decimal _CUBIC_YARD = 1.3079506193M;
        private const decimal _GALLON = 219.9692483M;
        private const decimal _KILOLITRE = 1;
        private const decimal _LITRE = 1000;
        private const decimal _MEGALITRE = 0.001M;
        private const decimal _MICROLITRE = 1000000000;
        private const decimal _MILLILITRE = 1000000;
        private decimal _volume;

        public decimal cubicCentimetres
        {
            get
            {
                return (_volume * _CUBIC_CENTIMETRE);
            }
            set
            {
                _volume = (value / _CUBIC_CENTIMETRE);
            }
        }

        public decimal cubicFeet
        {
            get
            {
                return (_volume * _CUBIC_MILLIMETRE);
            }
            set
            {
                _volume = (value / _CUBIC_MILLIMETRE);
            }
        }

        public decimal cubicInches
        {
            get
            {
                return (_volume * _CUBIC_INCH);
            }
            set
            {
                _volume = (value / _CUBIC_INCH);
            }
        }

        public decimal cubicKilometres
        {
            get
            {
                return (_volume * _CUBIC_KILOMETRE);
            }
            set
            {
                _volume = (value / _CUBIC_KILOMETRE);
            }
        }

        public decimal cubicMetres
        {
            get
            {
                return _volume;
            }
            set
            {
                _volume = value;
            }
        }

        public decimal cubicMillimetres
        {
            get
            {
                return (_volume * _CUBIC_MILLIMETRE);
            }
            set
            {
                _volume = (value / _CUBIC_MILLIMETRE);
            }
        }

        public decimal cubicYards
        {
            get
            {
                return (_volume * _CUBIC_YARD);
            }
            set
            {
                _volume = (value / _CUBIC_YARD);
            }
        }

        public decimal gallons
        {
            get
            {
                return (_volume * _GALLON);
            }
            set
            {
                _volume = (value / _GALLON);
            }
        }

        public decimal kilolitres
        {
            get
            {
                return (_volume * _KILOLITRE);
            }
            set
            {
                _volume = (value / _KILOLITRE);
            }
        }

        public decimal litres
        {
            get
            {
                return (_volume * _LITRE);
            }
            set
            {
                _volume = (value / _LITRE);
            }
        }

        public decimal megalitres
        {
            get
            {
                return (_volume * _MEGALITRE);
            }
            set
            {
                _volume = (value / _MEGALITRE);
            }
        }

        public decimal microlitre
        {
            get
            {
                return (_volume * _MICROLITRE);
            }
            set
            {
                _volume = (value / _MICROLITRE);
            }
        }

        public decimal millilitres
        {
            get
            {
                return (_volume * _MILLILITRE);
            }
            set
            {
                _volume = (value / _MILLILITRE);
            }
        }
    }
}