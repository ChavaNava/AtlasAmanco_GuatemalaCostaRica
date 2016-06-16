Imports Atlas.Accesos.CLVarGlobales
Imports SQL_DATA
Public Class Generic_CB
    Sub Con_Comp_rep(ByVal CB As ComboBox, ByVal C_Material As String, Tipo As String)
        Dim NDataSet1 As New DataSet
        Q = ""
        Q = "PA_Compuestos_Consumo_Otros '" & SessionUser._sCentro.Trim & "', '" & C_Material.Trim & "', '" & Tipo.Trim & "' "
        Combo(Q)
        NDataSet1 = DataSetCombo.Copy
        CB.DataSource = NDataSet1.Tables(0)
        CB.DisplayMember = "Descripcion"
        CB.ValueMember = "C_Compuesto"
    End Sub
    Sub Con_Centros(ByVal CB As ComboBox, ByVal Tipo As String)
        Dim NDataSet1 As New DataSet
        Q = ""
        Q = "Select Planta from ADM_Planta Where Tipo = '" & Tipo.Trim & "' "
        Combo_AMD(Q)
        NDataSet1 = DataSetCombo.Copy
        CB.DataSource = NDataSet1.Tables(0)
        CB.DisplayMember = "Planta"
        'CB.ValueMember = "Planta"
    End Sub
    Sub Tipo_SC(ByVal CB As ComboBox, Seccion As String)
        Dim NDataSet1 As New DataSet
        Q = ""
        Q = "Select C_Scrap + D_Scrap As Scrap,C_Scrap,Tipo "
        Q = Q & "From CAT_TipoScrap "
        Q = Q & "Where Centro = '" & SessionUser._sCentro.Trim & "' "
        Q = Q & "And Status = '1' "
        Q = Q & "And C_Area = '" & Seccion.Trim & "' "
        Combo(Q)
        NDataSet1 = DataSetCombo.Copy
        CB.DataSource = NDataSet1.Tables(0)
        CB.DisplayMember = "Scrap"
        CB.ValueMember = "C_Scrap"
    End Sub

    Sub Operador(ByVal CB As ComboBox)
        Dim NDataSet1 As New DataSet
        Q = ""
        Q = "SELECT usuario, nombre FROM ADM_Usuario "
        Q = Q & "Where Planta = '" & SessionUser._sCentro.Trim & "' "
        Q = Q & "AND Deshabilitado = '0' "
        Q = Q & "AND Puesto = '50' "
        Combo_AMD(Q)
        NDataSet1 = DataSetCombo.Copy
        CB.DataSource = NDataSet1.Tables(0)
        CB.DisplayMember = "nombre"
        CB.ValueMember = "usuario"
    End Sub
    Sub CB_Rack(ByVal CB As ComboBox)
        Dim NDataSet1 As New DataSet
        Q = ""
        Q = "SELECT C_Rack, D_Rack, Peso FROM CAT_Racks  "
        Q = Q & "Where Centro = '" & SessionUser._sCentro.Trim & " ' "
        Q = Q & "AND Activo = '1' "
        Q = Q & "order by C_Rack Desc"
        Combo(Q)
        NDataSet1 = DataSetCombo.Copy
        CB.DataSource = NDataSet1.Tables(0)
        CB.DisplayMember = "C_Rack"
        CB.ValueMember = "Peso"
    End Sub
    Sub CB_Clase(ByVal CB As ComboBox)
        Dim NDataSet1 As New DataSet
        Q = ""
        Q = "SELECT Clase_Compuesto,Nombre_ClaseCompuesto FROM MCPC_CompuestoClase  "
        Q = Q & "Where Activo = '1' "
        Combo(Q)
        NDataSet1 = DataSetCombo.Copy
        CB.DataSource = NDataSet1.Tables(0)
        CB.DisplayMember = "Nombre_ClaseCompuesto"
        CB.ValueMember = "Clase_Compuesto"
    End Sub
    Sub CB_Categoria(ByVal CB As ComboBox)
        Dim NDataSet1 As New DataSet
        Q = ""
        Q = "SELECT C_Compuesto,Descripcion,C_Compuesto+Descripcion as CodCompuesto  "
        Q = Q & "FROM CAT_Compuestos "
        Q = Q & "Where Centro = '" & SessionUser._sCentro.Trim & " ' "
        Q = Q & "And C_Tipo = '" & EXTINY & "' "
        Combo(Q)
        NDataSet1 = DataSetCombo.Copy
        CB.DataSource = NDataSet1.Tables(0)
        CB.DisplayMember = "CodCompuesto"
        CB.ValueMember = "C_Compuesto"
    End Sub

    Sub CBPuesto(ByVal CB As ComboBox)
        Dim NDataSet1 As New DataSet
        Combo_AMD("SP_Consulta_Puestos")
        NDataSet1 = DataSetCombo.Copy
        CB.DataSource = NDataSet1.Tables(0)
        CB.DisplayMember = "DescPto"
        CB.ValueMember = "Puesto"
    End Sub

    Sub CB_Turnos(ByVal CB As ComboBox)
        Dim NDataSet1 As New DataSet
        Combo_AMD("PA_Consulta_Turnos '" & SessionUser._sCentro.Trim & "' ")
        NDataSet1 = DataSetCombo.Copy
        CB.DataSource = NDataSet1.Tables(0)
        CB.DisplayMember = "Descripcion"
        CB.ValueMember = "Turno"
    End Sub
End Class
