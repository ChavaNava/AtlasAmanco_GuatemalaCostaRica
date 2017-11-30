Imports System.Windows.Forms
Imports SQL_DATA

Public Class FrmMonitorMaster
#Region "Variables"

#End Region

#Region "Eventos"
    Private Sub FrmMonitorMaster_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Dim pantalla As Screen
        'pantalla = Screen.AllScreens(0)  'le paso 0 para el monitor principal y 1 para el secundario
        Timer1.Interval = 30000
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        Resumen()
        Orden()
        ResumenMensual()
        Resumendiaturno()
        ResumeProduccion()
        ResumenSeguridad()
        Timer1.Start()
    End Sub

#End Region

#Region "Metodos"

    Private Sub Resumen()
        Dim FrmMonitor As New FrmMonitorMaster
        Cnn.LecturaQry("PA_Indicadores '" & SessionUser._sIdCentro.Trim & "', '" & 1 & "'")
        Do While (Cnn.LecturaBD.Read)
            ResumenIndicadores.IdIndicador = Cnn.LecturaBD(1)
            Select Case ResumenIndicadores._IdIndicador
                Case Is = 2 ''Sobrepeso
                    TxM2.Text = Cnn.LecturaBD(3) & "%"
                Case Is = 3 ''Rendimiento
                    TxM4.Text = Cnn.LecturaBD(3)
                    TxT4.Text = Cnn.LecturaBD(4)
                    TxMe4.Text = Cnn.LecturaBD(5)
                Case Is = 4 ''Tiempos de paro
                    TxM5.Text = Cnn.LecturaBD(3) & "%"
                    TxR5.Text = Cnn.LecturaBD(4)
                Case Is = 5 ''Scrap
                    TxM3.Text = Cnn.LecturaBD(3) & "%"
                Case Is = 6 ''Cumplimiento de producción
                    TxM6.Text = Cnn.LecturaBD(3) & "%"
                    TxR6.Text = Cnn.LecturaBD(4)
                Case Is = 7 ''Bono
                    TxM7.Text = Cnn.LecturaBD(3) & "%"
                    TxR7.Text = Cnn.LecturaBD(4)
            End Select
        Loop
    End Sub

    Private Sub Orden()
        Cnn.LecturaQry("PA_Indicadores_Resume_Orden '" & SessionUser._sCentro.Trim & "', 'E'")
        Do While (Cnn.LecturaBD.Read)
            ConsultaOrden.FH = Cnn.LecturaBD(0)
            ConsultaOrden.Folio = Cnn.LecturaBD(1)
            ConsultaOrden.Orden = Cnn.LecturaBD(2)
            ConsultaOrden.Tipo = Cnn.LecturaBD(3)
        Loop
    End Sub

    Private Sub ResumeProduccion()
        Cnn.LecturaQry("PA_Indicadores_Avance_Produccion '" & SessionUser._sCentro.Trim & "', '" & ConsultaOrden._Orden.Trim & "', '(0,4,3,1)', 'E', '<> ''36''', '*', '', '', '', '', 1")
        Do While (Cnn.LecturaBD.Read)
            ResumenOrdenProduccion.Orden = Cnn.LecturaBD(0)
            ResumenOrdenProduccion.Puesto = Cnn.LecturaBD(1)
            ResumenOrdenProduccion.CantidadProgramada = Cnn.LecturaBD(2)
            ResumenOrdenProduccion.CodigoProducto = Cnn.LecturaBD(3)
            ResumenOrdenProduccion.Producto = Cnn.LecturaBD(4)
            ResumenOrdenProduccion.TramosNotificado = Cnn.LecturaBD(5)
            ResumenOrdenProduccion.TramosPendientes = Cnn.LecturaBD(6)
            ResumenOrdenProduccion.Sobrepeso = Cnn.LecturaBD(7)
            ResumenOrdenProduccion.PesoScrap = Cnn.LecturaBD(8)
            ResumenOrdenProduccion.PorcentajeScrap = Cnn.LecturaBD(9)
        Loop
        SetResumeProduccion()
    End Sub

    Private Sub SetResumeProduccion()
        TxOrden.Text = ResumenOrdenProduccion._Orden
        TxEquipo.Text = ResumenOrdenProduccion._Puesto
        TxDesc.Text = ResumenOrdenProduccion._CodigoProducto & " " & ResumenOrdenProduccion._Producto
        TCant.Text = ResumenOrdenProduccion._CantidadProgramada
        TTramosNotificados.Text = ResumenOrdenProduccion.TramosNotificado
        TTramosPendientes.Text = ResumenOrdenProduccion.TramosPendientes
        TSobrepeso.Text = FormatNumber(ResumenOrdenProduccion.Sobrepeso, 2) & "%"
    End Sub

    Private Sub SetResumenMensual()
        TxMe2.Text = FormatNumber(ResumenMes._Sobre_Peso, 3) & "%"
        TxMe3.Text = FormatNumber(ResumenMes._Porcentaje_Scrap, 3) & "%"
    End Sub

    Private Sub ResumenMensual()
        Dim PrimerDiaDelMes As String = DateSerial(Year(Date.Now), Month(Date.Now), 1).ToString("yyyy-MM-dd")
        Dim UltimoDiaDelMes As String = DateSerial(Year(Date.Now), Month(Date.Now) + 1, 0).ToString("yyyy-MM-dd")
        Cnn.LecturaQry("PA_Indicadores_Avance_Produccion '" & SessionUser._sCentro.Trim & "', '', '(0,4,3,1)', 'E', '<> ''36''', '*', '" & PrimerDiaDelMes & "', '" & UltimoDiaDelMes & "', '', '', 2")
        Do While (Cnn.LecturaBD.Read)
            ResumenMes.Sobre_Peso = Cnn.LecturaBD(0)
            ResumenMes.Peso_Scrap = Cnn.LecturaBD(1)
            ResumenMes.Porcentaje_Scrap = Cnn.LecturaBD(2)
        Loop
        SetResumenMensual()
    End Sub

    Private Sub Resumendiaturno()
        Dim dia As Date = DateTime.Now.ToString("yyyy-MM-dd")
        Dim HReal As String = DateTime.Now.ToString("HH:mm:ss")
        Dim dia1 As String = dia.ToString("yyyy-MM-dd")
        Dim dia2 As String = DateAdd(DateInterval.Day, 1, dia).ToString("yyyy-MM-dd")
        Dim Turnodia As String = Catalogo_Turnos.Turno(HReal)


        Cnn.LecturaQry("PA_Indicadores_Avance_Produccion '" & SessionUser._sCentro.Trim & "', '', '(0,4,3,1)', 'E', '<> ''36''', '" & Turnodia & "', '" & dia1 & "', '" & dia2 & "', '', '', 3")
        Do While (Cnn.LecturaBD.Read)
            Resumen_dia_Turno.Sobre_Peso = Cnn.LecturaBD(0)
            Resumen_dia_Turno.Peso_Scrap = Cnn.LecturaBD(1)
            Resumen_dia_Turno.Porcentaje_Scrap = Cnn.LecturaBD(2)
        Loop
        SetResumendiaturno()
    End Sub
    Private Sub ResumenSeguridad()
        Cnn.LecturaQry("PA_Indicadores '" & SessionUser._sIdCentro.Trim & "', 2")
        Do While (Cnn.LecturaBD.Read)
            ResumenSeg.dias = Cnn.LecturaBD(2)
        Loop
        SetResumenSeg()
    End Sub
    Private Sub SetResumendiaturno()
        TxT2.Text = FormatNumber(Resumen_dia_Turno._Sobre_Peso, 2) & "%"
        TxT3.Text = FormatNumber(Resumen_dia_Turno._Porcentaje_Scrap, 2) & "%"
    End Sub

    Private Sub SetResumenSeg()
        TxMe1.Text = ResumenSeg._dias
    End Sub
#End Region
End Class