using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Media;

namespace CustomControls
{
    /// <summary>
    /// 带颜色的Slider
    /// </summary>
    public class ColorSlider:System.Windows.Controls.Slider
    {
        #region Fields
        //依赖项属性设置是否可用绑定
        public static readonly DependencyProperty ColorProperty;
        public static readonly DependencyProperty ColorWidthProperty;

        #endregion
        #region Properties
        public Brush Color
        {
            get {return (Brush) GetValue(ColorProperty); }
            set { SetValue(ColorProperty, value); }
        }
        public Double ColorWidth
        {
            get { return (Double)GetValue(ColorWidthProperty); }
            set { SetValue(ColorWidthProperty, value); }
        }
        #endregion
        #region Constructors
        static ColorSlider()
        {
            FrameworkPropertyMetadata metadata = new FrameworkPropertyMetadata(new SolidColorBrush(Colors.Blue));
            ColorProperty = DependencyProperty.Register("Color", typeof(Brush), typeof(ColorSlider),
                metadata);
            ColorWidthProperty = DependencyProperty.Register("ColorWidth", typeof(Double), typeof(ColorSlider),
                new FrameworkPropertyMetadata(100.0));
        }
        #endregion
    }
}
