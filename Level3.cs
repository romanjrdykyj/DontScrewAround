using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DontScrewAround
{
    public partial class Level3 : Form
    {

        public int ratunek_licznik_odstępu = 100;
        public int ratunek_licznik_widocznosci = 0;
        Zawodnik zawodnik = new Zawodnik();
        public SolidBrush myBrush = new SolidBrush(Color.Gray);
        static public Random random = new Random();
        Niewiadome niewiadoma1 = new Niewiadome();
        Niewiadome niewiadoma2 = new Niewiadome();
        Niewiadome niewiadoma3 = new Niewiadome();
        Niewiadome niewiadoma4 = new Niewiadome();
        Niewiadome niewiadoma5 = new Niewiadome();
        Niewiadome niewiadoma6 = new Niewiadome();
        public int wynik = 0;
        public int wylosowana;
        public Boolean czy_szansa = false;



        public Level3()
        {
            niewiadoma1.szybkosc_ustawienia = 2;
            niewiadoma2.szybkosc_ustawienia = 2;
            niewiadoma3.szybkosc_ustawienia = 2;
            niewiadoma4.szybkosc_ustawienia = 2;
            niewiadoma5.szybkosc_ustawienia = 2;
            niewiadoma6.szybkosc_ustawienia = 2;
            InitializeComponent();
            wybor_poprawnej();
        }
        public Level3(int wynik, Boolean czy_szansa)
        {
            niewiadoma1.szybkosc_ustawienia = 2;
            niewiadoma2.szybkosc_ustawienia = 2;
            niewiadoma3.szybkosc_ustawienia = 2;
            niewiadoma4.szybkosc_ustawienia = 2;
            niewiadoma5.szybkosc_ustawienia = 2;
            niewiadoma6.szybkosc_ustawienia = 2;
            this.wynik = wynik;
            this.czy_szansa = czy_szansa;
            InitializeComponent();
            wybor_poprawnej();
        }


        public void odbijanie_kulek()
        {
            if (((niewiadoma2.wspolrzedne_x - 48 < niewiadoma1.wspolrzedne_x & niewiadoma1.wspolrzedne_x < niewiadoma2.wspolrzedne_x + 48) &
                (niewiadoma2.wspolrzedne_y - 48 < niewiadoma1.wspolrzedne_y & niewiadoma1.wspolrzedne_y < niewiadoma2.wspolrzedne_y + 48)))
            {
                niewiadoma1.odbicie_x = !niewiadoma1.odbicie_x;
                niewiadoma1.odbicie_y = !niewiadoma1.odbicie_y;
                niewiadoma2.odbicie_x = !niewiadoma2.odbicie_x;
                niewiadoma2.odbicie_y = !niewiadoma2.odbicie_y;
            }
            else if (((niewiadoma3.wspolrzedne_x - 48 < niewiadoma1.wspolrzedne_x & niewiadoma1.wspolrzedne_x < niewiadoma3.wspolrzedne_x + 48) &
                (niewiadoma3.wspolrzedne_y - 48 < niewiadoma1.wspolrzedne_y & niewiadoma1.wspolrzedne_y < niewiadoma3.wspolrzedne_y + 48)))
            {
                niewiadoma1.odbicie_x = !niewiadoma1.odbicie_x;
                niewiadoma1.odbicie_y = !niewiadoma1.odbicie_y;
                niewiadoma3.odbicie_x = !niewiadoma3.odbicie_x;
                niewiadoma3.odbicie_y = !niewiadoma3.odbicie_y;
            }
            else if (((niewiadoma3.wspolrzedne_x - 48 < niewiadoma2.wspolrzedne_x & niewiadoma2.wspolrzedne_x < niewiadoma3.wspolrzedne_x + 48) &
               (niewiadoma3.wspolrzedne_y - 48 < niewiadoma2.wspolrzedne_y & niewiadoma2.wspolrzedne_y < niewiadoma3.wspolrzedne_y + 48)))
            {
                niewiadoma2.odbicie_x = !niewiadoma2.odbicie_x;
                niewiadoma2.odbicie_y = !niewiadoma2.odbicie_y;
                niewiadoma3.odbicie_x = !niewiadoma3.odbicie_x;
                niewiadoma3.odbicie_y = !niewiadoma3.odbicie_y;
            }
        }


        public void game_over()
        {
            if (((niewiadoma2.wspolrzedne_x - 26 < zawodnik.pozycja_x & zawodnik.pozycja_x < niewiadoma2.wspolrzedne_x + 70) & (niewiadoma2.wspolrzedne_y - 26 < zawodnik.pozycja_y & zawodnik.pozycja_y < niewiadoma2.wspolrzedne_y + 70))
                | (niewiadoma3.wspolrzedne_x - 26 < zawodnik.pozycja_x & zawodnik.pozycja_x < niewiadoma3.wspolrzedne_x + 70) & (niewiadoma3.wspolrzedne_y - 26 < zawodnik.pozycja_y & zawodnik.pozycja_y < niewiadoma3.wspolrzedne_y + 70))
            {
                if (czy_szansa == false)
                {
                    czy_szansa = true;
                    new Szansa(wylosowana, wynik, czy_szansa).Show();
                    this.Close();
                }
                else
                {
                    new GameOver(wynik).Show();
                    this.Close();
                }
            }
        }

        public void wybor_poprawnej()
        {
            int skladnik1;
            int skladnik2;
            int rozwiazanie = 91;
            do
            {
                skladnik1 = random.Next(1, 90);
                skladnik2 = random.Next(1, 90);
                rozwiazanie = skladnik1 + skladnik2;
            } while (rozwiazanie > 90);
            niewiadoma1.losowanie_niewiadomych(rozwiazanie);
            int losowa = 92;
            do
            {
                losowa = random.Next(2, 90);
                niewiadoma2.losowanie_niewiadomych(losowa);
            } while (losowa == rozwiazanie);
            do
            {
                losowa = random.Next(2, 90);
                niewiadoma3.losowanie_niewiadomych(losowa);
            } while (losowa == rozwiazanie);
            niewiadoma1.Generowanie_pozycji();
            do
            {
                niewiadoma2.Generowanie_pozycji();
            } while (niewiadoma1.wspolrzedne_x - niewiadoma2.wspolrzedne_x < 100 & niewiadoma1.wspolrzedne_y - niewiadoma2.wspolrzedne_y < 100);
            do
            {
                niewiadoma3.Generowanie_pozycji();
            } while ((niewiadoma1.wspolrzedne_x - niewiadoma3.wspolrzedne_x < 100 & niewiadoma1.wspolrzedne_y - niewiadoma3.wspolrzedne_y < 100) |
            (niewiadoma3.wspolrzedne_x - niewiadoma2.wspolrzedne_x < 100 & niewiadoma3.wspolrzedne_y - niewiadoma2.wspolrzedne_y < 100));

            zawodnik.Pob_wspol_zaw(200, 200);
            niewiadoma1.szybkosc_x = 2;
            niewiadoma2.szybkosc_y = 2;

            label2.Text = "Rozwiąż: " + skladnik1.ToString() + " + " + skladnik2.ToString();
        }

        public void dodaj_do_wyniku()
        {
            if ((niewiadoma1.wspolrzedne_x - 26 < zawodnik.pozycja_x & zawodnik.pozycja_x < niewiadoma1.wspolrzedne_x + 70) & (niewiadoma1.wspolrzedne_y - 26 < zawodnik.pozycja_y & zawodnik.pozycja_y < niewiadoma1.wspolrzedne_y + 70))
            {
                wynik += 1;
                wybor_poprawnej();
                niewiadoma1.Generowanie_pozycji();
            }
            label3.Text = "Wynik:" + wynik.ToString();
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            if (czy_szansa == false)
            {



                if (ratunek_licznik_odstępu == 100)
                {
                    Random rnd = new Random();
                    int poczatek = 1;
                    int koniec = 49;
                    wylosowana = rnd.Next(poczatek, koniec);
                    label1.Visible = true;
                    label1.Text = "Zapamiętaj: " + wylosowana.ToString();
                    ratunek_licznik_odstępu = 0;
                }
                if (ratunek_licznik_widocznosci < 20)
                {
                    label1.Visible = true;
                }
                if (ratunek_licznik_widocznosci < 100 & ratunek_licznik_widocznosci > 20)
                {
                    label1.Visible = false;
                }
                if (ratunek_licznik_widocznosci == 100)
                {
                    ratunek_licznik_widocznosci = 0;
                }
                ratunek_licznik_odstępu += 1;
                ratunek_licznik_widocznosci += 1;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Invalidate();
            dodaj_do_wyniku();
            game_over();
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            zawodnik.Pob_wspol_zaw(e.X, e.Y);

        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillEllipse(myBrush, zawodnik.pozycja_x - 23, zawodnik.pozycja_y - 23, zawodnik.promien, zawodnik.promien);
            odbijanie_kulek();
            niewiadoma1.ruch();
            e.Graphics.DrawImage(new Bitmap(niewiadoma1.poprawny_obraz), niewiadoma1.wspolrzedne_x, niewiadoma1.wspolrzedne_y);
            niewiadoma2.ruch();
            e.Graphics.DrawImage(new Bitmap(niewiadoma2.poprawny_obraz), niewiadoma2.wspolrzedne_x, niewiadoma2.wspolrzedne_y);
            niewiadoma3.ruch();
            e.Graphics.DrawImage(new Bitmap(niewiadoma3.poprawny_obraz), niewiadoma3.wspolrzedne_x, niewiadoma3.wspolrzedne_y);
        }
    }
}
