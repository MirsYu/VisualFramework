using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualFramework.Core.Models;

namespace VisualFramework.UI.ViewModels
{
    // UI/ViewModels/NodeViewModel.cs
    // 节点的 ViewModel，桥接数据和 UI
    public class NodeViewModel
    {
        public ToolNode Node { get; set; }

        public NodeViewModel(ToolNode node)
        {
            Node = node;
        }
    }
}
