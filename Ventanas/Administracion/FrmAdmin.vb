Imports System.Data.SqlClient
Imports System.Configuration
Imports Utili_Generales
Imports Atlas.Accesos.CLVarGlobales
Imports SQL_DATA
Public Class FrmAdmin
    Dim UsrLog As String  'el usuario actual logeado en el sistema
    Dim strNumeroPlanta As String
    Dim Permiso As New Permisos

    Private Sub FrmAdmin_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        FrmMain.restart_session()
    End Sub

    Private Sub FrmAdmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'DesButtons_Admin(Me)
        Gen_Valida.Valida_Acceso_Admin(SessionUser._sIdPerfil, Me, "MA%")
    End Sub

    Private Sub GruposGeneralesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            FrmAdmCatGrpcausasGenerales.ShowDialog()
        Finally
            FrmAdmCatGrpcausasGenerales.Dispose()
            FrmAdmCatGrpcausasGenerales = Nothing
        End Try
    End Sub

    Private Sub PerfilesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            FrmAdmCatPerfiles.ShowDialog()
        Finally
            FrmAdmCatPerfiles.Dispose()
            FrmAdmCatPerfiles = Nothing
        End Try
    End Sub


    Private Sub GrupoRTMToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            FrmAdmCatGruposRTM.ShowDialog()
        Finally
            FrmAdmCatGruposRTM.Dispose()
            FrmAdmCatGruposRTM = Nothing
        End Try
    End Sub

    Private Sub NotificaciónMasivaInyecciónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        EXTINY = "2"
        NotificacionMasiva.Text = "Notificación Masiva Producto Terminado Inyección"
        NotificacionMasiva.ShowDialog()
        NotificacionMasiva.TabControl1.SelectedIndex = 0
    End Sub

    Private Sub ToolStripMenuItem80_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            FrmAdmCatProgramas_AMEX.ShowDialog()
        Finally
            FrmAdmCatProgramas_AMEX.Dispose()
            FrmAdmCatProgramas_AMEX = Nothing
        End Try
    End Sub

    Private Sub MA_ODP_EXT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MA_ODP_EXT.Click
        Permiso.Accesos("MA_ODP_EXT", "1", SessionUser._sIdPerfil, "", "")
    End Sub

    Private Sub MA_ODP_INY_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MA_ODP_INY.Click
        Permiso.Accesos("MA_ODP_INY", "2", SessionUser._sIdPerfil, "", "")
    End Sub

    Private Sub MA_SAP_EXT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MA_SAP_EXT.Click
        Permiso.Accesos("MA_SAP_EXT", "1", SessionUser._sIdPerfil, "E", "Estatus de Conexión SAP Extrusion")
    End Sub

    Private Sub MA_SAP_INY_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MA_SAP_INY.Click
        Permiso.Accesos("MA_SAP_INY", "2", SessionUser._sIdPerfil, "I", "Estatus de Conexión SAP Inyección")
    End Sub

    Private Sub ArchivoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArchivoToolStripMenuItem1.Click
        Close()
    End Sub

    Private Sub MA_PRD_CATEXT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MA_PRD_CATEXT.Click
        Permiso.Accesos("MA_PRD_CATEXT", "1", SessionUser._sIdPerfil, "E", "")
    End Sub

    Private Sub MA_PRD_COMEXT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MA_PRD_COMEXT.Click
        Permiso.Accesos("MA_PRD_COMEXT", "1", SessionUser._sIdPerfil, "E", "")
    End Sub

    Private Sub MA_PRD_CATINY_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MA_PRD_CATINY.Click
        Permiso.Accesos("MA_PRD_CATINY", "2", SessionUser._sIdPerfil, "I", "")
    End Sub

    Private Sub MA_PRD_COMINY_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MA_PRD_COMINY.Click
        Permiso.Accesos("MA_PRD_COMINY", "2", SessionUser._sIdPerfil, "I", "")
    End Sub

    Private Sub MA_PRD_EMBINY_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MA_PRD_EMBINY.Click
        Permiso.Accesos("MA_PRD_EMBINY", "2", SessionUser._sIdPerfil, "I", "Asignar Embalajes ")
    End Sub

    Private Sub MA_CAT_AP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MA_CAT_AP.Click
        Permiso.Accesos("MA_CAT_AP", "", SessionUser._sIdPerfil, "", "")
    End Sub

    Private Sub MA_CAT_SEC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MA_CAT_SEC.Click
        FrmAdmCatSecciones_AMEX.ShowDialog()
    End Sub

    Private Sub MA_CAT_CAU_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MA_CAT_CAU.Click
        Permiso.Accesos("MA_CAT_CAU", "", SessionUser._sIdPerfil, "", "Catalogo de Causas")
    End Sub

    Private Sub MA_CAT_EMP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MA_CAT_EMP.Click
        Try
            FrmAdmCatEmpExt_AMEX.ShowDialog()
        Finally
            FrmAdmCatEmpExt_AMEX.Dispose()
            FrmAdmCatEmpExt_AMEX = Nothing
        End Try
    End Sub

    Private Sub MA_CAT_EMB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MA_CAT_EMB.Click
        Try
            FrmAdmCatMatIny_AMEX.ShowDialog()
        Finally
            FrmAdmCatMatIny_AMEX.Dispose()
            FrmAdmCatMatIny_AMEX = Nothing
        End Try
    End Sub

    Private Sub MA_CAT_TRM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MA_CAT_TRM.Click
        Permiso.Accesos("MA_CAT_TRM", "", SessionUser._sIdPerfil, "", "Catalogo de Racks/Tarimas/Carretas ")
    End Sub

    Private Sub MA_PTEXT_EM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MA_PTEXT_EM.Click
        Permiso.Accesos("MA_SCPT_EXT", "1", SessionUser._sIdPerfil, "E", "Eliminar registros pesajes de ")
    End Sub

    Private Sub MA_PTINY_EM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MA_PTINY_EM.Click
        Permiso.Accesos("MA_SCPT_INY", "2", SessionUser._sIdPerfil, "I", "Eliminar registros pesajes de ")
    End Sub

    Private Sub MA_HRINY_EM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MA_HRINY_EM.Click
        Try
            FrmAdminDelTPERIny.ShowDialog()
        Finally
            FrmAdminDelTPERIny.Dispose()
            FrmAdminDelTPERIny = Nothing
        End Try
    End Sub

    Private Sub MA_NOTMAS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MA_NOTMAS.Click
        Permiso.Accesos("MA_NOTMAS", "", SessionUser._sIdPerfil, "", "Notificación Masiva")
    End Sub

    Private Sub ParametrosDelSistemaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ParametrosDelSistemaToolStripMenuItem.Click

        Permiso.Accesos("MA_PARAMETRIZA", "", SessionUser._sIdPerfil, "", "")
    End Sub

    Private Sub MA_CAT_COMP_EXT_Click(sender As System.Object, e As System.EventArgs) Handles MA_CAT_COMP_EXT.Click
        Permiso.Accesos("MA_CAT_COMP_EXT", "1", SessionUser._sIdPerfil, "E", "Catalogo de Compuestos ")
    End Sub

    Private Sub MA_CAT_COMP_INY_Click(sender As System.Object, e As System.EventArgs) Handles MA_CAT_COMP_INY.Click
        Permiso.Accesos("MA_CAT_COMP_INY", "2", SessionUser._sIdPerfil, "I", "Catalogo de Compuestos ")
    End Sub

    Private Sub MA_CAT_USR_EXT_Click(sender As System.Object, e As System.EventArgs) Handles MA_CAT_USR_EXT.Click
        Permiso.Accesos("MA_CAT_USR_EXT", "1", SessionUser._sIdPerfil, "E", "Catalogo de Usuarios ")
    End Sub

    Private Sub MA_CAT_USR_INY_Click(sender As System.Object, e As System.EventArgs) Handles MA_CAT_USR_INY.Click
        Permiso.Accesos("MA_CAT_USR_INY", "2", SessionUser._sIdPerfil, "I", "Catalogo de Usuarios ")
    End Sub

    Private Sub MA_CAT_CAU_EXT_Click(sender As System.Object, e As System.EventArgs) Handles MA_CAT_CAU_EXT.Click
        Permiso.Accesos("MA_CAT_CAU_EXT", "1", SessionUser._sIdPerfil, "E", "Catalogo de Causas ")
    End Sub

    Private Sub MA_CAT_CAU_INY_Click(sender As System.Object, e As System.EventArgs) Handles MA_CAT_CAU_INY.Click
        Permiso.Accesos("MA_CAT_CAU_EXT", "2", SessionUser._sIdPerfil, "I", "Catalogo de Causas ")
    End Sub

    Private Sub MA_EQ_EXT_Click(sender As System.Object, e As System.EventArgs) Handles MA_EQ_EXT.Click
        Permiso.Accesos("MA_EQ_EXT", "1", SessionUser._sIdPerfil, "E", "Catalogo de Puestos de Trabajo ")
    End Sub

    Private Sub MA_EQ_INY_Click(sender As System.Object, e As System.EventArgs) Handles MA_EQ_INY.Click
        Permiso.Accesos("MA_EQ_INY", "2", SessionUser._sIdPerfil, "I", "Catalogo de Puestos de Trabajo ")
    End Sub

    Private Sub MA_NOTMAS_EXT_Click(sender As System.Object, e As System.EventArgs) Handles MA_NOTMAS_EXT.Click
        Permiso.Accesos("MA_NOTMAS_EXT", "1", SessionUser._sIdPerfil, "E", "Notificación Masiva ")
    End Sub

    Private Sub MA_NOTMAS_INY_Click(sender As System.Object, e As System.EventArgs) Handles MA_NOTMAS_INY.Click
        Permiso.Accesos("MA_NOTMAS_INY", "2", SessionUser._sIdPerfil, "I", "Notificación Masiva ")
    End Sub

    Private Sub MA_NOTPTEXT_Click(sender As System.Object, e As System.EventArgs) Handles MA_NOTPTEXT.Click
        Permiso.Accesos("MA_NOTPTEXT", "1", SessionUser._sIdPerfil, "E", "")
    End Sub

    Private Sub MA_NOTSCEXT_Click(sender As System.Object, e As System.EventArgs) Handles MA_NOTSCEXT.Click
        Permiso.Accesos("MA_NOTSCEXT", "1", SessionUser._sIdPerfil, "E", "")
    End Sub

    Private Sub MA_NOTPTINY_Click(sender As System.Object, e As System.EventArgs) Handles MA_NOTPTINY.Click
        Permiso.Accesos("MA_NOTPTINY", "2", SessionUser._sIdPerfil, "I", "")
    End Sub

    Private Sub MA_NOTSCINY_Click(sender As System.Object, e As System.EventArgs) Handles MA_NOTSCINY.Click
        Permiso.Accesos("MA_NOTSCINY", "2", SessionUser._sIdPerfil, "I", "")
    End Sub

    Private Sub ConfigurarBasculaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ConfigurarBasculaToolStripMenuItem.Click
        CNF_Parametrizacion.ShowDialog()
    End Sub

    Private Sub CatálogoProductosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CatálogoProductosToolStripMenuItem.Click
        Permiso.Accesos("MA_PRD_CATINY", "3", SessionUser._sIdPerfil, "R", "Catalogo de Productos Rotomoldeo")
    End Sub

    Private Sub AsignarCompuestoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AsignarCompuestoToolStripMenuItem.Click
        Permiso.Accesos("MA_PRD_COMROT", "3", SessionUser._sIdPerfil, "R", "")
    End Sub

    Private Sub MA_CAT_COMP_ROT_Click(sender As System.Object, e As System.EventArgs) Handles MA_CAT_COMP_ROT.Click
        Permiso.Accesos("MA_CAT_COMP_ROT", "3", SessionUser._sIdPerfil, "E", "Catalogo de Compuestos ")
    End Sub

    Private Sub MA_PTEXT_MOD_Click(sender As System.Object, e As System.EventArgs) Handles MA_PTEXT_MOD.Click
        Permiso.Accesos("MA_PTEXT_MOD", "1", SessionUser._sIdPerfil, "E", "Modificación Pesajes ")
    End Sub
End Class