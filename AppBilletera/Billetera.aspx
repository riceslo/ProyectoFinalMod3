<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Billetera.aspx.cs" Inherits="AppBilletera._Billetera" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>BILLETERA MOVIL</h1>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Ingreso</h2>
            <p>
                <input id="txtIngreso" type="number" runat="server" class="form-control" max="999999999" min="0" value="0" />
            </p>
            <p>
                <asp:LinkButton ID="lbtIngreso" class="btn btn-default"  runat="server" OnClick="lbtIngreso_Click">Procesar</asp:LinkButton>
                
            </p>
        </div>
        <div class="col-md-4">
            <h2>Egreso</h2>
            <p>
                <input id="txtEgreso" type="number" runat="server" class="form-control" />
            </p>
            <p>
                 <asp:LinkButton ID="lbtEgreso" class="btn btn-default"  runat="server" OnClick="lbtEgreso_Click">Procesar</asp:LinkButton>
            </p>
        </div>
        <div class="col-md-4" style="text-align:center">
            <h2> Saldo </h2>
           <h3><span id="spnSaldo" runat="server" class="badge badge-secondary">0.00</span></h3>
          
        </div>
    </div>

</asp:Content>
