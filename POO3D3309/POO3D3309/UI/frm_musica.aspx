<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frm_musica.aspx.cs" Inherits="POO3D3309.UI.frm_musica" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" href="../CSS/Styles.css">
    <link href="https://fonts.googleapis.com/css2?family=Titillium+Web:ital@1&display=swap" rel="stylesheet"/>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.14.0/css/all.min.css"/>

    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>

    <title></title>
</head>
<body>
    <form id="frm_grav" runat="server">
        <input type="checkbox" runat="server" id="check" checked>
            <header class="header" runat="server">
        <label for="check" runat="server">
            <i class="fas fa-bars" id="open-menu"></i>
        </label>
        <h3 class="logo" runat="server">Horou</h3>
    </header>

    <div class="sidebar" runat="server">
       
        <img src="res/IMG/profile.jpg" id="profile_img" runat="server"/>
        <h4 runat="server">Música</h4>
       

        <a runat="server" href="frm_gravadora.aspx"><i class="fas fa-home"></i><span>Gravadora</span></a>
        <a runat="server" href="frm_cd.aspx"><i class="far fa-id-badge"></i><span>CD</span></a>
        <a runat="server" href="frm_musica.aspx"><i class="fas fa-language"></i><span>Músicas</span></a>
    </div>

   

    <div class="background" runat="server">
        <div class="info" runat="server">
            <div class="row">
                <div class="col-md-6" runat="server">
                    <asp:Label class="titulo" runat="server" Text="Nome"/>
                    <asp:TextBox ID="txt_nome" type="text" runat="server" CssClass="form-control" ></asp:TextBox>
                </div>
                 <div class="col-md-6" runat="server">
                    <asp:Label class="titulo" runat="server" Text="Nome Autor"/>
                    <asp:TextBox ID="txt_autor" type="text" runat="server" CssClass="form-control" ></asp:TextBox>
                </div>
            </div>

            <div class="row">
                <div class="col-md-6" runat="server">
                    <asp:Label class="titulo" runat="server" Text="ID Gravadora"/>
                    <asp:DropDownList AutoPostBack="true" ID="id_grav" type="text" runat="server" CssClass="form-control" >

                    </asp:DropDownList>
                </div>
                 <div class="col-md-6" runat="server">
                    <asp:Label class="titulo" runat="server" Text="ID CD"/>
                    <asp:DropDownList ID="id_cd" type="text" runat="server" CssClass="form-control" ></asp:DropDownList>
                </div>
            </div>
            
            <div class="row m-2" runat="server">
                 <div class="col-md-12">
                      <asp:Button ID="InserirMusica" class="btn btn-outline-light btn-block" runat="server" Text="Inserir" OnClick="btnListar"/>
                 </div> 
            </div>

            <div class="row" runat="server">
                <div class="col-md-1"></div>
                <div class="col-md-10">
                     <asp:GridView ID="GridMusica" class="table table-dark table-striped" OnRowDeleting="DeletingRow" OnRowCancelingEdit="CancelEditing" OnRowEditing="EditingRow" OnRowUpdating="UpdatingRow" runat="server" AllowPaging="True" OnPageIndexChanging="PageIndexChanging" PageSize="5" ValidateRequestMode="Disabled">
                          <Columns>
                            <asp:CommandField ShowDeleteButton="True" ButtonType="Link" />
                            <asp:CommandField ButtonType="Link" ShowEditButton="True" UpdateText="Gravar" />
                          </Columns>
                     </asp:GridView>
                </div>
                <div class="col-md-1"></div>
               
            </div>
        </div>
    </div>
</form>
</body>
</html>
