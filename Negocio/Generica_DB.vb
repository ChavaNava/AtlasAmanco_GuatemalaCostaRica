Imports System.Data.SqlClient
Imports SQL_DATA
Imports Atlas.Accesos.CLVarGlobales
Public Class Generica_DB
#Region "Variables Miembro"
    'Con_Resumen_Produccion
    Dim Count As Integer
    Dim DGV_OrdenProduccion As String
    Dim DGV_Equipo As String
    Dim DGV_Producto As String
    Dim DGV_Tramos As Decimal
    Dim DGV_PN As Decimal
    Dim DGV_PT As Decimal
    Dim DGV_SP As Decimal
    Dim DGV_PNS As Decimal
    Dim DGV_SC As Decimal

    Dim DGV2_Equipo As String
    Dim DGV2_Tramos As Decimal
    Dim DGV2_PN As Decimal
    Dim DGV2_PT As Decimal
    Dim DGV2_SP As Decimal
    Dim DGV2_PNS As Decimal
    Dim DGV2_SC As Decimal

    Dim Programado As Integer
    Dim Pzas_Entregado As Integer
    Dim Pzas_Proceso As Integer
    Dim Kilos_Entregado As Decimal
    Dim Kilos_Proceso As Decimal
    Dim Kilos_Terminado As String
    Dim Kilos_Teoricos As String
