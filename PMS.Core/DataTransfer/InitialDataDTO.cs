using PMS.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PMS.Core.DataTransfer
{
    public class InitialDataDTO
    {
        public List<Filter> Filters {get; set;}
        public List<Filter> Categories { get; set; }

    }
}
