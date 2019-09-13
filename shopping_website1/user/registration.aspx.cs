using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class user_registration : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=Niloy;Initial Catalog=C:\SHOPPING_WEBSITE\APP_DATA\SHOPPING.MDF;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        con.Open();
        SqlCommand cmd=con.CreateCommand();
        cmd.CommandType=CommandType.Text;
        cmd.CommandText="insert into registration values('"+Textbox1.Text+"','"+Textbox2.Text+"','"+Textbox3.Text+"','"+Textbox4.Text+"','"+Textbox5.Text+"','"+Textbox6.Text+"','"+Textbox7.Text+"','"+Textbox8.Text+"','"+Textbox9.Text+"')";
        cmd.ExecuteNonQuery();


        con.Close();

        Textbox1.Text="";
        Textbox2.Text="";
        Textbox3.Text="";
        Textbox4.Text="";
        Textbox5.Text="";
        Textbox6.Text="";
        Textbox7.Text="";
        Textbox8.Text="";
        Textbox9.Text="";
Label1.Text="registration successful";

    }
}