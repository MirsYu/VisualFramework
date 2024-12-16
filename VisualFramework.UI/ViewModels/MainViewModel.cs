using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualFramework.UI.ViewModels
{
    public class MainViewModel 
    {
        public ObservableCollection<NodeViewModel> Nodes { get; set; }

        public MainViewModel()
        {
            Nodes = new ObservableCollection<NodeViewModel>();
        }
    }
}
