Public Class Compuestos


    Public Shared Function ValidaConfigCompuesto(ByVal IdCodigo As String, IdOrden As String) As Boolean
        Dim Contador As Integer = 0
        Dim listaCompuestos As New List(Of CompuestoSet)
        LecturaQry("PA_CompuestosConsumo '" & IdCodigo.Trim & "','','','','','','','" & IdOrden.Trim & "','1'", SessionUser._sAmbiente)

        listaCompuestos.Clear()
        Do While (LecturaBD.Read())
            Contador = Contador + 1
            Dim Info As New CompuestoSet
            Info.Orden = LecturaBD(0)
            ConfigCompuestos.Orden = LecturaBD(0)
            Info.Codigo = LecturaBD(1)
            ConfigCompuestos.Codigo = LecturaBD(1)
            Info.Lista = LecturaBD(2)
            ConfigCompuestos.Lista = LecturaBD(2)
            Info.Bom = LecturaBD(3)
            ConfigCompuestos.Bom = LecturaBD(3)
            Info.Compuesto = LecturaBD(4)
            ConfigCompuestos.Compuesto = LecturaBD(4)
            Info.Descripcion = LecturaBD(5)
            ConfigCompuestos.Descripcion = LecturaBD(5)
            Info.Porcentaje = LecturaBD(6)
            ConfigCompuestos.Porcentaje = LecturaBD(6)
            ConfigCompuestos.Cantidad = Contador
            listaCompuestos.Add(Info)
        Loop
        Select Case Contador
            Case Is = 0
                Return False
            Case Is = 1
                Do While (LecturaBD.Read())
                    Contador = Contador + 1
                    ConfigCompuestos.Orden = LecturaBD(0)
                    ConfigCompuestos.Codigo = LecturaBD(1)
                    ConfigCompuestos.Lista = LecturaBD(2)
                    ConfigCompuestos.Bom = LecturaBD(3)
                    ConfigCompuestos.Compuesto = LecturaBD(4)
                    ConfigCompuestos.Descripcion = LecturaBD(5)
                    ConfigCompuestos.Porcentaje = LecturaBD(6)
                    ConfigCompuestos.Cantidad = Contador
                Loop
                LecturaBD.Close()
                Return True
            Case Is = 3
                For j = 0 To listaCompuestos.Count - 0
                    Select Case j
                        Case Is = 0
                            Compuestos_1.Orden = listaCompuestos.Item(j).Orden.ToString
                            Compuestos_1.Codigo = listaCompuestos(j).Codigo.ToString
                            Compuestos_1.Lista = listaCompuestos(j).Lista.ToString
                            Compuestos_1.Bom = listaCompuestos(j).Bom.ToString
                            Compuestos_1.Compuesto = listaCompuestos(j).Compuesto.ToString
                            Compuestos_1.Descripcion = listaCompuestos(j).Descripcion.ToString
                            Compuestos_1.Porcentaje = listaCompuestos(j).Porcentaje.ToString
                        Case Is = 1
                            Compuestos_2.Orden = listaCompuestos.Item(j).Orden.ToString
                            Compuestos_2.Codigo = listaCompuestos(j).Codigo.ToString
                            Compuestos_2.Lista = listaCompuestos(j).Lista.ToString
                            Compuestos_2.Bom = listaCompuestos(j).Bom.ToString
                            Compuestos_2.Compuesto = listaCompuestos(j).Compuesto.ToString
                            Compuestos_2.Descripcion = listaCompuestos(j).Descripcion.ToString
                            Compuestos_2.Porcentaje = listaCompuestos(j).Porcentaje.ToString
                        Case Is = 2
                            Compuestos_3.Orden = listaCompuestos.Item(j).Orden.ToString
                            Compuestos_3.Codigo = listaCompuestos(j).Codigo.ToString
                            Compuestos_3.Lista = listaCompuestos(j).Lista.ToString
                            Compuestos_3.Bom = listaCompuestos(j).Bom.ToString
                            Compuestos_3.Compuesto = listaCompuestos(j).Compuesto.ToString
                            Compuestos_3.Descripcion = listaCompuestos(j).Descripcion.ToString
                            Compuestos_3.Porcentaje = listaCompuestos(j).Porcentaje.ToString
                    End Select
                Next
                LecturaBD.Close()
                Return True
        End Select
    End Function

    Public Shared Function ListaMateriales(ByVal IdCodigo As String, IdOrden As String) As Boolean
        Dim listaComp As New List(Of ListaCompuestos)
        Dim Info As New ListaCompuestos
        listaComp.Clear()

        LecturaQry("PA_CompuestosConsumo '33583','','','','','','','13278178','1'", SessionUser._sAmbiente)
        If (LecturaBD.Read) Then
            Info.Orden = LecturaBD(0)
            Info.Codigo = LecturaBD(1)
            Info.Lista = LecturaBD(2)
            Info.Bom = LecturaBD(3)
            listaComp.Add(Info)
            Return True
        Else
            Return False
        End If
    End Function


    Public Shared Sub CBComp1(ByVal CB As ComboBox, IdProducto As String, IdLista As String, Operacion As Integer)
        Dim NDataSet1 As New DataSet
        Dim Q As String

        Q = ""
        Q = "PA_CompuestosConsumo '" & IdProducto.Trim & "','','" & IdLista.Trim & "','','','','',''," & Operacion & ""
        Combo(Q, SessionUser._sAmbiente)
        NDataSet1 = DataSetCombo.Copy
        CB.DataSource = NDataSet1.Tables(0)
        If NDataSet1.Tables(0).Rows.Count > 0 Then
            CB.DisplayMember = "CompDes"
            CB.ValueMember = "Compuesto"
        End If

    End Sub

    Public Shared Sub CBComp2(ByVal CB As ComboBox, IdProducto As String, IdLista As String, Operacion As Integer)
        Dim NDataSet2 As New DataSet
        Dim Q As String

        Q = ""
        Q = "PA_CompuestosConsumo '" & IdProducto.Trim & "','','" & IdLista.Trim & "','','','','',''," & Operacion & ""
        Combo(Q, SessionUser._sAmbiente)
        NDataSet2 = DataSetCombo.Copy
        CB.DataSource = NDataSet2.Tables(0)
        If NDataSet2.Tables(0).Rows.Count > 0 Then
            CB.DisplayMember = "CompDes"
            CB.ValueMember = "Compuesto"
        End If

    End Sub

    Public Shared Sub CBComp3(ByVal CB As ComboBox, IdProducto As String, IdLista As String, Operacion As Integer)
        Dim NDataSet3 As New DataSet
        Dim Q As String

        Q = ""
        Q = "PA_CompuestosConsumo '" & IdProducto.Trim & "','','" & IdLista.Trim & "','','','','',''," & Operacion & ""
        Combo(Q, SessionUser._sAmbiente)
        NDataSet3 = DataSetCombo.Copy
        CB.DataSource = NDataSet3.Tables(0)
        If NDataSet3.Tables(0).Rows.Count > 0 Then
            CB.DisplayMember = "CompDes"
            CB.ValueMember = "Compuesto"
        End If

    End Sub

End Class
