using System;

namespace Prototype
{
    /// <summary>
    /// Prototype concrete class
    /// </summary>
    public class Android : AndroidPrototype
    {
        private int _iq;
        private int _areaOfOperation;
        private int _increaseIQOverTime;

        public Android(int iq, int areaOfOperation, int increaseIQOverTime)
        {
            _iq = iq;
            _areaOfOperation = areaOfOperation;
            _increaseIQOverTime = increaseIQOverTime;
        }

        public override AndroidPrototype Clone()
        {
            Console.WriteLine("*** Cloning android:");
            Console.WriteLine($"--> IQ: {_iq}");
            Console.WriteLine($"--> Area of Operation: {_areaOfOperation}");
            Console.WriteLine($"--> Increase IQ Over Time: {_increaseIQOverTime}");
            Console.WriteLine("*** EOP");
            Console.WriteLine("");

            return MemberwiseClone() as AndroidPrototype;
        }

        public void DisplayInternalData()
        {
            Console.WriteLine("*** Android data:");
            Console.WriteLine($"--> IQ: {_iq}");
            Console.WriteLine($"--> Area of Operation: {_areaOfOperation}");
            Console.WriteLine($"--> Increase IQ Over Time: {_increaseIQOverTime}");
            Console.WriteLine("*** EOF");
            Console.WriteLine("");
        }

        public void ChangeIQ(int iq)
        {
            _iq = iq;
        }

        public void ChangeRateOfIQIncreaseOverTime(int delta)
        {
            _increaseIQOverTime = delta;
        }
    }
}
