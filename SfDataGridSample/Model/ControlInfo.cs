using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfDataGridSample
{
    public class ControlInfo
    {
        private string control;
        private string platform;
        private string ugLink;

        public string Control
        {
            get { return control; }
            set { this.control = value; }
        }

        public string Platform
        {
            get { return platform; }
            set { this.platform = value; }
        }

        public string UGLink
        {
            get { return ugLink; }
            set { this.ugLink = value; }
        }

        public ControlInfo(string control, string platform, string ugLink)
        {
            this.Control = control;
            this.Platform = platform;
            this.UGLink = ugLink;
        }
    }
}
