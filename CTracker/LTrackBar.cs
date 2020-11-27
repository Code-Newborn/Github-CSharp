using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTracker
{
    public class LTrackBar : Control
    {


        public LTrackBar()
        {
            //减少闪烁
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            CreateControl();
        }

        #region Property
        private Color _BarColor = Color.FromArgb(128, 255, 127);//light green
        [Category("DemoUI"), Description("背景条颜色")]
        public Color L_BarColor
        {
            get { return _BarColor; }
            set
            {
                _BarColor = value;
                Invalidate();//重绘控件
            }
        }


        private Color _SliderColor = Color.FromArgb(0, 192, 0);
        [Category("DemoUI"), Description("滑块颜色")]
        public Color L_SliderColor
        {
            get { return _SliderColor; }
            set
            {
                _SliderColor = value;
                Invalidate();
            }
        }

        private bool _IsRound = true;
        [Category("DemoUI"), Description("是否圆角")]
        public bool L_IsRound
        {
            get { return _IsRound; }
            set
            {
                _IsRound = value;
                Invalidate();
            }
        }

        private int _Minimum = 0;
        [Category("DemoUI"), Description("滑动条最小值")]
        public int L_Minimum
        {
            get { return _Minimum; }
            set
            {
                _Minimum = value;
                if (_Minimum >= _Maximum) _Minimum = _Maximum - 1;//不能超过最大值
                if (_Minimum < 0) _Minimum = 0;//不能小于0
                Invalidate();
            }
        }

        private int _Maximum = 100;
        [Category("DemoUI"), Description("滑动条最大值")]
        public int L_Maximum
        {
            get { return _Maximum; }
            set
            {
                _Maximum = value;
                if (_Maximum < _Minimum) _Maximum = _Minimum + 1;//不能小于最小值
                if (_Maximum > 100) _Maximum = 100;//不能大于100
                Invalidate();
            }
        }

        public delegate void LValueChangedEventHandler(object sender, LEventArgs e);//声明委托
        public event LValueChangedEventHandler LValueChanged;//控件的自定义事件，LEventArgs里存放事件数据


        private int _Value = 50;
        [Category("DemoUI"), Description("滑动条当前值")]
        public int L_Value
        {
            get { return _Value; }
            set
            {
                _Value = value;
                if (_Value < _Minimum) _Value = _Minimum;//当前值不能小于最小值
                if (_Value > _Maximum) _Value = _Maximum;//当前值不能大于最大值
                Invalidate();
                LValueChanged?.Invoke(this, new LEventArgs(_Value));//值更改：触发事件（方法匹配委托）
            }
        }

        private SelfOrientation _Orientation = SelfOrientation.Horizontal_LR;//滑动条方向
        [Category("DemoUI"), Description("滑动条方向")]
        public SelfOrientation L__Orientation
        {
            get { return _Orientation; }
            set
            {
                SelfOrientation old = _Orientation;//获取拖动条更改前的方向
                _Orientation = value;
                if ((old == SelfOrientation.Horizontal_LR || old == SelfOrientation.Horizontal_RL) && (_Orientation == SelfOrientation.Vertical_BT || _Orientation == SelfOrientation.Vertical_TB))
                {
                    Size = new Size(Size.Height, Size.Width);//方向更改时，获取新的宽度高度
                }
                if ((old == SelfOrientation.Vertical_BT || old == SelfOrientation.Vertical_TB) && (_Orientation == SelfOrientation.Horizontal_LR || _Orientation == SelfOrientation.Horizontal_RL))
                {
                    Size = new Size(Size.Height, Size.Width);//方向更改时，获取新的宽度高度
                }
                Invalidate();
            }
        }

        private int _BarSize = 10;
        [Category("DemoUI"), Description("滑块大小")]
        public int L_BarSize
        {
            get { return _BarSize; }
            set
            {
                _BarSize = value;
                if (_BarSize < 1) _BarSize = 1;//最小值不能小于1
                if (_Orientation == SelfOrientation.Horizontal_LR || _Orientation == SelfOrientation.Horizontal_RL)
                {
                    Size = new Size(Width, _BarSize);//水平方向：获取宽度和滑块大小
                }
                else
                {
                    Size = new Size(_BarSize, Height);//垂直方向：获取高度和滑块大小
                }
            }
        }
        #endregion


        #region 重写控件方法
        /// <summary>
        /// 指定控件边界
        /// </summary>
        /// <param name="x">控件位置X</param>
        /// <param name="y">控件位置Y</param>
        /// <param name="width">宽度</param>
        /// <param name="height">高度</param>
        /// <param name="specified"></param>
        protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified)
        {
            int iHeight = _BarSize;
            if (_Orientation == SelfOrientation.Horizontal_LR || _Orientation == SelfOrientation.Horizontal_RL)
            {
                base.SetBoundsCore(x, y, width, iHeight, specified);//水平方向：拖动条高度为滑块高度
            }
            else
            {
                base.SetBoundsCore(x, y, iHeight, height, specified);//垂直方向：拖动条宽度为滑块高度
            }

        }

        private MouseStatus mouseStatus = MouseStatus.Leave;//鼠标默认状态：离开
        private PointF mousePoint = Point.Empty;//鼠标默认位置：null
        /// <summary>
        /// 重写鼠标进入控件方法
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            mouseStatus = MouseStatus.Enter;//获取鼠标状态
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            mouseStatus = MouseStatus.Leave;//获取鼠标状态
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            mouseStatus = MouseStatus.Up;//获取鼠标状态
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            mouseStatus = MouseStatus.Down;//获取鼠标状态
            mousePoint = e.Location;//获取鼠标坐标
            pPointToValue();//将坐标转换成值
            Invalidate();//重绘
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (mouseStatus == MouseStatus.Down)//如果鼠标按下
            {
                mousePoint = e.Location;//获取鼠标坐标
                pPointToValue();//将坐标转换成值
                Invalidate();//重绘
            }
        }

        /// <summary>
        /// 重写控件绘制方法
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            pValueToPoint();//值转换成坐标，修改mousePoint的值
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;//顺滑绘制图形

            Pen penBarBack = new Pen(_BarColor, _BarSize);//滚动条背景色：绘笔（颜色，大小）
            Pen penBarFore = new Pen(_SliderColor, _BarSize);//滚动条前景色：绘笔（颜色，大小）

            float fCapHalfWidth = 0;
            float fCapWidth = 0;
            if (_IsRound)//是否圆角
            {
                fCapWidth = _BarSize;//线帽宽度
                fCapHalfWidth = _BarSize / 2.0f;
                penBarBack.StartCap = LineCap.Round;//背景条起点线帽：圆角
                penBarBack.EndCap = LineCap.Round;//背景条终点线帽：圆角

                penBarFore.StartCap = LineCap.Round; //前景条起点线帽：圆角
                penBarFore.EndCap = LineCap.Round;//前景条终点线帽：圆角
            }

            
            float fPointValue = 0;//用于获取鼠标点击位置坐标
            if (_Orientation == SelfOrientation.Horizontal_LR || _Orientation == SelfOrientation.Horizontal_RL)//拖动条为水平方向
            {
                e.Graphics.DrawLine(penBarBack, fCapHalfWidth, Height / 2f, Width - fCapHalfWidth, Height / 2f);//线帽中心的坐标，绘制背景条

                fPointValue = mousePoint.X;//获取鼠标点击的坐标位置（控件内）绘制开始时已对值进行相应的坐标转换
                if (fPointValue < fCapHalfWidth) fPointValue = fCapHalfWidth;
                if (fPointValue > Width - fCapHalfWidth) fPointValue = Width - fCapHalfWidth;
            }
            else//拖动条为垂直方向
            {
                e.Graphics.DrawLine(penBarBack, Width / 2f, fCapHalfWidth, Width / 2f, Height - fCapHalfWidth);//线帽中心的坐标，绘制背景条

                fPointValue = mousePoint.Y;//获取鼠标点击的位置坐标
                if (fPointValue < fCapHalfWidth) fPointValue = fCapHalfWidth;
                if (fPointValue > Height - fCapHalfWidth) fPointValue = Height - fCapHalfWidth;
            }


            if (_Orientation == SelfOrientation.Horizontal_LR)
            {
                e.Graphics.DrawLine(penBarFore, fCapHalfWidth, Height / 2f, fPointValue, Height / 2f);//绘制前景条，fPointValue鼠标点击的坐标值
            }
            else if (_Orientation == SelfOrientation.Horizontal_RL)
            {
                e.Graphics.DrawLine(penBarFore, fPointValue, Height / 2f, Width - fCapHalfWidth, Height / 2f);
            }
            else if (_Orientation == SelfOrientation.Vertical_TB)
            {
                e.Graphics.DrawLine(penBarFore, Width / 2f, fCapHalfWidth, Width / 2f, fPointValue);
            }
            else
            {
                e.Graphics.DrawLine(penBarFore, Width / 2f, fPointValue, Width / 2f, Height - fCapHalfWidth);
            }
        }
        #endregion


        /// <summary>
        /// 鼠标对于控件的状态
        /// </summary>
        public enum MouseStatus
        {
            Enter,
            Leave,
            Down,
            Up
        }

        /// <summary>
        /// 坐标转换成值
        /// </summary>
        private void pPointToValue()
        {
            float fCapHalfWidth = 0;
            float fCapWidth = 0;
            if (_IsRound)
            {
                fCapWidth = _BarSize;
                fCapHalfWidth = _BarSize / 2.0f;
            }
            if (_Orientation == SelfOrientation.Horizontal_LR)
            {
                float fRatio = Convert.ToSingle(mousePoint.X - fCapHalfWidth) / (Width - fCapWidth);//拖动条水平从左到右的占比
                _Value = Convert.ToInt32(fRatio * (_Maximum - _Minimum) + _Minimum);//转换成100制中的值
            }
            else if (_Orientation == SelfOrientation.Horizontal_RL)//拖动条水平从右到左的占比
            {
                float fRatio = Convert.ToSingle(Width - mousePoint.X - fCapHalfWidth) / (Width - fCapWidth);
                _Value = Convert.ToInt32(fRatio * (_Maximum - _Minimum) + _Minimum);
            }
            else if (_Orientation == SelfOrientation.Vertical_TB)//拖动条水平从上到小的占比
            {
                float fRatio = Convert.ToSingle(mousePoint.Y - fCapHalfWidth) / (Height - fCapWidth);
                _Value = Convert.ToInt32(fRatio * (_Maximum - _Minimum) + _Minimum);
            }
            else if (_Orientation == SelfOrientation.Vertical_BT)//拖动条水平从下到上的占比
            {
                float fRatio = Convert.ToSingle(Height - mousePoint.Y - fCapHalfWidth) / (Height - fCapWidth);
                _Value = Convert.ToInt32(fRatio * (_Maximum - _Minimum) + _Minimum);
            }
            if (_Value < _Minimum) _Value = _Minimum;//限制值的大小
            if (_Value > _Maximum) _Value = _Maximum;
            LValueChanged?.Invoke(this, new LEventArgs(_Value));//触发事件（调用委托，匹配方法）
        }

        /// <summary>
        /// 值转换成坐标
        /// </summary>
        private void pValueToPoint()
        {
            float fCapHalfWidth = 0;
            float fCapWidth = 0;
            if (_IsRound)
            {
                fCapWidth = _BarSize;
                fCapHalfWidth = _BarSize / 2.0f;
            }
            float fRatio = Convert.ToSingle(_Value - _Minimum) / (_Maximum - _Minimum);//拖动条当前值占比

            if (_Orientation == SelfOrientation.Horizontal_LR)//拖动条水平从左到右
            {
                float fPointValue = fRatio * (Width - fCapWidth) + fCapHalfWidth;//获取值对应的坐标
                mousePoint = new PointF(fPointValue, fCapHalfWidth);
            }
            else if (_Orientation == SelfOrientation.Horizontal_RL)
            {
                float fPointValue = Width - fCapHalfWidth - fRatio * (Width - fCapWidth);
                mousePoint = new PointF(fPointValue, fCapHalfWidth);
            }
            else if (_Orientation == SelfOrientation.Vertical_TB)
            {
                float fPointValue = fRatio * (Height - fCapWidth) + fCapHalfWidth;
                mousePoint = new PointF(fCapHalfWidth, fPointValue);
            }
            else
            {
                float fPointValue = Height - fCapHalfWidth - fRatio * (Height - fCapWidth);
                mousePoint = new PointF(fCapHalfWidth, fPointValue);
            }
        }


    }
}
