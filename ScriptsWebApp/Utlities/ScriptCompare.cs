using ScriptsWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScriptsWebApp.Utlities
{
    public static class ScriptCompare
    {

        public static ChangeViewModel GetChangeViewModel(IEnumerable<Script> script1, IEnumerable<Script> script2)
        {

            var model = new ChangeViewModel();

            var scriptChanges = new List<ScriptChange>();

            foreach (var script in script1)
            {
                var s1 = script;
                var s2 =script2.SingleOrDefault(s => s.Field == s1.Field);


                var script1IsNullAndScript2IsNotNull = s1 == null && s2 != null;
                var script2IsNullAndScript1IsNotNull = s2 == null && s1 != null;

                if (script1IsNullAndScript2IsNotNull)
                {
                    s1 = new Script
                        {
                            Notes = "FIELD DOESN'T EXIST IN THIS SCRIPT",
                            Text = String.Empty
                        };
                }
                else if (script2IsNullAndScript1IsNotNull)
                {
                    s2 = new Script
                        {
                            Notes = "FIELD DOESN'T EXIST IN THIS SCRIPT",
                            Text = String.Empty
                        };
                }

                var s1Text  = (s1.Text ?? "") .Replace("\n","").Replace(" ","").Replace("\r","");
                var s1Notes = (s1.Notes ?? "").Replace("\n", "").Replace(" ", "").Replace("\r", "");
                var s2Text  = (s2.Text ?? "") .Replace("\n","").Replace(" ","").Replace("\r","");
                var s2Notes = (s2.Notes ?? "").Replace("\n", "").Replace(" ", "").Replace("\r", "");

                var fieldsBothExistAndAreUnequal = !s1Text.Equals(s2Text) || ((s1Notes == null && s2Notes != null) || (s1Notes != null && s2Notes == null) || (s1Notes != null && s2Notes != null && !s1Notes.Equals(s2Notes)));

                if (fieldsBothExistAndAreUnequal)
                {
                    scriptChanges.Add(new ScriptChange
                    {
                        //First script
                        ClientName1 = s1.ClientName,
                        Field1 = s1.Field,
                        Text1 = s1.Text,
                        Notes1 = s1.Notes,
                        Sequence1 = s1.Sequence,
                        //Second script
                        ClientName2 = s2.ClientName,
                        Field2 = s2.Field,
                        Text2 = s2.Text,
                        Notes2 = s2.Notes,
                        Sequence2 = s2.Sequence
                    });
                }

                model.ScriptChanges = scriptChanges.OrderBy(s => s.Sequence1).ToList();


            }


            return (model);
        }

    }
}