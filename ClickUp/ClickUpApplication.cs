using Blackbird.Applications.Sdk.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickUp
{
    public class ClickUpApplication : IApplication
    {
        private string _name;

        public ClickUpApplication()
        {
            _name = "ClickUp";
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public T GetInstance<T>()
        {
            throw new NotImplementedException();
        }
    }
}
