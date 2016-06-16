Imports System.Data.SqlClient
Imports Utili_Generales
Public Class Catalogo_Compuestos
    Shared Sub CB_Compuesto1(ByVal CB As ComboBox, Usuario As String, Centro As String, C_Material As String, Tipo As String, TipoProd As String, Estatus As Boolean)
        Dim Compuesto As String = ""
        If Estatus = True Then
            Dim NDataSet1 As New DataSet
            Dim Q As String
            Q = ""
            Q = "PA_Compuestos_Consumo '" & Centro.Trim & "', '" & C_Material.Trim & "','" & Tipo.Trim & "', '" & TipoProd.Trim & "' "
            Combo(Q, Usuario)
            NDataSet1 = DataSetCombo.Copy
            CB.DataSource = NDataSet1.Tables(0)
            If NDataSet1.Tables(0).Rows.Count > 0 Then
                Compuesto = "1"
                CB.DisplayMember = "CompDes"
                CB.ValueMember = "C_Compuesto"
            Else
                Compuesto = "0"
                MensajeBox.Mostrar("Este Material no tiene asignado compuesto para su consumo", "Aviso", MensajeBox.TipoMensaje.Information)
                Exit Sub
            End If
        End If
    End Sub

    Shared Sub CB_Compuesto2(ByVal CB As ComboBox, Usuario As String, Centro As String, C_Material As String, Tipo As String)
        Dim Compuesto As String = ""
        Dim NDataSet1 As New DataSet
        Dim Q As String
        Q = ""
        Q = "PA_Compuestos_Consumo_Otros '" & Centro.Trim & "', '" & C_Material.Trim & "','" & Tipo.Trim & "' "
        Combo(Q, Usuario)
        NDataSet1 = DataSetCombo.Copy
        CB.DataSource = NDataSet1.Tables(0)
        If NDataSet1.Tables(0).Rows.Count > 0 Then
            Compuesto = "1"
            CB.DisplayMember = "CompDes"
            CB.ValueMember = "C_Compuesto"
        Else
            Compuesto = "0"
            MensajeBox.Mostrar("Este Material no tiene asignado compuesto para su consumo", "Aviso", MensajeBox.TipoMensaje.Information)
            Exit Sub
        End If

    End Sub

    Shared Sub CB_Clase(ByVal CB As ComboBox, Usuario As String)
        Dim Compuesto As String = ""
            Dim NDataSet1 As New DataSet
            Dim Q As String
            Q = ""
            Q = "PA_Consulta_Compuesto_Clase"
            Combo(Q, Usuario)
            NDataSet1 = DataSetCombo.Copy
            CB.DataSource = NDataSet1.Tables(0)
            If NDataSet1.Tables(0).Rows.Count > 0 Then
                Compuesto = "1"
                CB.DisplayMember = "Clase_Comp"
                CB.ValueMember = "Clase"
            Else
                Compuesto = "0"
                MensajeBox.Mostrar("Este Material no tiene asignado compuesto para su consumo", "Aviso", MensajeBox.TipoMensaje.Information)
                Exit Sub
            End If
    End Sub

    Shared Sub CB_Tipo(ByVal CB As ComboBox, Usuario As String)
        Dim Compuesto As String = ""
        Dim NDataSet1 As New DataSet
        Dim Q As String
        Q = ""
        Q = "PA_Tipo_Compuesto"
        Combo(Q, Usuario)
        NDataSet1 = DataSetCombo.Copy
        CB.DataSource = NDataSet1.Tables(0)
        If NDataSet1.Tables(0).Rows.Count > 0 Then
            Compuesto = "1"
            CB.DisplayMember = "TipoComp"
            CB.ValueMember = "Tipo"
        Else
            Compuesto = "0"
            MensajeBox.Mostrar("Este Material no tiene asignado compuesto para su consumo", "Aviso", MensajeBox.TipoMensaje.Information)
            Exit Sub
        End If
    End Sub

    Public Shared Sub Catalogo_Compuestos(ByVal DataGV As DataGridView, Centro As String, Usuario As String, Area As String)
        Dim Q As String
        Dim objDa As SqlDataAdapter
        Dim objDs As DataSet

        Q = ""
        Q = "PA_Catalogo_Compuesto '" & Centro & "', '" & Area & "' "
        Try
            objDa = New SqlDataAdapter(Q, MSI(Usuario))
            objDs = New DataSet
            objDa.Fill(objDs)
            DataGV.DataSource = objDs.Tables(0)
        Catch ex As Exception
            MessageBox.Show("Error Conexion :" & ex.Message, "ORDENES PROCESO")
            Exit Sub
        End Try

        DataGV.Columns(0).HeaderText = "Codigo Compuesto"
        DataGV.Columns(1).HeaderText = "Descripción Compuesto"
        DataGV.Columns(2).HeaderText = "Clase"
        DataGV.Columns(3).HeaderText = "Tipo"
        DataGV.Columns(4).Visible = False 'Status

    End Sub

End Class
