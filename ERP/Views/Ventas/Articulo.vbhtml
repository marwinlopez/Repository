@Code
    ViewData("Title") = "Articulo"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<!-- Left side column. contains the logo and sidebar -->
@Html.Partial("~/Views/Shared/_MenuVenta.vbhtml")
<!-- Content Wrapper. Contains page content -->
<div class="content-wrapper" style="margin-top: 50px">
    <!-- Content Header (Page header) -->
    <section class="content-header">
        <h1>Listado de Artículos<small></small></h1>
        <ol class="breadcrumb">
            <li>@Html.ActionLink("Ventas", "Index", "Ventas")</li>
            <li>Clientes y Productos</li>
            <li class="active">Listado de Artículos</li>
        </ol>
    </section>
    <!-- Main content -->
    <section class="content">
        <div class="row">
            <div class="col-xs-12">
                <div class="box">
                    <div class="box-header">
                        <h3 class="box-title"><a href='@Url.Action("NuevoArticulo", "Ventas")' class="btn btn-success">Nuevo Artículo</a></h3>
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
    <script src="~/Scripts/menu.js"></script>
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
            "sEmptyTable": "No se han encontrado datos, por favor haga clic en el botón <b>Nuevo Artículo</b>",
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
