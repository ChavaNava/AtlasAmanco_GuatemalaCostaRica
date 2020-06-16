Imports System.Data.SqlClient
Imports System.Configuration
Imports Atlas.Accesos.CLVarGlobales
Imports SQL_DATA

Module MdOperaBD
    Dim usuario As String
    Dim TipPlantas As Integer
    Dim StrCadena As String
    Dim myDataReader As SqlClient.SqlDataReader
#Region "Funciones genericas para agregar, eliminar y actualiar ..."
    Public Function AbrirAmanco(ByVal IdAmbiente As String) As SqlConnection
        Dim varString As String
        If IdAmbiente.Trim = "D" Or IdAmbiente.Trim = "Q" Then
            varString = "Data Source=" & ipBDHost & ";Initial Catalog=Amanco_Dev;Persist Security Info=True;User ID=Fluentatlas;Password=flu3nt4tl4s;Trusted_Connection=False"
        Else
            varString = "Data Source=" & ipBDHost & ";Initial Catalog=Amanco;Persist Security Info=True;User ID=Fluentatlas;Password=flu3nt4tl4s;Trusted_Connection=False"
        End If
        objCnnAmanco = New SqlConnection
        objCnnAmanco.ConnectionString = varString
        objCnnAmanco.Open()
        Return objCnnAmanco
    End Function
    Public Sub Abrir_MSI()
        Dim strCnn_MSI, strCnnUsuarios As String

        If SessionUser._sAlias.Trim = "ATLAS" Or SessionUser._sAlias.Trim = "CALIDAD" Then
            strCnn_MSI = "Data Source=" & ipBDHost & ";Initial Catalog=Amanco_Dev;Persist Security Info=True;User ID=Fluentatlas;Password=flu3nt4tl4s;Trusted_Connection=False"
            'strCnn_MSI = "Data Source=10.1.2.30;Initial Catalog=MSI_A013_DEV;Persist Security Info=True;User ID=msi_atlas;Password=MSI;Trusted_Connection=False"
            'strCnnUsuarios = "Data Source=" & ipBDHost & ";Initial Catalog=DevUsuarios;Persist Security Info=True;User ID=Atlas2k;Password=;Trusted_Connection=False"
        Else
            strCnn_MSI = "Data Source=" & ipBDHost & ";Initial Catalog=Amanco;Persist Security Info=True;User ID=Fluentatlas;Password=flu3nt4tl4s;Trusted_Connection=False"
            'strCnnUsuarios = "Data Source=" & ipBDHost & ";Initial Catalog=Usuarios;Persist Security Info=True;User ID=Atlas2k;Password=;Trusted_Connection=False"
        End If

        cnnMsi = New Conexion(strCnn_MSI)
        cnnUsuarios = New Conexion(strCnnUsuarios)
    End Sub
    Public Function AbrirConfiguracion() As SqlConnection
        Dim Conexion As String
        If SessionUser._sAlias = "ATLAS" Or SessionUser._sAlias = "CALIDAD" Then
            Conexion = "Data Source=10.1.2.30;Initial Catalog=Usuarios_dev;Persist Security Info=True;User ID=Fluentatlas;Password=flu3nt4tl4s;Trusted_Connection=False"
        Else
            Conexion = "Data Source=10.1.2.30;Initial Catalog=Usuarios;Persist Security Info=True;User ID=Fluentatlas;Password=flu3nt4tl4s;Trusted_Connection=False"
        End If
        objCnn = New SqlConnection
        objCnn.ConnectionString = Conexion
        objCnn.Open()
        Return objCnn
    End Function
    Public Sub abcSQL(ByVal sql As String)
        Try
            AbrirAmanco(SessionUser._sAmbiente.Trim)
            objCmd = New SqlCommand
            objCmd.CommandText = sql
            objCmd.CommandType = CommandType.Text
            objCmd.Connection = objCnnAmanco
            objCmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error Eliminar :" & ex.Message, " VENTANA DE ERROR * * * ")
        End Try
    End Sub
    Public Sub abcSQL_ADM(ByVal sql As String)
        Try
            AbrirAmanco(SessionUser._sAmbiente.Trim)
            objCmd = New SqlCommand
            objCmd.CommandText = sql
            objCmd.CommandType = CommandType.Text
            objCmd.Connection = objCnn
            objCmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error Eliminar :" & ex.Message, " VENTANA DE ERROR * * * ")
        End Try
    End Sub
    Public Sub llenarCombo(ByVal sql As String, ByVal comboName As ComboBox)
        Dim dsCombo As DataSet
        Try
            AbrirAmanco(SessionUser._sAmbiente.Trim)
            objDa = New SqlDataAdapter(sql, objCnn)
            dsCombo = New DataSet
            objDa.Fill(dsCombo)
            comboName.DataSource = dsCombo.Tables(0)
            comboName.DisplayMember = dsCombo.Tables(0).Columns(1).ToString.Trim
            comboName.ValueMember = dsCombo.Tables(0).Columns(0).ToString
        Catch ex As Exception
            MessageBox.Show("Error llenar combo :" & ex.Message, " VENTANA DE ERROR * * * ")
        End Try
    End Sub
    Public Sub llenarCheckedListBox(ByVal sql As String, ByVal comboName As CheckedListBox)
        Dim dsCombo As DataSet
        Dim mfor As Integer
        Try
            AbrirAmanco(SessionUser._sAmbiente.Trim)
            objDa = New SqlDataAdapter(sql, objCnn)
            dsCombo = New DataSet
            objDa.Fill(dsCombo)
            With dsCombo.Tables(0)
                For mfor = 0 To .Columns.Count - 1
                    comboName.Items.Add(.Columns.Item(mfor).ColumnName.ToString.Trim)
                Next
            End With
        Catch ex As Exception
            MessageBox.Show("Error llenar combo :" & ex.Message, " VENTANA DE ERROR * * * ")
        End Try
    End Sub
    Public Sub SqlTransaccion(ByVal search As Integer, ByVal update As String, ByVal insert As String)
        Using connection As New SqlConnection("Data Source=MEMXSLPW001;Initial Catalog=bdmcp;Persist Security Info=True;User ID=UsrLibra;Password=;Trusted_Connection=False")
            connection.Open()
            Dim command As SqlCommand = connection.CreateCommand()
            Dim transaction As SqlTransaction
            transaction = connection.BeginTransaction("TransAgentes")
            command.Connection = connection
            command.Transaction = transaction
            Try
                If search = 0 Then
                    abcSQL(insert)
                Else
                    abcSQL(update)
                End If
                transaction.Commit()
            Catch ex As Exception
                Try
                    transaction.Rollback()
                Catch ex2 As Exception
                End Try
            End Try
        End Using
    End Sub
    Public Function suma(ByVal num1 As Double, ByVal num2 As Double, ByVal num3 As Double, ByVal num4 As Double, ByVal num5 As Double) As Double
        Dim sumacom As Double
        sumacom = num1 + num2 + num3 + num4 + num5
        Return sumacom
    End Function
    Public Function LecturaQry(ByVal Qry As String) As SqlDataReader
        Try
            AbrirAmanco(SessionUser._sAmbiente.Trim)
            objCmd = New SqlCommand
            objCmd.CommandType = CommandType.Text
            objCmd.Connection = objCnnAmanco
            objCmd.CommandText = Qry
            LecturaBD = objCmd.ExecuteReader()
        Catch ex As Exception
            MsgBox("Error Lectura: ", ex.Message)
            Return LecturaBD
            Exit Function
        End Try
        Return LecturaBD
    End Function
    Public Function LecturaSP(ByVal Qry_SP As String, ByVal Param As String, ByVal Param2 As String, ByVal Param3 As String) As SqlDataReader
        AbrirAmanco(SessionUser._sAmbiente.Trim)
        objCmd = New SqlCommand
        Param_1 = New SqlParameter
        Param_2 = New SqlParameter
        Param_3 = New SqlParameter

        objCmd.Connection = objCnnAmanco
        objCmd.CommandType = CommandType.StoredProcedure
        objCmd.CommandText = Qry_SP

        Param_1.ParameterName = "@Centro"
        Param_1.SqlDbType = System.Data.SqlDbType.Char
        Param_1.Value = Param
        objCmd.Parameters.Add(Param_1)

        Param_2.ParameterName = "@Reporte"
        Param_2.SqlDbType = System.Data.SqlDbType.Char
        Param_2.Value = Param2
        objCmd.Parameters.Add(Param_2)

        Param_3.ParameterName = "@Area"
        Param_3.SqlDbType = System.Data.SqlDbType.Char
        Param_3.Value = Param3
        objCmd.Parameters.Add(Param_3)

        Return LecturaBD
    End Function

    Public Function LecturaQry_AMD(ByVal QRY_AMD As String) As SqlDataReader
        AbrirConfiguracion()
        If objCnn.State <> ConnectionState.Open Then
            objCnn.Open()
        End If
        objCmd = New SqlCommand
        objCmd.CommandType = CommandType.Text
        objCmd.Connection = objCnn
        objCmd.CommandText = QRY_AMD
        Try
            LecturaBD_AMD = objCmd.ExecuteReader()
        Catch ex As Exception
            MsgBox("Error Lectura: ", ex.Message)                       
        End Try
        Return LecturaBD_AMD
    End Function
    Public Function InsertQry(ByVal InQry As String) As Integer
        AbrirAmanco(SessionUser._sAmbiente.Trim)
        If objCnnAmanco.State <> ConnectionState.Open Then
            objCnnAmanco.Open()
        End If
        If objCnnAmanco.State = 1 Then
            objCmd = New SqlCommand
            objCmd.Connection = objCnnAmanco
            objCmd.CommandText = InQry
            InsertBD = objCmd.ExecuteNonQuery
            Return InsertBD
        Else
            Return "Error de ConexiÛn con la Base de Datos. Vuelva a Intentar"
        End If

    End Function
    Public Function InsertQry_AMD(ByVal InQry As String) As Integer
        AbrirConfiguracion()
        If objCnn.State <> ConnectionState.Open Then
            objCnn.Open()
        End If
        objCmd = New SqlCommand
        objCmd.Connection = objCnn
        objCmd.CommandText = InQry
        InsertBD = objCmd.ExecuteNonQuery
        Return InsertBD
    End Function
    Public Function CerosIzquierda(ByVal CeroIzq As String) As String
        Dim X As Integer = 1
        Dim Y As Integer = 0
        Dim CeroIzq2 As String = ""
        RegresaCeroIzq = ""

        While CeroIzq.Length > 0
            CeroIzq2 = Mid(CeroIzq, X, 1)
            If CeroIzq2 <> 0 Then
                Y = CeroIzq.Length - X + 1
                CeroIzq2 = Mid(CeroIzq, X, Y)
                RegresaCeroIzq = CeroIzq2
                Exit While
            End If
            X = X + 1
        End While

        Return RegresaCeroIzq
    End Function
    Public Function SobrePeso(ByVal PesoTeorico As Decimal, ByVal TtramosNoti As Integer, ByVal TPesoNeto As Decimal, ByVal CodigoPT As String, ByVal Orden As String) As Decimal
        PorcentajeSobrePeso = 0
        Dim QRY_SobPeso As String
        Dim xPSP As Double
        Dim TablaBD As String = ""
        SobrepesoPermitido = 0
        If Forma <> "Inyeccion" Then
            TablaBD = "ProductoTerminadoExtrusion"
        ElseIf Forma = "Inyeccion" Then
            TablaBD = "ProductoTerminadoInyeccion"
        End If
        QRY_SobPeso = ""
        QRY_SobPeso = "Select  Sobrepeso From " & TablaBD.Trim & " Where Centro = '" & SessionUser._sCentro.Trim & "' "
        QRY_SobPeso = QRY_SobPeso & "And Codigo = '" & CodigoPT.Trim & "'"
        Try
            LecturaQry(QRY_SobPeso)
            Do While (LecturaBD.Read())
                SobrepesoPermitido = LecturaBD(0)
            Loop
            LecturaBD.Close()
            PorcentajeSobrePeso = 0
            If PesoTeorico > 0 And TtramosNoti > 0 Then
                xPSP = (((TPesoNeto / (PesoTeorico * TtramosNoti)) - 1) * 100)
                PorcentajeSobrePeso = Format(xPSP, xFormato)
            Else
                PorcentajeSobrePeso = Format(100, xFormato)
            End If
            Return PorcentajeSobrePeso
        Catch ex As Exception
            MessageBox.Show(ex.Message, " VENTANA DE ERROR * * * ")
        End Try
    End Function
    Public Function Combo(ByVal QryCombo As String) As DataSet
        DataSetCombo.Reset()
        Try
            Dim SQLCombo As New SqlClient.SqlDataAdapter(QryCombo, AbrirAmanco(SessionUser._sAmbiente))
            SQLCombo.Fill(DataSetCombo)
        Catch ex As Exception
            MessageBox.Show(ex.Message, " VENTANA DE ERROR * * * ")
        End Try
        Return DataSetCombo
    End Function
    Public Function Combo_AMD(ByVal QryCombo As String) As DataSet
        DataSetCombo.Reset()
        Try
            Dim SQLCombo As New SqlClient.SqlDataAdapter(QryCombo, AbrirConfiguracion)
            SQLCombo.Fill(DataSetCombo)
        Catch ex As Exception
            MessageBox.Show(ex.Message, " VENTANA DE ERROR * * * ")
        End Try
        Return DataSetCombo
    End Function
    Public Function GridInsert(ByVal QRY_Grid As String, ByVal NameTable As String) As BindingSource
        AbrirAmanco(SessionUser._sAmbiente)
        Dim DataSetGrid As New DataSet
        Try
            Dim SQLDataAdapterGrid As New SqlDataAdapter(QRY_Grid, objCnnAmanco.ConnectionString)
            SQLDataAdapterGrid.Fill(DataSetGrid, NameTable)
            bindingSource1.DataSource = DataSetGrid
            bindingSource1.DataMember = NameTable
        Catch ex As Exception
            MessageBox.Show(ex.Message, " VENTANA DE ERROR * * * ")
        End Try
        Return bindingSource1
    End Function
    Public Function GridInsert_AMD(ByVal QRY_Grid_AMD As String, ByVal NameTable_AMD As String) As BindingSource
        AbrirConfiguracion()
        Dim DataSetGrid2 As New DataSet     'DataSet Combo
        Dim SQLDataAdapterGrid2 As New SqlDataAdapter(QRY_Grid_AMD, objCnn.ConnectionString)
        SQLDataAdapterGrid2.Fill(DataSetGrid2, NameTable_AMD)
        bindingSource2.DataSource = DataSetGrid2
        bindingSource2.DataMember = NameTable_AMD
        Return bindingSource2
    End Function

    Public Function TraeDescripcion(ByVal elQRY As String) As String
        Dim Result As String
        AbrirAmanco(SessionUser._sAmbiente.Trim)
        objCmd.Connection = objCnnAmanco
        objCmd.CommandText = elQRY
        Try
            myDataReader = objCmd.ExecuteReader
        Catch ex As Exception
            MessageBox.Show(ex.Message, " VENTANA DE ERROR * * * ")
        End Try

        If myDataReader.Read Then
            Result = myDataReader(0)
        Else
            Result = ""
        End If
        myDataReader.Close()
        Return Result
    End Function
    Public Function TraeDescripcion_AMD(ByVal elQRY As String) As String
        Dim Result As String
        AbrirConfiguracion()
        objCmd.Connection = objCnn
        objCmd.CommandText = elQRY
        Try
            myDataReader = objCmd.ExecuteReader
        Catch ex As Exception
            MessageBox.Show(ex.Message, " VENTANA DE ERROR * * * ")
        End Try
        If myDataReader.Read Then
            Result = myDataReader(0)
        Else
            Result = ""
        End If
        myDataReader.Close()
        Return Result
    End Function
    Public Function carga_permisos(ByVal elQRY As String) As String
        Dim Result As String = ""
        Try
            AbrirConfiguracion()
            objCmd.Connection = objCnn
            objCmd.CommandText = elQRY
            myDataReader = objCmd.ExecuteReader
            If myDataReader.Read Then
                Result = "" & myDataReader(0) & "," & myDataReader(1) & "," & myDataReader(2) & "," & myDataReader(3) & "," & myDataReader(4) & "," & myDataReader(5)
            Else
                Result = ""
            End If
            myDataReader.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, " VENTANA DE ERROR * * * ")
        End Try

        Return Result
    End Function
    Public Function Mensajes(ByVal xMensaje As String, ByVal xTipo As Integer) As Integer
        Dim xTitulo As String = ""
        Dim coderr As Integer
        Select Case xTipo
            Case 0
                elDato = Ini.LeeIni(GIDIOMA, "xTitulo0").Trim
                xTitulo = Mid(elDato, 1, Len(elDato) - 1)
                MsgBox(xMensaje, vbInformation, xTitulo)
                Mensajes = 0
            Case 1
                elDato = Ini.LeeIni(GIDIOMA, "xTitulo1").Trim
                xTitulo = Mid(elDato, 1, Len(elDato) - 1)
                MsgBox(xMensaje, vbCritical, xTitulo)
                Mensajes = 0
            Case 2
                elDato = Ini.LeeIni(GIDIOMA, "xTitulo2").Trim
                xTitulo = Mid(elDato, 1, Len(elDato) - 1)
                coderr = MsgBox(xMensaje, vbOKCancel, xTitulo)
                Mensajes = coderr
            Case 3
                elDato = Ini.LeeIni(GIDIOMA, "xTitulo3").Trim
                xTitulo = Mid(elDato, 1, Len(elDato) - 1)
                MsgBox(xMensaje, vbExclamation, xTitulo)
                Mensajes = 0
        End Select
    End Function

    Public Function GridInsert1(ByVal QRY_Grid As String, ByVal NameTable As String) As BindingSource
        AbrirAmanco(SessionUser._sAmbiente.Trim)
        Dim DataSetGrid As New DataSet     'DataSet Combo
        Dim SQLDataAdapterGrid As New SqlDataAdapter(QRY_Grid1, objCnnAmanco.ConnectionString)
        SQLDataAdapterGrid.Fill(DataSetGrid, NameTable1)
        bindingSource3.DataSource = DataSetGrid
        bindingSource3.DataMember = NameTable1
        Return bindingSource3
    End Function

    Public Function GridInsert(ByVal QRY_Grid As String, ByVal NameTable As String, ByVal nombregrid As DataGridView) As BindingSource

        Dim DataSetGrid_New As New DataSet
        Dim SQLDataAdapterGrid_666 As New SqlDataAdapter(QRY_Grid, AbrirAmanco(SessionUser._sAmbiente.Trim))

        SQLDataAdapterGrid_666.Fill(DataSetGrid_New)
        nombregrid.DataSource = DataSetGrid_New.Tables(0)

        Return bindingSource1

    End Function
    Public Function SinAcentos(ByVal aString As String) As String
        Dim toReplace() As Char = "‡ËÏÚ˘¿»Ã“Ÿ ‰ÎÔˆ¸ƒÀœ÷‹ ‚ÍÓÙ˚¬ Œ‘€ ·ÈÌÛ˙¡…Õ”⁄–˝› „Òı√—’öäûéÁ«Â≈¯ÿ".ToCharArray
        Dim replaceChars() As Char = "aeiouAEIOU aeiouAEIOU aeiouAEIOU aeiouAEIOUdDyY anoANOsSzZcCaAoO".ToCharArray
        For index As Integer = 0 To toReplace.GetUpperBound(0)
            aString = aString.Replace(toReplace(index), replaceChars(index))
        Next
        Return aString
    End Function

    Public Function obtenerTurnos() As ArrayList
        Dim query As String
        Dim cont As Integer
        Dim turnos As ArrayList

        turnos = New ArrayList

        Try
            Dim dsCombo As DataSet
            query = "SELECT RTRIM(Descripcion)  FROM dbo.ADM_Turno" _
                + " WHERE planta= '" & SessionUser._sCentro.Trim & "'" _
                + " GROUP BY Descripcion"

            cnnUsuarios.abrir()

            objDa = New SqlDataAdapter(query, cnnUsuarios.cnn)
            dsCombo = New DataSet
            objDa.Fill(dsCombo)
            With dsCombo.Tables(0)
                For cont = 0 To .Rows.Count - 1
                    turnos.Add(.Rows(cont).Item(0).ToString.Trim)
                Next
            End With
        Catch ex As Exception
            MessageBox.Show("Error al obtener Turnos :" & ex.Message, "  VENTANA DE ERROR * * * ")
        End Try

        Return turnos
    End Function

    Public Sub llenarComboTurnos(ByRef cmbTurnos As ComboBox)
        Dim turnos As ArrayList
        turnos = obtenerTurnos()

        cmbTurnos.Items.Clear()
        For Each turno As String In turnos
            cmbTurnos.Items.Add(turno)
        Next

    End Sub

    Public Function obtenerTurnoActual(ByVal planta As String) As String
        Dim turnoActual As String = ""
        Dim query As String = ""

        query = "Select Turno, Descripcion, Convert(char(8),Hora_Inicio,108) as HoraIni, " _
                    + "Convert(char(8),Hora_Terminacion,108) as HoraFin, " _
                    + "Convert(char(8),getdate(),108) as Hora_Real " _
                + "From ADM_Turno " _
                + "Where Convert(char(8),getdate(),108) Between Convert(char(8),Hora_Inicio,108) " _
                    + "And Convert(char(8),Hora_Terminacion,108) " _
                    + "And Planta = '" & planta.Trim & "'"
        cnnUsuarios.consulta(query)

        Do While (cnnUsuarios.dataReader.Read)
            turnoActual = cnnUsuarios.dataReader("Turno")
            'dateRegistro = DateAdd(DateInterval.Day, Val(LecturaBD_AMD(4)), dateRegistro)
        Loop
        cnnUsuarios.cerrar()

        Return turnoActual
    End Function

#End Region
End Module
