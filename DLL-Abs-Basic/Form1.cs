using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using Newtonsoft.Json;


namespace DLL_Abs_Basic
{
    public partial class Form1 : Form
    {
        #region JSON_HANDLERS

        #region DLLCLUB_BASIC

        public class DLLClubsClub
        {
            public string clubName { get; set; }
            public int siteId { get; set; }
            public string brand { get; set; }
            public string status { get; set; }
            public string timezone { get; set; }
            public string country { get; set; }
            public bool bookingEnabled { get; set; }
            public bool membersBookingEnabled { get; set; }
            public bool paidOneClickBookingEnabled { get; set; }
            public bool coursesAndClassesEnabled { get; set; }
            public string displayGroupTranslationKey { get; set; }
            public bool supportsBoditrax { get; set; }
            public bool sendNsLcPushNotifications { get; set; }
            public string defaultLanguage { get; set; }
            public string feedbackUrl { get; set; }

            public DLLInnerClubInfo InnerClubInfo { get; set; }

        }

        public class DLLClubsAccessPermission
        {
            public int homeSiteId { get; set; }
            public List<int> accessibleSiteIds { get; set; }
        }

        public class DLLClubs
        {
            public List<DLLClubsClub> clubs { get; set; }
            public List<DLLClubsAccessPermission> DLLClubsaccessPermissions { get; set; }
        }

        #endregion
        #region DLLCLUB_EXTENDED
        public class Mon
        {
            public string from { get; set; }
            public string to { get; set; }
        }

        public class Tue
        {
            public string from { get; set; }
            public string to { get; set; }
        }

        public class Wed
        {
            public string from { get; set; }
            public string to { get; set; }
        }

        public class Thu
        {
            public string from { get; set; }
            public string to { get; set; }
        }

        public class Fri
        {
            public string from { get; set; }
            public string to { get; set; }
        }

        public class Sat
        {
            public string from { get; set; }
            public string to { get; set; }
        }

        public class Sun
        {
            public string from { get; set; }
            public string to { get; set; }
        }

        public class WeeklyOpeningTimes
        {
            public List<Mon> mon { get; set; }
            public List<Tue> tue { get; set; }
            public List<Wed> wed { get; set; }
            public List<Thu> thu { get; set; }
            public List<Fri> fri { get; set; }
            public List<Sat> sat { get; set; }
            public List<Sun> sun { get; set; }
        }

        public class Mon2
        {
            public string from { get; set; }
            public string to { get; set; }
        }

        public class Tue2
        {
            public string from { get; set; }
            public string to { get; set; }
        }

        public class Wed2
        {
            public string from { get; set; }
            public string to { get; set; }
        }

        public class Thu2
        {
            public string from { get; set; }
            public string to { get; set; }
        }

        public class Fri2
        {
            public string from { get; set; }
            public string to { get; set; }
        }

        public class Sat2
        {
            public string from { get; set; }
            public string to { get; set; }
        }

        public class Sun2
        {
            public string from { get; set; }
            public string to { get; set; }
        }

        public class PeakTimes
        {
            public List<Mon2> mon { get; set; }
            public List<Tue2> tue { get; set; }
            public List<Wed2> wed { get; set; }
            public List<Thu2> thu { get; set; }
            public List<Fri2> fri { get; set; }
            public List<Sat2> sat { get; set; }
            public List<Sun2> sun { get; set; }
        }

        public class ClubOpeningTimes
        {
            public WeeklyOpeningTimes weeklyOpeningTimes { get; set; }
            public List<object> specialOpeningTimes { get; set; }
            public List<object> closures { get; set; }
            public PeakTimes peakTimes { get; set; }
        }

        public class Court
        {
            public int courtId { get; set; }
            public string courtName { get; set; }
            public string courtSurface { get; set; }
            public string courtSurfaceTranslationKey { get; set; }
            public string courtType { get; set; }
            public string courtTypeTranslationKey { get; set; }
            public int sportId { get; set; }

            public DLLClassEntries CourtClasses { get; set; }

        }

