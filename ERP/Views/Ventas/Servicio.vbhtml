@Code
    ViewData("Title") = "Servicio"
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
        <h1>Listado de Servicios<small></small></h1>
        <ol class="breadcrumb">
            <li>@Html.ActionLink("Ventas", "Index", "Ventas")</li>
            <li>Clientes y Productos</li>
            <li class="active">Listado de Servicios</li>
        </ol>
    </section>
    <!-- Main content -->
    <section class="content">
        <div class="row">
            <div class="col-xs-12">
                <div class="box">
                    <div class="box-header">
                        <h3 class="box-title"><button class="btn btn-success" type="submit">@Html.ActionLink("Nuevo Servicio", "NuevoServicio", "Ventas", New With {.style = "color:white;"})</button></h3>
                    </div>
                    <!-- /.box-header -->
                    <div class="box-body">
                        <table id="example2" class="table table-bordered table-hover">
                            <thead>
                                <tr class="bg-primary" style="text-align:center">
                                    <th style="text-align:center">Código</th>
                                    <th style="text-align:center">Descripción</th>
                                    <th style="text-align:center">Precio</th>
                                    <th style="text-align:center">Acción</th>
                                </tr>
                            </thead>
                        </table>
                    </div>
                    <!-- /.box-body -->
                </div>
            </div>
        </div>
    </section>
    <!-- /.content -->
</div>
<!-- /.content-wrapper -->
@section scripts
    <script src="~/Scripts/DataTables/jquery.dataTables.min.js"></script>
    <script src="~/Scripts/DataTables/dataTables.bootstrap.min.js"></script>
    <script>
    $('#example2').DataTable({
        "ajax": {
            "url": "/Ventas/DataArticulo",
            "dataSrc": ""
        },
        "columns": [
            { "data": "Codigo" },
            { "data": "Nombre" },
            { "data": "Saldo" },
            {
                "data": "Id", "render": function () {
                    return "<a href='@Url.Action("", "")' class='btn btn-warning btn-sm'><i class='fa fa-pencil'></i> Edit</a><a href='@Url.Action("", "")' class='btn btn-danger btn-sm' style='margin-left:5px; margin-rigth:0'><i class='fa fa-trash'></i> Eliminar</a>"
            },
                "orderable": false,
                "width": "140px"
            }
        ],
        "language": {
            "sProcessing": "Procesando...",
            "sLengthMenu": "Mostrar _MENU_ registros",
            "sZeroRecords": "No se encontraron resultados",
            "sEmptyTable": "No se han encontrado datos, por favor haga clic en el botón <b>Nuevo Servicio</b>",
            "sInfo": "Mostrando registros del _START_ al _END_ de un total de _TOTAL_ registros",
            "sInfoEmpty": "Mostrando registros del 0 al 0 de un total de 0 registros",
            "sInfoFiltered": "(filtrado de un total de _MAX_ registros)",
            "sInfoPostFix": "",
            "sSearch": "Buscar:",
            "sUrl": "",
            "sInfoThousands": ",",
            "sLoadingRecords": "Cargando...",
            "oPaginate": {
                "sFirst": "Primero",
                "sLast": "Último",
                "sNext": "Siguiente",
                "sPrevious": "Anterior"
            },
            "oAria": {
                "sSortAscending": ": Activar para ordenar la columna de manera ascendente",
                "sSortDescending": ": Activar para ordenar la columna de manera descendente"
            }
        }
    });
    </script>
End Section
