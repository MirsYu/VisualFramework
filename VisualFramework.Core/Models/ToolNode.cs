using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualFramework.Core.Interfaces;

namespace VisualFramework.Core.Models
{
    // Core/Models/ToolNode.cs
    // 表示工具链中的一个节点，封装工具与连接信息
    // ToolNode 代表工具链中的一个节点，它对应一个具体的工具（IVisualTool），包含输入端口和输出端口。

    public class ToolNode
    {
        public IVisualTool Tool { get; set; } // 绑定的工具实例
        public List<Connection> Connections { get; set; } // 与其他节点的连接
    }
}
