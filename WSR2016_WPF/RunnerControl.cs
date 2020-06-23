using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSR2016_WPF
{
    public class RunnerControl
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Status { get; set; }
        public System.Windows.Controls.Button Edit { get; set; }
        public string EventTypeMar { get; set; }

        public string GenderCSV { get; set; }
        public string CountryCSV { get; set; }
        public DateTime DateOfBith { get; set; }
        public string NuborCSV { get; set; }
        public decimal SponsorTarget { get; set; }
        public string CharityName { get; set; }
        public string Pas { get; set; }
    }
}
