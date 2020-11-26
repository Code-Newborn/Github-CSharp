using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTracker
{
    public class LEventArgs:EventArgs//事件
    {
        public LEventArgs(object value)//事件构造函数
        {
            Value = value;
        }
        public object Value { get; set; }

        
    }
}
