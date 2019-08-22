using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3
{
    public class SampleGroupVm
    {
        public string Name { get; set; }
        public IEnumerable<SampleVm> Items { get; set; }
    }
}
