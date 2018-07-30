using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GalaSoft.MvvmLight;
using Demo.Model;

namespace Demo.ViewModel
{
    public class CLineViewModel:ViewModelBase
    {
        #region Properties

        private LineInfo[] _lineInfos;

        public LineInfo[] LineInfos
        {
            get { return _lineInfos; }
            set { _lineInfos = value;RaisePropertyChanged(() => LineInfos); }
        }


        #endregion
        #region Constructors
        public CLineViewModel()
        {
            LineInfos = new LineInfo[]
            {
                new LineInfo("C01","停机",0.25),
                new LineInfo("C02","正常运转",0.50),
                new LineInfo("C03","空转",0.56),
                new LineInfo("C04","设备空缺",0.85),
                new LineInfo("C05","停机",0.25),
                new LineInfo("C06","正常运转",0.63),
                new LineInfo("C07","空转",0.21),
                new LineInfo("C08","设备空缺",0.89)
            };
        }
        #endregion
    }
}
