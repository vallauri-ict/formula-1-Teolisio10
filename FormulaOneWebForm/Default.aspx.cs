using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FormulaOneDll;

namespace FormulaOneWebForm
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLoadCountries_Click(object sender, EventArgs e)
        {
            DbTools db = new DbTools();
            GridView1.DataSource = db.GetCountries().Values;
            GridView1.DataBind();
        }

        protected void btnLoadDrivers_Click(object sender, EventArgs e)
        {
            DbTools db = new DbTools();
            GridView1.DataSource = db.GetDrivers().Values;
            GridView1.DataBind();
        }

        protected void btnLoadTeams_Click(object sender, EventArgs e)
        {
            DbTools db = new DbTools();
            //Dictionary<string, List<object>> d = new Dictionary<string, List<object>>();
            //d.Add(db.LoadTeamsTable()[0].ToString(), db.LoadTeamsTable());
            //GridView1.DataSource = d.Values;
            GridView1.DataSource = db.LoadTeamsTable();
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Write($"<script>console.log('{GridView1.SelectedRow.Cells[1].Text}')</script>");
        }
    }
}