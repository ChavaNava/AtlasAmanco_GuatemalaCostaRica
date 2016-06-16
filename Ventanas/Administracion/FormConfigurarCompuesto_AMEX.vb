Imports Atlas.Accesos.CLVarGlobales
Imports SQL_DATA
Public Class FormConfigurarCompuesto_AMEX
    Dim SumaCompuestos As Integer

    Private Sub FormConfigurarCompuesto_CR_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        StatusConfiCompuesto = ""

        LimpiaObjetos()

        ValPublic_CompuestoVirgen = ""
        ValPublic_ReproConsumo = ""
        ValPublic_Ccompuesto1 = ""
        ValPublic_Ccompuesto2 = ""
        ValPublic_PorcentajeCom1 = 0
        ValPublic_PorcentajeCom2 = 0


        CReproConsumo.Enabled = False
        Ccompuesto1.Enabled = False
        TPorcentajeCom1.Enabled = False
        Ccompuesto2.Enabled = False
        TPorcentajeCom2.Enabled = False
        CcompuestoVirgen.Enabled = False


        CB2.Checked = False
        CB3.Checked = False
        CB1.Checked = False




    End Sub

    Private Sub LimpiaObjetos()

        TPorcentajeCom1.Text = ""   'Porcentaje de compuesto 1
        TPorcentajeCom2.Text = ""   'Porcentaje de compuesto 2
        CReproConsumo.Text = ""     'Combo Reproceso 
        Ccompuesto1.Text = ""       'Combo Compuesto Mezcla  1 
        Ccompuesto2.Text = ""       'Combo Compuesto Mezcla  2 
        CcompuestoVirgen.Text = ""  'Combo Compuesto Virgen    


    End Sub


    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB2.CheckedChanged
        If StrProces <> "Iny" Then

            If CB2.Checked = False Then
                LimpiaObjetos()
                Exit Sub

            Else
                CB1.Checked = False
                CB3.Checked = False

                CReproConsumo.Enabled = True

                Dim NDataSet13 As New DataSet
                QryCombo = ""
                QryCombo = "select ComExt_ComCodigo, ComExt_ComDescr, ComExt_ComCodigo + ComExt_ComDescr as Compuesto From CompuestoExtrusion "
                QryCombo = QryCombo & "Where ComExt_PT_Centro = '" & SessionUser._sCentro.Trim & "' "
                If Modulo = "SCE" Then
                    QryCombo = QryCombo & "And ComExt_PT_Codigo In ('" & StrProducto.Trim & "', '0') "
                    QryCombo = QryCombo & "And ComExt_ComClase In (2, 5) "
                Else
                    QryCombo = QryCombo & "And ComExt_PT_Codigo = '" & StrProducto.Trim & "' "
                    QryCombo = QryCombo & "And ComExt_ComClase = 2 "
                End If
                Combo(QryCombo)
                NDataSet13 = DataSetCombo.Copy
                CReproConsumo.DataSource = NDataSet13.Tables(0)
                CReproConsumo.DisplayMember = "Compuesto"
                CReproConsumo.ValueMember = "ComExt_ComCodigo"


                '  -------------------------------- Inicio : Bloqueo  de objetos --------------------------------
                '-----   RadioButton2   -----

                Ccompuesto1.Text = ""
                Ccompuesto1.Enabled = False
                TPorcentajeCom1.Enabled = False

                Ccompuesto2.Text = ""
                Ccompuesto2.Enabled = False
                TPorcentajeCom2.Enabled = False

                '-----   RadioButton3   -----

                CcompuestoVirgen.Text = ""
                CcompuestoVirgen.Enabled = False

                ' --------------------------------  Fin : Bloqueo  de objetos --------------------------------
            End If

        ElseIf StrProces = "Iny" Then

            If CB2.Checked = False Then
                LimpiaObjetos()
                Exit Sub

            Else
                CB1.Checked = False
                CB3.Checked = False

                CReproConsumo.Enabled = True

                Dim NDataSet13 As New DataSet
                QryCombo = ""
                QryCombo = "select CodComp,DesComp, CodComp + DesComp as DescCod From CompuestoInyeccion "
                QryCombo = QryCombo & "Where Centro = '" & SessionUser._sCentro.Trim & "' And CodPTI = '" & StrProducto.Trim & "' And Clase = 2"
                Combo(QryCombo)
                NDataSet13 = DataSetCombo.Copy
                CReproConsumo.DataSource = NDataSet13.Tables(0)
                CReproConsumo.DisplayMember = "DescCod"
                CReproConsumo.ValueMember = "CodComp"


                '  -------------------------------- Inicio : Bloqueo  de objetos --------------------------------
                '-----   RadioButton2   -----

                Ccompuesto1.Text = ""
                Ccompuesto1.Enabled = False
                TPorcentajeCom1.Enabled = False

                Ccompuesto2.Text = ""
                Ccompuesto2.Enabled = False
                TPorcentajeCom2.Enabled = False

                '-----   RadioButton3   -----

                CcompuestoVirgen.Text = ""
                CcompuestoVirgen.Enabled = False

                ' --------------------------------  Fin : Bloqueo  de objetos --------------------------------
            End If

        End If

    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB3.CheckedChanged

        If StrProces <> "Iny" Then

            If CB3.Checked = False Then
                LimpiaObjetos()
                Exit Sub

            Else
                CB1.Checked = False
                CB2.Checked = False


                Dim NDataSet11 As New DataSet
                Dim NDataSet12 As New DataSet

                QryCombo = ""
                QryCombo = "select Codigo_Compuesto,Clave_Descr_com From ComExtrusion "
                QryCombo = QryCombo & "Where Centro = '" & SessionUser._sCentro.Trim & "' And Codigo_PT = '" & StrProducto.Trim & "'"
                Combo(QryCombo)
                NDataSet11 = DataSetCombo.Copy
                NDataSet12 = DataSetCombo.Copy

                Ccompuesto1.DataSource = NDataSet11.Tables(0)
                Ccompuesto1.DisplayMember = "Clave_Descr_com"
                Ccompuesto1.ValueMember = "Codigo_Compuesto"

                Ccompuesto2.DataSource = NDataSet12.Tables(0)
                Ccompuesto2.DisplayMember = "Clave_Descr_com"
                Ccompuesto2.ValueMember = "Codigo_Compuesto"


                '-----   Mezcla   -----
                Ccompuesto1.Enabled = True
                TPorcentajeCom1.Enabled = True
                Ccompuesto2.Enabled = True
                TPorcentajeCom2.Enabled = True


                '-----   Virgen   -----
                CcompuestoVirgen.Text = ""
                CcompuestoVirgen.Enabled = False


                '-----   Reproceso   -----
                CReproConsumo.Enabled = False ' RadioButton1

            End If

        ElseIf StrProces = "Iny" Then

            If CB3.Checked = False Then
                LimpiaObjetos()
                Exit Sub

            Else
                CB1.Checked = False
                CB2.Checked = False


                Dim NDataSet11 As New DataSet
                Dim NDataSet12 As New DataSet

                QryCombo = ""
                QryCombo = "select CodComp,DesComp From CompuestoInyeccion "
                QryCombo = QryCombo & "Where Centro = '" & SessionUser._sCentro.Trim & "' And CodPTI = '" & StrProducto.Trim & "'"
                Combo(QryCombo)
                NDataSet11 = DataSetCombo.Copy
                NDataSet12 = DataSetCombo.Copy

                Ccompuesto1.DataSource = NDataSet11.Tables(0)
                Ccompuesto1.DisplayMember = "DesComp"
                Ccompuesto1.ValueMember = "CodComp"

                Ccompuesto2.DataSource = NDataSet12.Tables(0)
                Ccompuesto2.DisplayMember = "DesComp"
                Ccompuesto2.ValueMember = "CodComp"


                '-----   Mezcla   -----
                Ccompuesto1.Enabled = True
                TPorcentajeCom1.Enabled = True
                Ccompuesto2.Enabled = True
                TPorcentajeCom2.Enabled = True


                '-----   Virgen   -----
                CcompuestoVirgen.Text = ""
                CcompuestoVirgen.Enabled = False


                '-----   Reproceso   -----
                CReproConsumo.Enabled = False ' RadioButton1

            End If

        End If

    End Sub

    Private Sub BSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSalir.Click

        Close()

    End Sub

    Private Sub BGuardadConfiguracion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BGuardadConfiguracion.Click
        If StrProces <> "Iny" Then

            If CB2.Checked = True Then
                ValPublic_ReproConsumo = CReproConsumo.SelectedValue.ToString
            End If

            If CB3.Checked = True Then
                ValPublic_Ccompuesto1 = Ccompuesto1.SelectedValue.ToString
                ValPublic_Ccompuesto2 = Ccompuesto2.SelectedValue.ToString
                ValPublic_PorcentajeCom1 = Val(TPorcentajeCom1.Text.Trim)
                ValPublic_PorcentajeCom2 = Val(TPorcentajeCom2.Text.Trim)
                SumaCompuestos = ValPublic_PorcentajeCom1 + ValPublic_PorcentajeCom2
                If SumaCompuestos = 100 Then
                    Label4.Text = SumaCompuestos
                Else

                    MsgBox("La Configuración indicada es incorrecta", MsgBoxStyle.Critical)
                    TPorcentajeCom1.Text = ""
                    TPorcentajeCom2.Text = ""
                    Exit Sub
                End If

            End If

            If CB1.Checked = True Then
                ValPublic_CompuestoVirgen = CcompuestoVirgen.SelectedValue.ToString
            End If

            StatusConfiCompuesto = "1"

        ElseIf StrProces = "Iny" Then

            If CB2.Checked = True Then
                ValPublic_ReproConsumo = CReproConsumo.SelectedValue.ToString
            End If

            If CB3.Checked = True Then
                ValPublic_Ccompuesto1 = Ccompuesto1.SelectedValue.ToString
                ValPublic_Ccompuesto2 = Ccompuesto2.SelectedValue.ToString
                ValPublic_PorcentajeCom1 = Val(TPorcentajeCom1.Text.Trim)
                ValPublic_PorcentajeCom2 = Val(TPorcentajeCom2.Text.Trim)
                SumaCompuestos = ValPublic_PorcentajeCom1 + ValPublic_PorcentajeCom2
                If SumaCompuestos = 100 Then
                    Label4.Text = SumaCompuestos
                Else

                    MsgBox("La Configuración indicada es incorrecta", MsgBoxStyle.Critical)
                    TPorcentajeCom1.Text = ""
                    TPorcentajeCom2.Text = ""
                    Exit Sub
                End If

            End If

            If CB1.Checked = True Then
                ValPublic_CompuestoVirgen = CcompuestoVirgen.SelectedValue.ToString
            End If

            StatusConfiCompuesto = "1"
        End If
        Close()
    End Sub


    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB1.CheckedChanged
        If StrProces <> "Iny" Then

            If CB1.Checked = False Then
                LimpiaObjetos()
                Exit Sub
            Else
                CB3.Checked = False
                CB2.Checked = False


                CcompuestoVirgen.Enabled = True

                Dim NDataSet10 As New DataSet
                QryCombo = ""
                QryCombo = "select Codigo_Compuesto,Clave_Descr_com From ComExtrusion "
                QryCombo = QryCombo & "Where Centro = '" & SessionUser._sCentro.Trim & "' "
                If Modulo = "SCE" Then
                    QryCombo = QryCombo & "And Codigo_PT In ('" & StrProducto.Trim & "', '0') "
                    QryCombo = QryCombo & "And ComExt_ComClase In (1, 4) "
                Else
                    QryCombo = QryCombo & "And Codigo_PT = '" & StrProducto.Trim & "' "
                    QryCombo = QryCombo & "And ComExt_ComClase = 1 "
                End If
                Combo(QryCombo)
                NDataSet10 = DataSetCombo.Copy
                CcompuestoVirgen.DataSource = NDataSet10.Tables(0)
                CcompuestoVirgen.DisplayMember = "Clave_Descr_com"
                CcompuestoVirgen.ValueMember = "Codigo_Compuesto"


                '-----   Reproceso   -----

                CReproConsumo.Enabled = False ' RadioButton1

                '-----   Mezcla   -----

                Ccompuesto1.Enabled = False
                TPorcentajeCom1.Enabled = False
                Ccompuesto2.Enabled = False
                TPorcentajeCom2.Enabled = False
            End If

        ElseIf StrProces = "Iny" Then

            If CB1.Checked = False Then
                LimpiaObjetos()
                Exit Sub
            Else
                CB3.Checked = False
                CB2.Checked = False


                CcompuestoVirgen.Enabled = True

                Dim NDataSet10 As New DataSet
                QryCombo = ""
                QryCombo = "select CodComp,DesComp, CodComp + DesComp as DescCod From CompuestoInyeccion "
                QryCombo = QryCombo & "Where Centro = '" & SessionUser._sCentro.Trim & "' And CodPTI = '" & StrProducto.Trim & "' And Clase = 1"
                Combo(QryCombo)
                NDataSet10 = DataSetCombo.Copy
                CcompuestoVirgen.DataSource = NDataSet10.Tables(0)
                CcompuestoVirgen.DisplayMember = "DescCod"
                CcompuestoVirgen.ValueMember = "CodComp"


                '-----   Reproceso   -----

                CReproConsumo.Enabled = False ' RadioButton1

                '-----   Mezcla   -----

                Ccompuesto1.Enabled = False
                TPorcentajeCom1.Enabled = False
                Ccompuesto2.Enabled = False
                TPorcentajeCom2.Enabled = False
            End If
        End If
    End Sub

    Private Sub FormConfigurarCompuesto_CR_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        CcompuestoVirgen.DataSource = Nothing
        Modulo = ""
    End Sub
End Class