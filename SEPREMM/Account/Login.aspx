<%@ Page Title="Iniciar sesión" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Account_Login" Async="true" %>

<%@ Register Src="~/Account/OpenAuthProviders.ascx" TagPrefix="uc" TagName="OpenAuthProviders" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">


    <!-- css files -->
    <link rel="stylesheet" href="css/style.css" type="text/css" media="all" />
    <!-- Style-CSS -->
    <link href="css/font-awesome.min.css" rel="stylesheet">
    <!-- Font-Awesome-Icons-CSS -->
    <!-- //css files -->

    <!-- Mensaje en popup -->
    <div class="modal fade" id="modMensaje" style="z-index: 10000">
        <div class="modal-dialog">
            <div class="modal-content">
                <%--<div class="modal-header">
                    <h4 class="modal-title" id="lblModalMensajeTitulo">Modal title</h4>
                </div>--%>
                <div class="modal-body">
                    <h2 class="txt-center" id="lblModalMensajeTexto">One fine body&hellip;</h2>
                    <asp:Button ID="Button2" runat="server" class="submit last-btn" data-dismiss="modal" Text="Cerrar" />
                </div>
            </div>
        </div>
    </div>

    <div id="progressModal" class="modal col-lg-offset-3 col-md-offset-3 col-sm-offset-4 col-xs-offset-5" 
        tabindex="-1" role="dialog" aria-hidden="true" style="vertical-align:middle" >
        <div id="progressModalDet" class="modal-dialog modal-sm">
            <div id="progressModalContent" class="modal-content" style="background-color: transparent;">
                <img src="../images/load (4).gif" alt="" style="max-height: 80px; max-width: 80px;" />
            </div>
        </div>
    </div>
    <script type="text/javascript"> 
        $('form').submit(function (event) {
            var options = {
                "backdrop": "static"
                , "keyboard": "false"
            }
            $('#progressModalContent').css("-webkit-box-shadow", 'rgba(0, 0, 0, 0.5) 0px 0px 0px 0px');
            $('#progressModalContent').css("border-width", "0px");
            $('#progressModal').modal(options);

        });
        $("#txtAlias").focus();

        $('.mnuManual').click(function () {
            OpenInNewTab('./Documento/FHL WMS Movil.pdf');
        });
    </script>

</asp:Content>


<asp:Content runat="server" ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2">

    <div class="main-bg">
        <br />
        <br />
        <div class="sub-main-w3">
            <div class="image-style">
            </div>
            <!-- vertical tabs -->
            <div class="vertical-tab">
                <div id="section0" class="section-w3ls">
                    <article>
                        <form>
                        </form>
                    </article>
                </div>

                <div id="section1" class="section-w3ls">
                    <input type="radio" name="sections" id="option1" checked>
                    <label for="option1" class="icon-left-w3pvt"><span class="fa fa-user-circle" aria-hidden="true"></span>Iniciar</label>
                    <article>
                        <div>
                            <br />
                            <br />
                            <br />
                            <h3 class="legend">Iniciar Sesion</h3>
                            <br />
                            <div class="input">
                                <span class="fa fa-envelope-o" aria-hidden="true"></span>
                                <input runat="server" id="txt_email_login" type="text" placeholder="E-mail" name="email" />
                            </div>
                            <div class="input">
                                <span class="fa fa-key" aria-hidden="true"></span>
                                <input runat="server" id="txt_contraseña_login" type="password" placeholder="Contraseña" name="password" />
                            </div>


                            <asp:Button ID="btn_logiin" runat="server" class="submit last-btn" Text="Iniciar" OnClick="btn_logiin_Click" />

                        </div>
                    </article>
                </div>

                <div id="section2" class="section-w3ls">
                    <input type="radio" name="sections" id="option2">
                    <label for="option2" class="icon-left-w3pvt"><span class="fa fa-pencil-square" aria-hidden="true"></span>Registrar</label>
                    <article>
                        <div>
                            <h3 class="legend">Registrate</h3>
                            <div class="input">
                                <span class="fa fa-user-o" aria-hidden="true"></span>
                                <input runat="server" id="txt_nombre_registro" type="text" placeholder="Nombre(s) y Apelllidos" name="name" CharacterCasing="Upper"/>
                            </div>
                            <div class="input">
                                <span class="fa fa-envelope-o" aria-hidden="true"></span>
                                <input runat="server" id="txt_correo_registro" type="text" placeholder="E-mail" name="email" />
                            </div>
                            <div class="input">
                                <span class="fa fa-key" aria-hidden="true"></span>
                                <input runat="server" id="txt_cedula_registro" type="text" placeholder="Cedula" name="cedula" />
                            </div>
                            <div class="input">
                                <span class="fa fa-key" aria-hidden="true"></span>
                                <input runat="server" id="txt_contraseña_registro" type="password" placeholder="Contraseña" name="password" />
                            </div>
                            <div class="input">
                                <span class="fa fa-key" aria-hidden="true"></span>
                                <input runat="server" id="txt_confirma_contraseña" type="password" placeholder="Confirmar Contraseña" name="password2" />
                            </div>
                            <asp:Button ID="btn_registra" runat="server" class="btn submit last-btn" Text="Registrar" OnClick="btn_registra_Click1" />
                        </div>
                    </article>
                </div>

                <div id="section3" class="section-w3ls">
                    <input type="radio" name="sections" id="option3">
                    <label for="option3" class="icon-left-w3pvt"><span class="fa fa-lock" aria-hidden="true"></span>¿Olvidaste tu Contraseña?</label>
                    <article>
                        <div>
                            <br />
                            <br />
                            <h3 class="legend last">Resestablecer Contraseña</h3>
                            <p class="para-style">Ingrese su dirección de correo electrónico a continuación y le enviaremos un correo electrónico con instrucciones.</p>

                            <div class="input">
                                <span class="fa fa-envelope-o" aria-hidden="true"></span>
                                <%--								<input runat="server" id="txt_restablece" type="email" placeholder="Email" name="email" required />--%>
                                <asp:TextBox ID="txt_restablece" runat="server" placeholder="E-mail"></asp:TextBox>
                            </div>
                            <div class="input">
                                <span class="fa fa-key" aria-hidden="true"></span>
                                <input runat="server" id="txt_cedula_rest" type="text" placeholder="Cedula" name="cedula" />
                            </div>
                            <asp:Button ID="btn_restablece" runat="server" class="submit last-btn" Text="Restablecer" OnClick="btn_restablece_Click" />
                        </div>
                    </article>
                </div>

            </div>
            <!-- //vertical tabs -->
        </div>
        <br />
    </div>

    
    



</asp:Content>


