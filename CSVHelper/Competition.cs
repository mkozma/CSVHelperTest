using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace CSVHelper
{
    public class Competition: CSVHelper<Competition>
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Length { get; set; }
    }
}
