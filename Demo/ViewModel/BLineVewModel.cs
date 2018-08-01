using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GalaSoft.MvvmLight;
using Demo.Model;

namespace Demo.ViewModel
{
    public class BLineVewModel
    {
        #region Properties
        private LineInfo[] _lineInfos;

        public LineInfo[] LineInfos
        {
            get { return _lineInfos; }
            set { _lineInfos = value; }
        }

        #endregion
        #region Constructors
        public BLineVewModel()
        {
            LineInfos = new LineInfo[]
            {
                new LineInfo("B01","停机",0.25),
                new LineInfo("B02","正常运转",0.50),
                new LineInfo("B03","空转",0.56),
                new LineInfo("B04","设备空缺",0.85),
                new LineInfo("B05","停机",0.25),
                new LineInfo("B06","正常运转",0.63),
                new LineInfo("B07","空转",0.21),
                new LineInfo("B08","设备空缺",0.89)
            };
        }
        #endregion
    }
}
