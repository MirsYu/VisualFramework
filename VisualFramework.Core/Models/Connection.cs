using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualFramework.Core.Models
{
    // Core/Models/Connection.cs
    // 表示工具链中的连接，连接两个节点的终端
    // Connection 用于表示工具节点之间的连接。连接会连接工具的输入端口和输出端口。

    public class Connection
    {
        public ToolNode FromNode { get; set; } // 源节点
        public OutputTerminal FromTerminal { get; set; } // 源节点输出终端
        public ToolNode ToNode { get; set; } // 目标节点
        public InputTerminal ToTerminal { get; set; } // 目标节点输入终端
    }
}
