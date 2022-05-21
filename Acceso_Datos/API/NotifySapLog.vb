Imports System.Configuration
Imports Newtonsoft.Json.Linq
Imports RestSharp

Public Class NotifySapLog
    Public Shared Function WriteLog(ByVal log As AtlasSapLogRequest) As Boolean
        Dim urlAPI As String = ConfigurationManager.AppSettings.Get("ApiAtlas")

        Dim client As RestClient = New RestClient($"{urlAPI}/AtlasSapLog/WriteLog")
        Dim request As RestRequest = New RestRequest(Method.Post)
        request.AddHeader("Content-Type", "application/json")
        request.AddJsonBody(log)
        Dim response = client.ExecuteAsPost(Of ApiResponse(Of String))(request, "post")

        Dim jobj = JObject.Parse(response.Content)
        Dim respuesta = jobj("Mensaje").ToString

        If response.StatusCode = System.Net.HttpStatusCode.OK Or response.StatusCode = System.Net.HttpStatusCode.Created Then
            Return True
        Else
            Return False
        End If
    End Function
End Class

Public Class AtlasSapLogRequest
    Public Property Application As String
    Public Property Username As String
    Public Property Action As String
    Public Property Description As String
    Public Property DateHourAction As String
    Public Property Version As String
    Public Property ClientIP As String
    Public Property Centro As String
    Public Property DocumentoSAP As String
    Public Property ConsecutivoSAP As String
    Public Property FolioAtlas As String
End Class

Public Class ApiResponse(Of T)
    Public Sub New()
    End Sub

    Public Sub New(ByVal data As T)
        Application = String.Empty
        Succeeded = True
        Message = String.Empty
        Errors = Array.Empty(Of String)()
        data = data
    End Sub

    Public Property Application As String
    Public Property Data As T
    Public Property Succeeded As Boolean
    Public Property Errors As String()
    Public Property Message As String
End Class
