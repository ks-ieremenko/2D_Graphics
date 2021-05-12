using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectKR_Task3
{
    public partial class Form1 : Form
    {
        bool start = false;//старт анимации
        List<Matrix2D> FigurePoints; // координаты точек фигуры
        int h, w; //высота, ширина PictureBox
        float x0, y0;//точка, вокруг которой будет вращаться фигура
        int high = 1, middle = 2, low = 3;//для масштаба сетки
        static int size = 25; //масштаб
        bool figColorChanged = false, linesColorChanged = false;
        Color figClr, linesClr;// цвета фигуры и линий
        public Form1()
        {
            InitializeComponent();
            tbSize.Value = size;// масштаб
            FigurePoints = new List<Matrix2D> // координаты фигуры
            {
                new Matrix2D(2, 1),
                new Matrix2D(2, 3),
                new Matrix2D(5, 3),
                new Matrix2D(5, 1)
            };
            h = pictureBox1.Height / 2; // высота пополам
            w = pictureBox1.Width / 2;// ширина пополам
            dgv.Rows.Add(1, 0, 0); // добавление строчек в DataGridView
            dgv.Rows.Add(0, 1, 0);
            dgv.Rows.Add(0, 0, 1);
        }
        public void DrawPoint(Graphics gr, float x0, float y0)
        {
            SolidBrush pen = new SolidBrush(Color.Green);
            gr.FillEllipse(pen, x0 * size - 1f, -y0 * size - 2.5f, 5, 5);// нарисовать точку
        }
        public float DegreeToRad(float angle)
        {
            return (float)(angle * Math.PI / 180); // перевод в радианы
        }
        private void TranslateFigure()
        {
            float[,] matrix = new float[3, 3];
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++) // передаем в массив данные из DataGridView
                    matrix[i, j] = float.Parse(dgv[j, i].Value.ToString());
            foreach (Matrix2D point in FigurePoints)
                point.Mul(matrix,0,0);
        }
        private void DrawFigure(Graphics gr, List<Matrix2D> FigurePoints, Pen pen, Brush brush1, Brush brush2)
        {
            PointF[] points = new PointF[4];
            PointF start, end;
            for (int i = 0; i < 4; i++)
                points[i] = FigurePoints[i].To2DPoints(size);// массив для заливки
            gr.FillPolygon(brush2, points);//заливка
            for (int i = 0; i < 4; i++)//рисование фигуры
            {
                start = FigurePoints[i].To2DPoints(size);
                end = (i == 3) ? FigurePoints[0].To2DPoints(size) : FigurePoints[i + 1].To2DPoints(size);
                gr.DrawLine(pen, start, end);
                gr.FillEllipse(brush1, points[i].X - size / 20, points[i].Y - size / 25, size / 10, size / 10);
            }
        }
        private void DrawNumbers(Graphics gr, List<Matrix2D> figurePoints, Font fnt, Brush blackBrush)
        {
            char number = (char)65; // буква А
            PointF point;
            for (int i = 0; i < 4; i++)// подписываем вершины фигуры
            {
                point = figurePoints[i].To2DPoints(size);
                gr.DrawString(number.ToString(), fnt, blackBrush, point);
                number++;
            }
        }
        public void DrawAxes(Graphics gr, Pen pen, Font fnt, Brush brush, int h, int w)
        {
            gr.DrawLine(pen, -w + 20, 0, w - 20, 0); //ось х
            gr.DrawLine(pen, 0, h - 20, 0, -h + 20); // ось у
            gr.DrawString("X", fnt, brush, new PointF(w - 20, 0));//буква Х
            gr.DrawString("Y", fnt, brush, new PointF(0, -h + 10));//буква Y
        }
        public void DrawLines(Graphics gr, Pen pen)
        {
            int ans = (size > 20 && size <= 25) ? middle : ((size > 25) ? high : low);
            for (int i = ans * size; i < w - 40; i += ans * size) // черточки
            {
                gr.DrawEllipse(pen, i, -2.5f, 0.2f, 5);//на оси Х справа
                gr.DrawEllipse(pen, -i, -2.5f, 0.2f, 5);//на оси Х слева
                gr.DrawEllipse(pen, -2.5f, i, 5, 0.2f);//на оси Y ниже
                gr.DrawEllipse(pen, -2.5f, -i, 5, 0.2f);//на оси Y выше
            }
        }
        public void DrawGrid(Graphics gr, Pen pen)
        {
            for (int i = 0; i <= w; i += size)  // сетка
            {
                gr.DrawLine(pen, i, h, i, -h);//вертикальные линии справа
                gr.DrawLine(pen, -i, h, -i, -h);//вертикальные линии слева
                gr.DrawLine(pen, w, -i, -w, -i);//горизонтальные линии сверху
                gr.DrawLine(pen, w, i, -w, i);//горизонтальные линии снизу
            }
        }
        public void DrawNumbersAxes(Graphics gr, Brush brush, Font fnt)
        {
            int ans = (size > 20 && size <= 25) ? middle : ((size > 25) ? high : low);
            for (int i = ans; i < w / (size + 1); i += ans)
            {
                //положительные координаты на X, Y
                gr.DrawString(i.ToString(), fnt, brush, i * size - 4, 8);//X
                gr.DrawString(i.ToString(), fnt, brush, 8, -i * size - 5);//Y
            }
            for (int i = -ans; i > -w / (size + 1); i -= ans)
            {
                //отрицательные координаты на X, Y
                gr.DrawString(i.ToString(), fnt, brush, i * size - 7, 8);//X
                gr.DrawString(i.ToString(), fnt, brush, 8, -i * size - 8);//Y
            }
        }      
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            h = pictureBox1.Height / 2;
            w = pictureBox1.Width / 2;
            Graphics gr = e.Graphics;
            gr.SmoothingMode = SmoothingMode.HighQuality;//сглаживание линий
            gr.TranslateTransform(w, h); // новый центр
            Pen arrowBlackPen = new Pen(Color.Blue);//черная ручка со стрелкой
            arrowBlackPen.CustomEndCap = new AdjustableArrowCap(4, 4);

            Pen blackPen = new Pen(Color.Black, 0.5f);
            Font AxesFont = new Font("Times New Roman", 8);

            SolidBrush blackBrush = new SolidBrush(Color.Black);
            Pen grayPen = new Pen(Color.LightGray, 1);
            grayPen.DashStyle = DashStyle.DashDotDot;

            DrawGrid(gr, grayPen);//нарисовать сетку
            DrawLines(gr, blackPen);//нарисовать черточки
            DrawAxes(gr, arrowBlackPen, AxesFont, blackBrush, h, w);//нарисовать оси

            SolidBrush brushForFigure = new SolidBrush(Color.Red);
            if (figColorChanged)
                brushForFigure = new SolidBrush(figClr);//цвет заливки из ColorDialog

            SolidBrush brushForPoints = new SolidBrush(Color.DarkRed);
            Pen penForLines = new Pen(Color.DarkRed);
            if (linesColorChanged)
            {
                penForLines = new Pen(linesClr);//цвет линий из ColorDialog
                brushForPoints = new SolidBrush(linesClr);
            }
            int fontSize = (size < 15) ? 7 : 8;
            int verticesS= tbSize.Value / 3;
            verticesS = (verticesS < 1) ? 1 : tbSize.Value / 3;
            Font numbersFont = new Font("Times New Roman", fontSize); // шрифт
            Font verticesF = new Font("Times New Roman", verticesS); // шрифт
            GetXY();
            if (AxesNumb.Checked)
                DrawNumbersAxes(gr, blackBrush, numbersFont);//подписи осей
            TranslateFigure(); // перенос по матрице
            DrawFigure(gr, FigurePoints, penForLines, brushForPoints, brushForFigure);//нарисовать фигуру
            if (NumbersChB.Checked )//подписи вершин фигуры
                DrawNumbers(gr, FigurePoints, verticesF, blackBrush);
            if (ShowPointChb.Checked)
                DrawPoint(gr, x0, y0);
        }
        private void tbSize_Scroll(object sender, EventArgs e)
        {
            size = tbSize.Value; //значение масштаба
            txtSize.Text = size.ToString();
            pictureBox1.Invalidate();
        }
        private void txtSize_TextChanged(object sender, EventArgs e)
        {
            txtSize.Invalidate();
            if (txtSize.Text == "" || txtSize.Text == "-") tbSize.Value = 0;
            else
            {
                try
                {
                    if (int.Parse(txtSize.Text) > 60)
                    {
                        tbSize.Value = 20;
                        txtSize.Text = "20";
                        size = 20;
                        throw new Exception("Размер не может быть больше 60");
                    }
                    if (int.Parse(txtSize.Text) < 1)
                    {
                        tbSize.Value = 1;
                        txtSize.Text = "1";
                        size = 1;
                        throw new Exception("Размер не может быть меньше 1");
                    }
                    tbSize.Value = int.Parse(txtSize.Text);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            size = tbSize.Value;
            pictureBox1.Invalidate();
        }
        private void colorPickerLines_Click(object sender, EventArgs e)
        {
            linesColor.ShowDialog();//выбор цвета линий
            linesClr = linesColor.Color;
            linesColorChanged = true;
            pictureBox1.Invalidate();
        }
        private void AnimTimer_Tick(object sender, EventArgs e)
        {
            //анимация
            if (CenterAuto.Checked)//вращение по центру координат
                RotButton_Click(sender, e);
            pictureBox1.Invalidate();
        }
        private void Auto_CheckedChanged(object sender, EventArgs e)
        {
            if (CenterAuto.Checked && !start) //старт таймера
            {
                AnimTimer.Start();
                AnimTimer.Enabled = true;
                start = true;
            }
            else //стоп таймера
            {
                AnimTimer.Stop();
                AnimTimer.Enabled = false;
                start = false;
            }
        }
        public void GetXY()
        {
            if (Center.Checked)
            {
                panel2.Visible = false;
                x0 = 0; y0 = 0;
            }
            else if (FigCenter.Checked)
            {
                panel2.Visible = false;
                float sumx = 0, sumy = 0;
                for (int i = 0; i < FigurePoints.Count; i++)
                {
                    sumx += FigurePoints[i].GetX();
                    sumy += FigurePoints[i].GetY();
                }
                x0 = sumx / 4;
                y0 = sumy / 4;
            }
            else if(Point.Checked)
            {
                panel2.Visible = true;
                string pattern = "-?[0-9]+;-?[0-9]+"; // шаблон типа 1;1
                string[] start = PointTxt.Text.Split(';'); // координаты
                try
                {
                    if (!Regex.IsMatch(PointTxt.Text, pattern))
                        throw new Exception();
                    x0 = int.Parse(start[0]);
                    y0 = int.Parse(start[1]);
                }
                catch { }
            }
        }
        private void RotButton_Click(object sender, EventArgs e)
        {
            float[,] matrix_rotate = new float[3, 3];
            try
            {
                if (!Center.Checked && !Point.Checked && !FigCenter.Checked)
                    throw new Exception("Не выбран тип вращения");
                float degree = float.Parse(AngleTxt.Text);
                float sin = (float)Math.Sin(DegreeToRad(degree));
                float cos = (float)Math.Cos(DegreeToRad(degree));
                Array.Clear(matrix_rotate, 0, 3);
                matrix_rotate[0, 0] = cos;
                matrix_rotate[0, 1] = sin;
                matrix_rotate[1, 0] = -sin;
                matrix_rotate[1, 1] = cos;
                matrix_rotate[2, 2] = 1f;
                GetXY();
                foreach (Matrix2D point in FigurePoints)
                    point.Mul(matrix_rotate, x0, y0);
                pictureBox1.Invalidate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            //кнопка сбросить - обнуляю трекбары, цвета, DataGridView и текстбоксы
            size = 25;  txtSize.Text = 25.ToString();
            tbSize.Value = size; txtSize.Text = 25.ToString();
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {
                    if (i == j)
                        dgv[i, j].Value = 1;
                    else
                        dgv[i, j].Value = 0;
                }
            figClr = Color.Red;
            linesClr = Color.DarkRed;
            FigurePoints = new List<Matrix2D> // координаты фигуры
            {
                new Matrix2D(2, 1),
                new Matrix2D(2, 3),
                new Matrix2D(5, 3),
                new Matrix2D(5, 1)
            };
            Center.Checked = false;
            Point.Checked = false;
            FigCenter.Checked = false;
            panel2.Visible = false;
            AngleTxt.Text = "";
            CenterAuto.Checked = false;
            PointTxt.Text = "1;1";
            pictureBox1.Invalidate();
        }
        private void colorPickerFig_Click(object sender, EventArgs e)
        {
            figColor.ShowDialog(); //выбор цвета заливки
            figClr = figColor.Color;
            figColorChanged = true;
            pictureBox1.Invalidate();
        }
        private void InvalidateEvent(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();//перерисовка
        }
    }
}
