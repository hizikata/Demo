using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Media;

namespace CustomControls
{
    public class ColorPicker:System.Windows.Controls.UserControl
    {
        #region DependencyProperties
        public static readonly DependencyProperty ColorProperty;
        public static readonly DependencyProperty RedProperty;
        public static readonly DependencyProperty GreenProperty;
        public static readonly DependencyProperty BlueProperty;
        
        /// <summary>
        /// 自定义控件颜色
        /// </summary>
        public Color Color
        {
            get { return (Color)GetValue(ColorProperty); }
            set { SetValue(ColorProperty, value); }
        }
        /// <summary>
        /// 颜色Red通道
        /// </summary>
        public byte Red
        {
            get { return (byte)GetValue(RedProperty); }
            set { SetValue(RedProperty, value); }
        }
        /// <summary>
        /// 颜色Green通道
        /// </summary>
        public byte Green
        {
            get { return (byte)GetValue(GreenProperty); }
            set { SetValue(GreenProperty, value); }
        }
        /// <summary>
        /// 颜色Blue通道
        /// </summary>
        public byte Blue
        {
            get { return (byte)GetValue(BlueProperty); }
            set { SetValue(BlueProperty, value); }
        }
        public static void OnColorChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            Color newColor = (Color)e.NewValue;
            Color oldColor = (Color)e.OldValue;

            ColorPicker colorPicker = (ColorPicker)sender;
            colorPicker.Red = newColor.R;
            colorPicker.Green = newColor.G;
            colorPicker.Blue = newColor.B;
        }
        public static void OnColorRGBChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            ColorPicker colorPicker = (ColorPicker)sender;
            Color color = colorPicker.Color;
            if (e.Property == RedProperty)
            {
                color.R = (byte)e.NewValue;
            }
            else if (e.Property == GreenProperty)
            {
                color.G = (byte)e.NewValue;
            }
            else if (e.Property == BlueProperty)
            {
                color.B = (byte)e.NewValue;
            }
            colorPicker.Color = color;
        }
        #endregion
        #region RouteEvents
        public static readonly RoutedEvent ColorChangedEvent;
        public event RoutedPropertyChangedEventHandler<Color> ColorChanged
        {
            add { AddHandler(ColorChangedEvent, value); }
            remove { RemoveHandler(ColorChangedEvent, value); }
        }
        #endregion
        #region Constructors
        static ColorPicker()
        {
            //初始化依赖属性
            ColorProperty = DependencyProperty.Register("Color", typeof(Color), typeof(ColorPicker),
                new FrameworkPropertyMetadata(Colors.Black, new PropertyChangedCallback(OnColorChanged)));
            RedProperty = DependencyProperty.Register("Red", typeof(byte), typeof(ColorPicker),
                new FrameworkPropertyMetadata(new PropertyChangedCallback(OnColorRGBChanged)));
            GreenProperty = DependencyProperty.Register("Green", typeof(byte), typeof(ColorPicker),
                new FrameworkPropertyMetadata(new PropertyChangedCallback(OnColorRGBChanged)));
            BlueProperty = DependencyProperty.Register("Blue", typeof(byte), typeof(ColorPicker),
                new FrameworkPropertyMetadata(new PropertyChangedCallback(OnColorRGBChanged)));

            //初始化路由事件
            ColorChangedEvent = EventManager.RegisterRoutedEvent("ColorChanged", RoutingStrategy.Bubble,
                typeof(RoutedPropertyChangedEventHandler<Color>), typeof(ColorPicker));
        }
        #endregion

    }
}
