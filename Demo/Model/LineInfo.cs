using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo.Model
{
    public class LineInfo
    {
        #region Properties
        /// <summary>
        /// 流水线编号
        /// </summary>
        public string LineNum { get; set; }
        /// <summary>
        /// 当前状态
        /// </summary>
        public string State { get; set; }
        /// <summary>
        /// 进度
        /// </summary>
        public double Progress { get; set; }
        #endregion
        #region Constructors
        public LineInfo(string lineNum, string state, double progress)
        {
            this.LineNum = lineNum;
            this.State = state;
            this.Progress = progress;
        }
        #endregion
    }
    public enum LineState
    {
        停机,
        正常运转,
        空转,
        设备空缺
    }
}
