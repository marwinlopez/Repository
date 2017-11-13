@Code
    ViewData("Title") = "NuevoServicio"
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
                    <li>@Html.ActionLink("Artículos", "Articulo", "Ventas")</li>
                    <li class="active">@Html.ActionLink("Servicios", "Servicio", "Ventas")</li>
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
        <h1>Ficha de Servicio<small></small></h1>
        <ol class="breadcrumb">
            <li>@Html.ActionLink("Ventas", "Index", "Ventas")</li>
            <li>Clientes y Productos</li>
            <li class="active">Ficha de Servicio</li>
        </ol>
    </section>
    <!-- Main content -->
    <section class="content">
        <div class="row">
            <div class="col-xs-12">
                <div class="box box-primary">
                    <div class="box-header">
                        <div class="" style="width: 100%; background: #ececef; padding:5px 10px; margin-bottom: 30px; border-left: 2px solid #0094ff">
                            <h4 style="font-weight: bold">Información</h4>
                        </div>
                    </div>
                    <!-- /.box-header -->
                    <!-- form start -->
                    <form role="form" class="form-horizontal">
                        <div class="box-body">
                            <div class="row">
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label for="inputCodigo" class="col-sm-4 control-label">Código</label>
                                        <div class="col-sm-4" style="padding-right:0;">
                                            <input type="text" class="form-control" id="inputCodigo" placeholder="Código">
                                        </div>
                                        <button type="submit" class="btn btn-primary">...</button>
                                    </div>
                                    <div class="form-group">
                                        <label for="inputCodigo" class="col-sm-4 control-label">Descripción</label>
                                        <div class="col-sm-5">
                                            <input type="text" class="form-control" id="inputRut" placeholder="Descripción">
                                        </div>
                                    </div>
                                    <div class="form-group">
                                        <label for="inputNombre" class="col-sm-4 control-label">Descripción Detallada</label>
                                        <div class="col-sm-5">
                                            <textarea style="width:100%" class="form-control"></textarea>
                                        </div>
                                    </div>
                                    
                                </div>     
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label for="inputNombre" class="col-sm-4 control-label">Moneda de Venta</label>
                                        <div class="col-sm-2">
                                            <select class="form-control select2" style="width: 100%;">
                                                <option selected="selected">Seleccionar</option>
                                                <option>EURO</option>
                                                <option>PESO</option>
                                                <option>UF</option>
                                                <option>DOLAR</option>
                                            </select>
                                        </div>
                                    </div>
                                    <div class="form-group">
                                        <label for="inputNombre" class="col-sm-4 control-label">Precio de Venta</label>
                                        <div class="col-sm-2">
                                            <input type="text" class="form-control" id="inputRut" placeholder="0">
                                        </div>
                                    </div>
                                    <div class="form-group">
                                        <label for="inputNombre" class="col-sm-4 control-label">Costo Estándar</label>
                                        <div class="col-sm-2">
                                            <input type="text" class="form-control" id="inputRut" placeholder="0">
                                        </div>
                                    </div>
                                    <div class="form-group">
                                        <label for="inputNombre" class="col-sm-4 control-label">Tasa de Referencia</label>
                                        <div class="col-sm-2">
                                            <input type="text" class="form-control" id="inputRut" placeholder="1">
                                        </div>
                                    </div>
                                    <div class="form-group">
                                        <label for="inputNombre" class="col-sm-4 control-label">Unidad de Medida</label>
                                        <div class="col-sm-2">
                                            <input type="text" class="form-control" id="inputRut" placeholder="0">
                                        </div>
                                    </div>
                                </div>
                                <!-- /.box-body -->
                            </div>
                            
                            <div class="box-footer">
                                <button type="submit" class="btn btn-primary"><i class="glyphicon glyphicon-floppy-save"></i>@Html.ActionLink("Guardar", "NuevoCliente", "Ventas", New With {.style = "color:white; margin-left:5px"})</button>
                            </div>
                        </div>
                    </form>
                </div>
            </div>
        </div>
    </section>
    <!-- /.content -->
</div>
<!-- /.content-wrapper -->
@Section scripts
    <script>
        $(document).ready(function () {
            $('.select2').select2();
        });
    </script>
End Section