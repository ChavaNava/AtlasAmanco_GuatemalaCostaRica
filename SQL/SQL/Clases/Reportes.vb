Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports Reporting
Public Class Reportes
#Region "Variables Miembro"
 
#End Region
    Public Shared Sub Detalle_X_Prd_Ord(ByVal Usuario As String, Centro As String, Orden As String, Area As String, Turno As String, FI As String, FF As String, HI As String, HF As String, TipoRep As String, CodSeccion As String)
        Dim Q As String
        Dim objDa As SqlDataAdapter
        Dim objDs As DataSet
        Dim Datos As SummaryInfo

        Q = ""
        Q = "PA_Consulta_Produccion_Reportes_2 " & Centro.Trim & "_OrdenProduccion, " & Centro.Trim & "_PesoProductoTerminado, '" & FI.Trim & "', '" & FF.Trim & "', '" & HI.Trim & "', '" & HF.Trim & "', '" & Orden.Trim & "',  '" & Turno.Trim & "',  '" & Area.Trim & "', '" & CodSeccion.Trim & "' "
        Try
            objDa = New SqlDataAdapter(Q, MSI(SessionUser._sAmbiente))
            objDs = New DataSet
            objDa.Fill(objDs)
            'objDs.WriteXmlSchema("c:\atlas\PTE_AMEX.xsd")
            'MessageBox.Show("Field Definitions Written Successfully")
        Catch ex As Exception
            MessageBox.Show("Error : " & ex.Message, "DATOS PRODUCCION")
            Exit Sub
        End Try

        If TipoRep.Trim = "Prd" Then
            Dim RPT As New rptPTEOrdEntXProd
            IMP_Reporte.Imprimir(RPT, objDs, "Reporte Producto Terminado Ordenado por Producto", Datos, Centro, "0", "DPO")
        ElseIf TipoRep.Trim = "Ord" Then
            Dim RPT As New rptPTEOrdEntXODF
            IMP_Reporte.Imprimir(RPT, objDs, "Reporte Producto Terminado Ordenado por Orden de Producción", Datos, Centro, "0", "DPO")
        ElseIf TipoRep.Trim = "D_Eqp" Then
            Dim RPT As New rptPTEOrdEntXMaquina
            IMP_Reporte.Imprimir(RPT, objDs, "Reporte Producto Terminado Ordenado por Orden de Producción", Datos, Centro, "0", "DPO")
        End If
    End Sub

    Public Shared Sub Resumen_X_Prd_Ord(ByVal Usuario As String, Centro As String, Orden As String, Notifica As String, Area As String, Seccion As String, Turno As String, FI As String, FF As String, HI As String, HF As String)
        Dim Q As String
        Dim objDa As SqlDataAdapter
        Dim objDs As DataSet
        Dim Datos As SummaryInfo

        Q = ""
        Q = "PA_Consulta_Prod_Resumen_2 '" & Centro & "', '" & Notifica & "', '" & Area & "', '" & Seccion & "', '" & Turno & "', '" & FI & "', '" & FF & "', '" & HI & "', '" & HF & "', '" & Orden & "' "
        Try
            objDa = New SqlDataAdapter(Q, MSI(SessionUser._sAmbiente))
            objDs = New DataSet
            objDa.Fill(objDs)
            'Arma la estrucutura del reporte
            'objDs.WriteXmlSchema("C:\Estructuras Reportes Atlas\ResumenPesajeXOrdenFabricacion.xsd")
            'MessageBox.Show("Field Definitions Written Successfully")
        Catch ex As Exception
            MessageBox.Show("Error : " & ex.Message, "DATOS PRODUCCION")
            Exit Sub
        End Try

        Dim RPT As New rptResumenProdxOdf
        IMP_Reporte.Imprimir(RPT, objDs, "RESUME CONSUMOS DE PRODUCTO TERMINADO / SCRAP POR NUMERO DE ORDEN" & vbCr & "  del  " + FI.Trim + "  al  " + FF.Trim, Datos, Centro, "0", "DPO")

    End Sub

    Public Shared Sub Resumen_X_Eqp(ByVal Usuario As String, Centro As String, Orden As String, Notifica As String, Area As String, Seccion As String, Turno As String, FI As String, FF As String, HI As String, HF As String)
        Dim Q As String
        Dim objDa As SqlDataAdapter
        Dim objDs As DataSet
        Dim Datos As SummaryInfo

        Q = ""
        Q = "PA_Consulta_Eqp_Resumen_2 '" & Centro & "', '" & Notifica & "', '" & Area & "', '" & Seccion & "', '" & Turno & "', '" & FI & "', '" & FF & "', '" & HI & "', '" & HF & "', '" & Orden & "' "
        Try
            objDa = New SqlDataAdapter(Q, MSI(SessionUser._sAmbiente))
            objDs = New DataSet
            objDa.Fill(objDs)
            'Arma la estrucutura del reporte
            'objDs.WriteXmlSchema("C:\Estructuras Reportes Atlas\ResumenPesajeXOrdenFabricacion.xsd")
            'MessageBox.Show("Field Definitions Written Successfully")
        Catch ex As Exception
            MessageBox.Show("Error : " & ex.Message, "DATOS PRODUCCION")
            Exit Sub
        End Try

        Dim RPT As New rptResumenProdxeqp
        IMP_Reporte.Imprimir(RPT, objDs, "RESUME CONSUMOS DE PRODUCTO TERMINADO / SCRAP POR PUESTO DE TRABAJO" & vbCr & "  del  " + FI.Trim + "  al  " + FF.Trim, Datos, Centro, "0", "DPO")

    End Sub

    Public Shared Sub Boleta_PTE(ByVal IdFolio As String)
        Dim rTitulo1 As String = "PESAJE PRODUCTO TERMINADO EXTRUSIÓN"
        Dim rLeyenda1 As String = ""
        Dim RPT1 As New Boleta_PTE_doble
        IMP_Reporte.ImprimirBoletaDoble(RPT1, BoletaDataSet(IdFolio, rTitulo1, rLeyenda1))
    End Sub


    Public Shared Sub Boleta_Pesaje_PTE_Ext(ByVal Usuario As String, Centro As String, ByVal Orden As String, folio As String, St As String)
        Dim Q As String
        Dim objDa As SqlDataAdapter
        Dim objDs As DataSet
        Dim Datos As SummaryInfo

        Q = ""
        Q = "PA_Boleta_Pesaje_PT_1 " & Centro.Trim & "_OrdenProduccion, " & Centro.Trim & "_PesoProductoTerminado, '" & Orden.Trim & "', '" & folio.Trim & "', '2' "
        Try
            objDa = New SqlDataAdapter(Q, MSI(SessionUser._sAmbiente))
            objDs = New DataSet
            objDa.Fill(objDs)
        Catch ex As Exception
            MessageBox.Show("Error : " & ex.Message, "DATOS PRODUCCION")
            Return
        End Try

        If Centro.Trim = "A022" Or Centro.Trim = "A014" Then
            Dim RPT As New Boleta_PTE_D
            Datos = RPT.SummaryInfo
            Datos.ReportComments = "" & Centro.Trim & ""
            IMP_Reporte.Imprimir(RPT, objDs, "PESAJE PRODUCTO TERMINADO EXTRUSIÓN", Datos, Centro, St, "BPE")
        ElseIf Centro.Trim = "A001" Then
            Dim RPT As New Boleta_PTE_D
            Datos = RPT.SummaryInfo
            Datos.ReportComments = "" & Centro.Trim & ""
            IMP_Reporte.Imprimir(RPT, objDs, "PESAJE PRODUCTO TERMINADO EXTRUSIÓN", Datos, Centro, St, "BPE")
        ElseIf Centro.Trim = "CR01" Then
            Dim RPT As New Etiqueta_CR01
            Datos = RPT.SummaryInfo
            Datos.ReportComments = "" & Centro.Trim & ""
            IMP_Reporte.Imprimir(RPT, objDs, "PESAJE PRODUCTO TERMINADO EXTRUSIÓN", Datos, Centro, St, "BPE")
        ElseIf Centro.Trim = "GT01" Then
            Dim RPT As New Boleta_PTE_GT
            Datos = RPT.SummaryInfo
            Datos.ReportComments = "" & Centro.Trim & ""
            IMP_Reporte.Imprimir(RPT, objDs, "PESAJE PRODUCTO TERMINADO EXTRUSIÓN", Datos, Centro, St, "BPE")
        Else
            Dim RPT As New Boleta_PTE
            Datos = RPT.SummaryInfo
            Datos.ReportComments = "" & Centro.Trim & ""
            IMP_Reporte.Imprimir(RPT, objDs, "PESAJE PRODUCTO TERMINADO EXTRUSIÓN", Datos, Centro, St, "BPE")
        End If

    End Sub

    Public Shared Sub Boleta_Pesaje_SCE_Ext(ByVal Usuario As String, Centro As String, ByVal Orden As String, folio As String, St As String)
        Dim Q As String
        Dim objDa As SqlDataAdapter
        Dim objDs As DataSet
        Dim Datos As SummaryInfo

        Q = ""
        Q = "PA_Boleta_Pesaje_SC " & Centro.Trim & "_OrdenProduccion, " & Centro.Trim & "_PesoScrap, '" & Orden.Trim & "', '" & folio.Trim & "'"
        Try
            objDa = New SqlDataAdapter(Q, MSI(SessionUser._sAmbiente))
            objDs = New DataSet
            objDa.Fill(objDs)
        Catch ex As Exception
            MessageBox.Show("Error : " & ex.Message, "DATOS PRODUCCION")
            Return
        End Try

        If Centro.Trim = "A022" Then
            Dim RPT As New Boleta_SCE_D
            Datos = RPT.SummaryInfo
            Datos.ReportComments = "" & Centro.Trim & ""
            IMP_Reporte.Imprimir(RPT, objDs, "PESAJE SCRAP EXTRUSIÓN", Datos, Centro, St, "BSCE")
        Else
            Dim RPT As New Boleta_SCE
            Datos = RPT.SummaryInfo
            Datos.ReportComments = "" & Centro.Trim & ""
            IMP_Reporte.Imprimir(RPT, objDs, "PESAJE SCRAP EXTRUSIÓN", Datos, Centro, St, "BSCE")
        End If
    End Sub

    Public Shared Sub Consumo_Compuesto_X_Producto(ByVal Usuario As String, Centro As String, Turno As String, FI As String, FF As String, HI As String, HF As String, Orden As String)
        Dim Q As String
        Dim objDa As SqlDataAdapter
        Dim objDs As DataSet
        Dim Datos As SummaryInfo

        Q = ""
        Q = "PA_Consulta_Compuesto_Consumos_PT_SC_2 '" & Centro.Trim & "', '" & FI.Trim & "', '" & FF.Trim & "', '" & HI.Trim & "', '" & HF.Trim & "', '" & Turno.Trim & "', '" & Orden.Trim & "' "
        Try
            objDa = New SqlDataAdapter(Q, MSI(SessionUser._sAmbiente))
            objDs = New DataSet
            objDa.Fill(objDs)
            'Arma la estrucutura del reporte
            'objDs.WriteXmlSchema("C:\Estructuras Reportes Atlas\Consumo_Compuesto_Producto.xsd")
            'MessageBox.Show("Field Definitions Written Successfully")
        Catch ex As Exception
            MessageBox.Show("Error : " & ex.Message, "DATOS PRODUCCION")
            Return
        End Try
        Dim RPT As New rptConsumoCompuestoXProd
        Datos = RPT.SummaryInfo
        IMP_Reporte.Imprimir(RPT, objDs, "CONSUMO DE COMPUESTO RODUCTO TERMINADO EXTRUSIÓN X PRODUCTO " & vbCr & " del " + FI.Trim + "  al  " + FF.Trim, Datos, Centro, "0", "CCXP")
    End Sub

    Public Shared Sub Consumo_Compuesto_X_Orden(ByVal Usuario As String, Centro As String, Turno As String, FI As String, FF As String, HI As String, HF As String, Orden As String)
        Dim Q As String
        Dim objDa As SqlDataAdapter
        Dim objDs As DataSet
        Dim Datos As SummaryInfo

        Q = ""
        Q = "PA_Consulta_Compuesto_Consumos_PT_SC_2 '" & Centro.Trim & "', '" & FI.Trim & "', '" & FF.Trim & "', '" & HI.Trim & "', '" & HF.Trim & "', '" & Turno.Trim & "', '" & Orden.Trim & "' "
        Try
            objDa = New SqlDataAdapter(Q, MSI(SessionUser._sAmbiente))
            objDs = New DataSet
            objDa.Fill(objDs)
            'Arma la estrucutura del reporte
            'objDs.WriteXmlSchema("C:\Estructuras Reportes Atlas\Consumo_Compuesto_Producto.xsd")
            'MessageBox.Show("Field Definitions Written Successfully")
        Catch ex As Exception
            MessageBox.Show("Error : " & ex.Message, "DATOS PRODUCCION")
            Return
        End Try
        Dim RPT As New rptConsumoCompuestoXOrden
        Datos = RPT.SummaryInfo
        IMP_Reporte.Imprimir(RPT, objDs, "CONSUMO DE COMPUESTO RODUCTO TERMINADO EXTRUSIÓN X ORDEN DE FABRICACION " & vbCr & " del " + FI.Trim + "  al  " + FF.Trim, Datos, Centro, "0", "CCXP")
    End Sub

    Public Shared Sub Boleta_Pesaje_PTE_Iny(ByVal Usuario As String, Centro As String, ByVal Orden As String, folio As String, St As String)
        Dim Q As String
        Dim objDa As SqlDataAdapter
        Dim objDs As DataSet
        Dim Datos As SummaryInfo

        Q = ""
        Q = "PA_Boleta_Pesaje_PT " & Centro.Trim & "_OrdenProduccion, " & Centro.Trim & "_PesoProductoTerminado, '" & Orden.Trim & "', '" & folio.Trim & "' "
        Try
            objDa = New SqlDataAdapter(Q, MSI(SessionUser._sAmbiente))
            objDs = New DataSet
            objDa.Fill(objDs)
            'Arma la estrucutura del reporte
            'objDs.WriteXmlSchema("C:\Estructuras Reportes Atlas\EST_BOLETA_PESAJE_PTE.xsd")
            'MessageBox.Show("Field Definitions Written Successfully")
        Catch ex As Exception
            MessageBox.Show("Error : " & ex.Message, "DATOS PRODUCCION")
            Return
        End Try

        Dim RPT As New Boleta_PTI_CR01
        Datos = RPT.SummaryInfo
        Datos.ReportComments = "" & Centro.Trim & ""
        IMP_Reporte.Imprimir(RPT, objDs, "PESAJE PRODUCTO TERMINADO INYECCIÓN", Datos, Centro, St, "BPI")
    End Sub

    Public Shared Sub Boleta_Pesaje_SCE_Iny(ByVal Usuario As String, Centro As String, ByVal Orden As String, folio As String, St As String)

    End Sub

    Public Shared Sub Reporte_Entrega(ByVal Usuario As String, Centro As String, Orden As String, Notifica As String, Area As String, _
                                  Seccion As String, Turno As String, FI As String, FF As String, HI As String, HF As String)
        Dim Q As String
        Dim objDa As SqlDataAdapter
        Dim objDs As DataSet
        Dim Datos As SummaryInfo

        Q = ""
        Q = "PA_Reporte_Entrega '" & Centro & "', '" & Notifica & "', '" & Area & "', '" & Seccion & "', '" & Turno & "', '" & FI & "', '" & FF & "', '" & HI & "', '" & HF & "', '" & Orden & "' "
        Try
            objDa = New SqlDataAdapter(Q, MSI(SessionUser._sAmbiente))
            objDs = New DataSet
            objDa.Fill(objDs)
            'Arma la estrucutura del reporte
            'objDs.WriteXmlSchema("C:\Estructuras Reportes Atlas\Reporte_Entrega.xsd")
            'MessageBox.Show("Field Definitions Written Successfully")
        Catch ex As Exception
            MessageBox.Show("Error : " & ex.Message, "DATOS PRODUCCION")
            Return
        End Try
        Dim RPT As New rptPTEntrega
        Datos = RPT.SummaryInfo
        IMP_Reporte.Imprimir(RPT, objDs, "REPORTE DE PRODUCTO TERMINADO " & vbCr & " del " + FI.Trim + "  al  " + FF.Trim, Datos, Centro, "0", "")
    End Sub

