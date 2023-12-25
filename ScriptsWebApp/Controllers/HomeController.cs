using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ScriptsWebApp.Models;
using System.Data.Objects.SqlClient;
using ScriptsWebApp.Utlities;
using ScriptsWebApp.ViewModel;

namespace ScriptsWebApp.Controllers
{
    public class HomeController : Controller
    {
        private MothershipEntities _db;
        private List<ScriptSequence> _scriptSequences;
        public HomeController()

        {
            _db = new MothershipEntities();
                _scriptSequences = new List<ScriptSequence> 
                { 
                  new ScriptSequence  {Sequence=100, Field="Opening1"},
                  new ScriptSequence  {Sequence=101, Field="Opening2"},
                  new ScriptSequence  {Sequence=102, Field="Opening3"},
                  new ScriptSequence  {Sequence=103, Field="Opening4"},
                  new ScriptSequence  {Sequence=104, Field="Opening5"},
                  new ScriptSequence  {Sequence=105, Field="Opening6"},
                  new ScriptSequence  {Sequence=106, Field="Opening7"},
                  new ScriptSequence  {Sequence=107, Field="Opening8"},
                  new ScriptSequence  {Sequence=108, Field="Opening9"},
                  new ScriptSequence  {Sequence=109, Field="Opening10"},
                  new ScriptSequence  {Sequence=110, Field="Opening11"},
                  new ScriptSequence  {Sequence=111, Field="Opening12"},
                  new ScriptSequence  {Sequence=112, Field="Opening13"},
                  new ScriptSequence  {Sequence=113, Field="Opening14"},
                  new ScriptSequence  {Sequence=114, Field="Opening15"},
                  new ScriptSequence  {Sequence=115, Field="Opening16"},
                  new ScriptSequence  {Sequence=116, Field="Opening17"},
                  new ScriptSequence  {Sequence=117, Field="Opening18"},
                  new ScriptSequence  {Sequence=118, Field="Opening19"},
                  new ScriptSequence  {Sequence=119, Field="Opening20"},
                  new ScriptSequence  {Sequence=120, Field="Opening21"},
                  new ScriptSequence  {Sequence=121, Field="Opening22"},
                  new ScriptSequence  {Sequence=122, Field="Opening23"},
                  new ScriptSequence  {Sequence=123, Field="Opening24"},
                  new ScriptSequence  {Sequence=124, Field="Opening25"},
                  new ScriptSequence  {Sequence=125, Field="Opening26"},
                  new ScriptSequence  {Sequence=126, Field="Opening27"},
                  new ScriptSequence  {Sequence=127, Field="Opening28"},
                  new ScriptSequence  {Sequence=128, Field="Opening29"},
                  new ScriptSequence  {Sequence=129, Field="Opening30"},
                  new ScriptSequence  {Sequence=140, Field="Ask1"},
                  new ScriptSequence  {Sequence=141, Field="Ask2"},
                  new ScriptSequence  {Sequence=142, Field="Ask3"},
                  new ScriptSequence  {Sequence=143, Field="Ask4"},
                  new ScriptSequence  {Sequence=144, Field="Ask5"},
                  new ScriptSequence  {Sequence=145, Field="Ask6"},
                  new ScriptSequence  {Sequence=146, Field="Ask7"},
                  new ScriptSequence  {Sequence=147, Field="Ask8"},
                  new ScriptSequence  {Sequence=148, Field="Ask9"},
                  new ScriptSequence  {Sequence=149, Field="Ask10"},
                  new ScriptSequence  {Sequence=150, Field="Ask11"},
                  new ScriptSequence  {Sequence=151, Field="Ask12"},
                  new ScriptSequence  {Sequence=152, Field="Ask13"},
                  new ScriptSequence  {Sequence=153, Field="Ask14"},
                  new ScriptSequence  {Sequence=154, Field="Ask15"},
                  new ScriptSequence  {Sequence=155, Field="Ask16"},
                  new ScriptSequence  {Sequence=156, Field="Ask17"},
                  new ScriptSequence  {Sequence=157, Field="Ask18"},
                  new ScriptSequence  {Sequence=158, Field="Ask19"},
                  new ScriptSequence  {Sequence=159, Field="Ask20"},
                  new ScriptSequence  {Sequence=160, Field="Ask21"},
                  new ScriptSequence  {Sequence=161, Field="Ask22"},
                  new ScriptSequence  {Sequence=162, Field="Ask23"},
                  new ScriptSequence  {Sequence=163, Field="Ask24"},
                  new ScriptSequence  {Sequence=164, Field="Ask25"},
                  new ScriptSequence  {Sequence=165, Field="Ask26"},
                  new ScriptSequence  {Sequence=166, Field="Ask27"},
                  new ScriptSequence  {Sequence=167, Field="Ask28"},
                  new ScriptSequence  {Sequence=168, Field="Ask29"},
                  new ScriptSequence  {Sequence=169, Field="Ask30"},
                  new ScriptSequence  {Sequence=180, Field="CcAsk1"},
                  new ScriptSequence  {Sequence=181, Field="CcAsk2"},
                  new ScriptSequence  {Sequence=182, Field="CcAsk3"},
                  new ScriptSequence  {Sequence=183, Field="CcAsk4"},
                  new ScriptSequence  {Sequence=184, Field="CcAsk5"},
                  new ScriptSequence  {Sequence=185, Field="PlPro1"},
                  new ScriptSequence  {Sequence=186, Field="PlPro2"},
                  new ScriptSequence  {Sequence=187, Field="PlPro3"},
                  new ScriptSequence  {Sequence=188, Field="PlPro4"},
                  new ScriptSequence  {Sequence=189, Field="PlPro5"},
                  new ScriptSequence  {Sequence=190, Field="PlPro6"},
                  new ScriptSequence  {Sequence=191, Field="PlPro7"},
                  new ScriptSequence  {Sequence=192, Field="PlPro8"},
                  new ScriptSequence  {Sequence=193, Field="PlPro9"},
                  new ScriptSequence  {Sequence=194, Field="PlPro10"},
                  new ScriptSequence  {Sequence=200, Field="WcPro1"},
                  new ScriptSequence  {Sequence=201, Field="WcPro2"},
                  new ScriptSequence  {Sequence=202, Field="WcPro3"},
                  new ScriptSequence  {Sequence=203, Field="WcPro4"},
                  new ScriptSequence  {Sequence=205, Field="Rebuttal1"},
                  new ScriptSequence  {Sequence=206, Field="Rebuttal2"},
                  new ScriptSequence  {Sequence=207, Field="Rebuttal3"},
                  new ScriptSequence  {Sequence=208, Field="Rebuttal4"},
                  new ScriptSequence  {Sequence=209, Field="Rebuttal5"},
                  new ScriptSequence  {Sequence=210, Field="Rebuttal6"},
                  new ScriptSequence  {Sequence=211, Field="Rebuttal7"},
                  new ScriptSequence  {Sequence=212, Field="Rebuttal8"},
                  new ScriptSequence  {Sequence=213, Field="Rebuttal9"},
                  new ScriptSequence  {Sequence=214, Field="Rebuttal10"},
                  new ScriptSequence  {Sequence=215, Field="Rebuttal11"},
                  new ScriptSequence  {Sequence=216, Field="Rebuttal12"},
                  new ScriptSequence  {Sequence=217, Field="Rebuttal13"},
                  new ScriptSequence  {Sequence=218, Field="Rebuttal14"},
                  new ScriptSequence  {Sequence=219, Field="Rebuttal15"},
                  new ScriptSequence  {Sequence=220, Field="Rebuttal16"},
                  new ScriptSequence  {Sequence=221, Field="Rebuttal17"},
                  new ScriptSequence  {Sequence=222, Field="Rebuttal18"},
                  new ScriptSequence  {Sequence=223, Field="Rebuttal19"},
                  new ScriptSequence  {Sequence=224, Field="Rebuttal20"},
                  new ScriptSequence  {Sequence=235, Field="SendInfo1"},
                  new ScriptSequence  {Sequence=236, Field="SendInfo2"},
                  new ScriptSequence  {Sequence=237, Field="SendInfo3"},
                  new ScriptSequence  {Sequence=238, Field="Vm1"},
                  new ScriptSequence  {Sequence=239, Field="Vm2"},
                  new ScriptSequence  {Sequence=240, Field="Vm3"},
                  new ScriptSequence  {Sequence=241, Field="Vm4"},
                  new ScriptSequence  {Sequence=245, Field="MemInfo1"},
                  new ScriptSequence  {Sequence=246, Field="MemInfo2"},
                  new ScriptSequence  {Sequence=247, Field="MemInfo3"},
                  new ScriptSequence  {Sequence=248, Field="MemInfo4"},
                  new ScriptSequence  {Sequence=249, Field="MemInfo5"},
                  new ScriptSequence  {Sequence=250, Field="MemInfo6"},
                  new ScriptSequence  {Sequence=251, Field="MemInfo7"},
                  new ScriptSequence  {Sequence=252, Field="MemInfo8"},
                  new ScriptSequence  {Sequence=253, Field="MemInfo9"},
                  new ScriptSequence  {Sequence=254, Field="MemInfo10"},
                  new ScriptSequence  {Sequence=260, Field="MemberCard"},
                  new ScriptSequence  {Sequence=261, Field="ExtraInfo1"},
                  new ScriptSequence  {Sequence=262, Field="ExtraInfo2"},
                  new ScriptSequence  {Sequence=263, Field="ExtraInfo3"},
                  new ScriptSequence  {Sequence=264, Field="ExtraInfo4"},
                  new ScriptSequence  {Sequence=265, Field="ExtraInfo5"},
                  new ScriptSequence  {Sequence=266, Field="ExtraInfo6"},
                  new ScriptSequence  {Sequence=267, Field="ExtraInfo7"},
                  new ScriptSequence  {Sequence=268, Field="ExtraInfo8"},
                  new ScriptSequence  {Sequence=269, Field="ExtraInfo9"},
                  new ScriptSequence  {Sequence=270, Field="ExtraInfo10"},
                  new ScriptSequence  {Sequence=280, Field="Premiums1"},
                  new ScriptSequence  {Sequence=281, Field="Premiums2"},
                  new ScriptSequence  {Sequence=282, Field="Guide1"},
                  new ScriptSequence  {Sequence=283, Field="Guide2"},
                  new ScriptSequence  {Sequence=284, Field="OnAirDrive1"},
                  new ScriptSequence  {Sequence=285, Field="OnAirDrive2"},
                  new ScriptSequence  {Sequence=290, Field="Exhibits1"},
                  new ScriptSequence  {Sequence=291, Field="Exhibits2"},
                  new ScriptSequence  {Sequence=292, Field="Exhibits3"},
                  new ScriptSequence  {Sequence=293, Field="Exhibits4"},
                  new ScriptSequence  {Sequence=294, Field="Exhibits5"},
                  new ScriptSequence  {Sequence=295, Field="Exhibits6"},
                  new ScriptSequence  {Sequence=296, Field="Exhibits7"},
                  new ScriptSequence  {Sequence=297, Field="Exhibits8"},
                  new ScriptSequence  {Sequence=298, Field="Exhibits9"},
                  new ScriptSequence  {Sequence=299, Field="Exhibits10"},
                  new ScriptSequence  {Sequence=310, Field="ConfInfo1"},
                  new ScriptSequence  {Sequence=311, Field="ConfInfo2"},
                  new ScriptSequence  {Sequence=312, Field="ConfInfo3"},
                  new ScriptSequence  {Sequence=313, Field="ConfInfo4"},
                  new ScriptSequence  {Sequence=314, Field="Incentives"},
                  new ScriptSequence  {Sequence=315, Field="WebSite"},
                  new ScriptSequence  {Sequence=316, Field="ContInfo"},
                  new ScriptSequence  {Sequence=317, Field="Installments"},
                  new ScriptSequence  {Sequence=318, Field="CardInfo"},
                  new ScriptSequence  {Sequence=319, Field="ImportantNotes"},


                };
        }

