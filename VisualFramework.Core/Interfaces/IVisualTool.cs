using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualFramework.Core.Models;

namespace VisualFramework.Core.Interfaces
{
    // Core/Interfaces/IVisualTool.cs
    // 定义视觉工具的通用接口，每个工具实现此接口
    // IVisualTool 接口用于定义所有工具的基本行为。每个工具（如图像处理、模板匹配等）都需要实现此接口。
    public interface IVisualTool
    {
        string Name { get; } // 工具名称
        List<InputTerminal> Inputs { get; } // 输入端口列表
        List<OutputTerminal> Outputs { get; } // 输出端口列表

        void Initialize(); // 初始化工具
        void Execute(); // 执行工具逻辑
        void Dispose(); // 释放资源
    }

}
