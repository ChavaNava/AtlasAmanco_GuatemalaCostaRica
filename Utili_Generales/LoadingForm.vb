Imports System.Threading
Imports System.Windows.Forms

Public Class LoadingForm
    Shared ms_frmSplash As LoadingForm = Nothing
    Shared ms_oThread As Thread = Nothing


    Private CloseBan As Boolean = False

    Public Shared Sub ShowLoading()
        If ms_frmSplash Is Nothing Then
            ms_oThread = New Thread(New ThreadStart(AddressOf LoadingForm.ShowForm))
            ms_oThread.IsBackground = True
            ms_oThread.SetApartmentState(ApartmentState.STA)
            ms_oThread.Start()
        End If
    End Sub

    Private Shared Sub ShowForm()
        ms_frmSplash = New LoadingForm()
        Application.Run(ms_frmSplash)

    End Sub

    Public Shared ReadOnly Property LoadingView() As LoadingForm
        Get
            Return ms_frmSplash
        End Get
    End Property

    Shared Sub CloseForm()
        Try
            '    AndAlso Not ms_frmSplash.IsDisposed Is Nothing 
            If Not (ms_frmSplash Is Nothing) AndAlso ms_frmSplash.IsDisposed = False Then
                ' Make it start going away.
                ms_frmSplash.CloseBan = True
            End If
        Catch ex As Exception
            ms_frmSplash.CloseBan = True
        End Try
        ms_oThread = Nothing
        ms_frmSplash = Nothing
    End Sub

    Private Sub TimerClose_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerClose.Tick
        If CloseBan Then
            'WindowPosition.Fondo(Me.Handle.ToInt32())
            Me.Close()
        End If
    End Sub


    'Private Sub Form1_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
    '    If (ms_oThread.ThreadState.ToString = "SuspendedRequested, WaitSleepJoin") Or
    '            (ms_oThread.ThreadState.ToString = "Suspended") Or (ms_oThread.ThreadState.ToString =
    '            "WaitSleepJoin, Suspended") Then
    '    Else
    '        ms_oThread.Abort()
    '    End If
    'End Sub

    Private Sub LoadingForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TimerClose.Enabled = True
    End Sub
End Class