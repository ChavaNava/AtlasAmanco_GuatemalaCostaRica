Imports Utili_Generales
Imports WebServices
Imports System.Data.SqlClient

Public Class OrdenProduccion
    Public Shared T_ValidaOrden As New ValidaExistaODF
    Public Shared T_Orden As New OrdenSAP
    Public Shared T_OrdenDetalle As New OrdenDetalleSAP
    Public Shared Function ValExistencia(ByVal IdOrden As String) As Boolean
        LecturaQry("PA_OrdenesProduccion '" & IdOrden.Trim & "','" & SessionUser._sCentro.Trim & "','','','','','','','','','',7", SessionUser._sAmbiente)
        If (LecturaBD.Read) Then
            T_ValidaOrden.Orden = LecturaBD(0)
            T_ValidaOrden.Centro = LecturaBD(1)
            T_ValidaOrden.Equipo = LecturaBD(2)
            T_ValidaOrden.Codigo = LecturaBD(3)
            T_ValidaOrden.Cantidad = LecturaBD(4)
            T_ValidaOrden.Fecha_Inicio = LecturaBD(5)
            T_ValidaOrden.Fecha_Termino = LecturaBD(6)
            T_ValidaOrden.Origen = LecturaBD(7)
            T_ValidaOrden.Estatus = LecturaBD(8)
            Return True
        Else
            Return False
        End If
    End Function

    Public Shared Function Alta(ByVal Tipo As String, IdOrden As String) As Boolean
        Dim Head As String
        Dim Lista As New Generic.List(Of String)

        Dim File As String
        Dim Tbl() As String
        Dim SAP_Return As Object
        Dim Array() As String

        Head = "31" & "|" & IdOrden.Trim & "|" & "10" & "|" & Tipo

        WSG.Consume_WS(SessionUser._sAlias.Trim, Head, Lista, SessionUser._sAmbiente.Trim)
        Tbl = WSG.Tbl_resultado
        SAP_Return = WSG.Return_SAP


        Select Case SAP_Return.ZTYPE
            Case Is = "E"
                MensajeBox.Mostrar(SAP_Return.ZMESSAGE, "SAP", MensajeBox.TipoMensaje.Information, MensajeBox.TipoBoton.OkOnly)
                Return False
            Case Else

                For i = 0 To Tbl.Length - 1

                    File = Tbl(i)
                    Array = File.Split("|")

                    If Array(0) = "I" Then
                        T_Orden.Orden = Array(1)
                        T_Orden.Centro = Array(2)
                        T_Orden.Equipo = Array(3)
                        T_Orden.Codigo = Array(4)
                        T_Orden.Cantidad = Array(5)
                        T_Orden.UM = Array(6)
                        T_Orden.Fecha_Inicio = Array(7)
                        T_Orden.Fecha_Termino = Array(8)
                        T_Orden.Origen = Array(9)
                        T_Orden.Estatus = Array(10)
                        T_Orden.DEstatus = Array(11)
                        T_Orden.Fecha_Actual = Array(12)
                        T_Orden.Tipo_Orden = Array(13)
                        T_Orden.Usuario = SessionUser._sAlias
                        T_Orden.Fecha = DateTime.Now.ToString("yyyy-MM-dd  HH:mm:ss")
                        T_Orden.Version = Atlas_Version._Version
                        T_Orden.GrupoMaterial = ReturnGrupoMaterial(2)
                        ABC(1)
                    ElseIf Array(0) = "H" Then
                        T_OrdenDetalle.Orden = T_Orden._Orden
                        T_OrdenDetalle.Movimiento = Array(1)
                        T_OrdenDetalle.Codigo = Array(2)
                        T_OrdenDetalle.Descripcion = Array(3)
                        T_OrdenDetalle.Centro = Array(4)
                        T_OrdenDetalle.Almacen = Array(5)
                        T_OrdenDetalle.Cantidad = Array(6)
                        T_OrdenDetalle.UM = Array(7)
                        T_OrdenDetalle.Lote = Array(8)
                        ABCDetalle(1)
                    End If
                Next
                Return True
        End Select
    End Function

    Public Shared Sub ABC(ByVal Operacion As Integer)
        Dim Q As String
        Q = ""
        Q = "PA_OrdenesProduccion '" & T_Orden._Orden & "','" & T_Orden._Centro & "','" & T_Orden._Equipo & "','" & T_Orden._Codigo & "','" & T_Orden._Cantidad & "','" & T_Orden._Fecha_Inicio & "','" & T_Orden._Fecha_Termino & "','" & T_Orden._Origen & "','" & T_Orden._GrupoMaterial.Trim & "','" & T_Orden._Fecha & "','" & T_Orden._Usuario.Trim & "'," & Operacion & ""
        LecturaQry(Q, SessionUser._sAmbiente)
    End Sub

    Public Shared Sub ABCDetalle(ByVal Operacion As Integer)
        Dim Q As String
        Q = ""
        Q = "PA_OrdenesProduccionMaterial '" & T_OrdenDetalle._Orden & "','" & T_OrdenDetalle._Movimiento & "','" & T_OrdenDetalle._Codigo & "','" & T_OrdenDetalle._Descripcion & "','" & T_OrdenDetalle._Almacen & "','" & T_OrdenDetalle._Cantidad & "','" & T_OrdenDetalle._UM & "','" & T_OrdenDetalle._Lote & "'," & Operacion & ""
        LecturaQry(Q, SessionUser._sAmbiente)
    End Sub

    Public Shared Function ValidaOrden(ByVal IdOrden As String) As Boolean
        'Valida existencia de Puesto de Trabajo
        Select Case ValidaEquipo(IdOrden)
            Case Is = False
                MensajeBox.Mostrar("El Puesto de trabajo no está dado de alta ", "Aviso", MensajeBox.TipoMensaje.Information)
                Return False
                Exit Select
            Case Is = True
                'Valida la existencia del código de producto terminado
                Select Case ValidaProducto(IdOrden)
                    Case Is = False
                        MensajeBox.Mostrar("El Código de Producto Terminado no está  dado de alta ", "Aviso", MensajeBox.TipoMensaje.Information)
                        Return False
                        Exit Select
                    Case Is = True
                        'Se realiza la lectura de la orden para poblar los campos
                        FillOrder(IdOrden)
                        Return True
                End Select
        End Select
    End Function

    Public Shared Function ValidaEquipo(ByVal IdOrden As String) As Boolean
        LecturaQry("PA_OrdenesProduccion '" & IdOrden.Trim & "','" & SessionUser._sCentro.Trim & "','','','','','','','','','',3", SessionUser._sAmbiente)
        If (LecturaBD.Read) Then
            Return True
        Else
            Return False
        End If
        LecturaBD.Close()
    End Function

    Public Shared Function ValidaProducto(ByVal IdOrden As String) As Boolean
        LecturaQry("PA_OrdenesProduccion '" & IdOrden.Trim & "','" & SessionUser._sCentro.Trim & "','','','','','','','','','',4", SessionUser._sAmbiente)
        If (LecturaBD.Read) Then
            Return True
        Else
            Return False
        End If
        LecturaBD.Close()
    End Function

    Public Shared Function ReturnGrupoMaterial(Operacion As Integer) As String
        Dim Q As String
        Dim IdGrupo As String = ""
        Q = ""
        Q = "PA_OrdenesProduccion '','" & T_Orden._Centro & "','','" & T_Orden._Codigo & "','','','','','','',''," & Operacion & ""
        LecturaQry(Q, SessionUser._sAmbiente)
        If (LecturaBD.Read) Then
            IdGrupo = LecturaBD(0)
        End If
        Return IdGrupo
    End Function

    Public Shared Sub FillOrder(ByVal IdOrden As String)
        LecturaQry("PA_OrdenesProduccion '" & IdOrden.Trim & "','" & SessionUser._sCentro.Trim & "','','','','','','','','','',6", SessionUser._sAmbiente)
        If (LecturaBD.Read) Then
            OrderFill.Orden = LecturaBD(0)
            OrderFill.GrupoProductivo = LecturaBD(1)
            OrderFill.DGrupoProductivo = LecturaBD(2)
            OrderFill.Codigo = LecturaBD(3)
            OrderFill.DCodigo = LecturaBD(4)
            OrderFill.Empaque = LecturaBD(5)
            OrderFill.PesoTeorico = LecturaBD(6)
            OrderFill.Estatus = LecturaBD(7)
            OrderFill.Cantidad = LecturaBD(8)
            OrderFill.Equipo = LecturaBD(9)
            OrderFill.DEquipo = LecturaBD(10)
            OrderFill.GrupoMaterial = LecturaBD(11)
            OrderFill.SobrePeso = LecturaBD(12)
        End If
        LecturaBD.Close()
    End Sub

    Public Shared Sub Cantidades(ByVal IdOrden As String)
        Try
            LecturaQry("PA_CANTIDADES_PERU '" & SessionUser._sCentro.Trim & "',  '" & IdOrden.Trim & "'", SessionUser._sAlias.Trim)
            If (LecturaBD.Read) Then
                OrdenCantidades.Cantidad = LecturaBD(1)
                OrdenCantidades.CantEntregada = LecturaBD(2)
                OrdenCantidades.CantSeparada = LecturaBD(3)
                OrdenCantidades.CantProceso = LecturaBD(4)
                OrdenCantidades.CantPendientes = LecturaBD(5)
            Else
                OrdenCantidades.Cantidad = "0"
                OrdenCantidades.CantEntregada = "0"
                OrdenCantidades.CantSeparada = "0"
                OrdenCantidades.CantProceso = "0"
                OrdenCantidades.CantPendientes = "0"
            End If
            LecturaBD.Close()
        Catch ex1 As Exception
            MsgBox(ex1.Message)
            Exit Sub
        End Try
    End Sub

    Public Shared Sub DetallePiezasPesos(ByVal DataGV As DataGridView, IdOrden As String, Cant As Integer)
        Dim Q As String
        Dim objDa As SqlDataAdapter
        Dim objDs As DataSet

        Q = ""
        Q = "PA_PesosEmbalajes '" & SessionUser._sCentro.Trim & "','" & IdOrden.Trim & "', " & Cant & ",1 "
        Try
            objDa = New SqlDataAdapter(Q, MSI(SessionUser._sAmbiente))
            objDs = New DataSet
            objDa.Fill(objDs)
            DataGV.DataSource = objDs.Tables(0)
        Catch ex As Exception
            MessageBox.Show("Error Conexion :" & ex.Message, "ORDENES PROCESO")
        End Try
    End Sub

    Public Shared Sub TotalPiezasPesos(IdOrden As String, Cant As Integer)
        LecturaQry("PA_PesosEmbalajes '" & SessionUser._sCentro.Trim & "','" & IdOrden.Trim & "', " & Cant & ",2", SessionUser._sAmbiente)
        If (LecturaBD.Read) Then
            PesosPiezas.Piezas = LecturaBD(0)
            PesosPiezas.Pesos = LecturaBD(1)
        End If
        LecturaBD.Close()
    End Sub

    Public Shared Sub ConsumosMateriales(ByVal DataGV As DataGridView, IdOrden As String, IdProducto As String, IdPiezas As Integer, IdPeso As String, IdLista As String)
        Dim Q As String
        Dim objDa As SqlDataAdapter
        Dim objDs As DataSet

        Q = ""
        Q = "PA_ConsumoCompuestoSAP '" & IdOrden.Trim & "', '" & IdProducto.Trim & "', '" & IdPiezas & "', '" & IdPeso.Trim & "', '" & IdLista.Trim & "',2"
        Try
            objDa = New SqlDataAdapter(Q, MSI(SessionUser._sAmbiente))
            objDs = New DataSet
            objDa.Fill(objDs)
            DataGV.DataSource = objDs.Tables(0)
        Catch ex As Exception
            MessageBox.Show("Error Conexion :" & ex.Message, "ORDENES PROCESO")
        End Try
    End Sub
End Class
