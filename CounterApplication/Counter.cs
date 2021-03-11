using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Counter
    {
        //attributi

        private int ActVal;
        private int MaxVal;
        private bool state;

        //metodi

        public Counter(int max)
        {
             ActVal = 0;
             MaxVal = max;
             state = false;

        }
        public void inc()
        {
             ActVal++;
             if (ActVal > MaxVal)
             {
                 state = true;
             }
             else
             {
                 state = false;
             }

        }

        public void reset()
        {
             ActVal = 0;
        }

        public int getValue()
        {
             return ActVal;
        }

        public bool isError()
        {
             return state;
        }
    }

