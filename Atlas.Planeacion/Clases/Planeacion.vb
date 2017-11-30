Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports SQL_DATA
Public Class Planeacion
    Public Shared Sub Orden_Produccion(ByVal DataGV As DataGridView)
        Dim Q As String
        Dim objDa As SqlDataAdapter
        Dim objDs As DataSet

        Q = ""
        Q = "PA_Planeacion '" & ProduccionConsulta._cCentro.Trim & "','" & ProduccionConsulta._cFI.Trim & "','" & ProduccionConsulta._cFF.Trim & "','" & ProduccionConsulta._cHI.Trim & "', '" & ProduccionConsulta._cHF.Trim & "','" & ProduccionConsulta._cOrden.Trim & "','','" & ProduccionConsulta._cTurno.Trim & "','',2"
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
        Q = "PA_Planeacion '" & ProduccionConsulta._cCentro.Trim & "','" & ProduccionConsulta._cFI.Trim & "','" & ProduccionConsulta._cFF.Trim & "','" & ProduccionConsulta._cHI.Trim & "', '" & ProduccionConsulta._cHF.Trim & "','" & ProduccionConsulta._cOrden.Trim & "','','" & ProduccionConsulta._cTurno.Trim & "','',3"
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
        Cnn.LecturaQry("PA_Planeacion '" & ProduccionConsulta._cCentro.Trim & "','" & ProduccionConsulta._cFI.Trim & "','" & ProduccionConsulta._cFF.Trim & "','" & ProduccionConsulta._cHI.Trim & "', '" & ProduccionConsulta._cHF.Trim & "','" & ProduccionConsulta._cOrden.Trim & "','','" & ProduccionConsulta._cTurno.Trim & "','',1")
        Do While (Cnn.LecturaBD.Read)

            PlaneacionResumen.rOrdenProduccion = Cnn.LecturaBD(0)
            PlaneacionResumen.rEstatusOrden = Cnn.LecturaBD(1)
            PlaneacionResumen.rPuestoTrabajo = Cnn.LecturaBD(2)
            PlaneacionResumen.rProduccionkg = Cnn.LecturaBD(3)
            PlaneacionResumen.rScrapkg = Cnn.LecturaBD(4)
            PlaneacionResumen.rSobrepesokg = Cnn.LecturaBD(5)
            PlaneacionResumen.rTeoricokg = Cnn.LecturaBD(6)
            PlaneacionResumen.rPorcScrap = Cnn.LecturaBD(7)
            PlaneacionResumen.rPorcSobrepeso = Cnn.LecturaBD(8)
            PlaneacionResumen.rTramosRequeridos = Cnn.LecturaBD(9)
            PlaneacionResumen.rTramosproducidos = Cnn.LecturaBD(10)
            PlaneacionResumen.rPendienteProducir = Cnn.LecturaBD(11)
            PlaneacionResumen.rAvance = Cnn.LecturaBD(12)
            PlaneacionResumen.rEstatusAvance = Cnn.LecturaBD(13)
            Dim arrConsulta() As Object = {PlaneacionResumen._rOrdenProduccion.Trim, PlaneacionResumen._rEstatusOrden.Trim, PlaneacionResumen._rPuestoTrabajo.Trim, PlaneacionResumen._rProduccionkg.Trim, PlaneacionResumen._rScrapkg.Trim, PlaneacionResumen._rSobrepesokg.Trim, PlaneacionResumen._rTeoricokg.Trim, PlaneacionResumen._rPorcScrap.Trim, PlaneacionResumen._rPorcSobrepeso.Trim, PlaneacionResumen._rTramosRequeridos.Trim, PlaneacionResumen._rTramosproducidos.Trim, PlaneacionResumen._rPendienteProducir.Trim, PlaneacionResumen._rAvance.Trim, PlaneacionResumen._rEstatusAvance.Trim} 'Creamos un nuevo arreglo con los datos a agregar.               
            DataGV.Rows.Add(arrConsulta) 'Agregamos el arreglo de datos a las filas del DataGrid
            DataGV.Refresh()
        Loop
        Cnn.LecturaBD.Close()


        Cnn.LecturaQry("PA_Planeacion '" & ProduccionConsulta._cCentro.Trim & "','" & ProduccionConsulta._cFI.Trim & "','" & ProduccionConsulta._cFF.Trim & "','" & ProduccionConsulta._cHI.Trim & "', '" & ProduccionConsulta._cHF.Trim & "','" & ProduccionConsulta._cOrden.Trim & "','','" & ProduccionConsulta._cTurno.Trim & "','',8")
        Do While (Cnn.LecturaBD.Read)

            ResumenOrdenEquipo.rProduccionkg = Cnn.LecturaBD(0)
            ResumenOrdenEquipo.rScrapkg = Cnn.LecturaBD(1)
            ResumenOrdenEquipo.rSobrepesokg = Cnn.LecturaBD(2)
            ResumenOrdenEquipo.rTeoricokg = Cnn.LecturaBD(3)
            ResumenOrdenEquipo.rPorcScrap = Cnn.LecturaBD(4)
            ResumenOrdenEquipo.rPorcSobrepeso = Cnn.LecturaBD(5)
            ResumenOrdenEquipo.rTramosrequerdios = Cnn.LecturaBD(6)
            ResumenOrdenEquipo.rTramosproducidos = Cnn.LecturaBD(7)
            ResumenOrdenEquipo.rSaldo = Cnn.LecturaBD(8)
            ResumenOrdenEquipo.Porcavance = Cnn.LecturaBD(9)
        Loop
        Cnn.LecturaBD.Close()

    End Sub

    Public Shared Sub ResumenOrden(ByVal DataGV As DataGridView)
        Cnn.LecturaQry("PA_ResumenProduccion '" & ProduccionConsulta._cFI.Trim & "','" & ProduccionConsulta._cFF.Trim & "',5")
        Do While (Cnn.LecturaBD.Read)
            PlaneacionResumen.rOrdenProduccion = Cnn.LecturaBD(0)
            PlaneacionResumen.rCentro = Cnn.LecturaBD(1)
            PlaneacionResumen.rEstatusOrden = Cnn.LecturaBD(2)
            PlaneacionResumen.rPuestoTrabajo = Cnn.LecturaBD(3)
            PlaneacionResumen.rProduccionkg = Cnn.LecturaBD(4)
            PlaneacionResumen.rScrapkg = Cnn.LecturaBD(5)
            PlaneacionResumen.rSobrepesokg = Cnn.LecturaBD(6)
            PlaneacionResumen.rTeoricokg = Cnn.LecturaBD(7)
            PlaneacionResumen.rPorcScrap = Cnn.LecturaBD(8)
            PlaneacionResumen.rPorcSobrepeso = Cnn.LecturaBD(9)
            PlaneacionResumen.rTramosRequeridos = Cnn.LecturaBD(10)
            PlaneacionResumen.rTramosproducidos = Cnn.LecturaBD(11)
            PlaneacionResumen.rPendienteProducir = Cnn.LecturaBD(12)
            PlaneacionResumen.rAvance = Cnn.LecturaBD(13)
            PlaneacionResumen.rEstatusAvance = Cnn.LecturaBD(14)
            Dim arrConsulta() As Object = {PlaneacionResumen._rOrdenProduccion.Trim, PlaneacionResumen._rCentro.Trim, PlaneacionResumen._rEstatusOrden.Trim, PlaneacionResumen._rPuestoTrabajo.Trim, PlaneacionResumen._rProduccionkg.Trim, PlaneacionResumen._rScrapkg.Trim, PlaneacionResumen._rSobrepesokg.Trim, PlaneacionResumen._rTeoricokg.Trim, PlaneacionResumen._rPorcScrap.Trim, PlaneacionResumen._rPorcSobrepeso.Trim, PlaneacionResumen._rTramosRequeridos.Trim, PlaneacionResumen._rTramosproducidos.Trim, PlaneacionResumen._rPendienteProducir.Trim, PlaneacionResumen._rAvance.Trim, PlaneacionResumen._rEstatusAvance.Trim} 'Creamos un nuevo arreglo con los datos a agregar.               
            DataGV.Rows.Add(arrConsulta) 'Agregamos el arreglo de datos a las filas del DataGrid
            DataGV.Refresh()
        Loop
        Cnn.LecturaBD.Close()

        Cnn.LecturaQry("PA_ResumenProduccion '" & ProduccionConsulta._cFI.Trim & "','" & ProduccionConsulta._cFF.Trim & "',4")
        Do While (Cnn.LecturaBD.Read)
            ResumenOrdenEquipo.rProduccionkg = Cnn.LecturaBD(0)
            ResumenOrdenEquipo.rScrapkg = Cnn.LecturaBD(1)
            ResumenOrdenEquipo.rSobrepesokg = Cnn.LecturaBD(2)
            ResumenOrdenEquipo.rTeoricokg = Cnn.LecturaBD(3)
            ResumenOrdenEquipo.rPorcScrap = Cnn.LecturaBD(4)
            ResumenOrdenEquipo.rPorcSobrepeso = Cnn.LecturaBD(5)
            ResumenOrdenEquipo.rTramosrequerdios = Cnn.LecturaBD(6)
            ResumenOrdenEquipo.rTramosproducidos = Cnn.LecturaBD(7)
            ResumenOrdenEquipo.rSaldo = Cnn.LecturaBD(8)
            ResumenOrdenEquipo.Porcavance = Cnn.LecturaBD(9)
        Loop
        Cnn.LecturaBD.Close()

    End Sub

    Public Shared Sub Equipo_Produccion(ByVal DataGV As DataGridView)
        Dim Q As String
        Dim objDa As SqlDataAdapter
        Dim objDs As DataSet

        Q = ""
        Q = "PA_Planeacion '" & ProduccionConsulta._cCentro.Trim & "','" & ProduccionConsulta._cFI.Trim & "','" & ProduccionConsulta._cFF.Trim & "','" & ProduccionConsulta._cHI.Trim & "', '" & ProduccionConsulta._cHF.Trim & "','" & ProduccionConsulta._cOrden.Trim & "','','" & ProduccionConsulta._cTurno.Trim & "','',5"
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
        Q = "PA_Planeacion '" & ProduccionConsulta._cCentro.Trim & "','" & ProduccionConsulta._cFI.Trim & "','" & ProduccionConsulta._cFF.Trim & "','" & ProduccionConsulta._cHI.Trim & "', '" & ProduccionConsulta._cHF.Trim & "','" & ProduccionConsulta._cOrden.Trim & "','','" & ProduccionConsulta._cTurno.Trim & "','',6"
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
        Cnn.LecturaQry("PA_Planeacion '" & ProduccionConsulta._cCentro.Trim & "','" & ProduccionConsulta._cFI.Trim & "','" & ProduccionConsulta._cFF.Trim & "','" & ProduccionConsulta._cHI.Trim & "', '" & ProduccionConsulta._cHF.Trim & "','" & ProduccionConsulta._cOrden.Trim & "','','" & ProduccionConsulta._cTurno.Trim & "','',4")
        Do While (Cnn.LecturaBD.Read)
            PlaneacionResumen.rOrdenProduccion = Cnn.LecturaBD(0)
            PlaneacionResumen.rEstatusOrden = Cnn.LecturaBD(1)
            PlaneacionResumen.rPuestoTrabajo = Cnn.LecturaBD(2)
            PlaneacionResumen.rProduccionkg = Cnn.LecturaBD(3)
            PlaneacionResumen.rScrapkg = Cnn.LecturaBD(4)
            PlaneacionResumen.rSobrepesokg = Cnn.LecturaBD(5)
            PlaneacionResumen.rTeoricokg = Cnn.LecturaBD(6)
            PlaneacionResumen.rPorcScrap = Cnn.LecturaBD(7)
            PlaneacionResumen.rPorcSobrepeso = Cnn.LecturaBD(8)
            PlaneacionResumen.rTramosRequeridos = Cnn.LecturaBD(9)
            PlaneacionResumen.rTramosproducidos = Cnn.LecturaBD(10)
            PlaneacionResumen.rPendienteProducir = Cnn.LecturaBD(11)
            PlaneacionResumen.rAvance = Cnn.LecturaBD(12)
            PlaneacionResumen.rEstatusAvance = Cnn.LecturaBD(13)
            Dim arrConsulta() As Object = {PlaneacionResumen._rPuestoTrabajo.Trim, PlaneacionResumen._rEstatusOrden.Trim, PlaneacionResumen._rOrdenProduccion.Trim, PlaneacionResumen._rProduccionkg.Trim, PlaneacionResumen._rScrapkg.Trim, PlaneacionResumen._rSobrepesokg.Trim, PlaneacionResumen._rTeoricokg.Trim, PlaneacionResumen._rPorcScrap.Trim, PlaneacionResumen._rPorcSobrepeso.Trim, PlaneacionResumen._rTramosRequeridos.Trim, PlaneacionResumen._rTramosproducidos.Trim, PlaneacionResumen._rPendienteProducir.Trim, PlaneacionResumen._rAvance.Trim, PlaneacionResumen._rEstatusAvance.Trim} 'Creamos un nuevo arreglo con los datos a agregar.               
            DataGV.Rows.Add(arrConsulta) 'Agregamos el arreglo de datos a las filas del DataGrid
            DataGV.Refresh()
        Loop
        Cnn.LecturaBD.Close()

        Cnn.LecturaQry("PA_Planeacion '" & ProduccionConsulta._cCentro.Trim & "','" & ProduccionConsulta._cFI.Trim & "','" & ProduccionConsulta._cFF.Trim & "','" & ProduccionConsulta._cHI.Trim & "', '" & ProduccionConsulta._cHF.Trim & "','" & ProduccionConsulta._cOrden.Trim & "','','" & ProduccionConsulta._cTurno.Trim & "','',8")
        Do While (Cnn.LecturaBD.Read)

            ResumenOrdenEquipo.rProduccionkg = Cnn.LecturaBD(0)
            ResumenOrdenEquipo.rScrapkg = Cnn.LecturaBD(1)
            ResumenOrdenEquipo.rSobrepesokg = Cnn.LecturaBD(2)
            ResumenOrdenEquipo.rTeoricokg = Cnn.LecturaBD(3)
            ResumenOrdenEquipo.rPorcScrap = Cnn.LecturaBD(4)
            ResumenOrdenEquipo.rPorcSobrepeso = Cnn.LecturaBD(5)
            ResumenOrdenEquipo.rTramosrequerdios = Cnn.LecturaBD(6)
            ResumenOrdenEquipo.rTramosproducidos = Cnn.LecturaBD(7)
            ResumenOrdenEquipo.rSaldo = Cnn.LecturaBD(8)
            ResumenOrdenEquipo.Porcavance = Cnn.LecturaBD(9)
        Loop
        Cnn.LecturaBD.Close()
    End Sub

    Public Shared Sub ResumenEquipos(ByVal DataGV As DataGridView)
        Cnn.LecturaQry("PA_ResumenProduccion '" & ProduccionConsulta._cFI.Trim & "','" & ProduccionConsulta._cFF.Trim & "',6")
        Do While (Cnn.LecturaBD.Read)
            PlaneacionResumen.rPuestoTrabajo = Cnn.LecturaBD(0)
            PlaneacionResumen.rCentro = Cnn.LecturaBD(1)
            PlaneacionResumen.rEstatusOrden = Cnn.LecturaBD(2)
            PlaneacionResumen.rOrdenProduccion = Cnn.LecturaBD(3)
            PlaneacionResumen.rProduccionkg = Cnn.LecturaBD(4)
            PlaneacionResumen.rScrapkg = Cnn.LecturaBD(5)
            PlaneacionResumen.rSobrepesokg = Cnn.LecturaBD(6)
            PlaneacionResumen.rTeoricokg = Cnn.LecturaBD(7)
            PlaneacionResumen.rPorcScrap = Cnn.LecturaBD(8)
            PlaneacionResumen.rPorcSobrepeso = Cnn.LecturaBD(9)
            PlaneacionResumen.rTramosRequeridos = Cnn.LecturaBD(10)
            PlaneacionResumen.rTramosproducidos = Cnn.LecturaBD(11)
            PlaneacionResumen.rPendienteProducir = Cnn.LecturaBD(12)
            PlaneacionResumen.rAvance = Cnn.LecturaBD(13)
            PlaneacionResumen.rEstatusAvance = Cnn.LecturaBD(14)
            Dim arrConsulta() As Object = {PlaneacionResumen._rPuestoTrabajo.Trim, PlaneacionResumen._rCentro.Trim, PlaneacionResumen._rEstatusOrden.Trim, PlaneacionResumen._rOrdenProduccion.Trim, PlaneacionResumen._rProduccionkg.Trim, PlaneacionResumen._rScrapkg.Trim, PlaneacionResumen._rSobrepesokg.Trim, PlaneacionResumen._rTeoricokg.Trim, PlaneacionResumen._rPorcScrap.Trim, PlaneacionResumen._rPorcSobrepeso.Trim, PlaneacionResumen._rTramosRequeridos.Trim, PlaneacionResumen._rTramosproducidos.Trim, PlaneacionResumen._rPendienteProducir.Trim, PlaneacionResumen._rAvance.Trim, PlaneacionResumen._rEstatusAvance.Trim} 'Creamos un nuevo arreglo con los datos a agregar.               
            DataGV.Rows.Add(arrConsulta) 'Agregamos el arreglo de datos a las filas del DataGrid
            DataGV.Refresh()
        Loop
        Cnn.LecturaBD.Close()

        Cnn.LecturaQry("PA_ResumenProduccion '" & ProduccionConsulta._cFI.Trim & "','" & ProduccionConsulta._cFF.Trim & "',4")
        Do While (Cnn.LecturaBD.Read)
            ResumenOrdenEquipo.rProduccionkg = Cnn.LecturaBD(0)
            ResumenOrdenEquipo.rScrapkg = Cnn.LecturaBD(1)
            ResumenOrdenEquipo.rSobrepesokg = Cnn.LecturaBD(2)
            ResumenOrdenEquipo.rTeoricokg = Cnn.LecturaBD(3)
            ResumenOrdenEquipo.rPorcScrap = Cnn.LecturaBD(4)
            ResumenOrdenEquipo.rPorcSobrepeso = Cnn.LecturaBD(5)
            ResumenOrdenEquipo.rTramosrequerdios = Cnn.LecturaBD(6)
            ResumenOrdenEquipo.rTramosproducidos = Cnn.LecturaBD(7)
            ResumenOrdenEquipo.rSaldo = Cnn.LecturaBD(8)
            ResumenOrdenEquipo.Porcavance = Cnn.LecturaBD(9)
        Loop
        Cnn.LecturaBD.Close()

    End Sub

    Public Shared Sub ModificaOrden(ByVal Operacion As Integer)
        Try
            Cnn.LecturaQry("PA_OrdenesProduccion '" & dgvAvanceProduccion._rOrdenProduccion.Trim & "','" & ProduccionConsulta._cCentro.Trim & "','','','','','','','','','','" & Operacion & "'")
            MessageBox.Show("Modificación Exitosa")
        Catch ex As Exception
            MessageBox.Show("Error Conexion :" & ex.Message, "ORDENES PROCESO")
        End Try
    End Sub
End Class
