using System;
using System.Collections.Generic;
using System.Text;

namespace MTMConnect.SDK.Models
{
    /// <summary>
    /// Attribute will help to determing the api endpoint method. 
    /// </summary>
    public class ServiceName : Attribute
    {
        public string Name { get; set; }
        public ServiceName(string name)
        {
            this.Name = name;
        }

    }
}
