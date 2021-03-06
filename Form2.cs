﻿using System;
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
    public partial class Form2 : Form
    {
        //zmienne pomocnicze do wyświetlania labela z liczbą (druga szansa)
        public int ratunek_licznik_odstępu = 100;
        public int ratunek_licznik_widocznosci = 0;

        //pędzel do grafiki
        public SolidBrush myBrush = new SolidBrush(Color.Gray);

        //zmienna do liczb pseudolosowych
        static public Random random = new Random();

        //stworzenie obiektów w grze (zawodnik, kulka do zlapania, kulki pułapki)
        Zawodnik zawodnik = new Zawodnik();
        Niewiadome niewiadoma1 = new Niewiadome();
        Niewiadome niewiadoma2 = new Niewiadome();
        Niewiadome niewiadoma3 = new Niewiadome();

        //zmienna zawierająca wynik zdobytych kulek
        public int wynik = 0;

        //zmienna do "ponownej szansy" - wyswietlanie liczby w prawym gornym rogu
        public int wylosowana;
        //zmienna okreslająca czy użytkownik wykorzystał już swoją dodatkową szanse
        public Boolean czy_szansa = false;





        public Form2()
        {
            //odczytywanie rodzaju ustawien z pliku settings
            String lines = File.ReadAllText("settings_IO.txt");
            int settings;
            Int32.TryParse(lines, out settings);

            InitializeComponent();

            //void losujący liczby, które bedą w kulkach + wyznaczenie skłądników dodawania + wybór poprawnej kulki
            wybor_poprawnej();
        }
        public Form2(int wynik, Boolean czy_szansa) //konstruktor, ktory przekazuje parametry wynik i szansa do kolejnej Formy - najprawdopodobniej potrzebne do formy z "drugą szansą"
        {
            this.wynik = wynik;
            this.czy_szansa = czy_szansa;
            InitializeComponent();
            wybor_poprawnej();
        }


        //druga część ruchu kulek, która sprawia, że kulki odbijają się również od siebie (pierwsza część ruchu w Niewadome.cs)
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


        public void game_over() //detekcja przegranej lub "drugiej szansy", gdy uzytkownik najedzie na zła kulke
        {
            //warunki najehcania na zla kulke
            if (((niewiadoma2.wspolrzedne_x - 26 < zawodnik.pozycja_x & zawodnik.pozycja_x < niewiadoma2.wspolrzedne_x + 70) & (niewiadoma2.wspolrzedne_y - 26 < zawodnik.pozycja_y & zawodnik.pozycja_y < niewiadoma2.wspolrzedne_y + 70))
                | (niewiadoma3.wspolrzedne_x - 26 < zawodnik.pozycja_x & zawodnik.pozycja_x < niewiadoma3.wspolrzedne_x + 70) & (niewiadoma3.wspolrzedne_y - 26 < zawodnik.pozycja_y & zawodnik.pozycja_y < niewiadoma3.wspolrzedne_y + 70))
            {
                //druga szansa
                if (czy_szansa == false)
                {
                    czy_szansa = true;
                    new Szansa(wylosowana, wynik, czy_szansa).Show();
                    this.Close();
                }
                //definitywny koniec
                else
                {
                    new GameOver(wynik).Show();
                    this.Close();
                }
            }
        }

        //void losujący liczby, które bedą w kulkach + wyznaczenie skłądników dodawania + wybór poprawnej kulki
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

        //dodawanie punktów, gdy najedzie się na prawidłową kulke
        public void dodaj_do_wyniku()
        {
            if ((niewiadoma1.wspolrzedne_x - 26 < zawodnik.pozycja_x & zawodnik.pozycja_x < niewiadoma1.wspolrzedne_x + 70) & (niewiadoma1.wspolrzedne_y - 26 < zawodnik.pozycja_y & zawodnik.pozycja_y < niewiadoma1.wspolrzedne_y + 70))
            {
                wynik += 1;
                wybor_poprawnej(); //void losujący liczby, które bedą w kulkach + wyznaczenie skłądników dodawania + wybór poprawnej kulki
                niewiadoma1.Generowanie_pozycji(); //void generujący nowe pozycje kulek
            }
            label3.Text = "Wynik:" + wynik.ToString(); 
        }

        
        //timer odpowiedzialny za pojawianie sie liczby do "drugiej szansy"
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

        //timer do monitorowania stanu gry (tj. czy dodac do wyniku, czy przegrana, czy druga szansa?)
        private void timer2_Tick(object sender, EventArgs e)
        {
            Invalidate();
            dodaj_do_wyniku();
            game_over();
        }

        //void pobierający współrzędne myszki
        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            zawodnik.Pob_wspol_zaw(e.X, e.Y);

        }

        //rysowanie
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
