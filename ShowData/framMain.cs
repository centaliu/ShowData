using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
//====================================================================================================
//this application tends to gather information of platform list, and detail info of specific project
//history:
//  2017.09.07: initial version (1.0.0.1)
//  2017.09.08: split projects into different groups based on their initial letter (1.0.0.2)
//====================================================================================================

namespace ShowData
{
    public partial class framMain : Form
    {

        public framMain()
        {
            InitializeComponent();
        }

        //a struct to keep basic project info
        public class ProjInfo
        {
            public string PName;
            public string link;
            public string RSTDate;
            public string LOB;
        }

        private WebBrowser web = new WebBrowser();//for accessing data via web browsing object
        private string PLURL = @"http://agility.aus.amer.dell.com/platforms/";//URL of the platform list
        private List<ProjInfo> proj = new List<ProjInfo>();//for storing main information of projects
        private List<string> PNames = new List<string>();//just a temp list for storing project name for avoiding duplicated insertion

        private void btnLoad_Click(object sender, EventArgs e)
        {
            btnLoad.Enabled = false;
            Application.DoEvents();
            web.Navigate(PLURL);
        }

        //event while form is loading
        private void framMain_Load(object sender, EventArgs e)
        {
            web.DocumentCompleted += Web_DocumentCompleted;
        }

        private void Web_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            HtmlDocument doc = web.Document;
            string lastLOB = "";
            string dateStr = "";
            //traverse whole HTML document to get required project information
            foreach (HtmlElement ele in doc.All)
            {
                //check if that's a LOB name
                if ((ele.TagName.ToLower() == "tr") && (ele.GetAttribute("ClassName") == "header blue-header")) lastLOB = ele.InnerText;
                //get the project
                if ((ele.TagName.ToLower() == "tr") && (ele.GetAttribute("ClassName") == "platform-row")) {
                    if (!PNames.Contains(ele.Children[1].InnerText)) {
                        ProjInfo item = new ProjInfo();
                        item.PName = ele.Children[1].InnerText;
                        item.link = ele.Children[1].Children[0].GetAttribute("href");
                        item.LOB = lastLOB;
                        if (ele.Children[6].InnerText != null) {
                            dateStr = ele.Children[6].InnerText.Replace(" ", "");
                            if (dateStr == "") item.RSTDate = ""; else item.RSTDate = dateConvt(dateStr);
                        } else item.RSTDate = "";
                        proj.Add(item);
                        PNames.Add(ele.Children[1].InnerText);
                        continue;
                    }
                }
            }
            //divide projects into groups based on their initial letters
            int totCnt = 0;
            foreach (ProjInfo p in proj) {
                if (p.RSTDate == "") continue;
                if (Convert.ToInt32(p.RSTDate) <= 20160000) continue;
                if (p.LOB == "ENTERPRISE SERVERS") continue;
                Label lblNew = new Label();
                lblNew.Text = p.PName;
                Debug.WriteLine(p.PName);
                string initLetter = p.PName.ToUpper().Substring(0, 1);
                TabControl.TabPageCollection pages = tabCtrl.TabPages;
                foreach (TabPage page in pages) {
                    if (page.Name.IndexOf(initLetter) > 0) {
                        lblNew.Tag = initLetter;
                        lblNew.ForeColor = Color.Blue;
                        lblNew.Left = 10 + ((page.Name.IndexOf(initLetter)-3) * 240);
                        int cnt = 0;
                        foreach (Control ctrl in page.Controls) {
                            Label x = (Label)(ctrl);
                            if (x.Tag.ToString() == initLetter) cnt++;
                        }
                        lblNew.Top = 10 + (cnt * 25);
                        page.Controls.Add(lblNew);
                        break;
                    }
                }
                totCnt++;
                if (totCnt==215) break;
            }
            btnLoad.Enabled = true;
        }

        //converting hard-to-query date (ex: Aug. 01, 2017) string to easier-compare format (ex: 20180301)
        private string dateConvt(string income)
        {
            string ret = "YYYYMMDD";
            string MM = "";
            string[,] monMapping = { {"jan", "01" }, {"feb", "02"}, { "mar", "03" }, { "apr", "04" }, { "may", "05" }, { "jun", "06" }, { "jul", "07" }, { "aug", "08" }, { "sep", "09" }, { "oct", "10" }, { "nov", "11" }, { "dec", "12" } };
            income = income.ToLower().Replace(" ", "");
            string[] arrDate = income.Split(new char[] { ',', '.' });
            ret = ret.Replace("YYYY", arrDate[2]);
            ret = ret.Replace("DD", arrDate[1]);
            for (int i=0; i<monMapping.Length; i++) {
                if (arrDate[0] == monMapping[i, 0]) { MM = monMapping[i, 1]; break; }
            }
            ret = ret.Replace("MM", MM);
            return ret;
        }
    }
}



