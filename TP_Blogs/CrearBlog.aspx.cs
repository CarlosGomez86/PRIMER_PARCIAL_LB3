using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP_Blogs
{
    public partial class CrearBlog : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            int id = 0;

            try
            {
                this.SqlDataSource3.SelectParameters["nombre"].DefaultValue = this.TextBox2.Text;
                this.SqlDataSource3.SelectParameters["apellido"].DefaultValue = this.TextBox3.Text;
                this.SqlDataSource3.DataSourceMode = SqlDataSourceMode.DataReader;
                SqlDataReader datos;
                datos = (SqlDataReader)this.SqlDataSource3.Select(DataSourceSelectArguments.Empty);
                if (datos.Read())
                {
                    id = Convert.ToInt32(datos["id"]);

                    this.SqlDataSource3.InsertParameters["texto"].DefaultValue = TextBox1.Text;
                    this.SqlDataSource3.InsertParameters["idAutor"].DefaultValue = id.ToString();
                    this.SqlDataSource3.Insert();
                    Label9.Text = "Se realizó correctamente la carga de su blog.";
                    this.TextBox1.Text = "";
                    this.TextBox2.Text = "";
                    this.TextBox3.Text = "";
                }

                else
                   this.Label9.Text = "No existe un Autor registrado con ese nombre. Por favor registre sus datos para poder redactar un blog.";
            }
            catch (Exception ex)
            {
                this.Label9.Text= ex.Message;

                StreamWriter arch = new StreamWriter(this.Server.MapPath(".") + "/excepciones.txt", true);
                arch.WriteLine(DateTime.Now.ToString());
                arch.WriteLine("<br>");
                arch.WriteLine(ex.Message.ToString());
                arch.Close();

            }

        }
    }
}