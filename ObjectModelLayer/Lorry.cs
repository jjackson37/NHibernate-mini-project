using HelperClasses.Measurements;

namespace ObjectModelLayer
{
    public class Lorry : Automobile
    {
        public virtual bool hasLoad { get; set; }
        public virtual Weight loadWeight { get; set; }
    }
}