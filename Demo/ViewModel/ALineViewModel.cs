using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GalaSoft.MvvmLight;
using Demo.Model;

namespace Demo.ViewModel
{
    public class ALineViewModel:ViewModelBase
    {
        #region Properties
        private LineInfo[] _lineInfos;

        public LineInfo[] LineInfos
        {
            get { return _lineInfos; }
            set { _lineInfos = value; RaisePropertyChanged(() => LineInfos); }
        }
        #endregion
        #region Constructors
        public ALineViewModel()
        {
            LineInfos = new LineInfo[]
            {
                new LineInfo("A01","停机",0.25),
                new LineInfo("A02","正常运转",0.50),
                new LineInfo("A03","空转",0.56),
                new LineInfo("A04","设备空缺",0.85),
                new LineInfo("A05","停机",0.25),
                new LineInfo("A06","正常运转",0.63),
                new LineInfo("A07","空转",0.21),
                new LineInfo("A08","设备空缺",0.89)
            };
        }

        #endregion

    }
}