        public class DLLInnerClubInfo
        {
            public string clubName { get; set; }
            public ClubOpeningTimes clubOpeningTimes { get; set; }
            public int clubTypeId { get; set; }
            public string brand { get; set; }
            public List<Court> courts { get; set; }
            public int siteId { get; set; }
            public List<int> sportIdsAvailable { get; set; }
            public List<int> sportsPackageIdsAvailable { get; set; }
            public string memberFeedbackEmailAddress { get; set; }
            public string referralEmailAddress { get; set; }
            public string salesManagerEmailAddress { get; set; }
            public string fitnessManagerEmailAddress { get; set; }
            public string defaultLanguage { get; set; }
            public string telephone { get; set; }
            public string feedbackUrl { get; set; }
            public string country { get; set; }
        }


        #endregion
        #region DLLCLUB_STUDIO_CLASSES

        public class SessionsDetail
        {
            public int courseId { get; set; }
            public int courseInstanceId { get; set; }
            public int courseTemplateId { get; set; }
            public string date { get; set; }
            public string startTime { get; set; }
            public int duration { get; set; }
            public string name { get; set; }
            public string level { get; set; }
            public string levelTranslationKey { get; set; }
            public List<string> instructorNames { get; set; }
            public List<int> instructorProfileIds { get; set; }
            public string status { get; set; }
        }

        public class Video
        {
            public object videoId { get; set; }
            public object videoType { get; set; }
        }

        public class EnGb
        {
            public string title { get; set; }
            public string subtitle { get; set; }
            public string description { get; set; }
        }

        public class ItIt
        {
            public string title { get; set; }
            public string subtitle { get; set; }
            public string description { get; set; }
        }

        public class DeDe
        {
            public string title { get; set; }
            public string subtitle { get; set; }
            public string description { get; set; }
        }

        public class FrBe
        {
            public string title { get; set; }
            public string subtitle { get; set; }
            public string description { get; set; }
        }

        public class EsEs
        {
            public string title { get; set; }
            public string subtitle { get; set; }
            public string description { get; set; }
        }

        public class FrFr
        {
            public string title { get; set; }
            public string subtitle { get; set; }
            public string description { get; set; }
        }

        public class NlBe
        {
            public string title { get; set; }
            public string subtitle { get; set; }
            public string description { get; set; }
        }

        public class Ca
        {
            public string title { get; set; }
            public string subtitle { get; set; }
            public string description { get; set; }
        }

        public class DetailsByLanguages
        {
            public EnGb engb { get; set; }
        public ItIt itit { get; set; }
    public DeDe dede { get; set; }
public FrBe frbe { get; set; } 
        public EsEs eses { get; set; } 
        public FrFr frfr { get; set; } 
        public NlBe nlbe { get; set; } 
        public Ca ca { get; set; } 
    }

    public class HeroImageUrlByBrand
{
    public string harbour { get; set; }
    public string davidlloyd { get; set; }
public string germany { get; set; }
public string barcelona { get; set; }
public string netherlands { get; set; }
public string france { get; set; }
public string belgium { get; set; }
public string italy { get; set; }
public string ireland { get; set; } 
    }

    public class LogoImageUrlByBrand
{
    public string harbour { get; set; }
    public string davidlloyd { get; set; }
public string germany { get; set; }
public string barcelona { get; set; }
public string netherlands { get; set; }
public string france { get; set; }
public string belgium { get; set; }
public string italy { get; set; }
public string ireland { get; set; } 
    }

    public class Harbour
{
    public object videoId { get; set; }
    public object videoType { get; set; }
}

public class DavidLloyd
{
    public object videoId { get; set; }
    public object videoType { get; set; }
}

public class Barcelona
{
    public object videoId { get; set; }
    public object videoType { get; set; }
}

public class Germany
{
    public object videoId { get; set; }
    public object videoType { get; set; }
}

public class Netherlands
{
    public object videoId { get; set; }
    public object videoType { get; set; }
}

public class France
{
    public object videoId { get; set; }
    public object videoType { get; set; }
}

public class Belgium
{
    public object videoId { get; set; }
    public object videoType { get; set; }
}

public class Italy
{
    public object videoId { get; set; }
    public object videoType { get; set; }
}

public class Ireland
{
    public object videoId { get; set; }
    public object videoType { get; set; }
}

public class VideoByBrand
{
    public Harbour harbour { get; set; }
    public DavidLloyd davidlloyd { get; set; }
public Barcelona barcelona { get; set; }
public Germany germany { get; set; }
public Netherlands netherlands { get; set; }
public France france { get; set; }
public Belgium belgium { get; set; }
public Italy italy { get; set; }
public Ireland ireland { get; set; } 
    }

