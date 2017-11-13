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
               
                <!-- nav-tabs-custom -->
                <div class="box box-primary">
                    <div class="box-header">
                        <ul class="nav nav-tabs nav-justified">
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
                        <div class="box-body">
                            <div class="tab-content">
                                <div id="ficha" class="tab-pane fade in active">
                                    @Html.Partial("~/Views/Shared/Articulos/_PartialFicha.vbhtml")
                                </div>
                                <div id="atributo" class="tab-pane fade">
                                    @Html.Partial("~/Views/Shared/Articulos/_PartialAtributo.vbhtml")
                                </div>
                                <div id="sustituto" class="tab-pane fade">
                                    @Html.Partial("~/Views/Shared/Articulos/_PartialSustituto.vbhtml")
                                </div>
                                <div id="unidad" class="tab-pane fade">
                                    @Html.Partial("~/Views/Shared/Articulos/_PartialUnidad.vbhtml")
                                </div>
                                <div id="propiedad" class="tab-pane fade">
                                    @Html.Partial("~/Views/Shared/Articulos/_PartialPropiedades.vbhtml")
                                </div>
                            </div>
                        </div>
                        <!-- /.box-body -->
                        <div class="box-footer">
                            <button type="submit" class="btn btn-primary"><i class="glyphicon glyphicon-floppy-save"></i>@Html.ActionLink("Guardar", "NuevoCliente", "Ventas", New With {.style = "color:white; margin-left:5px"})</button>
                            <button type="submit" class="btn btn-primary"><i class="glyphicon glyphicon-adjust"></i>@Html.ActionLink("Adjuntar Archivo", "NuevoCliente", "Ventas", New With {.style = "color:white; margin-left:5px"})</button>
                            <button type="submit" class="btn btn-primary"><i class="glyphicon glyphicon-download"></i>@Html.ActionLink("Documentos Asociados", "NuevoCliente", "Ventas", New With {.style = "color:white; margin-left:5px"})</button>
                            <button type="submit" class="btn btn-primary"><i class="glyphicon glyphicon-print"></i>@Html.ActionLink("Imprimir", "NuevoCliente", "Ventas", New With {.style = "color:white; margin-left:5px"})</button>
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
<script src="~/Scripts/DataTables/jquery.dataTables.min.js"></script>
<script src="~/Scripts/DataTables/dataTables.bootstrap.min.js"></script>
<script>
    $('#example2, #example3').DataTable({
        "ajax": {
            "url": "/Ventas/DataArticulo",
            "dataSrc": ""
        },
        "columns": [
            { "data": "Codigo" },
            { "data": "Nombre" },
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
            "sEmptyTable": "No se han encontrado datos, por favor haga clic en el botón <b>Agregar</b>",
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

    $('#tablePropiedades').DataTable({
        "ajax": {
            "url": "/Ventas/DataArticulo",
            "dataSrc": ""
        },
        "columns": [
            { "data": "Codigo" },
            { "data": "Nombre" },
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
            "sEmptyTable": "<b>No existen elementos definidos en configuración de artículos</b>",
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
    <script>
        $(document).ready(function () {
            $('.select2').select2();
        });
        $('#impuestoAdicional').click(function () {
            if ($(this).is(':checked')) {
                $('#impuesto').show();
            } else {
                $('#impuesto').hide();
            }
        });
        $("#radio1").click(function () {
            $("label[for = inputPrecio]").text("Precio de Venta");
            $("label[for = inputMargen]").text("Margen");
        });
        $("#radio2").click(function () {
            $("label[for = inputMargen]").text("Precio de Venta");
            $("label[for = inputPrecio]").text("Margen");
        });
    </script>
End Section
