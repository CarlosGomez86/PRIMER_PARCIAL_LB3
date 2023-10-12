using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP_Blogs
{
    public partial class CrearAutor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            try
            {

                this.SqlDataSource1.InsertParameters["nombre"].DefaultValue = this.TextBox2.Text;
                this.SqlDataSource1.InsertParameters["apellido"].DefaultValue = this.TextBox1.Text;
                this.SqlDataSource1.Insert();
                this.Label5.Text = $"Se a agregado a {TextBox2.Text} {TextBox1.Text} exitosamente!";
            }
            catch(Exception ex)
            {
                this.Label5.Text= ex.Message;
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