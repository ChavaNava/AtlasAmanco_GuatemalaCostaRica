Imports Utili_Generales
Public Class ValidacionesCompuestos
    Public Shared Function ValidaCompuestos_Inyeccion(PesoNeto As String, Comp_1 As String, Porc_1 As String, Comp_2 As String, Porc_2 As String, _
                                            Comp_3 As String, Porc_3 As String)

        Dim Retorna As Boolean = True
        Dim Cant_1 As String = "0"
        Dim Cant_2 As String = "0"
        Dim Cant_3 As String = "0"

        'Asigna valores compuesto 1
        If Comp_1 = "" Then
            MensajeBox.Mostrar("Seleccione un compuesto a consumir", "Aviso", MensajeBox.TipoMensaje.Information)
            Retorna = False
        ElseIf Porc_1 = "" Then
            MensajeBox.Mostrar("El porcenatje de participacion del compuesto 1 no puede ser 0", "Aviso", MensajeBox.TipoMensaje.Information)
            Retorna = False
        Else
            Cant_1 = Format((Val(PesoNeto) * Porc_1) / 100, "###,##0.00")
        End If
        'Asigna valores compuesto 2
        If Comp_2 > "0" Then
            If Comp_2 = "" Then
                MensajeBox.Mostrar("Seleccione un compuesto a consumir", "Aviso", MensajeBox.TipoMensaje.Information)
                Retorna = False
            End If
            If Porc_2 = "" Then
                MsgBox("El porcenatje de participacion del compuesto 2 no puede ser 0", MsgBoxStyle.Information)
                Retorna = False
            End If
            Cant_2 = Format(Val((PesoNeto) * Porc_2) / 100, "###,##0.00")
        Else
            Comp_2 = "0"
            Porc_2 = "0"
            Cant_2 = "0"
        End If
        'Asigna valores compuesto 3
        If Comp_3 > "0" Then
            If Comp_3 = "" Then
                MsgBox("Seleccione un compuesto a consumir", MsgBoxStyle.Information)
                Retorna = False
            End If
            If Porc_3 = "" Then
                MsgBox("El porcenatje de participacion del compuesto 3 no puede ser 0", MsgBoxStyle.Information)
                Retorna = False
            End If
            Cant_3 = Format(Val((PesoNeto) * Porc_3) / 100, "###,##0.00")
        Else
            Comp_3 = "0"
            Porc_3 = "0"
            Cant_3 = "0"
        End If

        Return Retorna & "|" & Comp_1 & "|" & Porc_1 & "|" & Cant_1 & "|" & Comp_2 & "|" & Porc_2 & "|" & Cant_2 & "|" & Comp_3 & "|" & Porc_3 & "|" & Cant_3

    End Function

    Public Shared Function ValidaCompuestos_Extrusion(PesoNeto As String, Comp_1 As String, Porc_1 As String, Comp_2 As String, Porc_2 As String)

        Dim Retorna As Boolean = True
        Dim Cant_1 As String = "0"
        Dim Cant_2 As String = "0"

        'Asigna valores compuesto 1
        If Comp_1 = "" Then
            MensajeBox.Mostrar("Seleccione un compuesto a consumir", "Aviso", MensajeBox.TipoMensaje.Information)
            Retorna = False
        ElseIf Porc_1 = "" Then
            MensajeBox.Mostrar("El porcenatje de participacion del compuesto 1 no puede ser 0", "Aviso", MensajeBox.TipoMensaje.Information)
            Retorna = False
        Else
            Cant_1 = Format((Val(PesoNeto) * Porc_1) / 100, "#####0.00")
        End If
        'Asigna valores compuesto 2
        If Comp_2 > "0" Then
            If Comp_2 = "" Then
                MensajeBox.Mostrar("Seleccione un compuesto a consumir", "Aviso", MensajeBox.TipoMensaje.Information)
                Retorna = False
            End If
            If Porc_2 = "" Then
                MsgBox("El porcenatje de participacion del compuesto 2 no puede ser 0", MsgBoxStyle.Information)
                Retorna = False
            End If
            Cant_2 = Format(Val((PesoNeto) * Porc_2) / 100, "#####0.00")
        Else
            Comp_2 = "0"
            Porc_2 = "0"
            Cant_2 = "0"
        End If

        Return Retorna & "|" & Comp_1 & "|" & Porc_1 & "|" & Cant_1 & "|" & Comp_2 & "|" & Porc_2 & "|" & Cant_2

    End Function

End Class
