using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Linq;
using System.Data.OleDb;
using System.Data;

public partial class linq1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void cmdGet_Click(object sender, EventArgs e)
    {
        // create DataTable
        DataTable myTable = TableFactory.makeTable();

        // create CLOSED connection instance
        string path = Server.MapPath("/"); // driver to connection
        string connStr = "Provider=Microsoft.Jet.OLEDB.4.0;" +
            "Data Source=" + path + "App_Data\\NWIND.MDB"; // location of database file
        OleDbConnection conn = new OleDbConnection(connStr);

        // create main entry point for LINQ to SQL framework
        DataContext dc = new DataContext(conn);

        // create GENERIC LINQ table
        Table<entitySuppliers> table = dc.GetTable<entitySuppliers>();

        // create linq query
        IQueryable<entitySuppliers> query = 
            from row in table
           // where row.SupplierID == Convert.ToInt32(txtSId.Text)
            select row;

        // iterate through query
        foreach (entitySuppliers row in query)
        {
            DataRow dr = myTable.NewRow();
            dr["SupplierID"] = row.SupplierID;
            dr["CompanyName"] = row.CompanyName;
            dr["City"] = row.City;
            dr["Country"] = row.Country;

            myTable.Rows.Add(dr);
        }

        // bind and display...DataSource may be  query, linq table or a DataTable
        GridView1.DataSource = myTable;
        GridView1.DataBind();
    }
}