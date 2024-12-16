using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualFramework.Core.Execution;
using VisualFramework.Core.Models;

namespace VisualFramework.Core.Interfaces
{
    // Core/Execution/ToolChainExecutor.cs
    // 管理工具链的执行逻辑
    // IToolChainExecutor 接口定义了工具链的执行接口。
    public class IToolChainExecutor
    {
        private List<ToolNode> _nodes;

        public IToolChainExecutor(List<ToolNode> nodes)
        {
            _nodes = nodes;
        }

        public void Execute()
        {
            // 使用拓扑排序确定执行顺序
            var sortedNodes = DependencyResolver.TopologicalSort(_nodes);
            foreach (var node in sortedNodes)
            {
                node.Tool.Execute();
            }
        }
    }
}
