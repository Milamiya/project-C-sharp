using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace VietGraph
{
    public enum GraphMode
    { Rectangular, Polar };

    //[ToolboxBitmap("graph.bmp")]
    public partial class ExpressionPlotter : Control
    {

        #region MemberVariables

        int iLengthScale; //represents no. of pixels for a scale
        int iOriginX, iOriginY; //represents the location of origin

        double dScaleX = 10, dScaleY = 10;  //base scale for graph 
        double dForwardX = 0, dForwardY = 0;    //position related to base scale

        int iDivisionsX = 5, iDivisionsY = 5;

        int iLengthBox;
        int iPrintStepX = 1;
        int iPrintStepY = 1;
        int iControlSize = 0;
        int iPenWidth = 1;

        bool bGrids = false;
        bool bDisplayText = true;

        int iPolarSensitivity = 100;

        GraphMode graphMode = GraphMode.Rectangular;
        PrintDocument printDoc;

        List<IEvaluatable> expressions;
        List<Color> expColors;
        List<bool> expVisible;

        #endregion

        #region Control specific functions
        public ExpressionPlotter()
        {
            this.expressions = new List<IEvaluatable>();
            this.expColors = new List<Color>();
            this.expVisible = new List<bool>();
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            //update internal variables
            UpdateVariables();

            pe.Graphics.Clear(Color.White);
            pe.Graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            pe.Graphics.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceOver;
            pe.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            PlotGraph(pe.Graphics);

            // Calling the base class OnPaint
            base.OnPaint(pe);
        }

        //private void ExpressionPlotter_Resize(object sender, EventArgs e)
        //{
        //    //code to keep the control's height and width same

        //    //see whether width was changed or the height was changed
        //    if (iControlSize != this.Width)
        //        this.Height = this.Width; //width was changed so adjust height accordingly
        //    else
        //        this.Width = this.Height; //height was changed so adjust width accordingly
        //}

        private void UpdateVariables()
        {
            iControlSize = this.Height;
            iLengthScale = (int)(iControlSize / 2.25);
            iOriginX = (this.Width) / 2;
            iOriginY = (this.Height) / 2;
            if (bGrids == true)
                this.iLengthBox = this.iLengthScale;
            else
                this.iLengthBox = (int)(this.iLengthScale * 0.025);
        }
        private double IncreaseScale(double scale)
        {
            double absScale = Math.Round(Math.Abs(scale), 3);
            double newScale;
            if (absScale >= 100)
                newScale = (absScale + 100);
            else if (absScale >= 10)
                newScale = (absScale + 10);
            else if (absScale >= 1)
                newScale = (absScale + 1);
            else if (absScale >= .10)
                newScale = (absScale + .10);
            else
                newScale = (absScale + .010);
            return newScale * Math.Sign(scale);
        }
        private double DecreaseScale(double scale)
        {
            double absScale = Math.Round(Math.Abs(scale), 3);
            double newScale;
            if (absScale > 100)
                newScale = (absScale - 100);
            else if (absScale > 10)
                newScale = (absScale - 10);
            else if (absScale > 1)
                newScale = (absScale - 1);
            else if (absScale > .1)
                newScale = (absScale - .1);
            else if (absScale > .01)
                newScale = (absScale - .01);
            else
                newScale = absScale;
            return newScale * Math.Sign(scale);
        }

        #endregion

        #region Properties
        public int DivisionsX
        {
            get { return this.iDivisionsX; }
            set { if (value > 0) this.iDivisionsX = value; }
        }
        public int DivisionsY
        {
            get { return this.iDivisionsY; }
            set { if (value > 0) this.iDivisionsY = value; }
        }

        public double ScaleX
        {
            get { return this.dScaleX; }
            set { if (value != 0) this.dScaleX = value; }
        }
        public double ScaleY
        {
            get { return this.dScaleY; }
            set { if (value != 0) this.dScaleY = value; }
        }

        public double ForwardX
        {
            get { return this.dForwardX; }
            set { this.dForwardX = value; }
        }
        public double ForwardY
        {
            get { return this.dForwardY; }
            set { this.dForwardY = value; }
        }

        public int PrintStepX
        {
            get { return this.iPrintStepX; }
            set { if (value > 0) this.iPrintStepX = value; }
        }
        public int PrintStepY
        {
            get { return this.iPrintStepY; }
            set { if (value > 0) this.iPrintStepY = value; }
        }

        public int PolarSensitivity
        {
            get { return this.iPolarSensitivity; }
            set { if (value > 0) this.iPolarSensitivity = value; }
        }

        public bool Grids
        {
            get { return this.bGrids; }
            set { this.bGrids = value; }
        }

        public bool DisplayText
        {
            get { return bDisplayText; }
            set { bDisplayText = value; }
        }

        public GraphMode GraphMode
        {
            get { return graphMode; }
            set { graphMode = value; }
        }

        public int PenWidth
        {
            get { return iPenWidth; }
            set { iPenWidth = value; }
        }

        #endregion

        #region Plotting Functions
        void PlotGraph(Graphics g)
        {
            DisplayScale(g);
            if (this.bDisplayText)
                DisplayExpressionsText(g);

            double X, Y;
            double dPointX, dPointY;
            double dLeastStepX, dLeastStepY;
            double dMin, dMax, dStep;
            int i;

            //(X1,Y1) is the previous point ploted, (X2,Y2) is the current point to plot. (we will join both to have our 
            // graph continuous).
            float X1 = 0, Y1 = 0, X2 = 0, Y2 = 0;
            //This variable controls whether our graph should be continuous or not
            bool bContinuity = false;

            //divide scale with its length(pixels) to get increment per pixel
            dLeastStepX = dScaleX / iLengthScale;
            dLeastStepY = dScaleY / iLengthScale;

            //prepare variables for loop
            if (graphMode == GraphMode.Polar)
            {
                dMin = -Math.PI;
                dMax = Math.PI;
                dStep = dScaleX / iPolarSensitivity;
            }
            else //if (Rectangular Mode)
            {
                dStep = dLeastStepX;
                dMin = -dScaleX + dForwardX;
                dMax = dScaleX + dForwardX;
            }


            for (i = 0; i < this.expressions.Count; i++)
            {
                //check if expression needs to be drawn and is valid
                if (expVisible[i] == true && expressions[i].IsValid == true)
                {
                    bContinuity = false;
                    for (X = dMin; X != dMax; X += dStep)
                    {
                        if (dScaleX < 0 && X < dMax)
                            break;
                        if (dScaleX > 0 && X > dMax)
                            break;
                        try
                        {
                            //evaluate expression[i] at point: X
                            Y = expressions[i].Evaluate(X);
                            if (double.IsNaN(Y))
                            {
                                //break continuity in graph if expression returned a NaN
                                bContinuity = false;
                                continue;
                            }

                            //get points to plot
                            if (graphMode == GraphMode.Polar)
                            {
                                dPointX = Y * Math.Cos(X) / dLeastStepX;
                                dPointY = Y * Math.Sin(X) / dLeastStepY;
                            }
                            else // if (Rectangular mode;
                            {
                                dPointX = X / dLeastStepX;
                                dPointY = Y / dLeastStepY;
                            }

                            //check if the point to be plotted lies inside our visible area(i.e. inside our current axes ranges)
                            if ((iOriginY - dPointY + dForwardY / dLeastStepY) < iOriginY - iLengthScale
                                || (iOriginY - dPointY + dForwardY / dLeastStepY) > iOriginY + iLengthScale
                                || (iOriginX + dPointX - dForwardX / dLeastStepX) < iOriginX - iLengthScale
                                || (iOriginX + dPointX - dForwardX / dLeastStepX) > iOriginX + iLengthScale)
                            {
                                //the point lies outside our current scale so break continuity
                                bContinuity = false;
                                continue;
                            }

                            //get coordinates for currently evaluated point
                            X2 = (float)(iOriginX + dPointX - dForwardX / dLeastStepX);
                            Y2 = (float)(iOriginY - dPointY + dForwardY / dLeastStepY);

                            //if graph should not be continuous
                            if (bContinuity == false)
                            {
                                X1 = X2;
                                Y1 = Y2;
                                // the graph should be continuous afterwards since the current evaluated value is valid 
                                //  and can be plot within our axes range
                                bContinuity = true;

                            }

                            //join points (X1,Y1) and (X2,Y2)
                            g.DrawLine(new Pen(expColors[i], iPenWidth), new PointF(X1, Y1), new PointF(X2, Y2));

                            //get current values into X1,Y1
                            X1 = X2;
                            Y1 = Y2;
                        }
                        catch
                        {
                            bContinuity = false;
                            continue;
                        }

                    }
                }
            }
        }

        void DisplayScale(Graphics g)
        {
            //axes lines
            g.DrawLine(new Pen(Color.Black, 2),
                new Point(iOriginX - iLengthScale, iOriginY),
                new Point(iOriginX + iLengthScale, iOriginY));

            g.DrawLine(new Pen(Color.Black, 2),
                new Point(iOriginX, iOriginY - iLengthScale),
                new Point(iOriginX, iOriginY + iLengthScale));

            int i;
            double dValue;
            string strValue;

            float cordX, cordY;

            //X-axis values
            dValue = -dScaleX + dForwardX;
            for (i = -iDivisionsX; i <= iDivisionsX; i++)
            {
                g.DrawLine(new Pen(Color.Gray, 1),
                    new PointF((float)(iOriginX + (dValue - dForwardX) * iLengthScale / dScaleX), iOriginY - iLengthBox),
                    new PointF((float)(iOriginX + (dValue - dForwardX) * iLengthScale / dScaleX), iOriginY + iLengthBox));
                if (i % iPrintStepX == 0 && i != 0)
                {
                    strValue = Math.Round(dValue, 3).ToString();
                    cordX = (float)(iOriginX + (dValue - dForwardX) * iLengthScale / dScaleX - 6 - (strValue.Length - 2) * 5);
                    cordY = (float)(iOriginY + 10);
                    g.DrawString(strValue, new Font("Arial", 8), new SolidBrush(Color.Black), cordX, cordY);
                }
                dValue = dValue + dScaleX / iDivisionsX;
            }


            //Y-axis values
            dValue = -dScaleY + dForwardY;
            for (i = -iDivisionsY; i <= iDivisionsY; i++)
            {
                g.DrawLine(new Pen(Color.Gray, 1),
                    new PointF(iOriginX - iLengthBox, (float)(iOriginY + (dValue - dForwardY) * iLengthScale / dScaleY)),
                    new PointF(iOriginX + iLengthBox, (float)(iOriginY + (dValue - dForwardY) * iLengthScale / dScaleY)));
                if (i % iPrintStepY == 0 && i != 0)
                {
                    strValue = Math.Round(dValue, 3).ToString();
                    cordX = (float)(iOriginX - 20 - (strValue.Length) * 4);
                    cordY = (float)(iOriginY - (dValue - dForwardY) * iLengthScale / dScaleY - 7);
                    if (this.iLengthBox == this.iLengthScale)
                        cordY += 6;
                    g.DrawString(strValue, new Font("Arial", 8), new SolidBrush(Color.Black), cordX, cordY);
                }
                dValue = dValue + dScaleY / iDivisionsY;
            }

            if (graphMode == GraphMode.Polar)
            {
                g.DrawEllipse(new Pen(Color.Black, 1), iOriginX - iLengthScale, iOriginY - (float)(iLengthScale * dScaleX / dScaleY), iLengthScale*2, (float)(iLengthScale * dScaleX / dScaleY)*2);
                for (dValue = 0; dValue <= 2 * Math.PI; dValue += Math.PI / 6)
                {
                    g.DrawLine(new Pen(Color.Black, 1), new Point(iOriginX, iOriginY),
                        new PointF((float)(iOriginX + iLengthScale * Math.Cos(dValue)), (float)(iOriginY + iLengthScale * Math.Sin(dValue))));
                }
            }
        }

        void DisplayExpressionsText(Graphics g)
        {
            int line = 0;
            for (int i = 0; i < this.expressions.Count; i++)
            {
                if (expVisible[i] == true)
                {
                    if (expressions[i].IsValid)
                        g.DrawString(expressions[i].ExpressionText, new Font("Arial", 10), new SolidBrush(expColors[i]), 10, 10 + 18 * line);
                    else
                        g.DrawString("ERROR: " + expressions[i].ExpressionText, new Font("Arial", 10), new SolidBrush(expColors[i]), 10, 10 + 18 * line);
                    line++;
                }
            }
        }

        void InitializePrintDoc()
        {
            this.printDoc = new PrintDocument();
            this.printDoc.OriginAtMargins = true;
            this.printDoc.DefaultPageSettings.Margins.Left = 200;
            this.printDoc.DefaultPageSettings.Margins.Top = 100;
            this.printDoc.DocumentName = "Graph Plotter by Syed Mehroz Alam";
            this.printDoc.PrintPage += delegate(object sender, PrintPageEventArgs e) { PlotGraph(e.Graphics); };
        }

        #endregion

        #region Public functions for expression management

        public void AddExpression(IEvaluatable expression, Color color, bool visible)
        {
            expressions.Add(expression);
            expColors.Add(color);
            expVisible.Add(visible);
        }
        public bool RemoveExpression(IEvaluatable expression)
        {
            int index = expressions.IndexOf(expression);
            if (index == -1)
                return false;
            expressions.RemoveAt(index);
            expColors.RemoveAt(index);
            expVisible.RemoveAt(index);
            return true;
        }
        public void RemoveExpressionAt(int index)
        {
            // can throw OutOfRangeException
            expressions.RemoveAt(index);
            expColors.RemoveAt(index);
            expVisible.RemoveAt(index);
        }
        public void RemoveAllExpressions()
        {
            this.expressions.Clear();
            this.expColors.Clear();
            this.expVisible.Clear();
        }

        public IEvaluatable GetExpression(int index)
        {
            // can throw OutOfRangeException
            return expressions[index];
        }
        public Color GetExpressionColor(int index)
        {
            // can throw OutOfRangeException
            return expColors[index];
        }
        public bool GetExpressionVisibility(int index)
        {
            // can throw OutOfRangeException
            return expVisible[index];
        }

        public void SetExpression(int index, IEvaluatable expression)
        {
            // can throw OutOfRangeException
            this.expressions[index]=expression;
        }
        public void SetExpressionColor(int index, Color color)
        {
            // can throw OutOfRangeException
            this.expColors[index]=color;
        }
        public void SetExpressionVisibility(int index, bool visibility)
        {
            // can throw OutOfRangeException
            this.expVisible[index]=visibility;
        }

        #endregion

        #region Public functions for graph management

        public void SetRangeX(double startX, double endX)
        {
            this.dScaleX = (endX - startX) / 2;
            this.dForwardX = (endX + startX) / 2;
        }
        public void SetRangeY(double startY, double endY)
        {
            this.dScaleY = (endY - startY) / 2;
            this.dForwardY = (endY + startY) / 2;
        }
        
        public void RestoreDefaults()
        {
            this.dScaleX = this.dScaleY = 10;
            this.dForwardX = this.dForwardY = 0;
            this.iDivisionsX=this.iDivisionsY = 5;
            this.iPrintStepX = this.iPrintStepY = 1;
            this.bGrids = false;
            this.iPolarSensitivity = 100;
        }

        public void ToggleGrids()
        {
            this.bGrids = (!bGrids);
        }

        public double[] GetValues(double x)
        {
            double[] result = new double[expressions.Count];
            for (int i = 0; i < this.expressions.Count; i++)
                if (this.expressions[i].IsValid)
                    result[i] = this.expressions[i].Evaluate(x);
            return result;
        }

        public Bitmap GetGraphBitmap()
        {
            Bitmap bmpSnap = new Bitmap(this.Width, this.Height);
            DrawToBitmap(bmpSnap, new Rectangle(0, 0, this.Width, this.Height));
            return bmpSnap;
        }

        public void CopyToClipboard()
        {
            Clipboard.SetImage(GetGraphBitmap());
        }

        public void MoveLeft(int divisions)
        {
            this.dForwardX -= divisions * this.dScaleX / this.iDivisionsX;
        }
        public void MoveRight(int divisions)
        {
            this.dForwardX += divisions * this.dScaleX / this.iDivisionsX;
        }
        public void MoveUp(int divisions)
        {
            this.dForwardY += divisions * this.dScaleY / this.iDivisionsY;
        }
        public void MoveDown(int divisions)
        {
            this.dForwardY -= divisions * this.dScaleY / this.iDivisionsY;
        }

        public void ZoomInX()
        {
            this.dScaleX = DecreaseScale(this.dScaleX);
        }
        public void ZoomInY()
        {
            this.dScaleY = DecreaseScale(this.dScaleY);
        }
        public void ZoomOutX()
        {
            this.dScaleX = IncreaseScale(this.dScaleX);
        }
        public void ZoomOutY()
        {
            this.dScaleY = IncreaseScale(this.dScaleY);
        }

        public void ZoomIn()
        {
            ZoomInX();
            ZoomInY();
        }
        public void ZoomOut()
        {
            ZoomOutX();
            ZoomOutY();
        }

        #endregion

    }
}
