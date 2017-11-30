Imports System.Windows.Forms

Public Class ControlDgv
    Public Shared Sub OrdenProduccion(ByVal DGV As DataGridView)

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
End Class
