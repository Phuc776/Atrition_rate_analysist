using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace WebApplication
{
    public partial class WebForm1 : System.Web.UI.Page
    {
		XULYDULIEU xuly;
        protected void Page_Load(object sender, EventArgs e)
        {
			xuly = new XULYDULIEU();
		}
        
        protected void Button1_Click(object sender, EventArgs e)
        {
            String sql = "SELECT ([Db Job Management2].[Attrition]) as [predicted value],"
                      + "(PredictProbability([Db Job Management2].[Attrition])) as [PredictProbability]"
          + " From [Db Job Management2] NATURAL PREDICTION JOIN (SELECT '" + txtAge.Text + "' AS[Age],"
          + " '" + txtDistanceFromHome.Text + "' AS[Distance From Home],'"
          + txtYearsWithCurrManager.Text + "' AS[Years With Curr Manager], '"
          + DropDownListEducation.SelectedValue + "' AS [Education], '"
          + txtPercentSalaryHike.Text + "' AS [Percent Salary Hike], '"
          + txtTotalWorkingYear.Text + "' AS [Total Working Year], '"
          + txtYearsAtCompany.Text + "' AS [Years At Company], '"
          + txtYearsInCurrentRole.Text + "' AS [Years In Current Role], '"
          + txtYearsSinceLastPromotion.Text + "' AS [Years Since Last Promotion]) AS t";
           

            this.GridView1.DataSource = xuly.getPredicted(sql);
			this.GridView1.DataBind();
		}

        protected void Button2_Click(object sender, EventArgs e)
        {
            String sql = "SELECT ([Db Job Management2].[Attrition]) as [predicted value],"
                      + "(PredictProbability([Db Job Management2].[Attrition])) as [PredictProbability]"
          + " From [Db Job Management2] NATURAL PREDICTION JOIN (SELECT '" + txtAge.Text + "' AS[Age],"
          + " '" + txtDistanceFromHome.Text + "' AS[Distance From Home],'"
          + txtYearsWithCurrManager.Text + "' AS[Years With Curr Manager], '"
          + DropDownListEducation.SelectedValue + "' AS [Education], '"
          + txtPercentSalaryHike.Text + "' AS [Percent Salary Hike], '"
          + txtTotalWorkingYear.Text + "' AS [Total Working Year], '"
          + txtYearsAtCompany.Text + "' AS [Years At Company], '"
          + txtYearsInCurrentRole.Text + "' AS [Years In Current Role], '"
          + txtYearsSinceLastPromotion.Text + "' AS [Years Since Last Promotion]) AS t";


            SMTP_Client client = new SMTP_Client();
            Model model = new Model(txtAge.Text, txtDistanceFromHome.Text, DropDownListEducation.SelectedValue, txtPercentSalaryHike.Text,
                txtTotalWorkingYear.Text, txtYearsAtCompany.Text, txtYearsInCurrentRole.Text, txtYearsSinceLastPromotion.Text, txtYearsWithCurrManager.Text);
            DataTable table = xuly.getPredicted(sql);
            String htmlTable = ConvertDataTableToHtmlTable(table);
            Label1.Text = client.send(model, htmlTable, txtUsername.Text, txtPassWord.Text, txtToUsername.Text);
        }

        public string ConvertDataTableToHtmlTable(DataTable dt)
        {
            // Convert DataTable to HTML table
            string htmlTable = "<table border='1'>";
            // Adding column headers
            htmlTable += "<tr>";
            foreach (DataColumn column in dt.Columns)
            {
                htmlTable += "<th>" + column.ColumnName + "</th>";
            }
            htmlTable += "</tr>";
            // Adding rows
            foreach (DataRow row in dt.Rows)
            {
                htmlTable += "<tr>";
                foreach (var item in row.ItemArray)
                {
                    htmlTable += "<td>" + item.ToString() + "</td>";
                }
                htmlTable += "</tr>";
            }
            htmlTable += "</table>";

            return htmlTable;
        }

    }
}