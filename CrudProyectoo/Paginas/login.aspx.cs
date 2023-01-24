using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CrudProyectoo.Paginas
{
    public partial class login : System.Web.UI.Page
    {
        readonly SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("sp_login", con);
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = tbUsuario.Text;
            cmd.Parameters.Add("@Edad", SqlDbType.Int).Value = tbClave.Text;
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                Session["usuarioCorrecto"] = tbUsuario.Text;




                Response.Redirect("index.aspx");
            }
            else {
                Response.Redirect("login.aspx");
            }

            con.Close();
            

        }
    }
}