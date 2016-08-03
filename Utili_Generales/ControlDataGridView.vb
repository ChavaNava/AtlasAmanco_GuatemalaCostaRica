Imports System.Windows.Forms
Imports System.Drawing

Public Class ControlDataGridView
    Public Shared Sub SummaryOrder(ByVal DGV As DataGridView)

        'DGV.Columns.Clear()

        Dim arrCols(0 To 8) As DataGridViewColumn           'Arreglo que contendrá la definición de las columnas.

        arrCols(0) = New DataGridViewTextBoxColumn()        'Creación del Objeto de Columna en la posición '0' del Arreglo.     
        arrCols(0).HeaderText = "Orden Producción"          'Texto de Cabecera de la Columna.     
        arrCols(0).Name = "C_ODP"                           'Nombre de la Columna dentro del DataGridView.   
        arrCols(0).ReadOnly = True

        arrCols(1) = New DataGridViewTextBoxColumn()
        arrCols(1).HeaderText = "Puesto de Trabajo"
        arrCols(1).Name = "C_Equipo"
        arrCols(1).ReadOnly = True

        arrCols(2) = New DataGridViewTextBoxColumn()
        arrCols(2).HeaderText = "Producto"
        arrCols(2).Name = "C_Producto"
        arrCols(2).ReadOnly = True

        arrCols(3) = New DataGridViewTextBoxColumn()
        arrCols(3).HeaderText = "Tramos"
        arrCols(3).Name = "C_Tramos"
        arrCols(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        arrCols(3).ReadOnly = True

        arrCols(4) = New DataGridViewTextBoxColumn()
        arrCols(4).HeaderText = "Peso Neto Kgs."
        arrCols(4).Name = "C_PN"
        arrCols(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        arrCols(4).ReadOnly = True

        arrCols(5) = New DataGridViewTextBoxColumn()
        arrCols(5).HeaderText = "Peso Teorico Kgs."
        arrCols(5).Name = "C_PT"
        arrCols(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        arrCols(5).ReadOnly = True
        arrCols(5).Width = 2

        arrCols(6) = New DataGridViewTextBoxColumn()
        arrCols(6).HeaderText = "% Sobre Peso"
        arrCols(6).Name = "C_SP"
        arrCols(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        arrCols(6).ReadOnly = True
        arrCols(6).Width = 2

        arrCols(7) = New DataGridViewTextBoxColumn()
        arrCols(7).HeaderText = "Peso Neto Kgs. Scrap"
        arrCols(7).Name = "C_PNS"
        arrCols(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        arrCols(7).ReadOnly = True
        arrCols(7).Width = 2

        arrCols(8) = New DataGridViewTextBoxColumn()
        arrCols(8).HeaderText = "% Scrap"
        arrCols(8).Name = "C_SC"
        arrCols(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        arrCols(8).ReadOnly = True

        DGV.Columns.AddRange(arrCols) 'Agregamos el conjunto de Columnas al DataGridView. 
    End Sub

    Public Shared Sub SummaryMachine(ByVal DGV As DataGridView)

        'DGV.Columns.Clear()

        Dim arrCols(0 To 6) As DataGridViewColumn           'Arreglo que contendrá la definición de las columnas.

        arrCols(0) = New DataGridViewTextBoxColumn()        'Creación del Objeto de Columna en la posición '0' del Arreglo.     
        arrCols(0).HeaderText = "Puesto de Trabajo"         'Texto de Cabecera de la Columna.     
        arrCols(0).Name = "C_Equipo"                        'Nombre de la Columna dentro del DataGridView.   
        arrCols(0).ReadOnly = True

        arrCols(1) = New DataGridViewTextBoxColumn()
        arrCols(1).HeaderText = "Tramos"
        arrCols(1).Name = "C_Tramos"
        arrCols(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        arrCols(1).ReadOnly = True

        arrCols(2) = New DataGridViewTextBoxColumn()
        arrCols(2).HeaderText = "Peso Neto Kgs."
        arrCols(2).Name = "C_PN"
        arrCols(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        arrCols(2).ReadOnly = True

        arrCols(3) = New DataGridViewTextBoxColumn()
        arrCols(3).HeaderText = "Peso Teorico Kgs."
        arrCols(3).Name = "C_PT"
        arrCols(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        arrCols(3).ReadOnly = True
        arrCols(3).Width = 2

        arrCols(4) = New DataGridViewTextBoxColumn()
        arrCols(4).HeaderText = "% Sobre Peso"
        arrCols(4).Name = "C_SP"
        arrCols(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        arrCols(4).ReadOnly = True
        arrCols(4).Width = 2

        arrCols(5) = New DataGridViewTextBoxColumn()
        arrCols(5).HeaderText = "Peso Neto Kgs. Scrap"
        arrCols(5).Name = "C_PNS"
        arrCols(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        arrCols(5).ReadOnly = True
        arrCols(5).Width = 2

        arrCols(6) = New DataGridViewTextBoxColumn()
        arrCols(6).HeaderText = "% Scrap"
        arrCols(6).Name = "C_SC"
        arrCols(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        arrCols(6).ReadOnly = True

        DGV.Columns.AddRange(arrCols) 'Agregamos el conjunto de Columnas al DataGridView. 
    End Sub


    Public Shared Sub Colums_ControlTiempos(ByVal DGV As DataGridView)
        DGV.Columns.Clear()

        Dim arrCols(0 To 16) As DataGridViewColumn       'Arreglo que contendrá la definición de las columnas.

        arrCols(0) = New DataGridViewTextBoxColumn()    'Creación del Objeto de Columna en la posición '0' del Arreglo.     
        arrCols(0).HeaderText = "Id"                'Texto de Cabecera de la Columna.     
        arrCols(0).Name = "Id"                       'Nombre de la Columna dentro del DataGridView.   
        arrCols(0).ReadOnly = True

        arrCols(1) = New DataGridViewTextBoxColumn()
        arrCols(1).HeaderText = "Puesto Trabajo"
        arrCols(1).Name = "Equipo_Basico"
        arrCols(1).ReadOnly = True

        arrCols(2) = New DataGridViewTextBoxColumn()
        arrCols(2).HeaderText = "Orden"
        arrCols(2).Name = "No_Orden"
        arrCols(2).ReadOnly = True

        arrCols(3) = New DataGridViewTextBoxColumn()
        arrCols(3).HeaderText = "Código"
        arrCols(3).Name = "C_Codigo"
        arrCols(3).ReadOnly = True

    End Sub

    Public Shared Sub Colums_CalculaEmbalajes(ByVal DGV As DataGridView)

        DGV.Columns.Clear()

        Dim arrCols(0 To 4) As DataGridViewColumn       'Arreglo que contendrá la definición de las columnas.

        arrCols(0) = New DataGridViewTextBoxColumn()    'Creación del Objeto de Columna en la posición '0' del Arreglo.     
        arrCols(0).HeaderText = "Código"                'Texto de Cabecera de la Columna.     
        arrCols(0).Name = "C_Emb"                       'Nombre de la Columna dentro del DataGridView.   
        arrCols(0).ReadOnly = True

        arrCols(1) = New DataGridViewTextBoxColumn()
        arrCols(1).HeaderText = "Descripción Embalaje"
        arrCols(1).Name = "D_Emb"
        arrCols(1).ReadOnly = True

        arrCols(2) = New DataGridViewTextBoxColumn()
        arrCols(2).HeaderText = "Tipo Embalaje"
        arrCols(2).Name = "T_Emb"
        arrCols(2).ReadOnly = True
        arrCols(2).Visible = False

        arrCols(3) = New DataGridViewTextBoxColumn()
        arrCols(3).HeaderText = "Total Piezas"
        arrCols(3).Name = "TPiezas"
        arrCols(3).ReadOnly = True

        arrCols(4) = New DataGridViewTextBoxColumn()
        arrCols(4).HeaderText = "Total Peso"
        arrCols(4).Name = "TPeso"
        arrCols(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        arrCols(4).ReadOnly = True

        DGV.Columns.AddRange(arrCols) 'Agregamos el conjunto de Columnas al DataGridView. 
    End Sub

    Public Shared Sub DGV_Formating(DGV As DataGridView, Columna As Integer, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs)
        Dim Status As Boolean
        Status = (DGV.Rows(e.RowIndex).Cells(Columna).Value)
        If Status = True Then
            e.CellStyle.BackColor = Color.LightGreen
            e.CellStyle.ForeColor = Color.Black
        ElseIf Status = False Then
            e.CellStyle.BackColor = Color.LightSalmon
            e.CellStyle.ForeColor = Color.Black
        End If
    End Sub

    Public Shared Sub DGV_Formating_Produccion(DGV As DataGridView, Columna As Integer, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs)
        Dim Status As String
        Status = (DGV.Rows(e.RowIndex).Cells(Columna).Value)

        If Status = "1" Then
            e.CellStyle.BackColor = Color.LightGreen
            e.CellStyle.ForeColor = Color.Black
        ElseIf Status = "0" Or Status = "4" Or Status = "3" Then
            e.CellStyle.BackColor = Color.Yellow
            e.CellStyle.ForeColor = Color.Black
        ElseIf Status = "9" Then
            e.CellStyle.BackColor = Color.Red
            e.CellStyle.ForeColor = Color.White
        End If

    End Sub

    Public Shared Sub DGV_Formating_Estandar(DGV As DataGridView)
        With DGV
            .RowsDefaultCellStyle.BackColor = Color.White
            .AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue
        End With
    End Sub

End Class
