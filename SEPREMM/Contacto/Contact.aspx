<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Contact.aspx.cs" Inherits="Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <meta charset="utf-8">

	<link href="css/style.css" rel='stylesheet' type='text/css' />

	<h1></h1>
    <br />
	<div class="contact-main-w3-agile">
		<div class="top-section-wthree">
			<h2 class="sub-title">Contactanos</h2>
		</div>
		<div class="form-agileits-w3layouts">
			<form action="#" method="post">
				<div class="form-w3layouts-fields">
					<input runat="server" id="txt_nombre" type="text" name="Name" placeholder="Nombre" required="" />
				</div>
				<div class="form-w3layouts-fields">
					<input runat="server" id="txt_email" type="email" name="Email" placeholder="Email" required="" />
				</div>
				<div class="form-w3layouts-fields">
					<input runat="server" id="txt_telefono" type="text" name="Phone" placeholder="Telefono" required="" />
				</div>
				<div class="form-w3layouts-fields">
					<textarea runat="server" id="txt_mensaje" name="Message" placeholder="Mensaje" required=""></textarea>
				</div>
				<asp:button ID="btn_envia" runat="server" text="Enviar" OnClick="btn_envia_Click"/>
			</form>
		</div>
	</div>
	<div class="clear"></div>
    <br />
    <br />
    
    <script>
      $("body").ripples({
        resolution: 256,
        perturbance: 0.00001,
      });
    </script>

</asp:Content>
