using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_OO_Ex_01
{
    class Temperature
    {
        private double temperature;
        private char unite;

        public Temperature(double temperature, char unite)
        {
            this.temperature = temperature;
            this.unite = unite;
        }


        public void SetTemp(double t, char u)
        {

            if (u == 'c')
            {
                this.temperature = t;
                
            }
            else
            {
                this.temperature = (t - 32) *5 / 9;
                
            } 
        }

        public void SetUnit(char u)
        {
            unite = u;
        }


        public double EnCel()
        {
            if (unite == 'c')
            {
                return temperature;
            }
            else
            {
                return (temperature - 32) * 5 / 9;
            }

        }

        public double EnFar()
        {
            if (unite == 'f')
            {
                return temperature;
            }
            else
            {
                return temperature * 9 / 5 + 32;
            }          
        }

        public bool Chauffage()
        {          
            if (EnCel() < 15)
            {
                return true;
            }
            else
            {
                return false;
            }     
        }
    }
}
