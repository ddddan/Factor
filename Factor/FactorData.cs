using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factor
{
    public class FactorData
    {
        private const int MAX_TRIES = 10000;
        private int[] m_seedfactors = new int[4] { 2, 3, 5, 7 };

        private int m_value;
        List<int> m_factorList = new List<int>();
        //private int m_greatestFactor;
        //private double m_log;
        //private double m_compositivity;


        // Constructors
        public FactorData() { }

        public FactorData(int newValue)
        {
            m_value = newValue;
        }

        // Getters & Setters
        public int Value
        {
            get
            {
                return m_value;
            }
            set
            {
                m_value = value;
                m_factorList.Clear();
                m_factorList = Factors();
            }
        }

        // Body functions
        public List<int> Factors()
        {
            int currentFactor = 0;
            int currentValue = m_value;

            int threshold;

            // If the factor list has already been created, don't re-create it
            if (m_factorList != null && m_factorList.Count > 0)
            {
                return m_factorList;
            }

            // If the value is 0 or 1, don't bother
            if (m_value < 2)
            {
                return null;
            }

            // Do factoring - start with seed values
            threshold = Convert.ToInt32(Math.Round(Math.Sqrt((double)currentValue)));

            int i = 0; // Counter for factor progression
            do
            {
                // Use seed factors if available, otherwise increment by two (all odd #s)
                if (i < m_seedfactors.Length)
                {
                    currentFactor = m_seedfactors[i];
                }
                else
                {
                    currentFactor += 2;
                }

                // Check the factor and keep checking until exhausted
                // Once square root or number itself is exceeded, we are done
                while (currentFactor < threshold && currentFactor < currentValue &&
                    (currentValue / currentFactor * currentFactor == currentValue))
                {
                    m_factorList.Add(currentFactor);
                    currentValue = currentValue / currentFactor;
                }

            } while (++i < MAX_TRIES); // Escape clause to avoid infinite looping

            if (currentValue > 1)
            {
                m_factorList.Add(currentValue);
            }

            return m_factorList;
        }

    }

}
