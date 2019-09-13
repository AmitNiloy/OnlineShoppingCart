using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class user_login : System.Web.UI.Page
{
    
    SqlConnection con = new SqlConnection(@"Data Source=Niloy;Initial Catalog=C:\SHOPPING_WEBSITE\APP_DATA\SHOPPING.MDF;Integrated Security=True");
    int tot=0;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        con.Open();
        SqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "select *from registration  where email='"+TextBox1.Text+"' and password= '"+TextBox2.Text+"'";
        cmd.ExecuteNonQuery();
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(dt);
        tot = Convert.ToInt32(dt.Rows.Count.ToString());

        if (tot > 0)
        {
            if (Session["checkoutbutton"] == "yes")
            {
                Session["user"] = TextBox1.Text;
                Response.Redirect("update_order_details.aspx");
            }
            else
            {
                Session["user"] = TextBox1.Text;
                Response.Redirect("order_details.aspx");
            }
        }
        else {
            Label2.Text = "invalid username or password";
        }


        con.Close();

    }
}