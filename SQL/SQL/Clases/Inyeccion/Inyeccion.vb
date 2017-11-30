Imports System.Data.SqlClient
Imports Utili_Generales
Public Class Inyeccion
#Region "Variables de miembro"

#End Region

#Region "Metodos"
    Public Shared Function Embalajes(ByVal DataGV As DataGridView, Centro As String, TblProduccion As String, Orden As String, Cantidad As Integer, _
                                Usuario As String, TPesoEmp As TextBox)
        Dim DGV_Codigo As String = ""
        Dim DGV_Descr As String = ""
        Dim DGV_Tipo As String = ""
        Dim DGV_Unidades As String = ""
        Dim DGV_Peso As String = ""

        Dim C_Pzas As String = ""
        Dim C_Peso As String = ""
        Dim B_Pzas As String = ""
        Dim B_Peso As String = ""

        If Cantidad <> 0 Then
            LecturaQry("PA_Calcula_Pzas_Pesos_Embalajes_3 '" & TblProduccion.Trim & "', '" & Orden.Trim & "', '" & Cantidad & "'")

            Do While (LecturaBD.Read)
                DGV_Codigo = "" & LecturaBD(0)
                DGV_Descr = "" & LecturaBD(1)
                DGV_Tipo = "" & LecturaBD(2)
                DGV_Unidades = "" & LecturaBD(3)
                DGV_Peso = "" & LecturaBD(4)
                Dim arrConsulta() As Object = {DGV_Codigo.Trim(), DGV_Descr.Trim(), DGV_Tipo.Trim(), DGV_Unidades.Trim(), DGV_Peso.Trim()} 'Creamos un nuevo arreglo con los datos a agregar.               
                DataGV.Rows.Add(arrConsulta) 'Agregamos el arreglo de datos a las filas del DataGrid
                DataGV.Refresh()
                If DGV_Tipo.Trim = "C" Then
                    C_Pzas = DGV_Unidades
                    C_Peso = DGV_Peso
                End If

                If DGV_Tipo.Trim = "B" Then
                    B_Pzas = DGV_Unidades
                    B_Peso = DGV_Peso
                End If
            Loop
            LecturaBD.Close()
            TPesoEmp.Text = Sumar("TPeso", DataGV)

            Return C_Pzas & "|" & C_Peso & "|" & B_Pzas & "|" & B_Peso

        End If
    End Function

    Public Shared Function Sumar(ByVal Nombre_Columna As String, ByVal Dgv As DataGridView) As Double
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

    Public Shared Function Identifies_shift_supervisor(ByVal Centro As String, Usuarios As String, Fecha As String, Turno As Integer)
        Dim C_Supervisor As String
        LecturaQry("PA_IdentificarSupervisorTurno '" & Centro.Trim & "', '" & Fecha & "', " & Turno & "")
        If (LecturaBD.Read) Then
            C_Supervisor = "" & LecturaBD(0)
        Else
            C_Supervisor = "Supervisor"
        End If
        LecturaBD.Close()

        Return C_Supervisor
    End Function

    Public Shared Sub LimpiarForm(Frm As Form)
        Utili_Generales.FrontUtils.LimpiarText_Inyeccion(Frm)
    End Sub


    Public Shared Sub Scrap_Detalle(ByVal DataGV As DataGridView, FI As String, FF As String, Usuario As String)
        Dim Q As String
        Dim objDa As SqlDataAdapter
        Dim objDs As DataSet

        Q = ""
        Q = "PA_Consulta_Scrap_CR01_Detalle '" & FI.Trim & "', '" & FF.Trim & "' "
        Try
            objDa = New SqlDataAdapter(Q, MSI(SessionUser._sAmbiente))
            objDs = New DataSet
            objDa.Fill(objDs)
            DataGV.DataSource = objDs.Tables(0)
        Catch ex As Exception
            MessageBox.Show("Error Conexion :" & ex.Message, "ORDENES PROCESO")
        End Try

        DataGV.Columns(0).HeaderText = "Orden Producción"
        DataGV.Columns(1).HeaderText = "Código Producto"
        DataGV.Columns(2).HeaderText = "Descripción Producto"
        DataGV.Columns(3).HeaderText = "Fecha Inicio Producción"
        DataGV.Columns(4).HeaderText = "Controlador Piso"
        DataGV.Columns(5).HeaderText = "Mes"
        DataGV.Columns(6).HeaderText = "Grupo"
        DataGV.Columns(7).HeaderText = "Compuesto Virgen 1"
        DataGV.Columns(8).HeaderText = "Compuesto Virgen 2"
        DataGV.Columns(9).HeaderText = "% Virgen 1"
        DataGV.Columns(10).HeaderText = "% Virgen 2"
        DataGV.Columns(11).HeaderText = "Compuesto R1 1"
        DataGV.Columns(12).HeaderText = "Compuesto R1 2"
        DataGV.Columns(13).HeaderText = "Porcentaje R1 1"
        DataGV.Columns(14).HeaderText = "Porcenatje R1 2"
        DataGV.Columns(15).HeaderText = "Colada"
        DataGV.Columns(16).HeaderText = "Cierrre Abierto"
        DataGV.Columns(17).HeaderText = "Pringado"
        DataGV.Columns(18).HeaderText = "Falta de Material"
        DataGV.Columns(19).HeaderText = "Huecos Rebabas"
        DataGV.Columns(20).HeaderText = "Crudo"
        DataGV.Columns(21).HeaderText = "Pruebas de Calidad"
        DataGV.Columns(22).HeaderText = "Prueba de Moldes"
        DataGV.Columns(23).HeaderText = "Producto No Conforme"
        DataGV.Columns(24).HeaderText = "Purga"
        DataGV.Columns(25).HeaderText = "Quemados"
        DataGV.Columns(26).HeaderText = "Total"
    End Sub

    Public Shared Sub Scrap_Resumen(ByVal DataGV As DataGridView, FI As String, FF As String, Usuario As String)
        Dim Q As String
        Dim objDa As SqlDataAdapter
        Dim objDs As DataSet

        Q = ""
        Q = "PA_Consulta_Scrap_CR01_Resumen '" & FI.Trim & "', '" & FF.Trim & "' "
        Try
            objDa = New SqlDataAdapter(Q, MSI(SessionUser._sAmbiente))
            objDs = New DataSet
            objDa.Fill(objDs)
            DataGV.DataSource = objDs.Tables(0)
        Catch ex As Exception
            MessageBox.Show("Error Conexion :" & ex.Message, "ORDENES PROCESO")
        End Try

        DataGV.Columns(0).HeaderText = "Orden Producción"
        DataGV.Columns(1).HeaderText = "Código Producto"
        DataGV.Columns(2).HeaderText = "Descripción Producto"
        DataGV.Columns(3).HeaderText = "Fecha Inicio Producción"
        DataGV.Columns(4).HeaderText = "Controlador Piso"
        DataGV.Columns(5).HeaderText = "Mes"
        DataGV.Columns(6).HeaderText = "Grupo"
        DataGV.Columns(7).HeaderText = "Compuesto Virgen 1"
        DataGV.Columns(8).HeaderText = "Compuesto Virgen 2"
        DataGV.Columns(9).HeaderText = "% Virgen 1"
        DataGV.Columns(10).HeaderText = "% Virgen 2"
        DataGV.Columns(11).HeaderText = "Compuesto R1 1"
        DataGV.Columns(12).HeaderText = "Compuesto R1 2"
        DataGV.Columns(13).HeaderText = "Porcentaje R1 1"
        DataGV.Columns(14).HeaderText = "Porcenatje R1 2"
        DataGV.Columns(15).HeaderText = "Colada"
        DataGV.Columns(16).HeaderText = "Cierrre Abierto"
        DataGV.Columns(17).HeaderText = "Pringado"
        DataGV.Columns(18).HeaderText = "Falta de Material"
        DataGV.Columns(19).HeaderText = "Huecos Rebabas"
        DataGV.Columns(20).HeaderText = "Crudo"
        DataGV.Columns(21).HeaderText = "Pruebas de Calidad"
        DataGV.Columns(22).HeaderText = "Prueba de Moldes"
        DataGV.Columns(23).HeaderText = "Producto No Conforme"
        DataGV.Columns(24).HeaderText = "Purga"
        DataGV.Columns(25).HeaderText = "Quemados"
        DataGV.Columns(26).HeaderText = "Total"
    End Sub

    Public Shared Sub Scrap_Resumen_X_Tipo(ByVal DataGV As DataGridView, FI As String, FF As String, Usuario As String)
        Dim Q As String
        Dim objDa As SqlDataAdapter
        Dim objDs As DataSet

        Q = ""
        Q = "PA_Consulta_Scrap_CR01_Resumen_X_Tipo '" & FI.Trim & "', '" & FF.Trim & "' "
        Try
            objDa = New SqlDataAdapter(Q, MSI(SessionUser._sAmbiente))
            objDs = New DataSet
            objDa.Fill(objDs)
            DataGV.DataSource = objDs.Tables(0)
        Catch ex As Exception
            MessageBox.Show("Error Conexion :" & ex.Message, "ORDENES PROCESO")
        End Try

        DataGV.Columns(0).HeaderText = "Código Tipo Scrap"
        DataGV.Columns(1).HeaderText = "Descripción"
        DataGV.Columns(2).HeaderText = "Total"
    End Sub
#End Region


End Class
