<%@ Page Title="" Language="C#" MasterPageFile="~/Receta/Master_Inicio.master" AutoEventWireup="true" CodeFile="Receta.aspx.cs" Inherits="Receta_Receta" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div class="container">
        <br />
        <%--        <h1 runat="server">Bienvenido</h1>--%>
        <%--        <asp:Label runat="server" ID="lbl_usuario" Text="...Nombre"></asp:Label>

        <asp:Label runat="server" ID="Label1" Text="...Fecha"></asp:Label>--%>

        <%--        <div class="row container">
            <textarea id="TextArea1" cols="20" class="col-12" rows="5"></textarea>
        </div>--%>

        <header class="header">
            <div class="container_r">
                <div class="fecha">
                    <strong>Fecha:</strong>
                    <u><asp:Label runat="server" ID="Label1" Text="...--/--/--"></asp:Label></u>
                </div>
                <div class="datos-hospital">
                    <h3>Aptus Medical Arts</h3>
                    <h6>W.E. Hansen
<%--                            <br>--%>
                        123 Homestead Pl. Suite 2
<%--                            <br>--%>
                        Searchlight, NV 89046
                    </h6>
                </div>
                <figure class="logo">
                    <img src="./logo.png" alt="Logo" height="65px">
                </figure>
            </div>
        </header>

        <section class="paciente">
            <div class="container_r">
                <div class="paciente-nombre">
                    <strong>Nombre:</strong>
                    <u>Don Luis Gerardo Martínez</u>
                </div>
                <div class="paciente-edad">
                    <strong>Edad:</strong>
                    <u>24 años</u>
                </div>
            </div>
            <div class="container_r">
                <div class="paciente-direccion">
                    <strong>Dirección:</strong>
                    <u>Avenida Siempre Viva</u>
                </div>
                <div class="paciente-peso">
                    <strong>Peso:</strong>
                    <u>70 kg</u>
                </div>
            </div>
        </section>

        <section class="receta">
            <div class="container-receta">
                <%--<div class="receta-nombre">
                    <strong>Receta:</strong>
                </div>--%>
                <div class="container receta-nombre">
                    <div class="row ">
                        <textarea id="TextArea1" cols="50" class="col-12" rows="5" placeholder="Prescipcion"></textarea>
                    </div>
                </div>
            </div>
        </section>

        <footer class="footer">
            <div class="container_r">
                <div class="refill">
                    <strong>Refill</strong>
                    <u>6(six)</u>
                    times
                </div>
                <div class="firma">
                    <strong>Firma:</strong>
                    <u>Aquí va la firma del doctor</u>
                </div>
            </div>
            <div class="container_r">
                <div class="generic">
                    <strong>Generic Substitution: </strong>
                    <u>OK</u>
                </div>
                <div class="dea">
                    <strong>Dea#: </strong>
                    <u>Algo</u>
                </div>
            </div>
        </footer>

      <%--  <header class="header">
            <div class="container-r">
                <div class="fecha">
                    <strong>Fecha:</strong>
                    <u>8/08/2019</u>
                </div>
                <div class="datos-hospital">
                    <h3>Aptus Medical Arts</h3>
                    <h4>W.E. Hansen
                        <br>
                        123 Homestead Pl. Suite 2
                        <br>
                        Searchlight, NV 89046
                    </h4>
                </div>
                <figure class="logo">
                    <img src="./logo.png" alt="Logo" height="100px">
                </figure>
            </div>
        </header>
        <section class="paciente">
            <div class="container-r">
                <div class="paciente-nombre">
                    <strong>Nombre:</strong>
                    <u>Don Luis Gerardo Martínez</u>
                </div>
                <div class="paciente-edad">
                    <strong>Edad:</strong>
                    <u>24 años</u>
                </div>
            </div>
            <div class="container-r">
                <div class="paciente-direccion">
                    <strong>Dirección:</strong>
                    <u>Avenida Siempre Viva</u>
                </div>
                <div class="paciente-peso">
                    <strong>Peso:</strong>
                    <u>70 kg</u>
                </div>
            </div>
        </section>
        <section class="receta">
            <div class="container-receta">
                <div class="receta-nombre">
                    <strong>Receta:</strong>
                </div>
                <div class="receta-descripcion">
                    <ol>
                        <li>
                            <u>2 raspatitos al día</u>
                        </li>
                        <li>
                            <u>otros 2 raspatitos cada 24 horas</u>
                        </li>
                        <li>
                            <u>otro medicamento</u>
                        </li>
                    </ol>
                </div>
            </div>
        </section>
        <footer class="footer">
            <div class="container-r">
                <div class="refill">
                    <strong>Refill</strong>
                    <u>6(six)</u>
                    times
                </div>
                <div class="firma">
                    <strong>Firma:</strong>
                    <u>Aquí va la firma del doctor</u>
                </div>
            </div>
            <div class="container-r">
                <div class="generic">
                    <strong>Generic Substitution: </strong>
                    <u>OK</u>
                </div>
                <div class="dea">
                    <strong>Dea#: </strong>
                    <u>Algo</u>
                </div>
            </div>
        </footer>--%>
    </div>




</asp:Content>

