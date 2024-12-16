using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Shapes;
using VisualFramework.Core.Interfaces;
using VisualFramework.Core.Models;

namespace VisualFramework.ToolLibrary.Tools
{
    // ToolLibrary/Tools/LineFitTool.cs
    // 示例工具：拟合直线工具
    public class LineFitTool : IVisualTool
    {
        public string Name => "LineFitTool";
        public List<InputTerminal> Inputs { get; private set; }
        public List<OutputTerminal> Outputs { get; private set; }

        List<InputTerminal> IVisualTool.Inputs => throw new NotImplementedException();

        List<OutputTerminal> IVisualTool.Outputs => throw new NotImplementedException();

        public LineFitTool()
        {
            Inputs = new List<InputTerminal>
        {
            new InputTerminal { Name = "InputPoints", DataType = typeof(List<Point>) }
        };

            Outputs = new List<OutputTerminal>
        {
            new OutputTerminal { Name = "FittedLine", DataType = typeof(Line) }
        };
        }

        public void Initialize()
        {
            throw new NotImplementedException();
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
