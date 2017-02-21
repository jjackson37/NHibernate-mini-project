using System;

namespace HelperClasses.Measurements
{
    public class Weight
    {
        //Base value is 1 kilogram

        private const decimal _KILOGRAM = 0.001M;
        private const decimal _METRICTON = 0.000001M;
        private const decimal _MICROGRAM = 1000000;
        private const decimal _MILLIGRAM = 1000;
        private const decimal _OUNCE = 0.03527396M;
        private const decimal _POUND = 0.002204623M;
        private const decimal _STONE = 0.000157473M;
        private decimal _weight;

        public decimal grams
        {
            get
            {
                return _weight;
            }
            set
            {
                _weight = value;
            }
        }

        public decimal kilograms
        {
            get
            {
                return (_weight * _KILOGRAM);
            }
            set
            {
                _weight = (value / _KILOGRAM);
            }
        }

        public decimal metricTons
        {
            get
            {
                return (_weight * _METRICTON);
            }
            set
            {
                _weight = (value / _METRICTON);
            }
        }

        public decimal micrograms
        {
            get
            {
                return (_weight * _MICROGRAM);
            }
            set
            {
                _weight = (value / _MICROGRAM);
            }
        }

        public decimal milligrams
        {
            get
            {
                return (_weight * _MILLIGRAM);
            }
            set
            {
                _weight = (value / _MILLIGRAM);
            }
        }

        public decimal ounces
        {
            get
            {
                return (_weight * _OUNCE);
            }
            set
            {
                _weight = (value / _OUNCE);
            }
        }

        public decimal pounds
        {
            get
            {
                return (_weight * _POUND);
            }
            set
            {
                _weight = (value / _POUND);
            }
        }

        public decimal stones
        {
            get
            {
                return (_weight * _STONE);
            }
            set
            {
                _weight = (value / _STONE);
            }
        }
    }
}