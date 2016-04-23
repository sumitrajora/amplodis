using BusinessWrapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Amplodis
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //Get Recent Blog
                DbParameter[] parameters = new DbParameter[1];
                parameters = null;
                DataTable dt = AmplodisConnect.ExecuteStoredProcedure("sp_fetchBlogParentChildRelation", parameters);

                DataTable dtn = dt.Clone();
                for (int i = 0; i < 3; i++)
                {
                    dtn.ImportRow(dt.Rows[i]);
                }

                lstRecentPost.DataSource = dtn;
                lstRecentPost.DataBind();

                //Get Recent Tag
                DbParameter[] paramTag = new DbParameter[1];
                paramTag = null;
                DataTable dtTag = AmplodisConnect.ExecuteStoredProcedure("sp_fetchTag", paramTag);
                lstTag.DataSource = dtTag;
                lstTag.DataBind();
            }
        }

        

        protected void Button1_Click(object sender, EventArgs e)
        {

            AmplodisMail.to = "info@amplodis.com";
            AmplodisMail.body = "<table><tr><td>Name <font color=#ff0000 size=1>*</font></td><td>" + txtName.Text + "</td></tr><tr><td>Company Name</td><td>" + txtComp.Text + "</td></tr><tr><td>Phone number<font color=#ff0000 size=1>*</font></td><td>" + txtPhone.Text + "</td></tr><tr><td>Email<font color=#ff0000 size=1>*</font></td><td>" + txtEmail.Text + "</td></tr><tr><td>Hear about us<font color=#ff0000 size=1>*</font></td><td>" + txtHear.Text + "</td></tr><tr><td>Query</td><td>" + txtComment.Text + "</td></tr><tr><td>&nbsp;</td><td></td></tr></table>";
            AmplodisMail.subject = "Contact Us";
            AmplodisMail.send();
            txtComment.Text = "";
            txtComp.Text = "";
            txtEmail.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
        }
    }
}