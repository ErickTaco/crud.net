<%@ Page Title="" Language="C#" MasterPageFile="~/mp.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="CrudProyectoo.Paginas.login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3"  ContentPlaceHolderID="body" runat="server" >
 
  <div style=" background-image:url('../img/ironman.jpg'); height:500px;width:100%">
      <br />
    <div class="mx-auto" style="width: 550px">
        <asp:Label runat="server" CssClass="h2" ID="lbltitulo"></asp:Label>
    </div>

    <form runat="server" class="h-100 d-flex align-items-center justify-content-center ">
        <div>
             <asp:Button runat="server" CssClass="btn btn-primary mb-4 " ID="BtnLogin" Text="Ingresar" Visible="true" OnClick="BtnLogin_Click" />          
            <asp:TextBox runat="server" CssClass="form-control mb-2" ID="tbUsuario" placeholder="Ingrese Usuario"></asp:TextBox>
            <asp:TextBox runat="server" CssClass="form-control mt-2" TextMode="Password" ID="tbClave" placeholder="Ingrese Contrasenia"></asp:TextBox>
          
        </div>
    </form>

  </div>  

    

</asp:Content>










