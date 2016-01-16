using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

public class TableFactory
{
    public static DataTable makeTable()
    {
        DataTable table = new DataTable();

        DataColumn dc1 = new DataColumn();
        dc1.ColumnName = "SupplierID";
        dc1.DataType = Type.GetType("System.Int32");
        table.Columns.Add(dc1);

        DataColumn dc2 = new DataColumn();
        dc2.ColumnName = "CompanyName";
        dc2.DataType = Type.GetType("System.String");
        table.Columns.Add(dc2);

        DataColumn dc3 = new DataColumn();
        dc3.ColumnName = "City";
        dc3.DataType = Type.GetType("System.String");
        table.Columns.Add(dc3);

        DataColumn dc4 = new DataColumn();
        dc4.ColumnName = "Country";
        dc4.DataType = Type.GetType("System.String");
        table.Columns.Add(dc4);

        return table;
    }
}