#End Region

    Public Function Insert_ODF(ByVal strOrdenProd As String, ByVal Centro As String, ByVal Equipo As String, _
                                ByVal Producto As String, ByVal Cantidad_Programada_Tramos As String, _
                                ByVal Fecha_Inicio As String, ByVal Fecha_Termino As String, _
                                ByVal Origen_Informacion As String, ByVal Estatus_Activa As String, _
                                ByVal Usuario_Actualiza As String, ByVal Fecha_Actualizacion As String, _
                                ByVal Observaciones As String, ByVal ObservacFecha_Inicio_Produccioniones As String, _
                                ByVal Hora_Inicio_Produccion As String, ByVal Usuario_Registra_Inicio As String, _
                                ByVal Fecha_Terminacion As String, ByVal Hora_Terminacion As String, _
                                ByVal Usuario_Registra_Terminacion As String, ByVal usuarioreg As String, _
                                ByVal fechareg As String, ByVal horareg As String, ByVal GrupMaterial As String) As Integer


        Dim query As String = ""
        Dim rows As Integer = 0

        query = "INSERT INTO " & Centro.Trim & "_OrdenProduccion(Orden_Produccion,Planta,Equipo_Basico,Producto, " _
                        + "Cantidad_Programada_Tramos,Fecha_Inicio,Fecha_Termino,Origen_Informacion,Estatus_Activa," _
                        + "Usuario_Actualiza,Fecha_Actualizacion,Observaciones,Fecha_Inicio_Produccion," _
                        + "Hora_Inicio_Produccion,Usuario_Registra_Inicio,Fecha_Terminacion,Hora_Terminacion," _
                        + "Usuario_Registra_Terminacion,usuarioreg,fechareg,Horareg,GrupMaterial) " _
                        + "VALUES('" & strOrdenProd & "'," _
                        + " '" + Centro + "', " _
                        + " '" + Equipo + "', " _
                        + " '" + Producto + "', " _
                        + " '" + Cantidad_Programada_Tramos + "', " _
                        + " '" + Fecha_Inicio + "', " _
                        + " '" + Fecha_Termino + "', " _
                        + " '" + Origen_Informacion + " ', " _
                        + " '" + Estatus_Activa + "', " _
                        + " '" + Usuario_Actualiza.Trim + "', " _
                        + " '" + Fecha_Actualizacion + "', " _
                        + " '" + Observaciones + "', " _
                        + " '" + ObservacFecha_Inicio_Produccioniones + "', " _
                        + " '" + Hora_Inicio_Produccion + "', " _
                        + " '" + Usuario_Registra_Inicio.Trim + "', " _
                        + " '" + Fecha_Terminacion + "', " _
                        + " '" + Hora_Terminacion + "', " _
                        + " '" + Usuario_Registra_Terminacion.Trim + "', " _
                        + " '" + usuarioreg + "', " _
                        + " '" + fechareg + "', " _
                        + " '" + horareg + "', " _
                        + " '" + GrupMaterial.Trim + "' " _
                        + ")"
        LecturaQry(query)
        Return rows
    End Function

    Public Function Update_ODF(ByVal strOrdenProd As String, ByVal Centro As String, ByVal Equipo As String, _
                                ByVal Producto As String, ByVal Cantidad_Programada_Tramos As String, _
                                ByVal Fecha_Inicio As String, ByVal Fecha_Termino As String) As Integer

        Dim query As String = ""
        Dim rows As Integer = 0

        query = "Update " & Centro.Trim & "_OrdenProduccion Set Equipo_Basico = '" + Equipo.Trim + "' , " _
                + "Producto = '" + Producto.Trim + "', " _
                + "Cantidad_Programada_Tramos = '" + Cantidad_Programada_Tramos.Trim + "', " _
                + "Fecha_Inicio = '" + Fecha_Inicio.Trim + "', " _
                + "Fecha_Termino = '" + Fecha_Termino.Trim + "' " _
                + "Where Orden_Produccion = '" + strOrdenProd.Trim + "' " _
                + "And Planta = '" + Centro.Trim + "' "
        Try
            LecturaQry(query)
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.Critical)
        End Try
        Return rows
    End Function

    Public Function Insert_Lista_Materiales(ByVal ODF As String, ByVal Centro As String, ByVal matnr As String, _
                                            ByVal dmatnr As String, ByVal lgort As String, ByVal erfmg As String, _
                                            ByVal erfme As String, ByVal charg As String) As Integer
        Dim query As String = ""
        Dim rows As Integer = 0

        query = "INSERT INTO " & Centro.Trim & "_Lista_Materiales(Orden_Produccion,Centro,matnr,lgort,erfmg," _
                        + "erfme,charg) " _
                        + "VALUES('" & ODF & "'," _
                        + " '" + Centro + "', " _
                        + " '" + matnr + "', " _
                        + " '" + dmatnr + "', " _
                        + " '" + lgort + "', " _
                        + " '" + erfmg + "', " _
                        + " '" + erfme + "', " _
                        + " '" + charg + "' " _
                        + ")"
        LecturaQry(query)
        Return rows
    End Function

    Public Function Insert_Notificacion(ByVal ODF As String, ByVal Fecha_Pesaje As String, ByVal Hora_Pesaje As String, _
                                        ByVal Bascula As String, ByVal Rack As String, ByVal Peso_Bruto As String, _
                                        ByVal Tara As String, ByVal Peso_Neto As String, ByVal Empaques As String, _
                                        ByVal Tramos As String, ByVal Usuario As String, ByVal Turno As String, _
                                        ByVal Supervisor As String, ByVal Planta As String, _
                                        ByVal Fecha_Turno As String, ByVal Sobrepeso As String, _
                                        ByVal CausaSobrepeso As String, ByVal PuestoTrabajo As String, _
                                        ByVal Peso_teorico As String, ByVal Area As String, _
                                        ByVal ST_Sp As String, ByVal Comp1 As String, ByVal Porc1 As String, _
                                        ByVal cant1 As String, ByVal comp2 As String, ByVal porc2 As String, _
                                        ByVal cant2 As String) As String

        Dim query As String = ""
        Dim rows As Integer = 0

        query = "INSERT INTO " & Planta.Trim & "_PesoProductoTerminado(Orden_Produccion,Fecha_Pesaje,Hora_Pesaje," _
                + "Bascula,Rack,Peso_Bruto,Tara,Peso_Neto,Empaques,Tramos,Usuario,Turno,Supervisor,Planta," _
                + "Fecha_Turno,Sobrepeso,CausaSobrepeso,PuestoTrabajo," _
                + "Peso_teorico,Area,St_Sobrepeso,Compuesto1,Porcentaje1,Cant_1,Compuesto2,Porcentaje2,Cant_2) " _
                + "VALUES('" & ODF & "'," _
                + " '" + Fecha_Pesaje + "', " _
                + " '" + Hora_Pesaje + "', " _
                + " '" + Bascula + "', " _
                + " '" + Rack + "', " _
                + " '" + Peso_Bruto + "', " _
                + " '" + Tara + "', " _
                + " '" + Peso_Neto + "', " _
                + " '" + Empaques + "', " _
                + " '" + Tramos + "', " _
                + " '" + Usuario + "', " _
                + " '" + Turno + "', " _
                + " '" + Supervisor + "', " _
                + " '" + Planta + "', " _
                + " '" + Fecha_Turno + "', " _
                + " '" + Sobrepeso + "', " _
                + " '" + CausaSobrepeso + "', " _
                + " '" + PuestoTrabajo.Trim + "', " _
                + " '" + Peso_teorico + "', " _
                + " '" + Area + "', " _
                + " '" + ST_Sp + "', " _
                + " '" + Comp1 + "', " _
                + " '" + Porc1 + "', " _
                + " '" + cant1 + "', " _
                + " '" + comp2 + "', " _
                + " '" + porc2 + "', " _
                + " '" + cant2 + "' " _
                + ")"
        Try
            LecturaQry(query)
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.Critical)
        End Try
        Return rows
    End Function

    Public Function Update_Notificacion(ByVal Centro As String, ByVal Reg As String, ByVal Documento_SAP As String, ByVal Consecutivo_SAP As String, _
                                    ByVal Folio As String, ByVal Tipo As String, ByVal Msg As String) As String
        Dim query As String = ""
        Dim rows As Integer = 0

        query = "Update " & Centro.Trim & "_PesoProductoTerminado Set Notifica = '" + Reg.Trim + "' , " _
        + "Documento_SAP = '" + Documento_SAP.Trim + "', " _
        + "Consecutivo_SAP = '" + Consecutivo_SAP.Trim + "', " _
        + "Tipo_PT = '" + Tipo.Trim + "', " _
        + "MsgSAP = '" + Msg.Trim + " ' " _
        + "Where Folio = '" + Folio.Trim + "' "
        Try
            LecturaQry(query)
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.Critical)
        End Try
        MsgBox("Notificación Exitosa", MsgBoxStyle.Information)
        Return rows
    End Function

    Public Function Insert_Scrap(ByVal Centro As String, ByVal ODF As String, ByVal Fecha_Pesaje As String, ByVal Hora_Pesaje As String, _
                                 ByVal Bascula As String, ByVal Tipo_Scrap As String, ByVal Peso_Bruto As String, _
                                 ByVal Tara As String, ByVal Peso_Neto As String, ByVal Usuario As String, _
                                 ByVal Turno As String, ByVal Causa As String, ByVal Rack As String, _
                                 ByVal Efecto As String, ByVal Fecha_Turno As String, ByVal PuestoTrabajo As String, _
                                 ByVal Area As String, ByVal Comp1 As String, ByVal Porc1 As String, _
                                 ByVal cant1 As String, ByVal comp2 As String, ByVal porc2 As String, _
                                 ByVal cant2 As String) As String
        Dim query As String = ""
        Dim rows As Integer = 0

        query = "INSERT INTO " & Centro.Trim & "_PesoScrap(Orden_Produccion,Fecha_Pesaje,Hora_Pesaje," _
                + "Bascula,Tipo_Scrap,Peso_Bruto,Tara,Peso_Neto,Usuario,Turno,Causa,Rack,Efecto," _
                + "Fecha_Turno,PuestoTrabajo,Area,Compuesto1,Porcentaje1,Cant_1,Compuesto2,Porcentaje2,Cant_2)" _
        + "VALUES('" & ODF & "'," _
        + " '" + Fecha_Pesaje + "', " _
        + " '" + Hora_Pesaje + "', " _
        + " '" + Bascula + "', " _
        + " '" + Tipo_Scrap + "', " _
        + " " + Peso_Bruto + ", " _
        + " " + Tara + ", " _
        + " " + Peso_Neto + ", " _
        + " '" + Usuario + "', " _
        + " '" + Turno + "', " _
        + " '" + Causa + "', " _
        + " '" + Rack + "', " _
        + " '" + Efecto + "', " _
        + " '" + Fecha_Turno + "', " _
        + " '" + PuestoTrabajo + "', " _
        + " '" + Area + "', " _
        + " '" + Comp1 + "', " _
        + " '" + Porc1 + "', " _
        + " '" + cant1 + "', " _
        + " '" + comp2 + "', " _
        + " '" + porc2 + "', " _
        + " '" + cant2 + "' " _
        + ")"
        Try
            LecturaQry(query)
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.Critical)
        End Try
        Return rows
    End Function

    Public Function Update_Scrap(ByVal Reg As String, ByVal Documento_SAP As String, ByVal Consecutivo_SAP As String, _
                                    ByVal Folio As String, ByVal Tipo As String, ByVal Mns As String) As String
        Dim query As String = ""
        Dim rows As Integer = 0

        query = "Update " & SessionUser._sCentro.Trim & "_PesoScrap Set Notifica = '" + Reg.Trim + "' , " _
        + "Documento_SAP = '" + Documento_SAP.Trim + "', " _
        + "Consecutivo_SAP = '" + Consecutivo_SAP.Trim + "', " _
        + "Tipo_Scrap = '" + Tipo.Trim + "', " _
        + "MsgSAP = '" + Mns.Trim + "' " _
        + "Where Folio = '" + Folio.Trim + "' "
        Try
            LecturaQry(query)
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.Critical)
        End Try
        If rows > 0 Then
            MsgBox("Notificación Exitosa", MsgBoxStyle.Information)
        End If
        Return rows
    End Function

    Public Sub Catalogo_Usuarios(ByVal DataGV As DataGridView)
        Try
            objDa = New SqlDataAdapter("SP_Consulta_Catalogo_Usuarios '" & SessionUser._sCentro.Trim & "' ", AbrirConfiguracion)
            objDs = New DataSet
            objDa.Fill(objDs)
            DataGV.DataSource = objDs.Tables(0)

        Catch ex As Exception
            MessageBox.Show("Error Conexion :" & ex.Message, "ORDENES PROCESO")
        End Try
        DataGV.Columns(0).HeaderText = "Alias Usuario"
        DataGV.Columns(1).HeaderText = "Clave de Acceso"
        DataGV.Columns(2).HeaderText = "Nombre Usuario"
        DataGV.Columns(3).HeaderText = "Numero de Empleado"
        DataGV.Columns(4).HeaderText = "Perfil"
        DataGV.Columns(5).HeaderText = "Descripción Perfil"
        DataGV.Columns(6).HeaderText = "E-mail"
        DataGV.Columns(7).HeaderText = "Telefono Fijo"
        DataGV.Columns(8).HeaderText = "Telefono Movil"
        DataGV.Columns(9).HeaderText = "Modulo"
        DataGV.Columns(10).HeaderText = "Status"
    End Sub


    Public Sub Parametros(ByVal Frm As Form, DataGV As DataGridView)
        Try
            objDa = New SqlDataAdapter("PA_Parametros ", AbrirConfiguracion)
            objDs = New DataSet
            objDa.Fill(objDs)
            DataGV.DataSource = objDs.Tables(0)
        Catch ex As Exception
            MessageBox.Show("Error Conexion :" & ex.Message, "ORDENES PROCESO")
        End Try
        DataGV.Columns(0).HeaderText = "Id"
        DataGV.Columns(1).Visible = False       'Nombre Form
        DataGV.Columns(2).HeaderText = "Proceso"
        DataGV.Columns(3).HeaderText = "Estatus"

        LecturaBD.Close()
    End Sub

    Public Sub Consulta_Prd_Comp(ByVal C_Producto As String, ByVal DataGV As DataGridView)
        QRY_Grid = ""
        NameTable = ""
        NameTable = "CatalogoCompuestos"
        QRY_Grid = "Select a.C_Material,a.C_Compuesto,b.Descripcion,a.UM_Compuesto,a.C_Clase,c.Nombre_ClaseCompuesto,a.C_Tipo,a.Bom,"
        QRY_Grid = QRY_Grid & "a.C_Reprocesado,a.C_Scrap,a.Activo "
        QRY_Grid = QRY_Grid & "FROM Compuestos_Consumo a , MCPC_Compuesto b, MCPC_CompuestoClase c "
        QRY_Grid = QRY_Grid & "WHERE a.C_Compuesto = b.Compuesto "
        QRY_Grid = QRY_Grid & "AND a.Centro = b.Planta "
        QRY_Grid = QRY_Grid & "AND a.C_Clase = c.Clase_Compuesto "
        QRY_Grid = QRY_Grid & "AND a.Centro = '" & SessionUser._sCentro.Trim & "' "
        If C_Producto.Trim <> "*" Then
            QRY_Grid = QRY_Grid & "AND C_Material = '" & C_Producto.Trim & "' "
        End If
        QRY_Grid = QRY_Grid & "AND a.C_Tipo = '" & EXTINY & "' "
        QRY_Grid = QRY_Grid & "Order by a.C_Material "

        Try
            objDa = New SqlDataAdapter(QRY_Grid, AbrirAmanco)
            objDs = New DataSet
            objDa.Fill(objDs)
            DataGV.DataSource = objDs.Tables(0)

        Catch ex As Exception
            MessageBox.Show("Error Conexion :" & ex.Message, "ORDENES PROCESO")
        End Try

        DataGV.Columns(0).HeaderText = "Codigo Material"
        DataGV.Columns(1).HeaderText = "Codigo Compuesto"
        DataGV.Columns(2).HeaderText = "Descripción Compuesto"
        DataGV.Columns(3).HeaderText = "Unidad de Medida"
        DataGV.Columns(4).HeaderText = "Clase"
        DataGV.Columns(5).HeaderText = "Descripción Clase"
        DataGV.Columns(6).HeaderText = "Tipo"
        DataGV.Columns(7).HeaderText = "Bom"
        DataGV.Columns(8).HeaderText = "Reprocesado Generado"
        DataGV.Columns(9).HeaderText = "Scrap Basura"
        DataGV.Columns(10).HeaderText = "Status"

    End Sub

    Public Sub Consulta_Produccion_Detalle(ByVal Area As String, ByRef DG As DataGridView)

        Q = ""
        Q = "PA_ProduccionDetalle '" & SessionUser._sCentro.Trim & "', '" & ProduccionResumen._Status_Notif & "', '" & Area & "',  '" & ProduccionResumen.Seccion & "', '" & ProduccionResumen._Turno & "', '" & ProduccionResumen._FI & "', '" & ProduccionResumen._FF & "', '" & ProduccionResumen._HI & "', '" & ProduccionResumen._HF & "', 1"

        objDa = New SqlDataAdapter(Q, AbrirAmanco)
        objDs = New DataSet
        objDa.Fill(objDs)
        DG.DataSource = objDs.Tables(0)

        DG.Columns(0).HeaderText = "Orden Producción"
        DG.Columns(1).HeaderText = "Planta"
        DG.Columns(2).HeaderText = "Fecha Pesaje"
        DG.Columns(3).HeaderText = "Hora Pesaje"
        DG.Columns(4).HeaderText = "Bascula"
        DG.Columns(5).HeaderText = "Peso Bruto"
        DG.Columns(5).Name = "PB"
        DG.Columns(6).HeaderText = "Peso Tara"
        DG.Columns(7).HeaderText = "Peso Neto"
        DG.Columns(8).HeaderText = "Peso Scrap"
        DG.Columns(9).HeaderText = "Tramos"
        DG.Columns(10).HeaderText = "Usuario"
        DG.Columns(11).HeaderText = "Folio Atlas"
        DG.Columns(12).HeaderText = "Documento SAP"
        DG.Columns(13).HeaderText = "Consecutivo SAP"
        DG.Columns(14).HeaderText = "Compuesto 1"
        DG.Columns(15).HeaderText = "Porcentaje 1"
        DG.Columns(16).HeaderText = "Compuesto 2"
        DG.Columns(17).HeaderText = "Porcentaje 2"
        DG.Columns(18).HeaderText = "Puesto de Trabajo"
        DG.Columns(19).Visible = False  'Cadena Compuestos
        DG.Columns(20).HeaderText = "Producto"
        DG.Columns(21).HeaderText = "Descripción"
        DG.Columns(22).HeaderText = "Turno"
        DG.Columns(23).HeaderText = "Tipo Pesaje"
        DG.Columns(24).HeaderText = "Peso Teorico"
        DG.Columns(25).HeaderText = "Sobre Peso"
        DG.Columns(26).Visible = False  'Puesto de Trabajo
        DG.Columns(27).HeaderText = "Status Notificación"
        DG.Columns(28).HeaderText = "Area"
        DG.Columns(29).HeaderText = "Código Sección"
        DG.Columns(30).Visible = False  'cantidad_programada_tramos
    End Sub

    Public Sub Cantidades_Produccion_Detalle(ByVal Area As String, ByVal T_Programado As TextBox, ByVal T_Entregado As TextBox,
                                             ByVal T_Proceso As TextBox, ByVal T_Saldo As TextBox, ByVal T_Produccion As TextBox, _
                                             ByVal Tk_Entregado As TextBox, ByVal TD_Proceso As TextBox, ByVal Tk_Proceso As TextBox, ByVal Tk_Sobrepeso As TextBox)

        'Se obtiene el total de la cantidad programada de acuerdo al filtro de la consulta
        'LecturaQry("PA_Consulta_Suma_Cantidad_Programada " & Centro & "_Consulta_Produccion, " & Centro & "_OrdenProduccion, '" & Notifica & "', '" & Area & "',  '" & Seccion1 & "', 36, '" & Turno & "', '" & FI & "', '" & FF & "', '" & HI & "', '" & HF & "' ")
        LecturaQry("PA_ProduccionDetalle '" & SessionUser._sCentro.Trim & "', '" & ProduccionResumen.Status_Notif & "', '" & Area & "',  '" & ProduccionResumen._Seccion & "', '" & ProduccionResumen._Turno & "', '" & ProduccionResumen._FI & "', '" & ProduccionResumen._FF & "', '" & ProduccionResumen._HI & "', '" & ProduccionResumen._HF & "', 2")
        Do While (LecturaBD.Read)
            Programado = "" & LecturaBD(0)
        Loop
        LecturaBD.Close()

        T_Programado.Text = Format(Programado, "#0.00")

        'Se obtiene el total de la cantidad entregada de acuerdo al filtro de la consulta
        'LecturaQry("PA_Consulta_Ordenes_Proceso " & Centro & "_Consulta_Produccion, '(1)', '" & Area & "',  '" & Seccion1 & "', 36, '" & Turno & "', '" & FI & "', '" & FF & "', '" & HI & "', '" & HF & "' ")
        LecturaQry("PA_ProduccionDetalle " & SessionUser._sCentro.Trim & ", '(1)', '" & Area & "',  '" & ProduccionResumen._Seccion & "', '" & ProduccionResumen._Turno & "', '" & ProduccionResumen._FI & "', '" & ProduccionResumen._FF & "', '" & ProduccionResumen._HI & "', '" & ProduccionResumen._HF & "', 3")
        Do While (LecturaBD.Read)
            Pzas_Entregado = "" & LecturaBD(0)
            Kilos_Entregado = "" & LecturaBD(1)
        Loop
        LecturaBD.Close()
        T_Entregado.Text = Format(Pzas_Entregado, "#0.00")
        T_Produccion.Text = Format(Pzas_Entregado, "#0.00")
        Tk_Entregado.Text = Format(Kilos_Entregado, "#0.00")
        'Se obtiene el total de la cantidad en proceso de acuerdo al filtro de la consulta
        'LecturaQry("PA_Consulta_Ordenes_Proceso " & Centro & "_Consulta_Produccion, '(0)', '" & Area & "',  '" & Seccion1 & "', 36, '" & Turno & "', '" & FI & "', '" & FF & "', '" & HI & "', '" & HF & "' ")
        LecturaQry("PA_ProduccionDetalle " & SessionUser._sCentro.Trim & ", '(0)', '" & Area & "',  '" & ProduccionResumen._Seccion & "', '" & ProduccionResumen._Turno & "', '" & ProduccionResumen._FI & "', '" & ProduccionResumen._FF & "', '" & ProduccionResumen._HI & "', '" & ProduccionResumen._HF & "', 3")
        Do While (LecturaBD.Read)
            Pzas_Proceso = "" & LecturaBD(0)
            Kilos_Proceso = "" & LecturaBD(1)
        Loop
        LecturaBD.Close()
        TD_Proceso.Text = Format(Pzas_Proceso, "#0.00")
        T_Proceso.Text = Format(Pzas_Proceso, "#0.00")
        Tk_Proceso.Text = Kilos_Proceso
        T_Saldo.Text = Format(Programado - (Pzas_Entregado + Pzas_Proceso), "#0.00")

        ''LecturaQry("PA_Consulta_Ordenes_Proceso " & Centro & "_Consulta_Produccion, '(0,1)', '" & Area & "',  '" & Seccion1 & "', 36, '" & Turno & "', '" & FI & "', '" & FF & "', '" & HI & "', '" & HF & "' ")
        LecturaQry("PA_ProduccionDetalle " & SessionUser._sCentro.Trim & ", '(0,1)', '" & Area & "',  '" & ProduccionResumen._Seccion & "', '" & ProduccionResumen._Turno & "', '" & ProduccionResumen._FI & "', '" & ProduccionResumen._FF & "', '" & ProduccionResumen._HI & "', '" & ProduccionResumen._HF & "', 3")
        Do While (LecturaBD.Read)
            Kilos_Terminado = LecturaBD(1)
            Kilos_Teoricos = LecturaBD(2)
        Loop
        LecturaBD.Close()

        'Tk_Sobrepeso.Text = Kilos_Terminado - Tk_Sobrepeso

    End Sub

    Public Sub SummaryProductionOrder(ByRef Area As String, ByRef DG As DataGridView, ByVal P_Sobre_Peso As TextBox, _
                                           ByVal K_Sobrepeso As TextBox, ByVal Tk_Scrap As TextBox, ByVal Tp_Scrap As TextBox)
        LecturaQry("PA_ProduccionResumen '" & SessionUser._sCentro & "', '" & ProduccionResumen.Status_Notif & "', '" & Area & "', '" & ProduccionResumen._Seccion & "', '" & ProduccionResumen._Turno & "', '" & ProduccionResumen._FI & "', '" & ProduccionResumen._FF & "', '" & ProduccionResumen._HI & "', '" & ProduccionResumen._HF & "', 1 ")
        Count = 0
        Do While (LecturaBD.Read)
            Count = Count + 1
            DGV_OrdenProduccion = "" & LecturaBD(0)
            DGV_Equipo = "" & LecturaBD(1)
            DGV_Producto = "" & LecturaBD(2)
            DGV_Tramos = "" & LecturaBD(3)
            DGV_PN = "" & LecturaBD(4)
            DGV_PT = "" & LecturaBD(5)
            DGV_SP = "" & LecturaBD(6)
            DGV_PNS = "" & LecturaBD(7)
            DGV_SC = "" & LecturaBD(8)
            Dim arrConsulta() As Object = {DGV_OrdenProduccion.Trim(), DGV_Equipo.Trim(), DGV_Producto.Trim(), FormatNumber((DGV_Tramos), 3), FormatNumber((DGV_PN), 3), FormatNumber((DGV_PT), 3), FormatNumber((DGV_SP), 3), FormatNumber((DGV_PNS), 2), FormatNumber((DGV_SC), 3)} 'Creamos un nuevo arreglo con los datos a agregar.               
            DG.Rows.Add(arrConsulta) 'Agregamos el arreglo de datos a las filas del DataGrid
            DG.Refresh()
        Loop
        LecturaBD.Close()

        DGV_OrdenProduccion = "Totales"
        DGV_Equipo = " "
        DGV_Producto = " "
        DGV_Tramos = Sumar("C_Tramos", DG)
        DGV_PN = Sumar("C_PN", DG)
        DGV_PT = Sumar("C_PT", DG)
        DGV_SP = Porcentaje_Producto_Terminado(DGV_PN, DGV_PT)
        DGV_PNS = Sumar("C_PNS", DG)
        DGV_SC = Porcentaje_Scrap(DGV_PNS, DGV_PN)

        Dim arrDatos() As Object = {DGV_OrdenProduccion.Trim(), DGV_Equipo.Trim(), DGV_Producto.Trim(), FormatNumber((DGV_Tramos), 3), FormatNumber((DGV_PN), 3), FormatNumber((DGV_PT), 3), FormatNumber((DGV_SP), 3), FormatNumber((DGV_PNS), 2), FormatNumber((DGV_SC), 3)} 'Creamos un nuevo arreglo con los datos a agregar.               
        DG.Rows.Add(arrDatos) 'Agregamos el arreglo de datos a las filas del DataGrid
        DG.Refresh()

        P_Sobre_Peso.Text = Porcentaje_Producto_Terminado(DGV_PN, DGV_PT)
        K_Sobrepeso.Text = Kilos_Producto_Terminado(DGV_PN, DGV_PT)
        Tk_Scrap.Text = DGV_PNS
        Tp_Scrap.Text = DGV_SC
    End Sub

    Public Sub SummaryProductionMachine(ByRef Area As String, ByRef DG As DataGridView)
        LecturaQry("PA_ProduccionResumen '" & SessionUser._sCentro & "', '" & ProduccionResumen.Status_Notif & "', '" & Area & "', '" & ProduccionResumen._Seccion & "', '" & ProduccionResumen._Turno & "', '" & ProduccionResumen._FI & "', '" & ProduccionResumen._FF & "', '" & ProduccionResumen._HI & "', '" & ProduccionResumen._HF & "', 2 ")
        Count = 0
        Do While (LecturaBD.Read)
            Count = Count + 1
            DGV2_Equipo = "" & LecturaBD(0)
            DGV2_Tramos = "" & LecturaBD(1)
            DGV2_PN = "" & LecturaBD(2)
            DGV2_PT = "" & LecturaBD(3)
            DGV2_SP = "" & LecturaBD(4)
            DGV2_PNS = "" & LecturaBD(5)
            DGV2_SC = "" & LecturaBD(6)
            Dim arrConsulta() As Object = {DGV2_Equipo.Trim(), FormatNumber((DGV2_Tramos), 3), FormatNumber((DGV2_PN), 3), FormatNumber((DGV2_PT), 3), FormatNumber((DGV2_SP), 3), FormatNumber((DGV2_PNS), 2), FormatNumber((DGV2_SC), 3)} 'Creamos un nuevo arreglo con los datos a agregar.               
            DG.Rows.Add(arrConsulta) 'Agregamos el arreglo de datos a las filas del DataGrid
            DG.Refresh()
        Loop
        LecturaBD.Close()

        DGV2_Equipo = "Totales"
        DGV2_Tramos = Sumar("C_Tramos", DG)
        DGV2_PN = Sumar("C_PN", DG)
        DGV2_PT = Sumar("C_PT", DG)
        DGV2_SP = Porcentaje_Producto_Terminado(DGV_PN, DGV_PT)
        DGV2_PNS = Sumar("C_PNS", DG)
        DGV2_SC = Porcentaje_Scrap(DGV2_PNS, DGV2_PN)

        Dim arrDatos() As Object = {DGV2_Equipo.Trim(), FormatNumber((DGV2_Tramos), 3), FormatNumber((DGV2_PN), 3), FormatNumber((DGV2_PT), 3), FormatNumber((DGV2_SP), 3), FormatNumber((DGV2_PNS), 2), FormatNumber((DGV2_SC), 3)} 'Creamos un nuevo arreglo con los datos a agregar.               
        DG.Rows.Add(arrDatos) 'Agregamos el arreglo de datos a las filas del DataGrid
        DG.Refresh()

    End Sub

    Public Sub Pesajes_PT_SC(ByVal FI As String, FF As String, DataGV As DataGridView, AreaProd As String, TBProdKilos As TextBox, _
                             TBProrUnidades As TextBox, TBProcKilos As TextBox, TBProcUnidades As TextBox, TBSobrePesoKilos As TextBox, _
                             TBSobrePesoPorc As TextBox, TBScrapKilos As TextBox, TBScrapPorc As TextBox, TBScrapPurgaKilos As TextBox, _
                             TBScrapPurgaPorc As TextBox, TBProg As TextBox, TBEnt As TextBox, TBProc As TextBox, TBPend As TextBox, _
                             Orden As String)

        Q = ""
        Q = "PA_Consulta_Produccion_Scrap " & SessionUser._sCentro.Trim & "_OrdenProduccion, " & SessionUser._sCentro.Trim & "_PesoProductoTerminado, " & SessionUser._sCentro.Trim & "_PesoScrap, '" & FI & "', '" & FF & "', '" & AreaProd & "', '" & Orden & "' "
        Try
            objDa = New SqlDataAdapter(Q, AbrirAmanco)
            objDs = New DataSet
            objDa.Fill(objDs)
            DataGV.DataSource = objDs.Tables(0)
        Catch ex As Exception
            MessageBox.Show("Error Conexion :" & ex.Message, "ORDENES PROCESO")
        End Try
        DataGV.Columns(0).HeaderText = "Folio"
        DataGV.Columns(1).HeaderText = "Tipo Producción"
        DataGV.Columns(2).HeaderText = "Orden Producción"
        DataGV.Columns(3).HeaderText = "Codigo Producto"
        DataGV.Columns(4).HeaderText = "Fecha_Pesaje"
        DataGV.Columns(5).HeaderText = "Hora Pesaje"
        DataGV.Columns(6).HeaderText = "Bascula"
        DataGV.Columns(7).HeaderText = "Tramos"
        DataGV.Columns(7).Name = "Tramos"
        DataGV.Columns(8).HeaderText = "Rack"
        DataGV.Columns(9).HeaderText = "Peso Bruto"
        DataGV.Columns(10).HeaderText = "Peso Tara"
        DataGV.Columns(11).HeaderText = "Peso Neto"
        DataGV.Columns(11).Name = "PesoNeto"
        DataGV.Columns(12).Visible = False  'Peso Teorico"
        DataGV.Columns(13).HeaderText = "Empaques"
        DataGV.Columns(14).HeaderText = "Usuario"
        DataGV.Columns(15).HeaderText = "Turno"
        DataGV.Columns(16).HeaderText = "Documento SAP"
        DataGV.Columns(17).HeaderText = "Consecutivo SAP"
        DataGV.Columns(18).HeaderText = "Sobre Peso"
        DataGV.Columns(19).HeaderText = "Puesto Trabajo"
        DataGV.Columns(20).Visible = False  'Status Notificación
        DataGV.Columns(21).Visible = False  'Mensaje
        DataGV.Columns(22).Visible = False  'Tipo Produccion 1 = Producto Terminado 2 Scrap

        LecturaQry("PA_Consulta_Produccion_Totales " & SessionUser._sCentro.Trim & "_OrdenProduccion, " & SessionUser._sCentro.Trim & "_PesoProductoTerminado, '" & FI & "', '" & FF & "', '" & AreaProd & "', '" & Orden & "' ")
        If (LecturaBD.Read) Then
            TBProrUnidades.Text = Format(LecturaBD(0), "#,##0.00")
            TBProdKilos.Text = Format(LecturaBD(1), "#,##0.00")
            TBSobrePesoPorc.Text = Format(LecturaBD(2), "#0.000")
            TBSobrePesoKilos.Text = Format(LecturaBD(3), "#,##0.00")
        End If
        LecturaBD.Close()

        LecturaQry("PA_Consulta_Produccion_Scrap_Proceso " & SessionUser._sCentro.Trim & "_OrdenProduccion, " & SessionUser._sCentro.Trim & "_PesoProductoTerminado, '" & FI & "', '" & FF & "', '" & AreaProd & "', '" & Orden & "'")
        If (LecturaBD.Read) Then
            TBProcUnidades.Text = Format(LecturaBD(0), "#,##0.00")
            TBProcKilos.Text = Format(LecturaBD(1), "#,##0.00")
        End If
        LecturaBD.Close()

        LecturaQry("PA_Consulta_Scrap_Totales " & SessionUser._sCentro.Trim & "_PesoScrap, '" & FI & "', '" & FF & "', '" & AreaProd & "', '1', '" & Orden & "'")
        If (LecturaBD.Read) Then
            TBScrapKilos.Text = Format(LecturaBD(0), "#,##0.00")
        End If
        LecturaBD.Close()

        LecturaQry("PA_Consulta_Scrap_Totales " & SessionUser._sCentro.Trim & "_PesoScrap, '" & FI & "', '" & FF & "', '" & AreaProd & "', '2', '" & Orden & "'")
        If (LecturaBD.Read) Then
            TBScrapPurgaKilos.Text = Format(LecturaBD(0), "#,##0.00")
        End If
        LecturaBD.Close()

        'Consulta Cantidad Programada
        LecturaQry("PA_Consulta_Cantidad_Programada " & SessionUser._sCentro.Trim & "_OrdenProduccion, " & SessionUser._sCentro.Trim & "_PesoProductoTerminado, '" & FI & "', '" & FF & "', '" & AreaProd & "', '" & Orden & "'")
        If (LecturaBD.Read) Then
            TBProg.Text = Format(LecturaBD(0), "#,##0.00")
        End If
        LecturaBD.Close()

        'Consulta Cantidad Entregada
        LecturaQry("PA_Consulta_Cantidad_Entregadas  '" & SessionUser._sCentro.Trim & "', '" & FI & "', '" & FF & "', '" & AreaProd & "', '" & Orden & "'")
        If (LecturaBD.Read) Then
            TBEnt.Text = Format(LecturaBD(0), "#,##0.00")
        End If
        LecturaBD.Close()

        'Consulta Cantidad En Proceso
        LecturaQry("PA_Consulta_Cantidad_Proceso  '" & SessionUser._sCentro.Trim & "', '" & FI & "', '" & FF & "', '" & AreaProd & "', '" & Orden & "'")
        If (LecturaBD.Read) Then
            TBProc.Text = Format(LecturaBD(0), "#,##0.00")
        End If
        LecturaBD.Close()

        TBPend.Text = Format((TBProg.Text - (TBEnt.Text - TBProc.Text)), "#,##0.00")

        TBScrapPorc.Text = Format((TBScrapKilos.Text / TBProdKilos.Text), "#0.000")
        TBScrapPurgaPorc.Text = Format((TBScrapPurgaKilos.Text / TBProdKilos.Text), "#0.000")

    End Sub

    Public Sub Consulta_Ordenes_Produccion(ByVal DataGV As DataGridView, FI As String, FF As String, ODF As String, Area As String)
        Q = ""
        Q = "PA_Consulta_ODF " & SessionUser._sCentro.Trim & "_OrdenProduccion, '" & FI & "', '" & FF & "', '" & ODF & "', '" & Area & "' "
        Try
            objDa = New SqlDataAdapter(Q, AbrirAmanco)
            objDs = New DataSet
            objDa.Fill(objDs)
            DataGV.DataSource = objDs.Tables(0)
        Catch ex As Exception
            MessageBox.Show("Error Conexion :" & ex.Message, "ORDENES PROCESO")
        End Try
        DataGV.Columns(0).HeaderText = "Orden de Producción"
        DataGV.Columns(1).Visible = False   'Centro
        DataGV.Columns(2).HeaderText = "Equipo Basico"
        DataGV.Columns(3).HeaderText = "Codigo Material"
        DataGV.Columns(4).HeaderText = "Cantidad Programada Tramos"
        DataGV.Columns(5).HeaderText = "Cantidad Programada Kilos"
        DataGV.Columns(6).HeaderText = "Fecha Inicio"
        DataGV.Columns(7).HeaderText = "Fecha Termino"
        DataGV.Columns(8).HeaderText = "Origen Información"
        DataGV.Columns(9).HeaderText = "Estatus"
        DataGV.Columns(10).HeaderText = "Usuario Actualiza"
        DataGV.Columns(11).HeaderText = "Fecha Actualizacion"
        DataGV.Columns(12).HeaderText = "Observaciones"
        DataGV.Columns(13).HeaderText = "Fecha Inicio Producció"
        DataGV.Columns(14).HeaderText = "Hora Inicio Producción"
        DataGV.Columns(15).HeaderText = "Usuario Registra Inicio"
        DataGV.Columns(16).HeaderText = "Fecha Terminación"
        DataGV.Columns(17).HeaderText = "Hora Terminación"
        DataGV.Columns(18).HeaderText = "Usuario Registra Terminación"
        DataGV.Columns(19).HeaderText = "Usuario Registra"
        DataGV.Columns(20).HeaderText = "Fecha Registro"
        DataGV.Columns(21).HeaderText = "Hora Registro"
        DataGV.Columns(22).HeaderText = "Grupo Productivo"

    End Sub

