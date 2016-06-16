Imports System.Configuration
Imports System.Data.SqlClient
Imports Utili_Generales
Imports Atlas.Accesos.CLVarGlobales
Imports SQL_DATA
Public Class FrmAdminDelTPERIny
    Dim Status_Notif As String
    Dim ODF As String
    Dim folio As String
    Dim Notif As String
    Dim xAREA As String
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Close()
    End Sub

    Private Sub CB2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB2.CheckedChanged
        If CB2.Checked = True Then
            CB3.Enabled = False
            CB4.Enabled = False
            CB5.Enabled = True
            lblODF.Visible = True
            lblEQUIPO.Visible = False
            TxtOrdProd.Visible = True
            txtEquipo.Visible = False
            BtnConsulta.Visible = True
        ElseIf CB2.Checked = False Then
            CB3.Enabled = True
            CB4.Enabled = True
            CB5.Checked = False
            CB5.Enabled = False
            lblODF.Visible = False
            lblEQUIPO.Visible = False
            TxtOrdProd.Visible = False
            txtEquipo.Visible = False
            TxtOrdProd.Text = "*"
            BtnConsulta.Visible = False
            DGHP.DataSource = Nothing
            DGRHP.DataSource = Nothing
            DGDHP.DataSource = Nothing
        End If
    End Sub

    Private Sub FrmAdminPPT_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        CB2.Checked = False
        CB3.Checked = False
        CB4.Checked = False
        CB5.Checked = False
        TxtOrdProd.Text = "*"
    End Sub

    Private Sub CB3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB3.CheckedChanged
        If CB3.Checked = True Then
            CB2.Enabled = False
            CB4.Enabled = False
            CB5.Enabled = True
            lblPeriodo.Visible = True
            DTP1.Visible = True
            DTP2.Visible = True
            lblODF.Visible = True
            lblEQUIPO.Visible = False
            TxtOrdProd.Visible = True
            txtEquipo.Visible = False

            BtnConsulta.Visible = True
        Else
            CB2.Enabled = True
            CB4.Enabled = True
            CB5.Enabled = False
            lblPeriodo.Visible = False
            DTP1.Visible = False
            DTP2.Visible = False
            lblODF.Visible = False
            lblEQUIPO.Visible = False
            TxtOrdProd.Visible = False
            TxtOrdProd.Text = "*"
            txtEquipo.Visible = False
            txtEquipo.Text = "*"

            BtnConsulta.Visible = False
            DGHP.DataSource = Nothing
            DGRHP.DataSource = Nothing
            DGDHP.DataSource = Nothing
            CB5.Checked = False
            CB5.Enabled = False
        End If
    End Sub
    Private Sub CB4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB4.CheckedChanged
        If CB4.Checked = True Then
            CB2.Enabled = False
            CB3.Enabled = False
            CB5.Enabled = True
            lblPeriodo.Visible = True
            DTP1.Visible = True
            DTP2.Visible = True
            lblODF.Visible = False
            TxtOrdProd.Visible = False
            lblEQUIPO.Visible = True
            txtEquipo.Visible = True

            BtnConsulta.Visible = True
        Else
            CB2.Enabled = True
            CB3.Enabled = True
            CB5.Enabled = False
            lblPeriodo.Visible = False
            DTP1.Visible = False
            DTP2.Visible = False
            lblODF.Visible = False
            TxtOrdProd.Visible = False
            TxtOrdProd.Text = "*"
            lblEQUIPO.Visible = False
            txtEquipo.Visible = False
            txtEquipo.Text = "*"
            BtnConsulta.Visible = False
            DGHP.DataSource = Nothing
            DGRHP.DataSource = Nothing
            DGDHP.DataSource = Nothing
        End If
    End Sub
    Private Sub CB5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB5.CheckedChanged
        If CB5.Checked = True Then
            GBNotif.Visible = True
        Else
            GBNotif.Visible = False
            TxtODF.Text = ""
            TxtPtotrabajo.Text = ""
            TxtFecha.Text = ""
            txtUKID.Text = ""
        End If
    End Sub

    Private Sub BtnConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConsulta.Click
        Consultar()
    End Sub

    Private Sub Consultar()

        Dim StrFecIni As String
        Dim StrFecFin As String
        Dim StrOrdProd As String
        Dim Qd As String = ""
        Dim Qt As String = ""
        Dim Qde As String = ""
        Dim OPselec As String = ""
        Dim xDias As Integer

        StrOrdProd = TxtOrdProd.Text.Trim
        StrFecIni = DTP1.Text.Trim
        StrFecFin = DTP2.Text.Trim
        xDias = Val(DTP2.Value) - Val(DTP1.Value) + 1
        TxtODF.Text = ""
        TxtPtotrabajo.Text = ""
        TxtFecha.Text = ""
        txtUKID.Text = ""

        Dim xGrupos As String = ""

        Qd = " SELECT THP.ordenProd ORDEN, THP.PuestoTrabajo EQUIPO, THP.HREPORTADAS, THP.HPARO, THP.CodCausa CAUSA, "
        Qd = Qd & " CCC.DesCausa DESCRIPCION, THP.fecha FECHA_TURNO, THP.fechareg FECHA_REGISTRO, THP.usuarioreg REGISTRADO_POR, THP.turno TURNO, THP.ukid UKID"

        Qd = Qd & " FROM (((SELECT Centro, ordenProd, fecha, turno, PuestoTrabajo, CodCausa, horasparo as HREPORTADAS, 0 HPARO, fechareg, horareg, usuarioreg, ukid FROM " & SessionUser._sCentro.Trim & "_HorasParo WHERE CodCausa='0000' and status<>'9') "
        Qd = Qd & " UNION ALL (SELECT Centro, ordenProd, fecha, turno, PuestoTrabajo, CodCausa, 0 as HREPORTADAS, horasparo HPARO, fechareg, horareg, usuarioreg, ukid FROM " & SessionUser._sCentro.Trim & "_HorasParo WHERE CodCausa<>'0000' and status<>'9')) THP "

        Qd = Qd & " INNER JOIN " & SessionUser._sCentro.Trim & "_OrdenProduccion OP "
        Qd = Qd & " ON THP.Ordenprod = OP.Orden_Produccion ) INNER JOIN MCPC_EquipoBasico EB ON THP.centro = EB.Planta AND THP.PuestoTrabajo = EB.Equipo_basico "
        Qd = Qd & " INNER JOIN ProductoTerminadoInyeccion PTE ON PTE.CENTRO= THP.centro and PTE.Codigo = OP.Producto "
        Qd = Qd & " INNER JOIN CatCausas CCC ON CCC.Centro=THP.Centro AND CCC.grpprod=PTE.grpprod AND CCC.CodCausa=THP.CodCausa "
        Qd = Qd & " WHERE THP.Centro = '" & SessionUser._sCentro.Trim & "'"
        Qd = Qd & " AND  CCC.Tipocausa='HP' "

        Qt = " SELECT THP.PuestoTrabajo EQUIPO, (24*" & xDias & ") H_MAQUINA, sum(THP.HREPORTADAS) H_REPORTADAS, sum(THP.HPARO) H_PARO, ((24*" & xDias & ")-sum(THP.HREPORTADAS)-sum(THP.HPARO)) Variacion "
        Qt = Qt & " FROM (((SELECT Centro, ordenProd, fecha, turno, PuestoTrabajo, CodCausa, horasparo as HREPORTADAS, 0 HPARO, fechareg, horareg, usuarioreg, ukid FROM " & SessionUser._sCentro.Trim & "_HorasParo WHERE CodCausa='0000' and status<>'9') "
        Qt = Qt & " UNION ALL (SELECT Centro, ordenProd, fecha, turno, PuestoTrabajo, CodCausa, 0 as HREPORTADAS, horasparo HPARO, fechareg, horareg, usuarioreg, ukid FROM " & SessionUser._sCentro.Trim & "_HorasParo WHERE CodCausa<>'0000' and status<>'9')) THP "
        Qt = Qt & " INNER JOIN " & SessionUser._sCentro.Trim & "_OrdenProduccion OP "
        Qt = Qt & " ON THP.Ordenprod = OP.Orden_Produccion ) INNER JOIN MCPC_EquipoBasico EB ON THP.centro = EB.Planta AND THP.PuestoTrabajo = EB.Equipo_basico "
        Qt = Qt & " INNER JOIN ProductoTerminadoInyeccion PTE ON PTE.CENTRO= THP.centro and PTE.Codigo = OP.Producto "
        Qt = Qt & " INNER JOIN CatCausas CCC ON CCC.Centro=THP.Centro AND CCC.grpprod=PTE.grpprod AND CCC.CodCausa=THP.CodCausa "
        Qt = Qt & " WHERE THP.Centro = '" & SessionUser._sCentro.Trim & "'"
        Qt = Qt & " AND  CCC.Tipocausa='HP' "

        Qde = " SELECT THP.ordenProd ORDEN, THP.PuestoTrabajo EQUIPO, THP.HPARO, THP.HPARO, THP.CodCausa CAUSA, "
        Qde = Qde & " CCC.DesCausa DESCRIPCION, THP.fecha FECHA_TURNO, THP.fechareg FECHA_REGISTRO, THP.usuarioreg REGISTRADO_POR, THP.turno TURNO, THP.ukid UKID"
        Qde = Qde & " FROM (((SELECT Centro, ordenProd, fecha, turno, PuestoTrabajo, CodCausa, horasparo as HREPORTADAS, 0 HPARO, fechareg, horareg, usuarioreg, ukid FROM " & SessionUser._sCentro.Trim & "_HorasParo WHERE CodCausa='0000' and status='9') "
        Qde = Qde & " UNION ALL (SELECT Centro, ordenProd, fecha, turno, PuestoTrabajo, CodCausa, 0 as HREPORTADAS, horasparo HPARO, fechareg, horareg, usuarioreg, ukid FROM " & SessionUser._sCentro.Trim & "_HorasParo WHERE CodCausa<>'0000' and status='9')) THP "
        Qde = Qde & " INNER JOIN " & SessionUser._sCentro.Trim & "_OrdenProduccion OP "
        Qde = Qde & " ON THP.Ordenprod = OP.Orden_Produccion ) INNER JOIN MCPC_EquipoBasico EB ON THP.centro = EB.Planta AND THP.PuestoTrabajo = EB.Equipo_basico "
        Qde = Qde & " INNER JOIN ProductoTerminadoInyeccion PTE ON PTE.CENTRO= THP.centro and PTE.Codigo = OP.Producto "
        Qde = Qde & "  INNER JOIN CatCausas CCC ON CCC.Centro=THP.Centro AND CCC.grpprod=PTE.grpprod AND CCC.CodCausa=THP.CodCausa "
        Qde = Qde & " WHERE THP.Centro = '" & SessionUser._sCentro.Trim & "'"
        Qde = Qde & " AND CCC.Tipocausa='HP' "

        AbrirAmanco()

        If CB2.Checked = True Then
            If TxtOrdProd.Text = "" Then
                MessageBox.Show(" Tecleé Orden de Fabricación ")
                TxtOrdProd.Text = ""
                TxtOrdProd.Focus()
            End If

            If TxtOrdProd.Text.Trim = "*" Then

                Qd = Qd & "   ORDER BY THP.Fecha DESC, THP.Horareg DESC"

                Try
                    objDa = New SqlDataAdapter(Qd, objCnnAmanco.ConnectionString)
                    objDs = New DataSet
                    objDa.Fill(objDs)
                    DGHP.DataSource = objDs
                Catch ex As Exception
                    MessageBox.Show("Error Conexion :" & ex.Message, "DATOS DETALLE HORAS PARO")
                End Try

                Qt = Qt & " GROUP BY THP.PuestoTrabajo "

                Try
                    objDa = New SqlDataAdapter(Qt, objCnnAmanco.ConnectionString)
                    objDs = New DataSet
                    objDa.Fill(objDs)
                    DGRHP.DataSource = objDs
                Catch ex As Exception
                    MessageBox.Show("Error Conexion :" & ex.Message, "DATOS RESUMEN DETALLE HORAS PARO")
                End Try

                Qde = Qde & " ORDER BY THP.Fecha DESC, THP.Horareg DESC"

                Try
                    objDa = New SqlDataAdapter(Qde, objCnnAmanco.ConnectionString)
                    objDs = New DataSet
                    objDa.Fill(objDs)
                    DGDHP.DataSource = objDs
                Catch ex As Exception
                    MessageBox.Show("Error Conexion :" & ex.Message, "DATOS RESUMEN eliminados HORAS PARO")
                End Try

            End If

            If TxtOrdProd.Text <> "*" Then

                Qd = Qd & "   AND THP.ordenProd like ('%" & TxtOrdProd.Text.Trim & "%') "
                Qd = Qd & "   ORDER BY THP.Fecha DESC, THP.Horareg DESC"

                Try
                    objDa = New SqlDataAdapter(Qd, objCnnAmanco.ConnectionString)
                    objDs = New DataSet
                    objDa.Fill(objDs)
                    DGHP.DataSource = objDs
                Catch ex As Exception
                    MessageBox.Show("Error Conexion :" & ex.Message, "DATOS DETALLE HORAS PARO")
                End Try

                Qt = Qt & " AND THP.ordenProd like ('%" & TxtOrdProd.Text.Trim & "%') "
                Qt = Qt & " GROUP BY THP.PuestoTrabajo "

                Try
                    objDa = New SqlDataAdapter(Qt, objCnnAmanco.ConnectionString)
                    objDs = New DataSet
                    objDa.Fill(objDs)
                    DGRHP.DataSource = objDs
                Catch ex As Exception
                    MessageBox.Show("Error Conexion :" & ex.Message, "DATOS RESUMEN HORAS PARO")
                End Try

                Qde = Qde & " AND THP.ordenProd like ('%" & TxtOrdProd.Text.Trim & "%') "
                Qde = Qde & " ORDER BY THP.Fecha DESC, THP.Horareg DESC"

                Try
                    objDa = New SqlDataAdapter(Qde, objCnnAmanco.ConnectionString)
                    objDs = New DataSet
                    objDa.Fill(objDs)
                    DGDHP.DataSource = objDs
                Catch ex As Exception
                    MessageBox.Show("Error Conexion :" & ex.Message, "DATOS RESUMEN Eliminados HORAS PARO")
                End Try

            End If
        End If

        If CB3.Checked = True Then
            If TxtOrdProd.Text = "" Then
                MessageBox.Show(" Tecleé Orden de Fabricación ")
                TxtOrdProd.Text = ""
                TxtOrdProd.Focus()
            End If
            If TxtOrdProd.Text = "*" Then

                Qd = Qd & "   AND THP.fecha BETWEEN '" & StrFecIni & "' AND '" & StrFecFin & "' "
                Qd = Qd & "   ORDER BY THP.Fecha DESC, THP.Horareg DESC"

                Try
                    objDa = New SqlDataAdapter(Qd, objCnnAmanco.ConnectionString)
                    objDs = New DataSet
                    objDa.Fill(objDs)
                    DGHP.DataSource = objDs
                Catch ex As Exception
                    MessageBox.Show("Error Conexion :" & ex.Message, "DATOS DETALLE HORAS PARO")
                End Try

                Qt = Qt & " AND THP.fecha BETWEEN '" & StrFecIni & "' AND '" & StrFecFin & "' "
                Qt = Qt & " GROUP BY THP.PuestoTrabajo "

                Try
                    objDa = New SqlDataAdapter(Qt, objCnnAmanco.ConnectionString)
                    objDs = New DataSet
                    objDa.Fill(objDs)
                    DGRHP.DataSource = objDs
                Catch ex As Exception
                    MessageBox.Show("Error Conexion :" & ex.Message, "DATOS RESUMEN HORAS PARO")
                End Try

                Qde = Qde & " AND THP.fecha BETWEEN '" & StrFecIni & "' AND '" & StrFecFin & "' "
                Qde = Qde & " ORDER BY THP.Fecha DESC, THP.Horareg DESC"

                Try
                    objDa = New SqlDataAdapter(Qde, objCnnAmanco.ConnectionString)
                    objDs = New DataSet
                    objDa.Fill(objDs)
                    DGDHP.DataSource = objDs
                Catch ex As Exception
                    MessageBox.Show("Error Conexion :" & ex.Message, "DATOS RESUMEN Eliminados HORAS PARO")
                End Try
            End If

            If TxtOrdProd.Text <> "*" Then
                Qd = Qd & "   AND THP.ordenProd like ('%" & TxtOrdProd.Text.Trim & "%') "
                Qd = Qd & "   AND THP.fecha BETWEEN '" & StrFecIni & "' AND '" & StrFecFin & "' "
                Qd = Qd & "   ORDER BY THP.Fecha DESC, THP.Horareg DESC"
                Try
                    objDa = New SqlDataAdapter(Qd, objCnnAmanco.ConnectionString)
                    objDs = New DataSet
                    objDa.Fill(objDs)
                    DGHP.DataSource = objDs
                Catch ex As Exception
                    MessageBox.Show("Error Conexion :" & ex.Message, "DATOS DETALLE HORAS PARO")
                End Try

                Qt = Qt & " AND THP.ordenProd like ('%" & TxtOrdProd.Text.Trim & "%') "
                Qt = Qt & " AND THP.fecha BETWEEN '" & StrFecIni & "' AND '" & StrFecFin & "' "
                Qt = Qt & " GROUP BY THP.PuestoTrabajo "

                Try
                    objDa = New SqlDataAdapter(Qt, objCnnAmanco.ConnectionString)
                    objDs = New DataSet
                    objDa.Fill(objDs)
                    DGRHP.DataSource = objDs
                Catch ex As Exception
                    MessageBox.Show("Error Conexion :" & ex.Message, "DATOS RESUMEN HORAS PARO")
                End Try

                Qde = Qde & " AND THP.ordenProd like ('%" & TxtOrdProd.Text.Trim & "%') "
                Qde = Qde & " AND THP.fecha BETWEEN '" & StrFecIni & "' AND '" & StrFecFin & "' "
                Qde = Qde & " ORDER BY THP.Fecha DESC, THP.Horareg DESC"

                Try
                    objDa = New SqlDataAdapter(Qde, objCnnAmanco.ConnectionString)
                    objDs = New DataSet
                    objDa.Fill(objDs)
                    DGDHP.DataSource = objDs
                Catch ex As Exception
                    MessageBox.Show("Error Conexion :" & ex.Message, "DATOS RESUMEN Eliminados HORAS PARO")
                End Try

            End If
        End If

        If CB4.Checked = True Then
            If txtEquipo.Text = "" Then
                MessageBox.Show(" Tecleé equipo ")
                txtEquipo.Text = ""
                txtEquipo.Focus()
            End If
            If txtEquipo.Text = "*" Then
                Qd = Qd & "   AND THP.fecha BETWEEN '" & StrFecIni & "' AND '" & StrFecFin & "' "
                Qd = Qd & "   ORDER BY THP.Fecha DESC, THP.Horareg DESC"
                Try
                    objDa = New SqlDataAdapter(Qd, objCnnAmanco.ConnectionString)
                    objDs = New DataSet
                    objDa.Fill(objDs)
                    DGHP.DataSource = objDs
                Catch ex As Exception
                    MessageBox.Show("Error Conexion :" & ex.Message, "DATOS DETALLE HORAS PARO")
                End Try

                Qt = Qt & " AND THP.fecha BETWEEN '" & StrFecIni & "' AND '" & StrFecFin & "' "
                Qt = Qt & " GROUP BY THP.PuestoTrabajo "

                Try
                    objDa = New SqlDataAdapter(Qt, objCnnAmanco.ConnectionString)
                    objDs = New DataSet
                    objDa.Fill(objDs)
                    DGRHP.DataSource = objDs
                Catch ex As Exception
                    MessageBox.Show("Error Conexion :" & ex.Message, "DATOS RESUMEN HORAS PARO")
                End Try

                Qde = Qde & " AND THP.fecha BETWEEN '" & StrFecIni & "' AND '" & StrFecFin & "' "
                Qde = Qde & " ORDER BY THP.Fecha DESC, THP.Horareg DESC"

                Try
                    objDa = New SqlDataAdapter(Qde, objCnnAmanco.ConnectionString)
                    objDs = New DataSet
                    objDa.Fill(objDs)
                    DGDHP.DataSource = objDs
                Catch ex As Exception
                    MessageBox.Show("Error Conexion :" & ex.Message, "DATOS RESUMEN HORAS PARO")
                End Try
            End If
            If txtEquipo.Text <> "*" Then
                Qd = Qd & "   AND THP.PuestoTrabajo like ('%" & txtEquipo.Text.Trim & "%') "
                Qd = Qd & "   AND THP.fecha BETWEEN '" & StrFecIni & "' AND '" & StrFecFin & "' "
                Qd = Qd & "   ORDER BY THP.Fecha DESC, THP.Horareg DESC"
                Try
                    objDa = New SqlDataAdapter(Qd, objCnnAmanco.ConnectionString)
                    objDs = New DataSet
                    objDa.Fill(objDs)
                    DGHP.DataSource = objDs
                Catch ex As Exception
                    MessageBox.Show("Error Conexion :" & ex.Message, "DATOS DETALLE HORAS PARO")
                End Try

                Qt = Qt & " AND THP.PuestoTrabajo like ('%" & txtEquipo.Text.Trim & "%') "
                Qt = Qt & " AND THP.fecha BETWEEN '" & StrFecIni & "' AND '" & StrFecFin & "' "
                Qt = Qt & " GROUP BY THP.PuestoTrabajo "

                Try
                    objDa = New SqlDataAdapter(Qt, objCnnAmanco.ConnectionString)
                    objDs = New DataSet
                    objDa.Fill(objDs)
                    DGRHP.DataSource = objDs
                Catch ex As Exception
                    MessageBox.Show("Error Conexion :" & ex.Message, "DATOS RESUMEN HORAS PARO")
                End Try

                Qde = Qde & " AND THP.PuestoTrabajo like ('%" & txtEquipo.Text.Trim & "%') "
                Qde = Qde & " AND THP.fecha BETWEEN '" & StrFecIni & "' AND '" & StrFecFin & "' "
                Qde = Qde & " ORDER BY THP.Fecha DESC, THP.Horareg DESC"

                Try
                    objDa = New SqlDataAdapter(Qde, objCnnAmanco.ConnectionString)
                    objDs = New DataSet
                    objDa.Fill(objDs)
                    DGDHP.DataSource = objDs
                Catch ex As Exception
                    MessageBox.Show("Error Conexion :" & ex.Message, "DATOS RESUMEN Eliminados HORAS PARO")
                End Try
            End If
        End If
        If CB5.Enabled = False Then
            CB5.Enabled = True
        End If
    End Sub

    Private Sub BtnPost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPost.Click
        Dim xreg As String

        '---< Update Autoriza PesoProducto Terminado > ---

        xreg = "9"
        Try
            InQry = ""
            InQry = "Update " & SessionUser._sCentro.Trim & "_horasparo "
            InQry = InQry & " Set status = '" & xreg.Trim & "'"
            InQry = InQry & " where "
            InQry = InQry & " Centro = '" & SessionUser._sCentro.Trim & "' And ordenProd = '" & TxtODF.Text.Trim & "'"
            InQry = InQry & " And puestotrabajo = '" & TxtPtotrabajo.Text.Trim & "'"
            InQry = InQry & " And ukid = '" & txtUKID.Text.Trim & "'"
            InQry = InQry & " AND fecha = '" & TxtFecha.Text.Trim & "'"

            InsertQry(InQry)
            MsgBox("Registros Actualizados : " & InsertBD, MsgBoxStyle.OkOnly, "Horas Paro")
        Catch ex As Exception
            MessageBox.Show("Error Conexion :" & ex.Message, " VENTANA DE ERROR * * * ")
        End Try

        Consultar()
    End Sub

    Private Sub FrmAdminPPT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DTP1.Value = Date.Today.ToString("yyyy-MM-dd")
        DTP2.Value = DTP1.Value
        Me.Icon = Util.ApplicationIcon()
    End Sub

    Private Sub ToolStripButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Close()
    End Sub

    Private Sub CerrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub DGPPT_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DGHP.MouseDoubleClick
        Try
            If DGHP.CurrentRowIndex > -1 Then
                TxtODF.Text = DGHP.Item(DGHP.CurrentCell.RowNumber, 0).ToString.Trim
                TxtPtotrabajo.Text = DGHP.Item(DGHP.CurrentCell.RowNumber, 1).ToString.Trim
                TxtFecha.Text = DGHP.Item(DGHP.CurrentCell.RowNumber, 6).ToString.Trim
                txtUKID.Text = DGHP.Item(DGHP.CurrentCell.RowNumber, 10).ToString.Trim
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class