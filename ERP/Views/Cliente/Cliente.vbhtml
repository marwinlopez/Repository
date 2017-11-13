@Code
    ViewData("Title") = "Index"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code
<!-- Left side column. contains the logo and sidebar -->
<aside class="main-sidebar" style="position:fixed">
    <!-- sidebar: style can be found in sidebar.less -->
    <section class="sidebar">
        <!-- Sidebar user panel (optional) -->
        <div class="user-panel">
            <div class="pull-left image">
                <img src="~/images/avatar.png" class="img-circle" alt="User Image">
            </div>
            <div class="pull-left info">
                <p>Alexander Pierce</p>
                <!-- Status -->
                <a href="#"><i class="fa fa-circle text-success"></i> Online</a>
            </div>
        </div>
        <!-- Sidebar Menu -->
        <ul class="sidebar-menu">
            <li class="header">HEADER</li>
            <!-- Optionally, you can add icons to the links -->
            <li class="active treeview">
                <a href="#">
                    <span>Clientes y Productos</span>
                    <span class="pull-right-container">
                        <i class="fa fa-angle-left pull-right"></i>
                    </span>
                </a>
                <ul class="treeview-menu">
                    <li>@Html.ActionLink("Artículos", "Index", "Home")</li>
                    <li>@Html.ActionLink("Servicios", "Index", "Home")</li>
                    <li>@Html.ActionLink("Clientes", "Cliente", "Cliente")</li>
                </ul>
            </li>
            <li class="treeview">
                <a href="#">
                    <span>Cotizaciones</span>
                    <span class="pull-right-container">
                        <i class="fa fa-angle-left pull-right"></i>
                    </span>
                </a>
                <ul class="treeview-menu">
                    <li>@Html.ActionLink("Pendientes", "Index", "Home")</li>
                    <li>@Html.ActionLink("Aprobadas", "Index", "Home")</li>
                    <li>@Html.ActionLink("Rechazadas", "Index", "Home")</li>
                    <li>@Html.ActionLink("Informes", "Index", "Home")</li>
                </ul>
            </li>
            <li class="treeview">
                <a href="#">
                    <span>Pedidos</span>
                    <span class="pull-right-container">
                        <i class="fa fa-angle-left pull-right"></i>
                    </span>
                </a>
                <ul class="treeview-menu">
                    <li>@Html.ActionLink("Pendientes", "Index", "Home")</li>
                    <li>@Html.ActionLink("Aprobadas", "Index", "Home")</li>
                    <li>@Html.ActionLink("Rechazadas", "Index", "Home")</li>
                    <li>@Html.ActionLink("Informes", "Index", "Home")</li>
                </ul>
            </li>
        </ul>
        <!-- /.sidebar-menu -->
    </section>
    <!-- /.sidebar -->
</aside>
<!-- Content Wrapper. Contains page content -->
<div class="content-wrapper" style="margin-top: 50px">
    <!-- Content Header (Page header) -->
    <section class="content-header">
        <h1>Cliente<small>Optional description</small></h1>
        <ol class="breadcrumb">
            <li>@Html.ActionLink("Inicio", "Index", "Home")</li>
            <li>Clientes y Productos</li>
            <li class="active">Index</li>
        </ol>
    </section>
    <!-- Main content -->
    <section class="content">
        <h1>Hola</h1>
    </section>
    <!-- /.content -->
</div>
<!-- /.content-wrapper -->