        public ActionResult Index(string txtClientName, string txtOldClientName, string txtNewClientName)
        {

            if (Request.QueryString.AllKeys.Contains("btnSearch") && !String.IsNullOrWhiteSpace(txtClientName))
            {
                return RedirectToAction("SearchIndex", new { SearchString = txtClientName });
            }

            if (Request.QueryString.AllKeys.Contains("btnAddNewScript") && !String.IsNullOrWhiteSpace(txtClientName)) //If they are adding a new script
            {
                var scriptExists = _db.Scripts.Any(s => s.ClientName == txtClientName);
                if (!scriptExists)
                    CopyScript("TEMPLATE-DEFAULT", txtClientName);
            }
            else if (Request.QueryString.AllKeys.Contains("btnCopyScript")) //Copying a script
            {
                if (!_db.Scripts.Any(s => s.ClientName == txtOldClientName))
                {
                    ViewBag.CopyMessage = "Old clientname doesn't exist.";
                    return View();
                }
                if (_db.Scripts.Any(s => s.ClientName == txtNewClientName) && Request.QueryString["chkOverWrite"] != "on")
                {

                    ViewBag.CopyMessage = "New clientname already exists.";
                    return View();
                }

                CopyScript(txtOldClientName, txtNewClientName);
                txtClientName = txtNewClientName;
            }
            else if (Request.QueryString.AllKeys.Contains("btnCheckChange")) //if button check changes is clicked
            {
                return CheckChanges(txtOldClientName,txtNewClientName);
            }
            

            //Return back to form view if they didn't enter a clientname
            if (String.IsNullOrWhiteSpace(txtClientName))
                return View();

            return RedirectToAction("Script", new { txtClientname = txtClientName });
        }

