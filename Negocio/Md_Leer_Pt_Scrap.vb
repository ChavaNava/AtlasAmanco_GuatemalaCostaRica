Module Md_Leer_Pt_Scrap
    'Variables WS Productivo
    Dim lo_wsamancomx_pr As New Lee_OFP.ZPP001_91Service
    Public ls_return_pr As New Lee_OFP.ZBAPIRET2

    'Variables WS Desarrollo
    Dim lo_wsamancomx_d As New Read.ZPP001_91Service
    Public ls_return_d As New Read.ZBAPIRET2

    Public Function Leer_ODP_PR(ByVal ODP As String) As Lee_OFP.ZEPP001

        lo_wsamancomx_pr.Credentials = New System.Net.NetworkCredential(Usrsap, Password)
        Leer_ODP_PR = lo_wsamancomx_pr.Z_PP001(ODP, ls_return_pr)

        lo_wsamancomx_pr.Dispose()

    End Function

    Public Function Leer_ODP_D(ByVal ODP As String) As Read.ZEPP001

        lo_wsamancomx_d.Credentials = New System.Net.NetworkCredential(Usrsap, Password)
        Leer_ODP_D = lo_wsamancomx_d.Z_PP001(ODP, ls_return_d)

        lo_wsamancomx_d.Dispose()

    End Function

End Module
