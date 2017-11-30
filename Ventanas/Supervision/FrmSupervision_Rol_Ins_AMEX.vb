Imports System.Data.SqlClient
Imports Atlas.Accesos.CLVarGlobales
Imports SQL_DATA
Public Class FrmSupervision_Rol_Ins_AMEX
    Dim Str_FI As String    'Fecha del día
    Dim C_Mes As String

    Sub FillCBSuper()
        Dim NDataSet1 As New DataSet
        QryCombo = ""
        QryCombo = "select * from ADM_Usuario "
        QryCombo = QryCombo & "Where Planta = '" & SessionUser._sCentro.Trim & "' "
        QryCombo = QryCombo & "And Puesto = '3' "
        Combo_AMD(QryCombo)
        NDataSet1 = DataSetCombo.Copy
        CB_Sup.DataSource = NDataSet1.Tables(0)
        CB_Sup.DisplayMember = "Nombre"
        CB_Sup.ValueMember = "Usuario"
    End Sub

    Sub FillCBTurno()
        Dim NDataSet1 As New DataSet
        QryCombo = ""
        QryCombo = "Select * from ADM_Turno "
        QryCombo = QryCombo & "Where Planta = '" & SessionUser._sCentro.Trim & "' "
        Combo_AMD(QryCombo)
        NDataSet1 = DataSetCombo.Copy
        CB_Turno.DataSource = NDataSet1.Tables(0)
        CB_Turno.DisplayMember = "Descripción"
        CB_Turno.ValueMember = "Turno"
    End Sub

    Private Sub FrmSupervision_Rol_Ins_AMEX_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CB_Sup.Text = ""
        CB_Turno.Text = ""
        Accion = "Alta"
        FillCBSuper()
        FillCBTurno()
    End Sub

    Private Sub BtnPost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPost.Click
        Str_FI = DTP_FI.Text.Trim
        'Verifica el mes que le corresponde
        QRY = ""
        QRY = "Select DATENAME(month,'" & Str_FI.Trim & "') as Mes "

        Try
            objDa = New SqlDataAdapter(QRY, AbrirAmanco(SessionUser._sAmbiente))
            objDs = New DataSet
            objDa.Fill(objDs)

        Catch ex As Exception
            MessageBox.Show("Error Conexion :" & ex.Message, "Produccion")
        End Try

        LecturaQry(QRY)

        Do While (LecturaBD.Read)
            C_Mes = LecturaBD(0)
        Loop

        LecturaBD.Close()

        Select Case Accion
            Case Is = "Alta"

                QRY = ""
                QRY = " SELECT * FROM " & SessionUser._sCentro.Trim & "_Rol_Supervisor "
                QRY = QRY & "WHERE Fecha = '" & Str_FI.Trim & "' "
                QRY = QRY & "And Turno = '" & CB_Turno.SelectedValue & "' "
                QRY = QRY & ""
                LecturaQry(QRY)
                If LecturaBD.Read Then
                    Mensajes("***  Ya esta ingresado el rol de este Turno *** ", 1)
                    LecturaBD.Close()
                    Exit Sub
                Else

                    QRY = ""
                    QRY = " SELECT * FROM " & SessionUser._sCentro.Trim & "_Rol_Supervisor "
                    QRY = QRY & "WHERE Clave_Usr = '" & CB_Sup.SelectedValue.Trim & "' "
                    QRY = QRY & "And Fecha = '" & Str_FI.Trim & "' "
                    QRY = QRY & "And Turno = '" & CB_Turno.SelectedValue & "' "
                    QRY = QRY & ""
                    LecturaQry(QRY)
                    If LecturaBD.Read Then
                        Mensajes("***  Ya esta ingresado el rol con estos datos *** ", 1)
                        LecturaBD.Close()
                        Exit Sub
                    Else

                        Try

                            InQry = "INSERT INTO " & SessionUser._sCentro.Trim & "_Rol_Supervisor (Clave_Usr,Fecha,Turno,Mes) Values "
                            InQry = InQry & "( '" & CB_Sup.SelectedValue.Trim & "','" & Str_FI.Trim & "','" & CB_Turno.SelectedValue & "',"
                            InQry = InQry & "'" & C_Mes.Trim & "')"
                            InsertQry(InQry)

                        Catch ex1 As Exception
                            MsgBox(ex1.Message)
                            Exit Sub
                        End Try

                        InQry = " UPDATE " & SessionUser._sCentro.Trim & "_PesoProductoTerminado SET Sup_Turno='" & CB_Sup.SelectedValue.Trim & "' "
                        InQry = InQry & "WHERE Planta = '" & SessionUser._sCentro.Trim & "' "
                        InQry = InQry & "AND Fecha_Pesaje = '" & Str_FI.Trim & "' "
                        InQry = InQry & "AND Turno = '" & CB_Turno.SelectedValue & "' "
                        InsertQry(InQry)

                        FrmSupervision_Rol_AMEX.Grid_Load()

                    End If
                End If
                LecturaBD.Close()

        End Select
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Close()
    End Sub

    Private Sub FrmSupervision_Rol_Ins_AMEX_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Accion = ""
    End Sub
End Class