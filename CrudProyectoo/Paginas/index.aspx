<%@ Page Title="" Language="C#" MasterPageFile="~/mp.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="CrudProyectoo.Paginas.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">

    Inicio
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body "   runat="server">
    <form runat="server">
        <br />
        <div class="mx-auto" style="width:300px">
            <h2>Listado de registros</h2>
        
        </div>
        <br />
        <div class="container" >
            <div class="row">
                <div class="col align-self-end">
                    <asp:Button runat="server" ID="BtnCreate" CssClass="btn btn-success form-control-sm" Text="Crear" OnClick="BtnCreate_Click"/>
                </div>
            </div>
        </div>
        <br />
        <div class="container row " >
            <div class="table small " style="
            width:90%;height:500px; 
            color:white;
            background-image:url('../img/R.jpg');
            background-repeat: no-repeat;
	        ">
                <asp:GridView runat="server" ID="gvusuarios" CssClass=""  >
                    <Columns >
                        <asp:TemplateField HeaderText="Opciones del administrador">
                            <ItemTemplate>
                                
                                <asp:Button runat="server" Text="Editar" CssClass="btn form-control-sm btn-warning" ID="BtnUpdate" OnClick="BtnUpdate_Click"/>
                                <asp:Button runat="server" Text="Eliminar" CssClass="btn form-control-sm btn-danger" ID="BtnDelete" OnClick="BtnDelete_Click"/>
                            </ItemTemplate>
                        </asp:TemplateField>

                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </form>
</asp:Content>