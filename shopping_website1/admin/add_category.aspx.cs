using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class admin_add_category : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=Niloy;Initial Catalog=C:\SHOPPING_WEBSITE\APP_DATA\SHOPPING.MDF;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
         if (Session["admin"] == null) {

            Response.Redirect("adminlogin.aspx");
        }


         con.Open();
         SqlCommand cmd = con.CreateCommand();
         cmd.CommandType = CommandType.Text;
         cmd.CommandText = "select * from product_category";
         cmd.ExecuteNonQuery();
         DataTable dt = new DataTable();
         SqlDataAdapter da = new SqlDataAdapter(cmd);
         da.Fill(dt);
         d1.DataSource = dt;
         d1.DataBind();
    
    }
    protected void b1_Click(object sender, EventArgs e)
    {
        con.Open();
        SqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "insert into product_category values ('" + t1.Text + "')";
        cmd.ExecuteNonQuery();

        con.Close();

        Response.Write("<script>alert('product category added successfully');</script");
    }
}