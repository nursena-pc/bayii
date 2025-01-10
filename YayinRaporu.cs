using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Reporting;
using System.IO;



namespace bayii
{

    public partial class YayinRaporu : Form
    {
        SqlConnection _connection = new SqlConnection(@"server=-ND-\SQLEXPRESS; initial catalog=bayii; integrated security=true");
        public DataSet dataset= new DataSet();
        public YayinRaporu()
        {
            InitializeComponent();

        }

        private void YayinRaporu_Load(object sender, EventArgs e)
        {

            _connection.Open();
            yayinRaporum.SetDataSource(dataset);

            crystalReportViewer1.ReportSource = yayinRaporum;


            //ReportDocument reportDocument = new ReportDocument();
            //reportDocument.Load(@"C:\Users\nursena\Desktop\bayiiC#\bayii\YayinRaporum.rpt");
            //string pdfPath = @"C:\Reports\YayinRaporum.pdf";

            ////Raporu PDF formatında dışa aktarın
            //reportDocument.ExportToDisk(ExportFormatType.PortableDocFormat, pdfPath);


        }

    }
}

       
    






