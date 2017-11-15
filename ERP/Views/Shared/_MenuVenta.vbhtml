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
            <li class="treeview cliente-producto">
                <a href="">
                    <span>Clientes y Productos</span>
                    <span class="pull-right-container">
                        <i class="fa fa-angle-left pull-right"></i>
                    </span>
                </a>
                <ul class="treeview-menu">
                    <li class="articulo"><a href='@Url.Action("Articulo", "Ventas")'>Artículos</a></li>
                    <li class="servicio"><a href='@Url.Action("Servicio", "Ventas")'>Servicios</a></li>
                    <li class="cliente"><a href='@Url.Action("Cliente", "Ventas")'>Clientes</a></li>
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
                    <li><a href='@Url.Action("Index", "Home")'>Pendientes</a></li>
                    <li><a href='@Url.Action("Index", "Home")'>Aprobadas</a></li>
                    <li><a href='@Url.Action("Index", "Home")'>Rechazadas</a></li>
                    <li><a href='@Url.Action("Index", "Home")'>Informes</a></li>
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
                    <li><a href='@Url.Action("Index", "Home")'>Pendientes</a></li>
                    <li><a href='@Url.Action("Index", "Home")'>Aprobadas</a></li>
                    <li><a href='@Url.Action("Index", "Home")'>Rechazadas</a></li>
                    <li><a href='@Url.Action("Index", "Home")'>Informes</a></li>
                </ul>
            </li>
        </ul>
        <!-- /.sidebar-menu -->
    </section>
    <!-- /.sidebar -->
</aside>
