using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualFramework.DataModels.ToolChain
{
    // DataModels/ToolChain/ToolChainConfig.cs
    // 定义工具链的配置结构，用于保存和加载工具链
    public class ToolChainConfig
    {
        public List<ToolNodeData> Nodes { get; set; }
        public List<ConnectionData> Connections { get; set; }
    }

    // DataModels/Tools/ToolNodeData.cs
    // 表示工具节点的数据模型
    public class ToolNodeData
    {
        public string ToolType { get; set; } // 工具类型（通过反射动态加载）
        public Dictionary<string, object> Parameters { get; set; } // 参数键值对
    }

    // DataModels/Tools/ConnectionData.cs
    // 表示连接的数据模型
    public class ConnectionData
    {
        public int FromNodeId { get; set; }
        public string FromTerminalName { get; set; }
        public int ToNodeId { get; set; }
        public string ToTerminalName { get; set; }
    }
}
