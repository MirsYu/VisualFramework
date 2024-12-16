using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualFramework.Core.Models
{
    // Core/Models/Terminal.cs
    // 表示工具的输入或输出端口
    // Terminal 代表工具节点的输入或输出端口。

    public abstract class Terminal
    {
        public string Name { get; set; } // 端口名称
        public Type DataType { get; set; } // 数据类型

        public object Value { get; set; }
    }

    public class InputTerminal : Terminal { }
    public class OutputTerminal : Terminal { }
}
