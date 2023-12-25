using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScriptsWebApp.ViewModel
{
    public class PrinterViewModel
    {
        public string ClientName { get; set; }
        public IQueryable<ScriptsWebApp.Models.Script> Scripts { get; set; }
    }
}