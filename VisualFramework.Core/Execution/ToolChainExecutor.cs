using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualFramework.Core.Interfaces;
using VisualFramework.Core.Models;

namespace VisualFramework.Core.Execution
{
    // 执行引擎负责根据工具链执行工具节点。

    public class ToolChainExecutor : IToolChainExecutor

    {
        public ToolChainExecutor(List<ToolNode> nodes) : base(nodes)
        {
        }
    }
}
