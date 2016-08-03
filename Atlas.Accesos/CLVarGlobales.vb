Public Class CLVarGlobales
    Public Shared strNumeroBascula As String
    Public Shared Val_Bascula As String
    Public Shared Val_Bascula_2 As String
    Public Shared Val_Bascula_3 As String
    'Variable para acciones en modulos Alta, Baja, Cambio
    Public Shared Accion As String
    'Variable para informar de error dentro de grupo de funciones
    Public Shared TipoError As String
    'Identifica Area
    Public Shared EXTINY As String = "0"
    'Variables Permisos
    Public Shared gPermisos As String
    'Public Shared IdCadenas As String
    'Public Shared Password_Usr As String = ""
    'Variables Estatus SAP
    Public Shared SSAPINY As Boolean = False    'Estatus de conexion Inyección
    Public Shared SSAPEXT As Boolean = False    'Estatus de conexion Extrusión
    Public Shared SSAPROT As Boolean = False    'Estatus de conexion Rotomoldeo
    Public Shared StatusSap As Boolean = False  'Status de conexión Atlas - SAP  
    Public Shared Seccion As String        'PT = Produtor Terminado o SC = Scrap
    'Variables para identificar bascula
    Public Shared ValCodigoBascula As String = ""
    Public Shared ValCodigoBascula_2 As String = ""
    Public Shared ValCodigoBascula_3 As String = ""
    'Variables de Parametrizacion
    Public Shared P_SP As Boolean = False     'Sobre Peso
    Public Shared P_OP As Boolean = False     'Captura de operador de puesto de trabajo
    Public Shared P_CD As Boolean = False     'Tipo de Selección de Causa Defecto
    Public Shared P_CC1 As Boolean = False    'Consume Compuesto 1
    Public Shared P_CC2 As Boolean = False    'Consume Compuesto 2
    Public Shared P_NM As Boolean = False     'Notificacion Manual
    Public Shared P_MB As Boolean = False     'Activar el Group Box de Basculas
    Public Shared P_VU As Boolean = False     'Activa o desactiva la validacion del usuario a realizar pesaje
    Public Shared P_CC As Boolean = False     'Activa o desactiva la opción de seleccionar compuestos
    Public Shared P_FV As Boolean = False     'Activa o desactiva campo de folio vale
    Public Shared P_TPA As Boolean = False    'Determina tiempos de produccion automatico
    'Formatos para variables deciamles
    Public Shared xFD2 As String = "#####0.00"

    Public Shared WS_P As New WS_Generic.WSG

    Public Shared PorcentajeSobrePeso As Decimal
    Public Shared EstatusAutoriza As Integer  'Nota : a. 1 --> Sí autoriza ;  b. 2 --> No autoriza 


End Class
