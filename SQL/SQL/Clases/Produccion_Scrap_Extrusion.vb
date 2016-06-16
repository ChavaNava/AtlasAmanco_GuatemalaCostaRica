Imports System.Data.SqlClient
Public Class Produccion_Scrap_Extrusion
    Dim DGV_OrdenProduccion As String
    Dim DGV_Equipo As String
    Dim DGV_Producto As String
    Dim DGV_Tramos As Decimal
    Dim DGV_PN As Decimal
    Dim DGV_PT As Decimal
    Dim DGV_SP As Decimal
    Dim DGV_PNS As Decimal
    Dim DGV_SC As Decimal

    Public Sub Con_Imp_Resumen_Produccion(ByRef Centro As String, ByVal DataGV As DataGridView, ByVal Notifica As String, ByVal Seccion As String, _
                                       ByVal Turno As String, ByVal FI As String, ByVal FF As String, ByVal HI As String, _
                                       ByVal HF As String, ByRef DG As DataGridView, ByVal P_Sobre_Peso As TextBox, _
                                       ByVal K_Sobrepeso As TextBox, ByVal Tk_Scrap As TextBox, ByVal Tp_Scrap As TextBox, Usuario As String)

        Dim Q As String
        Dim objDa As SqlDataAdapter
        Dim objDs As DataSet

        Q = ""
        Q = "PA_Consulta_Produccion_Resumen " & Centro & "_Consulta_Produccion, '" & Notifica & "', 'E', '" & Seccion & "', '" & Turno & "', '" & FI & "', '" & FF & "', '" & HI & "', '" & HF & "' "
        Try
            objDa = New SqlDataAdapter(Q, MSI(Usuario))
            objDs = New DataSet
            objDa.Fill(objDs)
            DataGV.DataSource = objDs.Tables(0)
        Catch ex As Exception
            MessageBox.Show("Error Conexion :" & ex.Message, "ORDENES PROCESO")
        End Try


        Do While (LecturaBD.Read)
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
        'DGV_Tramos = Sumar("C_Tramos", DG)
        'DGV_PN = Sumar("C_PN", DG)
        'DGV_PT = Sumar("C_PT", DG)
        'DGV_SP = Porcentaje_Producto_Terminado(DGV_PN, DGV_PT)
        'DGV_PNS = Sumar("C_PNS", DG)
        'DGV_SC = Porcentaje_Scrap(DGV_PNS, DGV_PN)

        Dim arrDatos() As Object = {DGV_OrdenProduccion.Trim(), DGV_Equipo.Trim(), DGV_Producto.Trim(), FormatNumber((DGV_Tramos), 3), FormatNumber((DGV_PN), 3), FormatNumber((DGV_PT), 3), FormatNumber((DGV_SP), 3), FormatNumber((DGV_PNS), 2), FormatNumber((DGV_SC), 3)} 'Creamos un nuevo arreglo con los datos a agregar.               
        DG.Rows.Add(arrDatos) 'Agregamos el arreglo de datos a las filas del DataGrid
        DG.Refresh()

    End Sub

    Public Shared Sub Baja_Pesaje(ByVal Centro As String, Usuario As String, Folio As String, Orden As String, Proceso As String)
        LecturaQry("PA_Baja_PT_SC_Extrusion  '" & Centro.Trim & "' , '" & Orden & "', '" & Folio & "', '" & Proceso & "'", Usuario)
    End Sub

    Public Shared Sub Inser_Movimiento_Baja(ByVal Usuario As String, Centro As String, Orden As String, Folio As String, _
                                            DocSap As String, NumSap As String, Notifica As String, Masiva As String, Observaciones As String, _
                                            StatusPesaje As String, Area As String, Proceso As String)

        Dim Fec_Mov As String = Now.Date.ToString("yyyy-MM-dd")
        Dim Hra_Mov As String = Now.TimeOfDay.ToString.Substring(0, 8)


        LecturaQry("PA_Inserta_Movimiento_Baja  '" & Centro.Trim & "', '" & Folio & "', '" & Orden & "', '" & Fec_Mov & "', '" & Hra_Mov & _
                   "', '" & DocSap & "', '" & NumSap & "', '" & Notifica & "', '" & Masiva & "', '" & Usuario & "', '" & Observaciones & _
                   "', '" & StatusPesaje & "', '" & Area & "', '" & Proceso & "' ", Usuario)
    End Sub

    Public Shared Function Empaques(ByVal Codigo As String, Cantidad As String) As String
        Dim CodEmp As String = "0"

        If Codigo <> "0" Then
            CodEmp = Cantidad
        Else
            CodEmp = "0"
        End If

        Return CodEmp
    End Function
End Class
