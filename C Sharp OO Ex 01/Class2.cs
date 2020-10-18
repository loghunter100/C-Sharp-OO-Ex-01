using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_OO_Ex_01
{
    class SondeSpatiale
    {
        Temperature exterieur; 
        Temperature interieur;

        public SondeSpatiale(Temperature exterieur)
        {
            interieur = exterieur;
            this.exterieur = new Temperature(exterieur.EnCel(),'c');
        }


        public Temperature augmenterTemp(double interval, char unit)           
        {
           
            if (unit == 'c')
            {
                while (interieur.EnCel() < -50.0)
                {
                    interieur.SetTemp(interieur.EnCel() + interval,'c');
                    Console.WriteLine("Augmentation de la temperature interne : " + interieur.EnCel() + "°C");

                }
            }
            else
            {
                while (interieur.EnCel() < -50)
                {
                    interieur.SetTemp(interieur.EnFar() + interval,'f');
                    Console.WriteLine("Augmentation de la temperature interne : " + interieur.EnFar() + "°F");

                }
            }


           
            
            return interieur;
        }

        public void AfficherTempSonde()
        {
            
            Console.WriteLine($"temperature interne de la sonde {interieur.EnCel()} degrée C");
            Console.WriteLine($"temperature externe de la sonde {exterieur.EnCel()} degrée C");
        }



    }
}