        private void CopyScript(string oldClientname, string newClientname) //copying to a a script.
        {
                   
            var oldScripts = _db.Scripts.Where(s => s.ClientName == oldClientname).ToList();//getting old clientname
            var newScripts = _db.Scripts.Where(s => s.ClientName == newClientname).ToList();//getting new clientname
           



            foreach (var newScript in newScripts)
            {

                if (!oldScripts.Any(s => s.Field == newScript.Field))   //If the newScript field doesn't exist in the old script
                {
                    //DELETE the field
                    //_db.Scripts.Remove(newScript);

                    //UPDATE the field to empty
                    newScript.Text = String.Empty;
                    newScript.Notes = String.Empty;

                    _db.SaveChanges();
                }
            }

            foreach (var oldScript in oldScripts) //Loop through each script field under oldClientname and copy to newClientname
            {
                Script newScript;

                if (_db.Scripts.Any(s => s.ClientName == newClientname && s.Field == oldScript.Field))
                {
                    //UPDATE
                    newScript = _db.Scripts.SingleOrDefault(s => s.ClientName == newClientname && s.Field == oldScript.Field);
                    newScript.Field = oldScript.Field;
                    newScript.Text = oldScript.Text;
                    newScript.Notes = oldScript.Notes;
                    newScript.Sequence = oldScript.Sequence;
                }
                else
                {
                    //INSERT
                    newScript = new Script();
                    newScript.ClientName = newClientname;
                    newScript.Field = oldScript.Field;
                    newScript.Text = oldScript.Text;
                    newScript.Notes = oldScript.Notes;
                    newScript.Sequence = oldScript.Sequence;
                    _db.Scripts.Add(newScript);
                }

                _db.SaveChanges();
            }

        }

