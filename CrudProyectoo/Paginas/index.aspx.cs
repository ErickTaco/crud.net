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
    public partial class index : System.Web.UI.Page
    {

        readonly SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {

            cargarTabla();
            inicioSesion();
        }
        void inicioSesion() {
            if (Session["usuarioCorrecto"] != null)
            {
                string usuarioCorrecto = Session["usuarioCorrecto"].ToString();
           
            }
            else {
                Response.Redirect("login.aspx");
            }
        }
        void cargarTabla() {
            SqlCommand cmd = new SqlCommand("sp_load", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            con.Open();
            SqlDataAdapter da=new SqlDataAdapter(cmd);
            DataTable dt=new DataTable();   
            da.Fill(dt);
            gvusuarios.DataSource = dt; 
            gvusuarios.DataBind();
            con.Close();
        }

        protected void BtnCreate_Click(object sender, EventArgs e) {
            Response.Redirect("~/Paginas/crud.aspx?op=C");
        }

        protected void BtnRead_Click(object sender, EventArgs e)
        {
            string id;
            Button BtnConsultar=(Button)sender;
            GridViewRow selectedrow = (GridViewRow)BtnConsultar.NamingContainer;
            id = selectedrow.Cells[1].Text;
            Response.Redirect("~/Paginas/crud.aspx?id="+id+"&op=R");
        }

        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            string id;
            Button BtnConsultar = (Button)sender;
            GridViewRow selectedrow = (GridViewRow)BtnConsultar.NamingContainer;
            id = selectedrow.Cells[1].Text;
            Response.Redirect("~/Paginas/crud.aspx?id=" + id + "&op=U");
        }

        protected void BtnDelete_Click(object sender, EventArgs e)
        {
            string id;
            Button BtnConsultar = (Button)sender;
            GridViewRow selectedrow = (GridViewRow)BtnConsultar.NamingContainer;
            id = selectedrow.Cells[1].Text;
            Response.Redirect("~/Paginas/crud.aspx?id=" + id + "&op=D");
        }

    }
}