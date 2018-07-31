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

        #endregion
        #region Properties
        public Color Color
        {
            get {return (Color) GetValue(ColorProperty); }
            set { SetValue(ColorProperty, value); }
        }
        #endregion
        #region Constructors
        static ColorSlider()
        {
            FrameworkPropertyMetadata metadata = new FrameworkPropertyMetadata(Colors.Red);
            ColorProperty = DependencyProperty.Register("Color", typeof(Color), typeof(ColorSlider),
                metadata);
        }
        #endregion
    }
}