    public class Template
{
    public int templateId { get; set; }
    public string title { get; set; }
    public string subtitle { get; set; }
    public string description { get; set; }
    public string heroImageUrl { get; set; }
    public string logoImageUrl { get; set; }
    public Video video { get; set; }
    public DetailsByLanguages detailsByLanguages { get; set; }
    public HeroImageUrlByBrand heroImageUrlByBrand { get; set; }
    public LogoImageUrlByBrand logoImageUrlByBrand { get; set; }
    public VideoByBrand videoByBrand { get; set; }
}

public class DLLClassEntries
{
    public List<SessionsDetail> sessionsDetails { get; set; }
    public List<Template> templates { get; set; }
}

#endregion

#endregion
public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
     
            pbProc.Left = 0;
            pbProc.Top = 0;
            pbProc.Size = this.Size;
            pbProc.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            treeView1.Height = this.Height - 80;

            treeView1.Visible = false;

            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            this.BringToFront();
            this.Show();
            
                        try
                        {
                            Thread gtabs = new Thread(getAbs);
                            //gtabs.IsBackground = true;
                            gtabs.Start();
                        }catch(Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
              

         

            treeView1.Width = this.Width - 40;
            

            treeView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;

        }
        DLLClubs ClubInfo = new DLLClubs();
        private void getAbs()
        {
            treeView1.Invoke(new Action(() => treeView1.Enabled = false));
            treeView1.Invoke(new Action(() => pbProc.Visible = true));
            try
            {
                ClubInfo = new DLLClubs();

                
                string jsonstring = "";

                WebClient wc = new WebClient();


                jsonstring = wc.DownloadString("https://staff-back.davidlloyd.co.uk/clubs/");





                //MessageBox.Show(jsonstring.Length.ToString());





                ClubInfo = JsonConvert.DeserializeObject<DLLClubs>(jsonstring);


                // MessageBox.Show(ClubInfo.clubs.Count.ToString());
                treeView1.Invoke(new Action(() => treeView1.Nodes.Add("David Lloyd Estate")));



                List<DLLClubsClub> nclubs = new List<DLLClubsClub>();


                nclubs = ClubInfo.clubs;

                nclubs.Sort((x, y) => x.clubName.CompareTo(y.clubName));

                int index = 0;
                foreach (DLLClubsClub c in nclubs)
                {
                    this.Invoke(new Action(() => this.Text = string.Format("David Lloyd ABS - Processing {0} / {1}",index,nclubs.Count)));
                    jsonstring = wc.DownloadString("https://staff-back.davidlloyd.co.uk/clubs/" + c.siteId + "/");
                    c.InnerClubInfo = JsonConvert.DeserializeObject<DLLInnerClubInfo>(jsonstring);
                    int imgindex = 0;

                    if(c.brand.ToUpper() == "HARBOUR")
                    {
                        imgindex = 1;

                    }
                    else
                    {
                        imgindex = 0;
                    }
                    if (devdata == true)
                    {
                        treeView1.Invoke(new Action(() => treeView1.Nodes[0].Nodes.Add(c.clubName,c.clubName + " - Brand: " + c.brand + " - Club ID:" + c.siteId,imgindex)));
                    }
                    else
                    {
                        treeView1.Invoke(new Action(() => treeView1.Nodes[0].Nodes.Add(c.clubName,c.clubName + " - Brand: " + c.brand,imgindex)));
                    }
                    c.InnerClubInfo.courts.Sort((x, y) => x.courtName.CompareTo(y.courtName));
                    
                    foreach (Court crt in c.InnerClubInfo.courts)
                    {
                        if (devdata == true)
                        {
                            treeView1.Invoke(new Action(() => treeView1.Nodes[0].Nodes[index].Nodes.Add(crt.courtId.ToString(),crt.courtName + " - CourtID:" + crt.courtId,2)));
                           
                        }
                        else
                        {
                            treeView1.Invoke(new Action(() => treeView1.Nodes[0].Nodes[index].Nodes.Add(crt.courtId.ToString(),crt.courtName,2)));
                        }

                    }
                    index += 1;
                    //Thread.Sleep(10);
                    //this.Update();


                }
                this.Invoke(new Action(() => this.Text = string.Format("David Lloyd ABS - Ready")));
            }
            catch(Exception ex)
            {
               // MessageBox.Show(ex.ToString());
            }
            treeView1.Invoke(new Action(() => treeView1.Enabled = true));
            treeView1.Invoke(new Action(() => treeView1.Visible = true));
            treeView1.Invoke(new Action(() => pbProc.Visible = false));
        }
        Boolean devdata = false;

