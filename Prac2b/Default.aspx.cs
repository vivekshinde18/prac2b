using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
public partial class Pract2b : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }
    public class conv
    {
        public double d, r, e, a;
        public conv(double amount)
        {
            a = amount;
        }
        public void rtd()
        {
            d = a / 69;
        }
        public void dtr()
        {
            r = a * 69;
        }
        public void rte()
        {
            e = a / 82.36;
        }
        public void etr()
        {
            r = a * 82.36;
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        double a = Double.Parse(TextBox1.Text);
        conv obj = new conv(a);
        obj.rtd();
        TextBox2.Text = Convert.ToString(obj.d);
        obj.dtr();
        TextBox3.Text = Convert.ToString(obj.r);
        obj.rte();
        TextBox4.Text = Convert.ToString(obj.e);
        obj.etr();
        TextBox5.Text = Convert.ToString(obj.r);
    }
}