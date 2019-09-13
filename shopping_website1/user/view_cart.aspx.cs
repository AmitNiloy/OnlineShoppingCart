using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class user_view_cart : System.Web.UI.Page
{
    string s;
    string t;
    string[] a = new string[10];
    int tot = 0;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void b1_Click(object sender, EventArgs e)
    {
        DataTable dt = new DataTable();
        dt.Columns.AddRange(new DataColumn[6] { new DataColumn("product_name"), new DataColumn("product_desc"), new DataColumn("product_price"), new DataColumn("product_qty"), new DataColumn("product_image"), new DataColumn("id") });
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
                dt.Rows.Add(a[0].ToString(), a[1].ToString(), a[2].ToString(), a[3].ToString(), a[4].ToString(), i.ToString());
                tot = tot + (Convert.ToInt32(a[2].ToString()) * Convert.ToInt32(a[3].ToString()));
            }

        }

        d1.DataSource = dt;
        d1.DataBind();
        L1.Text = "you have to pay="+tot.ToString();

    }
    protected void Unnamed1_Click(object sender, EventArgs e)
    {
        Session["checkoutbutton"] = "yes";
        Response.Redirect("checkout.aspx");
    }
}