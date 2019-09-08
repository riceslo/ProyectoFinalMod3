<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Servicio.aspx.cs" Inherits="AppBilletera.Servicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
<script type="text/javascript">
    $(function () {
        $.ajax({
            type: "POST",
            url: "Billtera.aspx/Getsaldo",
            data: '{}',
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: OnSuccess,
            failure: function (response) {
                alert('failure : ' + response.d);
            },
            error: function (response) {
                alert('error : ' + response.d);
            }
        });
    });
 
    function OnSuccess(response) {
        var jSONOBJECTS = response.d;
        $(jSONOBJECTS).each(function () {
            alert(this.saldo);

        });
    }
</script>

</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>
