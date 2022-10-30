using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_13
{
    sealed class MultiBuilding : Building
    {
        int storey;
        public MultiBuilding(string adress, int length, int width, int height, int storey)
             : base(adress, length, width, height)
        {
            this.storey = storey;
        }
        public int Storey
            { 
            get { return storey; } 
            set 
            {
                if (value > 100)
                    storey = 100;
                else if (value < 1)
                    storey = 1;
                else
                    storey = value;
            }    
            }  

         public string Print()
        {
            string result = base.Print();
            result += $" \n Количество этажей = {storey}";
            return result;  
        }
    }
}


