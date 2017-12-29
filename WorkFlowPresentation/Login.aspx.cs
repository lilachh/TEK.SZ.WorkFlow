using System;
using System.Web;
using System.Web.UI;

namespace WorkFlowPresentation
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {                
                Log.Debug("test");
                if (Session["EMPLID"] != null)
                {
                    Response.Redirect("Default.aspx?SystemID=-1");
                }
                string NT = HttpContext.Current.Request.LogonUserIdentity.Name.ToString();
                NT = NT.Substring(11); // get rid of tekni-plex/
                //NT = " " + NT;
                if (WorkFlowEngine.BLL.WorkFlow.NTExist(NT) && Session["ever"] == null)
                {
                    object emplID = WorkFlowEngine.BLL.WorkFlow.GetEmplID(NT);
                    Session["EMPLID"] = emplID;
                    Log.Debug("application start" + "  emplid=" + Session["EMPLID".ToString()] + "\n\r");
                    Session["ever"] = true;
                    this.Response.Redirect("Default.aspx?SystemID=-1");
                }
            }
        }

        protected void cmdimgok_Click(object sender, ImageClickEventArgs e)
        {
            this.loginStatus.Text = "";
            if (!WorkFlowEngine.BLL.Employee.EmplIDExist(txbopename.Text))
            {
                this.loginStatus.Text = "EmplID Not Existed!";
                return;
            }
            WorkFlowEngine.BLL.Employee employee=new WorkFlowEngine.BLL.Employee(int.Parse(txbopename.Text));
            if (employee.VerifyPassword(this.txbpwd.Text))
            {
                Session["EMPLID"] = employee.EmplID;
                Log.Debug("application start" + "  emplid=" + Session["EMPLID".ToString()]);
                Session["ever"] = true;

                //int di = 0;
                //int x = 100 / di;

                Response.Redirect("Default.aspx?SystemID=-1");
            }
            else
            {
                this.loginStatus.Text = "Wrong Password!";
            }
        }


        protected void txbopename_TextChanged(object sender, EventArgs e)
        {
            if (this.txbopename.Text.Length == 6)
            {
                if (!WorkFlowEngine.BLL.Employee.EmplIDExist(txbopename.Text))
                {
                    this.loginStatus.Text = "EmplID Not Existed!";
                }
                else
                {
                    this.loginStatus.Text = "";
                }
            }
            else
            {
                this.loginStatus.Text = "";
            }
        }

        protected void txbpwd_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
