namespace HelperClasses.Measurements
{
    public class Speed
    {
        //Base value is 1 mile per hour

        private const decimal _CENTIMETRE_SECOND = 44.704M;
        private const decimal _FOOT_SECOND = 1.4666666667M;
        private const decimal _INCH_SECOND = 17.6M;
        private const decimal _KILOMETRE_HOUR = 1.609344M;
        private const decimal _KILOMETRE_SECOND = 0.00044704M;
        private const decimal _METRE_SECOND = 0.44704M;
        private const decimal _MILE_SECOND = 0.0002777777778M;
        private decimal _speed;

        public decimal centimetresPerSecond
        {
            get
            {
                return (_speed * _CENTIMETRE_SECOND);
            }
            set
            {
                _speed = (value / _CENTIMETRE_SECOND);
            }
        }

        public decimal feetPerSecond
        {
            get
            {
                return (_speed * _FOOT_SECOND);
            }
            set
            {
                _speed = (value / _FOOT_SECOND);
            }
        }

        public decimal inchsPerSecond
        {
            get
            {
                return (_speed * _INCH_SECOND);
            }
            set
            {
                _speed = (value / _INCH_SECOND);
            }
        }

        public decimal kilometresPerHour
        {
            get
            {
                return (_speed * _KILOMETRE_HOUR);
            }
            set
            {
                _speed = (value / _KILOMETRE_HOUR);
            }
        }

        public decimal kilometresPerSecond
        {
            get
            {
                return (_speed * _KILOMETRE_SECOND);
            }
            set
            {
                _speed = (value / _KILOMETRE_SECOND);
            }
        }

        public decimal metresPerSecond
        {
            get
            {
                return (_speed * _METRE_SECOND);
            }
            set
            {
                _speed = (value / _METRE_SECOND);
            }
        }

        public decimal milesPerHour
        {
            get
            {
                return _speed;
            }
            set
            {
                _speed = value;
            }
        }

        public decimal milesPerSecond
        {
            get
            {
                return (_speed * _MILE_SECOND);
            }
            set
            {
                _speed = (value / _MILE_SECOND);
            }
        }
    }
}