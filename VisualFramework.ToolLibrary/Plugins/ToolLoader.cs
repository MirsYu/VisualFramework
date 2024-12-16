using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using VisualFramework.Core.Interfaces;

namespace VisualFramework.ToolLibrary.Plugins
{
    //ToolLoader 负责加载工具 DLL，并创建工具实例。
    public static class ToolLoader
    {
        public static List<IVisualTool> LoadToolsFromAssembly(string assemblyPath)
        {
            var tools = new List<IVisualTool>();
            var assembly = Assembly.LoadFrom(assemblyPath);

            // 查找实现了 IVisualTool 接口的所有类
            foreach (var type in assembly.GetTypes())
            {
                if (typeof(IVisualTool).IsAssignableFrom(type) && !type.IsInterface && !type.IsAbstract)
                {
                    IVisualTool tool = (IVisualTool)Activator.CreateInstance(type);
                    tools.Add(tool);
                }
            }

            return tools;
        }
    }
}
