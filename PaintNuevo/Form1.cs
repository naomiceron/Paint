using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintNuevo
{
    public partial class Form1 : Form
    {
        Graphics objDibujador;
        int primerX = 0;
        int primerY = 0;
        int primerXsiguientePunto = 0;
        int primerYsiguientePunto = 0;
        int primerXcero = 0;
        int primerYcero = 0; 
        double distanciaEntrelosPuntos = 0;
        int finalX = 0;
        int finalY = 0;
        Figuras figuraActiva;
        enum Figuras
        {
            Linea,
            Circulo,
            Arco,
            Triangulo,
            Cuadrado,
            Rectangulo,
            Pentagono,
            Poligono

        }



        public Form1()
        {
            InitializeComponent();
        }

        private void btnLinea_Click(object sender, EventArgs e)
        {
            figuraActiva = Figuras.Linea;

        }

        private void btnCirculo_Click(object sender, EventArgs e)
        {
            figuraActiva = Figuras.Circulo;

        }

        private void btnArco_Click(object sender, EventArgs e)
        {
            figuraActiva = Figuras.Arco;

        }

        private void btnTriangulo_Click(object sender, EventArgs e)
        {
            figuraActiva = Figuras.Triangulo;

        }

        private void btnCuadrado_Click(object sender, EventArgs e)
        {
            figuraActiva = Figuras.Cuadrado;

        }

        private void btnRectangulo_Click(object sender, EventArgs e)
        {
            figuraActiva = Figuras.Rectangulo;

        }

        private void btnPentagono_Click(object sender, EventArgs e)
        {
            figuraActiva = Figuras.Pentagono;
        }

        private void btnPoligonoIR_Click(object sender, EventArgs e)
        {
            figuraActiva = Figuras.Poligono;
        }

        private void graficarCirculoBresenham(int x, int y, int r)
        {
            int x1 = 0;
            int y1 = r;
            int d = 3 - 2 * r;
            Pen miLapiz = new Pen(pnlColores.BackColor, (float)nudGrosorLinea.Value);
            while (x1 <= y1)
            {
                objDibujador.DrawRectangle(miLapiz, x + x1, y + y1, 1, 1);
                objDibujador.DrawRectangle(miLapiz, x - x1, y + y1, 1, 1);
                objDibujador.DrawRectangle(miLapiz, x + x1, y - y1, 1, 1);
                objDibujador.DrawRectangle(miLapiz, x - x1, y - y1, 1, 1);
                objDibujador.DrawRectangle(miLapiz, x + y1, y + x1, 1, 1);
                objDibujador.DrawRectangle(miLapiz, x - y1, y + x1, 1, 1);
                objDibujador.DrawRectangle(miLapiz, x + y1, y - x1, 1, 1);
                objDibujador.DrawRectangle(miLapiz, x - y1, y - x1, 1, 1);
                if (d < 0)
                {
                    d += 4 * x1 + 6;

                }
                else
                {
                    d += 4 * (x1 - y1) + 10;
                    y1--;
                }
                x1++;
            }

        }

        private void graficarArcoBresenham(int x, int y, int r)
        {
            int x1 = 0;
            int y1 = r;
            int d = 3 - 2 * r;
            Pen miLapiz = new Pen(pnlColores.BackColor, (float)nudGrosorLinea.Value);
            while (x1 <= y1)
            {
                //objDibujador.DrawRectangle(miLapiz, x + x1, y + y1, 1, 1);
                //objDibujador.DrawRectangle(miLapiz, x - x1, y + y1, 1, 1);
                objDibujador.DrawRectangle(miLapiz, x + x1, y - y1, 1, 1);
                objDibujador.DrawRectangle(miLapiz, x - x1, y - y1, 1, 1);
                //objDibujador.DrawRectangle(miLapiz, x + y1, y + x1, 1, 1);
                //objDibujador.DrawRectangle(miLapiz, x - y1, y + x1, 1, 1);
                objDibujador.DrawRectangle(miLapiz, x + y1, y - x1, 1, 1);
                //objDibujador.DrawRectangle(miLapiz, x - y1, y - x1, 1, 1);
                if (d < 0)
                {
                    d += 4 * x1 + 6;

                }
                else
                {
                    d += 4 * (x1 - y1) + 10;
                    y1--;
                }
                x1++;
            }

        }

        private void GraficarLineaBresenham(int x1, int y1, int x2, int y2)
        {
            Pen miLapiz = new Pen(pnlColores.BackColor, (float)nudGrosorLinea.Value);
            int slope;
            int dx, dy, inCE, inCNE, d, y, x;
            dx = x2 - x1;
            dy = y2 - y1;

            if (Math.Abs(dy) > Math.Abs(dx))
            {
                if (y1 > y2)
                {
                    GraficarLineaBresenham(x2, y2, x1, y1);
                    return;
                }


                if (dx < 0)
                {
                    slope = -1;
                    dx = -dx;
                }
                else
                {
                    slope = 1;
                }

                inCE = 2 * dx;
                inCNE = (2 * dx) - (2 * dy);
                d = (2 * dx) - dy;
                x = x1;

                for (y = y1; y <= y2; y++)
                {
                    objDibujador.DrawRectangle(miLapiz, x, y, 1, 1);
                    if (d <= 0)
                    {
                        d += inCE;
                    }
                    else
                    {
                        d += inCNE;
                        x += slope;
                    }
                }
            }
            else
            {
                if (x1 > x2)
                {
                    GraficarLineaBresenham(x2, y2, x1, y1);
                    return;
                }


                if (dy < 0)
                {
                    slope = -1;
                    dy = -dy;
                }
                else
                {
                    slope = 1;
                }

                inCE = 2 * dy;
                inCNE = (2 * dy) - (2 * dx);
                d = (2 * dy) - dx;
                y = y1;

                for (x = x1; x <= x2; x++)
                {
                    objDibujador.DrawRectangle(miLapiz, x, y, 1, 1);
                    if (d <= 0)
                    {
                        d += inCE;
                    }
                    else
                    {
                        d += inCNE;
                        y += slope;
                    }
                }

            }


        }
        private Point[] getVertices(int lados, float radio, Point centro)
        {
            List<Point> puntos = new List<Point>();
            float step = 360.0f / lados;
            int anguloInicial = 90;
            float angulo = anguloInicial;
            for (float i = anguloInicial; i < anguloInicial + 360.0; i += step)
            {
                puntos.Add(angulos_XY(angulo, radio, centro));
                angulo += step;
            }

            return puntos.ToArray();
        }
        private Point angulos_XY(float grados, float radio, Point origen)
        {
            Point valor_xy = new Point();
            double radianes = grados * Math.PI / 180.0;
            valor_xy.X = (int)(Math.Cos(radianes) * radio + origen.X);
            valor_xy.Y = (int)(Math.Sin(-radianes) * radio + origen.Y);
            return valor_xy;
        }
        private void pnlCanvas_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void pnlCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            finalX = e.X;
            finalY = e.Y;

            switch (figuraActiva)
            {
                case Figuras.Linea:
                    finalX = e.X;
                    finalY = e.Y;

                    int x1, x2, y1, y2;

                    x1 = primerX;
                    x2 = finalX;
                    y1 = primerY;
                    y2 = finalY;

                    objDibujador = pnlCanvas.CreateGraphics();
                    GraficarLineaBresenham(x1, y1, x2, y2);
                    break;
                case Figuras.Circulo:
                    int x, y, r;
                    x = e.X;
                    y = e.Y;
                    r = (int)Math.Sqrt(Math.Pow((finalX - primerX), 2) + Math.Pow((finalY - primerY), 2));
                    objDibujador = pnlCanvas.CreateGraphics();
                    graficarCirculoBresenham(primerX, primerY, r);

                    break;
                case Figuras.Arco:
                    
                   
                    r = (int)Math.Sqrt(Math.Pow((finalX - primerX), 2) + Math.Pow((finalY - primerY), 2));
                    
                    
                    objDibujador = pnlCanvas.CreateGraphics();
                    graficarArcoBresenham(primerX, primerY, r);
                    break;
                case Figuras.Triangulo:

                    int Pmx = (finalX + primerX) / 2;
                    int Pmy = (finalY + primerY) / 2;

                    int Nx = (-1) * (finalX - primerX);
                    int Ny = (finalY - primerY);

                    float SinY = Ny * 0.866f;
                    float SinX = Nx * 0.866f;


                    PointF[] points = { new PointF(primerX, primerY), new PointF(finalX, finalY), new PointF(Pmx + SinY, Pmy + SinX) };
                    objDibujador = pnlCanvas.CreateGraphics();
                    GraficarLineaBresenham(primerX, primerY, finalX, finalY);
                    GraficarLineaBresenham(finalX, finalY, (int)(Pmx + SinY), (int)(Pmy + SinX));
                    GraficarLineaBresenham((int)(Pmx + SinY), (int)(Pmy + SinX),primerX, primerY);

                    break;
                case Figuras.Cuadrado:
                    int deltaX = finalX - primerX;
                    int deltaY = finalY - primerY;
                    double diagonalCuadrado = Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2));

                    objDibujador = pnlCanvas.CreateGraphics();
                    if (Math.Abs(deltaX) > Math.Abs(deltaY))
                    {
                        if (deltaX > 0)
                        {
                            GraficarLineaBresenham(primerX, primerY, (primerX + deltaY), primerY);
                            GraficarLineaBresenham(primerX, primerY, primerX, finalY);
                            GraficarLineaBresenham((primerX + deltaY), primerY, (primerX + deltaY), finalY);
                            GraficarLineaBresenham(primerX, finalY, (primerX + deltaY), finalY);
                        }
                        else
                        {
                            GraficarLineaBresenham((primerX - deltaY), primerY, primerX, primerY);
                            GraficarLineaBresenham((primerX - deltaY), primerY, (primerX - deltaY), finalY);
                            GraficarLineaBresenham(primerX, primerY, primerX, finalY);
                            GraficarLineaBresenham((primerX - deltaY), finalY, primerX, finalY);
                        }
                    }
                    else if (Math.Abs(deltaY) > Math.Abs(deltaX))
                    {
                        if (deltaY > 0)
                        {
                            GraficarLineaBresenham(primerX, primerY, finalX, primerY);
                            GraficarLineaBresenham(finalX, primerY, finalX, (primerY + deltaX));
                            GraficarLineaBresenham(primerX, primerY, primerX, (primerY + deltaX));
                            GraficarLineaBresenham(primerX, (primerY + deltaX), finalX, (primerY + deltaX));
                        }
                        else
                        {
                            GraficarLineaBresenham(primerX, primerY, finalX, primerY);
                            GraficarLineaBresenham(primerX, primerY, primerX, (primerY + deltaX));
                            GraficarLineaBresenham(finalX, primerY, finalX, (primerY + deltaX));
                            GraficarLineaBresenham(primerX, (primerY + deltaX), finalX, (primerY + deltaX));
                        }
                    }
                   


                    break;
                case Figuras.Rectangulo:
                    int anchoRectangulo = finalX - primerX;
                    int alturaRectangulo = finalY - primerX;
                    
                    double diagonalRectangulo = Math.Sqrt(Math.Pow(anchoRectangulo, 2) + Math.Pow(alturaRectangulo, 2));

                    objDibujador = pnlCanvas.CreateGraphics();
                    GraficarLineaBresenham(primerX, primerY, finalX, primerY);
                    GraficarLineaBresenham(primerX, primerY, primerX, finalY);
                    GraficarLineaBresenham(finalX, primerY, finalX, finalY);
                    GraficarLineaBresenham(primerX, finalY, finalX, finalY);
                    break;
                case Figuras.Pentagono:
                    
                    objDibujador = pnlCanvas.CreateGraphics();

                    double vertices = Math.Pow(finalX - primerX, 2) + Math.Pow(finalY - primerY, 2);
                    Point centro = new Point(primerX, primerY);
                    Point[] puntos = getVertices(5, (float)Math.Sqrt(vertices),centro);
                    //objDibujador.DrawPolygon(miLapiz, getVertices(5, (float)Math.Sqrt(vertices), centro));
                    GraficarLineaBresenham(puntos[0].X, puntos[0].Y, puntos[1].X, puntos[1].Y);
                    GraficarLineaBresenham(puntos[1].X, puntos[1].Y, puntos[2].X, puntos[2].Y);
                    GraficarLineaBresenham(puntos[2].X, puntos[2].Y, puntos[3].X, puntos[3].Y);
                    GraficarLineaBresenham(puntos[3].X, puntos[3].Y, puntos[4].X, puntos[4].Y);
                    GraficarLineaBresenham(puntos[4].X, puntos[4].Y, puntos[0].X, puntos[0].Y);
                    break;
                case Figuras.Poligono:
                    finalX = e.X;
                    finalY = e.Y;


                   
                    objDibujador = pnlCanvas.CreateGraphics();
                    if (primerXsiguientePunto == 0)
                    {
                        primerXcero = primerX;
                        primerYcero = primerY;
                        GraficarLineaBresenham(primerX, primerY, finalX, finalY);
                        primerXsiguientePunto = finalX;
                        primerYsiguientePunto = finalY;

                    }
                    else
                    {
                        
                        distanciaEntrelosPuntos = Math.Sqrt(Math.Pow((finalX - primerXcero), 2) + Math.Pow((finalY - primerYcero), 2));

                        if (distanciaEntrelosPuntos <= 20)
                        {
                            GraficarLineaBresenham(primerXsiguientePunto, primerYsiguientePunto, primerXcero, primerYcero);
                            primerXsiguientePunto = 0;
                            primerYsiguientePunto = 0;

                        }
                        else
                        {
                            GraficarLineaBresenham(primerXsiguientePunto, primerYsiguientePunto, finalX, finalY);
                            primerXsiguientePunto = finalX;
                            primerYsiguientePunto = finalY;
                        }
                    }

                    
                    
                   
                    break;
                default:
                    break;
            }
        }

        private void pnlCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            primerY = e.Y;
            primerX = e.X;
            
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (clrdColores.ShowDialog() == DialogResult.OK)
            {
                pnlColores.BackColor = clrdColores.Color;
            }
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            objDibujador.Clear(pnlCanvas.BackColor = Color.White);

            pnlCanvas.Refresh();
        }

        private void pnlCanvas_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
