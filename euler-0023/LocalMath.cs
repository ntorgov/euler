using System.Numerics;

namespace euler_0023
{
    public class LocalMath
    {
        private BigInteger _value { get; set; }
        private BigInteger _dividers { get; set; }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="initValue"></param>
        public LocalMath(BigInteger initValue)
        {
            this.Value = initValue;
        }
        
        /// <summary>
        /// Значение
        /// </summary>
        public BigInteger Value
        {
            get { return _value; }
            set
            {
                _value = value;
                _dividers = Dividers(_value);
            }
        }

        /// <summary>
        /// Является ли число идеальным
        /// </summary>
        public bool IsIdeal
        {
            get { return _dividers == _value; }
        }

        /// <summary>
        /// Является ли число избыточным
        /// </summary>
        public bool IsAbundant
        {
            get { return _dividers > _value; }
        }

        /// <summary>
        /// Является ли число недостаточным
        /// </summary>
        public bool IsNonAbundant
        {
            get { return _dividers < _value; }
        }

        /// <summary>
        /// Сумма делителей
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        private static int Dividers(BigInteger number)
        {
            var nod = 0;

            for (var i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    nod += i;
                }
            }

            return nod;
        }
    }
}