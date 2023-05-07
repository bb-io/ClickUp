using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickUp.InputParameters
{
    public class Attachment
    {
        public string TaskId { get; set; }
        public byte[] File { get; set; }
        public string FileName { get; set; }
    }
}
