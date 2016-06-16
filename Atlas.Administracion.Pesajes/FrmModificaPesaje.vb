Imports SQL_DATA
Imports Atlas.Accesos
Imports Utili_Generales
Imports Atlas.Accesos.CLVarGlobales
Imports Utili_Generales.ValueText
Public Class FrmModificaPesaje

#Region "Variables"
    Dim Str_FI As String        'Fecha inicio consulta
    Dim Str_FF As String        'Fecha fin consulta
    Dim TipoProd As String
    'Variables para compuestos
    Dim Comp_1 As String = "0"
    Dim Comp_2 As String = "0"
    'Variables filtros consulta
    Dim cOrden As String
    Dim cFolio As String
    Dim cTurno As String

    Dim _errores As ValidationError()
    Dim _objetoSeleccionado As New ObjetosSeleccionados

#End Region

#Region "Eventos"

    Private Sub FrmModificaPesaje_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Parametrizacion.Parametrized_Form(Me)
        Catalogo_Turnos.Combo_Turnos(Consulta.CB_Turno, SessionUser._sCentro.Trim, SessionUser._sAlias.Trim)
        TSI_Cancela.Enabled = False
        TSI_Guarda.Enabled = False
        TSI_Modifica.Enabled = True
        PModifica.Enabled = False
        CargaGrid()
    End Sub

    Private Sub TSI_Cerrar_Click(sender As System.Object, e As System.EventArgs) Handles TSI_Cerrar.Click
        Close()
    End Sub

    Private Sub consulta_ButtonClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Consulta.ButtonClick
        CargaGrid()
    End Sub

    Private Sub TSI_Modifica_Click(sender As System.Object, e As System.EventArgs) Handles TSI_Modifica.Click
        Accion = "Modificar"
        PModifica.Enabled = True
        TSI_Cancela.Enabled = True
        TSI_Guarda.Enabled = True
        If TipoProd = "S" Then
            TtramosNoti.ReadOnly = True
        Else
            TtramosNoti.ReadOnly = False
        End If
    End Sub

    Private Sub TSI_Cancela_Click(sender As System.Object, e As System.EventArgs) Handles TSI_Cancela.Click
        CargaGrid()
        PModifica.Enabled = False
        TSI_Modifica.Enabled = True
        TSI_Cancela.Enabled = False
        TSI_Guarda.Enabled = False
    End Sub

    Private Sub TSI_Guarda_Click(sender As System.Object, e As System.EventArgs) Handles TSI_Guarda.Click
        If ValidateInfo() Then
            Try
                If Proceso_Extrusion.Modifica(SessionUser._sAlias.Trim) Then

                End If

                CargaGrid()
            Catch ex As Exception

            End Try
        Else
            Dim strErores As String = ""
            strErores = _errores.Aggregate(strErores, Function(current, val) current + (val.Message + Environment.NewLine))
            MensajeBox.Mostrar(strErores, "Verificar", MensajeBox.TipoMensaje.Exclamation)
        End If
    End Sub
    Private Sub Usr_DGV1_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Usr_DGV1.CurrentCellChanged
        Dim oldRowIndex As Object
        oldRowIndex = Usr_DGV1.DGV1.CurrentCellAddress.Y
        If oldRowIndex <> -1 Then
            PModifica.Enabled = False
            TSI_Modifica.Enabled = True
            TSI_Cancela.Enabled = False
            TSI_Guarda.Enabled = False
            Try
                Dim Fila_Seleccionada As Integer = Usr_DGV1.DGV1.CurrentCell.RowIndex
                Modifica_Pesajes.mFolio = Usr_DGV1.DGV1.Rows(Fila_Seleccionada).Cells(0).Value.ToString
                Modifica_Pesajes.mTipoProduccion = Usr_DGV1.DGV1.Rows(Fila_Seleccionada).Cells(1).Value.ToString
                Modifica_Pesajes.mOrdenFabricacion = Usr_DGV1.DGV1.Rows(Fila_Seleccionada).Cells(2).Value.ToString
                Modifica_Pesajes.mUnidades = Usr_DGV1.DGV1.Rows(Fila_Seleccionada).Cells(3).Value.ToString
                Modifica_Pesajes.mCodigoProducto = Usr_DGV1.DGV1.Rows(Fila_Seleccionada).Cells(4).Value.ToString
                Modifica_Pesajes.mProducto = Usr_DGV1.DGV1.Rows(Fila_Seleccionada).Cells(5).Value.ToString
                Modifica_Pesajes.mFechaPesaje = Usr_DGV1.DGV1.Rows(Fila_Seleccionada).Cells(6).Value.ToString
                Modifica_Pesajes.mPesoBruto = Usr_DGV1.DGV1.Rows(Fila_Seleccionada).Cells(7).Value.ToString
                Modifica_Pesajes.mPesoTara = Usr_DGV1.DGV1.Rows(Fila_Seleccionada).Cells(8).Value.ToString
                Modifica_Pesajes.mPesoNeto = Usr_DGV1.DGV1.Rows(Fila_Seleccionada).Cells(9).Value.ToString
                Modifica_Pesajes.mPesoEmpaques = Usr_DGV1.DGV1.Rows(Fila_Seleccionada).Cells(10).Value.ToString
                Modifica_Pesajes.mPesoNetoMerma = Usr_DGV1.DGV1.Rows(Fila_Seleccionada).Cells(11).Value.ToString
                Modifica_Pesajes.mCompuesto1 = Usr_DGV1.DGV1.Rows(Fila_Seleccionada).Cells(12).Value.ToString
                Modifica_Pesajes.mCDescripcion1 = Usr_DGV1.DGV1.Rows(Fila_Seleccionada).Cells(13).Value.ToString
                Modifica_Pesajes.mPorcentaje1 = Usr_DGV1.DGV1.Rows(Fila_Seleccionada).Cells(14).Value.ToString
                Modifica_Pesajes.mCantidad1 = Usr_DGV1.DGV1.Rows(Fila_Seleccionada).Cells(15).Value.ToString
                Modifica_Pesajes.mCompuesto2 = Usr_DGV1.DGV1.Rows(Fila_Seleccionada).Cells(16).Value.ToString
                Modifica_Pesajes.mCDescripcion2 = Usr_DGV1.DGV1.Rows(Fila_Seleccionada).Cells(17).Value.ToString
                Modifica_Pesajes.mPorcentaje2 = Usr_DGV1.DGV1.Rows(Fila_Seleccionada).Cells(18).Value.ToString
                Modifica_Pesajes.mCantidad2 = Usr_DGV1.DGV1.Rows(Fila_Seleccionada).Cells(19).Value.ToString
                Modifica_Pesajes.mBascula = Usr_DGV1.DGV1.Rows(Fila_Seleccionada).Cells(20).Value.ToString
                Modifica_Pesajes.mRack = Usr_DGV1.DGV1.Rows(Fila_Seleccionada).Cells(21).Value.ToString
                Modifica_Pesajes.mUsuario = Usr_DGV1.DGV1.Rows(Fila_Seleccionada).Cells(22).Value.ToString
                Modifica_Pesajes.mTurno = Usr_DGV1.DGV1.Rows(Fila_Seleccionada).Cells(23).Value.ToString
                Modifica_Pesajes.mDocumento = Usr_DGV1.DGV1.Rows(Fila_Seleccionada).Cells(24).Value.ToString
                Modifica_Pesajes.mConsecutivo = Usr_DGV1.DGV1.Rows(Fila_Seleccionada).Cells(25).Value.ToString
                Modifica_Pesajes.mSobrePeso = Usr_DGV1.DGV1.Rows(Fila_Seleccionada).Cells(26).Value.ToString
                Modifica_Pesajes.mPuestoTrabajo = Usr_DGV1.DGV1.Rows(Fila_Seleccionada).Cells(27).Value.ToString
                Modifica_Pesajes.mNotifica = Usr_DGV1.DGV1.Rows(Fila_Seleccionada).Cells(28).Value.ToString
                Modifica_Pesajes.mPNMerma = Usr_DGV1.DGV1.Rows(Fila_Seleccionada).Cells(29).Value.ToString
                TipoProd = ""
                Select Case Modifica_Pesajes._mTipoProduccion
                    Case Is = "Scrap"
                        TipoProd = "S"

                    Case Is = "Terminado"
                        TipoProd = "T"
                End Select
                SetInfoPesaje()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "VENTANA DE ERROR * * * ")
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub TPC1_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TPC1.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TPC1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TPC1.TextChanged
        Try
            Dim V1, V2, TPNM As Decimal
            If TPC1.Text.Trim = 100 Then
                TPNM = TPesoNeto.Text
                CBC2.DataSource = Nothing
                CBC2.Text = ""
                Comp_2 = "0"
                TPC2.Text = 0
                CBC2.Enabled = False
                TPC2.Enabled = False
                V1 = (TPNM * (TPC1.Text / 100))
                V2 = 0
                TKC1.Text = V1
                TKC2.Text = V2
            ElseIf TPC1.Text.Trim > 100 Then
                MessageBox.Show("No se permiten valores mayores al 100%")
                TPC1.Text = "100"
            ElseIf TPC1.Text <= 0 Then
                TPC2.Text = 0
            Else
                CBC2.Enabled = True
                TPC2.Enabled = True
                TPNM = TPesoNeto.Text
                Catalogo_Compuestos.CB_Compuesto2(CBC2, SessionUser._sAlias.Trim, SessionUser._sCentro.Trim, TcodPt.Text.Trim.Trim, EXTINY)
                TPC2.Text = 100 - Val(TPC1.Text)
                V1 = (TPNM * (TPC1.Text / 100))
                V2 = (TPNM - (TPNM * (TPC1.Text / 100)))
                TKC1.Text = V1
                TKC2.Text = V2
                Comp_2 = CBC2.SelectedValue
            End If
            If TPC1.Text.Trim = 0 Then
                MessageBox.Show("No se permite valor de 0% o negativos ")
                TPC1.Text = "100"
            End If
        Catch ex As Exception
            TPC1.Text = "100"
        End Try
    End Sub

    Private Sub CBC1_Click(sender As System.Object, e As System.EventArgs) Handles CBC1.Click
        Catalogo_Compuestos.CB_Compuesto1(CBC1, SessionUser._sAlias.Trim, SessionUser._sCentro.Trim, TcodPt.Text.Trim, EXTINY, TipoProd, True)
    End Sub

    Private Sub TtramosNoti_TextChanged(sender As System.Object, e As System.EventArgs) Handles TtramosNoti.TextChanged
        TCantEmp.Text = TtramosNoti.Text
    End Sub