        private void button1_Click(object sender, EventArgs e)
        {
            devdata = checkBox1.Checked;
            treeView1.Nodes.Clear();

            try
            {
                Thread gtabs = new Thread(getAbs);
                //gtabs.IsBackground = true;
                gtabs.Start();
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.ToString());
            }
        }

        private void GetClasses(string siteid, string courtid,int parent, int index)
        {
          
            treeView1.Enabled = false;
            try
            {
                pbProc.Invoke(new Action(() => pbProc.Visible = true));
                string curday = "";
                if (treeView1.Nodes[0].Nodes[parent].Nodes[index].Nodes.Count > 0)
                {
                    treeView1.Invoke(new Action(() => treeView1.Nodes[0].Nodes[parent].Nodes[index].Nodes.Clear()));
                }
                for (int i = 0; i < 7; i++)
                {
                    string dayname = Enum.GetName(typeof(DayOfWeek),i);
                    TreeNode daynode = new TreeNode(dayname, 4, 4);
                    ContextMenuStrip ms = new ContextMenuStrip();
                    ms.Items.Add("Copy");

                    daynode.ContextMenuStrip = ms;
                    



                    treeView1.Invoke(new Action(() => treeView1.Nodes[0].Nodes[parent].Nodes[index].Nodes.Add(daynode)));
                    
                }

                string jsonstring;
                WebClient wc = new WebClient();
                jsonstring = wc.DownloadString("https://staff-back.davidlloyd.co.uk/clubs/" + siteid + "/studio/" + courtid + "/sessions/timetable");

                ClubInfo.clubs[parent].InnerClubInfo.courts[index].CourtClasses = JsonConvert.DeserializeObject<DLLClassEntries>(jsonstring);
                ClubInfo.clubs[parent].InnerClubInfo.courts[index].CourtClasses.sessionsDetails.Sort((x, y) => DateTime.Parse(x.date + " " + x.startTime).CompareTo(DateTime.Parse(y.date + " " + y.startTime)));

                int indx = 0;
                var random = new Random();

                int rnd = random.Next(0, 10000000);


                foreach (SessionsDetail cls in ClubInfo.clubs[parent].InnerClubInfo.courts[index].CourtClasses.sessionsDetails)
                {
                    string classidnew = cls.courseId.ToString() + "-" + ClubInfo.clubs[parent].InnerClubInfo.courts[index].courtId.ToString() + "-" + indx.ToString() + "-" + rnd;

                    indx += 1;
                    this.Invoke(new Action(() => this.Text = string.Format("David Lloyd ABS - Processing Classes:{0}/{1}", indx, ClubInfo.clubs[parent].InnerClubInfo.courts[index].CourtClasses.sessionsDetails.Count)));
                    int dow = (int)DateTime.Parse(cls.date).DayOfWeek;
                    TreeNode[] indexofnode = null;

                    if (treeView1.Nodes[0].Nodes[parent].Nodes[index].Nodes[dow].Nodes.IndexOfKey(DateTime.Parse(cls.date).ToShortDateString()) < 0)
                    {
                        treeView1.Invoke(new Action(() => treeView1.Nodes[0].Nodes[parent].Nodes[index].Nodes[dow].Nodes.Add(DateTime.Parse(cls.date).ToShortDateString(), DateTime.Parse(cls.date).ToShortDateString(), 4)));
                        treeView1.Update();
                    }
                    indexofnode = treeView1.Nodes[0].Nodes[parent].Nodes[index].Nodes[dow].Nodes.Find(DateTime.Parse(cls.date).ToShortDateString(), false);

                    if (indexofnode.Length > 0)
                    {
                        treeView1.Invoke(new Action(() => treeView1.Nodes[0].Nodes[parent].Nodes[index].Nodes[dow].Nodes[indexofnode[0].Index].Nodes.Add(classidnew, string.Format("{0} - {1}", DateTime.Parse(cls.date + " " + cls.startTime).ToShortTimeString(), DateTime.Parse(cls.date + " " + cls.startTime).AddMinutes(cls.duration).ToShortTimeString()), 4)));
                        TreeNode[] tnc = treeView1.Nodes.Find(classidnew, true);
                        treeView1.Invoke(new Action(() => treeView1.Nodes[0].Nodes[parent].Nodes[index].Nodes[dow].Nodes[indexofnode[0].Index].Nodes[tnc[0].Index].Nodes.Add(classidnew + cls.name, "Email:" + ClubInfo.clubs[parent].InnerClubInfo.fitnessManagerEmailAddress, 5)));
                        treeView1.Invoke(new Action(() => treeView1.Nodes[0].Nodes[parent].Nodes[index].Nodes[dow].Nodes[indexofnode[0].Index].Nodes[tnc[0].Index].Nodes.Add(classidnew + cls.name, "Phone:" + ClubInfo.clubs[parent].InnerClubInfo.telephone, 5)));
                        treeView1.Invoke(new Action(() => treeView1.Nodes[0].Nodes[parent].Nodes[index].Nodes[dow].Nodes[indexofnode[0].Index].Nodes[tnc[0].Index].Nodes.Add(classidnew + cls.name, "Class Name:" + cls.name, 5)));
                        treeView1.Invoke(new Action(() => treeView1.Nodes[0].Nodes[parent].Nodes[index].Nodes[dow].Nodes[indexofnode[0].Index].Nodes[tnc[0].Index].Nodes.Add(classidnew + cls.name, "Start:" + DateTime.Parse(cls.startTime).ToShortTimeString(), 5)));
                        treeView1.Invoke(new Action(() => treeView1.Nodes[0].Nodes[parent].Nodes[index].Nodes[dow].Nodes[indexofnode[0].Index].Nodes[tnc[0].Index].Nodes.Add(classidnew + cls.name, "End:" + DateTime.Parse(cls.startTime).AddMinutes(cls.duration).ToShortTimeString(), 5)));



                    }

                }
                //index2 += 1;
            }catch(Exception ex)
            {

            }
            treeView1.Enabled = true;
            this.Invoke(new Action(() => this.Text = string.Format("David Lloyd ABS - Ready")));
            pbProc.Invoke(new Action(() => pbProc.Visible = false));
        }
        private void treeView1_NodeMouseClick(object sender, TreeViewEventArgs e)
        {
            MessageBox.Show(e.Node.Name);
        }
            private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            int parent = 0;
            int index = 0;

