using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP_Blogs
{
    public partial class ActualizarBlog : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            GridView1.Visible = true;

            GridView1.DataBind();
        }

        protected void ActualizarButton_Click(object sender, ImageClickEventArgs e)
        {
            try
            {

                SqlDataSource1.Update();
                Label3.Text = "Se han actualizado los datos correctamente.";

            }
            catch(Exception ex)
            {
             


                    Label3.Text = ex.Message;
                    StreamWriter arch = new StreamWriter(this.Server.MapPath(".") + "/excepciones.txt", true);
                    arch.WriteLine("");
                    arch.WriteLine(DateTime.Now.ToString());                    
                    arch.WriteLine(ex.Message.ToString());
                    arch.WriteLine("");                    
                    arch.Close();
                
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBox1.Text = GridView1.SelectedRow.Cells[2].Text;
        }
    }
}