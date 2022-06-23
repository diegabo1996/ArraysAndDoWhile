using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.Models
{
    public class Table
    {
        public string Brand { get; set; }
        public string Color { get; set; }
        public string Material { get; set; }
        public byte NumberSupports { get; set; }
        public Size Size { get; set; }

    }
    public enum Size
    {
        Small,
        Medium,
        Large
    }
}
