using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace renameform.RenameOption
{
    public class OptionBool
    {
        public OptionBool()
        {
        }

        public bool AddFront { get; set; } = true;
        public bool AddBack { get; set; } = false;
        public bool AddInteger { get; set; } = false;
        public bool Replace { get; set; } = false;
        public bool AllSame { get; set; } = false;

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("AddFront:" + AddFront)
                .Append(", AddBack:" + AddBack)
                .Append(", AddInteger:" + AddInteger)
                .Append(", Replace:" + Replace)
                .Append(", AllSame:" + AllSame);
            return sb.ToString();
        }


    }
}
