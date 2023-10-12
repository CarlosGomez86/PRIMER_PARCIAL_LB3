using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP_Blogs
{
    public partial class ConsultarBlog : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            GridView1.Visible = true;
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                TextBox1.Text = GridView1.SelectedRow.Cells[1].Text;
            }
            catch(Exception ex)
            {
                TextBox1.Text = ex.Message;
                StreamWriter arch = new StreamWriter(this.Server.MapPath(".") + "/excepciones.txt", true);
                arch.WriteLine("");
                arch.WriteLine(DateTime.Now.ToString());
                arch.WriteLine(ex.Message.ToString());
                arch.WriteLine("");
                arch.Close();
            }
        }
    }
}