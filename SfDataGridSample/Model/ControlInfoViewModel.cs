using System.Collections.ObjectModel;

namespace SfDataGridSample
{
    public class ControlInfoViewModel
    {
        private ObservableCollection<ControlInfo> controlInfo;
        public ObservableCollection<ControlInfo> ControlInfoCollection
        {
            get { return controlInfo; }
            set { this.controlInfo = value; }
        }

        public ControlInfoViewModel()
        {
            controlInfo = new ObservableCollection<ControlInfo>();
            this.GenerateOrders();
        }
        

        public void GenerateOrders()
        {
            controlInfo.Add(new ControlInfo("DataGrid", "Xamarin.Forms", "https://help.syncfusion.com/xamarin/datagrid/getting-started"));
            controlInfo.Add(new ControlInfo("DataGrid", "MAUI", "https://help.syncfusion.com/maui/datagrid/getting-started"));            
            controlInfo.Add(new ControlInfo("DataGrid", "WPF", "https://help.syncfusion.com/wpf/datagrid/getting-started"));            
            controlInfo.Add(new ControlInfo("DataGrid", "Flutter", "https://help.syncfusion.com/flutter/datagrid/getting-started"));            
        }
    }

}

