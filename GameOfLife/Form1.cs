using System;
using System.Drawing;
using System.Windows.Forms;

namespace GameOfLife
{
    public partial class Form1 : Form
    {
        int tile_amount;
        int[,] cells;
        Graphics g;
        public Form1()
        {
            InitializeComponent();
        }
        private void CalculateGrid()
        {
            int cellCount = 0;
            int[,] newGrid = new int[tile_amount, tile_amount];
            for (int i = 0; i < cells.GetLength(0); i++)
            {
                for (int j = 0; j < cells.GetLength(1); j++)
                {
                    cellCount = CheckSurroundingCells(i, j);
                    if (cellCount < 2 || cellCount > 3)
                    {
                        newGrid[i, j] = 0;
                    }
                    else if (cellCount == 2 && cells[i, j] == 0)
                    {
                        newGrid[i, j] = 0;
                    }
                    else
                    {
                        newGrid[i, j] = 1;
                    }
                }
            }
            cells = newGrid;
        }

        private int CheckSurroundingCells(int pI, int pJ)
        {
            int count = 0;

            int im1 = pI - 1;
            if (im1 < 0) im1 = tile_amount - 1;

            int ip1 = pI + 1;
            if (ip1 >= tile_amount) ip1 = 0;

            int jm1 = pJ - 1;
            if (jm1 < 0) jm1 = tile_amount - 1;

            int jp1 = pJ + 1;
            if (jp1 >= tile_amount) jp1 = 0;


            if (cells[im1, jm1] == 1)
                count++;
            if (cells[pI, jm1] == 1)
                count++;
            if (cells[ip1, jm1] == 1)
                count++;

            if (cells[im1, pJ] == 1)
                count++;
            if (cells[ip1, pJ] == 1)
                count++;

            if (cells[im1, jp1] == 1)
                count++;
            if (cells[pI, jp1] == 1)
                count++;
            if (cells[ip1, jp1] == 1)
                count++;

            return count;
        }
        private void DrawGrid()
        {
            int tile_size = (int)Math.Floor((double)(pnlGame.Width) / tile_amount);
            g = pnlGame.CreateGraphics();
            Pen myPen = new Pen(Color.Black, 1);
            Brush dead = new SolidBrush(Color.Purple);
            Brush alive = new SolidBrush(Color.Yellow);
            for (int i = 0; i < tile_amount; i++)
            {
                for (int j = 0; j < tile_amount; j++)
                {
                    if (cells[i, j] == 0)
                    {
                        g.FillRectangle(dead, new Rectangle(i * tile_size, j * tile_size, tile_size, tile_size));
                    }
                    else
                    {
                        g.FillRectangle(alive, new Rectangle(i * tile_size, j * tile_size, tile_size, tile_size));
                    }
                    g.DrawRectangle(myPen, new Rectangle(i * tile_size, j * tile_size, tile_size, tile_size));
                }
            }
        }
        private void GenerateGrid()
        {
            Random rnd = new Random();
            tile_amount = 50;
            cells = new int[tile_amount, tile_amount];
            for (int i = 0; i < tile_amount; i++)
            {
                for (int j = 0; j < tile_amount; j++)
                {
                    cells[i, j] = rnd.Next(0, 2);
                }
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            GenerateGrid();
            DrawGrid();
            btnStart.Enabled = true;
        }

        private void tmrGen_Tick(object sender, EventArgs e)
        {
            CalculateGrid();
            DrawGrid();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            tmrGen.Start();
            btnStart.Enabled = false;
            btnStop.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            tmrGen.Stop();
            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }
    }
}
