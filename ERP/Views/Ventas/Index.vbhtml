@Code
    ViewData("Title") = "Index"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code
<!-- Left side column. contains the logo and sidebar -->
@Html.Partial("~/Views/Shared/_MenuVenta.vbhtml")
<!-- Content Wrapper. Contains page content -->
<div class="content-wrapper" style="margin-top: 50px">
    <!-- Content Header (Page header) -->
    <section class="content-header">
        <h1>Ventas<small>Optional description</small></h1>
        <ol class="breadcrumb">
            <li>@Html.ActionLink("Ventas", "Index", "Ventas")</li>
        </ol>
    </section>
    <!-- Main content -->
    <section class="content">
        
    </section>
    <!-- /.content -->
</div>
<!-- /.content-wrapper -->
@section scripts
    <script src="~/Scripts/menu.js"></script>
End Section