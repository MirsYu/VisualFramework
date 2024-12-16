using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualFramework.Core.Interfaces;
using VisualFramework.Core.Models;
using VisualFramework.ToolLibrary.Tools;

namespace VisualFramework.Runtime.Execution
{
    public class ToolExecutor
    {
        private readonly List<IVisualTool> _tools;

        public ToolExecutor()
        {
            _tools = new List<IVisualTool>();
        }

        // 初始化工具链
        public void InitializeToolChain(List<ToolNode> nodes)
        {
            foreach (var node in nodes)
            {
                IVisualTool tool = null; //CreateToolInstance(node.Tool.Name);
                if (tool != null)
                {
                    _tools.Add(tool);
                    Console.WriteLine($"Tool {node.Tool.Name} initialized.");
                }
            }
        }

        // 执行工具链
        public void ExecuteToolChain()
        {
            foreach (var tool in _tools)
            {
                try
                {
                    Console.WriteLine($"Executing tool: {tool.GetType().Name}");
                    tool.Execute();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error executing tool {tool.GetType().Name}: {ex.Message}");
                }
            }
        }

        // 销毁工具链
        public void DestroyToolChain()
        {
            foreach (var tool in _tools)
            {
                //tool.Destroy();
                Console.WriteLine($"Tool {tool.GetType().Name} destroyed.");
            }
        }

        // 根据工具名称创建工具实例
        private ToolNode CreateToolInstance(string toolName)
        {
            //switch (toolName)
            //{
            //    case "LineFitTool":
            //        return new LineFitTool();
            //    case "BlobDetectionTool":
            //        return new BlobDetectionTool();
            //    default:
            //        Console.WriteLine($"Tool {toolName} not found.");
            //        return null;
            //}
            return null;
        }
    }
}
