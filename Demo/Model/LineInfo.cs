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
        public string ProgressPercent { get; set; }
        #endregion
        #region Constructors
        public LineInfo(string lineNum, string state, double progress)
        {
            this.LineNum = lineNum;
            this.State = state;
            this.Progress = progress;
            this.ProgressPercent = this.Progress.ToString("P0");
        }
        #endregion
    }
}