            if (e.Node.Level > 1)
            {
                parent = e.Node.Parent.Index;
                if (e.Node.Level < 3)
                {
                    index = e.Node.Index;
                    if (e.Node.IsExpanded == false)
                    {
                        Thread gclstrd = new Thread(() => GetClasses(ClubInfo.clubs[parent].siteId.ToString(), ClubInfo.clubs[parent].InnerClubInfo.courts[index].courtId.ToString(), parent, index));
                        gclstrd.IsBackground = true;

                        gclstrd.Start();
                    }
                }
            }


            if (e.Node.Level > 5)
            {
                e.Node.BeginEdit();
            }
            else
            {
                e.Node.EndEdit(true);
            }


            if(e.Action == TreeViewAction.ByMouse)
            {
                if(e.Node.Level == 2)
                {
                    
                    string nodeentry = "";
                    try
                    {
                        foreach (TreeNode n in e.Node.Nodes)
                        {
                            try {
                            nodeentry += n.Text + "\r\n";
                            foreach (TreeNode n2 in n.Nodes)
                            {
                                    try
                                    {
                                        nodeentry += "\t" + n2.Text + "\r\n";
                                    }catch(Exception ex)
                                    {

                                    }
                            }
                        }catch(Exception ex)
                    {

                    }
                        }
                    }catch(Exception ex)
                    {

                    }
                    if (nodeentry != string.Empty)
                    {
                        Clipboard.SetText(nodeentry);
                    }
                    else
                    {
                        Clipboard.Clear();

                    }
                    }

          
            }
  
                

            
        }

        private void btnClps_Click(object sender, EventArgs e)
        {
            treeView1.CollapseAll();

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
