using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualFramework.DataModels.Tools
{
    public class ToolNodeData
    {
        public int Id { get; set; }
        public string ToolName { get; set; }
        public List<TerminalData> Inputs { get; set; }
        public List<TerminalData> Outputs { get; set; }

        public ToolNodeData()
        {
            Inputs = new List<TerminalData>();
            Outputs = new List<TerminalData>();
        }
    }

    // 端口数据模型，包含名称和类型
    public class TerminalData
    {
        public string Name { get; set; }
        public string Type { get; set; }
    }
}
