<div class="row">
    <div class="col-md-6">
        <div class="" style="width: 100%; background: #ececef; padding:5px 10px; margin-bottom: 10px; border-left: 2px solid #0094ff">
            <h4 style="font-weight: bold">Identificación</h4>
        </div>
        <div class="content">
            <div class="form-group">
                <label for="inputCodigo" class="col-sm-4 control-label">Código</label>
                <div class="col-sm-8">
                    <input type="text" class="form-control" id="inputCodigo" placeholder="Código">
                </div>
            </div>
            <div class="form-group">
                <label for="inputCodigo" class="col-sm-4 control-label">Descripción</label>
                <div class="col-sm-8">
                    <input type="text" class="form-control" id="inputRut" placeholder="RUT">
                </div>
            </div>
            <div class="form-group">
                <label for="inputNombre" class="col-sm-4 control-label">Descripción Detallada</label>
                <div class="col-sm-8">
                    <textarea style="width:100%" class="form-control"></textarea>
                </div>
            </div>
            <div class="form-group">
                <label for="inputNombreFantasia" class="col-sm-4 control-label">Comentario</label>
                <div class="col-sm-8">
                    <textarea style="width:100%" class="form-control"></textarea>
                </div>
            </div>
        </div>
        <div class="" style="width: 100%; background: #ececef; padding:5px 10px; margin-bottom: 10px; border-left: 2px solid #0094ff">
            <h4 style="font-weight: bold">Ventas</h4>
        </div>
        <div class="content">
            <div class="form-group">
                <label for="inputSigla" class="col-sm-4 control-label">Disponible para la Venta</label>
                <div class="col-sm-6 checkbox">
                    <input type="checkbox" style="margin-left: 1px" checked>
                </div>
            </div>
            <div class="form-group">
                <label for="inputNombre" class="col-sm-4 control-label">Moneda de Venta</label>
                <div class="col-sm-8">
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
                <label for="inputNombre" class="col-sm-4 control-label">Unidad de Medida de Venta</label>
                <div class="col-sm-8">
                    <select class="form-control select2" style="width: 100%;">
                        <option selected="selected">Seleccionar</option>
                        <option>Gramos</option>
                        <option>Kilo</option>
                        <option>Litro</option>
                        <option>Metro</option>
                        <option>Unidad</option>
                    </select>
                </div>
            </div>
            <div class="form-group">
                <label for="inputSigla" class="col-sm-4 control-label">Impuesto especifico adicional</label>
                <div class="col-sm-6 checkbox">
                    <input type="checkbox" id="impuestoAdicional" style="margin-left: 1px">
                </div>
            </div>
            <div id="impuesto" class="form-group" style="display:none">
                <label for="inputTeléfonoCelular" class="col-sm-4 control-label">Impuesto</label>
                <div class="col-sm-8">
                    <select class="form-control select2" style="width: 100%;">
                        <option>IMTO ESPECIFICO</option>
                        <option>IVA</option>
                    </select>
                </div>
            </div>
            <div class="form-group">
                <label for="inputDirección" class="col-sm-4 control-label">Factor Especifico</label>
                <div class="col-sm-8">
                    <input type="text" class="form-control" id="inputDirección" placeholder="0">
                </div>
            </div>
            <div class="form-group">
                <label for="inputDirección" class="col-sm-4 control-label">Precio de Venta</label>
                <div class="col-sm-8">
                    <input type="text" class="form-control" id="inputDirección" placeholder="0">
                </div>
            </div>
            <div class="form-group">
                <div class="col-sm-12">
                    <div class="radio">
                        <label style="font-weight:bold"><input id="radio1" type="radio" name="optradio" checked> Cálculo de Precio de ventas a partir del margen con respecto al costo promedio vigente:</label>
                    </div>
                </div>
            </div>
            <div class="form-group">
                <div class="col-sm-12">
                    <div class="radio">
                        <label style="font-weight:bold"><input id="radio2" type="radio" name="optradio">Cálculo de margen a partir del precio de ventas con respecto al costo promedio vigente:</label>
                    </div>
                </div>
            </div>
            <div class="form-group">
                <label for="inputMargen" class="col-sm-4 control-label">Margen</label>
                <div class="col-sm-8">
                    <input type="text" class="form-control" id="inputDirección" placeholder="0">
                </div>
            </div>
            <div class="form-group">
                <label for="inputPrecio" class="col-sm-4 control-label">Precio de Venta</label>
                <div class="col-sm-8">
                    <input type="text" class="form-control" id="inputDirección" placeholder="0">
                </div>
            </div>
        </div>
    </div>
    <div class="col-md-6">
        <div class="" style="width: 100%; background: #ececef; padding:5px 10px; margin-bottom: 10px; border-left: 2px solid #0094ff">
            <h4 style="font-weight: bold">Stock</h4>
        </div>
        <div class="content">
            <div class="form-group">
                <label for="inputCodigo" class="col-sm-4 control-label">Saldo Disponible para la Venta</label>
                <div class="col-sm-8">
                    <input type="text" class="form-control" id="inputCodigo" placeholder="0">
                </div>
            </div>
            <div class="form-group">
                <label for="inputCodigo" class="col-sm-4 control-label">Saldo de Stock</label>
                <div class="col-sm-8">
                    <input type="text" class="form-control" id="inputRut" placeholder="0">
                </div>
            </div>
            <div class="form-group">
                <label for="inputNombre" class="col-sm-4 control-label">Fecha de Actualización</label>
                <div class="col-sm-8">
                    <input type="text" class="form-control" id="inputRut" placeholder="">
                </div>
            </div>
            <div class="form-group">
                <label for="inputNombreFantasia" class="col-sm-4 control-label">Pendiente de entrega</label>
                <div class="col-sm-8">
                    <label class="control-label">0</label>   
                </div>
            </div>
            <div class="form-group">
                <label for="inputNombreFantasia" class="col-sm-4 control-label">Pendiente de recepción</label>
                <div class="col-sm-8">
                    <label class="control-label">0</label>
                </div>
            </div>
            <div class="form-group">
                <label for="inputNombreFantasia" class="col-sm-4 control-label">Disponible futuro</label>
                <div class="col-sm-8">
                    <label class="control-label">0</label>
                </div>
            </div>
            <div class="form-group">
                <label for="inputNombreFantasia" class="col-sm-4 control-label">Fecha de próxima recepción</label>
                <div class="col-sm-8">
                    <label class="control-label">0</label>
                </div>
            </div>
        </div>
        <div class="" style="width: 100%; background: #ececef; padding:5px 10px; margin-bottom: 10px; border-left: 2px solid #0094ff">
            <h4 style="font-weight: bold">Costos</h4>
        </div>
        <div class="content">
            <div class="form-group">
                <label for="inputNombreFantasia" class="col-sm-4 control-label">Costo Promedio</label>
                <div class="col-sm-8">
                    <label class="control-label">0</label>
                </div>
            </div>
            <div class="form-group">
                <label for="inputCodigo" class="col-sm-4 control-label">Costo de reposición</label>
                <div class="col-sm-8">
                    <input type="text" class="form-control" id="inputCodigo" placeholder="0">
                </div>
            </div>
        </div>
        <div class="" style="width: 100%; background: #ececef; padding:5px 10px; margin-bottom: 10px; border-left: 2px solid #0094ff">
            <h4 style="font-weight: bold">Factura de Compra Electrónica</h4>
        </div>
        <div class="content">
            <div class="col-sm-8">
                <select class="form-control select2" style="width: 100%;">
                    
                </select>
            </div>
        </div>
    </div>
</div>
