using System;

namespace euler_0067
{
    public class Name
    {
        private string _title;

        /// <summary>
        /// Значение
        /// </summary>
        public int Value { get; set; }

        /// <summary>
        /// Имя
        /// </summary>
        public string Title
        {
            get { return _title; }
            set
            {
                _title = value.Trim('"');
                Value = Calculate(_title);
            }
        }

        /// <summary>
        /// Индекс
        /// </summary>
        public int Index { get; set; }

        /// <summary>
        /// Вычисление значения
        /// </summary>
        /// <param name="nameValue"></param>
        /// <returns></returns>
        private int Calculate(string nameValue)
        {
            int result = 0;

            foreach (var chr in nameValue)
            {
                var charIndex = (int) chr - 64;
                result = result + charIndex;
            }

            return result;
        }
    }
}