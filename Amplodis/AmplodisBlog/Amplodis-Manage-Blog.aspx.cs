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
    public partial class Amplodis_Manage_Blog : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMsg.Text = "";
            if (!IsPostBack)
            {
                DbParameter[] parameters = new DbParameter[1];
                parameters = null;
                DataTable dt = AmplodisConnect.ExecuteStoredProcedure("sp_fetchBlogParentChildRelation", parameters);
                ddlBlog.DataSource = dt;
                ddlBlog.DataValueField = "Id";
                ddlBlog.DataTextField = "BlogName";
                ddlBlog.DataBind();
            }

        }

        protected void btnSaveAns_Click(object sender, EventArgs e)
        {
            DbParameter[] parameters = new DbParameter[2];

            parameters[0] = new SqlParameter("@Answer", txtAnswer.Text);
            parameters[0].Direction = ParameterDirection.Input;
            parameters[0].DbType = DbType.String;

            parameters[1] = new SqlParameter("@BlogId", ddlBlog.SelectedValue);
            parameters[1].Direction = ParameterDirection.Input;
            parameters[1].DbType = DbType.String;

            AmplodisConnect.ExecuteNonQueryStoredProcedure("sp_insertAnswer", parameters);
            lblMsg.Text = "Answer Saved Successfully";
            txtAnswer.Text = "";
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {

            DbParameter[] parameters = new DbParameter[3];

            parameters[0] = new SqlParameter("@BlogName", txtBlog.Text);
            parameters[0].Direction = ParameterDirection.Input;
            parameters[0].DbType = DbType.String;

            parameters[1] = new SqlParameter("@Description", txtDesc.Text);
            parameters[1].Direction = ParameterDirection.Input;
            parameters[1].DbType = DbType.String;

            parameters[2] = new SqlParameter("@ParentId", null);
            parameters[2].Direction = ParameterDirection.Input;
            parameters[2].DbType = DbType.String;

            AmplodisConnect.ExecuteNonQueryStoredProcedure("sp_insertBlogParentChildRelation", parameters);
            lblMsg.Text = "Blog Saved Successfully";
            txtBlog.Text = "";
            txtDesc.Text = "";
        }
    }
}