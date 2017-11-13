﻿<div class="row">
    <div class="col-md-12">
        <div class="" style="width: 100%; background: #ececef; padding:5px 10px; margin-bottom: 20px; border-left: 2px solid #0094ff">
            <h4 style="font-weight: bold">Sustituto</h4>
        </div>
        <div class="form-group">
            <label for="inputNombre" class="col-sm-2 control-label">Sustituto</label>
            <div class="col-sm-4">
                <select class="form-control select2" style="width: 100%;">
                    <option selected="selected">Seleccionar</option>
                </select>
            </div>
            <div class="col-sm-2">
                <button type="submit" class="btn btn-primary"><i class="glyphicon glyphicon-plus"></i>@Html.ActionLink("Agregar", "NuevoCliente", "Ventas", New With {.style = "color:white; margin-left:5px"})</button>
            </div>
        </div>
        <table id="example3" class="table table-bordered table-hover" width="100%">
            <thead>
                <tr class="bg-primary" style="text-align:center">
                    <th style="text-align:center; width: 20px">Nro</th>
                    <th style="text-align:center">Disponible</th>
                    <th style="text-align:center">Acción</th>
                </tr>
            </thead>
        </table>
    </div>
</div>

