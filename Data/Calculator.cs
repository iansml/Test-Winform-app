using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delta.Data
{
    public class DeltaCalculator
    {
        private decimal val1 = 0;
        private decimal val2 = 0;
        private string text;

        public DeltaCalculator() { }
        public DeltaCalculator(decimal v1, decimal v2)
        {
            Val1 = v1;
            Val2 = v2;
        }

        public decimal Val1
        {
            get
            {
                return val1;
            }

            set
            {
                SetValue(val1, value);
            }
        }

        public decimal Val2
        {
            get
            {
                return val2;
            }

            set
            {
                SetValue(val2, value);
            }
        }

        public string Text
        {
            get
            {
                return text;
            }

            set
            {
                text = value;
            }
        }

        public Decimal AddValues()
        {
            return Val1 + Val2;
        }

        /// <summary>
        /// only values greater than or equal to zero are allowed
        /// </summary>
        /// <param name="valOrig">the value to update</param>
        /// <param name="valNew">the new value</param>
        private void SetValue (Decimal valOrig, Decimal valNew)
        {
            if (valNew >= 0)
                valOrig = valNew;
            else
                throw new ArgumentException(String.Format("Value cannot be less than zero:", valNew));

        }


    }
}
