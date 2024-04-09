<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Inicio.aspx.cs" Inherits="Account_Inicio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">


   


</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">

         	<link rel="stylesheet" href="Account/css/style.css" type="text/css" media="all" />
	<!-- Style-CSS -->
	<link href="Account/css/font-awesome.min.css" rel="stylesheet">
	<div class="main-bg">
        <br />
        <br />

		<div class="sub-main-w3">

			<div class="image-style">
			</div>

			<div class="vertical-tab">
                
                <div id="section0" class="section-w3ls">
					<article>
						<div >
						</div>
					</article>
				</div>
               
                <div id="section1" class="section-w3ls">
					<input type="radio" name="sections" id="option1" checked>
					<label for="option1" class="icon-left-w3pvt"><span class="fa fa-user-circle" aria-hidden="true"></span>Iniciar</label>
                    <article>
						<div >
							<h3 class="legend">Iniciar Sesion</h3> 
							<div class="input">
								<span class="fa fa-envelope-o" aria-hidden="true"></span>
								<input runat="server" id="txt_email_login" type="text" placeholder="E-mail" name="email" />
							</div>
							<div class="input">
								<span class="fa fa-key" aria-hidden="true"></span>
								<input runat="server" id="txt_contraseña_login" type="password" placeholder="Contraseña" name="password"  />
							</div>
                            <asp:Button ID="btn_login" runat="server" class="btn submint last-btn" Text="Iniciar" OnClick="btn_login_Click" />
						</div>
					</article>
				</div>
                
                <div id="section2" class="section-w3ls">
					<input type="radio" name="sections" id="option2">
					<label for="option2" class="icon-left-w3pvt"><span class="fa fa-pencil-square" aria-hidden="true"></span>Registrar</label>
					<article>
						<div >
							<h3 class="legend">Registrate</h3>
							<div class="input">
								<span class="fa fa-user-o" aria-hidden="true"></span>
								<input runat="server" id="txt_nombre" type="text" placeholder="Nombre(s) y Apelllidos" name="name"  />
							</div>
                            <div class="input">
								<span class="fa fa-key" aria-hidden="true"></span>
								<input runat="server" id="txt_cedula" type="text" placeholder="Cedula" name="cedula" />
							</div>
							<div class="input">
								<span class="fa fa-key" aria-hidden="true"></span>
								<input runat="server" id="txt_contraseña" type="password" placeholder="Contraseña" name="password" />
							</div>
							<div class="input">
								<span class="fa fa-key" aria-hidden="true"></span>
								<input runat="server" id="txt_confirma_contraseña" type="password" placeholder="Confirmar Contraseña" name="password2"/>
							</div>
                            <asp:Button ID="btn_registra" runat="server"  Text="Registrar" OnClick="btn_registra_Click"  />
						</div>
					</article>
				</div>
				
                <div id="section3" class="section-w3ls">
					<input type="radio" name="sections" id="option3">
					<label for="option3" class="icon-left-w3pvt"><span class="fa fa-lock" aria-hidden="true"></span>¿Olvidaste tu Contraseña?</label>
					<article>
						<div>
							<h3 class="legend last">Resestablecer Contraseña</h3>
							<p class="para-style">Ingrese su dirección de correo electrónico a continuación y le enviaremos un correo electrónico con instrucciones.</p>
							
							<div class="input">
								<span class="fa fa-envelope-o" aria-hidden="true"></span>
                                <asp:TextBox ID="txt_restablece" runat="server"  placeholder="Email"></asp:TextBox>
							</div>
                            <asp:Button ID="btn_restablece" runat="server" Text="Restablecer" OnClick="btn_restablece_Click" />
						</div>
					</article>
				</div>
                
			
			</div>
		</div>
        <br />

	</div>  
    	
	
</asp:Content>

