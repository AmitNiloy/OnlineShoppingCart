using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class user_payment_success : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=Niloy;Initial Catalog=C:\SHOPPING_WEBSITE\APP_DATA\SHOPPING.MDF;Integrated Security=True");
    string order = "";
    string order_id;
    string s;
    string t;
    string[] a = new string[6];
    protected void Page_Load(object sender, EventArgs e)
    {

        con.Open();
        order = Request.QueryString["order"].ToString();
        if (order == Session["order_no"].ToString()) {

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from registration where email='" + Session["user"].ToString() + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows) {
                SqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandText = "insert into orders values ('" + dr["firstname"].ToString() + "','" + dr["lastname"].ToString() + "','" + dr["email"].ToString() + "','" + dr["address"].ToString() + "','" + dr["city"].ToString() + "','" + dr["state"].ToString() + "','" + dr["pincode"].ToString() + "','"+dr["mobile"].ToString()+"')";
                cmd1.ExecuteNonQuery();


            }

                SqlCommand cmd2 = con.CreateCommand();
                cmd2.CommandType = CommandType.Text;
            cmd2.CommandText="select top 1 * from orders where email='"+Session["user"].ToString()+"' order by id desc";
             DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(cmd);
            da2.Fill(dt2);
            
            foreach(DataRow dr2 in dt2.Rows ){
            order_id=dr2["id"].ToString();
            }


            if (Request.Cookies["aa"] != null)
            {

                s = Convert.ToString(Request.Cookies["aa"].Value);
                string[] strArr = s.Split('|');
                for (int i = 0; i < strArr.Length; i++)
                {
                    t = Convert.ToString(strArr[i].ToString());
                    string[] strArr1 = t.Split(',');

                    for (int j = 0; j < strArr1.Length; j++)
                    {
                        a[j] = strArr1[j].ToString();

                    }


                    SqlCommand cmd3 = con.CreateCommand();
                    cmd3.CommandType = CommandType.Text;
                    cmd3.CommandText = "insert into order_details values('" + order_id.ToString() + "','" + a[0].ToString() + "','" + a[2].ToString() + "','" + a[3].ToString() + "','" + a[4].ToString() + "') ";
                    cmd3.ExecuteNonQuery();


                }




            }



            else {

                Response.Redirect("login.aspx");
            }
            con.Close();
            Session["user"] = "";
            Response.Cookies["aa"].Expires = DateTime.Now.AddDays(-1);
            Response.Cookies["aa"].Expires = DateTime.Now.AddDays(-1);

            Response.Redirect("display_item.aspx");
        
        }

    }
}