#Region "Funciones"
    Private Function Sumar(ByVal Nombre_Columna As String, ByVal Dgv As DataGridView) As Double
        Dim total As Double = 0
        ' recorrer las filas y obtener los items de la columna indicada en "nombre_Columna"  
        Try
            For i As Integer = 0 To Dgv.RowCount - 1
                total = total + CDbl(Dgv.Item(Nombre_Columna.ToLower, i).Value)
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        ' retornar el valor  
        Return Format((total), "#0.000")
    End Function

    Private Function Porcentaje_Producto_Terminado(ByVal PPTerminado As Decimal, ByVal PTeorico As Decimal) As Double
        Dim Porcentaje_PT As Double = 0
        Porcentaje_PT = ((PPTerminado / PTeorico) - 1) * 100
        Return Format(Porcentaje_PT, "#0.000")
    End Function

    Private Function Kilos_Producto_Terminado(ByVal PPTerminado As Decimal, ByVal PTeorico As Decimal) As Double
        Dim Kilo_Sobrepeso As Double = 0
        Kilo_Sobrepeso = (PPTerminado - PTeorico)
        Return Format(Kilo_Sobrepeso, "#0.000")
    End Function

    Private Function Porcentaje_Scrap(ByVal PNScrap As Decimal, ByVal PPTerminado As Decimal) As Double
        Dim Porcentaje_SC As Double = 0
        Porcentaje_SC = PNScrap / PPTerminado
        Return Format(Porcentaje_SC, "#0.000")
    End Function
#End Region



End Class
