using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Data;
using System.Windows.Media;

namespace Demo.Converter
{
    public class StateToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch (value.ToString().Trim())
            {
                case "正常运转":
                    return new SolidColorBrush(Colors.ForestGreen);
                case "停机":
                    return new SolidColorBrush(Color.FromArgb(0xff, 0xa2, 0x23, 0xa2));
                case "空转":
                    return new SolidColorBrush(Colors.Orange);
                case "设备空缺":
                    return new SolidColorBrush(Colors.CornflowerBlue);
                default:
                    return new SolidColorBrush(Colors.White);
                    //throw new Exception("设备状态错误导致颜色转换失败");
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
