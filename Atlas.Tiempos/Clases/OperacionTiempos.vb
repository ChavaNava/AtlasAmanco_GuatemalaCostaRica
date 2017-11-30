Imports System.Data.SqlClient
Imports Utili_Generales
Imports SQL_DATA
Imports Atlas.Accesos.CLVarGlobales

Public Class OperacionTiempos
    Public Shared Sub Consulta_ODF_Tiempos(ByVal DataGV As DataGridView, Opcion As Integer)

        Dim Q As String
        Dim RegCount As Integer
        Dim objDa As SqlDataAdapter
        Dim objDs As DataSet

        Q = ""
        Q = "PA_Orden_Fabricacion '" & ConsultaODF._rODF.Trim & "','" & SessionUser._sCentro.Trim & "','','','','','','','','','','','','','','','','','','','','','','','','','','','','','" & ConsultaODF._rFIP.Trim & "','" & ConsultaODF._rFFP.Trim & "','','" & ConsultaODF._rArea.Trim & "'," & Opcion & ""
        Try
            objDa = New SqlDataAdapter(Q, Cnn.MSI(SessionUser._sAmbiente))
            objDs = New DataSet
            objDa.Fill(objDs)
            DataGV.DataSource = objDs.Tables(0)
            RegCount = DataGV.RowCount

            If RegCount <= 0 Then
                MensajeBox.Mostrar("La consulta no encontro resultados dentro de las fechas y filtros establecidos.", "Consulta", MensajeBox.TipoMensaje.Information)
                Exit Sub
            Else
                DataGV.Columns(0).HeaderText = "Centro"
                DataGV.Columns(1).HeaderText = "Puesto Trabajo"
                DataGV.Columns(2).HeaderText = "Orden Producción"
                DataGV.Columns(3).HeaderText = "Código Producto"
                DataGV.Columns(4).HeaderText = "Cantidad Programada"
                DataGV.Columns(5).HeaderText = "Fecha Inicio Producción"
                DataGV.Columns(6).HeaderText = "Fecha Fin Producción"
                DataGV.Columns(7).Visible = False 'Estatus Producción
                DataGV.Columns(8).Visible = False 'IdOrden
            End If
        Catch ex As Exception
            LoadingForm.CloseForm()
            MessageBox.Show("Error Conexion :" & ex.Message, "ORDENES PROCESO")
        End Try
    End Sub

    Public Shared Sub FechaIniProd()
        Cnn.LecturaQry("PA_FechasProduccion '" & SessionUser._sCentro.Trim & "','" & AjustaTiempos._OrdenProduccion.Trim & "','" & AjustaTiempos._PuestoTrabajo.Trim & "','" & AjustaTiempos._IdTurno.Trim & "',1")
        Do While (Cnn.LecturaBD.Read)
            AjustaTiempos.FIP = Cnn.LecturaBD(0)
        Loop
        Cnn.LecturaBD.Close()
    End Sub

    Public Shared Sub FechaFinProd()
        Cnn.LecturaQry("PA_FechasProduccion '" & SessionUser._sCentro.Trim & "','" & AjustaTiempos._OrdenProduccion.Trim & "','" & AjustaTiempos._PuestoTrabajo.Trim & "','" & AjustaTiempos._IdTurno.Trim & "',2")
        Do While (Cnn.LecturaBD.Read)
            AjustaTiempos.FFP = Cnn.LecturaBD(0)
        Loop
        Cnn.LecturaBD.Close()
    End Sub

    Public Shared Sub ActualizaFechas(ByVal Operacion As Integer)
        Cnn.LecturaQry("PA_OrdenProduccionTiempos '" & AjustaTiempos._IdOrden.Trim & "','" & SessionUser._sCentro.Trim & "','','','','','','" & FHIniFin._rFIP.Trim & "','" & FHIniFin._rFFP.Trim & "','','','','','','','',''," & Operacion & "")
    End Sub

    Shared Sub Turnos(ByVal CB As ComboBox)
        Dim NDataSet1 As New DataSet
        Dim Q As String
        Q = ""
        Q = "PA_Consulta_Turno '" & SessionUser._sCentro.Trim & "' "
        Cnn.Combo_ADM(Q)
        NDataSet1 = Cnn.DataSetCombo.Copy
        CB.DataSource = NDataSet1.Tables(0)
        CB.DisplayMember = "Descripcion"
        CB.ValueMember = "Turno"
    End Sub

    Shared Sub WorkCenter(ByVal CB As ComboBox)
        Dim NDataSet1 As New DataSet
        Dim Q As String
        Q = ""
        Q = "PA_PuestoTrabajo '" & SessionUser._sCentro.Trim & "','','','" & EXTINY.Trim & "','','','','','','','','','','','',2"
        Cnn.Combo(Q)
        NDataSet1 = Cnn.DataSetCombo.Copy
        CB.DataSource = NDataSet1.Tables(0)
        CB.DisplayMember = "C_Equipo"
        CB.ValueMember = "D_Equipo"
    End Sub
    Shared Sub GrupoDiametros(ByVal CB As ComboBox)
        Dim NDataSet1 As New DataSet
        Dim Q As String
        Q = ""
        Q = "PA_GrupoMateriales '','" & SessionUser._sCentro.Trim & "','','','" & EXTINY.Trim & "','','','',1"
        Cnn.Combo(Q)
        NDataSet1 = Cnn.DataSetCombo.Copy
        CB.DataSource = NDataSet1.Tables(0)
        CB.DisplayMember = "C_Material"
        CB.ValueMember = "D_Material"
    End Sub

    Shared Sub GrupoParos(ByVal CB As ComboBox)
        Dim NDataSet1 As New DataSet
        Dim Q As String
        Q = ""
        Q = "PA_TiemposProductivoParo '" & SessionUser._sIdCentro.Trim & "','','','','',1 "
        Cnn.Combo(Q)
        NDataSet1 = Cnn.DataSetCombo.Copy
        CB.DataSource = NDataSet1.Tables(0)
        CB.DisplayMember = "GrupoParos"
        CB.ValueMember = "IdGrupoParos"
    End Sub
    Shared Sub GrupoProductivo(ByVal CB As ComboBox, IdGrupoParo As Integer)
        Dim NDataSet1 As New DataSet
        Dim Q As String
        Q = ""
        Q = "PA_TiemposProductivoParo '','','','" & IdGrupoParo & "','" & ReadOrderProducction._rIdGrupProd & "',2 "
        Cnn.Combo(Q)
        NDataSet1 = Cnn.DataSetCombo.Copy
        CB.DataSource = NDataSet1.Tables(0)
        CB.DisplayMember = "Concepto"
        CB.ValueMember = "IdParoProduccion"
    End Sub
    Public Shared Function ValidaGrpProd(ByVal GropProd As Integer, Operacion As Integer) As Boolean
        Cnn.LecturaQry("PA_TiemposProductivoParo '','','','','" & GropProd & "', " & Operacion & " ")

        If (Cnn.LecturaBD.Read) Then
            ReadOrderProducction.rIdGrupProd = Cnn.LecturaBD(0)
            Return True
        Else
            Return False
        End If
        Cnn.LecturaBD.Close()
    End Function
    Public Shared Function LeerOrdenProduccion(ByVal Orden As String, Operacion As Integer) As Boolean


        Cnn.LecturaQry("PA_OrdenesProduccion '" & Orden.Trim & "','" & SessionUser._sCentro.Trim & "','','','','','','','','',''," & Operacion & "")

        If (Cnn.LecturaBD.Read) Then
            ReadOrderProducction.rCentro = Cnn.LecturaBD(0)
            ReadOrderProducction.rOrden = Cnn.LecturaBD(1)
            ReadOrderProducction.rIdPuestoTrabajo = Cnn.LecturaBD(2)
            ReadOrderProducction.rPuestoTrabajo = Cnn.LecturaBD(3)
            ReadOrderProducction.rIdProducto = Cnn.LecturaBD(4)
            ReadOrderProducction.rProducto = Cnn.LecturaBD(5)
            ReadOrderProducction.rIdGrupProd = Cnn.LecturaBD(6)
            ReadOrderProducction.rGrupProd = Cnn.LecturaBD(7)
            ReadOrderProducction.rGrupProdDesc = Cnn.LecturaBD(8)
            ReadOrderProducction.rIdSeccion = Cnn.LecturaBD(9)
            ReadOrderProducction.rCodSeccion = Cnn.LecturaBD(10)
            ReadOrderProducction.rSeccion = Cnn.LecturaBD(11)
            ReadOrderProducction.rIdGrupMaterial = Cnn.LecturaBD(12)
            ReadOrderProducction.rClaveGrupMaterial = Cnn.LecturaBD(13)
            ReadOrderProducction.rGrupMaterial = Cnn.LecturaBD(14)
            ReadOrderProducction.rPesoTeorico = Cnn.LecturaBD(15)
            Return True
        Else
            Return False
        End If
        Cnn.LecturaBD.Close()
    End Function

    Public Shared Function LeerHorasRegistradas(ByVal IdFolio As Integer, Operacion As Integer) As Boolean
        Cnn.LecturaQry("PA_HorasProdParo '" & IdFolio & "','" & SessionUser._sCentro.Trim & "','','','','','','','','','','','','','','',''," & Operacion & "")

        If (Cnn.LecturaBD.Read) Then
            ConsultaHoras.rIdTiempos = Cnn.LecturaBD(0)
            ConsultaHoras.rOrden = Cnn.LecturaBD(1)
            ConsultaHoras.rIdPuestoTrabajo = Cnn.LecturaBD(2)
            ConsultaHoras.rPuestoTrabajo = Cnn.LecturaBD(3)
            ConsultaHoras.rIdProducto = Cnn.LecturaBD(4)
            ConsultaHoras.rProducto = Cnn.LecturaBD(5)
            ConsultaHoras.rIdGrupProd = Cnn.LecturaBD(6)
            ConsultaHoras.rGrupProd = Cnn.LecturaBD(7)
            ConsultaHoras.rGrupProdDesc = Cnn.LecturaBD(8)
            ConsultaHoras.rIdSeccion = Cnn.LecturaBD(9)
            ConsultaHoras.rCodSeccion = Cnn.LecturaBD(10)
            ConsultaHoras.rSeccion = Cnn.LecturaBD(11)
            ConsultaHoras.rIdGrupMaterial = Cnn.LecturaBD(12)
            ConsultaHoras.rClaveGrupMaterial = Cnn.LecturaBD(13)
            ConsultaHoras.rGrupMaterial = Cnn.LecturaBD(14)
            ConsultaHoras.rPesoTeorico = Cnn.LecturaBD(15)
            ConsultaHoras.rTurno = Cnn.LecturaBD(16)
            ConsultaHoras.rIdGrupoParos = Cnn.LecturaBD(17)
            ConsultaHoras.rGrupoParos = Cnn.LecturaBD(18)
            ConsultaHoras.rIdParoProduccion = Cnn.LecturaBD(19)
            ConsultaHoras.rCodigoParo = Cnn.LecturaBD(20)
            ConsultaHoras.rConceptoParo = Cnn.LecturaBD(21)
            ConsultaHoras.rFecha = Cnn.LecturaBD(22)
            Return True
        Else
            Return False
        End If
        Cnn.LecturaBD.Close()
    End Function

    Public Shared Function LeerEquipo(ByVal Equipo As String, Operacion As Integer) As Boolean


        Cnn.LecturaQry("PA_OrdenesProduccion '','" & SessionUser._sCentro.Trim & "','" & Equipo.Trim & "','0000','','','','','','',''," & Operacion & "")

        If (Cnn.LecturaBD.Read) Then
            ReadWorkCenter.rCentro = Cnn.LecturaBD(0)
            ReadWorkCenter.rIdPuestoTrabajo = Cnn.LecturaBD(1)
            ReadWorkCenter.rPuestoTrabajo = Cnn.LecturaBD(2)
            ReadWorkCenter.rIdProducto = Cnn.LecturaBD(3)
            ReadWorkCenter.rProducto = Cnn.LecturaBD(4)
            ReadWorkCenter.rIdGrupProd = Cnn.LecturaBD(5)
            ReadWorkCenter.rGrupProd = Cnn.LecturaBD(6)
            ReadWorkCenter.rGrupProdDesc = Cnn.LecturaBD(7)
            ReadWorkCenter.rIdSeccion = Cnn.LecturaBD(8)
            ReadWorkCenter.rCodSeccion = Cnn.LecturaBD(9)
            ReadWorkCenter.rSeccion = Cnn.LecturaBD(10)
            ReadWorkCenter.rIdGrupMaterial = Cnn.LecturaBD(11)
            ReadWorkCenter.rClaveGrupMaterial = Cnn.LecturaBD(12)
            ReadWorkCenter.rGrupMaterial = Cnn.LecturaBD(13)
            ReadWorkCenter.rPesoTeorico = Cnn.LecturaBD(14)
            Return True
        Else
            Return False
        End If
        Cnn.LecturaBD.Close()
    End Function
    Public Shared Sub abc(ByVal Operacion As Integer)
        Cnn.LecturaQry("PA_HorasProdParo '" & Tiemposabc._iIdTiempo & "','" & SessionUser._sCentro.Trim & "','" & Tiemposabc._iPuestoTrabajo.Trim & "','" & Tiemposabc._iOrden_Produccion.Trim & "','','" & Tiemposabc._iTurno.Trim & "','" & Tiemposabc._iIdGrupoCausa & "','" & Tiemposabc._iIdCausa & "','" & Tiemposabc._iHorasProdParo.Trim & "','','" & Tiemposabc._iUserRegistra.Trim & "','" & Tiemposabc._iFechaRegistra.Trim & "','" & Tiemposabc._iIdGrupo & "','" & Tiemposabc._iIdSeccion & "','" & Tiemposabc._iIdGrupoMaterial & "','',''," & Operacion & "")
    End Sub

    Public Shared Sub TotalHoras(ByVal DataGV As DataGridView, Operacion As Integer)

        Dim Q As String
        Dim RegCount As Integer
        Dim objDa As SqlDataAdapter
        Dim objDs As DataSet

        Q = ""
        Q = "PA_HorasProdParo '','','" & ConsultaHorasTotales._rPuestoTrabajo.Trim & "','" & ConsultaHorasTotales._rOrdenProduccion.Trim & "','" & ConsultaHorasTotales._rOrdenProduccionGenerica.Trim & "','','','','','','','','','','','" & ConsultaHorasTotales._rFIP.Trim & "','" & ConsultaHorasTotales._rFFP.Trim & "'," & Operacion & ""
        Try
            objDa = New SqlDataAdapter(Q, Cnn.MSI(SessionUser._sAmbiente))
            objDs = New DataSet
            objDa.Fill(objDs)
            DataGV.DataSource = objDs.Tables(0)
            RegCount = DataGV.RowCount

            DataGV.Columns(0).HeaderText = "Fecha"
            DataGV.Columns(1).HeaderText = "Puesto Trabajo"
            DataGV.Columns(2).HeaderText = "Orden Producción"
            DataGV.Columns(3).HeaderText = "Turno"
            DataGV.Columns(4).HeaderText = "Total Horas Reportadas"
        Catch ex As Exception
            MessageBox.Show("Error Conexion :" & ex.Message, "ORDENES PROCESO")
        End Try
    End Sub

    Public Shared Sub DetalleHoras(ByVal DataGV As DataGridView, Operacion As Integer)

        Dim Q As String
        Dim RegCount As Integer
        Dim objDa As SqlDataAdapter
        Dim objDs As DataSet

        Q = ""
        Q = "PA_HorasProdParo '','','" & ConsultaHorasDetalle._PuestoTrabajo.Trim & "','','','" & ConsultaHorasDetalle._Turno.Trim & "','','','','','','','','','','" & ConsultaHorasDetalle._Fecha.Trim & "',''," & Operacion & ""
        Try
            objDa = New SqlDataAdapter(Q, Cnn.MSI(SessionUser._sAmbiente))
            objDs = New DataSet
            objDa.Fill(objDs)
            DataGV.DataSource = objDs.Tables(0)
            RegCount = DataGV.RowCount

            DataGV.Columns(0).HeaderText = "Folio"
            DataGV.Columns(1).HeaderText = "Fecha"
            DataGV.Columns(2).HeaderText = "Orden Producción"
            DataGV.Columns(3).HeaderText = "Puesto Trabajo"
            DataGV.Columns(4).HeaderText = "Turno"
            DataGV.Columns(5).Visible = False   'Id Grupo Paros
            DataGV.Columns(6).HeaderText = "Grupo Paro"
            DataGV.Columns(7).Visible = False   'Id Paro Producción
            DataGV.Columns(8).HeaderText = "Código Paro"
            DataGV.Columns(9).HeaderText = "Concepto Paro"
            DataGV.Columns(10).HeaderText = "Horas"
            DataGV.Columns(11).Visible = False   'Estatus
        Catch ex As Exception
            MessageBox.Show("Error Conexion :" & ex.Message, "ORDENES PROCESO")
        End Try
    End Sub

    Public Shared Function ValidaHoras(ByVal Operacion As Integer, Turno As String, OrdenProduccion As String, Fecha As String) As Boolean
        Cnn.LecturaQry("PA_HorasProdParo '','','','" & OrdenProduccion.Trim & "','','" & Turno.Trim & "','','','','','','" & Fecha.Trim & "','','','','',''," & Operacion & "")

        If (Cnn.LecturaBD.Read) Then
            TiemposReportados.Horas = Cnn.LecturaBD(0)
            Return True
        Else
            Return False
        End If
        Cnn.LecturaBD.Close()
    End Function

    Public Shared Sub dgvEstatusAvanceHoras(DGV As DataGridView, Columna As Integer, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs)
        Dim TotalHoras As Integer
        TotalHoras = (DGV.Rows(e.RowIndex).Cells(Columna).Value)

        If TotalHoras = 8 Then
            e.CellStyle.BackColor = Color.LightGreen
            e.CellStyle.ForeColor = Color.Black
        Else
            e.CellStyle.BackColor = Color.Yellow
            e.CellStyle.ForeColor = Color.Black
        End If
    End Sub

    Public Shared Sub dgvEstatusDetalleHoras(DGV As DataGridView, Columna As Integer, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs)
        Dim Detalle As Integer
        Detalle = (DGV.Rows(e.RowIndex).Cells(Columna).Value)

        If Detalle = 1 Then
            e.CellStyle.BackColor = Color.Aquamarine
            e.CellStyle.ForeColor = Color.Black
        ElseIf Detalle = 0 Then
            e.CellStyle.BackColor = Color.LightCoral
            e.CellStyle.ForeColor = Color.Black
        End If
    End Sub
End Class
