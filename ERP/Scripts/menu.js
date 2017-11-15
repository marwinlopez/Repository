$(document).ready(function () {
    var url = window.location.pathname;

    menu(url);

});
var menu = function (url) {
    items = url.split("/");
    if (items[1] === "") {
        $('#home').addClass('active');
    } else {
        $('#' + items[1].toLowerCase()).addClass('active');
        if (items.length > 2) {
            subMenu(items[2]);
        }
    }

}

var subMenu = function (subItem) {
    switch (subItem) {
        case "Articulo":
        case "NuevoArticulo":
            $('.cliente-producto').addClass('active');
            $('.' + subItem.toLowerCase()).addClass('active');
            break;
        case "Cliente":
        case "NuevoCliente":
            $('.cliente-producto').addClass('active');
            $('.' + subItem.toLowerCase()).addClass('active');
            break;
        case "Servicio":
        case "NuevoServicio":
            $('.cliente-producto').addClass('active');
            $('.' + subItem.toLowerCase()).addClass('active');
            break;
    }
}