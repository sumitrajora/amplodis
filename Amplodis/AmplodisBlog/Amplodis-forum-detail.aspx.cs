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

namespace Amplodis.AmplodisBlog
{
    public partial class Amplodis_forum_detail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DbParameter[] parameters = new DbParameter[1];
                if (Request.QueryString["ID"] != null)
                {
                    parameters[0] = new SqlParameter("@Id", Request.QueryString["ID"].ToString());
                    parameters[0].Direction = ParameterDirection.Input;
                    parameters[0].DbType = DbType.String;
                }
                else
                    parameters = null;
                DataTable dt = AmplodisConnect.ExecuteStoredProcedure("sp_fetchBlogParentChildRelation", parameters);
                if (dt.Columns.Contains("Answer"))
                {
                    lblDate.Text = dt.Rows[0]["AnswerDate"].ToString();
                    lblBlogName.Text = dt.Rows[0]["BlogName"].ToString();
                    lblDesc.Text = dt.Rows[0]["Answer"].ToString();
                    lblTagName.Text = dt.Rows[0]["TagName"].ToString();
                    imgUser.Src = dt.Rows[0]["ImageUrl"].ToString();
                }
            }
        }
    }
}