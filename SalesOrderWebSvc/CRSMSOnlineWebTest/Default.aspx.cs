using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CRSMSOnlineWebTest.SOWebSvcRef;

namespace CRSMSOnlineWebTest
{
    public partial class _Default : System.Web.UI.Page
    {
        SOWebSvcClient sowebsvc;
        Customer cust;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Request["save"]))
            {
                sowebsvc = new SOWebSvcClient();
                cust = new Customer();
                cust.FirstName = Request["fname"];
                cust.LastName = Request["lname"];
                cust.Address = Request["address"];
                cust.ContactNo = Request["contactno"];

                if (sowebsvc.SaveCustomer(cust))
                {
                    Response.Write("<script>alert('Customer Added!');</script>");
                }
                else
                {
                    Response.Write("<script>alert('Error occured. Please try again later.');</script>");
                }
                //Response.Redirect("Default.aspx");
            }
        }
    }
}