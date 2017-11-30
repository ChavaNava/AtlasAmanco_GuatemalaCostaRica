Imports System.Drawing.Text

Public Class ProductoTerminadoExtrusion
#Region "Eventos"
#End Region

#Region "Variables miembro"
    Private m_centro As String
    Private m_codigo As String
    Private m_descripcion As String
    Private m_unidadMedida As String
    Private m_pesoEstandar As Decimal
    Private m_pesoTeorico As Decimal
    Private m_empaque As String
    Private m_longitud As Decimal
    Private m_diametroMM As Decimal
    Private m_sobrePeso As Decimal
    Private m_grpProd As String
    Private m_codSeccion As String
    Private m_codUsoMaquina As String
    Private m_valCompuesto As Char
    Private m_numUnPaq As Decimal
    Private m_grpMaterial As String
    Private m_conCombinado As Boolean
    Private m_pesoAcumulado As Decimal
    Private m_pesoEmb As Decimal
#End Region

#Region "Constructores"
    Public Sub New()
        m_centro = ""
        m_codigo = ""
        m_descripcion = ""
        m_unidadMedida = ""
        m_pesoEstandar = 0.0
        m_pesoTeorico = 0.0
        m_empaque = ""
        m_longitud = 0.0
        m_diametroMM = 0.0
        m_sobrePeso = 0.0
        m_grpProd = ""
        m_codSeccion = ""
        m_codUsoMaquina = ""
        m_valCompuesto = ""
        m_numUnPaq = 0.0
        m_grpMaterial = ""
        m_conCombinado = False
        m_pesoAcumulado = 0.0
        m_pesoEmb = 0.0
    End Sub

    Public Sub New(ByVal centro As String, ByVal codigo As String, ByVal descripcion As String, ByVal unidadMedida As String, _
                   ByVal pesoEstandar As Decimal, ByVal pesoTeorico As Decimal, ByVal empaque As String, _
                   ByVal longitud As Decimal, ByVal diametroMM As Decimal, ByVal sobrePeso As Decimal, _
                   ByVal grpProd As String, ByVal codSeccion As String, ByVal codUsoMaquina As String, _
                   ByVal valCompuesto As Char, ByVal numUnPaq As Decimal, ByVal grpMaterial As String, _
                   ByVal conCombinado As Boolean, ByVal pesoAcumulado As Decimal, ByVal pesoEmb As Decimal)
        m_centro = centro.Trim
        m_codigo = codigo.Trim
        m_descripcion = descripcion.Trim
        m_unidadMedida = unidadMedida.Trim
        m_pesoEstandar = pesoEstandar
        m_pesoTeorico = pesoTeorico
        m_empaque = empaque.Trim
        m_longitud = longitud
        m_diametroMM = diametroMM
        m_sobrePeso = sobrePeso
        m_grpProd = grpProd.Trim
        m_codSeccion = codSeccion.Trim
        m_codUsoMaquina = codUsoMaquina.Trim
        m_valCompuesto = valCompuesto
        m_numUnPaq = numUnPaq
        m_grpMaterial = grpMaterial.Trim
        m_conCombinado = conCombinado
        m_pesoAcumulado = pesoAcumulado
        m_pesoEmb = pesoEmb
    End Sub
#End Region

#Region "Enumeraciones"
#End Region

#Region "Clases anidadas"
#End Region

