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

    Public Shared Sub AvanceOrden(ByVal DGV As DataGridView)
        Dim arrCols(0 To 13) As DataGridViewColumn           'Arreglo que contendrá la definición de las columnas.

        arrCols(0) = New DataGridViewTextBoxColumn()        'Creación del Objeto de Columna en la posición '0' del Arreglo.     
        arrCols(0).HeaderText = "Orden Producción"          'Texto de Cabecera de la Columna.     
        arrCols(0).Name = "Orden_Produccion"                'Nombre de la Columna dentro del DataGridView.   
        arrCols(0).ReadOnly = True

        arrCols(1) = New DataGridViewTextBoxColumn()
        arrCols(1).HeaderText = "Estatus Orden"
        arrCols(1).Name = "Estatus_Activa"
        arrCols(1).ReadOnly = True

        arrCols(2) = New DataGridViewTextBoxColumn()
        arrCols(2).HeaderText = "Puesto de Trabajo"
        arrCols(2).Name = "PuestoTrabajo"
        arrCols(2).ReadOnly = True

        arrCols(3) = New DataGridViewTextBoxColumn()
        arrCols(3).HeaderText = "Producción (Kg.)"
        arrCols(3).Name = "Produccionkg"
        arrCols(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        arrCols(3).ReadOnly = True

        arrCols(4) = New DataGridViewTextBoxColumn()
        arrCols(4).HeaderText = "Scrap (Kg.)"
        arrCols(4).Name = "Scrapkg"
        arrCols(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        arrCols(4).ReadOnly = True

        arrCols(5) = New DataGridViewTextBoxColumn()
        arrCols(5).HeaderText = "Sobrepeso (Kg.)"
        arrCols(5).Name = "Sobrepesokg"
        arrCols(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        arrCols(5).ReadOnly = True

        arrCols(6) = New DataGridViewTextBoxColumn()
        arrCols(6).HeaderText = "Teórico (Kg.)"
        arrCols(6).Name = "Teoricoskg"
        arrCols(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        arrCols(6).ReadOnly = True
        arrCols(6).Width = 2

        arrCols(7) = New DataGridViewTextBoxColumn()
        arrCols(7).HeaderText = "% Scap"
        arrCols(7).Name = "PorcScrap"
        arrCols(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        arrCols(7).ReadOnly = True
        arrCols(7).Width = 2

        arrCols(8) = New DataGridViewTextBoxColumn()
        arrCols(8).HeaderText = "% Sobrepeso"
        arrCols(8).Name = "PorcSobrepeso"
        arrCols(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        arrCols(8).ReadOnly = True
        arrCols(8).Width = 2

        arrCols(9) = New DataGridViewTextBoxColumn()
        arrCols(9).HeaderText = "Tramos requeridos"
        arrCols(9).Name = "Tramosrequeridos"
        arrCols(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        arrCols(9).ReadOnly = True

        arrCols(10) = New DataGridViewTextBoxColumn()
        arrCols(10).HeaderText = "Tramos producidos"
        arrCols(10).Name = "Tramosproducidos"
        arrCols(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        arrCols(10).ReadOnly = True

        arrCols(11) = New DataGridViewTextBoxColumn()
        arrCols(11).HeaderText = "Pendientes por producir"
        arrCols(11).Name = "Saldo"
        arrCols(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        arrCols(11).ReadOnly = True

        arrCols(12) = New DataGridViewTextBoxColumn()
        arrCols(12).HeaderText = "% Avance"
        arrCols(12).Name = "Avance"
        arrCols(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        arrCols(12).ReadOnly = True

        arrCols(13) = New DataGridViewTextBoxColumn()
        arrCols(13).HeaderText = "Estatus Avance"
        arrCols(13).Name = "EstatusAvance"
        arrCols(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        arrCols(13).ReadOnly = True
        arrCols(13).Visible = False

        DGV.Columns.AddRange(arrCols) 'Agregamos el conjunto de Columnas al DataGridView. 
    End Sub

    Public Shared Sub AvanceEquipo(ByVal DGV As DataGridView)
        Dim arrCols(0 To 13) As DataGridViewColumn           'Arreglo que contendrá la definición de las columnas.

        arrCols(0) = New DataGridViewTextBoxColumn()
        arrCols(0).HeaderText = "Puesto de Trabajo"
        arrCols(0).Name = "PuestoTrabajo"
        arrCols(0).ReadOnly = True

        arrCols(1) = New DataGridViewTextBoxColumn()
        arrCols(1).HeaderText = "Estatus Orden"
        arrCols(1).Name = "Estatus_Activa"
        arrCols(1).ReadOnly = True

        arrCols(2) = New DataGridViewTextBoxColumn()
        arrCols(2).HeaderText = "Orden Producción"
        arrCols(2).Name = "Orden_Produccion"
        arrCols(2).ReadOnly = True

        arrCols(3) = New DataGridViewTextBoxColumn()
        arrCols(3).HeaderText = "Producción (Kg.)"
        arrCols(3).Name = "Produccionkg"
        arrCols(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        arrCols(3).ReadOnly = True

        arrCols(4) = New DataGridViewTextBoxColumn()
        arrCols(4).HeaderText = "Scrap (Kg.)"
        arrCols(4).Name = "Scrapkg"
        arrCols(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        arrCols(4).ReadOnly = True

        arrCols(5) = New DataGridViewTextBoxColumn()
        arrCols(5).HeaderText = "Sobrepeso (Kg.)"
        arrCols(5).Name = "Sobrepesokg"
        arrCols(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        arrCols(5).ReadOnly = True

        arrCols(6) = New DataGridViewTextBoxColumn()
        arrCols(6).HeaderText = "Teórico (Kg.)"
        arrCols(6).Name = "Teoricoskg"
        arrCols(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        arrCols(6).ReadOnly = True
        arrCols(6).Width = 2

        arrCols(7) = New DataGridViewTextBoxColumn()
        arrCols(7).HeaderText = "% Scap"
        arrCols(7).Name = "PorcScrap"
        arrCols(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        arrCols(7).ReadOnly = True
        arrCols(7).Width = 2

        arrCols(8) = New DataGridViewTextBoxColumn()
        arrCols(8).HeaderText = "% Sobrepeso"
        arrCols(8).Name = "PorcSobrepeso"
        arrCols(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        arrCols(8).ReadOnly = True
        arrCols(8).Width = 2

        arrCols(9) = New DataGridViewTextBoxColumn()
        arrCols(9).HeaderText = "Tramos requeridos"
        arrCols(9).Name = "Tramosrequeridos"
        arrCols(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        arrCols(9).ReadOnly = True

        arrCols(10) = New DataGridViewTextBoxColumn()
        arrCols(10).HeaderText = "Tramos producidos"
        arrCols(10).Name = "Tramosproducidos"
        arrCols(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        arrCols(10).ReadOnly = True

        arrCols(11) = New DataGridViewTextBoxColumn()
        arrCols(11).HeaderText = "Pendientes por producir"
        arrCols(11).Name = "Saldo"
        arrCols(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        arrCols(11).ReadOnly = True

        arrCols(12) = New DataGridViewTextBoxColumn()
        arrCols(12).HeaderText = "% Avance"
        arrCols(12).Name = "Avance"
        arrCols(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        arrCols(12).ReadOnly = True

        arrCols(13) = New DataGridViewTextBoxColumn()
        arrCols(13).HeaderText = "Estatus Avance"
        arrCols(13).Name = "EstatusAvance"
        arrCols(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        arrCols(13).ReadOnly = True
        arrCols(13).Visible = False

        DGV.Columns.AddRange(arrCols) 'Agregamos el conjunto de Columnas al DataGridView. 
    End Sub

    Public Shared Sub ResumenOrden(ByVal DGV As DataGridView)
        Dim arrCols(0 To 14) As DataGridViewColumn           'Arreglo que contendrá la definición de las columnas.

        arrCols(0) = New DataGridViewTextBoxColumn()        'Creación del Objeto de Columna en la posición '0' del Arreglo.     
        arrCols(0).HeaderText = "Orden Producción"          'Texto de Cabecera de la Columna.     
        arrCols(0).Name = "Orden_Produccion"                'Nombre de la Columna dentro del DataGridView.   
        arrCols(0).ReadOnly = True

        arrCols(1) = New DataGridViewTextBoxColumn()
        arrCols(1).HeaderText = "Planta"
        arrCols(1).Name = "Planta"
        arrCols(1).ReadOnly = True

        arrCols(2) = New DataGridViewTextBoxColumn()
        arrCols(2).HeaderText = "Estatus Orden"
        arrCols(2).Name = "Estatus_Activa"
        arrCols(2).ReadOnly = True

        arrCols(3) = New DataGridViewTextBoxColumn()
        arrCols(3).HeaderText = "Puesto de Trabajo"
        arrCols(3).Name = "PuestoTrabajo"
        arrCols(3).ReadOnly = True

        arrCols(4) = New DataGridViewTextBoxColumn()
        arrCols(4).HeaderText = "Producción (Kg.)"
        arrCols(4).Name = "Produccionkg"
        arrCols(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        arrCols(4).ReadOnly = True

        arrCols(5) = New DataGridViewTextBoxColumn()
        arrCols(5).HeaderText = "Scrap (Kg.)"
        arrCols(5).Name = "Scrapkg"
        arrCols(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        arrCols(5).ReadOnly = True

        arrCols(6) = New DataGridViewTextBoxColumn()
        arrCols(6).HeaderText = "Sobrepeso (Kg.)"
        arrCols(6).Name = "Sobrepesokg"
        arrCols(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        arrCols(6).ReadOnly = True

        arrCols(7) = New DataGridViewTextBoxColumn()
        arrCols(7).HeaderText = "Teórico (Kg.)"
        arrCols(7).Name = "Teoricoskg"
        arrCols(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        arrCols(7).ReadOnly = True
        arrCols(7).Width = 2

        arrCols(8) = New DataGridViewTextBoxColumn()
        arrCols(8).HeaderText = "% Scap"
        arrCols(8).Name = "PorcScrap"
        arrCols(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        arrCols(8).ReadOnly = True
        arrCols(8).Width = 2

        arrCols(9) = New DataGridViewTextBoxColumn()
        arrCols(9).HeaderText = "% Sobrepeso"
        arrCols(9).Name = "PorcSobrepeso"
        arrCols(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        arrCols(9).ReadOnly = True
        arrCols(9).Width = 2

        arrCols(10) = New DataGridViewTextBoxColumn()
        arrCols(10).HeaderText = "Tramos requeridos"
        arrCols(10).Name = "Tramosrequeridos"
        arrCols(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        arrCols(10).ReadOnly = True

        arrCols(11) = New DataGridViewTextBoxColumn()
        arrCols(11).HeaderText = "Tramos producidos"
        arrCols(11).Name = "Tramosproducidos"
        arrCols(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        arrCols(11).ReadOnly = True

        arrCols(12) = New DataGridViewTextBoxColumn()
        arrCols(12).HeaderText = "Pendientes por producir"
        arrCols(12).Name = "Saldo"
        arrCols(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        arrCols(12).ReadOnly = True

        arrCols(13) = New DataGridViewTextBoxColumn()
        arrCols(13).HeaderText = "% Avance"
        arrCols(13).Name = "Avance"
        arrCols(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        arrCols(13).ReadOnly = True

        arrCols(14) = New DataGridViewTextBoxColumn()
        arrCols(14).HeaderText = "Estatus Avance"
        arrCols(14).Name = "EstatusAvance"
        arrCols(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        arrCols(14).ReadOnly = True
        arrCols(14).Visible = False

        DGV.Columns.AddRange(arrCols) 'Agregamos el conjunto de Columnas al DataGridView. 
    End Sub

    Public Shared Sub ResumenEquipo(ByVal DGV As DataGridView)
        Dim arrCols(0 To 14) As DataGridViewColumn           'Arreglo que contendrá la definición de las columnas.

        arrCols(0) = New DataGridViewTextBoxColumn()        'Creación del Objeto de Columna en la posición '0' del Arreglo.     
        arrCols(0).HeaderText = "Puesto Trabajo"          'Texto de Cabecera de la Columna.     
        arrCols(0).Name = "PuestoTrabajo"                'Nombre de la Columna dentro del DataGridView.   
        arrCols(0).ReadOnly = True

        arrCols(1) = New DataGridViewTextBoxColumn()
        arrCols(1).HeaderText = "Planta"
        arrCols(1).Name = "Planta"
        arrCols(1).ReadOnly = True

        arrCols(2) = New DataGridViewTextBoxColumn()
        arrCols(2).HeaderText = "Estatus Orden"
        arrCols(2).Name = "Estatus_Activa"
        arrCols(2).ReadOnly = True

        arrCols(3) = New DataGridViewTextBoxColumn()
        arrCols(3).HeaderText = "Orden Producción"
        arrCols(3).Name = "OrdenProduccion"
        arrCols(3).ReadOnly = True

        arrCols(4) = New DataGridViewTextBoxColumn()
        arrCols(4).HeaderText = "Producción (Kg.)"
        arrCols(4).Name = "Produccionkg"
        arrCols(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        arrCols(4).ReadOnly = True

        arrCols(5) = New DataGridViewTextBoxColumn()
        arrCols(5).HeaderText = "Scrap (Kg.)"
        arrCols(5).Name = "Scrapkg"
        arrCols(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        arrCols(5).ReadOnly = True

        arrCols(6) = New DataGridViewTextBoxColumn()
        arrCols(6).HeaderText = "Sobrepeso (Kg.)"
        arrCols(6).Name = "Sobrepesokg"
        arrCols(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        arrCols(6).ReadOnly = True

        arrCols(7) = New DataGridViewTextBoxColumn()
        arrCols(7).HeaderText = "Teórico (Kg.)"
        arrCols(7).Name = "Teoricoskg"
        arrCols(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        arrCols(7).ReadOnly = True
        arrCols(7).Width = 2

        arrCols(8) = New DataGridViewTextBoxColumn()
        arrCols(8).HeaderText = "% Scap"
        arrCols(8).Name = "PorcScrap"
        arrCols(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        arrCols(8).ReadOnly = True
        arrCols(8).Width = 2

        arrCols(9) = New DataGridViewTextBoxColumn()
        arrCols(9).HeaderText = "% Sobrepeso"
        arrCols(9).Name = "PorcSobrepeso"
        arrCols(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        arrCols(9).ReadOnly = True
        arrCols(9).Width = 2

        arrCols(10) = New DataGridViewTextBoxColumn()
        arrCols(10).HeaderText = "Tramos requeridos"
        arrCols(10).Name = "Tramosrequeridos"
        arrCols(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        arrCols(10).ReadOnly = True

        arrCols(11) = New DataGridViewTextBoxColumn()
        arrCols(11).HeaderText = "Tramos producidos"
        arrCols(11).Name = "Tramosproducidos"
        arrCols(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        arrCols(11).ReadOnly = True

        arrCols(12) = New DataGridViewTextBoxColumn()
        arrCols(12).HeaderText = "Pendientes por producir"
        arrCols(12).Name = "Saldo"
        arrCols(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        arrCols(12).ReadOnly = True

        arrCols(13) = New DataGridViewTextBoxColumn()
        arrCols(13).HeaderText = "% Avance"
        arrCols(13).Name = "Avance"
        arrCols(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        arrCols(13).ReadOnly = True

        arrCols(14) = New DataGridViewTextBoxColumn()
        arrCols(14).HeaderText = "Estatus Avance"
        arrCols(14).Name = "EstatusAvance"
        arrCols(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        arrCols(14).ReadOnly = True
        arrCols(14).Visible = False

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

    Public Shared Sub dgvAvance(DGV As DataGridView, Columna As Integer, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs)
        Dim Avance As String
        Avance = (DGV.Rows(e.RowIndex).Cells(Columna).Value)

        If Avance = 1 Then
            e.CellStyle.BackColor = Color.LightGreen
            e.CellStyle.ForeColor = Color.Black
        ElseIf Avance = 2 Then
            e.CellStyle.BackColor = Color.Yellow
            e.CellStyle.ForeColor = Color.Black
        ElseIf Avance = 3 Then
            e.CellStyle.BackColor = Color.Red
            e.CellStyle.ForeColor = Color.Black
        End If
    End Sub

    Public Shared Sub dgvAvancePlaneacion(DGV As DataGridView, Columna As Integer, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs)
        Dim Avance As String
        Avance = (DGV.Rows(e.RowIndex).Cells(Columna).Value)

        If Avance = 1 Then
            e.CellStyle.BackColor = Color.LightGreen
            e.CellStyle.ForeColor = Color.Black
        ElseIf Avance = 2 Then
            e.CellStyle.BackColor = Color.Yellow
            e.CellStyle.ForeColor = Color.Black
        ElseIf Avance = 3 Then
            e.CellStyle.BackColor = Color.RoyalBlue
            e.CellStyle.ForeColor = Color.White
        ElseIf Avance = 4 Then
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