        public ActionResult Script(string txtClientname)//Displaying Script.
        {
            var model = _db.Scripts.Where(s => s.ClientName == txtClientname).OrderBy(s => s.Sequence);
            
            ViewBag.ScriptSequences = _scriptSequences;
           

            return View(model);
        }
        [HttpPost]
        public ActionResult Script()//Saving changes.
        {
            var txtClientname = Request.QueryString["txtClientname"];

            var fields = Request.Form.AllKeys;  //Getting field names from the posted form       
            
            foreach (var Text in fields)        //Loop through each field
            {
                Script script;

                if (Text.StartsWith("Text"))
                {
                    script = _db.Scripts.SingleOrDefault(s => s.ClientName == txtClientname && s.Field == Text.Substring("Text".Length)); //Get the script entity for that field
                    script.Text = Request.Form[Text]; //Assign the posted value from the form to the script entity
                }
                else
                {
                    script = _db.Scripts.SingleOrDefault(s => s.ClientName == txtClientname && s.Field == Text.Substring("Notes".Length)); //Get the script entity for that field
                    script.Notes = Request.Form[Text];  //Assign Notes
                }
            }

            _db.SaveChanges();

            var model = _db.Scripts.Where(s => s.ClientName == txtClientname);

            //return View();                  //loads Script .cshtml
            //return View("Contact");         //loads Contact.cshtml
            return RedirectToAction("Index"); //loads Script .cshtml and passes the model

            //return View("Contact",model);   //loads Contact.cshtml and passes the model

        }

