Imports System.IO
Imports System.Data.SqlClient
Imports System.Configuration
Imports Utili_Generales
Imports Utili_Generales.ValueText
Public Class FrmAdminconfig
    'Variables de uso general
    Dim StrPlanta As String     'Planta
    Dim myDataReader As SqlClient.SqlDataReader
    Dim RegistrosActualizados As Integer
    Dim Actualizados As Integer
    Dim Q As String

    'Variables de tabla ADM_Planta
    Dim StrTipo As String       'Tipo Planta
    Dim StrPais As String       'Pais
    Dim StrRFC As String        'RFC
    Dim StrMun As String        'Municipio
    Dim StrDes As String        'Descripción Municipio
    Dim StrNomCorto As String   'Nombre Corto Municipio
    Dim StrRazon As String      'Razon Social
    Dim StrCalle As String      'Calle No
    Dim StrCol As String        'Colonia
    Dim StrDel As String        'Delegación / Municipio
    Dim StrCP As String         'Codigo Postal
    Dim StrTel1 As String       'Telefono 1
    Dim StrTel2 As String       'Telefono 2
    Dim StrTel3 As String       'Telefono 3
    Dim StrFax As String        'Fax
    Dim StrMail As String       'E-mail
    Dim StrWeb As String        'Web
    Dim StrTxt1 As String       'Texto 1
    Dim StrTxt2 As String       'Texto 2
    Dim StrPTE As String        'PT Extrucción
    Dim StrPTI As String        'PT Inyección
    Dim StrSG As String         'Scrap Generado
    Dim StrCR As String         'Consumo de Recuperado
    Dim StrQPT As String        'PT Quimir
    Dim StrQMP As String        'MP Quimir
    Dim StrQTR As String        'TR Quimir
    Dim StrQOT As String        'OT Quimir
    Dim StrAut As String        'AutCalidad

    'Variables ADM_Config_Bascula
    Dim StrBPTE1 As String   'Bascula Producto Terminado Extrucción 1
    Dim StrBPTE2 As String   'Bascula Producto Terminado Extrucción 2
    Dim StrBPTE3 As String   'Bascula Producto Terminado Extrucción 3
    Dim StrBPTE4 As String   'Bascula Producto Terminado Extrucción 4
    Dim StrBPTI1 As String   'Bascula Producto Terminado Inyección 1
    Dim StrBPTI2 As String   'Bascula Producto Terminado Inyección 2
    Dim StrBPTI3 As String   'Bascula Producto Terminado Inyección 3
    Dim StrBPTI4 As String   'Bascula Producto Terminado Inyección 4
    Dim StrBSC1 As String    'Bascula Scrap 1
    Dim StrBSC2 As String    'Bascula Scrap 2
    Dim StrBSC3 As String    'Bascula Scrap 3
    Dim StrBSC4 As String    'Bascula Scrap 4
    Dim StrBCR1 As String    'Bascula Recuperado 1
    Dim StrBCR2 As String    'Bascula Recuperado 2
    Dim StrBCR3 As String    'Bascula Recuperado 3
    Dim StrBCR4 As String    'Bascula Recuperado 4
    Dim StrQPT1 As String    'Bascula Quimir PT 1
    Dim StrQPT2 As String    'Bascula Quimir PT 2
    Dim StrQPT3 As String    'Bascula Quimir PT 3
    Dim StrQPT4 As String    'Bascula Quimir PT 4
    Dim StrQMP1 As String    'Bascula Quimir MP 1
    Dim StrQMP2 As String    'Bascula Quimir MP 2
    Dim StrQMP3 As String    'Bascula Quimir MP 3
    Dim StrQMP4 As String    'Bascula Quimir MP 4
    Dim StrQTR1 As String    'Bascula Quimir TR 1
    Dim StrQTR2 As String    'Bascula Quimir TR 2
    Dim StrQTR3 As String    'Bascula Quimir TR 3
    Dim StrQTR4 As String    'Bascula Quimir TR 4
    Dim StrQOT1 As String    'Bascula Quimir OT 1
    Dim StrQOT2 As String    'Bascula Quimir OT 2
    Dim StrQOT3 As String    'Bascula Quimir OT 3
    Dim StrQOT4 As String    'Bascula Quimir OT 4

    'Variables de la tabla MCPC_Foliador
    Dim StrFPTE As String
    Dim StrFPTI As String
    Dim StrFSG As String
    Dim StrFCR As String

    'Variables de la tabla MCPC_SobrepesoPlanta
    Dim StrESPM As String
    Dim StrEAUS As String
    Dim StrEAUG As String
    Dim StrEAUD As String
    Dim StrISPM As String
    Dim StrIAUS As String
    Dim StrIAUG As String
    Dim StrIAUD As String

    'Variables Tabla ADM_Basculas
    Dim B_Bascula As String
    Dim B_Puerto As String
    Dim B_TipPto As String
    Dim B_Baudios As String
    Dim B_Paridad As String
    Dim B_BitsDatos As String
    Dim B_BitsParo As String



    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Close()
    End Sub

    Private Sub CerrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Close()

    End Sub

    Private Sub ToolStripButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Close()

    End Sub

    Private Sub Adminconfig_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Q As String
        Dim myDataReader As SqlClient.SqlDataReader
        Dim contador As Integer

        Me.Icon = Util.ApplicationIcon()

        contador = 0

        AbrirConfiguracion()

        objCmd = New SqlCommand
        objCmd.CommandType = CommandType.Text
        objCmd.Connection = objCnn

        'Consulta de tabla ADM_Planta para asignar valores a Datos Compañia
        Q = ""
        Q = "Select * from ADM_Planta WHERE Planta = '" & strPlanta & "'"
        '
        objCmd.CommandText = Q
        Try
            myDataReader = objCmd.ExecuteReader()
        Catch ex1 As Exception
            MsgBox(ex1.Message)
            Exit Sub
        End Try
        '
        Do While (myDataReader.Read())
            contador = contador + 1
            strPlanta = myDataReader(0)     'Num. Planta
            StrTipo = myDataReader(1)       'Tipo Planta (Quimica, PVC o Minera)
            StrPais = myDataReader(2)       'Pais Planta
            StrRFC = myDataReader(3)        'RFC de la Planta
            StrMun = myDataReader(4)        'Numero Municipio
            StrDes = myDataReader(5)        'Descripcion Municipio
            StrNomCorto = myDataReader(6)   'Nombre Corto Ubicación
            StrRazon = myDataReader(7)      'Razon Social
            StrCalle = myDataReader(8)      'Calle y No.
            StrCol = myDataReader(9)        'Colonia
            StrDel = myDataReader(10)       'Delegación o Municipio
            StrCP = myDataReader(11)        'Codigo Postal
            StrTel1 = myDataReader(12)      'Telefono 1
            StrTel2 = myDataReader(13)      'Telefono 2
            StrTel3 = myDataReader(14)      'Telefono 3
            StrFax = myDataReader(15)       'Fax
            StrMail = myDataReader(16)      'Correo Electronico
            StrWeb = myDataReader(17)       'Pagina WEB
            StrTxt1 = myDataReader(18)      'Texto Pantalla Principal 1
            StrTxt2 = myDataReader(19)      'Texto Pantalla Principal 2
        Loop
        '
        myDataReader.Close()

        If contador > 0 Then
            TxtCentro.Text = strPlanta
            TxtPlanta.Text = StrDes
            TxtRFC.Text = StrRFC
            TxtPais.Text = StrPais
            TxtRazon.Text = StrRazon
            TxtDomicilio.Text = StrCalle
            TxtCol.Text = StrCol
            TxtDM.Text = StrDel
            TxtCP.Text = StrCP
            TxtTel1.Text = StrTel1
            TxtTel2.Text = StrTel2
            TxtTel3.Text = StrTel3
            TxtFax.Text = StrFax
            Txtemail.Text = StrMail
            txtweb.Text = StrWeb
            Texto1.Text = StrTxt1
            Texto2.Text = StrTxt2

        ElseIf contador = 0 Then
            MessageBox.Show(" Empresa no Registrada ")
            Exit Sub
            Close()
        End If

        'Consulta de tabla ADM_Config_Basculas para asignar Basculas

        Q = "Select * from ADM_Config_Bascula WHERE Planta = '" & strPlanta & "'"
        '
        objCmd.CommandText = Q
        Try
            myDataReader = objCmd.ExecuteReader()
        Catch ex1 As Exception
            MsgBox(ex1.Message)
            Exit Sub
        End Try
        '
        contador = 0

        Do While (myDataReader.Read())
            contador = contador + 1
            StrPlanta = myDataReader(0) 'Numero Planta
            StrBPTE1 = myDataReader(1)  'Bascula Producto Terminado Extrucción 1
            StrBPTE2 = myDataReader(2)  'Bascula Producto Terminado Extrucción 2
            StrBPTE3 = myDataReader(3)  'Bascula Producto Terminado Extrucción 3
            StrBPTE4 = myDataReader(4)  'Bascula Producto Terminado Extrucción 4
            StrBPTI1 = myDataReader(5)  'Bascula Producto Terminado Inyección 1
            StrBPTI2 = myDataReader(6)  'Bascula Producto Terminado Inyección 2
            StrBPTI3 = myDataReader(7)  'Bascula Producto Terminado Inyección 3
            StrBPTI4 = myDataReader(8)  'Bascula Producto Terminado Inyección 4
            StrBSC1 = myDataReader(9)   'Bascula Scrap 1
            StrBSC2 = myDataReader(10)  'Bascula Scrap 2
            StrBSC3 = myDataReader(11)  'Bascula Scrap 3
            StrBSC4 = myDataReader(12)  'Bascula Scrap 4
            StrBCR1 = myDataReader(13)  'Bascula Recuperado 1
            StrBCR2 = myDataReader(14)  'Bascula Recuperado 2
            StrBCR3 = myDataReader(15)  'Bascula Recuperado 3
            StrBCR4 = myDataReader(16)  'Bascula Recuperado 4
            StrQPT1 = myDataReader(17)  'Bascula Quimir PT 1
            StrQPT2 = myDataReader(18)  'Bascula Quimir PT 2
            StrQPT3 = myDataReader(19)  'Bascula Quimir PT 3
            StrQPT4 = myDataReader(20)  'Bascula Quimir PT 4
            StrQMP1 = myDataReader(21)  'Bascula Quimir MP 1
            StrQMP2 = myDataReader(22)  'Bascula Quimir MP 2
            StrQMP3 = myDataReader(23)  'Bascula Quimir MP 3
            StrQMP4 = myDataReader(24)  'Bascula Quimir MP 4
            StrQTR1 = myDataReader(25)  'Bascula Quimir TR 1
            StrQTR2 = myDataReader(26)  'Bascula Quimir TR 2
            StrQTR3 = myDataReader(27)  'Bascula Quimir TR 3
            StrQTR4 = myDataReader(28)  'Bascula Quimir TR 4
            StrQOT1 = myDataReader(29)  'Bascula Quimir OT 1
            StrQOT2 = myDataReader(30)  'Bascula Quimir OT 2
            StrQOT3 = myDataReader(31)  'Bascula Quimir OT 3
            StrQOT4 = myDataReader(32)  'Bascula Quimir OT 4

        Loop
        '
        myDataReader.Close()

        If contador > 0 Then
            TxtPTE1.Text = StrBPTE1
            TxtPTE2.Text = StrBPTE2
            TxtPTE3.Text = StrBPTE3
            TxtPTE4.Text = StrBPTE4
            TXTBPTI1.Text = StrBPTI1
            TXTBPTI2.Text = StrBPTI2
            TXTBPTI3.Text = StrBPTI3
            TXTBPTI4.Text = StrBPTI4
            TXTBSC1.Text = StrBSC1
            TXTBSC2.Text = StrBSC2
            TXTBSC3.Text = StrBSC3
            TXTBSC4.Text = StrBSC4
            TXTBCR1.Text = StrBCR1
            TXTBCR2.Text = StrBCR2
            TXTBCR3.Text = StrBCR3
            TXTBCR4.Text = StrBCR4
        ElseIf contador = 0 Then
            MessageBox.Show(" Bascula no asignada ")
            Exit Sub
            Close()
        End If

        'Lee Tabla ADM_Basculas para asignar datos al Datagrid de basculas

        Try
            objDa = New SqlDataAdapter("select *  from ADM_Basculas ", objCnn.ConnectionString)
            objDs = New DataSet
            objDa.Fill(objDs)
            DGBascula.DataSource = objDs

        Catch ex As Exception
            MessageBox.Show("Error Conexion :" & ex.Message)
        End Try

        AbrirAmanco()

        objCmd = New SqlCommand
        objCmd.CommandType = CommandType.Text
        objCmd.Connection = objCnnAmanco

        ' Consulta de tabla MCPC_Foliador para asignar valores de folios
        '
        Q = "Select * from MCPC_Foliador WHERE Planta = '" & StrPlanta & "' "
        '
        objCmd.CommandText = Q
        Try
            myDataReader = objCmd.ExecuteReader()
        Catch ex1 As Exception
            MsgBox(ex1.Message)
            Exit Sub
        End Try

        Do While (myDataReader.Read())
            StrPlanta = myDataReader(0)
            StrFCR = myDataReader(1)
            StrFPTE = myDataReader(3)
            StrFSG = myDataReader(4)
            StrFPTI = myDataReader(9)
        Loop
        '
        myDataReader.Close()

        TxtFPTE.Text = StrFPTE
        TxtFPTI.Text = StrFPTI
        TxtFSG.Text = StrFSG
        TxtFCR.Text = StrFCR

        ' Consulta MCPC_SobrepesoPlanta para asignar valores a sobrepeso extrucción
        objCmd = New SqlCommand
        objCmd.CommandType = CommandType.Text
        objCmd.Connection = objCnn
        Q = "Select * from ADM_SobrepesoPlanta WHERE Modulo = 'PTE' and Planta = '" & StrPlanta & "'"
        '
        objCmd.CommandText = Q
        Try
            myDataReader = objCmd.ExecuteReader()
        Catch ex1 As Exception
            MsgBox(ex1.Message)
            Exit Sub
        End Try

        Do While (myDataReader.Read())
            StrPlanta = myDataReader(0)
            StrESPM = myDataReader(2)
            StrEAUS = myDataReader(3)
            StrEAUG = myDataReader(4)
            StrEAUD = myDataReader(5)
        Loop
        myDataReader.Close()

        TxtSPE1.Text = StrESPM
        TxtSPE2.Text = StrEAUS
        TxtSPE3.Text = StrEAUG
        TxtSPE4.Text = StrEAUD


        ' Consulta MCPC_SobrepesoPlanta para asignar valores a sobrepeso inyección
        '
        Q = "Select * from ADM_SobrepesoPlanta WHERE Modulo = 'PTI' and Planta = '" & StrPlanta & "'"
        '
        objCmd.CommandText = Q
        Try
            myDataReader = objCmd.ExecuteReader()
        Catch ex1 As Exception
            MsgBox(ex1.Message)
            Exit Sub
        End Try

        Do While (myDataReader.Read())
            StrPlanta = myDataReader(0)
            StrISPM = myDataReader(2)
            StrIAUS = myDataReader(3)
            StrIAUG = myDataReader(4)
            StrIAUD = myDataReader(5)
        Loop
        myDataReader.Close()

        TxtSPI1.Text = StrISPM
        TxtSPI2.Text = StrIAUS
        TxtSPI3.Text = StrIAUG
        TxtSPI4.Text = StrIAUD

        ''Asignar valores a configuracion PTE
        'CBPTE1.Checked = CG_PTE_Calidad
        'CBPTE2A.Checked = CG_PTE_PorProd
        'CBPTE2B.Checked = CG_PTE_AlertaProd
        'TBPTE.Text = CG_PTE_Porcentaje
        'CBPTE3.Checked = CG_PTE_Almacen
        'CBPTE4.Checked = CG_PTE_OFExp
        'CBPTE5.Checked = CG_PTE_Embalaje
        'CBPTE6.Checked = CG_PTE_DifBasculas
        'CBPTE8.Checked = CG_ILPTE

        ''Asignar valores a configuracion PTI
        'CBPTI1.Checked = CG_PTI_Calidad
        'CBPTI2A.Checked = CG_PTI_PorProd
        'CBPTI2B.Checked = CG_PTI_AlertaProd
        'TBPTI.Text = CG_PTI_Porcentaje
        'CBPTI3.Checked = CG_PTI_Almacen
        'CBPTI4.Checked = CG_PTI_OFExp
        'CBPTI5.Checked = CG_PTI_Embalaje
        'CBPTI6.Checked = CG_PTI_DifBasculas
        'CBPTI8.Checked = CG_ILPTI

        ''Asignar valores a configuracion SG
        'CBSC1.Checked = CG_SG_DifBasculas
        'CBSC2.Checked = CG_ILSC

        ''Asignar valores a configuracion CR
        'CBCR1.Checked = CG_CR_DifBasculas
        'CBCR2.Checked = CG_ILCR

    End Sub

    Private Sub FrmAdminconfig_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        BPTE1.ReadOnly = True

    End Sub

    Private Sub BtnGrd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Q As String
        Dim RegistrosActualizados As Integer
        Dim StrBPTE1 As String
        Dim StrBPTE2 As String
        Dim StrBPTE3 As String
        Dim StrBPTE4 As String

        StrBPTE1 = BPTE1.Text.Trim()
        StrBPTE2 = BPTE2.Text.Trim()
        StrBPTE3 = BPTE3.Text.Trim()
        StrBPTE4 = BPTE4.Text.Trim()

        AbrirConfiguracion()

        objCmd = New SqlCommand
        objCmd.CommandType = CommandType.Text
        objCmd.Connection = objCnn
        Q = "UPDATE ADM_Config_Bascula "
        Q = Q & "SET BPTE1= '" & StrBPTE1 & "', "
        Q = Q & "BPTEX2 = '" & StrBPTE2 & "', "
        Q = Q & "BPTEX3 = '" & StrBPTE3 & "', "
        Q = Q & "BPTEX4 = '" & StrBPTE4 & "' "
        Q = Q & "WHERE ADM_Config_Bascula.PLANTA = '" & StrPlanta & "'"
        objCmd.CommandText = Q
        Try
            RegistrosActualizados = objCmd.ExecuteNonQuery()
        Catch ex1 As Exception
            MsgBox(ex1.Message)
            Exit Sub
        End Try
        BtnPostPTE.Enabled = False
        BPTE1.ReadOnly = True
        BPTE2.ReadOnly = True
        BPTE3.ReadOnly = True
        BPTE4.ReadOnly = True

    End Sub

    Private Sub BPT_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub BSG_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub BCR_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub BtnEdit_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BPTE1.ReadOnly = False
        BPTE2.ReadOnly = False
        BPTE3.ReadOnly = False
        BPTE4.ReadOnly = False
        BtnPostPTE.Enabled = True
    End Sub

    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        TxtRFC.ReadOnly = False
        TxtRazon.ReadOnly = False
        TxtDomicilio.ReadOnly = False
        TxtCol.ReadOnly = False
        TxtDM.ReadOnly = False
        TxtCP.ReadOnly = False
        TxtTel1.ReadOnly = False
        TxtTel2.ReadOnly = False
        TxtTel3.ReadOnly = False
        TxtFax.ReadOnly = False
        Txtemail.ReadOnly = False
        txtweb.ReadOnly = False
        Texto1.ReadOnly = False
        Texto2.ReadOnly = False
        BtnGrd.Enabled = True
    End Sub

    Private Sub BtnGrd_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGrd.Click
        Dim Q As String
        Dim RFC As String
        Dim RS As String
        Dim Dom As String
        Dim Col As String
        Dim DM As String
        Dim CP As String
        Dim TEL1 As String
        Dim TEL2 As String
        Dim TEL3 As String
        Dim FAX As String
        Dim Email As String
        Dim Web As String
        Dim TEXT1 As String
        Dim TEXT2 As String

        RFC = TxtRFC.Text.Trim()
        RS = TxtRazon.Text.Trim()
        Dom = TxtDomicilio.Text.Trim()
        Col = TxtCol.Text.Trim()
        DM = TxtDM.Text.Trim()
        CP = TxtCP.Text.Trim()
        TEL1 = TxtTel1.Text.Trim()
        TEL2 = TxtTel2.Text.Trim()
        TEL3 = TxtTel3.Text.Trim()
        FAX = TxtFax.Text.Trim()
        Email = Txtemail.Text.Trim()
        Web = txtweb.Text.Trim()
        TEXT1 = Texto1.Text.Trim()
        TEXT2 = Texto2.Text.Trim()

        AbrirConfiguracion()

        objCmd = New SqlCommand
        objCmd.CommandType = CommandType.Text
        objCmd.Connection = objCnn
        Q = "UPDATE ADM_Planta "
        Q = Q & "SET RFC = '" & RFC & "', "
        Q = Q & "Razon_Social = '" & RS & "', "
        Q = Q & "CalleNo = '" & Dom & "', "
        Q = Q & "Colonia = '" & Col & "', "
        Q = Q & "Descripcion = '" & DM & "', "
        Q = Q & "CP = '" & CP & "', "
        Q = Q & "Tel1 = '" & TEL1 & "', "
        Q = Q & "Tel2 = '" & TEL2 & "', "
        Q = Q & "Tel3 = '" & TEL3 & "', "
        Q = Q & "Fax = '" & FAX & "', "
        Q = Q & "Email = '" & Email & "', "
        Q = Q & "Web = '" & Web & "', "
        Q = Q & "Texto1 = '" & TEXT1 & "', "
        Q = Q & "Texto2 = '" & TEXT2 & "'  "
        Q = Q & "WHERE ADM_PLANTA.PLANTA = '" & strPlanta & "'"
        objCmd.CommandText = Q
        Try
            RegistrosActualizados = objCmd.ExecuteNonQuery()
        Catch ex1 As Exception
            MsgBox(ex1.Message)
            Exit Sub
        End Try

        TxtRFC.ReadOnly = True
        TxtRazon.ReadOnly = True
        TxtDomicilio.ReadOnly = True
        TxtCol.ReadOnly = True
        TxtDM.ReadOnly = True
        TxtCP.ReadOnly = True
        TxtTel1.ReadOnly = True
        TxtTel2.ReadOnly = True
        TxtTel3.ReadOnly = True
        TxtFax.ReadOnly = True
        Txtemail.ReadOnly = True
        txtweb.ReadOnly = True
        Texto1.ReadOnly = True
        Texto2.ReadOnly = True
        BtnGrd.Enabled = False

    End Sub

    Private Sub BtnPostPTE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim RegistrosActualizados As Integer
        Dim Q As String

        StrBPTE1 = BPTE1.Text.Trim()
        StrBPTE2 = BPTE2.Text.Trim()
        StrBPTE3 = BPTE3.Text.Trim()
        StrBPTE4 = BPTE4.Text.Trim()

        AbrirConfiguracion()

        Try
            If objCnn.State <> ConnectionState.Open Then
                objCnn.Open()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try

        objCmd.Connection = objCnn
        Q = "Update ADM_Config_Bascula set BPTE1 = '" & StrBPTE1 & "', "
        Q = Q & " BPTE2 = '" & StrBPTE2 & "', "
        Q = Q & " BPTE3 = '" & StrBPTE3 & "', "
        Q = Q & " BPTE4 = '" & StrBPTE4 & "' "
        Q = Q & " where ADM_Config_Bascula.planta = '" & StrPlanta & "'"
        '
        objCmd.CommandText = Q
        Try
            RegistrosActualizados = objCmd.ExecuteNonQuery()
        Catch ex1 As Exception
            MsgBox(ex1.Message)
            Exit Sub
        End Try

        MessageBox.Show(" Registro Actualizado ")

        BPTE1.Enabled = False
        BPTE2.Enabled = False
        BPTE3.Enabled = False
        BPTE4.Enabled = False
        BtnPostPTE.Enabled = False
    End Sub

    Private Sub BtnEditPTI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BPTI1.Enabled = True
        BPTI2.Enabled = True
        BPTI3.Enabled = True
        BPTI4.Enabled = True
        BtnPostPTI.Enabled = True
        BPTI1.Focus()
    End Sub

    Private Sub BtnPostPTI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim RegistrosActualizados As Integer
        Dim Q As String

        StrBPTI1 = BPTI1.Text.Trim()
        StrBPTI2 = BPTI2.Text.Trim()
        StrBPTI3 = BPTI3.Text.Trim()
        StrBPTI4 = BPTI4.Text.Trim()

        AbrirConfiguracion()

        Try
            If objCnn.State <> ConnectionState.Open Then
                objCnn.Open()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try

        objCmd.Connection = objCnn
        Q = "Update ADM_Config_Bascula set BPTI1 = '" & StrBPTI1 & "', "
        Q = Q & " BPTI2 = '" & StrBPTI2 & "', "
        Q = Q & " BPTI3 = '" & StrBPTI3 & "', "
        Q = Q & " BPTI4 = '" & StrBPTI4 & "' "
        Q = Q & " where ADM_Config_Bascula.planta = '" & StrPlanta & "'"
        '
        objCmd.CommandText = Q
        Try
            RegistrosActualizados = objCmd.ExecuteNonQuery()
        Catch ex1 As Exception
            MsgBox(ex1.Message)
            Exit Sub
        End Try

        MessageBox.Show(" Registro Actualizado ")

        BPTI1.Enabled = False
        BPTI2.Enabled = False
        BPTI3.Enabled = False
        BPTI4.Enabled = False
        BtnPostPTI.Enabled = False
    End Sub

    Private Sub BtnEditSG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BSC1.Enabled = True
        BSC2.Enabled = True
        BSC3.Enabled = True
        BSC4.Enabled = True
        BtnPostSG.Enabled = True
        BSC1.Focus()
    End Sub

    Private Sub BtnPostSG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim RegistrosActualizados As Integer
        Dim Q As String

        StrBSC1 = BSC1.Text.Trim()
        StrBSC2 = BSC2.Text.Trim()
        StrBSC3 = BSC3.Text.Trim()
        StrBSC4 = BSC4.Text.Trim()

        AbrirConfiguracion()

        Try
            If objCnn.State <> ConnectionState.Open Then
                objCnn.Open()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try

        objCmd.Connection = objCnn
        Q = "Update ADM_Config_Bascula set BSC1 = '" & StrBSC1 & "', "
        Q = Q & " BSC2 = '" & StrBSC2 & "', "
        Q = Q & " BSC3 = '" & StrBSC3 & "', "
        Q = Q & " BSC4 = '" & StrBSC4 & "' "
        Q = Q & " where ADM_Config_Bascula.planta = '" & StrPlanta & "'"
        '
        objCmd.CommandText = Q
        Try
            RegistrosActualizados = objCmd.ExecuteNonQuery()
        Catch ex1 As Exception
            MsgBox(ex1.Message)
            Exit Sub
        End Try

        MessageBox.Show(" Registro Actualizado ")

        BSC1.Enabled = False
        BSC2.Enabled = False
        BSC3.Enabled = False
        BSC4.Enabled = False
        BtnPostSG.Enabled = False
    End Sub

    Private Sub BtnEditCR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BCR1.Enabled = True
        BCR2.Enabled = True
        BCR3.Enabled = True
        BCR4.Enabled = True
        BtnPostCR.Enabled = True
        BCR1.Focus()
    End Sub

    Private Sub BtnPostCR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim RegistrosActualizados As Integer
        Dim Q As String

        StrBCR1 = BCR1.Text.Trim()
        StrBCR2 = BCR2.Text.Trim()
        StrBCR3 = BCR3.Text.Trim()
        StrBCR4 = BCR4.Text.Trim()

        AbrirConfiguracion()

        Try
            If objCnn.State <> ConnectionState.Open Then
                objCnn.Open()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try

        objCmd.Connection = objCnn
        Q = "Update ADM_Config_Bascula set BCR1 = '" & StrBCR1 & "', "
        Q = Q & " BCR2 = '" & StrBCR2 & "', "
        Q = Q & " BCR3 = '" & StrBCR3 & "', "
        Q = Q & " BCR4 = '" & StrBCR4 & "' "
        Q = Q & " where ADM_Config_Bascula.planta = '" & StrPlanta & "'"
        '
        objCmd.CommandText = Q
        Try
            RegistrosActualizados = objCmd.ExecuteNonQuery()
        Catch ex1 As Exception
            MsgBox(ex1.Message)
            Exit Sub
        End Try

        MessageBox.Show(" Registro Actualizado ")

        BCR1.Enabled = False
        BCR2.Enabled = False
        BCR3.Enabled = False
        BCR4.Enabled = False
        BtnPostCR.Enabled = False
    End Sub

    Private Sub BtnPost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPost.Click
        'consultamos el numero de bascula
        AbrirConfiguracion()
        objCmd.Connection = objCnn
        Q = "Select Max(Bascula)+1 as folioSiguiente from ADM_Basculas "
        objCmd.CommandText = Q
        Try
            myDataReader = objCmd.ExecuteReader()
        Catch ex1 As Exception
            MsgBox(ex1.Message)
            Exit Sub
        End Try
        '
        Dim FolioSiguiente As String
        FolioSiguiente = "1"
        Do While (myDataReader.Read())
            FolioSiguiente = myDataReader(0)
        Loop

        FolioSiguiente = FolioSiguiente.Trim()
        FolioSiguiente = Mid("000", 1, 3 - Len(FolioSiguiente)) & FolioSiguiente.Trim()
        myDataReader.Close()

        'Asignar valor a variables
        B_Bascula = FolioSiguiente
        B_Puerto = TxtPto.Text.Trim()
        B_TipPto = CBTipPto.Text.Trim()
        B_Baudios = TxtBau.Text.Trim()
        B_Paridad = TxtPar.Text.Trim()
        B_BitsDatos = Txtbd.Text.Trim()
        B_BitsParo = Txtbp.Text.Trim()

        'Se realiza la insercion del nuevo registro
        objCmd.Connection = objCnn
        Q = "INSERT INTO ADM_Basculas(Bascula, Puerto, TipPto, Baudios, Paridad, BitsDatos, BitsParo ) "
        Q = Q & " VALUES('" & B_Bascula & "', '" & B_Puerto & "', '" & B_TipPto & "', '" & B_Baudios & "', '" & B_Paridad & "', '" & B_BitsDatos & "', '" & B_BitsParo & "' )"
        objCmd.CommandText = Q

        Try
            RegistrosActualizados = objCmd.ExecuteNonQuery()
        Catch ex1 As Exception
            MsgBox(ex1.Message)
            Exit Sub
        End Try
        myDataReader.Close()

        'Lee Tabla ADM_Basculas para asignar datos al Datagrid de basculas

        Try
            objDa = New SqlDataAdapter("select *  from ADM_Basculas ", objCnn.ConnectionString)
            objDs = New DataSet
            objDa.Fill(objDs)
            DGBascula.DataSource = objDs

        Catch ex As Exception
            MessageBox.Show("Error Conexion :" & ex.Message)
        End Try


        MessageBox.Show("***  Registro Actualizado  *** ")

        TxtPto.Text = ""
        CBTipPto.Text = ""
        TxtBau.Text = ""
        TxtPar.Text = "N"
        Txtbd.Text = "8"
        Txtbp.Text = "1"
        TxtPto.Enabled = False
        CBTipPto.Enabled = False
        TxtBau.Enabled = False
        TxtPar.Enabled = False
        Txtbd.Enabled = False
        Txtbp.Enabled = False
        BtnPost.Enabled = False
        BtnIns.Enabled = True
    End Sub

    Private Sub TxtPto_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPto.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub TxtPto_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPto.Leave
        If TxtPto.Text = "" Then
            Dim Message As String = "Tecleé Número de Puerto"
            Dim Caption As String = "Campo vacio"
            Dim Buttons As MessageBoxButtons = MessageBoxButtons.OK
            Dim Result As DialogResult
            'Se presenta el mensaje en pantalla
            Result = MessageBox.Show(Message, Caption, Buttons)
            ' Se toma ejecuta el proceso de acuerdo a la decision tomada
            If Result = System.Windows.Forms.DialogResult.OK Then
                TxtPto.Text = ""
                TxtPto.Focus()
                Return
            End If
        End If
        CBTipPto.Text = ""
        CBTipPto.Focus()
    End Sub

    Private Sub CBTipPto_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CBTipPto.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub CBTipPto_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBTipPto.Leave
        If CBTipPto.Text = "" Then
            Dim Message As String = "Seleccione Tipo de Puerto Seial o USB"
            Dim Caption As String = "Campo vacio"
            Dim Buttons As MessageBoxButtons = MessageBoxButtons.OK
            Dim Result As DialogResult
            'Se presenta el mensaje en pantalla
            Result = MessageBox.Show(Message, Caption, Buttons)
            ' Se toma ejecuta el proceso de acuerdo a la decision tomada
            If Result = System.Windows.Forms.DialogResult.OK Then
                CBTipPto.Text = ""
                CBTipPto.Focus()
                Return
            End If
        End If
        TxtBau.Text = ""
        TxtBau.Focus()
    End Sub

    Private Sub TxtBau_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtBau.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub TxtBau_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtBau.Leave
        If TxtBau.Text = "" Then
            Dim Message As String = "Tecleé Baudios"
            Dim Caption As String = "Campo vacio"
            Dim Buttons As MessageBoxButtons = MessageBoxButtons.OK
            Dim Result As DialogResult
            'Se presenta el mensaje en pantalla
            Result = MessageBox.Show(Message, Caption, Buttons)
            ' Se toma ejecuta el proceso de acuerdo a la decision tomada
            If Result = System.Windows.Forms.DialogResult.OK Then
                TxtBau.Text = ""
                TxtBau.Focus()
                Return
            End If
        End If
        TxtPar.Focus()
    End Sub

    Private Sub TxtPar_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPar.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub TxtPar_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPar.Leave
        If TxtPar.Text = "" Then
            Dim Message As String = "Tecleé Paridad por default es N"
            Dim Caption As String = "Campo vacio"
            Dim Buttons As MessageBoxButtons = MessageBoxButtons.OK
            Dim Result As DialogResult
            'Se presenta el mensaje en pantalla
            Result = MessageBox.Show(Message, Caption, Buttons)
            ' Se toma ejecuta el proceso de acuerdo a la decision tomada
            If Result = System.Windows.Forms.DialogResult.OK Then
                TxtPar.Text = ""
                TxtPar.Focus()
                Return
            End If
        End If
        Txtbd.Focus()
    End Sub

    Private Sub Txtbd_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txtbd.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub Txtbd_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtbd.Leave
        If Txtbd.Text = "" Then
            Dim Message As String = "Tecleé bits de datos por default es 8"
            Dim Caption As String = "Campo vacio"
            Dim Buttons As MessageBoxButtons = MessageBoxButtons.OK
            Dim Result As DialogResult
            'Se presenta el mensaje en pantalla
            Result = MessageBox.Show(Message, Caption, Buttons)
            ' Se toma ejecuta el proceso de acuerdo a la decision tomada
            If Result = System.Windows.Forms.DialogResult.OK Then
                Txtbd.Text = ""
                Txtbd.Focus()
                Return
            End If
        End If
        Txtbp.Focus()
    End Sub

    Private Sub Txtbp_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txtbp.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub Txtbp_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtbp.Leave
        If Txtbp.Text = "" Then
            Dim Message As String = "Tecleé bits paridad por default 1"
            Dim Caption As String = "Campo vacio"
            Dim Buttons As MessageBoxButtons = MessageBoxButtons.OK
            Dim Result As DialogResult
            'Se presenta el mensaje en pantalla
            Result = MessageBox.Show(Message, Caption, Buttons)
            ' Se toma ejecuta el proceso de acuerdo a la decision tomada
            If Result = System.Windows.Forms.DialogResult.OK Then
                Txtbp.Text = ""
                Txtbp.Focus()
                Return
            End If
        End If
        TxtPto.Enabled = False
        CBTipPto.Enabled = False
        TxtBau.Enabled = False
        TxtPar.Enabled = False
        Txtbd.Enabled = False
        Txtbp.Enabled = False
        BtnPost.Enabled = True
    End Sub

    Private Sub CBPTE2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBPTE2.CheckedChanged
        If CBPTE2.Checked = True Then
            CBPTE2A.Enabled = True
            CBPTE2B.Enabled = True
            TBPTE.Enabled = True
        Else
            CBPTE2A.Enabled = False
            CBPTE2B.Enabled = False
            TBPTE.Enabled = False
        End If
    End Sub

    Private Sub BPTEedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BPTEedit.Click
        CBPTE1.Enabled = True
        CBPTE2.Enabled = True
        CBPTE3.Enabled = True
        CBPTE4.Enabled = True
        CBPTE5.Enabled = True
        CBPTE6.Enabled = True
        CBPTE7.Enabled = True
        CBPTE8.Enabled = True
        CBPTE9.Enabled = True
        BPTEedit.Enabled = False
        BPTEpost.Enabled = True
    End Sub

    Private Sub BPTEpost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BPTEpost.Click
        ''Reasignar valores a las variables
        'CG_PTE_Calidad = CBPTE1.CheckState
        'CG_PTE_PorProd = CBPTE2A.CheckState
        'CG_PTE_AlertaProd = CBPTE2B.CheckState
        'CG_PTE_Porcentaje = TBPTE.Text.Trim()
        'CG_PTE_Almacen = CBPTE3.CheckState
        'CG_PTE_OFExp = CBPTE4.CheckState
        'CG_PTE_Embalaje = CBPTE5.CheckState
        'CG_PTE_DifBasculas = CBPTE6.CheckState
        'CG_PTE_ScrapEfecto = CBPTE7.CheckState
        'CG_ILPTE = CBPTE8.CheckState
        'CG_PTE_PesoTeorico = CBPTE9.CheckState

        'AbrirConfiguracion()
        ''Se actualiza ADM_Config_General
        'objCmd.Connection = objCnn
        'Q = "Update ADM_Config_General set PTE_Calidad = " & CG_PTE_Calidad & ", "
        'Q = Q & "PTE_PorProd  = '" & CG_PTE_PorProd & "', "
        'Q = Q & "PTE_AlertaProd = '" & CG_PTE_AlertaProd & "', "
        'Q = Q & "PTE_Porcentaje = '" & CG_PTE_Porcentaje & "', "
        'Q = Q & "PTE_Almacen = " & CG_PTE_Almacen & ", "
        'Q = Q & "PTE_OFExp = '" & CG_PTE_OFExp & "', "
        'Q = Q & "PTE_Embalaje = '" & CG_PTE_Embalaje & "', "
        'Q = Q & "PTE_DifBasculas = '" & CG_PTE_DifBasculas & "', "
        'Q = Q & "PTE_ScrapEfecto = '" & CG_PTE_ScrapEfecto & "', "
        'Q = Q & "ILPTE = '" & CG_ILPTE & "' "
        'Q = Q & "WHERE Planta = '" & StrPlanta & "' "
        'objCmd.CommandText = Q

        Try
            Actualizados = objCmd.ExecuteNonQuery()
        Catch ex1 As Exception
            MsgBox(ex1.Message)
            Exit Sub
        End Try

        MessageBox.Show("Configuración Actualizada")

        CBPTE1.Enabled = False
        CBPTE2.Checked = False
        CBPTE2.Enabled = False
        CBPTE3.Enabled = False
        CBPTE4.Enabled = False
        CBPTE5.Enabled = False
        CBPTE6.Enabled = False
        CBPTE7.Enabled = False
        CBPTE8.Enabled = False
        BPTEedit.Enabled = True
        BPTEpost.Enabled = False

    End Sub

    Private Sub CBPTE2A_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBPTE2A.CheckedChanged
        If CBPTE2A.Checked = True Then
            CBPTE2B.Checked = False
            CBPTE2B.Enabled = False
        Else
            CBPTE2B.Enabled = True
        End If
    End Sub

    Private Sub CBPTE2B_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBPTE2B.CheckedChanged
        If CBPTE2B.Checked = True Then
            CBPTE2A.Checked = False
            CBPTE2A.Enabled = False
            TBPTE.Text = ""
            TBPTE.Enabled = False
        Else
            CBPTE2A.Enabled = True
            TBPTE.Enabled = True
        End If
    End Sub

    Private Sub BPostPTE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BPostPTE.Click
        StrBPTE1 = TxtPTE1.Text.Trim()
        StrBPTE2 = TxtPTE2.Text.Trim()
        StrBPTE3 = TxtPTE3.Text.Trim()
        StrBPTE4 = TxtPTE4.Text.Trim()

        AbrirConfiguracion()


        'Actualiza configuración basculas
        objCmd.Connection = objCnn
        Q = "Update ADM_Config_Bascula Set BPTE1 = '" & StrBPTE1 & "', "
        Q = Q & "BPTE2 = '" & StrBPTE2 & "', "
        Q = Q & "BPTE3 = '" & StrBPTE3 & "', "
        Q = Q & "BPTE4 = '" & StrBPTE4 & "' "
        Q = Q & "where Planta = '" & StrPlanta & "' "
        objCmd.CommandText = Q
        Try
            RegistrosActualizados = objCmd.ExecuteNonQuery()
        Catch ex1 As Exception
            MsgBox(ex1.Message)
            Exit Sub
        End Try

        MessageBox.Show("Se actualizo configuración")

        'If CG_PTE_DifBasculas = True Then
        '    TxtPTE1.Enabled = False
        '    TxtPTE2.Enabled = False
        '    TxtPTE3.Enabled = False
        '    TxtPTE4.Enabled = False
        '    BPostPTE.Enabled = False
        'Else
        '    TxtPTE1.Enabled = False
        '    BPostPTE.Enabled = False
        'End If
    End Sub

    Private Sub BBEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BBEdit.Click
        'If CG_PTE_DifBasculas = True Then
        '    TxtPTE1.Enabled = True
        '    TxtPTE2.Enabled = True
        '    TxtPTE3.Enabled = True
        '    TxtPTE4.Enabled = True
        '    BPostPTE.Enabled = True
        '    TxtPTE1.Focus()
        'Else
        '    TxtPTE1.Enabled = True
        '    BPostPTE.Enabled = True
        '    TxtPTE1.Focus()
        'End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        'If CG_PTE_DifBasculas = True Then
        '    TXTBPTI1.Enabled = True
        '    TXTBPTI2.Enabled = True
        '    TXTBPTI3.Enabled = True
        '    TXTBPTI4.Enabled = True
        '    BBPTIPost.Enabled = True
        '    TXTBPTI1.Focus()
        'Else
        '    TXTBPTI1.Enabled = True
        '    BBPTIPost.Enabled = True
        '    TXTBPTI1.Focus()
        'End If
    End Sub

    Private Sub BBPTIPost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BBPTIPost.Click
        StrBPTI1 = TXTBPTI1.Text.Trim()
        StrBPTI2 = TXTBPTI2.Text.Trim()
        StrBPTI3 = TXTBPTI3.Text.Trim()
        StrBPTI4 = TXTBPTI4.Text.Trim()

        AbrirConfiguracion()


        'Actualiza configuración basculas
        objCmd.Connection = objCnn
        Q = "Update ADM_Config_Bascula Set BPTI1 = '" & StrBPTI1 & "', "
        Q = Q & "BPTI2 = '" & StrBPTE2 & "', "
        Q = Q & "BPTI3 = '" & StrBPTE3 & "', "
        Q = Q & "BPTI4 = '" & StrBPTE4 & "' "
        Q = Q & "where Planta = '" & StrPlanta & "' "
        objCmd.CommandText = Q
        Try
            RegistrosActualizados = objCmd.ExecuteNonQuery()
        Catch ex1 As Exception
            MsgBox(ex1.Message)
            Exit Sub
        End Try

        MessageBox.Show("Se actualizo configuración")

        'If CG_PTE_DifBasculas = True Then
        '    TXTBPTI1.Enabled = False
        '    TXTBPTI2.Enabled = False
        '    TXTBPTI3.Enabled = False
        '    TXTBPTI4.Enabled = False
        '    BBPTIPost.Enabled = False
        'Else
        '    TXTBPTI1.Enabled = False
        '    BBPTIPost.Enabled = False
        'End If
    End Sub

    Private Sub BBSCEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BBSCEdit.Click
        'If CG_PTE_DifBasculas = True Then
        '    TXTBSC1.Enabled = True
        '    TXTBSC2.Enabled = True
        '    TXTBSC3.Enabled = True
        '    TXTBSC4.Enabled = True
        '    BBSCPost.Enabled = True
        '    TXTBSC1.Focus()
        'Else
        '    TXTBSC1.Enabled = True
        '    BBSCPost.Enabled = True
        '    TXTBSC1.Focus()
        'End If
    End Sub

    Private Sub BBSCPost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BBSCPost.Click
        StrBSC1 = TXTBSC1.Text.Trim()
        StrBSC2 = TXTBSC2.Text.Trim()
        StrBSC3 = TXTBSC3.Text.Trim()
        StrBSC4 = TXTBSC4.Text.Trim()

        AbrirConfiguracion()


        'Actualiza configuración basculas
        objCmd.Connection = objCnn
        Q = "Update ADM_Config_Bascula Set BSC1 = '" & StrBSC1 & "', "
        Q = Q & "BSC2 = '" & StrBSC2 & "', "
        Q = Q & "BSC3 = '" & StrBSC3 & "', "
        Q = Q & "BSC4 = '" & StrBSC4 & "' "
        Q = Q & "where Planta = '" & StrPlanta & "' "
        objCmd.CommandText = Q
        Try
            RegistrosActualizados = objCmd.ExecuteNonQuery()
        Catch ex1 As Exception
            MsgBox(ex1.Message)
            Exit Sub
        End Try

        MessageBox.Show("Se actualizo configuración")

        'If CG_PTE_DifBasculas = True Then
        '    TXTBSC1.Enabled = False
        '    TXTBSC2.Enabled = False
        '    TXTBSC3.Enabled = False
        '    TXTBSC4.Enabled = False
        '    BBSCPost.Enabled = False
        'Else
        '    TXTBSC1.Enabled = False
        '    BBSCPost.Enabled = False
        'End If
    End Sub

    Private Sub BBCREdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BBCREdit.Click
        'If CG_PTE_DifBasculas = True Then
        '    TXTBCR1.Enabled = True
        '    TXTBCR2.Enabled = True
        '    TXTBCR3.Enabled = True
        '    TXTBCR4.Enabled = True
        '    BBCRPost.Enabled = True
        '    TXTBCR1.Focus()
        'Else
        '    TXTBCR1.Enabled = True
        '    BBCRPost.Enabled = True
        '    TXTBCR1.Focus()
        'End If
    End Sub

    Private Sub BBCRPost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BBCRPost.Click
        StrBCR1 = TXTBCR1.Text.Trim()
        StrBCR2 = TXTBCR2.Text.Trim()
        StrBCR3 = TXTBCR3.Text.Trim()
        StrBCR4 = TXTBCR4.Text.Trim()

        AbrirConfiguracion()


        'Actualiza configuración basculas
        objCmd.Connection = objCnn
        Q = "Update ADM_Config_Bascula Set BCR1 = '" & StrBCR1 & "', "
        Q = Q & "BCR2 = '" & StrBCR2 & "', "
        Q = Q & "BCR3 = '" & StrBCR3 & "', "
        Q = Q & "BCR4 = '" & StrBCR4 & "' "
        Q = Q & "where Planta = '" & StrPlanta & "' "
        objCmd.CommandText = Q
        Try
            RegistrosActualizados = objCmd.ExecuteNonQuery()
        Catch ex1 As Exception
            MsgBox(ex1.Message)
            Exit Sub
        End Try

        MessageBox.Show("Se actualizo configuración")

        'If CG_PTE_DifBasculas = True Then
        '    TXTBCR1.Enabled = False
        '    TXTBCR2.Enabled = False
        '    TXTBCR3.Enabled = False
        '    TXTBCR4.Enabled = False
        '    BBCRPost.Enabled = False
        'Else
        '    TXTBCR1.Enabled = False
        '    BBCRPost.Enabled = False
        'End If
    End Sub

    Private Sub BFoliosEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BFoliosEdit.Click
        TxtFPTE.ReadOnly = False
        TxtFPTI.ReadOnly = False
        TxtFSG.ReadOnly = False
        TxtFCR.ReadOnly = False
        BFolioPost.Enabled = True
    End Sub

    Private Sub BFolioPost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BFolioPost.Click
        StrFPTE = TxtFPTE.Text.Trim()
        StrFPTI = TxtFPTI.Text.Trim()
        StrFSG = TxtFSG.Text.Trim()
        StrFCR = TxtFCR.Text.Trim()

        AbrirAmanco()


        'Actualiza configuración folios
        objCmd.Connection = objCnnAmanco
        Q = "Update MCPC_Foliador Set Producto_Terminado = '" & StrFPTE & "', "
        Q = Q & "PT_Inyeccion = '" & StrFPTI & "', "
        Q = Q & "Scrap = '" & StrFSG & "', "
        Q = Q & "Compuesto = '" & StrFCR & "' "
        Q = Q & "where Planta = '" & StrPlanta & "' "
        objCmd.CommandText = Q
        Try
            RegistrosActualizados = objCmd.ExecuteNonQuery()
        Catch ex1 As Exception
            MsgBox(ex1.Message)
            Exit Sub
        End Try

        MessageBox.Show("Se actualizo configuración")

        TxtFPTE.ReadOnly = True
        TxtFPTI.ReadOnly = True
        TxtFSG.ReadOnly = True
        TxtFCR.ReadOnly = True
        BFolioPost.Enabled = False

    End Sub

    Private Sub BSPEEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSPEEdit.Click
        TxtSPE1.ReadOnly = False
        TxtSPE2.ReadOnly = False
        TxtSPE3.ReadOnly = False
        TxtSPE4.ReadOnly = False
        BSPEPost.Enabled = True
    End Sub

    Private Sub BSPEPost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSPEPost.Click
        StrESPM = TxtSPE1.Text.Trim()
        StrEAUS = TxtSPE2.Text.Trim()
        StrEAUG = TxtSPE3.Text.Trim()
        StrEAUD = TxtSPE4.Text.Trim()

        AbrirConfiguracion()


        'Actualiza configuración folios
        objCmd.Connection = objCnn
        Q = "Update ADM_SobrepesoPlanta Set Sobrepeso_Maximo = '" & StrESPM & "', "
        Q = Q & "Autoriza_Supervisor = '" & StrEAUS & "', "
        Q = Q & "Autoriza_Gerente = '" & StrEAUG & "', "
        Q = Q & "Autoriza_Director  = '" & StrEAUD & "' "
        Q = Q & "where Planta = '" & StrPlanta & "' "
        Q = Q & "and Modulo = 'PTE' "
        objCmd.CommandText = Q
        Try
            RegistrosActualizados = objCmd.ExecuteNonQuery()
        Catch ex1 As Exception
            MsgBox(ex1.Message)
            Exit Sub
        End Try

        MessageBox.Show("Se actualizo configuración")

        TxtSPE1.ReadOnly = True
        TxtSPE2.ReadOnly = True
        TxtSPE3.ReadOnly = True
        TxtSPE4.ReadOnly = True
        BSPEPost.Enabled = False
    End Sub

    Private Sub BSPIEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSPIEdit.Click
        TxtSPI1.ReadOnly = False
        TxtSPI2.ReadOnly = False
        TxtSPI3.ReadOnly = False
        TxtSPI4.ReadOnly = False
        BSPIPost.Enabled = True
    End Sub

    Private Sub BSPIPost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSPIPost.Click
        StrISPM = TxtSPI1.Text.Trim()
        StrIAUS = TxtSPI2.Text.Trim()
        StrIAUG = TxtSPI3.Text.Trim()
        StrIAUD = TxtSPI4.Text.Trim()

        AbrirConfiguracion()


        'Actualiza configuración folios
        objCmd.Connection = objCnn
        Q = "Update ADM_SobrepesoPlanta Set Sobrepeso_Maximo = '" & StrISPM & "', "
        Q = Q & "Autoriza_Supervisor = '" & StrIAUS & "', "
        Q = Q & "Autoriza_Gerente = '" & StrIAUG & "', "
        Q = Q & "Autoriza_Director  = '" & StrIAUD & "' "
        Q = Q & "where Planta = '" & StrPlanta & "' "
        Q = Q & "and Modulo = 'PTI' "
        objCmd.CommandText = Q
        Try
            RegistrosActualizados = objCmd.ExecuteNonQuery()
        Catch ex1 As Exception
            MsgBox(ex1.Message)
            Exit Sub
        End Try

        MessageBox.Show("Se actualizo configuración")

        TxtSPI1.ReadOnly = True
        TxtSPI2.ReadOnly = True
        TxtSPI3.ReadOnly = True
        TxtSPI4.ReadOnly = True
        BSPIPost.Enabled = False
    End Sub

    Private Sub BPTIedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BPTIedit.Click
        CBPTI1.Enabled = True
        CBPTI2.Enabled = True
        CBPTI3.Enabled = True
        CBPTI4.Enabled = True
        CBPTI5.Enabled = True
        CBPTI6.Enabled = True
        CBPTI7.Enabled = True
        CBPTI8.Enabled = True
        CBPTI9.Enabled = True
        BPTIedit.Enabled = False
        BPTIpost.Enabled = True
    End Sub

    Private Sub BPTIpost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BPTIpost.Click
        ''Reasignar valores a las variables
        'CG_PTI_Calidad = CBPTI1.CheckState
        'CG_PTI_PorProd = CBPTI2A.CheckState
        'CG_PTI_AlertaProd = CBPTI2B.CheckState
        'CG_PTI_Porcentaje = TBPTI.Text.Trim()
        'CG_PTI_Almacen = CBPTI3.CheckState
        'CG_PTI_OFExp = CBPTI4.CheckState
        'CG_PTI_Embalaje = CBPTI5.CheckState
        'CG_PTI_DifBasculas = CBPTI6.CheckState
        'CG_PTI_ScrapEfecto = CBPTI7.CheckState
        'CG_ILPTI = CBPTI8.CheckState

        'AbrirConfiguracion()
        ''Se actualiza ADM_Config_General
        'objCmd.Connection = objCnn
        'Q = "Update ADM_Config_General set PTI_Calidad = " & CG_PTI_Calidad & ", "
        'Q = Q & "PTI_PorProd  = '" & CG_PTI_PorProd & "', "
        'Q = Q & "PTI_AlertaProd = '" & CG_PTI_AlertaProd & "', "
        'Q = Q & "PTI_Porcentaje = '" & CG_PTI_Porcentaje & "', "
        'Q = Q & "PTI_Almacen = " & CG_PTI_Almacen & ", "
        'Q = Q & "PTI_OFExp = '" & CG_PTI_OFExp & "', "
        'Q = Q & "PTI_Embalaje = '" & CG_PTI_Embalaje & "', "
        'Q = Q & "PTI_DifBasculas = '" & CG_PTI_DifBasculas & "', "
        'Q = Q & "PTI_ScrapEfecto = '" & CG_PTI_ScrapEfecto & "', "
        'Q = Q & "ILPTI = '" & CG_ILPTI & "' "
        'Q = Q & "WHERE Planta = '" & StrPlanta & "' "
        'objCmd.CommandText = Q

        'Try
        '    Actualizados = objCmd.ExecuteNonQuery()
        'Catch ex1 As Exception
        '    MsgBox(ex1.Message)
        '    Exit Sub
        'End Try

        'MessageBox.Show("Configuración Actualizada")

        'CBPTI1.Enabled = False
        'CBPTI2.Checked = False
        'CBPTI2.Enabled = False
        'CBPTI3.Enabled = False
        'CBPTI4.Enabled = False
        'CBPTI5.Enabled = False
        'CBPTI6.Enabled = False
        'CBPTI7.Enabled = False
        'CBPTI8.Enabled = False
        'BPTIedit.Enabled = True
        'BPTIpost.Enabled = False
    End Sub

    Private Sub BSCedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSCedit.Click
        CBSC1.Enabled = True
        CBSC2.Enabled = True
        BSCedit.Enabled = False
        BSCpost.Enabled = True
    End Sub

    Private Sub BSCpost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSCpost.Click
        ''Reasignar valores a las variables
        'CG_SG_DifBasculas = CBSC1.CheckState
        'CG_ILSC = CBSC2.CheckState

        'AbrirConfiguracion()
        ''Se actualiza ADM_Config_General
        'objCmd.Connection = objCnn
        'Q = "Update ADM_Config_General set SG_DifBasculas = " & CG_SG_DifBasculas & ", "
        'Q = Q & "ILSC = '" & CG_ILSC & "' "
        'Q = Q & "WHERE Planta = '" & StrPlanta & "' "
        'objCmd.CommandText = Q

        'Try
        '    Actualizados = objCmd.ExecuteNonQuery()
        'Catch ex1 As Exception
        '    MsgBox(ex1.Message)
        '    Exit Sub
        'End Try

        'MessageBox.Show("Configuración Actualizada")

        'CBSC1.Enabled = False
        'CBSC2.Enabled = False
        'BSCedit.Enabled = True
        'BSCpost.Enabled = False
    End Sub

    Private Sub BCRedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BCRedit.Click
        CBCR1.Enabled = True
        CBCR2.Enabled = True
        BCRedit.Enabled = False
        BCRpost.Enabled = True
    End Sub

    Private Sub BCRpost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BCRpost.Click
        ''Reasignar valores a las variables
        'CG_CR_DifBasculas = CBSC1.CheckState
        'CG_ILCR = CBSC2.CheckState

        'AbrirConfiguracion()
        ''Se actualiza ADM_Config_General
        'objCmd.Connection = objCnn
        'Q = "Update ADM_Config_General set CR_DifBasculas = " & CG_CR_DifBasculas & ", "
        'Q = Q & "ILCR = '" & CG_ILCR & "' "
        'Q = Q & "WHERE Planta = '" & StrPlanta & "' "
        'objCmd.CommandText = Q

        'Try
        '    Actualizados = objCmd.ExecuteNonQuery()
        'Catch ex1 As Exception
        '    MsgBox(ex1.Message)
        '    Exit Sub
        'End Try

        'MessageBox.Show("Configuración Actualizada")

        'CBSC1.Enabled = True
        'CBSC2.Enabled = True
        'BSCedit.Enabled = False
        'BSCpost.Enabled = True
    End Sub

    Private Sub CBPTI2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBPTI2.CheckedChanged
        If CBPTI2.Checked = True Then
            CBPTI2A.Enabled = True
            CBPTI2B.Enabled = True
            TBPTI.Enabled = True
        Else
            CBPTI2A.Enabled = False
            CBPTI2B.Enabled = False
            TBPTI.Enabled = False
        End If
    End Sub
End Class