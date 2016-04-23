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
    public partial class amplodis_forum : System.Web.UI.Page
    {
        protected string strClass { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable dtTag = AmplodisConnect.ExecuteStoredProcedure("sp_fetchTag", null);
                String category = null;
                foreach (DataRow DRow in dtTag.Rows)
                {
                    category += "<a class='category-btn " + DRow["ClassName"] + "-btn' href='amplodis-forum.aspx?tid=" + DRow["TagId"] + "'>" + DRow["TagName"] + "</a>";
                }
                dvContainerTag.InnerHtml = category;

                this.strClass = "all-blog";

                DbParameter[] parameters = new DbParameter[1];
                if (Request.QueryString["ID"] != null)
                {
                    parameters[0] = new SqlParameter("@Id", Request.QueryString["ID"].ToString());
                    parameters[0].Direction = ParameterDirection.Input;
                    parameters[0].DbType = DbType.String;

                }
                else
                {
                    parameters[0] = new SqlParameter("@TagId", Request.QueryString["tid"] == null || Request.QueryString["tid"] == "" ? null : Request.QueryString["tid"].ToString());
                    parameters[0].Direction = ParameterDirection.Input;
                    parameters[0].DbType = DbType.String;
                }
                DataTable dt = AmplodisConnect.ExecuteStoredProcedure("sp_fetchBlogParentChildRelation", parameters);
                {
                    grdBlog.Visible = true;
                    grdBlog.DataSource = dt;
                    if (dt.Rows.Count > 0)
                    {
                        this.strClass = dt.Rows[0]["ClassName"].ToString();
                        grdBlog.DataBind();
                    }
                }
            }
        }

        protected void grdBlog_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}