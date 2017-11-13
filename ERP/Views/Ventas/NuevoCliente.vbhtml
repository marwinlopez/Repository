@Code
    ViewData("Title") = "Index"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code
<!-- Left side column. contains the logo and sidebar -->
@Html.Partial("~/Views/Shared/_MenuCliente.vbhtml")
<!-- Content Wrapper. Contains page content -->
<div class="content-wrapper" style="margin-top: 50px">
    <!-- Content Header (Page header) -->
    <section class="content-header">
        <h1>Ficha de Cliente Ventas<small></small></h1>
        <ol class="breadcrumb">
            <li>@Html.ActionLink("Ventas", "Index", "Ventas")</li>
            <li>Clientes y Productos</li>
            <li class="active">Ficha de Cliente Ventas</li>
        </ol>
    </section>
    <!-- Main content -->
    <section class="content">
        <div class="row">
            <div class="col-xs-12">
                <div class="box box-primary">
                    <div class="box-header">
                        <ul class="nav nav-pills nav-justified">
                            <li class="active"><a data-toggle="tab" href="#informacion"><h5>Información</h5></a></li>
                            <li><a data-toggle="tab" href="#venta"><h5>Venta</h5></a></li>
                        </ul>
                    </div>
                    <!-- /.box-header -->
                    <!-- form start -->
                    <form role="form" class="form-horizontal">
                        <div class="box-body" style="height:480px;">
                            <div class="tab-content">
                                <div id="informacion" class="tab-pane fade in active">
                                    @Html.Partial("_PartialClienteInformacion")
                                </div>
                                <div id="venta" class="tab-pane fade">
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
@Section scripts
    <script>
        $(document).ready(function () {
            $('.select2').select2();
        });
    </script>
End Section