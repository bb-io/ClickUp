using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickUp.InputParameters
{
    public class NewTask
    {
        public string ListId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
