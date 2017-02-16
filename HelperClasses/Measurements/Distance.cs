namespace HelperClasses.Measurements
{
    public class Distance
    {
        //Base value is 1 metre

        private const decimal _CENTIMETRE = 100;
        private const decimal _DECIMETRE = 10;
        private const decimal _FOOT = 3.28084M;
        private const decimal _INCH = 39.3701M;
        private const decimal _KILOMETRE = 0.001M;
        private const decimal _MILE = 0.000621371M;
        private const decimal _MILLIMETRE = 1000;
        private const decimal _NAUTICALMILE = 0.0005399568M;
        private const decimal _YARD = 1.09361M;
        private decimal _distance;

        public decimal centimetres
        {
            get
            {
                return (_distance * _CENTIMETRE);
            }
            set
            {
                _distance = (value / _CENTIMETRE);
            }
        }

        public decimal decimetre
        {
            get
            {
                return (_distance * _DECIMETRE);
            }
            set
            {
                _distance = (value / _DECIMETRE);
            }
        }

        public decimal feet
        {
            get
            {
                return (_distance * _FOOT);
            }
            set
            {
                _distance = (value / _FOOT);
            }
        }

        public decimal inches
        {
            get
            {
                return (_distance * _INCH);
            }
            set
            {
                _distance = (value / _INCH);
            }
        }

        public decimal kilometres
        {
            get
            {
                return (_distance * _KILOMETRE);
            }
            set
            {
                _distance = (value / _KILOMETRE);
            }
        }

        public decimal metres
        {
            get
            {
                return _distance;
            }
            set
            {
                _distance = value;
            }
        }

        public decimal miles
        {
            get
            {
                return (_distance * _MILE);
            }
            set
            {
                _distance = (value / _MILE);
            }
        }

        public decimal millimetres
        {
            get
            {
                return (_distance * _MILLIMETRE);
            }
            set
            {
                _distance = (value / _MILLIMETRE);
            }
        }

        public decimal nauticalMiles
        {
            get
            {
                return (_distance * _NAUTICALMILE);
            }
            set
            {
                _distance = (value / _NAUTICALMILE);
            }
        }

        public decimal yards
        {
            get
            {
                return (_distance * _YARD);
            }
            set
            {
                _distance = (value / _YARD);
            }
        }
    }
}