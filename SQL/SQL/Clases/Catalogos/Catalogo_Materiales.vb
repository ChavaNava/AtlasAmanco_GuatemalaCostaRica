Imports System.Data.SqlClient
Imports Utili_Generales
Public Class Catalogo_Materiales
#Region "Variables de miembro"

#End Region

#Region "Metodos"

    Shared Sub Combo_Materiales(ByVal CB As ComboBox, Usuario As String, Centro As String, EXTINY As String)
        Dim NDataSet1 As New DataSet
        Dim Q As String
        Q = ""
        Q = "PA_Consulta_Materiales '" & Centro.Trim & "', '" & EXTINY & "' "
        Combo(Q)
        NDataSet1 = DataSetCombo.Copy
        CB.DataSource = NDataSet1.Tables(0)
        CB.DisplayMember = "Producto"
        CB.ValueMember = "Codigo"
    End Sub

    Public Shared Sub Materiales(ByVal C_Producto As String, ByVal DataGV As DataGridView, ByVal TBox As TextBox, Centro As String, Frm As Form, Usuario As String, EXTINY As String)
        Dim Q As String
        Dim objDa As SqlDataAdapter
        Dim objDs As DataSet

        Q = ""
        Q = "PA_Consulta_Producto_Terminado_2 '" & Centro & "', '" & C_Producto.Trim & "', '" & EXTINY & "' "
        Try
            Frm.Cursor = System.Windows.Forms.Cursors.WaitCursor
            objDa = New SqlDataAdapter(Q, MSI(SessionUser._sAmbiente))
            objDs = New DataSet
            objDa.Fill(objDs)
            DataGV.DataSource = objDs.Tables(0)
            Frm.Cursor = System.Windows.Forms.Cursors.Default
        Catch ex As Exception
            MessageBox.Show("Error Conexion :" & ex.Message, "ORDENES PROCESO")
        End Try
        DataGV.Columns(0).HeaderText = "Centro"
        DataGV.Columns(1).HeaderText = "Codigo Producto"
        DataGV.Columns(2).HeaderText = "Descripción Producto"
        DataGV.Columns(3).HeaderText = "Unidad de Medida"
        DataGV.Columns(4).HeaderText = "Peso Teorico"
        DataGV.Columns(5).HeaderText = "Peso Estandart"
        If EXTINY.Trim = 1 Then
            DataGV.Columns(6).HeaderText = "Empaque"
        Else
            DataGV.Columns(6).Visible = False   'Empaque
        End If
        If EXTINY.Trim = 1 Then
            DataGV.Columns(7).HeaderText = "Reten"
        Else
            DataGV.Columns(7).Visible = False   'Reten
        End If
        DataGV.Columns(8).HeaderText = "Longitud"
        DataGV.Columns(9).HeaderText = "Diametro en mm"
        DataGV.Columns(10).HeaderText = "Porcentaje Sobre Peso"
        DataGV.Columns(11).HeaderText = "Grupo Productivo"
        DataGV.Columns(12).HeaderText = "Status"
        DataGV.Columns(13).HeaderText = "Codigo Sección"
        DataGV.Columns(14).HeaderText = "Codigo Uso Maquina"
        DataGV.Columns(15).HeaderText = "Grupo Material"
        DataGV.Columns(16).Visible = False     'Descripción Unidad de Medida
        DataGV.Columns(17).Visible = False     'Descripción Empaque
        DataGV.Columns(18).Visible = False     'Descripción Reten
        DataGV.Columns(19).Visible = False     'Descripción Grupo Productivo
        DataGV.Columns(20).Visible = False     'Descripción Sección
        DataGV.Columns(21).Visible = False     'Descripción Uso Maquina
        DataGV.Columns(22).Visible = False     'Descripción Grupo Diametro
        DataGV.Columns(23).HeaderText = "Consumo Combinado"
        DataGV.Columns(24).Visible = False     'Peso Accesorios
        DataGV.Columns(25).Visible = False     'Peso Embalajes
        DataGV.Columns(26).Visible = False     'Clave Tipo Compuesto
        DataGV.Columns(27).HeaderText = "Descripción Tipo Compuesto"
        DataGV.Columns(28).Visible = False     'Codigo de Barras
        DataGV.Columns(29).HeaderText = "Id Marca"
        DataGV.Columns(30).HeaderText = "Marca"
        DataGV.Columns(31).Visible = False     'Metodo Tuberia Convencional
        DataGV.Columns(32).Visible = False     'Metodo Valores Fijos
        DataGV.Columns(33).Visible = False     'Metodo Tuberia Corrugada

        LecturaQry("PA_Consulta_Producto_Terminado_Contador '" & Centro & "', '" & C_Producto.Trim & "', '" & EXTINY & "' ")
        If (LecturaBD.Read) Then
            TBox.Text = LecturaBD(0)
        Else
            TBox.Text = "1"
        End If
        LecturaBD.Close()
    End Sub

    Public Shared Sub Consulta_Dimensiones_Pesos(ByVal C_Producto As String, ByVal TBox As TextBox, Centro As String, Frm As Form, Usuario As String, EXTINY As String)

    End Sub

    Public Shared Sub Insert_PTE(ByVal Usuario As String, Centro As String, Codigo As String, Desc As String, UM As String, _
                                                PesoEstandar As Decimal, PesoTeorico As Decimal, Empaque As String, Reten As String, _
                                                Longitud As Decimal, DiametroMM As Decimal, SobrePeso As Decimal, Grpprod As String, _
                                                Codseccion As String, Codusomaq As String, grupmaterial As String, ConCombinado As String, _
                                                TipoComp As String, UsrAlta As String, CodBarr As String, MetodoTC As String, _
                                                MetodoVF As String, MetodoTCo As String, Marca As String, Tipo As String)
        Try
            LecturaQry("PA_Insert_Producto_Terminado_2 '" & Centro.Trim & "', '" & Codigo.Trim & "', '" & Desc.Trim & "', '" _
           & UM.Trim & "', " & PesoEstandar & ", " & PesoTeorico & ", '" & Empaque.Trim & "', '" & Reten.Trim & "', " & Longitud & ", " & DiametroMM & _
           ", " & SobrePeso & ", '" & Grpprod.Trim & "', '" & Codseccion.Trim & "', '" & Codusomaq.Trim & _
           "', '" & grupmaterial.Trim & "', '" & ConCombinado & "', '" & TipoComp.Trim & "', '" & UsrAlta.Trim & "', '" & CodBarr.Trim & _
           "', '" & MetodoTC & "', '" & MetodoVF & "', '" & MetodoTCo & "', '" & Marca & "', '" & Tipo.Trim & "' ")
        Catch ex As Exception
            MensajeBox.Mostrar(ex.ToString, "Error", MensajeBox.TipoMensaje.Critical)
            Exit Sub
        End Try

    End Sub

    Public Shared Sub Update_PTE(ByVal Usuario As String, Centro As String, Codigo As String, Desc As String, UM As String, _
                                                PesoEstandar As Decimal, PesoTeorico As Decimal, Empaque As String, Reten As String, _
                                                Longitud As Decimal, DiametroMM As Decimal, SobrePeso As Decimal, Grpprod As String, _
                                                Codseccion As String, Codusomaq As String, grupmaterial As String, ConCombinado As String, _
                                                TipoComp As String, UsrCambio As String, CodBarr As String, MetodoTC As String, _
                                                MetodoVF As String, MetodoTCo As String, Marca As String, Tipo As String, Activo As String)

        Try
            LecturaQry("PA_Actualiza_Producto_Terminado '" & Centro.Trim & "', '" & Codigo.Trim & "', '" & Desc.Trim & "', '" _
           & UM.Trim & "', " & PesoEstandar & ", " & PesoTeorico & ", '" & Empaque.Trim & "', '" & Reten.Trim & "', " & Longitud & ", " & DiametroMM & _
           ", " & SobrePeso & ", '" & Grpprod.Trim & "', '" & Codseccion.Trim & "', '" & Codusomaq.Trim & _
           "', '" & grupmaterial.Trim & "', '" & ConCombinado & "', '" & TipoComp.Trim & "', '" & UsrCambio.Trim & "', '" & CodBarr.Trim & _
           "', '" & MetodoTC & "', '" & MetodoVF & "', '" & MetodoTCo & "', '" & Marca & "', '" & Tipo.Trim & "', '" & Activo.Trim & "' ")
        Catch ex As Exception
            MensajeBox.Mostrar(ex.ToString, "Error", MensajeBox.TipoMensaje.Critical)
            Exit Sub
        End Try
    End Sub

    Public Shared Sub Baja_PTE(ByVal Usuario As String, Centro As String, Codigo As String, Tipo As String, Activo As String)

        Try
            LecturaQry("PA_Baja_Producto_Terminado '" & Centro.Trim & "', '" & Codigo.Trim & "',  '" & Tipo.Trim & "', '" & Activo.Trim & "' ")
        Catch ex As Exception
            MensajeBox.Mostrar(ex.ToString, "Error", MensajeBox.TipoMensaje.Critical)
            Exit Sub
        End Try

    End Sub

    Public Shared Sub Insert_PTI(ByVal Usuario As String, Centro As String, Codigo As String, Desc As String, UM As String, _
                                             PesoEstandar As Decimal, PesoTeorico As Decimal, Empaque As String, Longitud As Decimal, _
                                             DiametroMM As Decimal, SobrePeso As Decimal, Grpprod As String, Codseccion As String, _
                                             Codusomaq As String, grupmaterial As String, ConCombinado As String, TipoComp As String, _
                                             UsrAlta As String, CodBarr As String, MetodoTC As String, MetodoVF As String,
                                             MetodoTCo As String, Marca As String, Tipo As String)
        Try
            LecturaQry("PA_Insert_Producto_Terminado '" & Centro.Trim & "', '" & Codigo.Trim & "', '" & Desc.Trim & "', '" _
           & UM.Trim & "', " & PesoEstandar & ", " & PesoTeorico & ", '" & Empaque.Trim & "', " & Longitud & ", " & DiametroMM & _
           ", " & SobrePeso & ", '" & Grpprod.Trim & "', '" & Codseccion.Trim & "', '" & Codusomaq.Trim & _
           "', '" & grupmaterial.Trim & "', '" & ConCombinado & "', '" & TipoComp.Trim & "', '" & UsrAlta.Trim & "', '" & CodBarr.Trim & _
           "', '" & MetodoTC & "', '" & MetodoVF & "', '" & MetodoTCo & "', '" & Marca & "', '" & Tipo.Trim & "' ")
        Catch ex As Exception
            MensajeBox.Mostrar(ex.ToString, "Error", MensajeBox.TipoMensaje.Critical)
            Exit Sub
        End Try

    End Sub

#End Region
End Class
