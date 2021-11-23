using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassISBN
{
    public static  class ClassIsbn
    {
        public static bool VerifyISBN(int[] number)
        {
            if(number.Length == 10)
            {
                int position = 10;
                int multiplicacion = 0;
                int sumatoria = 0;

                for(int i=0;i < number.Length; i++)
                {
                    multiplicacion = number[i] * position;
                    sumatoria = sumatoria + multiplicacion;
                    multiplicacion = 0;
                    position--;
                }

                if(sumatoria % 11 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if(number.Length == 13)
            {
                
            }
            else
            {
                return false;
            }
        }
    }
}