        public ActionResult Printer(string clientname)//The printer freindly view.

        {
            if (string.IsNullOrWhiteSpace(clientname))//Is there a clientname?
            {
                 return RedirectToAction("Index");
            }
            else
            {
                var model = new PrinterViewModel
                    {
                        ClientName = clientname,
                        Scripts = _db.Scripts.Where(s => s.ClientName == clientname && !s.Field.Equals(s.Text)).OrderBy(s => s.Sequence)
                    };

                return View(model);
            }
        }

        public ActionResult SearchIndex(string SearchString)//Searching for a script.
        {
                     
            if (!String.IsNullOrWhiteSpace(SearchString)) //If search string is not empty
            {
                var clientname = _db.Scripts
                                    .Where(s => SqlFunctions.PatIndex(SearchString,s.ClientName) > 0)
                                    .Select(o => o.ClientName).Distinct();
                
                return View("SearchIndex", clientname);
            }
            
            return View();
        }

        public ActionResult NewField(string txtClientName, string ddlField, string txtTextNew, string txtNotesNew)//Adding a new field
        {
            if (string.IsNullOrWhiteSpace(ddlField)) //If ddl Field is not selected.
            {
                ViewBag.Message = "A short little description of this little application.";
                return RedirectToAction("Script", new { txtClientName = txtClientName });
            }

            else 
            { 
                var script = new Script();
                script.ClientName= txtClientName;
                script.Field = ddlField;
                script.Notes = txtNotesNew;
                script.Text = txtTextNew;
                script.Sequence = _scriptSequences.Where(ss => ss.Field == ddlField).SingleOrDefault().Sequence;

                _db.Scripts.Add(script);       

                _db.SaveChanges();

                return RedirectToAction("Script", new { txtClientName = txtClientName });
            }
            
        }

        public ActionResult CheckChanges(string oldClientname, string newClientname) //copying to a a script.
        {
            var oldScripts = _db.Scripts.Where(s => s.ClientName == oldClientname).ToList();//getting first clientname
            var newScripts = _db.Scripts.Where(s => s.ClientName == newClientname).ToList();//getting second clientname
            var model = ScriptCompare.GetChangeViewModel(oldScripts, newScripts);//passing data to script compare
            



            return View("Changes", model);
        }

        public ActionResult About()//About page.
            {
                ViewBag.Message = "A short little description of this little application.";

                return View();
            }

        public ActionResult Contact()//Contact page.
            {
                ViewBag.Message = "How to contact the developer.";

                return View();
            }
                
                
        //public ActionResult WordDoc(String clientname);  //This is the start of creating a word doc for th
        //{

        //    Application application = new Application();

        //    Application.Documents.Add();

        //    Document document = Application.Documents.Open("C:\\word.doc");

        //    Paragraph paragraph1 = document.Content.Paragraphs.Add();
        //    paragraph1.Range.Text = "paragraph1";
        //    paragraph1.Range.InsertParagraphAfter();

        //    Paragraph paragraph2 = document.Content.Paragraphs.Add();
        //    paragraph2.Range.Text = "paragraph2";
        //    paragraph2.Range.InsertParagraphAfter();

        //    document.Save();
        //    document.Close();

        //return View(model);
        //}
    }
}


