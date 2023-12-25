using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScriptsWebApp.Models
{
    public class ChangeViewModel
    {
        public List<ScriptChange> ScriptChanges { get; set; }
    }
    
    public class ScriptChange
    {
        //Old Clientname
        public string ClientName1 { get; set; }
        public string Field1 { get; set; }
        public string Text1 { get; set; }
        public string Notes1 { get; set; }
        public Nullable<int> Sequence1 { get; set; }

        //New clientname
        public string ClientName2 { get; set; }
        public string Field2 { get; set; }
        public string Text2 { get; set; }
        public string Notes2 { get; set; }
        public Nullable<int> Sequence2 { get; set; }
    }

}

