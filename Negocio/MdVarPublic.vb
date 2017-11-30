Imports System.Data.SqlClient
Imports System.Configuration
Module MdVarPublic
#Region "Inyección"
    'Variables Embalajes
    Public Pzas_Cajas As String
    Public Peso_Cajas As String
    Public Pzas_Bolsas As String
    Public Peso_Bolsas As String
#End Region
    Public cnnMsi As Conexion
    Public cnnUsuarios As Conexion
    Public miSesion As Sesion
    Public objCnn As SqlConnection
    Public objCnnQim As SqlConnection
    Public objCnnAmanco As SqlConnection
    Public objCmd As SqlCommand
    Public objDa As SqlDataAdapter
    Public objDs As DataSet
    Public objDRes As DataSet
    Public objDDet As DataSet
    Public objDaC As SqlDataAdapter
    Public objDsC As DataSet
    Public strNumeroPlanta As String
    'Public strAmbiente As String
    Public strOperador As String
    Public StrOrdProd As String
    Public strTurno As String
    'Public strNomPlanta As String
    Public strUsuario As String
    'Public StrusrNom As String
    'Public gPerfil As String
    Public UsrLog As String
    Public PlantaLog As String
    Public formaMP As Form
    Public OrdPrd As String
    '----- Variables para ingreso de orden de fabricación ------  
    Public Gen_Valida As New Validaciones
    Public Permiso As New Permisos
    '---- Variables para WS's
    Public Header_Notifica As String
    'Public Header_Duplicado As String

    Public Btn_Notificar As String
    ' ---------------------------------------------------------------------------------
    Public strArea As String           'Area o departamento al cual pertence
    ' ---------------------------------------------------------------------------------
    Public GEMPRESA As String = ""
    Public GIDIOMA As String = ""
    Public GDECIMAL As String = "."

    ' ---------------------------------------------------------------------------------
    Public NumPto As String
    Public Baudios As String
    Public DataBit As String
    'Public TPC As String
    'Public TPC2 As String
    Public CH1 As String
    Public CH2 As String
    Public AddChar As Integer = 0
    Public LenghtLec As Integer = 0
    ' ---------------------------------------------------------------------------------

    Public C_Bascula As String
    Public C_Bascula_2 As String
    Public C_Bascula_3 As String
    'Variables para login de usuario --------------------------------------------------
    Public strclave As String

    Public IntPuesto As Integer
    'Public Strtipo As String
    Public StrTexto1 As String
    Public StrTexto2 As String
    'Public Depto As String

    Public Bascula_1 As String = ""
    Public Bascula_2 As String = ""
    Public Bascula_3 As String = ""
    ' ---------------------------------------------------------------------------------
    'Public Usrsap As String = "ATLAS"
    Public Usrsap As String = "libra"
    'Public Password As String = "m3x1ch3m4tl4s"
    Public Password As String = "mxlibra$"

    ' ---------------------------------------------------------------------------------
    'Declaracion de clases propias
    Public CBG As New Generic_CB
    Public Ins_Gen As New Generica_DB

    Public DBG As New Generica_DB
    Public IA_ODF As New IAC_ODF
    ' ---------------------------------------------------------------------------------
    Public strNumeroBascula As String
    Public AutorizaPesaje As Boolean = False
    ' ---------------------------------------------------------------------------------
    Public Modulo As String
    Public elQRY As String
    Public Q As String                          'String para querys
    ' ---------------------------------------------------------------------------------
    Public QRY As String                        'Qry para BD Amanco 
    Public Qry_SP As String                     'Query para Store Procedure
    Public Param_1 As New SqlParameter          'Parametro 1 Para Store Procedure
    Public Param_2 As New SqlParameter          'Parametro 2 Para Store Procedure
    Public Param_3 As New SqlParameter          'Parametro 3 Para Store Procedure
    Public Param_4 As New SqlParameter          'Parametro 4 Para Store Procedure
    Public QRY_AMD As String                    'Qry para BD Usuarios
    Public InQry As String                      'Qry Insert para BD Amanco
    Public RegresaCeroIzq As String             'Variable Regresa sin ceros
    Public CeroIzq As String                    'Strig de validación
    Public QryCombo As String                   'Qry para Combos Amanco
    Public QRY_Grid As String                   'Qry para GRID Amanco
    Public DataSetCombo As New DataSet          'DataSet Combo
    Public NameTable As String                  'Name of table DataGridView 
    Public QRY_Grid_AMD As String               'Qry para GRID Amanco
    Public NameTable_AMD As String
    Public bindingSource1 As New BindingSource
    Public bindingSource2 As New BindingSource
    ' ---------------------------------------------------------------------------------
    Public LecturaBD As SqlClient.SqlDataReader
    Public LecturaBD_AMD As SqlClient.SqlDataReader
    Public InsertBD As Integer
    Public InsertBD_AMD As Integer
    Public NumEmpaques As String    'Número de Empaques 
    ' ---------------------------------------------------------------------------------
    Public ValPublic_CompuestoVirgen As String = ""
    Public ValPublic_ReproConsumo As String = ""
    Public ValPublic_Ccompuesto1 As String = ""
    Public ValPublic_Ccompuesto2 As String = ""
    Public ValPublic_PorcentajeCom1 As Integer = 0
    Public ValPublic_PorcentajeCom2 As Integer = 0
    ' ---------------------------------------------------------------------------------
    Public Help_TipoBD As String
    Public Help_QryGrid As String
    Public Help_TableNameGrid As String
    Public Help_Array(3) As String
    Public Help_BindingSource As New BindingSource
    Public Help_HeaderGrid_1 As String
    Public Help_HeaderGrid_2 As String
    Public Help_HeaderGrid_3 As String
    Public Help_HeaderForm As String
    Public GenericConexion As New SqlClient.SqlConnection
    Public DataSetGrid2 As New DataSet
    ' ---------------------------------------------------------------------------------
    Public SobrepesoPermitido As Decimal = "0"

    Public SuperAutoSobrepeso As String
    Public ObserSobrepeso As String
    Public StrProces As String = ""
    Public Forma As String = ""
    Public FUERATURNO As Integer = 0

    Public StrProducto As String = ""
    Public StatusConfiCompuesto As String = ""
    ' ---------------------------------------------------------------------------------
    Public FiltroQryHelp As String
    Public ValFiltroCodigo As String
    Public ValFiltroDesc As String
    Public ValFiltroSeleccionCodigo As String = "0"
    Public ValFiltroSeleccionDesc As String
    Public ValFiltroPresentacion As String
    ' ---------------------------------------------------------------------------------
    Public QRY_Grid1 As String                   'Qry para GRID Amanco
    Public NameTable1 As String                  'Name of table DataGridView
    Public bindingSource3 As New BindingSource
    Public WorkCenter As String
    Public elDato As String
    Public Ini As CIniClass
    Public xFormato As String = "#####0.00"
    ' ---------------------------------------------------------------------------------
    'Variables de devolucion WS Lectura de Ordenes
    Public OrdenProd As String
    Public NumeroPlanta As String
    Public Equipo As String
    Public Producto As String
    Public CantProgPzs As String
    Public Unidad As String
    Public Inicio As String
    Public Fin As String
    Public Origen As String
    Public Status1 As String
    Public Desc_Status As String
    Public fecini As String
    Public Tipo_Ord As String
    ' ---------------------------------------------------------------------------------
    Public laRaiz As String = My.Application.Info.DirectoryPath
    ' ---------------------------------------------------------------------------------


    Public P_1 As New SqlParameter          'Parametro 1 Para Store Procedure

    'Variables para boleta de pesaje
    Public StrFolio As String
    Public StrCPesaje As String
    Public TP As Boolean        'Tipo Pesaje Entrada o Salida
    Public Tipo_Pesaje As String   'Tipo Pesaje PT, MP o OT
    Public UMI As String            'Unidad de medida indicador

    'Variables para alta de camiones
    Public Cve_Transportista As String
    Public ControlGuardar As String

    Public Notif_Manual As String
    Public Acceso As String
    Public Crea As String
    Public Modifica As String
    Public Elimina As String

    'Variables para distincion de Scrap
    Public Tipo_Scrap As Boolean

    'Variable componente tipo material
    Public CTM As String = ""       'Componente tipo material

    'Variables para DGV
    Public UP_TPN As Decimal
    Public Pesos(3) As Decimal

    'Variables para accesos
    Public Cons As String      'Permiso de consulta
    Public Inse As String      'Permiso de insertar
    Public Modi As String      'Permiso de editar
    Public Elim As String      'Permiso de borrar
    Public Noti As String      'Permiso de Notificar

    Public Usr_Windows As String
    Public PC_Name As String

    'Variables para funcion de accesos
    Public strAccMod As String      'Modulo al que tiene acceso
    Public Tipo_Prog As String
    'Variables publicas para mensajes
    Public Message As String = ""
    Public Caption As String = ""
    Public Result As DialogResult
    Public Buttons As MessageBoxButtons = MessageBoxButtons.YesNo
    Public Botones As MessageBoxButtons = MessageBoxButtons.OK
    'Ordenes de producción
    Public OrdOld As String
    Public ValStatus As String 'Status del compuesto BOM
    'Error y mensaje de WS
    Public Err As String
    Public Mns As String
    'Variables cadena de conexion
    Public ipBDHost As String = "10.1.2.30"
    Public userBDHost As String = "atlas"
    'Variables para registrar el sobre o bajo peso
    Public SP As Decimal            'Variable para sobrepes
    Public Autoriza_SP As String    'Usuarios que autoriza sobre peso
    'Variables Permisos de Usuarios
    Public pHabilitado As Boolean   'Status del Usuario
    Public pstrusr As String        'Usuario
    Public pPlanta As String
    Public pUsrNom As String
    Public pCodPer As String
    Public pAlta As Boolean
    Public pBaja As Boolean
    Public pCambio As Boolean
    Public pImp As Boolean
    Public pNotif As Boolean
    Public pContab As Boolean
    Public pAutSBPeso As Boolean
    Public Obs_Peso As String

    'Codigo de barras
    Public fuente As Font

    'Variables Parametrizacion
    Public Idp_4 As Boolean
    'Variable de version del sistema
    'Public Ver_Atlas As String = "Versión 1.4.11.134"
    'Variables Baja de Pesajes
    Public Baja_Folio As String
    Public Baja_Orden As String
    Public Baja_Proceso As String
    Public Baja_DocSap As String
    Public Baja_NumSap As String
    Public Baja_Notifica As String
    Public Baja_Masiva As String
    Public Baja_St_Pesaje As String
    Public Baja_FI As String
    Public Baja_FF As String
    Public DGV As New DataGridView

    'Variable para confirmar la finalizacion exitosa o no de un proceso
    Public _Termina As Integer = 0

    Public Class CIniClass
        Private m_Ini As String
        Private Declare Function GetPrivateProfileStringKey Lib "kernel32" Alias _
        "GetPrivateProfileStringA" (ByVal lpApplicationName As String, ByVal _
        lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString _
        As String, ByVal nSize As Integer, ByVal lpFileName As String) As Integer

        Private Declare Function WritePrivateProfileString Lib "kernel32" Alias _
        "WritePrivateProfileStringA" (ByVal lpApplicationName As String, ByVal _
        lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Integer
        Property Archivo() As String
            Get
                Archivo = m_Ini
            End Get
            Set(ByVal value As String)
                m_Ini = value
            End Set
        End Property
        Public Function LeeIni(ByVal Seccion As String, ByVal Llave As String) As String
            Dim lret As Long
            Dim ret As String
            ret = New String(CChar(" "), 255)
            lret = GetPrivateProfileStringKey(Seccion, Llave, "", ret, Len(ret), m_Ini)
            If InStr(ret, Chr(0)) Then
                ret = Mid(ret, 1, Len(ret) - 3)
            End If
            LeeIni = ret
        End Function
    End Class
End Module
