using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratorLogic
{
    public class clsColumn
    {
        public string ColumnName { get; set; }
        public string ColumnDataType { get; set; }
        public bool IsNull { get; set; }
        public bool IsPK { get; set; }

        public clsColumn(string ColumnName,string ColumnDataType,bool IsNull,bool IsPK)
        {
            this.ColumnName = ColumnName;
            this.ColumnDataType = ColumnDataType;
            this.IsNull = IsNull;
            this.IsPK = IsPK;
        }
    }
}
