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
            <li class="header">Menú</li>
            <!-- Optionally, you can add icons to the links -->
            <li class="treeview">
                <a href="#">
                    <span>Administración</span>
                    <span class="pull-right-container">
                        <i class="fa fa-angle-left pull-right"></i>
                    </span>
                </a>
                <ul class="treeview-menu">
                    <li>@Html.ActionLink("Administración de Usuarios", "Index", "Home")</li>
                    <li>@Html.ActionLink("Administración de Grupos", "Index", "Home")</li>
                    <li>@Html.ActionLink("Solicitud de Upgrade", "Cliente", "Cliente")</li>
                    <li>@Html.ActionLink("Menú de herramientas", "Cliente", "Cliente")</li>
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
        <h1>Dashboard<small>Optional description</small></h1>
        <ol class="breadcrumb">
            <li class="active">@Html.ActionLink("Inicio", "Index", "Home")</li>
        </ol>
    </section>
    <!-- Main content -->
    <section class="content">
        
    </section>
    <!-- /.content -->
</div>
<!-- /.content-wrapper -->