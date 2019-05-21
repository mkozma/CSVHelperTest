using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using System.Collections.Generic;

namespace CSVHelper
{
    public class CSVHelper<T>
    {
        public IEnumerable<T> ReadData(string filename, T t)
        {
            using (var reader = new StreamReader(filename))
            using (var csv = new CsvReader(reader))
            {
                return csv.GetRecords<T>().ToList();
            }
        }
    }
}
