Imports System.Configuration
Imports System.Data.SqlClient
Imports Atlas.Accesos.CLVarGlobales
Imports Atlas.Accesos
Imports SQL_DATA
Public Class FrmAdminPPTIny
    Dim Status_Notif As String
    Dim ODF As String
    Dim folio As String
    Dim Notif As String
    Dim xORIGINAL As String = ""
    Dim Qdg As String = ""
    Dim xRegCount As Integer = 0
    Dim tablaEXTINY As String = ""
    Dim objExcel As Object
    Dim wks As Object

    Dim Obj_Excel As Object
    Dim Obj_Libro As Object
    Dim Obj_Hoja As Object
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Close()
    End Sub
    Private Sub CB2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB2.CheckedChanged
        If CB2.Checked = True Then
            CB3.Enabled = False
            CB4.Enabled = False
            lblODF.Visible = True
            lblEQUIPO.Visible = False
            TxtOrdProd.Text = ""
            TxtOrdProd.Visible = True
            txtEquipo.Visible = False
            lblTurno.Visible = False
            cmbTurnos.Visible = False
        ElseIf CB2.Checked = False Then
            CB3.Enabled = True
            CB4.Enabled = True
            lblODF.Visible = False
            lblEQUIPO.Visible = False
            TxtOrdProd.Visible = False
            txtEquipo.Visible = False
            lblTurno.Visible = False
            cmbTurnos.Visible = False
            TxtOrdProd.Text = "*"
            LimpiaObjetos()
            DGPPT.DataSource = Nothing
            DGOP.DataSource = Nothing
            DGSC.DataSource = Nothing
        End If
    End Sub

    Private Sub FrmAdminPPT_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        CB2.Checked = False
        CB3.Checked = False
        CB4.Checked = False
        TxtOrdProd.Text = "*"
    End Sub

    Private Sub CB3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB3.CheckedChanged
        If CB3.Checked = True Then
            CB2.Enabled = False
            CB4.Enabled = False
            lblPeriodo.Visible = True
            DTP1.Visible = True
            DTP2.Visible = True
            lblODF.Visible = True
            lblEQUIPO.Visible = False
            TxtOrdProd.Text = "*"
            TxtOrdProd.Visible = True
            txtEquipo.Visible = False
            lblTurno.Visible = True
            cmbTurnos.Visible = True
        Else
            CB2.Enabled = True
            CB4.Enabled = True
            lblPeriodo.Visible = False
            DTP1.Visible = False
            DTP2.Visible = False
            lblODF.Visible = False
            lblEQUIPO.Visible = False
            TxtOrdProd.Visible = False
            TxtOrdProd.Text = "*"
            txtEquipo.Visible = False
            txtEquipo.Text = "*"
            lblTurno.Visible = False
            cmbTurnos.Visible = False
            LimpiaObjetos()
            DGPPT.DataSource = Nothing
            DGOP.DataSource = Nothing
            DGSC.DataSource = Nothing
        End If
    End Sub
    Private Sub CB4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB4.CheckedChanged
        If CB4.Checked = True Then
            CB2.Enabled = False
            CB3.Enabled = False
            lblPeriodo.Visible = True
            DTP1.Visible = True
            DTP2.Visible = True
            lblODF.Visible = False
            TxtOrdProd.Visible = False
            lblEQUIPO.Visible = True
            txtEquipo.Visible = True
            lblTurno.Visible = True
            cmbTurnos.Visible = True
            LimpiaObjetos()
        Else
            CB2.Enabled = True
            CB3.Enabled = True
            lblPeriodo.Visible = False
            DTP1.Visible = False
            DTP2.Visible = False
            lblODF.Visible = False
            TxtOrdProd.Visible = False
            TxtOrdProd.Text = "*"
            lblEQUIPO.Visible = False
            txtEquipo.Visible = False
            txtEquipo.Text = "*"
            lblTurno.Visible = False
            cmbTurnos.Visible = False
            LimpiaObjetos()
            DGPPT.DataSource = Nothing
            DGOP.DataSource = Nothing
            DGSC.DataSource = Nothing
        End If
    End Sub
    Private Sub LimpiaObjetos()
        TxtOrdProdSel.Text = ""
        TCantProgra.Text = "0" & GDECIMAL & "00"
        TCantEntre.Text = "0" & GDECIMAL & "00"
        TCantEnproce.Text = "0" & GDECIMAL & "00"
        TCantpendi.Text = "0" & GDECIMAL & "00"

        TTrabajadas.Text = "0" & GDECIMAL & "00"
        TProg.Text = "0" & GDECIMAL & "00"
        TMant.Text = "0" & GDECIMAL & "00"
        TSetu.Text = "0" & GDECIMAL & "00"
        TOtro.Text = "0" & GDECIMAL & "00"

        txtTotkilosprod.Text = "0" & GDECIMAL & "00"
        txtTotunprod.Text = "0" & GDECIMAL & "00"
        txtTotkilosproceso.Text = "0" & GDECIMAL & "00"
        txtTotunproceso.Text = "0" & GDECIMAL & "00"
        txtTotkilosscrap.Text = "0" & GDECIMAL & "00"
        txtTotunscrap.Text = "0" & GDECIMAL & "00"
        txtTotkilossprut.Text = "0" & GDECIMAL & "00"
        txtTotkilospurga.Text = "0" & GDECIMAL & "00"


        txtPorscrap.Text = "0" & GDECIMAL & "00"
        txtPorsprut.Text = "0" & GDECIMAL & "00"

        txtTotHorastrab.Text = "0" & GDECIMAL & "00"
        txtTotHorasprog.Text = "0" & GDECIMAL & "00"
        txtTotHorasmant.Text = "0" & GDECIMAL & "00"
        txtTotHorassetu.Text = "0" & GDECIMAL & "00"
        txtTotHorasotro.Text = "0" & GDECIMAL & "00"

        DGPPT.CaptionText = "Detalle Pesaje por ORDEN-MAQUINA             Registros: 0"
        DGOP.CaptionText = "Resumen pesaje por ORDEN-MAQUINA          Registros: 0"
        DGSC.CaptionText = "Resumen pesaje por SECCIÓN          Registros: 0"
    End Sub

    Private Sub tsbImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbImprimir.Click
        If DGPPT.CurrentRowIndex > -1 Or DGPPT.CurrentCell.RowNumber > 0 Then
            xORIGINAL = "  ============ COPIA   "
            If DGPPT(DGPPT.CurrentCell.RowNumber, 5) = "PRODUCCION" Or DGPPT(DGPPT.CurrentCell.RowNumber, 5) = "SOBREPESO" Then
                imprimir_PT()
            Else
                imprimir_SC()
            End If
        End If
    End Sub

    Sub imprimir_PT()
        Dim PFolioAtlas As String = ""
        Dim PFechaPesaje As String = ""
        Dim PHoraPesaje As String = ""
        Dim PTurno As String = ""
        Dim PFechaTurno As String = ""
        Dim PrbtFinal As String = ""
        Dim PGrpprod As String = ""
        Dim PGrpproddesc As String = ""
        Dim POrden As String = ""
        Dim PCodPT As String = ""
        Dim PCodPtDecr As String = ""
        Dim PtramosNoti As String = ""
        Dim PPesoBruto As String = ""
        Dim PPesoTara As String = ""
        Dim PPesoNeto As String = ""
        ' Dim PSobrePeso As String = ""
        Dim PPesoTeorico As String = ""
        Dim PPtoTrabajo As String = ""
        Dim PCodOperador As String = ""
        Dim PNomOperador As String = ""


        PFolioAtlas = DGPPT(DGPPT.CurrentCell.RowNumber, 25)
        POrden = DGPPT(DGPPT.CurrentCell.RowNumber, 0)

        QRY = ""
        QRY = QRY & " SELECT PPT.Folio, PPT.Fecha_Pesaje, PPT.Hora_Pesaje, PPT.Turno, PPT.Fecha_Turno, PPT.Notifica,  "
        QRY = QRY & " PTE.Grpprod, CGR.desgrupo, PPT.Orden_Produccion, PTE.Codigo, PTE.Descr , PPT.Tramos,PPT.Peso_Bruto,  "
        QRY = QRY & " PPT.Tara, PPT.Peso_Neto, PPT.Peso_teorico, PPT.PuestoTrabajo, PPT.Usuario"
        QRY = QRY & " FROM  (" & SessionUser._sCentro.Trim & "_PesoProductoTerminado PPT "
        QRY = QRY & " INNER JOIN " & SessionUser._sCentro.Trim & "_OrdenProduccion OP ON OP.Planta= PPT.PLANTA and  PPT.Orden_Produccion = OP.Orden_Produccion)"
        QRY = QRY & " INNER JOIN MCPC_EquipoBasico EB    ON PPT.planta = EB.Planta AND PPT.PuestoTrabajo = EB.Equipo_basico AND EB.Tpo_equipo_basico= '" & EXTINY & "' "
        QRY = QRY & " INNER JOIN " & tablaEXTINY & " PTE ON PTE.CENTRO= OP.PLANTA  and  PTE.Codigo = OP.Producto "
        QRY = QRY & " INNER JOIN catgrupos CGR           ON PTE.CENTRO= CGR.CENTRO and  PTE.Grpprod = CGR.Grpprod "
        QRY = QRY & " WHERE  PPT.Planta = '" & SessionUser._sCentro.Trim & "' AND PPT.Orden_Produccion = '" & POrden.Trim & "' AND PPT.folio='" & PFolioAtlas.Trim & "'"
        LecturaQry(QRY)

        If LecturaBD.Read() Then
            PFolioAtlas = LecturaBD(0)
            PFechaPesaje = LecturaBD(1)
            PHoraPesaje = LecturaBD(2)
            PTurno = LecturaBD(3)
            PFechaTurno = LecturaBD(4)
            PrbtFinal = LecturaBD(5)
            PGrpprod = LecturaBD(6)
            PGrpproddesc = LecturaBD(7)
            POrden = LecturaBD(8)
            PCodPT = LecturaBD(9)
            PCodPtDecr = LecturaBD(10)
            PtramosNoti = LecturaBD(11)
            PPesoBruto = LecturaBD(12)
            PPesoTara = LecturaBD(13)
            PPesoNeto = LecturaBD(14)
            '    PSobrePeso = LecturaBD(15)
            PPesoTeorico = LecturaBD(15)
            PPtoTrabajo = LecturaBD(16)
            PCodOperador = LecturaBD(17)
        End If
        LecturaBD.Close()

        QRY_AMD = ""
        QRY_AMD = "Select Usuario, Nombre From  ADM_Usuario "
        QRY_AMD = QRY_AMD & " WHERE  Usuario = '" & PCodOperador.Trim & "' And Planta = '" & SessionUser._sCentro.Trim & "'"
        LecturaQry_AMD(QRY_AMD)
        PNomOperador = ""
        If LecturaBD_AMD.Read() Then
            PNomOperador = LecturaBD_AMD(1)
        End If
        LecturaBD_AMD.Close()

        FileOpen(1, GETIQUETAS.Trim & "\barcode.TXT", OpenMode.Output)
        PrintLine(1)
        PrintLine(1, GEMPRESA.Trim)
        PrintLine(1, "PRODUCCION CONTROL DE PESAJE")
        PrintLine(1)
        PrintLine(1, "   FOLIO: " & PFolioAtlas.Trim)
        PrintLine(1, "F.PESAJE: " & PFechaPesaje.Trim)
        PrintLine(1, "H.PESAJE: " & Mid(PHoraPesaje.Trim, 1, 8))
        PrintLine(1)
        PrintLine(1, "TURNO: " & PTurno.Trim & "   F.TURNO: " & PFechaTurno.Trim)
        PrintLine(1)
        If PrbtFinal = 0 Or PrbtFinal = 1 Or PrbtFinal = 4 Then
            PrintLine(1, "  * * *  PRODUCCION FINAL  ")
        End If

        If PrbtFinal = 2 Then
            PrintLine(1, "  * * *  PRODUCCION FINAL - SOBREPESO  ")
        End If

        If PrbtFinal = 3 Then
            PrintLine(1, "  * * *  PRODUCCION EN PROCESO  ")
        End If
        PrintLine(1)
        PrintLine(1, " TIPO PROD.: " & PGrpprod.Trim & "    " & PGrpproddesc.Trim)
        PrintLine(1)
        PrintLine(1, "   O.D.F.: " & POrden.Trim)
        PrintLine(1, " MATERIAL: " & PCodPT.Trim)
        PrintLine(1, " " & Mid(PCodPtDecr.Trim, 1, 30))
        PrintLine(1)
        PrintLine(1, " UNIDADES: " & Str(Val(PtramosNoti.Trim)))
        PrintLine(1, " P. BRUTO: " & Str(Val(PPesoBruto.Trim)))
        PrintLine(1, "     TARA: " & Str(Val(PPesoTara.Trim)))
        PrintLine(1, "  P. NETO: " & Str(Val(PPesoNeto.Trim)))
        PrintLine(1)
        PrintLine(1, " PESO TEORICO: " & Str(Val(PPesoTeorico.Trim)))
        PrintLine(1)
        PrintLine(1, xORIGINAL)
        PrintLine(1)
        PrintLine(1, "P.TRABAJO: " & PPtoTrabajo.Trim)
        PrintLine(1, " OPERADOR: " & PCodOperador.Trim & "    " & PNomOperador.Trim)
        FileClose(1)
        Shell(GETIQUETAS.Trim & "\printcode.bat", AppWinStyle.Hide, True)
    End Sub
    Sub imprimir_SC()
        Dim PFolioAtlas As String = ""
        Dim PFechaPesaje As String = ""
        Dim PHoraPesaje As String = ""
        Dim PTurno As String = ""
        Dim PFechaTurno As String = ""
        Dim PrbtFinal As String = ""
        Dim PGrpprod As String = ""
        Dim PGrpproddesc As String = ""
        Dim POrden As String = ""
        Dim PCodPT As String = ""
        Dim PCodPtDecr As String = ""
        Dim PtramosNoti As String = ""
        Dim PPesoBruto As String = ""
        Dim PPesoTara As String = ""
        Dim PPesoNeto As String = ""
        Dim PCausa As String = ""
        Dim PDesccausa As String = ""
        Dim PPtoTrabajo As String = ""
        Dim PCodOperador As String = ""
        Dim PNomOperador As String = ""

        PFolioAtlas = DGPPT(DGPPT.CurrentCell.RowNumber, 25)
        POrden = DGPPT(DGPPT.CurrentCell.RowNumber, 0)

        QRY = ""
        QRY = QRY & " Select PSC.Folio, PSC.Fecha_Pesaje, PSC.Hora_Pesaje, PSC.Turno, PSC.Fecha_Turno, PSC.Notifica,  "
        QRY = QRY & " PTE.Grpprod, CGR.desgrupo, PSC.Orden_Produccion, PTE.Codigo, PTE.Descr , PSC.Tramos, PSC.Peso_Bruto,  "
        QRY = QRY & " PSC.Tara, PSC.Peso_Neto, PSC.Causa, CA.descausagrupa, PSC.PuestoTrabajo, PSC.Usuario, PSC.tipo_Scrap, PSC.folioR "
        QRY = QRY & " FROM  (" & SessionUser._sCentro.Trim & "_PesoScrap PSC "
        QRY = QRY & " inner join " & SessionUser._sCentro.Trim & "_OrdenProduccion OP ON OP.Planta= PSC.PLANTA and  PSC.Orden_Produccion = OP.Orden_Produccion)"
        QRY = QRY & " inner join MCPC_EquipoBasico EB ON PSC.planta = EB.Planta AND PSC.PuestoTrabajo = EB.Equipo_basico AND EB.Tpo_equipo_basico= '" & EXTINY & "' "
        QRY = QRY & " inner join " & tablaEXTINY & " PTE ON PTE.CENTRO= OP.PLANTA and  PTE.Codigo = OP.Producto "
        QRY = QRY & " inner join catgrupos CGR                  ON PTE.Centro = CGR.CENTRO AND PTE.Grpprod = CGR.Grpprod "
        QRY = QRY & " INNER JOIN CatCausas CC                   ON CC.Centro=PTE.Centro    AND CC.grpprod=PTE.grpprod             AND CC.codcausagrupa=PSC.Causa  AND CC.codcausgeneral=PSC.efecto  AND CC.Tipocausa='SC' "
        QRY = QRY & " INNER JOIN CatAgrupaciones CA             ON CA.centro= PTE.centro   AND CC.codcausagrupa = CA.codcausagrupa  AND CA.status = 'A'                AND NOT CA.codgrpgeneral= '0' "
        QRY = QRY & " INNER JOIN Catgrpgeneral   CGG            ON CGG.centro= CA.centro   AND CA.codgrpgeneral = CGG.codgrpgeneral  AND CGG.status = 'A' "
        QRY = QRY & " WHERE  PSC.Planta = '" & SessionUser._sCentro.Trim & "' AND PSC.Orden_Produccion = '" & POrden.Trim & "' AND PSC.folio='" & PFolioAtlas.Trim & "'"
        LecturaQry(QRY)

        Do While (LecturaBD.Read())
            PFolioAtlas = LecturaBD(0)
            PFechaPesaje = LecturaBD(1)
            PHoraPesaje = LecturaBD(2)
            PTurno = LecturaBD(3)
            PFechaTurno = LecturaBD(4)
            PrbtFinal = LecturaBD(5)
            PGrpprod = LecturaBD(6)
            PGrpproddesc = LecturaBD(7)
            POrden = LecturaBD(8)
            PCodPT = LecturaBD(9)
            PCodPtDecr = LecturaBD(10)
            PtramosNoti = LecturaBD(11)
            PPesoBruto = LecturaBD(12)
            PPesoTara = LecturaBD(13)
            PPesoNeto = LecturaBD(14)

            PCausa = LecturaBD(15)
            PDesccausa = LecturaBD(16)

            PPtoTrabajo = LecturaBD(17)
            PCodOperador = LecturaBD(18)
        Loop
        LecturaBD.Close()

        QRY_AMD = ""
        QRY_AMD = "Select Usuario, Nombre From  ADM_Usuario "
        QRY_AMD = QRY_AMD & " WHERE  Usuario = '" & PCodOperador.Trim & "' And Planta = '" & SessionUser._sCentro.Trim & "'"
        LecturaQry_AMD(QRY_AMD)
        PNomOperador = ""
        Do While (LecturaBD_AMD.Read)
            PNomOperador = LecturaBD_AMD(1)
        Loop
        LecturaBD_AMD.Close()

        FileOpen(1, GETIQUETAS.Trim & "\barcode.TXT", OpenMode.Output)
        PrintLine(1)
        PrintLine(1, GEMPRESA.Trim)
        PrintLine(1, "PRODUCCION CONTROL DE PESAJE")
        PrintLine(1)
        PrintLine(1, "   FOLIO: " & PFolioAtlas.Trim)
        PrintLine(1, "F.PESAJE: " & PFechaPesaje.Trim)
        PrintLine(1, "H.PESAJE: " & Mid(PHoraPesaje.Trim, 1, 8))
        PrintLine(1)
        PrintLine(1, "TURNO: " & PTurno.Trim & "   F.TURNO: " & PFechaTurno.Trim)
        PrintLine(1)
        PrintLine(1, "  * * *  " & DGPPT(DGPPT.CurrentCell.RowNumber, 5))
        PrintLine(1)
        PrintLine(1, " TIPO PROD.: " & PGrpprod.Trim & "    " & PGrpproddesc.Trim)
        PrintLine(1)
        PrintLine(1, "   O.D.F.: " & POrden.Trim)
        PrintLine(1, " MATERIAL: " & PCodPT.Trim)
        PrintLine(1, " " & Mid(PCodPtDecr.Trim, 1, 30))
        PrintLine(1)
        PrintLine(1, "U.RECHAZO: " & Str(Val(PtramosNoti.Trim)))
        PrintLine(1, " P. BRUTO: " & Str(Val(PPesoBruto.Trim)))
        PrintLine(1, "     TARA: " & Str(Val(PPesoTara.Trim)))
        PrintLine(1, "  P. NETO: " & Str(Val(PPesoNeto.Trim)))
        PrintLine(1)
        PrintLine(1, "CAUSA SCRAP: " & PCausa.Trim)
        PrintLine(1, "             " & PDesccausa.Trim)
        'PrintLine(1, "  % SOBREPESO: " & Str(Val(PSobrePeso.Trim)))
        'PrintLine(1, " PESO TEORICO: " & Str(Val(PPesoTeorico.Trim)))
        'PrintLine(1)
        PrintLine(1)
        PrintLine(1, xORIGINAL)
        PrintLine(1)
        PrintLine(1, "P.TRABAJO: " & PPtoTrabajo.Trim)
        PrintLine(1, " OPERADOR: " & PCodOperador.Trim & "    " & PNomOperador.Trim)
        FileClose(1)
        Shell(GETIQUETAS.Trim & "\printcode.bat", AppWinStyle.Hide, True)
    End Sub
    Sub imprimir_PackID()

        '*******************************
        '   TICKET(AMANCO PERU)
        '*******************************

        FileOpen(1, GETIQUETAS.Trim & "\barcode.TXT", OpenMode.Output)   ' Open file for output.
        PrintLine(1)
        PrintLine(1, GEMPRESA.Trim)
        PrintLine(1, "PRODUCCION CONTROL DE PESAJE")
        PrintLine(1)
        PrintLine(1, "   FOLIO: " & DGPPT(DGPPT.CurrentCell.RowNumber, 23))
        PrintLine(1, "F.PESAJE: " & DGPPT(DGPPT.CurrentCell.RowNumber, 19))
        PrintLine(1, "H.PESAJE: " & Mid(DGPPT(DGPPT.CurrentCell.RowNumber, 20), 1, 8))
        PrintLine(1)
        PrintLine(1, "TURNO: " & DGPPT(DGPPT.CurrentCell.RowNumber, 2) & "   F.TURNO: " & DGPPT(DGPPT.CurrentCell.RowNumber, 21))
        PrintLine(1)
        PrintLine(1, "  * * *  " & DGPPT(DGPPT.CurrentCell.RowNumber, 5))
        PrintLine(1)
        PrintLine(1, " TIPO PROD.:    INYECCION ")
        PrintLine(1)
        PrintLine(1, "   O.D.F.: " & DGPPT(DGPPT.CurrentCell.RowNumber, 0))
        PrintLine(1, " MATERIAL: " & DGPPT(DGPPT.CurrentCell.RowNumber, 3))
        PrintLine(1, " " & DGPPT(DGPPT.CurrentCell.RowNumber, 4))
        PrintLine(1)

        If DGPPT(DGPPT.CurrentCell.RowNumber, 5) = "PRODUCCION" Then
            PrintLine(1, " UNIDADES: " & DGPPT(DGPPT.CurrentCell.RowNumber, 6))
        End If
        If DGPPT(DGPPT.CurrentCell.RowNumber, 5) = "SCRAP" Then
            PrintLine(1, "U.RECHAZO: " & DGPPT(DGPPT.CurrentCell.RowNumber, 8))
        End If
        If DGPPT(DGPPT.CurrentCell.RowNumber, 5) = "SPRUT" Then
            PrintLine(1, "U.RECHAZO: " & DGPPT(DGPPT.CurrentCell.RowNumber, 8))
        End If
        If DGPPT(DGPPT.CurrentCell.RowNumber, 5) = "PURGA" Then
            PrintLine(1, "U.RECHAZO: " & DGPPT(DGPPT.CurrentCell.RowNumber, 8))
        End If

        PrintLine(1, " P. BRUTO: " & DGPPT(DGPPT.CurrentCell.RowNumber, 15))
        PrintLine(1, "     TARA: " & DGPPT(DGPPT.CurrentCell.RowNumber, 16))

        If DGPPT(DGPPT.CurrentCell.RowNumber, 5) = "PRODUCCION" Then
            PrintLine(1, "  P. NETO: " & DGPPT(DGPPT.CurrentCell.RowNumber, 7))
        End If
        If DGPPT(DGPPT.CurrentCell.RowNumber, 5) = "SCRAP" Then
            PrintLine(1, "  P. NETO: " & DGPPT(DGPPT.CurrentCell.RowNumber, 9))
        End If
        If DGPPT(DGPPT.CurrentCell.RowNumber, 5) = "SPRUT" Then
            PrintLine(1, "  P. NETO: " & DGPPT(DGPPT.CurrentCell.RowNumber, 10))
        End If
        If DGPPT(DGPPT.CurrentCell.RowNumber, 5) = "PURGA" Then
            PrintLine(1, "  P. NETO: " & DGPPT(DGPPT.CurrentCell.RowNumber, 11))
        End If

        PrintLine(1)
        PrintLine(1, "P.TRABAJO: " & DGPPT(DGPPT.CurrentCell.RowNumber, 1))
        PrintLine(1, " OPERADOR: " & DGPPT(DGPPT.CurrentCell.RowNumber, 17))
        FileClose(1)   ' Close file.
        Shell(GETIQUETAS.Trim & "\printcode.bat", AppWinStyle.Hide, True)

        '*******************************
        '   TICKET(PLASTIGAMA)
        '*******************************

        'FileOpen(1, GETIQUETAS.Trim & "\barcode.TXT", OpenMode.Output)   ' Open file for output.
        'Print(1, "^XA")
        'Print(1, "^FO20,25^ADN,10,10,^FD" & Mid(DGPPT(DGPPT.CurrentCell.RowNumber, 4), 1, 30) & "^FS")
        'Print(1, "^FO420,25^ADN,10,10,^FD" & Mid(DGPPT(DGPPT.CurrentCell.RowNumber, 4), 1, 30) & "^FS")
        'Print(1, "^FO20,43^ADN,5,5,^FDUnid: " & DGPPT(DGPPT.CurrentCell.RowNumber, 6) & "    Peso: " & DGPPT(DGPPT.CurrentCell.RowNumber, 7) & "^FS")
        'Print(1, "^FO420,43^ADN,5,5,^FDUnid: " & DGPPT(DGPPT.CurrentCell.RowNumber, 6) & "    Peso: " & DGPPT(DGPPT.CurrentCell.RowNumber, 7) & "^FS")
        'Print(1, "^FO60,60^B3N,N,100,Y,N^FDA" & DGPPT(DGPPT.CurrentCell.RowNumber, 17) & "^FS")
        'Print(1, "^FO460,60^B3N,N,100,Y,N^FDA" & DGPPT(DGPPT.CurrentCell.RowNumber, 17) & "^FS")
        'Print(1, "^ISR:PACKID.GRF^FS")
        'Print(1, "^XZ")
        'FileClose(1)   ' Close file.
        'Shell(GETIQUETAS.Trim & "\printcode.bat", AppWinStyle.Hide, True)

        'FileOpen(1, GETIQUETAS.Trim & "\barcode.TXT", OpenMode.Output)   ' Open file for output.
        'Print(1, "^XA")
        'Print(1, "^FO20,25^ADN,10,10,^FD" & Mid(DGPPT(DGPPT.CurrentCell.RowNumber, 4), 1, 30) & "^FS")
        'Print(1, "^FO420,25^ADN,10,10,^FD" & Mid(DGPPT(DGPPT.CurrentCell.RowNumber, 4), 1, 30) & "^FS")
        'Print(1, "^FO20,43^ADN,5,5,^FDUnid: " & DGPPT(DGPPT.CurrentCell.RowNumber, 6) & "    Peso: " & DGPPT(DGPPT.CurrentCell.RowNumber, 7) & "^FS")
        'Print(1, "^FO420,43^ADN,5,5,^FDUnid: " & DGPPT(DGPPT.CurrentCell.RowNumber, 6) & "    Peso: " & DGPPT(DGPPT.CurrentCell.RowNumber, 7) & "^FS")
        'Print(1, "^FO60,60^B3N,N,100,Y,N^FDA" & DGPPT(DGPPT.CurrentCell.RowNumber, 15) & "^FS")
        'Print(1, "^FO460,60^B3N,N,100,Y,N^FDA" & DGPPT(DGPPT.CurrentCell.RowNumber, 15) & "^FS")
        'Print(1, "^ISR:PACKID.GRF^FS")
        'Print(1, "^XZ")
        'FileClose(1)   ' Close file.
        'Shell(GETIQUETAS.Trim & "\printcode.bat", AppWinStyle.Hide, True)

    End Sub
    Private Sub FrmAdminPPTIny_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim mfor As Integer
        Dim Q As String = ""
        Dim dsCombo As DataSet

        EXTINY = "2"
        tablaEXTINY = "productoterminadoinyeccion"
        ' ---------------------------------------------------------------------------------
        Q = "SELECT RTRIM(Descripcion)  FROM dbo.ADM_Turno"
        Q = Q & " WHERE planta= '" & SessionUser._sCentro.Trim & "'"
        Q = Q & " GROUP BY Descripcion"
        Try
            AbrirConfiguracion()
            objDa = New SqlDataAdapter(Q, objCnn)
            dsCombo = New DataSet
            objDa.Fill(dsCombo)
            cmbTurnos.Items.Add("")
            '          objDa.Fill(dsCombo)
            With dsCombo.Tables(0)
                For mfor = 0 To .Rows.Count - 1
                    cmbTurnos.Items.Add(.Rows(mfor).Item(0).ToString.Trim)
                Next
            End With
            ' ---------------------------------------------------------------------------------
            Dim dateRegistro As Date
            Dim FechaPesaje As String
            Dim HoraPesaje As String
            Dim Turno As String
            Dim dregistro As String = "0"
            dateRegistro = Today()
            FechaPesaje = Date.Today.ToString("yyyy-MM-dd")
            HoraPesaje = Date.Now.TimeOfDay.ToString
            ' ---------------------------------------------------------------------------------
            QRY_AMD = ""
            QRY_AMD = " Select TT.Turno, TT.Descripcion, Convert(char(8),TT.Hora_Inicio,108) as Hora_Inicio, "
            QRY_AMD = QRY_AMD & " Convert(char(8),TT.Hora_Terminacion,108) as Hora_Terminacion, TT.registro "
            QRY_AMD = QRY_AMD & " FROM ADM_Turno TT INNER JOIN ADM_CambioHora CH ON TT.Planta=CH.Planta "
            QRY_AMD = QRY_AMD & " AND Convert(char(10), getdate(),102)between Convert(char(10), CH.Fecha_Inicio,102) AND Convert(char(10),CH.fecha_Terminacion,102) "
            QRY_AMD = QRY_AMD & " WHERE Convert(char(8), getdate()+(CH.CHora/24),108) between Convert(char(8), Hora_Inicio,108) "
            QRY_AMD = QRY_AMD & " AND Convert(char(8),Hora_Terminacion,108) and TT.Planta='" & SessionUser._sCentro.Trim & "' "
            LecturaQry_AMD(QRY_AMD)
            Turno = "1"
            If LecturaBD_AMD.Read() Then
                Turno = LecturaBD_AMD(0)
                dateRegistro = DateAdd(DateInterval.Day, -Val(LecturaBD_AMD(4)), dateRegistro)
            End If
            DTP1.Value = dateRegistro.Date
            DTP2.Value = DTP1.Value
            LecturaBD_AMD.Close()
            ' ---------------------------------------------------------------------------------
        Catch ex As Exception
            MessageBox.Show("Error llenar combo :" & ex.Message, "  VENTANA DE ERROR * * * ")
        End Try
    End Sub

    Private Sub DGPPT_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DGPPT.MouseDoubleClick
        Try
            If DGPPT.CurrentRowIndex > -1 Then
                TxtOrdProdSel.Text = DGPPT.Item(DGPPT.CurrentCell.RowNumber, 0).ToString.Trim
                Calcula_Cantidades()
                llena_novedades()
            End If
        Catch ex1 As Exception
            MsgBox(ex1.Message)
            Exit Sub
        End Try

    End Sub
    Private Sub Calcula_Cantidades()
        '   Dim RegistrosActualizados As Integer
        Dim regupdate As Integer
        Dim Qfup As String
        Dim xTCantProgra As Decimal = 0
        Dim xTCantEntre As Decimal = 0
        Dim xTCantEnproce As Decimal = 0
        Dim xTCantpendi As Decimal = 0
        Dim xFechaUltpesaje As String
        ' ---------------------------------------------------------------------------------
        'grpCantidades.Visible = True
        Qfup = " SELECT  PTYS.Orden_Produccion, OP.Cantidad_Programada_Tramos, SUM(PTYS.PRODUCCION), SUM(PTYS.SEPARADA), (OP.Cantidad_Programada_Tramos-(SUM(PTYS.PRODUCCION)+SUM(PTYS.SEPARADA))) "
        Qfup = Qfup & " FROM (((sELECT planta, Orden_Produccion, PuestoTrabajo, 'PRODUCCION' as tipoprod, Notifica, notificacionmasiva, tramos as PRODUCCION, 0 as SEPARADA "
        Qfup = Qfup & "  FROM " & SessionUser._sCentro.Trim & "_PesoProductoTerminado WHERE tramos<>0 AND notifica in ('0','1','4')) "
        Qfup = Qfup & " UNION ALL (sELECT planta, Orden_Produccion, PuestoTrabajo, 'EN PROCESO' as tipoprod, Notifica, notificacionmasiva, 0 as PRODUCCION, tramos as SEPARADA "
        Qfup = Qfup & " FROM " & SessionUser._sCentro.Trim & "_PesoProductoTerminado WHERE tramos<>0 AND notifica in ('3'))) PTYS "
        Qfup = Qfup & " INNER JOIN " & SessionUser._sCentro.Trim & "_OrdenProduccion OP ON PTYS.Orden_Produccion = OP.Orden_Produccion) "
        Qfup = Qfup & "	INNER JOIN MCPC_EquipoBasico EB ON PTYS.planta = EB.Planta AND PTYS.PuestoTrabajo = EB.Equipo_basico AND EB.Tpo_equipo_basico= '" & EXTINY & "' "
        Qfup = Qfup & " INNER JOIN " & tablaEXTINY & " PTE ON  PTE.CENTRO= PTYS.PLANTA and PTE.Codigo = OP.Producto "
        Qfup = Qfup & " WHERE PTYS.planta= '" & SessionUser._sCentro.Trim & "'"
        Qfup = Qfup & " AND PTYS.notifica <> '9' "
        Qfup = Qfup & " AND PTYS.Orden_Produccion = '" & TxtOrdProdSel.Text.Trim & "'"
        Qfup = Qfup & " GROUP BY PTYS.Orden_Produccion, OP.Cantidad_Programada_Tramos "
        xFechaUltpesaje = ""
        Try
            LecturaQry(Qfup)
            regupdate = 0
            If (LecturaBD.Read) Then
                xTCantProgra = Val("0" & LecturaBD(1))
                xTCantEntre = Val("0" & LecturaBD(2))
                xTCantEnproce = Val("0" & LecturaBD(3))
                xTCantpendi = Val("0" & LecturaBD(4))
            End If
            TCantProgra.Text = Format(xTCantProgra, xFormato)
            TCantEntre.Text = Format(xTCantEntre, xFormato)
            TCantEnproce.Text = Format(xTCantEnproce, xFormato)
            TCantpendi.Text = Format(xTCantpendi, xFormato)
            LecturaBD.Close()
            ' ---------------------------------------------------------------------------------
        Catch ex1 As Exception
            MsgBox(ex1.Message)
            Exit Sub
        End Try
    End Sub
    Private Sub llena_novedades()
        Dim Q As String = ""
        Dim Qt As String = ""
        Dim Qm As String = ""
        Dim xDias As String = ""
        Dim xGrupos As String = ""

        '   Dim RegistrosActualizados As Integer
        Dim regupdate As Integer
        Dim Qfup As String
        Dim xTTrabajadas As Decimal = 0
        Dim xTProg As Decimal = 0
        Dim xTMant As Decimal = 0
        Dim xTSetu As Decimal = 0
        Dim xTOtro As Decimal = 0


        Dim xFechaUltpesaje As String

        Qfup = ""
        Qfup = Qfup & "  SELECT sum(HPTOTAL.HREPORTADAS), sum(HPTOTAL.POR_PROGRAMA), sum(HPTOTAL.MANTENIMIENTO), sum(HPTOTAL.POR_SETUP), sum(HPTOTAL.OTROS) "
        Qfup = Qfup & " FROM ((SELECT THP.Centro, THP.ordenProd, THP.fecha, THP.turno, THP.PuestoTrabajo, THP.CodCausa, horasparo as HREPORTADAS, 0 as POR_PROGRAMA, 0 as MANTENIMIENTO, 0 as POR_SETUP, 0 as OTROS"
        Qfup = Qfup & " FROM ((" & SessionUser._sCentro.Trim & "_HorasParo THP INNER JOIN " & SessionUser._sCentro.Trim & "_OrdenProduccion OP ON THP.Centro = OP.planta AND THP.ordenProd = OP.Orden_Produccion )"
        Qfup = Qfup & " INNER JOIN MCPC_EquipoBasico EB ON THP.centro = EB.Planta AND THP.PuestoTrabajo = EB.Equipo_basico AND EB.Tpo_equipo_basico='" & EXTINY & "' "
        Qfup = Qfup & " INNER JOIN " & tablaEXTINY & " PTE ON PTE.CENTRO= THP.centro and PTE.Codigo = OP.Producto )"
        Qfup = Qfup & " INNER JOIN CatCausas CC  ON CC.Centro=THP.Centro AND CC.grpprod=PTE.grpprod AND CC.CodCausa=THP.CodCausa   "
        Qfup = Qfup & " INNER JOIN CatAgrupaciones CA ON CC.centro= CA.centro AND CC.codcausagrupa = CA.codcausagrupa  AND CA.status = 'A' "
        Qfup = Qfup & " where THP.CodCausa='0000' and THP.status<>'9')"
        Qfup = Qfup & " UNION ALL (SELECT THP.Centro, THP.ordenProd, THP.fecha, THP.turno, THP.PuestoTrabajo, THP.CodCausa, 0 as HREPORTADAS, horasparo as POR_PROGRAMA, 0 as MANTENIMIENTO, 0 as POR_SETUP, 0 as OTROS"
        Qfup = Qfup & " FROM ((" & SessionUser._sCentro.Trim & "_HorasParo THP INNER JOIN " & SessionUser._sCentro.Trim & "_OrdenProduccion OP ON THP.Centro = OP.planta AND THP.ordenProd = OP.Orden_Produccion )"
        Qfup = Qfup & " INNER JOIN MCPC_EquipoBasico EB ON THP.centro = EB.Planta AND THP.PuestoTrabajo = EB.Equipo_basico AND EB.Tpo_equipo_basico='" & EXTINY & "' "
        Qfup = Qfup & " INNER JOIN " & tablaEXTINY & " PTE ON PTE.CENTRO= THP.centro and PTE.Codigo = OP.Producto )"
        Qfup = Qfup & " INNER JOIN CatCausas CC  ON CC.Centro=THP.Centro AND CC.grpprod=PTE.grpprod AND CC.CodCausa=THP.CodCausa   "
        Qfup = Qfup & " INNER JOIN CatAgrupaciones CA ON CC.centro= CA.centro AND CC.codcausagrupa = CA.codcausagrupa  AND CA.status = 'A' AND CA.codgrpgeneral= '1'"
        Qfup = Qfup & " where THP.CodCausa<>'0000' and THP.status<>'9')      "

        Qfup = Qfup & " UNION ALL (SELECT THP.Centro, THP.ordenProd, THP.fecha, THP.turno, THP.PuestoTrabajo, THP.CodCausa, 0 as HREPORTADAS, 0 as POR_PROGRAMA, horasparo as MANTENIMIENTO, 0 as POR_SETUP, 0 as OTROS"
        Qfup = Qfup & " FROM ((" & SessionUser._sCentro.Trim & "_HorasParo THP INNER JOIN " & SessionUser._sCentro.Trim & "_OrdenProduccion OP ON THP.Centro = OP.planta AND THP.ordenProd = OP.Orden_Produccion )"
        Qfup = Qfup & " 	INNER JOIN MCPC_EquipoBasico EB ON THP.centro = EB.Planta AND THP.PuestoTrabajo = EB.Equipo_basico AND EB.Tpo_equipo_basico='" & EXTINY & "' "
        Qfup = Qfup & " 	INNER JOIN " & tablaEXTINY & " PTE ON PTE.CENTRO= THP.centro and PTE.Codigo = OP.Producto )"
        Qfup = Qfup & " 	INNER JOIN CatCausas CC  ON CC.Centro=THP.Centro AND CC.grpprod=PTE.grpprod AND CC.CodCausa=THP.CodCausa   "
        Qfup = Qfup & " 	INNER JOIN CatAgrupaciones CA ON CC.centro= CA.centro AND CC.codcausagrupa = CA.codcausagrupa  AND CA.status = 'A' AND CA.codgrpgeneral= '2'"
        Qfup = Qfup & " where THP.CodCausa<>'0000' and THP.status<>'9')"
        Qfup = Qfup & " UNION ALL (SELECT THP.Centro, THP.ordenProd, THP.fecha, THP.turno, THP.PuestoTrabajo, THP.CodCausa, 0 as HREPORTADAS, 0 as POR_PROGRAMA, 0 as MANTENIMIENTO, horasparo as POR_SETUP, 0 as OTROS"
        Qfup = Qfup & " FROM ((" & SessionUser._sCentro.Trim & "_HorasParo THP INNER JOIN " & SessionUser._sCentro.Trim & "_OrdenProduccion OP ON THP.Centro = OP.planta AND THP.ordenProd = OP.Orden_Produccion )"
        Qfup = Qfup & " 	INNER JOIN MCPC_EquipoBasico EB ON THP.centro = EB.Planta AND THP.PuestoTrabajo = EB.Equipo_basico AND EB.Tpo_equipo_basico='" & EXTINY & "' "
        Qfup = Qfup & " 	INNER JOIN " & tablaEXTINY & " PTE ON PTE.CENTRO= THP.centro and PTE.Codigo = OP.Producto )"
        Qfup = Qfup & " 	INNER JOIN CatCausas CC  ON CC.Centro=THP.Centro AND CC.grpprod=PTE.grpprod AND CC.CodCausa=THP.CodCausa   "
        Qfup = Qfup & " 	INNER JOIN CatAgrupaciones CA ON CC.centro= CA.centro AND CC.codcausagrupa = CA.codcausagrupa  AND CA.status = 'A' AND CA.codgrpgeneral= '3'"
        Qfup = Qfup & " where THP.CodCausa<>'0000' and THP.status<>'9')"

        Qfup = Qfup & " UNION ALL (SELECT THP.Centro, THP.ordenProd, THP.fecha, THP.turno, THP.PuestoTrabajo, THP.CodCausa, 0 as HREPORTADAS, 0 as POR_PROGRAMA, 0 as MANTENIMIENTO, 0 as POR_SETUP,horasparo as OTROS"
        Qfup = Qfup & " FROM ((" & SessionUser._sCentro.Trim & "_HorasParo THP INNER JOIN " & SessionUser._sCentro.Trim & "_OrdenProduccion OP ON THP.Centro = OP.planta AND THP.ordenProd = OP.Orden_Produccion )"
        Qfup = Qfup & " 	INNER JOIN MCPC_EquipoBasico EB ON THP.centro = EB.Planta AND THP.PuestoTrabajo = EB.Equipo_basico AND EB.Tpo_equipo_basico='" & EXTINY & "' "
        Qfup = Qfup & " 	INNER JOIN " & tablaEXTINY & " PTE ON PTE.CENTRO= THP.centro and PTE.Codigo = OP.Producto )"
        Qfup = Qfup & " 	INNER JOIN CatCausas CC  ON CC.Centro=THP.Centro AND CC.grpprod=PTE.grpprod AND CC.CodCausa=THP.CodCausa   "
        Qfup = Qfup & " 	INNER JOIN CatAgrupaciones CA ON CC.centro= CA.centro AND CC.codcausagrupa = CA.codcausagrupa  AND CA.status = 'A' AND CA.codgrpgeneral= '9'"
        Qfup = Qfup & " where THP.CodCausa<>'0000' and THP.status<>'9')"
        Qfup = Qfup & " ) HPTOTAL WHERE HPTOTAL.centro='" & SessionUser._sCentro.Trim & "' AND HPTOTAL.ordenProd='" & TxtOrdProdSel.Text.Trim & "'"

        xFechaUltpesaje = ""
        Try
            LecturaQry(Qfup)
            regupdate = 0
            If (LecturaBD.Read) Then
                xTTrabajadas = Val("0" & LecturaBD(0))
                xTProg = Val("0" & LecturaBD(1))
                xTMant = Val("0" & LecturaBD(2))
                xTSetu = Val("0" & LecturaBD(3))
                xTOtro = Val("0" & LecturaBD(4))
            End If
            TTrabajadas.Text = Format(xTTrabajadas, xFormato)
            TProg.Text = Format(xTProg, xFormato)
            TMant.Text = Format(xTMant, xFormato)
            TSetu.Text = Format(xTSetu, xFormato)
            TOtro.Text = Format(xTOtro, xFormato)
            LecturaBD.Close()
            ' ---------------------------------------------------------------------------------
        Catch ex1 As Exception
            MsgBox(ex1.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub tsbExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbExportar.Click

        Dim strTempQuery As String = ""
        Dim xLinea As String = ""
        Dim i As Integer = 0
        Dim FExport As String
        Dim Hexport As String

        If Qdg = "" Then
            Mensajes("No hay registros seleccionados.", 1)
            Exit Sub
        End If

        strTempQuery = Qdg
        LecturaQry(strTempQuery)

        If (LecturaBD.HasRows) Then

            FileOpen(1, GEXPORTACIONES.Trim & "\ExpInyeccion.txt", OpenMode.Output)

            Do While (LecturaBD.Read())
                xLinea = ""
                For i = 0 To LecturaBD.FieldCount - 1
                    xLinea = xLinea & LecturaBD(i).ToString.Trim & "	"
                Next
                PrintLine(1, xLinea)
            Loop
            FileClose(1)

            Dim strFileName As String = GEXPORTACIONES.Trim & "\ExpInyeccion"
            Dim strFileName1 As String = ""
            Dim blnFileOpen As Boolean = False


            FExport = Date.Today.ToString("yyyy-MM-dd")
            Hexport = Date.Now.TimeOfDay.ToString
            Hexport = Mid(Hexport, 1, 2) & Mid(Hexport, 4, 2) & Mid(Hexport, 7, 2)
            strFileName1 = strFileName & FExport & Hexport & ".txt"
            strFileName = strFileName & ".txt"

            FileCopy(strFileName, strFileName1)


        End If
        Mensajes("Proceso terminado...", 0)
        LecturaBD.Close()


        'Dim objExcel As New Microsoft.Office.Interop.Excel.ApplicationClass
        'Dim wBook As Microsoft.Office.Interop.Excel.Workbook
        'Dim wks As Microsoft.Office.Interop.Excel.Worksheet
        'Dim strTempQuery As String
        'Dim FExport As String
        'Dim Hexport As String
        'Dim i As Integer
        'Dim j As Integer = 1
        'strTempQuery = ""
        'If Qdg = "" Then
        '    Mensajes("No hay registros seleccionados.", 1)
        '    Exit Sub
        'End If
        'strTempQuery = Qdg
        'LecturaQry(strTempQuery)

        'With objExcel
        '    .DisplayAlerts = False
        '    .Visible = False
        '    wBook = .Workbooks.Add()
        '    wks = .ActiveSheet
        '    Do While (LecturaBD.Read())
        '        For i = 1 To LecturaBD.FieldCount - 1
        '            .Cells(j, i) = LecturaBD(i)
        '        Next
        '        j = j + 1
        '    Loop
        '    wks.Columns.AutoFit()
        '    Dim strFileName As String = GEXPORTACIONES.Trim & "\CodeExport"
        '    Dim strFileName1 As String = ""
        '    Dim strFileName2 As String = "Back.xls"
        '    Dim blnFileOpen As Boolean = False

        '    FExport = Date.Today.ToString("yyyy-MM-dd")
        '    Hexport = Date.Now.TimeOfDay.ToString
        '    Hexport = Mid(Hexport, 1, 2) & Mid(Hexport, 4, 2) & Mid(Hexport, 7, 2)
        '    strFileName1 = strFileName & FExport & Hexport & ".xls"
        '    strFileName = strFileName & ".xls"
        '    strFileName2 = "Back.xls"
        '    Try
        '        Dim fileTemp As System.IO.FileStream = System.IO.File.OpenWrite(strFileName)
        '        fileTemp.Close()
        '    Catch ex As Exception
        '        blnFileOpen = False
        '    End Try
        '    If System.IO.File.Exists(strFileName) Then
        '        System.IO.File.Copy(strFileName, strFileName1)
        '        System.IO.File.Delete(strFileName)
        '    End If

        '    wBook.SaveAs(strFileName1)
        '    .Workbooks.Open(strFileName1)
        '    If System.IO.File.Exists(strFileName) Then
        '        System.IO.File.Delete(strFileName)
        '    End If
        '    .Visible = True
        'End With
        'Mensajes("Proceso terminado...", 0)
        'LecturaBD.Close()
    End Sub

    Private Sub tsbCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbCerrar.Click
        Close()
    End Sub

    Private Sub tsbConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbConsultar.Click
        Dim myDataReader As Data.SqlClient.SqlDataReader
        Dim myDataReaderH As Data.SqlClient.SqlDataReader

        Dim StrFecIni As String
        Dim StrFecFin As String
        Dim StrOrdProd As String
        Dim xTurno As String

        Dim xTOTKILOSPROD As Decimal
        Dim xTOTUNPROD As Decimal
        Dim xTOTKILOSPROCESO As Decimal
        Dim xTOTUNPROCESO As Decimal

        Dim xTOTKILOSSCRAP As Decimal
        Dim xTOTUNSCRAP As Decimal
        Dim xPORCSCRAP As Decimal
        Dim xTOTKILOSSPRUT As Decimal
        Dim xPORCSPRUT As Decimal
        Dim xTOTKILOSPURGA As Decimal

        Dim xTotHorastrab As Decimal = 0
        Dim xTotHorasprog As Decimal = 0
        Dim xTotHorasmant As Decimal = 0
        Dim xTotHorassetu As Decimal = 0
        Dim xTotHorasotro As Decimal = 0
        Dim xTotHorasvari As Decimal = 0

        Dim Qd As String = ""
        Dim Qtp As String = ""
        Dim Qts As String = ""
        Dim Qfup As String = ""
        Dim Qs As String = ""
        Dim Qt As String = ""
        Dim OPselec As String = ""

        StrOrdProd = TxtOrdProd.Text.Trim
        StrFecIni = DTP1.Text.Trim
        StrFecFin = DTP2.Text.Trim
        xTurno = cmbTurnos.Text.Trim

        xTOTKILOSPROD = 0
        xTOTUNPROD = 0
        xTOTKILOSPROCESO = 0
        xTOTUNPROCESO = 0
        xTOTKILOSSCRAP = 0
        xTOTUNSCRAP = 0
        xPORCSCRAP = 0
        xTOTKILOSSPRUT = 0
        xPORCSPRUT = 0
        xTOTKILOSPURGA = 0

        AbrirAmanco(SessionUser._sAmbiente.Trim)

        Qd = " SELECT PTYS.Orden_Produccion ORDEN, PTYS.PuestoTrabajo EQUIPO, PTYS.Turno TURNO, "
        Qd = Qd & " PTE.Codigo CODIGO, PTE.Descr MATERIAL, PTYS.tipoprod TIPO, PTYS.Tramos U_PRODUCCION, PTYS.PRODUCCION K_PRODUCCION, PTYS.sTramos U_SEPARADAS, PTYS.SEPARADA K_SEPARADA, PTYS.xTramos U_RECHAZO, PTYS.SCRAP K_SCRAP, PTYS.SPRUT K_SPRUT, PTYS.PURGA K_PURGA, "
        Qd = Qd & " CONVERT(DECIMAL(18,2),ROUND(((CASE PTYS.SCRAP WHEN 0 THEN 0 ELSE (PTYS.SCRAP/PTYS.SCRAP) END)*100),2))Porc_SCRAP, "
        Qd = Qd & " (PTYS.PRODUCCION + PTYS.SCRAP) TOTAL, (PTYS.Tramos * PTE.PesoTeorico) PESO_TEORICO, "
        Qd = Qd & " PTYS.Peso_Bruto PESO_BRUTO, PTYS.Tara TARA, PTYS.Usuario USUARIO, PTYS.PackID, PTYS.Fecha_Pesaje FECHA, PTYS.Hora_Pesaje HORA, "
        Qd = Qd & " PTYS.Fecha_turno, PTYS.Empaques, PTYS.Folio, PTYS.Documento_SAP, PTYS.Consecutivo_SAP, PTYS.Notifica FINAL, "
        Qd = Qd & " PTYS.Planta CENTRO, PTYS.Bascula BASCULA, PTYS.notificacionmasiva NOT_MASIVA, PTYS.Compuesto1, PTYS.Porcentaje1, PTYS.Compuesto2, PTYS.Porcentaje2, PTYS.LTCompuestos  "

        Qd = Qd & " FROM (((sELECT Orden_Produccion,  Fecha_Pesaje, Hora_Pesaje, Turno,  "
        Qd = Qd & " 'PRODUCCION' as tipoprod, Notifica, notificacionmasiva, Tramos as Tramos, Peso_Neto as PRODUCCION, 0 as sTramos, 0 as SEPARADA, 0 as xTramos, 0 as SCRAP, 0 as SPRUT, 0 as PURGA, Peso_Bruto, Tara, Empaques, Folio, Documento_SAP, "
        Qd = Qd & " Consecutivo_SAP, Planta, Bascula, Usuario, PackID, Fecha_turno, Compuesto1, Porcentaje1, Compuesto2, Porcentaje2, LTCompuestos, PuestoTrabajo FROM " & SessionUser._sCentro.Trim & "_PesoProductoTerminado WHERE tramos <> 0 AND Tipo_PT in ('T','R') and notifica in ('0','1','4')) "

        Qd = Qd & " UNION ALL (SELECT Orden_Produccion,  Fecha_Pesaje, Hora_Pesaje, Turno,  "
        Qd = Qd & " 'EN PROCESO' as tipoprod, Notifica, notificacionmasiva, 0 as Tramos, 0 as PRODUCCION, Tramos as sTramos, Peso_Neto as SEPARADA, 0 as xTramos, 0 as SCRAP, 0 as SPRUT, 0 as PURGA, Peso_Bruto, Tara, Empaques, Folio, Documento_SAP, "
        Qd = Qd & " Consecutivo_SAP, Planta, Bascula, Usuario, PackID, Fecha_turno, Compuesto1, Porcentaje1, Compuesto2, Porcentaje2, LTCompuestos, PuestoTrabajo FROM " & SessionUser._sCentro.Trim & "_PesoProductoTerminado WHERE tramos <> 0 AND Tipo_PT in ('P') and notifica = '3' ) "

        Qd = Qd & " UNION ALL (SELECT Orden_Produccion,  Fecha_Pesaje, Hora_Pesaje, Turno,  "
        Qd = Qd & " 'SOBREPESO' as tipoprod, Notifica, notificacionmasiva, 0 as Tramos, 0 as PRODUCCION, Tramos  as sTramos, Peso_Neto as SEPARADA, 0 as xTramos, 0 as SCRAP, 0 as SPRUT, 0 as PURGA, Peso_Bruto, Tara, Empaques, Folio, Documento_SAP, "
        Qd = Qd & " Consecutivo_SAP, Planta, Bascula, Usuario, PackID, Fecha_turno, Compuesto1, Porcentaje1, Compuesto2, Porcentaje2, LTCompuestos, PuestoTrabajo FROM " & SessionUser._sCentro.Trim & "_PesoProductoTerminado WHERE tramos <> 0 AND Tipo_PT in ('S') and notifica = '2' ) "

        Qd = Qd & " UNION ALL (SELECT Orden_Produccion, Fecha_Pesaje, Hora_Pesaje, Turno,  "
        Qd = Qd & " 'SCRAP' as tipoprod, Notifica, notificacionmasiva, 0 as Tramos, 0 as PRODUCCION, 0 as sTramos, 0 as SEPARADA, Tramos as xTramos, Peso_Neto as SCRAP, 0 as SPRUT, 0 as PURGA, Peso_Bruto, Tara, 0, Folio, Documento_SAP, "
        Qd = Qd & " Consecutivo_SAP, Planta, Bascula, Usuario, '0', Fecha_turno, Compuesto1, Porcentaje1, Compuesto2, Porcentaje2, LTCompuestos, PuestoTrabajo FROM " & SessionUser._sCentro.Trim & "_PesoScrap WHERE Tipo_Scrap in ('T','R') AND notifica in ('0','1','4')) "
        Qd = Qd & " UNION ALL (SELECT Orden_Produccion, Fecha_Pesaje, Hora_Pesaje, Turno,  "
        Qd = Qd & " 'SPRUT' as tipoprod, Notifica, notificacionmasiva, 0 as Tramos, 0 as PRODUCCION, 0 as sTramos, 0 as SEPARADA, Tramos as xTramos, 0 as SCRAP, Peso_Neto as SPRUT, 0 as PURGA, Peso_Bruto, Tara, 0, Folio, Documento_SAP, "
        Qd = Qd & " Consecutivo_SAP, Planta, Bascula, Usuario, '0', Fecha_turno, Compuesto1, Porcentaje1, Compuesto2, Porcentaje2, LTCompuestos, PuestoTrabajo FROM " & SessionUser._sCentro.Trim & "_PesoScrap WHERE tramos = 0 AND Tipo_Scrap in ('P') AND notifica in ('0','1','4')) "
        Qd = Qd & " UNION ALL (SELECT Orden_Produccion, Fecha_Pesaje, Hora_Pesaje, Turno,  "
        Qd = Qd & " 'PURGA' as tipoprod, Notifica, notificacionmasiva, 0 as Tramos, 0 as PRODUCCION, 0 as sTramos, 0 as SEPARADA, Tramos as xTramos, 0 as SCRAP, 0 as SPRUT, Peso_Neto as PURGA, Peso_Bruto, Tara, 0, Folio, Documento_SAP, "
        Qd = Qd & " Consecutivo_SAP, Planta, Bascula, Usuario, '0', Fecha_turno, Compuesto1, Porcentaje1, Compuesto2, Porcentaje2, LTCompuestos, PuestoTrabajo FROM " & SessionUser._sCentro.Trim & "_PesoScrap WHERE Tipo_Scrap IN ('G') AND notifica = '5')) PTYS "
        Qd = Qd & " INNER JOIN " & SessionUser._sCentro.Trim & "_OrdenProduccion OP ON OP.Planta= PTYS.PLANTA and  PTYS.Orden_Produccion = OP.Orden_Produccion) "
        Qd = Qd & "	INNER JOIN MCPC_EquipoBasico EB ON PTYS.planta = EB.Planta AND PTYS.PuestoTrabajo = EB.Equipo_basico AND EB.Tpo_equipo_basico='" & EXTINY & "' "
        Qd = Qd & " INNER JOIN " & tablaEXTINY & " PTE ON PTE.CENTRO= PTYS.PLANTA and  PTE.Codigo = OP.Producto "
        Qd = Qd & " WHERE PTYS.planta= '" & SessionUser._sCentro.Trim & "'"
        Qd = Qd & "  AND PTYS.notifica <> '9' "

        If Not xTurno = "" Then
            Qd = Qd & "   AND PTYS.turno = '" & cmbTurnos.Text.Trim & "'"
        End If

        Qt = " SELECT PTYS.PuestoTrabajo Equipo, "
        Qt = Qt & " PTE.Codigo Codigo, PTE.Descr Material, OP.Cantidad_Programada_Tramos U_Programadas, SUM(PTYS.TRAMOS) U_Produccion, SUM(PTYS.PRODUCCION) K_Produccion,  SUM(PTYS.sTramos) U_Separada, SUM(PTYS.SEPARADA) K_Separada,"
        Qt = Qt & " SUM(PTYS.xTramos) U_Rechazo, SUM(PTYS.SCRAP) K_Scrap, SUM(PTYS.SPRUT) K_Sprut, SUM(PTYS.PURGA) K_Purga, SUM(PTYS.TRAMOS * PTE.PesoTeorico) Peso_Teorico , "
        Qt = Qt & " CONVERT(DECIMAL(18,2),ROUND(((CASE SUM(PTYS.PRODUCCION) WHEN 0 THEN 1 ELSE (SUM(PTYS.SCRAP)/SUM(PTYS.PRODUCCION)) END)*100),2)) Porc_Scrap, "
        Qt = Qt & " CONVERT(DECIMAL(18,2),ROUND(((CASE SUM(PTYS.PRODUCCION) WHEN 0 THEN 1 ELSE (SUM(PTYS.SPRUT)/SUM(PTYS.PRODUCCION)) END)*100),2)) Porc_Sprut "
        Qt = Qt & " FROM (((sELECT Orden_Produccion,  Fecha_Pesaje, Hora_Pesaje,  Turno, "

        Qt = Qt & " 'PRODUCCION' as tipoprod, Notifica, tramos as Tramos, Peso_Neto as PRODUCCION, 0 as sTramos, 0 as SEPARADA, 0 as xTramos, 0 as SCRAP, 0 as SPRUT, 0 as PURGA, Peso_Bruto, Tara, Empaques, Documento_SAP, "
        Qt = Qt & " Consecutivo_SAP, Planta, Bascula, Usuario, PackID, Fecha_turno, PuestoTrabajo FROM " & SessionUser._sCentro.Trim & "_PesoProductoTerminado WHERE tramos <> 0 AND Tipo_PT in ('T','R') and notifica in ('0','1','4')) "
        Qt = Qt & " UNION ALL (SELECT Orden_Produccion,  Fecha_Pesaje, Hora_Pesaje,  Turno, "

        Qt = Qt & " 'EN PROCESO' as tipoprod, Notifica, 0 as Tramos, 0 as PRODUCCION, tramos as sTramos, Peso_Neto as SEPARADA, 0 as xTramos, 0 as SCRAP, 0 as SPRUT, 0 as PURGA, Peso_Bruto, Tara, Empaques, Documento_SAP, "
        Qt = Qt & " Consecutivo_SAP, Planta, Bascula, Usuario, PackID, Fecha_turno, PuestoTrabajo FROM " & SessionUser._sCentro.Trim & "_PesoProductoTerminado WHERE tramos <> 0 AND Tipo_PT in ('P') and notifica = '3' ) "
        Qt = Qt & " UNION ALL (SELECT Orden_Produccion,  Fecha_Pesaje, Hora_Pesaje,  Turno, "

        Qt = Qt & " 'SOBREPESO' as tipoprod, Notifica, 0 as Tramos, 0 as PRODUCCION, tramos as sTramos, Peso_Neto as SEPARADA, 0 as xTramos, 0 as SCRAP, 0 as SPRUT, 0 as PURGA, Peso_Bruto, Tara, Empaques, Documento_SAP, "
        Qt = Qt & " Consecutivo_SAP, Planta, Bascula, Usuario, PackID, Fecha_turno, PuestoTrabajo FROM " & SessionUser._sCentro.Trim & "_PesoProductoTerminado WHERE tramos <> 0 AND Tipo_PT in ('S') and notifica = '2' ) "
        Qt = Qt & " UNION ALL (SELECT Orden_Produccion, Fecha_Pesaje, Hora_Pesaje,  Turno, "

        Qt = Qt & " 'SCRAP' as tipoprod, Notifica, 0 as Tramos, 0 as PRODUCCION, 0 as sTramos, 0 as SEPARADA, Tramos as xTramos, Peso_Neto as SCRAP, 0 as SPRUT, 0 as PURGA, Peso_Bruto, Tara, 0, Documento_SAP, "
        Qt = Qt & " Consecutivo_SAP, Planta, Bascula, Usuario, '0', Fecha_turno, PuestoTrabajo FROM " & SessionUser._sCentro.Trim & "_PesoScrap WHERE Tipo_Scrap in ('T','R') AND notifica in ('0','1','4')) "
        Qt = Qt & " UNION ALL (SELECT Orden_Produccion, Fecha_Pesaje, Hora_Pesaje,  Turno, "

        Qt = Qt & " 'SPRUT' as tipoprod, Notifica, 0 as Tramos, 0 as PRODUCCION, 0 as sTramos, 0 as SEPARADA, 0 as xTramos, 0 as SCRAP, Peso_Neto as SPRUT, 0 as PURGA, Peso_Bruto, Tara, 0, Documento_SAP, "
        Qt = Qt & " Consecutivo_SAP, Planta, Bascula, Usuario, '0', Fecha_turno, PuestoTrabajo FROM " & SessionUser._sCentro.Trim & "_PesoScrap WHERE tramos = 0 AND Tipo_Scrap in ('P') AND notifica in ('0','1','4')) "
        Qt = Qt & " UNION ALL (SELECT Orden_Produccion, Fecha_Pesaje, Hora_Pesaje,  Turno, "

        Qt = Qt & " 'PURGA' as tipoprod, Notifica, 0 as Tramos, 0 as PRODUCCION, 0 as sTramos, 0 as SEPARADA, 0 as xTramos, 0 as SCRAP, 0 as SPRUT, Peso_Neto as PURGA, Peso_Bruto, Tara, 0, Documento_SAP, "
        Qt = Qt & " Consecutivo_SAP, Planta, Bascula, Usuario, '0', Fecha_turno, PuestoTrabajo FROM " & SessionUser._sCentro.Trim & "_PesoScrap WHERE Tipo_Scrap in ('G') AND notifica = '5')) PTYS "
        Qt = Qt & " INNER JOIN " & SessionUser._sCentro.Trim & "_OrdenProduccion OP ON OP.Planta= PTYS.PLANTA and  PTYS.Orden_Produccion = OP.Orden_Produccion) "
        Qt = Qt & "	INNER JOIN MCPC_EquipoBasico EB ON PTYS.planta = EB.Planta AND PTYS.PuestoTrabajo = EB.Equipo_basico AND EB.Tpo_equipo_basico='" & EXTINY & "' "
        Qt = Qt & " INNER JOIN " & tablaEXTINY & " PTE ON PTE.CENTRO= PTYS.PLANTA and  PTE.Codigo = OP.Producto "
        Qt = Qt & " WHERE PTYS.planta= '" & SessionUser._sCentro.Trim & "'"
        Qt = Qt & "  AND PTYS.notifica <> '9' "
        If Not xTurno = "" Then
            Qt = Qt & "   AND PTYS.turno = '" & cmbTurnos.Text.Trim & "'"
        End If

        Qs = " SELECT TCS.codseccion Codigo, TCS.Desseccion Seccion, SUM(PTYS.Tramos) U_Produccion, SUM(PTYS.PRODUCCION) AS K_Produccion, SUM(PTYS.sTramos) U_Separadas, SUM(PTYS.SEPARADA) AS K_Separados, "
        Qs = Qs & " SUM(PTYS.SCRAP) AS Scrap, CONVERT(DECIMAL(18,2),ROUND(((CASE SUM(PTYS.PRODUCCION) WHEN 0 THEN 1 ELSE (SUM(PTYS.SCRAP)/SUM(PTYS.PRODUCCION)) END)*100),2)) Porc_Scrap, "
        Qs = Qs & " SUM(PTYS.SPRUT) AS Sprut, CONVERT(DECIMAL(18,2),ROUND(((CASE SUM(PTYS.PRODUCCION) WHEN 0 THEN 1 ELSE (SUM(PTYS.SPRUT)/SUM(PTYS.PRODUCCION)) END)*100),2)) Porc_SPrut, "
        Qs = Qs & " SUM(PTYS.PURGA) AS Purga "

        Qs = Qs & " FROM (((sELECT Orden_Produccion,  Fecha_Pesaje, Hora_Pesaje,  Turno, "
        Qs = Qs & " 'PRODUCCION' as tipoprod, Notifica, tramos as Tramos, Peso_Neto as PRODUCCION, 0 as sTramos, 0 as SEPARADA, 0 as xTramos, 0 as SCRAP, 0 as SPRUT, 0 as PURGA, Peso_Bruto, Tara, Empaques, Documento_SAP, "
        Qs = Qs & " Consecutivo_SAP, Planta, Bascula, Usuario, PackID, Fecha_turno, PuestoTrabajo FROM " & SessionUser._sCentro.Trim & "_PesoProductoTerminado WHERE tramos <> 0 AND Tipo_PT in ('T','R') and notifica in ('0','1','4')) "

        Qs = Qs & " UNION ALL (sELECT Orden_Produccion,  Fecha_Pesaje, Hora_Pesaje,  Turno, "
        Qs = Qs & " 'SEPARADA' as tipoprod, Notifica, 0 as Tramos, 0 as PRODUCCION, tramos as sTramos, Peso_Neto as SEPARADA, 0 as xTramos, 0 as SCRAP, 0 as SPRUT, 0 as PURGA, Peso_Bruto, Tara, Empaques, Documento_SAP, "
        Qs = Qs & " Consecutivo_SAP, Planta, Bascula, Usuario, PackID, Fecha_turno, PuestoTrabajo FROM " & SessionUser._sCentro.Trim & "_PesoProductoTerminado WHERE tramos <> 0 AND Tipo_PT in ('P') and notifica = '3' ) "

        Qs = Qs & " UNION ALL (sELECT Orden_Produccion,  Fecha_Pesaje, Hora_Pesaje,  Turno, "
        Qs = Qs & " 'SOBREPESO' as tipoprod, Notifica, 0 as Tramos, 0 as PRODUCCION, tramos as sTramos, Peso_Neto as SEPARADA, 0 as xTramos, 0 as SCRAP, 0 as SPRUT, 0 as PURGA, Peso_Bruto, Tara, Empaques, Documento_SAP, "
        Qs = Qs & " Consecutivo_SAP, Planta, Bascula, Usuario, PackID, Fecha_turno, PuestoTrabajo FROM " & SessionUser._sCentro.Trim & "_PesoProductoTerminado WHERE tramos <> 0 AND Tipo_PT in ('S') and notifica = '2' ) "

        Qs = Qs & " UNION ALL (SELECT Orden_Produccion, Fecha_Pesaje, Hora_Pesaje,  Turno, "
        Qs = Qs & " 'SCRAP' as tipoprod, Notifica, 0 as Tramos, 0 as PRODUCCION, 0 as sTramos, 0 as SEPARADA, Tramos as xTramos, Peso_Neto as SCRAP, 0 as SPRUT, 0 as PURGA, Peso_Bruto, Tara, 0, Documento_SAP, "
        Qs = Qs & " Consecutivo_SAP, Planta, Bascula, Usuario, '0', Fecha_turno, PuestoTrabajo FROM " & SessionUser._sCentro.Trim & "_PesoScrap WHERE Tipo_Scrap in ('T','R') AND notifica in ('0','1','4')) "
        Qs = Qs & " UNION ALL (SELECT Orden_Produccion, Fecha_Pesaje, Hora_Pesaje,  Turno, "
        Qs = Qs & " 'SPRUT' as tipoprod, Notifica, 0 as Tramos, 0 as PRODUCCION, 0 as sTramos, 0 as SEPARADA, 0 as xTramos, 0 as SCRAP, Peso_Neto as SPRUT, 0 as PURGA, Peso_Bruto, Tara, 0, Documento_SAP, "
        Qs = Qs & " Consecutivo_SAP, Planta, Bascula, Usuario, '0', Fecha_turno, PuestoTrabajo FROM " & SessionUser._sCentro.Trim & "_PesoScrap WHERE tramos = 0 AND Tipo_Scrap in ('P') AND notifica in ('0','1','4'))"
        Qs = Qs & " UNION ALL (SELECT Orden_Produccion, Fecha_Pesaje, Hora_Pesaje,  Turno, "
        Qs = Qs & " 'PURGA' as tipoprod, Notifica, 0 as Tramos, 0 as PRODUCCION, 0 as sTramos, 0 as SEPARADA, 0 as xTramos, 0 as SCRAP, 0 as SPRUT, Peso_Neto as PURGA, Peso_Bruto, Tara, 0, Documento_SAP, "
        Qs = Qs & " Consecutivo_SAP, Planta, Bascula, Usuario, '0', Fecha_turno, PuestoTrabajo FROM " & SessionUser._sCentro.Trim & "_PesoScrap WHERE Tipo_Scrap in ('G') AND notifica = '5')) PTYS "
        Qs = Qs & " INNER JOIN " & SessionUser._sCentro.Trim & "_OrdenProduccion OP ON OP.Planta= PTYS.PLANTA and  PTYS.Orden_Produccion = OP.Orden_Produccion) "
        Qs = Qs & "	INNER JOIN MCPC_EquipoBasico EB ON PTYS.planta = EB.Planta AND PTYS.PuestoTrabajo = EB.Equipo_basico AND EB.Tpo_equipo_basico='" & EXTINY & "' "
        Qs = Qs & " INNER JOIN " & tablaEXTINY & " PTE ON PTE.Centro = PTYS.planta AND PTE.Codigo = OP.Producto "
        Qs = Qs & " INNER JOIN CatSecciones TCS ON TCS.Centro = PTYS.planta AND TCS.codseccion = PTE.Codseccion  "
        Qs = Qs & " WHERE PTYS.planta= '" & SessionUser._sCentro.Trim & "'"
        Qs = Qs & "  AND PTYS.notifica <> '9' "
        If Not xTurno = "" Then
            Qs = Qs & "   AND PTYS.turno = '" & cmbTurnos.Text.Trim & "'"
        End If

        Qtp = " SELECT SUM(PTYS.TRAMOS), SUM(PTYS.PRODUCCION), SUM(PTYS.sTRAMOS), SUM(PTYS.SEPARADA), "
        Qtp = Qtp & " SUM(PTYS.xTRAMOS), SUM(PTYS.SCRAP), CONVERT(DECIMAL(18,2),ROUND(((CASE SUM(PTYS.PRODUCCION) WHEN 0 THEN 1 ELSE (SUM(PTYS.SCRAP)/SUM(PTYS.PRODUCCION)) END)*100),2)) Porc_Scrap,  "
        Qtp = Qtp & " SUM(PTYS.SPRUT), CONVERT(DECIMAL(18,2),ROUND(((CASE SUM(PTYS.PRODUCCION) WHEN 0 THEN 1 ELSE (SUM(PTYS.SPRUT)/SUM(PTYS.PRODUCCION)) END)*100),2)) Porc_Sprut, "
        Qtp = Qtp & " SUM(PTYS.PURGA) "
        Qtp = Qtp & " FROM (((sELECT Orden_Produccion,  Fecha_Pesaje, Hora_Pesaje,  Turno, "
        Qtp = Qtp & " 'PRODUCCION' as tipoprod, Notifica, tramos as Tramos, Peso_Neto as PRODUCCION, 0 as sTramos, 0 as SEPARADA, 0 as xTramos, 0 as SCRAP, 0 as SPRUT, 0 as PURGA, Peso_Bruto, Tara, Empaques, Documento_SAP, "
        Qtp = Qtp & " Consecutivo_SAP, Planta, Bascula, Usuario, PackID, Fecha_turno, PuestoTrabajo FROM " & SessionUser._sCentro.Trim & "_PesoProductoTerminado WHERE tramos <> 0 AND Tipo_PT in ('T','R') and notifica in ('0','1','4')) "
        Qtp = Qtp & " UNION ALL (sELECT Orden_Produccion,  Fecha_Pesaje, Hora_Pesaje,  Turno, "
        Qtp = Qtp & " 'SEPARADA' as tipoprod, Notifica, 0 as Tramos, 0 as PRODUCCION, tramos as sTramos, Peso_Neto as SEPARADA, 0 as xTramos, 0 as SCRAP, 0 as SPRUT, 0 as PURGA, Peso_Bruto, Tara, Empaques, Documento_SAP, "
        Qtp = Qtp & " Consecutivo_SAP, Planta, Bascula, Usuario, PackID, Fecha_turno, PuestoTrabajo FROM " & SessionUser._sCentro.Trim & "_PesoProductoTerminado WHERE tramos <> 0 AND Tipo_PT in ('P') and notifica = '3' ) "
        Qtp = Qtp & " UNION ALL (sELECT Orden_Produccion,  Fecha_Pesaje, Hora_Pesaje,  Turno, "
        Qtp = Qtp & " 'SOBREPESO' as tipoprod, Notifica, 0 as Tramos, 0 as PRODUCCION, tramos as sTramos, Peso_Neto as SEPARADA, 0 as xTramos, 0 as SCRAP, 0 as SPRUT, 0 as PURGA, Peso_Bruto, Tara, Empaques, Documento_SAP, "
        Qtp = Qtp & " Consecutivo_SAP, Planta, Bascula, Usuario, PackID, Fecha_turno, PuestoTrabajo FROM " & SessionUser._sCentro.Trim & "_PesoProductoTerminado WHERE tramos <> 0 AND Tipo_PT in ('S') and notifica = '2' ) "

        Qtp = Qtp & " UNION ALL (SELECT Orden_Produccion, Fecha_Pesaje, Hora_Pesaje,  Turno, "
        Qtp = Qtp & " 'SCRAP' as tipoprod, Notifica, 0 as Tramos, 0 as PRODUCCION, 0 as sTramos, 0 as SEPARADA, Tramos as xTramos, Peso_Neto as SCRAP, 0 as SPRUT, 0 as PURGA, Peso_Bruto, Tara, 0, Documento_SAP, "
        Qtp = Qtp & " Consecutivo_SAP, Planta, Bascula, Usuario, '0', Fecha_turno, PuestoTrabajo FROM " & SessionUser._sCentro.Trim & "_PesoScrap WHERE Tipo_Scrap in ('T','R') AND notifica in ('0','1','4')) "
        Qtp = Qtp & " UNION ALL (SELECT Orden_Produccion, Fecha_Pesaje, Hora_Pesaje,  Turno, "
        Qtp = Qtp & " 'SPRUT' as tipoprod, Notifica, 0 as Tramos, 0 as PRODUCCION, 0 as sTramos, 0 as SEPARADA, 0 as xTramos, 0 as SCRAP, Peso_Neto as SPRUT, 0 as PURGA, Peso_Bruto, Tara, 0, Documento_SAP, "
        Qtp = Qtp & " Consecutivo_SAP, Planta, Bascula, Usuario, '0', Fecha_turno, PuestoTrabajo FROM " & SessionUser._sCentro.Trim & "_PesoScrap WHERE tramos = 0 AND Tipo_Scrap in ('P') AND notifica in ('0','1','4'))"
        Qtp = Qtp & " UNION ALL (SELECT Orden_Produccion, Fecha_Pesaje, Hora_Pesaje,  Turno, "
        Qtp = Qtp & " 'PURGA' as tipoprod, Notifica, 0 as Tramos, 0 as PRODUCCION, 0 as sTramos, 0 as SEPARADA, 0 as xTramos, 0 as SCRAP, 0 as SPRUT, Peso_Neto as PURGA, Peso_Bruto, Tara, 0, Documento_SAP, "
        Qtp = Qtp & " Consecutivo_SAP, Planta, Bascula, Usuario, '0', Fecha_turno, PuestoTrabajo FROM " & SessionUser._sCentro.Trim & "_PesoScrap WHERE Tipo_Scrap in ('G') AND notifica = '5')) PTYS "
        Qtp = Qtp & " INNER JOIN " & SessionUser._sCentro.Trim & "_OrdenProduccion OP ON OP.Planta= PTYS.PLANTA and  PTYS.Orden_Produccion = OP.Orden_Produccion) "
        Qtp = Qtp & " INNER JOIN MCPC_EquipoBasico EB ON PTYS.planta = EB.Planta AND PTYS.PuestoTrabajo = EB.Equipo_basico and Tpo_equipo_basico='" & EXTINY & "' "
        Qtp = Qtp & " INNER JOIN " & tablaEXTINY & " PTE ON PTE.CENTRO= PTYS.PLANTA and  PTE.Codigo = OP.Producto "
        Qtp = Qtp & " WHERE PTYS.planta= '" & SessionUser._sCentro.Trim & "'"
        Qtp = Qtp & "  AND PTYS.notifica <> '9' "

        If Not xTurno = "" Then
            Qtp = Qtp & " AND PTYS.turno = '" & cmbTurnos.Text.Trim & "'"
        End If
        Qfup = ""
        Qfup = Qfup & "  SELECT sum(HPTOTAL.HREPORTADAS), sum(HPTOTAL.POR_PROGRAMA), sum(HPTOTAL.MANTENIMIENTO), sum(HPTOTAL.POR_SETUP), sum(HPTOTAL.OTROS) "
        Qfup = Qfup & " FROM ((SELECT THP.Centro, THP.ordenProd, THP.fecha, THP.turno, THP.PuestoTrabajo, THP.CodCausa, horasparo as HREPORTADAS, 0 as POR_PROGRAMA, 0 as MANTENIMIENTO, 0 as POR_SETUP, 0 as OTROS"
        Qfup = Qfup & " FROM ((" & SessionUser._sCentro.Trim & "_HorasParo THP INNER JOIN " & SessionUser._sCentro.Trim & "_OrdenProduccion OP ON THP.Centro = OP.planta AND THP.ordenProd = OP.Orden_Produccion )"
        Qfup = Qfup & " INNER JOIN MCPC_EquipoBasico EB ON THP.centro = EB.Planta AND THP.PuestoTrabajo = EB.Equipo_basico AND EB.Tpo_equipo_basico='" & EXTINY & "' "
        Qfup = Qfup & " INNER JOIN ProductoTerminadoinyeccion PTE ON PTE.CENTRO= THP.centro and PTE.Codigo = OP.Producto )"
        Qfup = Qfup & " INNER JOIN CatCausas CC  ON CC.Centro=THP.Centro AND CC.grpprod=PTE.grpprod AND CC.CodCausa=THP.CodCausa   "
        Qfup = Qfup & " INNER JOIN CatAgrupaciones CA ON CC.centro= CA.centro AND CC.codcausagrupa = CA.codcausagrupa  AND CA.status = 'A' "
        Qfup = Qfup & " where THP.CodCausa='0000' and THP.status<>'9')"
        Qfup = Qfup & " union all (SELECT THP.Centro, THP.ordenProd, THP.fecha, THP.turno, THP.PuestoTrabajo, THP.CodCausa, 0 as HREPORTADAS, horasparo as POR_PROGRAMA, 0 as MANTENIMIENTO, 0 as POR_SETUP, 0 as OTROS"
        Qfup = Qfup & " FROM ((" & SessionUser._sCentro.Trim & "_HorasParo THP INNER JOIN " & SessionUser._sCentro.Trim & "_OrdenProduccion OP ON THP.Centro = OP.planta AND THP.ordenProd = OP.Orden_Produccion )"
        Qfup = Qfup & " INNER JOIN MCPC_EquipoBasico EB ON THP.centro = EB.Planta AND THP.PuestoTrabajo = EB.Equipo_basico AND EB.Tpo_equipo_basico='" & EXTINY & "' "
        Qfup = Qfup & " INNER JOIN " & tablaEXTINY & " PTE ON PTE.CENTRO= THP.centro and PTE.Codigo = OP.Producto )"
        Qfup = Qfup & " INNER JOIN CatCausas CC  ON CC.Centro=THP.Centro AND CC.grpprod=PTE.grpprod AND CC.CodCausa=THP.CodCausa   "
        Qfup = Qfup & " INNER JOIN CatAgrupaciones CA ON CC.centro= CA.centro AND CC.codcausagrupa = CA.codcausagrupa  AND CA.status = 'A' AND CA.codgrpgeneral= '1'"
        Qfup = Qfup & " where THP.CodCausa<>'0000' and THP.status<>'9')      "

        Qfup = Qfup & " union all (SELECT THP.Centro, THP.ordenProd, THP.fecha, THP.turno, THP.PuestoTrabajo, THP.CodCausa, 0 as HREPORTADAS, 0 as POR_PROGRAMA, horasparo as MANTENIMIENTO, 0 as POR_SETUP, 0 as OTROS"
        Qfup = Qfup & " FROM ((" & SessionUser._sCentro.Trim & "_HorasParo THP INNER JOIN " & SessionUser._sCentro.Trim & "_OrdenProduccion OP ON THP.Centro = OP.planta AND THP.ordenProd = OP.Orden_Produccion )"
        Qfup = Qfup & " 	INNER JOIN MCPC_EquipoBasico EB ON THP.centro = EB.Planta AND THP.PuestoTrabajo = EB.Equipo_basico AND EB.Tpo_equipo_basico='" & EXTINY & "' "
        Qfup = Qfup & " 	INNER JOIN " & tablaEXTINY & " PTE ON PTE.CENTRO= THP.centro and PTE.Codigo = OP.Producto )"
        Qfup = Qfup & " 	INNER JOIN CatCausas CC  ON CC.Centro=THP.Centro AND CC.grpprod=PTE.grpprod AND CC.CodCausa=THP.CodCausa   "
        Qfup = Qfup & " 	INNER JOIN CatAgrupaciones CA ON CC.centro= CA.centro AND CC.codcausagrupa = CA.codcausagrupa  AND CA.status = 'A' AND CA.codgrpgeneral= '2'"
        Qfup = Qfup & " where THP.CodCausa<>'0000' and THP.status<>'9')"
        Qfup = Qfup & " union all (SELECT THP.Centro, THP.ordenProd, THP.fecha, THP.turno, THP.PuestoTrabajo, THP.CodCausa, 0 as HREPORTADAS, 0 as POR_PROGRAMA, 0 as MANTENIMIENTO, horasparo as POR_SETUP, 0 as OTROS"
        Qfup = Qfup & " FROM ((" & SessionUser._sCentro.Trim & "_HorasParo THP INNER JOIN " & SessionUser._sCentro.Trim & "_OrdenProduccion OP ON THP.Centro = OP.planta AND THP.ordenProd = OP.Orden_Produccion )"
        Qfup = Qfup & " 	INNER JOIN MCPC_EquipoBasico EB ON THP.centro = EB.Planta AND THP.PuestoTrabajo = EB.Equipo_basico AND EB.Tpo_equipo_basico='" & EXTINY & "' "
        Qfup = Qfup & " 	INNER JOIN " & tablaEXTINY & " PTE ON PTE.CENTRO= THP.centro and PTE.Codigo = OP.Producto )"
        Qfup = Qfup & " 	INNER JOIN CatCausas CC  ON CC.Centro=THP.Centro AND CC.grpprod=PTE.grpprod AND CC.CodCausa=THP.CodCausa   "
        Qfup = Qfup & " 	INNER JOIN CatAgrupaciones CA ON CC.centro= CA.centro AND CC.codcausagrupa = CA.codcausagrupa  AND CA.status = 'A' AND CA.codgrpgeneral= '3'"
        Qfup = Qfup & " where THP.CodCausa<>'0000' and THP.status<>'9')"

        Qfup = Qfup & " union all (SELECT THP.Centro, THP.ordenProd, THP.fecha, THP.turno, THP.PuestoTrabajo, THP.CodCausa, 0 as HREPORTADAS, 0 as POR_PROGRAMA, 0 as MANTENIMIENTO, 0 as POR_SETUP,horasparo as OTROS"
        Qfup = Qfup & " FROM ((" & SessionUser._sCentro.Trim & "_HorasParo THP INNER JOIN " & SessionUser._sCentro.Trim & "_OrdenProduccion OP ON THP.Centro = OP.planta AND THP.ordenProd = OP.Orden_Produccion )"
        Qfup = Qfup & " 	INNER JOIN MCPC_EquipoBasico EB ON THP.centro = EB.Planta AND THP.PuestoTrabajo = EB.Equipo_basico AND EB.Tpo_equipo_basico='" & EXTINY & "' "
        Qfup = Qfup & " 	INNER JOIN " & tablaEXTINY & " PTE ON PTE.CENTRO= THP.centro and PTE.Codigo = OP.Producto )"
        Qfup = Qfup & " 	INNER JOIN CatCausas CC  ON CC.Centro=THP.Centro AND CC.grpprod=PTE.grpprod AND CC.CodCausa=THP.CodCausa   "
        Qfup = Qfup & " 	INNER JOIN CatAgrupaciones CA ON CC.centro= CA.centro AND CC.codcausagrupa = CA.codcausagrupa  AND CA.status = 'A' AND CA.codgrpgeneral= '9'"
        Qfup = Qfup & " WHERE THP.CodCausa<>'0000' and THP.status<>'9')"
        Qfup = Qfup & " ) HPTOTAL WHERE HPTOTAL.centro='" & SessionUser._sCentro.Trim & "' "
        If Not xTurno = "" Then
            Qfup = Qfup & "   AND HPTOTAL.turno = '" & cmbTurnos.Text.Trim & "'"
        End If

        If CB2.Checked = True Then
            If TxtOrdProd.Text = "" Then
                MessageBox.Show(" Tecleé Orden de Fabricación ")
                TxtOrdProd.Text = ""
                TxtOrdProd.Focus()
                Exit Sub
            End If

            If TxtOrdProd.Text.Trim = "*" Then

                Qd = Qd & "   ORDER BY PTYS.Fecha_Pesaje DESC, PTYS.Hora_Pesaje DESC"
                Qdg = Qd
                Try
                    objDa = New SqlDataAdapter(Qd, objCnnAmanco.ConnectionString)
                    objDs = New DataSet
                    objDa.Fill(objDs)
                    DGPPT.CaptionText = "Detalle Pesaje Final y SCRAP"
                    DGPPT.DataSource = objDs

                    xRegCount = objDs.Tables(0).Rows.Count
                    DGPPT.CaptionText = "Detalle Pesaje por ORDEN-MAQUINA             Registros: " & xRegCount

                Catch ex As Exception
                    MessageBox.Show("Error Conexion :" & ex.Message, "DATOS DETALLE PESAJES")
                End Try

                Qt = Qt & " GROUP BY PTYS.PuestoTrabajo, PTE.Codigo, PTE.Descr, OP.Cantidad_Programada_Tramos "

                Try
                    objDa = New SqlDataAdapter(Qt, objCnnAmanco.ConnectionString)
                    objDs = New DataSet
                    objDa.Fill(objDs)
                    DGOP.DataSource = objDs

                    xRegCount = objDs.Tables(0).Rows.Count
                    DGOP.CaptionText = "Resumen pesaje por ORDEN-MAQUINA          Registros: " & xRegCount

                Catch ex As Exception
                    MessageBox.Show("Error Conexion :" & ex.Message, "DATOS RESUMEN PESAJE")
                End Try

                Qs = Qs & " GROUP BY TCS.codseccion, TCS.Desseccion  "

                Try
                    objDa = New SqlDataAdapter(Qs, objCnnAmanco.ConnectionString)
                    objDs = New DataSet
                    objDa.Fill(objDs)
                    DGSC.DataSource = objDs
                Catch ex As Exception
                    MessageBox.Show("Error Conexion :" & ex.Message, "DATOS RESUMEN SECCIONES")
                End Try

                Try
                    objCmd = New SqlCommand
                    objCmd.CommandType = CommandType.Text
                    objCmd.Connection = objCnnAmanco
                    objCmd.CommandText = Qtp
                    myDataReader = objCmd.ExecuteReader()

                    If myDataReader.Read() Then
                        xTOTUNPROD = "0" & myDataReader(0).ToString
                        xTOTKILOSPROD = "0" & myDataReader(1).ToString
                        xTOTUNPROCESO = "0" & myDataReader(2).ToString
                        xTOTKILOSPROCESO = "0" & myDataReader(3).ToString
                        xTOTUNSCRAP = "0" & myDataReader(4).ToString
                        xTOTKILOSSCRAP = "0" & myDataReader(5).ToString
                        xPORCSCRAP = "0" & myDataReader(6).ToString
                        xTOTKILOSSPRUT = "0" & myDataReader(7).ToString
                        xPORCSPRUT = "0" & myDataReader(8).ToString
                        xTOTKILOSPURGA = "0" & myDataReader(9).ToString

                        txtTotunprod.Text = Format(xTOTUNPROD, xFormato)
                        txtTotkilosprod.Text = Format(xTOTKILOSPROD, xFormato)
                        txtTotunproceso.Text = Format(xTOTUNPROCESO, xFormato)
                        txtTotkilosproceso.Text = Format(xTOTKILOSPROCESO, xFormato)
                        txtTotunscrap.Text = Format(xTOTUNSCRAP, xFormato)
                        txtTotkilosscrap.Text = Format(xTOTKILOSSCRAP, xFormato)
                        txtPorscrap.Text = Format(xPORCSCRAP, xFormato)
                        txtTotkilossprut.Text = Format(xTOTKILOSSPRUT, xFormato)
                        txtPorsprut.Text = Format(xPORCSPRUT, xFormato)
                        txtTotkilospurga.Text = Format(xTOTKILOSPURGA, xFormato)

                        myDataReader.Close()
                    End If

                Catch ex As Exception
                    MessageBox.Show("Error Conexion :" & ex.Message, "DATOS TOTALES")
                End Try

                Try
                    objCmd = New SqlCommand
                    objCmd.CommandType = CommandType.Text
                    objCmd.Connection = objCnnAmanco
                    objCmd.CommandText = Qfup
                    myDataReaderH = objCmd.ExecuteReader()
                    If myDataReaderH.Read() Then
                        xTotHorastrab = "0" & myDataReaderH(0).ToString
                        xTotHorasprog = "0" & myDataReaderH(1).ToString
                        xTotHorasmant = "0" & myDataReaderH(2).ToString
                        xTotHorassetu = "0" & myDataReaderH(3).ToString
                        xTotHorasotro = "0" & myDataReaderH(4).ToString

                        txtTotHorastrab.Text = Format(xTotHorastrab, xFormato)
                        txtTotHorasprog.Text = Format(xTotHorasprog, xFormato)
                        txtTotHorasmant.Text = Format(xTotHorasmant, xFormato)
                        txtTotHorassetu.Text = Format(xTotHorassetu, xFormato)
                        txtTotHorasotro.Text = Format(xTotHorasotro, xFormato)

                        myDataReaderH.Close()
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error Conexion :" & ex.Message, "DATOS TOTALES HORAS")
                End Try
            End If

            If TxtOrdProd.Text <> "*" Then

                Qd = Qd & "   AND PTYS.Orden_Produccion like ('%" & TxtOrdProd.Text.Trim & "%') "
                Qd = Qd & "   ORDER BY PTYS.Fecha_Pesaje DESC, PTYS.Hora_Pesaje DESC"
                Qdg = Qd
                Try
                    objDa = New SqlDataAdapter(Qd, objCnnAmanco.ConnectionString)
                    objDs = New DataSet
                    objDa.Fill(objDs)
                    DGPPT.DataSource = objDs

                    xRegCount = objDs.Tables(0).Rows.Count
                    DGPPT.CaptionText = "Detalle Pesaje por ORDEN-MAQUINA             Registros: " & xRegCount

                Catch ex As Exception
                    MessageBox.Show("Error Conexion :" & ex.Message, "DATOS DETALLE PESAJES")
                End Try

                Qt = Qt & " AND PTYS.Orden_Produccion like ('%" & TxtOrdProd.Text.Trim & "%') "
                Qt = Qt & " GROUP BY PTYS.PuestoTrabajo, PTE.Codigo, PTE.Descr, OP.Cantidad_Programada_Tramos "

                Try
                    objDa = New SqlDataAdapter(Qt, objCnnAmanco.ConnectionString)
                    objDs = New DataSet
                    objDa.Fill(objDs)
                    DGOP.DataSource = objDs

                    xRegCount = objDs.Tables(0).Rows.Count
                    DGOP.CaptionText = "Resumen pesaje por ORDEN-MAQUINA          Registros: " & xRegCount

                Catch ex As Exception
                    MessageBox.Show("Error Conexion :" & ex.Message, "DATOS RESUMEN PESAJE")
                End Try

                Qs = Qs & " AND PTYS.Orden_Produccion like ('%" & TxtOrdProd.Text.Trim & "%') "
                Qs = Qs & " GROUP BY TCS.codseccion, TCS.Desseccion  "

                Try
                    objDa = New SqlDataAdapter(Qs, objCnnAmanco.ConnectionString)
                    objDs = New DataSet
                    objDa.Fill(objDs)
                    DGSC.DataSource = objDs
                Catch ex As Exception
                    MessageBox.Show("Error Conexion :" & ex.Message, "DATOS RESUMEN SECCIONES")
                End Try

                Qtp = Qtp & "   AND PTYS.Orden_Produccion like ('%" & TxtOrdProd.Text.Trim & "%') "

                Try
                    objCmd = New SqlCommand
                    objCmd.CommandType = CommandType.Text
                    objCmd.Connection = objCnnAmanco
                    objCmd.CommandText = Qtp
                    myDataReader = objCmd.ExecuteReader()

                    If myDataReader.Read() Then
                        xTOTUNPROD = "0" & myDataReader(0).ToString
                        xTOTKILOSPROD = "0" & myDataReader(1).ToString
                        xTOTUNPROCESO = "0" & myDataReader(2).ToString
                        xTOTKILOSPROCESO = "0" & myDataReader(3).ToString
                        xTOTUNSCRAP = "0" & myDataReader(4).ToString
                        xTOTKILOSSCRAP = "0" & myDataReader(5).ToString
                        xPORCSCRAP = "0" & myDataReader(6).ToString
                        xTOTKILOSSPRUT = "0" & myDataReader(7).ToString
                        xPORCSPRUT = "0" & myDataReader(8).ToString
                        xTOTKILOSPURGA = "0" & myDataReader(9).ToString

                        txtTotunprod.Text = Format(xTOTUNPROD, xFormato)
                        txtTotkilosprod.Text = Format(xTOTKILOSPROD, xFormato)
                        txtTotunproceso.Text = Format(xTOTUNPROCESO, xFormato)
                        txtTotkilosproceso.Text = Format(xTOTKILOSPROCESO, xFormato)
                        txtTotunscrap.Text = Format(xTOTUNSCRAP, xFormato)
                        txtTotkilosscrap.Text = Format(xTOTKILOSSCRAP, xFormato)
                        txtPorscrap.Text = Format(xPORCSCRAP, xFormato)
                        txtTotkilossprut.Text = Format(xTOTKILOSSPRUT, xFormato)
                        txtPorsprut.Text = Format(xPORCSPRUT, xFormato)
                        txtTotkilospurga.Text = Format(xTOTKILOSPURGA, xFormato)

                        myDataReader.Close()
                    End If

                Catch ex As Exception
                    MessageBox.Show("Error Conexion :" & ex.Message, "DATOS TOTALES")
                End Try

                Qfup = Qfup & "   AND HPTOTAL.ordenProd like ('%" & TxtOrdProd.Text.Trim & "%') "

                Try
                    objCmd = New SqlCommand
                    objCmd.CommandType = CommandType.Text
                    objCmd.Connection = objCnnAmanco
                    objCmd.CommandText = Qfup
                    myDataReaderH = objCmd.ExecuteReader()
                    If myDataReaderH.Read() Then
                        xTotHorastrab = "0" & myDataReaderH(0).ToString
                        xTotHorasprog = "0" & myDataReaderH(1).ToString
                        xTotHorasmant = "0" & myDataReaderH(2).ToString
                        xTotHorassetu = "0" & myDataReaderH(3).ToString
                        xTotHorasotro = "0" & myDataReaderH(4).ToString

                        txtTotHorastrab.Text = Format(xTotHorastrab, xFormato)
                        txtTotHorasprog.Text = Format(xTotHorasprog, xFormato)
                        txtTotHorasmant.Text = Format(xTotHorasmant, xFormato)
                        txtTotHorassetu.Text = Format(xTotHorassetu, xFormato)
                        txtTotHorasotro.Text = Format(xTotHorasotro, xFormato)

                        myDataReaderH.Close()
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error Conexion :" & ex.Message, "DATOS TOTALES HORAS")
                End Try

            End If
        End If

        If CB3.Checked = True Then
            If TxtOrdProd.Text = "" Then
                MessageBox.Show(" Tecleé Orden de Fabricación ")
                TxtOrdProd.Text = ""
                TxtOrdProd.Focus()
                Exit Sub
            End If
            If TxtOrdProd.Text = "*" Then

                Qd = Qd & "   AND PTYS.fecha_turno BETWEEN '" & StrFecIni & "' AND '" & StrFecFin & "' "
                Qd = Qd & "   ORDER BY PTYS.Fecha_Pesaje DESC, PTYS.Hora_Pesaje DESC"
                Qdg = Qd
                Try
                    objDa = New SqlDataAdapter(Qd, objCnnAmanco.ConnectionString)
                    objDs = New DataSet
                    objDa.Fill(objDs)
                    DGPPT.DataSource = objDs

                    xRegCount = objDs.Tables(0).Rows.Count
                    DGPPT.CaptionText = "Detalle Pesaje por ORDEN-MAQUINA             Registros: " & xRegCount

                Catch ex As Exception
                    MessageBox.Show("Error Conexion :" & ex.Message, "DATOS DETALLE PESAJES")
                End Try

                Qt = Qt & " AND PTYS.fecha_turno BETWEEN '" & StrFecIni & "' AND '" & StrFecFin & "' "
                Qt = Qt & " GROUP BY  PTYS.PuestoTrabajo, PTE.Codigo, PTE.Descr, OP.Cantidad_Programada_Tramos "

                Try
                    objDa = New SqlDataAdapter(Qt, objCnnAmanco.ConnectionString)
                    objDs = New DataSet
                    objDa.Fill(objDs)
                    DGOP.DataSource = objDs

                    xRegCount = objDs.Tables(0).Rows.Count
                    DGOP.CaptionText = "Resumen pesaje por ORDEN-MAQUINA          Registros: " & xRegCount

                Catch ex As Exception
                    MessageBox.Show("Error Conexion :" & ex.Message, "DATOS RESUMEN PESAJE")
                End Try

                Qs = Qs & " AND PTYS.fecha_turno BETWEEN '" & StrFecIni & "' AND '" & StrFecFin & "' "
                Qs = Qs & " GROUP BY TCS.codseccion, TCS.Desseccion  "

                Try
                    objDa = New SqlDataAdapter(Qs, objCnnAmanco.ConnectionString)
                    objDs = New DataSet
                    objDa.Fill(objDs)
                    DGSC.DataSource = objDs
                Catch ex As Exception
                    MessageBox.Show("Error Conexion :" & ex.Message, "DATOS RESUMEN SECCIONES")
                End Try

                Qtp = Qtp & "   AND PTYS.fecha_turno BETWEEN '" & StrFecIni & "' AND '" & StrFecFin & "' "

                Try
                    objCmd = New SqlCommand
                    objCmd.CommandType = CommandType.Text
                    objCmd.Connection = objCnnAmanco
                    objCmd.CommandText = Qtp
                    myDataReader = objCmd.ExecuteReader()

                    If myDataReader.Read() Then
                        xTOTUNPROD = "0" & myDataReader(0).ToString
                        xTOTKILOSPROD = "0" & myDataReader(1).ToString
                        xTOTUNPROCESO = "0" & myDataReader(2).ToString
                        xTOTKILOSPROCESO = "0" & myDataReader(3).ToString
                        xTOTUNSCRAP = "0" & myDataReader(4).ToString
                        xTOTKILOSSCRAP = "0" & myDataReader(5).ToString
                        xPORCSCRAP = "0" & myDataReader(6).ToString
                        xTOTKILOSSPRUT = "0" & myDataReader(7).ToString
                        xPORCSPRUT = "0" & myDataReader(8).ToString
                        xTOTKILOSPURGA = "0" & myDataReader(9).ToString

                        txtTotunprod.Text = Format(xTOTUNPROD, xFormato)
                        txtTotkilosprod.Text = Format(xTOTKILOSPROD, xFormato)
                        txtTotunproceso.Text = Format(xTOTUNPROCESO, xFormato)
                        txtTotkilosproceso.Text = Format(xTOTKILOSPROCESO, xFormato)
                        txtTotunscrap.Text = Format(xTOTUNSCRAP, xFormato)
                        txtTotkilosscrap.Text = Format(xTOTKILOSSCRAP, xFormato)
                        txtPorscrap.Text = Format(xPORCSCRAP, xFormato)
                        txtTotkilossprut.Text = Format(xTOTKILOSSPRUT, xFormato)
                        txtPorsprut.Text = Format(xPORCSPRUT, xFormato)
                        txtTotkilospurga.Text = Format(xTOTKILOSPURGA, xFormato)

                        myDataReader.Close()
                    End If

                Catch ex As Exception
                    MessageBox.Show("Error Conexion :" & ex.Message, "DATOS TOTALES")
                End Try
                Qfup = Qfup & "   AND HPTOTAL.Fecha BETWEEN '" & StrFecIni & "' AND '" & StrFecFin & "' "

                Try
                    objCmd = New SqlCommand
                    objCmd.CommandType = CommandType.Text
                    objCmd.Connection = objCnnAmanco
                    objCmd.CommandText = Qfup
                    myDataReaderH = objCmd.ExecuteReader()
                    If myDataReaderH.Read() Then
                        xTotHorastrab = "0" & myDataReaderH(0).ToString
                        xTotHorasprog = "0" & myDataReaderH(1).ToString
                        xTotHorasmant = "0" & myDataReaderH(2).ToString
                        xTotHorassetu = "0" & myDataReaderH(3).ToString
                        xTotHorasotro = "0" & myDataReaderH(4).ToString

                        txtTotHorastrab.Text = Format(xTotHorastrab, xFormato)
                        txtTotHorasprog.Text = Format(xTotHorasprog, xFormato)
                        txtTotHorasmant.Text = Format(xTotHorasmant, xFormato)
                        txtTotHorassetu.Text = Format(xTotHorassetu, xFormato)
                        txtTotHorasotro.Text = Format(xTotHorasotro, xFormato)

                        myDataReaderH.Close()
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error Conexion :" & ex.Message, "DATOS TOTALES HORAS")
                End Try

            End If
            If TxtOrdProd.Text <> "*" Then
                Qd = Qd & "   AND PTYS.Orden_Produccion like ('%" & TxtOrdProd.Text.Trim & "%') "
                Qd = Qd & "   AND PTYS.fecha_turno BETWEEN '" & StrFecIni & "' AND '" & StrFecFin & "' "
                Qd = Qd & "   ORDER BY PTYS.Fecha_Pesaje DESC, PTYS.Hora_Pesaje DESC"
                Qdg = Qd
                Try
                    objDa = New SqlDataAdapter(Qd, objCnnAmanco.ConnectionString)
                    objDs = New DataSet
                    objDa.Fill(objDs)
                    DGPPT.DataSource = objDs

                    xRegCount = objDs.Tables(0).Rows.Count
                    DGPPT.CaptionText = "Detalle Pesaje por ORDEN-MAQUINA             Registros: " & xRegCount

                Catch ex As Exception
                    MessageBox.Show("Error Conexion :" & ex.Message, "DATOS DETALLE PESAJES")
                End Try

                Qt = Qt & " AND PTYS.Orden_Produccion like ('%" & TxtOrdProd.Text.Trim & "%') "
                Qt = Qt & " AND PTYS.fecha_turno BETWEEN '" & StrFecIni & "' AND '" & StrFecFin & "' "
                Qt = Qt & " GROUP BY PTYS.PuestoTrabajo, PTE.Codigo, PTE.Descr, OP.Cantidad_Programada_Tramos"

                Try
                    objDa = New SqlDataAdapter(Qt, objCnnAmanco.ConnectionString)
                    objDs = New DataSet
                    objDa.Fill(objDs)
                    DGOP.DataSource = objDs

                    xRegCount = objDs.Tables(0).Rows.Count
                    DGOP.CaptionText = "Resumen pesaje por ORDEN-MAQUINA          Registros: " & xRegCount

                Catch ex As Exception
                    MessageBox.Show("Error Conexion :" & ex.Message, "DATOS RESUMEN PESAJE")
                End Try
                Qs = Qs & " AND PTYS.Orden_Produccion like ('%" & TxtOrdProd.Text.Trim & "%') "
                Qs = Qs & " AND PTYS.fecha_turno BETWEEN '" & StrFecIni & "' AND '" & StrFecFin & "' "
                Qs = Qs & " GROUP BY TCS.codseccion, TCS.Desseccion  "

                Try
                    objDa = New SqlDataAdapter(Qs, objCnnAmanco.ConnectionString)
                    objDs = New DataSet
                    objDa.Fill(objDs)
                    DGSC.DataSource = objDs
                Catch ex As Exception
                    MessageBox.Show("Error Conexion :" & ex.Message, "DATOS RESUMEN SECCIONES")
                End Try

                Qtp = Qtp & "   AND PTYS.Orden_Produccion like ('%" & TxtOrdProd.Text.Trim & "%') "
                Qtp = Qtp & "   AND PTYS.fecha_turno BETWEEN '" & StrFecIni & "' AND '" & StrFecFin & "' "

                Try
                    objCmd = New SqlCommand
                    objCmd.CommandType = CommandType.Text
                    objCmd.Connection = objCnnAmanco
                    objCmd.CommandText = Qtp
                    myDataReader = objCmd.ExecuteReader()

                    If myDataReader.Read() Then
                        xTOTUNPROD = "0" & myDataReader(0).ToString
                        xTOTKILOSPROD = "0" & myDataReader(1).ToString
                        xTOTUNPROCESO = "0" & myDataReader(2).ToString
                        xTOTKILOSPROCESO = "0" & myDataReader(3).ToString
                        xTOTUNSCRAP = "0" & myDataReader(4).ToString
                        xTOTKILOSSCRAP = "0" & myDataReader(5).ToString
                        xPORCSCRAP = "0" & myDataReader(6).ToString
                        xTOTKILOSSPRUT = "0" & myDataReader(7).ToString
                        xPORCSPRUT = "0" & myDataReader(8).ToString
                        xTOTKILOSPURGA = "0" & myDataReader(9).ToString

                        txtTotunprod.Text = Format(xTOTUNPROD, xFormato)
                        txtTotkilosprod.Text = Format(xTOTKILOSPROD, xFormato)
                        txtTotunproceso.Text = Format(xTOTUNPROCESO, xFormato)
                        txtTotkilosproceso.Text = Format(xTOTKILOSPROCESO, xFormato)
                        txtTotunscrap.Text = Format(xTOTUNSCRAP, xFormato)
                        txtTotkilosscrap.Text = Format(xTOTKILOSSCRAP, xFormato)
                        txtPorscrap.Text = Format(xPORCSCRAP, xFormato)
                        txtTotkilossprut.Text = Format(xTOTKILOSSPRUT, xFormato)
                        txtPorsprut.Text = Format(xPORCSPRUT, xFormato)
                        txtTotkilospurga.Text = Format(xTOTKILOSPURGA, xFormato)

                        myDataReader.Close()
                    End If

                Catch ex As Exception
                    MessageBox.Show("Error Conexion :" & ex.Message, "DATOS TOTALES")
                End Try

                Qfup = Qfup & "   AND HPTOTAL.OrdenProd like ('%" & TxtOrdProd.Text.Trim & "%') "
                Qfup = Qfup & "   AND HPTOTAL.Fecha BETWEEN '" & StrFecIni & "' AND '" & StrFecFin & "' "

                Try
                    objCmd = New SqlCommand
                    objCmd.CommandType = CommandType.Text
                    objCmd.Connection = objCnnAmanco
                    objCmd.CommandText = Qfup
                    myDataReaderH = objCmd.ExecuteReader()
                    If myDataReaderH.Read() Then
                        xTotHorastrab = "0" & myDataReaderH(0).ToString
                        xTotHorasprog = "0" & myDataReaderH(1).ToString
                        xTotHorasmant = "0" & myDataReaderH(2).ToString
                        xTotHorassetu = "0" & myDataReaderH(3).ToString
                        xTotHorasotro = "0" & myDataReaderH(4).ToString

                        txtTotHorastrab.Text = Format(xTotHorastrab, xFormato)
                        txtTotHorasprog.Text = Format(xTotHorasprog, xFormato)
                        txtTotHorasmant.Text = Format(xTotHorasmant, xFormato)
                        txtTotHorassetu.Text = Format(xTotHorassetu, xFormato)
                        txtTotHorasotro.Text = Format(xTotHorasotro, xFormato)

                        myDataReaderH.Close()
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error Conexion :" & ex.Message, "DATOS TOTALES HORAS")
                End Try

            End If
        End If

        If CB4.Checked = True Then
            If txtEquipo.Text = "" Then
                MessageBox.Show(" Tecleé equipo ")
                txtEquipo.Text = ""
                txtEquipo.Focus()
                Exit Sub
            End If
            If txtEquipo.Text = "*" Then
                Qd = Qd & "   AND PTYS.fecha_turno BETWEEN '" & StrFecIni & "' AND '" & StrFecFin & "' "
                Qd = Qd & "   ORDER BY PTYS.Fecha_Pesaje DESC, PTYS.Hora_Pesaje DESC"
                Qdg = Qd
                Try
                    objDa = New SqlDataAdapter(Qd, objCnnAmanco.ConnectionString)
                    objDs = New DataSet
                    objDa.Fill(objDs)
                    DGPPT.DataSource = objDs

                    xRegCount = objDs.Tables(0).Rows.Count
                    DGPPT.CaptionText = "Detalle Pesaje por ORDEN-MAQUINA             Registros: " & xRegCount

                Catch ex As Exception
                    MessageBox.Show("Error Conexion :" & ex.Message, "DATOS DETALLE PESAJES")
                End Try

                Qt = Qt & " AND PTYS.fecha_turno BETWEEN '" & StrFecIni & "' AND '" & StrFecFin & "' "
                Qt = Qt & " GROUP BY  PTYS.PuestoTrabajo, PTE.Codigo, PTE.Descr, OP.Cantidad_Programada_Tramos "

                Try
                    objDa = New SqlDataAdapter(Qt, objCnnAmanco.ConnectionString)
                    objDs = New DataSet
                    objDa.Fill(objDs)
                    DGOP.DataSource = objDs

                    xRegCount = objDs.Tables(0).Rows.Count
                    DGOP.CaptionText = "Resumen pesaje por ORDEN-MAQUINA          Registros: " & xRegCount

                Catch ex As Exception
                    MessageBox.Show("Error Conexion :" & ex.Message, "DATOS RESUMEN PESAJE")
                End Try

                Qs = Qs & " AND PTYS.fecha_turno BETWEEN '" & StrFecIni & "' AND '" & StrFecFin & "' "
                Qs = Qs & " GROUP BY TCS.codseccion, TCS.Desseccion  "

                Try
                    objDa = New SqlDataAdapter(Qs, objCnnAmanco.ConnectionString)
                    objDs = New DataSet
                    objDa.Fill(objDs)
                    DGSC.DataSource = objDs
                Catch ex As Exception
                    MessageBox.Show("Error Conexion :" & ex.Message, "DATOS RESUMEN SECCIONES")
                End Try

                Qtp = Qtp & "   AND PTYS.fecha_turno BETWEEN '" & StrFecIni & "' AND '" & StrFecFin & "' "

                Try
                    objCmd = New SqlCommand
                    objCmd.CommandType = CommandType.Text
                    objCmd.Connection = objCnnAmanco
                    objCmd.CommandText = Qtp
                    myDataReader = objCmd.ExecuteReader()
                    If myDataReader.Read() Then
                        xTOTUNPROD = "0" & myDataReader(0).ToString
                        xTOTKILOSPROD = "0" & myDataReader(1).ToString
                        xTOTUNPROCESO = "0" & myDataReader(2).ToString
                        xTOTKILOSPROCESO = "0" & myDataReader(3).ToString
                        xTOTUNSCRAP = "0" & myDataReader(4).ToString
                        xTOTKILOSSCRAP = "0" & myDataReader(5).ToString
                        xPORCSCRAP = "0" & myDataReader(6).ToString
                        xTOTKILOSSPRUT = "0" & myDataReader(7).ToString
                        xPORCSPRUT = "0" & myDataReader(8).ToString
                        xTOTKILOSPURGA = "0" & myDataReader(9).ToString

                        txtTotunprod.Text = Format(xTOTUNPROD, xFormato)
                        txtTotkilosprod.Text = Format(xTOTKILOSPROD, xFormato)
                        txtTotunproceso.Text = Format(xTOTUNPROCESO, xFormato)
                        txtTotkilosproceso.Text = Format(xTOTKILOSPROCESO, xFormato)
                        txtTotunscrap.Text = Format(xTOTUNSCRAP, xFormato)
                        txtTotkilosscrap.Text = Format(xTOTKILOSSCRAP, xFormato)
                        txtPorscrap.Text = Format(xPORCSCRAP, xFormato)
                        txtTotkilossprut.Text = Format(xTOTKILOSSPRUT, xFormato)
                        txtPorsprut.Text = Format(xPORCSPRUT, xFormato)
                        txtTotkilospurga.Text = Format(xTOTKILOSPURGA, xFormato)

                        myDataReader.Close()
                    End If

                Catch ex As Exception
                    MessageBox.Show("Error Conexion :" & ex.Message, "DATOS TOTALES")
                End Try
                Qfup = Qfup & "   AND HPTOTAL.Fecha BETWEEN '" & StrFecIni & "' AND '" & StrFecFin & "' "

                Try
                    objCmd = New SqlCommand
                    objCmd.CommandType = CommandType.Text
                    objCmd.Connection = objCnnAmanco
                    objCmd.CommandText = Qfup
                    myDataReaderH = objCmd.ExecuteReader()
                    If myDataReaderH.Read() Then
                        xTotHorastrab = "0" & myDataReaderH(0).ToString
                        xTotHorasprog = "0" & myDataReaderH(1).ToString
                        xTotHorasmant = "0" & myDataReaderH(2).ToString
                        xTotHorassetu = "0" & myDataReaderH(3).ToString
                        xTotHorasotro = "0" & myDataReaderH(4).ToString

                        txtTotHorastrab.Text = Format(xTotHorastrab, xFormato)
                        txtTotHorasprog.Text = Format(xTotHorasprog, xFormato)
                        txtTotHorasmant.Text = Format(xTotHorasmant, xFormato)
                        txtTotHorassetu.Text = Format(xTotHorassetu, xFormato)
                        txtTotHorasotro.Text = Format(xTotHorasotro, xFormato)

                        myDataReaderH.Close()
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error Conexion :" & ex.Message, "DATOS TOTALES HORAS")
                End Try


            End If
            If txtEquipo.Text <> "*" Then
                Qd = Qd & "   AND PTYS.PuestoTrabajo like ('%" & txtEquipo.Text.Trim & "%') "
                Qd = Qd & "   AND PTYS.fecha_turno BETWEEN '" & StrFecIni & "' AND '" & StrFecFin & "' "
                Qd = Qd & "   ORDER BY PTYS.Fecha_Pesaje DESC, PTYS.Hora_Pesaje DESC"
                Qdg = Qd
                Try
                    objDa = New SqlDataAdapter(Qd, objCnnAmanco.ConnectionString)
                    objDs = New DataSet
                    objDa.Fill(objDs)
                    DGPPT.DataSource = objDs

                    xRegCount = objDs.Tables(0).Rows.Count
                    DGPPT.CaptionText = "Detalle Pesaje por ORDEN-MAQUINA             Registros: " & xRegCount

                Catch ex As Exception
                    MessageBox.Show("Error Conexion :" & ex.Message, "DATOS DETALLE PESAJES")
                End Try

                Qt = Qt & " AND PTYS.PuestoTrabajo like ('%" & txtEquipo.Text.Trim & "%') "
                Qt = Qt & " AND PTYS.fecha_turno BETWEEN '" & StrFecIni & "' AND '" & StrFecFin & "' "
                Qt = Qt & " GROUP BY  PTYS.PuestoTrabajo, PTE.Codigo, PTE.Descr, OP.Cantidad_Programada_Tramos "

                Try
                    objDa = New SqlDataAdapter(Qt, objCnnAmanco.ConnectionString)
                    objDs = New DataSet
                    objDa.Fill(objDs)
                    DGOP.DataSource = objDs

                    xRegCount = objDs.Tables(0).Rows.Count
                    DGOP.CaptionText = "Resumen pesaje por ORDEN-MAQUINA          Registros: " & xRegCount

                Catch ex As Exception
                    MessageBox.Show("Error Conexion :" & ex.Message, "DATOS RESUMEN PESAJE")
                End Try

                Qs = Qs & " AND PTYS.PuestoTrabajo like ('%" & txtEquipo.Text.Trim & "%') "
                Qs = Qs & " AND PTYS.fecha_turno BETWEEN '" & StrFecIni & "' AND '" & StrFecFin & "' "
                Qs = Qs & " GROUP BY TCS.codseccion, TCS.Desseccion  "

                Try
                    objDa = New SqlDataAdapter(Qs, objCnnAmanco.ConnectionString)
                    objDs = New DataSet
                    objDa.Fill(objDs)
                    DGSC.DataSource = objDs
                Catch ex As Exception
                    MessageBox.Show("Error Conexion :" & ex.Message, "DATOS RESUMEN SECCIONES")
                End Try

                Qtp = Qtp & "   AND PTYS.PuestoTrabajo like ('%" & txtEquipo.Text.Trim & "%') "
                Qtp = Qtp & "   AND PTYS.fecha_turno BETWEEN '" & StrFecIni & "' AND '" & StrFecFin & "' "

                Try
                    objCmd = New SqlCommand
                    objCmd.CommandType = CommandType.Text
                    objCmd.Connection = objCnnAmanco
                    objCmd.CommandText = Qtp
                    myDataReader = objCmd.ExecuteReader()

                    If myDataReader.Read() Then
                        xTOTUNPROD = "0" & myDataReader(0).ToString
                        xTOTKILOSPROD = "0" & myDataReader(1).ToString
                        xTOTUNPROCESO = "0" & myDataReader(2).ToString
                        xTOTKILOSPROCESO = "0" & myDataReader(3).ToString
                        xTOTUNSCRAP = "0" & myDataReader(4).ToString
                        xTOTKILOSSCRAP = "0" & myDataReader(5).ToString
                        xPORCSCRAP = "" & myDataReader(6).ToString
                        xTOTKILOSSPRUT = "0" & myDataReader(7).ToString
                        xPORCSPRUT = "" & myDataReader(8).ToString
                        xTOTKILOSPURGA = "0" & myDataReader(9).ToString

                        txtTotunprod.Text = Format(xTOTUNPROD, xFormato)
                        txtTotkilosprod.Text = Format(xTOTKILOSPROD, xFormato)
                        txtTotunproceso.Text = Format(xTOTUNPROCESO, xFormato)
                        txtTotkilosproceso.Text = Format(xTOTKILOSPROCESO, xFormato)
                        txtTotunscrap.Text = Format(xTOTUNSCRAP, xFormato)
                        txtTotkilosscrap.Text = Format(xTOTKILOSSCRAP, xFormato)
                        txtPorscrap.Text = Format(xPORCSCRAP, xFormato)
                        txtTotkilossprut.Text = Format(xTOTKILOSSPRUT, xFormato)
                        txtPorsprut.Text = Format(xPORCSPRUT, xFormato)
                        txtTotkilospurga.Text = Format(xTOTKILOSPURGA, xFormato)

                        myDataReader.Close()
                    End If

                Catch ex As Exception
                    MessageBox.Show("Error Conexion :" & ex.Message, "DATOS TOTALES")
                End Try
                Qfup = Qfup & "   AND HPTOTAL.PuestoTrabajo like ('%" & txtEquipo.Text.Trim & "%') "
                Qfup = Qfup & "   AND HPTOTAL.Fecha BETWEEN '" & StrFecIni & "' AND '" & StrFecFin & "' "

                Try
                    objCmd = New SqlCommand
                    objCmd.CommandType = CommandType.Text
                    objCmd.Connection = objCnnAmanco
                    objCmd.CommandText = Qfup
                    myDataReaderH = objCmd.ExecuteReader()
                    If myDataReaderH.Read() Then
                        xTotHorastrab = "0" & myDataReaderH(0).ToString
                        xTotHorasprog = "0" & myDataReaderH(1).ToString
                        xTotHorasmant = "0" & myDataReaderH(2).ToString
                        xTotHorassetu = "0" & myDataReaderH(3).ToString
                        xTotHorasotro = "0" & myDataReaderH(4).ToString

                        txtTotHorastrab.Text = Format(xTotHorastrab, xFormato)
                        txtTotHorasprog.Text = Format(xTotHorasprog, xFormato)
                        txtTotHorasmant.Text = Format(xTotHorasmant, xFormato)
                        txtTotHorassetu.Text = Format(xTotHorassetu, xFormato)
                        txtTotHorasotro.Text = Format(xTotHorasotro, xFormato)

                        myDataReaderH.Close()
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error Conexion :" & ex.Message, "DATOS TOTALES HORAS")
                End Try
            End If
        End If
    End Sub
End Class