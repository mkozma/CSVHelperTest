using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVHelper
{
    class Program
    {
        public static IEnumerable<Competition> competition { get; set; }
        public static IEnumerable<Course> courses { get; set; }

        private static string FILENAME_COMPETITION = "a";
        private static string FILENAME_COURSE = "B";
        private static string FILENAME_PREFIX = @"C:\Users\Martin Kozma\OneDrive\Documents\";
        private static string FILENAME_SUFFIX = @".csv";

        static void Main(string[] args)
        {
            competition = new Competition().ReadData(
                string.Format("{0}{1}{2}",FILENAME_PREFIX, FILENAME_COMPETITION, FILENAME_SUFFIX), 
                new Competition());
            courses = new Course().ReadData(
                string.Format("{0}{1}{2}", FILENAME_PREFIX, FILENAME_COURSE, FILENAME_SUFFIX),
                new Course());

        }
    }
}
