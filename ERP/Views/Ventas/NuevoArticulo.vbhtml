@Code
    ViewData("Title") = "NuevoArticulo"
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
            <li class="header">Menú </li>
            <!-- Optionally, you can add icons to the links -->
            <li class="active treeview">
                <a href="">
                    <span>Clientes y Productos</span>
                    <span class="pull-right-container">
                        <i class="fa fa-angle-left pull-right"></i>
                    </span>
                </a>
                <ul class="treeview-menu">
                    <li class="active">@Html.ActionLink("Artículos", "Articulo", "Ventas")</li>
                    <li>@Html.ActionLink("Servicios", "Servicio", "Ventas")</li>
                    <li>@Html.ActionLink("Clientes", "Cliente", "Ventas")</li>
                </ul>
            </li>
            <li class="treeview">
                <a href="">
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
                <a href="">
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
        <h1>Ficha de Artículos<small></small></h1>
        <ol class="breadcrumb">
            <li>@Html.ActionLink("Ventas", "Index", "Ventas")</li>
            <li>Clientes y Productos</li>
            <li class="active">Ficha de Artículos</li>
        </ol>
    </section>
    <!-- Main content -->
    <section class="content">
        <div class="row">
            <div class="col-xs-12">
                <div class="box box-primary">
                    <div class="box-header">
                        <ul class="nav nav-pills nav-justified">
                            <li class="active"><a data-toggle="tab" href="#ficha"><h5>Ficha</h5></a></li>
                            <li><a data-toggle="tab" href="#atributo"><h5>Atributo</h5></a></li>
                            <li><a data-toggle="tab" href="#sustituto"><h5>Sustituto</h5></a></li>
                            <li><a data-toggle="tab" href="#unidad"><h5>Unidad</h5></a></li>
                            <li><a data-toggle="tab" href="#propiedad"><h5>Propiedades</h5></a></li>
                        </ul>
                    </div>
                    <!-- /.box-header -->
                    <!-- form start -->
                    <form role="form" class="form-horizontal">
                        <div class="box-body" style="height:450px;">
                            <div class="tab-content">
                                <div id="ficha" class="tab-pane fade in active">
                                    @Html.Partial("_PartialClienteInformacion")
                                </div>
                                <div id="atributo" class="tab-pane fade">
                                    @Html.Partial("_PartialClienteVenta")
                                </div>
                                <div id="sustituto" class="tab-pane fade">
                                    @Html.Partial("_PartialClienteVenta")
                                </div>
                                <div id="unidad" class="tab-pane fade">
                                    @Html.Partial("_PartialClienteVenta")
                                </div>
                                <div id="propiedad" class="tab-pane fade">
                                    @Html.Partial("_PartialClienteVenta")
                                </div>
                            </div>
                        </div>
                        <!-- /.box-body -->
                        <div class="box-footer">
                            <button type="submit" class="btn btn-primary"><i class="glyphicon glyphicon-floppy-save"></i>@Html.ActionLink("Guardar", "NuevoCliente", "Ventas", New With {.style = "color:white; margin-left:5px"})</button>
                        </div>
                    </form>
                </div>
            </div>
        </div>
    </section>
    <!-- /.content -->
</div>
<!-- /.content-wrapper -->
