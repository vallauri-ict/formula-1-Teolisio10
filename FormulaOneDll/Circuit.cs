using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaOneDll
{
    public class Circuit
    {
        private int id;
        private string name;
        private int length;
        private string recordLap;

        public Circuit(int id, string name, int length, string recordLap)
        {
            this.id = id;
            this.name = name;
            this.length = length;
            this.recordLap = recordLap;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Length { get => length; set => length = value; }
        public string RecordLap { get => recordLap; set => recordLap = value; }
    }
}
