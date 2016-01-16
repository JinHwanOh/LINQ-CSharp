using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Configuration;

public partial class linq2 : System.Web.UI.Page
{
    DataContext dc = null;
    Table<entityUsers> table = null;


    protected void Page_Load(object sender, EventArgs e)
    {
        // wire up rowCommand for GridView
        GridView1.RowCommand += GridView1_RowCommand;
        getData();
    }

    void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int rowIndex = Convert.ToInt32(e.CommandArgument);
        // CommandArgument returns index of row in Object

        txtUName.Text = GridView1.Rows[rowIndex].Cells[0].Text;
        txtPWord.Text = GridView1.Rows[rowIndex].Cells[1].Text;
    }

    private void getData()
    {
        //create  closed connection instance
        string connStr = ConfigurationManager.ConnectionStrings["connStr_Users"].ConnectionString;
        SqlConnection conn = new SqlConnection(connStr);
        dc = new DataContext(conn);
        table = dc.GetTable<entityUsers>();

        // bind and display the data
        GridView1.DataSource = table;
        GridView1.DataBind();
    }

    protected void cmdInsert_Click(object sender, EventArgs e)
    {
    //    string sql = "INSERT INTO [tUsers] ([username],[password]) VALUES ('" + txtUName.Text + "','" + txtPWord.Text + "')";

        table.InsertOnSubmit(new entityUsers(txtUName.Text, txtPWord.Text));

 //       dc.ExecuteCommand(sql);
        // update database
        dc.SubmitChanges();

        // show changes 
        getData();
        clearText();
    }
    protected void cmdUpdate_Click(object sender, EventArgs e)
    {
        // get row to update
        IQueryable<entityUsers> query = from row in table
                                        where row.Username == txtUName.Text
                                        select row;
        // update selected row... cannnot change primary key!
        foreach (entityUsers row in query)
        {
            row.Username = txtUName.Text;
            row.Password = txtPWord.Text;
        }

        dc.SubmitChanges();

        // show changes 
        getData();
        clearText();
    }
    protected void cmdDelete_Click(object sender, EventArgs e)
    {
        // get row to delete
        IQueryable<entityUsers> query = from row in table
                                        where row.Username == txtUName.Text
                                        select row;

        foreach (entityUsers row in query)
        {
            table.DeleteOnSubmit(row);
        }

        dc.SubmitChanges();

        // show changes 
        getData();
        clearText();
    }

    private void clearText()
    {
        txtUName.Text = "";
        txtPWord.Text = "";
        txtUName.Focus();
    }
}