<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="About.aspx.cs" Inherits="About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    
     
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
        

    <meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
	<script type="application/x-javascript">
		addEventListener("load", function () {
			setTimeout(hideURLbar, 0);
		}, false);

		function hideURLbar() {
			window.scrollTo(0, 1);
		}
	</script>
	<!--// Meta Tags -->
	<!-- Stylesheet -->
	<link href="css/style.css" rel='stylesheet' type='text/css' />
	<!--// Stylesheet -->
	<!--fonts-->
	<link href="//fonts.googleapis.com/css?family=Montserrat:300,400,500,600,700,800" rel="stylesheet">
	<!--//fonts-->
        
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.0/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery.ripples/0.5.3/jquery.ripples.min.js"></script>


    <div class="business-card middle">
      <div class="front">
        <h2>SEPREMM</h2>
        <span>Receta Medica Multilenguaje</span>
        <ul class="contact-info">
          <li>
            <i class="fas fa-mobile-alt"></i> Usa esta plataforma en cualquier dispositivo
          </li>
          <li>
            <i class="far fa-envelope"></i> Envía la receta digital al correo de cada paciente
          </li>
          <li>
            <i class="fas fa-map-marker-alt"></i> En cualquier lugar, cualquier lenguaje (ingles por ahora)
          </li>
        </ul>
      </div>
      <div class="back">
        <span>SEPREMM</span>
      </div>
    </div>


    <script>
      $(".business-card").click(function(){
        $(".business-card").toggleClass("business-card-active");
      });
    </script>

    <script>
      $(".business-card").ripples({
        resolution: 256,
        perturbance: 5.99,
      });
    </script>
</asp:Content>
