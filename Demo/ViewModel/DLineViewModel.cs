using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GalaSoft.MvvmLight;
using Demo.Model;

namespace Demo.ViewModel
{
    public class DLineViewModel:ViewModelBase
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
        public DLineViewModel()
        {
            LineInfos = new LineInfo[]
            {
                new LineInfo("D01","停机",0.25),
                new LineInfo("D02","正常运行",0.50),
                new LineInfo("D03","空转",0.56),
                new LineInfo("D04","设备空缺",0.85),
                new LineInfo("D05","停机",0.25),
                new LineInfo("D06","正常运转",0.63),
                new LineInfo("D07","空转",0.21),
                new LineInfo("D08","设备空缺",0.89)
            };
        }
        #endregion
    }
}
