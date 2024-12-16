using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualFramework.DataModels.Tools
{
    // 基础工具参数类，所有工具的参数类都可以继承此类
    public class ToolParams
    {
        // 基础参数：参数名称和类型
        public string Name { get; set; }
        public string Type { get; set; }
    }
}
