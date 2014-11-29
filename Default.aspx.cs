using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;




namespace showRDLC
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!IsPostBack)
            //{
            //    SqlConnection con = new SqlConnection(@"Data Source=SHOHEL-PC;Initial Catalog=SplendidCRMM;User ID=sa;Password=ipac");
            //    SqlDataAdapter adpt = new SqlDataAdapter("Select * from TASKS", con);
            //    DataSet ds = new DataSet();
            //    adpt.Fill(ds);
             
            //    ReportDataSource source = new ReportDataSource("DataSet1", ds.Tables[0]);
            //    ReportViewer1.LocalReport.ReportPath = Server.MapPath("Report1.rdlc");
            //    ReportViewer1.LocalReport.DataSources.Clear();
            //    ReportViewer1.LocalReport.DataSources.Add(source);
            //    ReportViewer1.LocalReport.Refresh();
            //}


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            showReport();
        
        

        }
        private void showReport()
        {
            ReportViewer1.Reset();
            DataTable dt = getdata(DateTime.Parse(TextBox1.Text),DateTime.Parse(TextBox2.Text));
            ReportDataSource rds = new ReportDataSource("DataSet1", dt);

            ReportViewer1.LocalReport.DataSources.Add(rds);
            ReportViewer1.LocalReport.ReportPath = "Report2.rdlc";

            ReportParameter[] rptparameter = new ReportParameter[]
            {
                new ReportParameter("@FromDate",TextBox1.Text),
                new ReportParameter("@ToDate",TextBox2.Text),
                                
            };
            ReportViewer1.LocalReport.SetParameters(rptparameter);
            ReportViewer1.LocalReport.Refresh();

            
        }
        private DataTable getdata(DateTime FromDate, DateTime ToDate)
        {
            DataTable dt = new DataTable();
            string conr = System.Configuration.ConfigurationManager.ConnectionStrings["SplendidCRMMConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(conr);
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM TASKS", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("From", SqlDbType.DateTime).Value = FromDate;
                cmd.Parameters.Add("To", SqlDbType.DateTime).Value = ToDate;

                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                adpt.Fill(dt);
            }
            return dt;
        }
    }
}