#End Region

#Region "Metodos"
    Public Sub CargaGrid()
        Str_FI = Consulta.DTP_FI.Text.Trim
        Str_FF = Consulta.DTP_FF.Text.Trim
        Usr_DGV1.IdEstatus = 28
        cOrden = Consulta.TOrd.Text.Trim
        cFolio = Consulta.TFol.Text.Trim
        If Consulta.CB_Turno.Text = "" Then
            cTurno = " "
        Else
            cTurno = Consulta.CB_Turno.SelectedValue
        End If
        Consulta_Pesajes.Pesajes(Usr_DGV1.DGV1, SessionUser._sAlias.Trim, SessionUser._sCentro.Trim, Str_FI, Str_FF, cOrden, cFolio, cTurno, Seccion.Trim)
    End Sub

    Public Sub SetInfoPesaje()
        TOrden.Text = Modifica_Pesajes._mOrdenFabricacion
        TcodPt.Text = Modifica_Pesajes._mCodigoProducto
        TTP.Text = Modifica_Pesajes._mTipoProduccion
        TFolioAtlas.Text = Modifica_Pesajes._mFolio
        TtramosNoti.Text = Modifica_Pesajes._mUnidades
        TPesoBruto.Text = Modifica_Pesajes._mPesoBruto
        TPesoRack.Text = Modifica_Pesajes._mPesoTara
        TPEmp.Text = Modifica_Pesajes._mPesoEmpaques
        TPesoNeto.Text = Modifica_Pesajes._mPesoNeto
        'TPesoNetoMerma.Text = Modifica_Pesajes._mPNMerma
        CBC1.Text = Modifica_Pesajes._mCompuesto1 + " " + Modifica_Pesajes._mCDescripcion1
        TKC1.Text = Modifica_Pesajes._mCantidad1
        TPC1.Text = Modifica_Pesajes._mPorcentaje1
        CBC2.Text = Modifica_Pesajes._mCompuesto2 + " " + Modifica_Pesajes._mCDescripcion2
        TKC2.Text = Modifica_Pesajes._mCantidad2
        TPC2.Text = Modifica_Pesajes._mPorcentaje2
        TCantEmp.Text = Modifica_Pesajes._mUnidades
        TSBPeso.Text = Modifica_Pesajes._mSobrePeso
    End Sub

    Private Function ValidateInfo() As Boolean
        Dim errs As New List(Of ValidationError)

        'Textos 
        ObjetosSeleccionados.modCentro = SessionUser._sCentro.Trim
        ObjetosSeleccionados.modFolio = Modifica_Pesajes._mFolio
        ObjetosSeleccionados.modOrden = Modifica_Pesajes._mOrdenFabricacion


        If TtramosNoti.Text = "" Then
            If TipoProd = "T" Then
                errs.Add(New ValidationError("Este campo no debe ir en 0"))
                Return False
            End If
        Else
            ObjetosSeleccionados.modTramos = TtramosNoti.Text

        End If

        If TPesoBruto.Text = "0" Then
            errs.Add(New ValidationError("Este campo no debe ir en 0"))
            Return False
        Else
            ObjetosSeleccionados.modPB = TPesoBruto.Text
        End If

        If TPesoRack.Text = "0" Then
            errs.Add(New ValidationError("Este campo no debe ir en 0"))
            Return False
        Else
            ObjetosSeleccionados.modPT = TPesoRack.Text
        End If

        If TPesoNeto.Text = "0" Then
            errs.Add(New ValidationError("Este campo no debe ir en 0"))
            Return False
        Else
            ObjetosSeleccionados.modPN = TPesoNeto.Text
        End If

        If CBC1.SelectedValue = Nothing Then
            ObjetosSeleccionados.modComp1 = Modifica_Pesajes._mCompuesto1
        Else
            ObjetosSeleccionados.modComp1 = CBC1.SelectedValue
        End If

        ObjetosSeleccionados.modPorc1 = TPC1.Text
        ObjetosSeleccionados.modCant1 = TKC1.Text

        If CBC2.SelectedValue Is Nothing Then
            ObjetosSeleccionados.modComp2 = Modifica_Pesajes._mCompuesto2
        Else
            ObjetosSeleccionados.modComp2 = CBC2.SelectedValue
        End If

        ObjetosSeleccionados.modPorc2 = TPC2.Text
        ObjetosSeleccionados.modCant2 = TKC2.Text
        ObjetosSeleccionados.modArea = TipoProd

        If errs.Any Then
            _errores = errs.ToArray()
            Return False
        Else
            _errores = Nothing
            Return True
        End If

    End Function

