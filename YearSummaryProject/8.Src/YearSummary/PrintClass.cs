using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text;

namespace YearSummary
{
    /// <summary>
    /// 
    /// </summary>
    internal class PrintClass
    {
        private ListView lvDatas;
        System.Drawing.Printing.PrintPageEventArgs e;

        private string _title = "唐山市节约用水办公室单位总账统计表";


        /// <summary>
        /// 
        /// </summary>
        /// <param name="lv"></param>
        public PrintClass(ListView lv, Font textFont)
        {
            this.lvDatas = lv;
            //this.e = e;
            this.TextFont = textFont;
        }

        /// <summary>
        /// 
        /// </summary>
        private Font TitleFont
        {
            get
            {
                if (this._titleFont == null)
                {
                    Font f = this.TextFont;
                    //this._titleFont = new Font("宋体", 20, FontStyle.Regular);
                    this._titleFont = new Font(f.Name, f.Size + 4, FontStyle.Regular);
                }
                return this._titleFont;
            }
            set
            {
                this._titleFont = value;
            }

        } private Font _titleFont;

        /// <summary>
        /// 
        /// </summary>
        private Brush Brush
        {
            get { return Brushes.Black; }
        }

        /// <summary>
        /// 
        /// </summary>
        private Font TextFont
        {
            get
            {
                if (_textFont == null)
                {
                    _textFont = new Font("宋体", 9, FontStyle.Regular);
                }
                return _textFont;
            }
            set
            {
                _textFont = value;
            }
        } private Font _textFont;

        /// <summary>
        /// 
        /// </summary>
        private Point TitlePoint
        {
            get
            {
                SizeF size = e.Graphics.MeasureString(_title, TitleFont);
                int x = (int)(e.PageBounds.Width - size.Width) / 2;
                return new Point(x, 20);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private int PrintColumns
        {
            get
            {
                return this.lvDatas.Columns.Count - 1;
            }
        }

        private string PrintDateTime
        {
            get
            {
                return "打印时间: " + DateTime.Now;
            }
        }

        private Point DateTimePoint
        {
            get { return new Point(XStart, 60); }
        }

        private Pen Pen
        {
            get
            {
                return Pens.Black;
            }
        }

        private int XStart
        {
            get { return 75; }
        }

        private int YStart
        {
            get { return 80; }
        }

        /// <summary>
        /// 
        /// </summary>
        private int Height
        {
            get { return 25; }
        }

        /// <summary>
        /// 
        /// </summary>
        private int ColumnExpand
        {
            get { return 20; }
        }

        private StringFormat LeftAlignmentStringFormat
        {
            get
            {
                if (_leftAlignmentStringFormat == null)
                {
                    _leftAlignmentStringFormat = new StringFormat();
                    _leftAlignmentStringFormat.Alignment = StringAlignment.Near;
                }
                return _leftAlignmentStringFormat;
            }

        } private StringFormat _leftAlignmentStringFormat;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        private int GetWidth(int i)
        {
            int w = this.lvDatas.Columns[i].Width;
            return w;
        }
        int _lviIndex = 0;
        /// <summary>
        /// 
        /// </summary>
        public void Print( System.Drawing.Printing.PrintPageEventArgs e1)
        {
            this.e = e1;

            Console.WriteLine("Print()");
            StringFormat ss = new StringFormat();
            //ss.Alignment = StringAlignment.Center;      //居中位置                        
            ss.LineAlignment = StringAlignment.Center;


            e.Graphics.DrawString(_title, TitleFont, this.Brush, this.TitlePoint, ss);

            //显示打印日期
            e.Graphics.DrawString(PrintDateTime, this.TextFont, this.Brush, this.DateTimePoint,ss);

            //显示列标题
            //
            int x = 0;
            int y = 0;
            int w = 0;
            int h = 0;

            x = XStart;
            y = YStart;
            h = Height;

            for (int i = 0; i < this.PrintColumns; i++)
            {
                w = GetWidth(i);

                // 获取列中的标题文本内容
                //
                string str = this.lvDatas.Columns[i].Text;
                Rectangle rect = new Rectangle(x, y, w, h);
                e.Graphics.DrawRectangle(Pen, rect);

                // 框的中点
                //
                Point textPoint = new Point(x, y + Height / 2);

                e.Graphics.DrawString(str, TextFont, this.Brush, textPoint,ss);
                x += w;
            }

            y += Height;

            //显示列内容
            //for (i = 0; i < this.lvDatas.Items.Count; i++)
            for (; _lviIndex < this.lvDatas.Items.Count; _lviIndex++)
            {
                ListViewItem lvi = this.lvDatas.Items[_lviIndex];
                x = XStart;
                for (int k = 0; k < this.PrintColumns; k++)
                {
                    string str = lvi.SubItems[k].Text;
                    w = this.GetWidth(k);
                    Rectangle rect = new Rectangle(x, y, w, h);

                    e.Graphics.DrawRectangle(this.Pen, rect);

                    Point pt = new Point(x, y + Height / 2);
                    e.Graphics.DrawString(str, this.TextFont, this.Brush, pt, ss);

                    x += w;
                }
                y += Height;

                //
                //
                if (y >  e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    y = YStart;
                    //return;
                    break;
                }
                else
                {
                    e.HasMorePages = false;
                }
            }
        }


        /// <summary>
        /// 
        /// </summary>
        internal void Init()
        {
            this._lviIndex = 0;
        }
    }
}