#Region "Propiedades"
    Property centro() As String
        Get
            Return m_centro
        End Get
        Set(ByVal value As String)
            m_centro = value
        End Set
    End Property

    Property codigo() As String
        Get
            Return m_codigo
        End Get
        Set(ByVal value As String)
            m_codigo = value
        End Set
    End Property

    Property descripcion() As String
        Get
            Return m_descripcion
        End Get
        Set(ByVal value As String)
            m_descripcion = value
        End Set
    End Property

    Property unidadMedida() As String
        Get
            Return m_unidadMedida
        End Get
        Set(ByVal value As String)
            m_unidadMedida = value
        End Set
    End Property

    Property pesoEstandar() As Decimal
        Get
            Return m_pesoEstandar
        End Get
        Set(ByVal value As Decimal)
            m_pesoEstandar = value
        End Set
    End Property

    Property pesoTeorico() As Decimal
        Get
            Return m_pesoTeorico
        End Get
        Set(ByVal value As Decimal)
            m_pesoTeorico = value
        End Set
    End Property

    Property empaque() As String
        Get
            Return m_empaque
        End Get
        Set(ByVal value As String)
            m_empaque = value
        End Set
    End Property

    Property longitud() As Decimal
        Get
            Return m_longitud
        End Get
        Set(ByVal value As Decimal)
            m_longitud = value
        End Set
    End Property

    Property diametroMM() As Decimal
        Get
            Return m_diametroMM
        End Get
        Set(ByVal value As Decimal)
            m_diametroMM = value
        End Set
    End Property

    Property sobrePeso() As Decimal
        Get
            Return m_sobrePeso
        End Get
        Set(ByVal value As Decimal)
            m_sobrePeso = value
        End Set
    End Property

    Property grpProd() As String
        Get
            Return m_grpProd
        End Get
        Set(ByVal value As String)
            m_grpProd = value
        End Set
    End Property

    Property codSeccion() As String
        Get
            Return m_codSeccion
        End Get
        Set(ByVal value As String)
            m_codSeccion = value
        End Set
    End Property

    Property codUsoMaquina() As String
        Get
            Return m_codUsoMaquina
        End Get
        Set(ByVal value As String)
            m_codUsoMaquina = value
        End Set
    End Property

    Property valCompuesto() As Char
        Get
            Return m_valCompuesto
        End Get
        Set(ByVal value As Char)
            m_valCompuesto = value
        End Set
    End Property

    Property numUnPaq() As Decimal
        Get
            Return m_numUnPaq
        End Get
        Set(ByVal value As Decimal)
            m_numUnPaq = value
        End Set
    End Property

    Property grpMaterial() As String
        Get
            Return m_grpMaterial
        End Get
        Set(ByVal value As String)
            m_grpMaterial = value
        End Set
    End Property

    Property conCombinado() As Boolean
        Get
            Return m_conCombinado
        End Get
        Set(ByVal value As Boolean)
            m_conCombinado = value
        End Set
    End Property

    Property pesoAcumulado() As Decimal
        Get
            Return m_pesoAcumulado
        End Get
        Set(ByVal value As Decimal)
            m_pesoAcumulado = value
        End Set
    End Property

    Property pesoEmb() As Decimal
        Get
            Return m_pesoEmb
        End Get
        Set(ByVal value As Decimal)
            m_pesoEmb = value
        End Set
    End Property
#End Region

#Region "Métodos"
    Public Sub cargarfuente()
        'Dim pfc As PrivateFontCollection = New PrivateFontCollection()
        'Dim fontFamily As FontFamily
        ''Obtenemos la fuente que se encuentra en el directorio de la aplicacion
        ''y la cargamos 
        'pfc.AddFontFile(My.Application.Info.DirectoryPath & "\IDAUHC39.TTF")
        'fontFamily = pfc.Families(0)
        'fuente = New Font(fontFamily, 16)
    End Sub

    Public Function FormatoCodigoBarras(ByVal code As String) As String
        Dim barcode As String = String.Empty
        barcode = String.Format("{0}", code)
        Return (barcode)
    End Function

    Shared Sub CB_Productos(ByVal CB As ComboBox, Usuario As String, Centro As String, Codigo_Emp As String, Tipo_Emp As String)
        Dim NDataSet1 As New DataSet
        Dim Q As String
        Q = ""
        Q = "PA_Producto_Terminado '" & Centro & "', '" & Codigo_Emp & "', '" & Tipo_Emp & "', 1"
        Combo(Q)
        NDataSet1 = DataSetCombo.Copy
        CB.DataSource = NDataSet1.Tables(0)
        CB.DisplayMember = "Producto"
        CB.ValueMember = "Codigo"
        CB.Text = ""
    End Sub
#End Region

#Region "Colección"
#End Region

#Region "Campos"
#End Region

End Class
