Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports SQL_DATA
Public Class Adm_Calidad
    Public Shared Sub Orden_Produccion(ByVal DataGV As DataGridView, Operacion As Integer)
        Dim Q As String
        Dim objDa As SqlDataAdapter
        Dim objDs As DataSet

        Q = ""
        Q = "PA_DetalleProduccion '" & ProduccionConsulta._cFI.Trim & "','" & ProduccionConsulta._cFF.Trim & "','" & ProduccionConsulta._cCentro.Trim & "','" & ProduccionConsulta._cOrden.Trim & "', '" & ProduccionConsulta._cTurno.Trim & "', " & Operacion & ""
        Try
            objDa = New SqlDataAdapter(Q, Cnn.MSI(SessionUser._sAmbiente))
            objDs = New DataSet
            objDa.Fill(objDs)
            DataGV.DataSource = objDs.Tables(0)
        Catch ex As Exception
            MessageBox.Show("Error Conexion :" & ex.Message, "ORDENES PROCESO")
        End Try
        DataGV.Columns(0).HeaderText = "Orden Producción"
        DataGV.Columns(1).HeaderText = "Folio"
        DataGV.Columns(2).HeaderText = "Centro"
        DataGV.Columns(3).HeaderText = "Area"
        DataGV.Columns(4).HeaderText = "Id Producto"
        DataGV.Columns(5).HeaderText = "Fecha Pesaje"
        DataGV.Columns(6).HeaderText = "Hora Pesaje"
        DataGV.Columns(7).HeaderText = "Bascula"
        DataGV.Columns(8).HeaderText = "Unidades"
        DataGV.Columns(9).HeaderText = "Rack"
        DataGV.Columns(10).HeaderText = "Peso Bruto"
        DataGV.Columns(11).HeaderText = "Peso Tara"
        DataGV.Columns(12).HeaderText = "Peso Neto"
        DataGV.Columns(13).HeaderText = "Peso Teórico"
        DataGV.Columns(14).HeaderText = "Cantidad Empaques"
        DataGV.Columns(15).HeaderText = "Notificador"
        DataGV.Columns(16).HeaderText = "Numero Empleado"
        DataGV.Columns(17).HeaderText = "Turno"
        DataGV.Columns(18).HeaderText = "Documento SAP"
        DataGV.Columns(19).HeaderText = "Consecutivo SAP"
        DataGV.Columns(20).HeaderText = "Sobre Peso"
        DataGV.Columns(21).HeaderText = "Puesto de Trabajo"
        DataGV.Columns(22).HeaderText = "Estatus de la notificación"
        DataGV.Columns(23).HeaderText = "Mensaje de la notificación"
        DataGV.Columns(24).Visible = False  'Notifica

    End Sub

    Public Shared Sub Orden_Scrap(ByVal DataGV As DataGridView)
        Dim Q As String
        Dim objDa As SqlDataAdapter
        Dim objDs As DataSet

        Q = ""
        Q = "PA_Calidad '" & ProduccionConsulta._cCentro.Trim & "','" & ProduccionConsulta._cFI.Trim & "','" & ProduccionConsulta._cFF.Trim & "','','','" & ProduccionConsulta._cTurno.Trim & "','',3"
        Try
            objDa = New SqlDataAdapter(Q, Cnn.MSI(SessionUser._sAmbiente))
            objDs = New DataSet
            objDa.Fill(objDs)
            DataGV.DataSource = objDs.Tables(0)
        Catch ex As Exception
            MessageBox.Show("Error Conexion :" & ex.Message, "ORDENES PROCESO")
        End Try
        DataGV.Columns(0).HeaderText = "Orden Producción"
        DataGV.Columns(1).HeaderText = "Folio"
        DataGV.Columns(2).HeaderText = "Centro"
        DataGV.Columns(3).HeaderText = "Area"
        DataGV.Columns(4).HeaderText = "Id Producto"
        DataGV.Columns(5).HeaderText = "Fecha Pesaje"
        DataGV.Columns(6).HeaderText = "Hora Pesaje"
        DataGV.Columns(7).HeaderText = "Bascula"
        DataGV.Columns(8).HeaderText = "Rack"
        DataGV.Columns(9).HeaderText = "Peso Bruto"
        DataGV.Columns(10).HeaderText = "Peso Tara"
        DataGV.Columns(11).HeaderText = "Peso Neto"
        DataGV.Columns(12).HeaderText = "Notificador"
        DataGV.Columns(13).HeaderText = "Numero Empleado"
        DataGV.Columns(14).HeaderText = "Turno"
        DataGV.Columns(15).HeaderText = "Documento SAP"
        DataGV.Columns(16).HeaderText = "Consecutivo SAP"
        DataGV.Columns(17).HeaderText = "Id Causa"
        DataGV.Columns(18).HeaderText = "Id Efecto"
        DataGV.Columns(19).HeaderText = "Causa"
        DataGV.Columns(20).HeaderText = "Efecto"
        DataGV.Columns(21).HeaderText = "Puesto de Trabajo"
        DataGV.Columns(22).HeaderText = "Estatus de la notificación"
        DataGV.Columns(23).HeaderText = "Mensaje de la notificación"
        DataGV.Columns(24).Visible = False  'Notifica

    End Sub

    Public Shared Sub Orden_Resumen(ByVal DataGV As DataGridView)
        Cnn.LecturaQry("PA_Calidad '" & AvanceProduccionConsulta._cCentro.Trim & "','" & AvanceProduccionConsulta._cFI.Trim & "','" & AvanceProduccionConsulta._cFF.Trim & "','','','" & AvanceProduccionConsulta._cTurno.Trim & "','',1")
        Do While (Cnn.LecturaBD.Read)
            AvanceResumen.rOrdenProduccion = Cnn.LecturaBD(0)
            AvanceResumen.rEstatusOrden = Cnn.LecturaBD(1)
            AvanceResumen.rPuestoTrabajo = Cnn.LecturaBD(2)
            AvanceResumen.rProduccionkg = Cnn.LecturaBD(3)
            AvanceResumen.rScrapkg = Cnn.LecturaBD(4)
            AvanceResumen.rSobrepesokg = Cnn.LecturaBD(5)
            AvanceResumen.rTeoricokg = Cnn.LecturaBD(6)
            AvanceResumen.rPorcScrap = Cnn.LecturaBD(7)
            AvanceResumen.rPorcSobrepeso = Cnn.LecturaBD(8)
            AvanceResumen.rTramosRequeridos = Cnn.LecturaBD(9)
            AvanceResumen.rTramosproducidos = Cnn.LecturaBD(10)
            AvanceResumen.rPendienteProducir = Cnn.LecturaBD(11)
            AvanceResumen.rAvance = Cnn.LecturaBD(12)
            AvanceResumen.rEstatusAvance = Cnn.LecturaBD(13)
            Dim arrConsulta() As Object = {AvanceResumen._rOrdenProduccion.Trim, AvanceResumen._rEstatusOrden.Trim, AvanceResumen._rPuestoTrabajo.Trim, AvanceResumen._rProduccionkg.Trim, AvanceResumen._rScrapkg.Trim, AvanceResumen._rSobrepesokg.Trim, AvanceResumen._rTeoricokg.Trim, AvanceResumen._rPorcScrap.Trim, AvanceResumen._rPorcSobrepeso.Trim, AvanceResumen._rTramosRequeridos.Trim, AvanceResumen._rTramosproducidos.Trim, AvanceResumen._rPendienteProducir.Trim, AvanceResumen._rAvance.Trim, AvanceResumen._rEstatusAvance.Trim} 'Creamos un nuevo arreglo con los datos a agregar.               
            DataGV.Rows.Add(arrConsulta) 'Agregamos el arreglo de datos a las filas del DataGrid
            DataGV.Refresh()
        Loop
        Cnn.LecturaBD.Close()

        Cnn.LecturaQry("PA_Calidad '" & AvanceProduccionConsulta._cCentro.Trim & "','" & AvanceProduccionConsulta._cFI.Trim & "','" & AvanceProduccionConsulta._cFF.Trim & "','','','" & AvanceProduccionConsulta._cTurno.Trim & "','',7")
        Do While (Cnn.LecturaBD.Read)
            AvanceGlobal.rPorcentajeScrap = Cnn.LecturaBD(0)
            AvanceGlobal.rPorcenatejSobrepeso = Cnn.LecturaBD(1)
        Loop
        Cnn.LecturaBD.Close()

    End Sub

    Public Shared Sub ResumenOrden(ByVal DataGV As DataGridView)
        Cnn.LecturaQry("PA_ResumenProduccion '" & ResumenProduccionPlantas._cFI.Trim & "','" & ResumenProduccionPlantas._cFF.Trim & "',1")
        Do While (Cnn.LecturaBD.Read)
            AvanceResumen.rOrdenProduccion = Cnn.LecturaBD(0)
            AvanceResumen.rCentro = Cnn.LecturaBD(1)
            AvanceResumen.rEstatusOrden = Cnn.LecturaBD(2)
            AvanceResumen.rPuestoTrabajo = Cnn.LecturaBD(3)
            AvanceResumen.rProduccionkg = Cnn.LecturaBD(4)
            AvanceResumen.rScrapkg = Cnn.LecturaBD(5)
            AvanceResumen.rSobrepesokg = Cnn.LecturaBD(6)
            AvanceResumen.rTeoricokg = Cnn.LecturaBD(7)
            AvanceResumen.rPorcScrap = Cnn.LecturaBD(8)
            AvanceResumen.rPorcSobrepeso = Cnn.LecturaBD(9)
            AvanceResumen.rTramosRequeridos = Cnn.LecturaBD(10)
            AvanceResumen.rTramosproducidos = Cnn.LecturaBD(11)
            AvanceResumen.rPendienteProducir = Cnn.LecturaBD(12)
            AvanceResumen.rAvance = Cnn.LecturaBD(13)
            AvanceResumen.rEstatusAvance = Cnn.LecturaBD(14)
            Dim arrConsulta() As Object = {AvanceResumen._rOrdenProduccion.Trim, AvanceResumen._rCentro.Trim, AvanceResumen._rEstatusOrden.Trim, AvanceResumen._rPuestoTrabajo.Trim, AvanceResumen._rProduccionkg.Trim, AvanceResumen._rScrapkg.Trim, AvanceResumen._rSobrepesokg.Trim, AvanceResumen._rTeoricokg.Trim, AvanceResumen._rPorcScrap.Trim, AvanceResumen._rPorcSobrepeso.Trim, AvanceResumen._rTramosRequeridos.Trim, AvanceResumen._rTramosproducidos.Trim, AvanceResumen._rPendienteProducir.Trim, AvanceResumen._rAvance.Trim, AvanceResumen._rEstatusAvance.Trim} 'Creamos un nuevo arreglo con los datos a agregar.               
            DataGV.Rows.Add(arrConsulta) 'Agregamos el arreglo de datos a las filas del DataGrid
            DataGV.Refresh()
        Loop
        Cnn.LecturaBD.Close()

        Cnn.LecturaQry("PA_ResumenProduccion '" & ResumenProduccionPlantas._cFI.Trim & "','" & ResumenProduccionPlantas._cFF.Trim & "',3")
        Do While (Cnn.LecturaBD.Read)
            AvanceGlobal.rPorcentajeScrap = Cnn.LecturaBD(0)
            AvanceGlobal.rPorcenatejSobrepeso = Cnn.LecturaBD(1)
        Loop
        Cnn.LecturaBD.Close()

    End Sub

    Public Shared Sub Equipo_Produccion(ByVal DataGV As DataGridView)
        Dim Q As String
        Dim objDa As SqlDataAdapter
        Dim objDs As DataSet

        Q = ""
        Q = "PA_Calidad '" & ProduccionConsulta._cCentro.Trim & "','" & ProduccionConsulta._cFI.Trim & "','" & ProduccionConsulta._cFF.Trim & "','','','" & ProduccionConsulta._cTurno.Trim & "','',5"
        Try
            objDa = New SqlDataAdapter(Q, Cnn.MSI(SessionUser._sAmbiente))
            objDs = New DataSet
            objDa.Fill(objDs)
            DataGV.DataSource = objDs.Tables(0)
        Catch ex As Exception
            MessageBox.Show("Error Conexion :" & ex.Message, "ORDENES PROCESO")
        End Try
        DataGV.Columns(0).HeaderText = "Orden Producción"
        DataGV.Columns(1).HeaderText = "Folio"
        DataGV.Columns(2).HeaderText = "Centro"
        DataGV.Columns(3).HeaderText = "Area"
        DataGV.Columns(4).HeaderText = "Id Producto"
        DataGV.Columns(5).HeaderText = "Fecha Pesaje"
        DataGV.Columns(6).HeaderText = "Hora Pesaje"
        DataGV.Columns(7).HeaderText = "Bascula"
        DataGV.Columns(8).HeaderText = "Unidades"
        DataGV.Columns(9).HeaderText = "Rack"
        DataGV.Columns(10).HeaderText = "Peso Bruto"
        DataGV.Columns(11).HeaderText = "Peso Tara"
        DataGV.Columns(12).HeaderText = "Peso Neto"
        DataGV.Columns(13).HeaderText = "Peso Teórico"
        DataGV.Columns(14).HeaderText = "Cantidad Empaques"
        DataGV.Columns(15).HeaderText = "Notificador"
        DataGV.Columns(16).HeaderText = "Numero Empleado"
        DataGV.Columns(17).HeaderText = "Turno"
        DataGV.Columns(18).HeaderText = "Documento SAP"
        DataGV.Columns(19).HeaderText = "Consecutivo SAP"
        DataGV.Columns(20).HeaderText = "Sobre Peso"
        DataGV.Columns(21).HeaderText = "Puesto de Trabajo"
        DataGV.Columns(22).HeaderText = "Estatus de la notificación"
        DataGV.Columns(23).HeaderText = "Mensaje de la notificación"
        DataGV.Columns(24).Visible = False  'Notifica

    End Sub

    Public Shared Sub Equipo_Scrap(ByVal DataGV As DataGridView)
        Dim Q As String
        Dim objDa As SqlDataAdapter
        Dim objDs As DataSet

        Q = ""
        Q = "PA_Calidad '" & ProduccionConsulta._cCentro.Trim & "','" & ProduccionConsulta._cFI.Trim & "','" & ProduccionConsulta._cFF.Trim & "','','','" & ProduccionConsulta._cTurno.Trim & "','',6"
        Try
            objDa = New SqlDataAdapter(Q, Cnn.MSI(SessionUser._sAmbiente))
            objDs = New DataSet
            objDa.Fill(objDs)
            DataGV.DataSource = objDs.Tables(0)
        Catch ex As Exception
            MessageBox.Show("Error Conexion :" & ex.Message, "ORDENES PROCESO")
        End Try
        DataGV.Columns(0).HeaderText = "Orden Producción"
        DataGV.Columns(1).HeaderText = "Folio"
        DataGV.Columns(2).HeaderText = "Centro"
        DataGV.Columns(3).HeaderText = "Area"
        DataGV.Columns(4).HeaderText = "Id Producto"
        DataGV.Columns(5).HeaderText = "Fecha Pesaje"
        DataGV.Columns(6).HeaderText = "Hora Pesaje"
        DataGV.Columns(7).HeaderText = "Bascula"
        DataGV.Columns(8).HeaderText = "Rack"
        DataGV.Columns(9).HeaderText = "Peso Bruto"
        DataGV.Columns(10).HeaderText = "Peso Tara"
        DataGV.Columns(11).HeaderText = "Peso Neto"
        DataGV.Columns(12).HeaderText = "Notificador"
        DataGV.Columns(13).HeaderText = "Numero Empleado"
        DataGV.Columns(14).HeaderText = "Turno"
        DataGV.Columns(15).HeaderText = "Documento SAP"
        DataGV.Columns(16).HeaderText = "Consecutivo SAP"
        DataGV.Columns(17).HeaderText = "Id Causa"
        DataGV.Columns(18).HeaderText = "Id Efecto"
        DataGV.Columns(19).HeaderText = "Causa"
        DataGV.Columns(20).HeaderText = "Efecto"
        DataGV.Columns(21).HeaderText = "Puesto de Trabajo"
        DataGV.Columns(22).HeaderText = "Estatus de la notificación"
        DataGV.Columns(23).HeaderText = "Mensaje de la notificación"
        DataGV.Columns(24).Visible = False  'Notifica

    End Sub

    Public Shared Sub Equipo_Resumen(ByVal DataGV As DataGridView)
        Cnn.LecturaQry("PA_Calidad '" & AvanceProduccionConsulta._cCentro.Trim & "','" & AvanceProduccionConsulta.cFI.Trim & "','" & AvanceProduccionConsulta.cFF.Trim & "','','','" & AvanceProduccionConsulta.cTurno.Trim & "','',4")
        Do While (Cnn.LecturaBD.Read)
            AvanceResumen.rPuestoTrabajo = Cnn.LecturaBD(0)
            AvanceResumen.rEstatusOrden = Cnn.LecturaBD(1)
            AvanceResumen.rOrdenProduccion = Cnn.LecturaBD(2)
            AvanceResumen.rProduccionkg = Cnn.LecturaBD(3)
            AvanceResumen.rScrapkg = Cnn.LecturaBD(4)
            AvanceResumen.rSobrepesokg = Cnn.LecturaBD(5)
            AvanceResumen.rTeoricokg = Cnn.LecturaBD(6)
            AvanceResumen.rPorcScrap = Cnn.LecturaBD(7)
            AvanceResumen.rPorcSobrepeso = Cnn.LecturaBD(8)
            AvanceResumen.rTramosRequeridos = Cnn.LecturaBD(9)
            AvanceResumen.rTramosproducidos = Cnn.LecturaBD(10)
            AvanceResumen.rPendienteProducir = Cnn.LecturaBD(11)
            AvanceResumen.rAvance = Cnn.LecturaBD(12)
            AvanceResumen.rEstatusAvance = Cnn.LecturaBD(13)
            Dim arrConsulta() As Object = {AvanceResumen._rPuestoTrabajo.Trim, AvanceResumen._rEstatusOrden.Trim, AvanceResumen._rOrdenProduccion.Trim, AvanceResumen._rProduccionkg.Trim, AvanceResumen._rScrapkg.Trim, AvanceResumen._rSobrepesokg.Trim, AvanceResumen._rTeoricokg.Trim, AvanceResumen._rPorcScrap.Trim, AvanceResumen._rPorcSobrepeso.Trim, AvanceResumen._rTramosRequeridos.Trim, AvanceResumen._rTramosproducidos.Trim, AvanceResumen._rPendienteProducir.Trim, AvanceResumen._rAvance.Trim, AvanceResumen._rEstatusAvance.Trim} 'Creamos un nuevo arreglo con los datos a agregar.               
            DataGV.Rows.Add(arrConsulta) 'Agregamos el arreglo de datos a las filas del DataGrid
            DataGV.Refresh()
        Loop
        Cnn.LecturaBD.Close()

        Cnn.LecturaQry("PA_Calidad '" & AvanceProduccionConsulta._cCentro.Trim & "','" & AvanceProduccionConsulta._cFI.Trim & "','" & AvanceProduccionConsulta._cFF.Trim & "','','','" & AvanceProduccionConsulta._cTurno.Trim & "','',7")
        Do While (Cnn.LecturaBD.Read)
            AvanceGlobal.rPorcentajeScrap = Cnn.LecturaBD(0)
            AvanceGlobal.rPorcenatejSobrepeso = Cnn.LecturaBD(1)
        Loop
        Cnn.LecturaBD.Close()
    End Sub

    Public Shared Sub ResumenEquipos(ByVal DataGV As DataGridView)
        Cnn.LecturaQry("PA_ResumenProduccion '" & ResumenProduccionPlantas._cFI.Trim & "','" & ResumenProduccionPlantas._cFF.Trim & "',2")
        Do While (Cnn.LecturaBD.Read)
            AvanceResumen.rPuestoTrabajo = Cnn.LecturaBD(0)
            AvanceResumen.rCentro = Cnn.LecturaBD(1)
            AvanceResumen.rEstatusOrden = Cnn.LecturaBD(2)
            AvanceResumen.rOrdenProduccion = Cnn.LecturaBD(3)
            AvanceResumen.rProduccionkg = Cnn.LecturaBD(4)
            AvanceResumen.rScrapkg = Cnn.LecturaBD(5)
            AvanceResumen.rSobrepesokg = Cnn.LecturaBD(6)
            AvanceResumen.rTeoricokg = Cnn.LecturaBD(7)
            AvanceResumen.rPorcScrap = Cnn.LecturaBD(8)
            AvanceResumen.rPorcSobrepeso = Cnn.LecturaBD(9)
            AvanceResumen.rTramosRequeridos = Cnn.LecturaBD(10)
            AvanceResumen.rTramosproducidos = Cnn.LecturaBD(11)
            AvanceResumen.rPendienteProducir = Cnn.LecturaBD(12)
            AvanceResumen.rAvance = Cnn.LecturaBD(13)
            AvanceResumen.rEstatusAvance = Cnn.LecturaBD(14)
            Dim arrConsulta() As Object = {AvanceResumen._rPuestoTrabajo.Trim, AvanceResumen._rCentro.Trim, AvanceResumen._rEstatusOrden.Trim, AvanceResumen._rOrdenProduccion.Trim, AvanceResumen._rProduccionkg.Trim, AvanceResumen._rScrapkg.Trim, AvanceResumen._rSobrepesokg.Trim, AvanceResumen._rTeoricokg.Trim, AvanceResumen._rPorcScrap.Trim, AvanceResumen._rPorcSobrepeso.Trim, AvanceResumen._rTramosRequeridos.Trim, AvanceResumen._rTramosproducidos.Trim, AvanceResumen._rPendienteProducir.Trim, AvanceResumen._rAvance.Trim, AvanceResumen._rEstatusAvance.Trim} 'Creamos un nuevo arreglo con los datos a agregar.               
            DataGV.Rows.Add(arrConsulta) 'Agregamos el arreglo de datos a las filas del DataGrid
            DataGV.Refresh()
        Loop
        Cnn.LecturaBD.Close()

        Cnn.LecturaQry("PA_ResumenProduccion '" & ResumenProduccionPlantas._cFI.Trim & "','" & ResumenProduccionPlantas._cFF.Trim & "',3")
        Do While (Cnn.LecturaBD.Read)
            AvanceGlobal.rPorcentajeScrap = Cnn.LecturaBD(0)
            AvanceGlobal.rPorcenatejSobrepeso = Cnn.LecturaBD(1)
        Loop
        Cnn.LecturaBD.Close()

    End Sub
End Class
