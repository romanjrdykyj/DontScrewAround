using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DontScrewAround
{
    class Zawodnik
    {
        public int pozycja_x = 500;
        public int pozycja_y = 500;
        public int promien = 50;

        public Zawodnik()
        {

        }

        public void Pob_wspol_zaw(int x, int y) //niepotrzebnie zrobiona metoda ale już zostawiam; pobiera ona wspolrzedne i ogranicza pole ruchu zawodnika
        {
            this.pozycja_x = x;
            this.pozycja_y = y;
            if (pozycja_x < 115)
            {
                pozycja_x = 115;
            }
            if (pozycja_x > 1160)
            {
                pozycja_x = 1160;
            }
            if (pozycja_y < 110)
            {
                pozycja_y = 110;
            }
            if (pozycja_y > 900)
            {
                pozycja_y = 900;
            }
        }
    }
}