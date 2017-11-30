Imports Utili_Generales
Imports System.Data.SqlClient
Imports SQL_DATA
Imports System.Windows.Forms

Public Class Querys

    Public Shared Sub Summary(ByVal DataGV As DataGridView, Operacion As Integer)
        Dim Q As String
        Dim objDa As SqlDataAdapter
        Dim objDs As DataSet
        LoadingForm.ShowLoading()
        Q = ""
        Q = "PA_ReportesProduccionPeru '" & ConsultasProduccion._Centro.Trim & "' , '" & ConsultasProduccion._Area.Trim & "', '" & ConsultasProduccion._Seccion.Trim & "', '" & ConsultasProduccion._Turno.Trim & "', '" & ConsultasProduccion._FI.Trim & "', '" & ConsultasProduccion._FF.Trim & "', '" & ConsultasProduccion._PuestoTrabajo.Trim & "', '" & ConsultasProduccion._Orden.Trim & "', '" & ConsultasProduccion._Producto.Trim & "', '" & ConsultasProduccion._GrpDiametro.Trim & "', '" & ConsultasProduccion._AreaProductiva.Trim & "', " & Operacion & " "
        Try
            objDa = New SqlDataAdapter(Q, Cnn.MSI(SessionUser._sAmbiente))
            objDs = New DataSet
            objDa.Fill(objDs)
            DataGV.DataSource = objDs.Tables(0)
            LoadingForm.CloseForm()
        Catch ex As Exception
            LoadingForm.CloseForm()
            MessageBox.Show("Error Conexion :" & ex.Message, "ORDENES PROCESO")
        End Try

    End Sub

    Public Shared Sub Detail(ByVal DataGV As DataGridView, Operacion As Integer)
        Dim Q As String
        Dim objDa As SqlDataAdapter
        Dim objDs As DataSet
        LoadingForm.ShowLoading()
        Q = ""
        Q = "PA_ReportesProduccionPeru '" & ConsultasProduccion._Centro.Trim & "' , '" & ConsultasProduccion._Area.Trim & "', '" & ConsultasProduccion._Seccion.Trim & "', '" & ConsultasProduccion._Turno.Trim & "', '" & ConsultasProduccion._FI.Trim & "', '" & ConsultasProduccion._FF.Trim & "', '" & ConsultasProduccion._PuestoTrabajo.Trim & "', '" & ConsultasProduccion._Orden.Trim & "', '" & ConsultasProduccion._Producto.Trim & "', '" & ConsultasProduccion._GrpDiametro.Trim & "', '" & ConsultasProduccion._AreaProductiva.Trim & "', " & Operacion & " "
        Try
            objDa = New SqlDataAdapter(Q, Cnn.MSI(SessionUser._sAmbiente))
            objDs = New DataSet
            objDa.Fill(objDs)
            DataGV.DataSource = objDs.Tables(0)
            LoadingForm.CloseForm()
        Catch ex As Exception
            LoadingForm.CloseForm()
            MessageBox.Show("Error Conexion :" & ex.Message, "ORDENES PROCESO")
        End Try

    End Sub

End Class
