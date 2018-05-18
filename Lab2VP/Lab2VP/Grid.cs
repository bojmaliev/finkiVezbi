using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2VP
{
    class Grid
    {
        public int Rows { get; set; }
        public int Columns { get; set; }
        public Cell[][] Cells { get; set; }

        public Grid(int rows, int columns)
        {
            // kod za postavuvanje na svojstvata Rows i Columns
            Rows = rows;
            Columns = columns;
            // kod za inicijalizacija na matricata
            Cells = new Cell[rows][];
            for (int i = 0; i < Rows; i++)
            {
                Cells[i] = new Cell[Columns];
                for (int j = 0; j < Columns; j++)
                {
                    Cell inst = Cells[i][j];
                    
                    // ovde kod za instanciranje na objekt od klasata Cell
                    // i postavuvanje na toj objekt na soodvetniot element vo matricata
                    // ... vasiot kod ovde...   
                }
            }
        }

        public void ToggleCell(int x, int y, bool isAlive)
        {
            if (isAlive) Cells[x][y].IsAlive = false; else Cells[x][y].IsAlive = true;
        }

        public bool IsAlive(int x,int y) {
            try {
                if (Cells[x][y].IsAlive) return true;
                return false;
            }
            catch (IndexOutOfRangeException e) {
                return false;
            }
        }

        public void Evolve()
        {
            /*
            Algoritam za implementiranje na pravilata na igrata
            1. Za sekoja kletka vo matricata so kletki treba da se izbrojat brojot na
            zhivi sosedi vo 8-te nasoki (gore levo, gore sredina, gore desno, levo,
            desno, dolu levo, dolu sredina i dolu desno). */

            for (int i = 0; i < Rows; i++) {
                for (int j = 0; j < Columns; j++) {

                    int brojZiviSosedi = 0;
                    if (IsAlive(i - 1, j - 1)) brojZiviSosedi++;
                    if (IsAlive(i - 1, j)) brojZiviSosedi++;
                    if (IsAlive(i - 1, j + 1)) brojZiviSosedi++;
                    if (IsAlive(i + 1, j - 1)) brojZiviSosedi++;
                    if (IsAlive(i + 1, j + 1)) brojZiviSosedi++;
                    if (IsAlive(i + 1, j)) brojZiviSosedi++;
                    if (IsAlive(i, j - 1)) brojZiviSosedi++;
                    if (IsAlive(i, j + 1)) brojZiviSosedi++;

                    if (brojZiviSosedi < 2 && Cells[i][j].IsAlive) Cells[i][j].ShouldLive = false;
                    if ((brojZiviSosedi == 2 || brojZiviSosedi == 3 ) && Cells[i][j].IsAlive) Cells[i][j].ShouldLive = true;
                    if (brojZiviSosedi > 3 && Cells[i][j].IsAlive) Cells[i][j].ShouldLive = false;
                    if (brojZiviSosedi == 3 && !Cells[i][j].IsAlive) Cells[i][j].ShouldLive = true;
                }
            }

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    Cells[i][j].IsAlive = Cells[i][j].ShouldLive;
                }
            }

        }
    }
}
