Imports System.Data.SqlClient
Imports Utili_Generales
Imports System.Windows.Forms

Public Class Catalogo_Ordenes_Produccion

    Public Shared Function Consulta_Ordenes_Produccion(ByVal DataGV As DataGridView, Centro As String, FI As String, FF As String, ODF As String, Area As String, Usuario As String)
        Dim Q As String
        Dim objDa As SqlDataAdapter
        Dim objDs As DataSet
        Dim Contador As Integer = 0
        Q = ""
        Q = "PA_Consulta_ODF " & Centro.Trim & "_OrdenProduccion, '" & FI & "', '" & FF & "', '" & ODF & "', '" & Area & "' "
        Try
            objDa = New SqlDataAdapter(Q, MSI(Usuario))
            objDs = New DataSet
            objDa.Fill(objDs)
            DataGV.DataSource = objDs.Tables(0)
            Contador = objDs.Tables(0).Rows.Count
        Catch ex As Exception
            MessageBox.Show("Error Conexion :" & ex.Message, "ORDENES PROCESO")
        End Try
        If Contador <= 0 Then
            MensajeBox.Mostrar("No existen la información solicitada", "Aviso", MensajeBox.TipoMensaje.Exclamation)
            Exit Function
        Else
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
        End If

        Return Contador

    End Function

    Public Shared Sub Consulta_Linea_Produccion(ByVal CB As ComboBox, Centro As String, Usuario As String, Area As String)
        Dim NDataSet1 As New DataSet
        Dim Q As String
        Q = ""
        Q = "PA_Consulta_Lineas_Produccion '" & Centro.Trim & "', '" & Area.Trim & "' "
        Combo(Q, Usuario)
        NDataSet1 = DataSetCombo.Copy
        CB.DataSource = NDataSet1.Tables(0)
        CB.DisplayMember = "D_Equipo"
        CB.ValueMember = "C_Equipo"
    End Sub

    Public Shared Sub Consulta_Producto_Terminado(ByVal CB As ComboBox, Centro As String, Usuario As String, Area As String)
        Dim NDataSet1 As New DataSet
        Dim Q As String
        Q = ""
        Q = "PA_Consulta_Productos '" & Centro.Trim & "', '" & Area.Trim & "' "
        Combo(Q, Usuario)
        NDataSet1 = DataSetCombo.Copy
        CB.DataSource = NDataSet1.Tables(0)
        CB.DisplayMember = "D_Prod"
        CB.ValueMember = "Codigo"
    End Sub

    Public Shared Function Valida_Orden_Fabricacion(ByVal Centro As String, Usuario As String, Orden As String)
        Dim Exis_Orden As Integer = 0
        LecturaQry("PA_Read_Production_Order '" & Orden.Trim & "', '" & Centro.Trim & "' ", Usuario)
        If (LecturaBD.Read) Then
            Exis_Orden = Exis_Orden + 1
        Else
            Exis_Orden = 0
        End If
        Return Exis_Orden
    End Function

    Public Shared Function Grupo_Material(ByVal Centro As String, Usuario As String, Codigo As String, Area As String)
        Dim G_Material As String = ""
        LecturaQry("PA_Consulta_Grupo_Material '" & Centro.Trim & "', '" & Codigo.Trim & "', '" & Area.Trim & "' ", Usuario)
        If (LecturaBD.Read) Then
            G_Material = "" & LecturaBD(0)
        Else
            G_Material = ""
        End If
        Return G_Material
    End Function

    Public Shared Sub Actualiza_Orden_Fabricacion(ByVal Centro As String, Usuario As String, OrdOld As String, OrdNew As String, C_Equipo As String, Producto As String, Tramos As String, Version As String)
        Dim FH_Update As String = DateTime.Now.ToString("yyyyMMdd hh:mm:ss")
        LecturaQry("PA_Actualiza_Orden_Fabricacion '" & Centro.Trim & "', '" & OrdOld.Trim & "', '" & OrdNew.Trim & "', '" & C_Equipo.Trim & "', '" & Producto.Trim & "', '" & Tramos.Trim & "', '" & Usuario.Trim & "', '" & FH_Update & "', '" & Version.Trim & "'", Usuario)
    End Sub

    Public Shared Function Consulta_Orden_Fabricacion(ByVal Centro As String, Usuario As String, Orden As String)
        Dim Cadena As String = ""
        Dim C_Orden As String = ""
        Dim C_Centro As String = ""
        Dim C_Equipo As String = ""
        Dim D_Equipo As String = ""
        Dim C_Producto As String = ""
        Dim D_Producto As String = ""
        Dim C_Cantidad As String = ""
        Dim C_Fecha As String = ""
        Dim C_Origen As String = ""
        Dim C_Activa As String = ""

        LecturaQry("PA_Consulta_Orden_Fabricacion '" & Centro.Trim & "', '" & Orden.Trim & "' ", Usuario)
        If (LecturaBD.Read) Then
            C_Orden = "" & LecturaBD(0)
            C_Centro = "" & LecturaBD(1)
            C_Equipo = "" & LecturaBD(2)
            D_Equipo = "" & LecturaBD(3)
            C_Producto = "" & LecturaBD(4)
            D_Producto = "" & LecturaBD(5)
            C_Cantidad = "" & LecturaBD(6)
            C_Fecha = "" & LecturaBD(7)
            C_Origen = "" & LecturaBD(8)
            C_Activa = "" & LecturaBD(9)
        End If

        Return C_Orden & "|" & C_Centro & "|" & C_Equipo & "|" & D_Equipo & "|" & C_Producto & "|" & D_Producto & "|" & C_Cantidad & "|" & C_Fecha & "|" & C_Origen & "|" & C_Activa
    End Function


    Public Shared Sub Consulta_ODF_Tiempos(ByVal DataGV As DataGridView, Usuario As String, FI As String, FF As String, Area As String, _
                                           Opcion As Integer)

        Dim Q As String
        Dim RegCount As Integer
        Dim objDa As SqlDataAdapter
        Dim objDs As DataSet

        Q = ""
        Q = "PA_Orden_Fabricacion '','" & SessionUser._sCentro & "','','','','','','','','','','','','','','','','','','','','','','','','','','','','','" & FI & "','" & FF & "','','" & Area & "'," & Opcion & ""
        Try
            objDa = New SqlDataAdapter(Q, MSI(Usuario))
            objDs = New DataSet
            objDa.Fill(objDs)
            DataGV.DataSource = objDs.Tables(0)
            RegCount = DataGV.RowCount

            If RegCount <= 0 Then
                MensajeBox.Mostrar("La consulta no encontro resultados dentro de las fechas y filtros establecidos.", "Consulta", MensajeBox.TipoMensaje.Information)
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show("Error Conexion :" & ex.Message, "ORDENES PROCESO")
        End Try
    End Sub

    Public Shared Sub Estatus_Produccion(ByVal ODF As String, FHI As String, FHF As String, Estatus As Integer, Opcion As String)
        LecturaQry("PA_Orden_Fabricacion '" & ODF.Trim & "','" & SessionUser._sCentro & "','','','','','','','','','','','','','','','','','','','','','','','','','','','','','" & FHI.Trim & "','" & FHF.Trim & "'," & Estatus & "," & Opcion & "", SessionUser._sAlias)
    End Sub

    Public Shared Sub Actualiza_Fechas(ByVal ODF As String, Estatus As Integer, Opcion As String)
        LecturaQry("PA_Orden_Fabricacion '" & ODF.Trim & "','" & SessionUser._sCentro & "','','','','','','','','','','','','','','','','','','','','','','','','','','','','','',''," & Estatus & "," & Opcion & "", SessionUser._sAlias)
    End Sub

    Public Shared Sub Tiempos_Prod_Muertos(ByVal PuestoTrabajo As String, FI As String, FF As String)
        LecturaQry("PA_Tiempos_Puesto_Orden '" & SessionUser._sCentro & "', '" & PuestoTrabajo.Trim & "', '" & FI.Trim & "', '" & FF.Trim & "' ", SessionUser._sAlias)
        If (LecturaBD.Read) Then
            Tiempo_Totales.tTotalTProd = LecturaBD(0)
            Tiempo_Totales.tTotalTMuerto = LecturaBD(1)
        End If
        LecturaBD.Close()
    End Sub

    Public Shared Sub Inser_Orden_Produccion(ByVal Centro As String, Usuario As String, Orden As String, Equipo As String, Producto As String, _
                                             Cantidad As String, Gpo_Material As String, Version As String)
        Dim Fecha As String = DateTime.Now.ToString("yyyyMMdd")
        Dim Fecha_Actualiza As String = DateTime.Now.ToString("yyyy/MM/dd")
        Dim Hra_Act As String = DateTime.Now.ToString("HH:MM:ss")

        LecturaQry("PA_Inserta_Orden_Fabricacion '" & Orden.Trim & "', '" & Centro.Trim & "', '" & Equipo.Trim & "' , '" & Producto.Trim & _
                   "', '" & Cantidad & "', '" & Fecha & "', '" & Fecha & "', 'A-tlas', '" & Usuario & "', '" & Fecha_Actualiza & _
                   "', 'Ingreso Por A-tlas', '" & Fecha_Actualiza & "', '" & Hra_Act & "', '" & Usuario & "', '" & Fecha_Actualiza & _
                   "', '" & Hra_Act & "', '" & Usuario & "', '" & Usuario & "', '" & Fecha_Actualiza & "', '" & Hra_Act & _
                   "', '" & Gpo_Material & "', '" & Usuario & "', '" & Version & "' ", Usuario)

    End Sub

    Public Shared Sub CB_ODP(ByVal CB As ComboBox, Usuario As String, Centro As String, FI As String, FF As String, C_Tipo As String, IdEquipo As String)
        Dim NDataSet1 As New DataSet
        Dim Q As String
        Q = ""
        Q = "PA_Orden_Produccion_1 " & Centro.Trim & "_OrdenProduccion, '', '" & IdEquipo & "', '', '', '', '', '', '" & FI & "', '" & FF & "', '" & C_Tipo & "', '2'"
        Combo(Q, Usuario)
        NDataSet1 = DataSetCombo.Copy
        CB.DataSource = NDataSet1.Tables(0)
        CB.DisplayMember = "Orden_Produccion"
        CB.ValueMember = "Orden_Produccion"
        CB.Text = ""
    End Sub

    Public Shared Function ODP_Codigo(ByVal Centro As String, Usuario As String, Orden As String)
        Dim rCodigo As String = ""
        Dim rDesc As String = ""

        LecturaQry("PA_Orden_Produccion_1 " & Centro.Trim & "_OrdenProduccion,'" & Orden & "', '', '','','','','','','','','3' ", Usuario)
        If (LecturaBD.Read) Then
            rCodigo = "" & LecturaBD(0)
            rDesc = "" & LecturaBD(1)
        End If

        Return rCodigo & "|" & rDesc
    End Function

End Class