#End Region

    Private Sub TPesoBruto_TextChanged(sender As System.Object, e As System.EventArgs) Handles TPesoBruto.TextChanged
        If Accion = "Modificar" Then
            Dim TPB As Decimal = TPesoBruto.Text
            Dim TPT As Decimal = TPesoRack.Text
            Dim TPE As Decimal = TPEmp.Text
            Dim TPNM As Decimal = TPesoNeto.Text
            Dim TK1, TK2 As Decimal
            TPesoNeto.Text = (TPB - (TPT + TPE))
            TK1 = (TPesoNeto.Text * (TPC1.Text / 100))
            TKC1.Text = TK1
            TK2 = (TPesoNeto.Text - (TPesoNeto.Text * (TPC1.Text / 100)))
            TKC2.Text = TK2
        End If
    End Sub

    Private Sub TPesoRack_TextChanged(sender As System.Object, e As System.EventArgs) Handles TPesoRack.TextChanged
        If Accion = "Modificar" Then
            Dim TPB As Decimal = TPesoBruto.Text
            Dim TPT As Decimal = TPesoRack.Text
            Dim TPE As Decimal = TPEmp.Text
            Dim TPNM As Decimal = TPesoNeto.Text
            TPesoNeto.Text = (TPB - (TPT + TPE))
            TKC1.Text = (TPNM * (TPC1.Text / 100))
            TKC2.Text = (TPNM - (TPNM * (TPC1.Text / 100)))
        End If
    End Sub
End Class
