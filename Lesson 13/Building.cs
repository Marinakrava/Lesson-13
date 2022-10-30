using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_13
{
    class Building
    {
        string adress;
        int length;
        int width;
        int height;

        public string Adress
        { 
        get { return adress; }  
        set { adress = value; }                  
        }

        public int Length
        {
            get { return length;}
            set
            { if (value>100)
                    length = 100;
            else if (value<5)
                    length = 5;
            else
                length = value;
            } 
        }

        public int Width
        {
            get { return width;}
            set 
            {
                if (value > 100)
                    width = 100;
                else if (value < 5)
                    width = 5;
                else
                    width = value;               
            }   
        }

        public int Height
        {
            get { return height; }
            set 
            {
                if (value > 300)
                    height = 300;
                else if (value < 5)
                    height = 5;
                else
                    height = value;                
            }  
        }

        public Building (string adress, int length, int width, int height)
        {
            this.adress = adress;
            this.length = length;
            this.width = width; 
            this.height = height;   
        }

        public string Print()
        {
            return $"{adress}\n Длина здания = {length} м\n Ширина здания = {width} м\n Высота здания = {height} м";
        }


}


}


