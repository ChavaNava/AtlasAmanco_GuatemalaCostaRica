Imports System
Imports System.Net.Mime.MediaTypeNames
Imports System.Configuration
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Drawing.Text

Public Class Util
#Region "Variables miembro"
#End Region

#Region "Enumeraciones"
#End Region

#Region "Constructores"
#End Region

#Region "Clases anidadas"
#End Region

#Region "Propiedades"
#End Region

#Region "Metodos"
    Public Shared Function QuitarCerosIzquierda(ByVal strValor As String) As String
        While strValor.Length > 0
            If strValor(0) = "0" Then
                strValor = strValor.Substring(1, strValor.Length - 1)
            Else
                Exit While
            End If
        End While
        Return strValor
    End Function

    Public Shared Sub CurrentCulture()
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-MX")
        System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern = "yyyy/MM/dd"
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = ","
    End Sub

    Public Shared Sub ExportaExcel(ByVal datagrid As Windows.Forms.DataGridView)

        Dim exApp As New Microsoft.Office.Interop.Excel.Application
        Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
        Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet

        Try
            'Añadimos el Libro al programa, y la hoja al libro
            exLibro = exApp.Workbooks.Add
            exHoja = exLibro.Worksheets.Add()
            ' ¿Cuantas columnas y cuantas filas?
            Dim NCol As Integer = datagrid.ColumnCount
            Dim NRow As Integer = datagrid.RowCount

            'Llenamos el encabezado
            For i As Integer = 1 To NCol
                exHoja.Cells.Item(1, i) = datagrid.Columns(i - 1).HeaderText.Trim
            Next

            'Aqui recorremos todas las filas, y por cada fila todas las columnas y vamos escribiendo.
            For Fila As Integer = 0 To NRow - 1
                For Col As Integer = 0 To NCol - 1
                    exHoja.Cells.Item(Fila + 2, Col + 1) = datagrid.Rows(Fila).Cells(Col).Value
                Next
            Next

            'Titulo en negrita, Alineado al centro y que el tamaño de la columna se ajuste al texto
            exHoja.Rows.Item(1).Font.Bold = 1
            exHoja.Rows.Item(1).HorizontalAlignment = 3
            exHoja.Columns.AutoFit()

            'Aplicación visible
            exApp.Application.Visible = True
            exHoja = Nothing
            exLibro = Nothing
            exApp = Nothing

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")
        End Try
    End Sub

    Public Shared Function ApplicationIcon() As Object
        Return My.Resources.Fluent
    End Function

    Public Shared Sub IdentificaBascula()
        'Dim b1 As String = ConfigurationManager.AppSettings("IdBascula1")
    End Sub

    Public Shared Sub Read_Order(ByVal OrderProduction As String)
        Select Case OrderProduction
            Case Is <> ""
                MensajeBox.Mostrar("Tecleé un numero de Orden de Producción", "Campo Vacio", MensajeBox.TipoMensaje.Exclamation)
                Return
            Case Else
                'Verificar que la orden existe en A-tlas

        End Select
    End Sub

    Public Shared Function SoloNumeros(ByVal Keyascii As Short) As Short
        If InStr("1234567890", Chr(Keyascii)) = 0 Then
            SoloNumeros = 0
        Else
            SoloNumeros = Keyascii
        End If
        Select Case Keyascii
            Case 8
                SoloNumeros = Keyascii
            Case 13
                SoloNumeros = Keyascii
        End Select
    End Function

    Public Shared Function Decimales(ByVal Keyascii As Short) As Short
        If InStr("1234567890.", Chr(Keyascii)) = 0 Then
            Decimales = 0
        Else
            Decimales = Keyascii
        End If
        Select Case Keyascii
            Case 8
                Decimales = Keyascii
            Case 13
                Decimales = Keyascii
        End Select
    End Function

    'Public Function txtNumerico(ByVal txtControl As TextBox, ByVal caracter As Char, ByVal decimales As Boolean) As Boolean
    '    If (Char.IsNumber(caracter, 0) = True) Or caracter = Convert.ToChar(8) Or caracter = GDECIMAL.Trim Then
    '        If caracter = GDECIMAL.Trim Then
    '            If decimales = True Then
    '                If txtControl.Text.IndexOf(GDECIMAL.Trim) <> -1 Then Return True
    '            Else : Return True
    '            End If
    '        End If
    '        Return False
    '    Else
    '        Return True
    '    End If
    'End Function

    Public Function LlenarCeros(ByVal Ceros As String, ByVal C_Ceros As String) As String

        If C_Ceros = 8 Then
            Ceros = Mid("00000000", 1, 8 - Len(Ceros)) & Ceros.Trim()
        ElseIf C_Ceros = 6 Then
            Ceros = Mid("000000", 1, 6 - Len(Ceros)) & Ceros.Trim()
        End If

        Return Ceros
    End Function

  

#End Region

#Region "Colección"
#End Region

#Region "Campos"
#End Region

#Region "Eventos"
#End Region

End Class