#Region "Metodos"
    Public Shared Function BoletaDataSet(ByVal IdPesaje As String, TxtTitulo As String, TxtLeyenda As String) As List(Of BoletaInfo)
        Dim listaInfos As New List(Of BoletaInfo)
        Dim Info As New BoletaInfo

        BoletaPesaje.Read(IdPesaje)

        'Info.idPesaje = BoletaRead._IdPesaje
        'Info.D_Origen = BoletaRead._D_Origen
        'Info.D_Destino = BoletaRead._D_Destino
        'Info.C_Producto = BoletaRead._C_Producto
        'Info.Especificacion = BoletaRead._Especificacion
        'Info.Lote = BoletaRead._Lote
        'Info.D_Transportista = BoletaRead._D_Transportista
        'Info.Clave = BoletaRead._Clave
        'Info.IdTractor = BoletaRead._IdTractor
        'Info.Placas = BoletaRead._Placas
        'Info.N_Operador = BoletaRead._N_Operador
        'Info.Registro_FH = BoletaRead._Registro_FH
        ''Info.Registro_User = BoletaRead._Registro_User
        'Info.Registro_User = IdBascula
        'Info.IdTipoPesaje = BoletaRead._IdTipoPesaje
        'Info.PesoBruto = BoletaRead._PesoBruto
        'Info.PesoTara = BoletaRead._PesoTara
        'Info.PesoNeto = BoletaRead._PesoNeto
        'Info.FHEntrada = BoletaRead._FHEntrada
        'Info.UsrEntrada = BoletaRead._UsrEntrada
        'Info.FHSalida = BoletaRead._FHSalida
        'Info.UsrSalida = BoletaRead._UsrSalida
        'Info.Pedido = BoletaRead._Pedido
        'Info.Logo = Util.ConvertImageFiletoBytes("C:\App Settings\Reportes\mexichem.png")
        'Info.QR = Util.ConvertImageFiletoBytes("C:\App Settings\Reportes\QRCode.jpg")
        'Info.Titulo = TxtTitulo
        'Info.Leyenda = TxtLeyenda
        listaInfos.Add(Info)

        Return listaInfos

    End Function
#End Region
End Class
