using ClickUp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickUp.Responses
{
    public class FolderResponse
    {
        [JsonProperty("folders")]
        public List<Folder> Folders { get; set; }

        public FolderResponse() { Folders = new List<Folder>(); }
    }
}
