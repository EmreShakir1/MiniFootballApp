using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniFootballApp.Infrastucture.Data.EntityModels
{
    public class Location
    {
        public int Id { get; set; }

        public string Address { get; set; } = string.Empty;

        public string Country { get; set; } = string.Empty;
    }
}
