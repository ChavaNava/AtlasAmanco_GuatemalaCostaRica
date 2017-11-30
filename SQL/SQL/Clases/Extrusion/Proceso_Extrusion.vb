Public Class Proceso_Extrusion

    Public Shared Function Peso_Embalajes(ByVal Orden As String, Cantidad As Integer)
        Dim rC_Embalaje,
            rD_Embalaje,
            rC_Tipo_Emp,
            rPieza,
            rPeso As String
        Dim Count As Integer = 0

        LecturaQry("PA_Pesos_Embalajes_Ext " & SessionUser._sCentro.Trim & "_OrdenProduccion, '" & Orden.Trim & "', '" & Cantidad & "' ")
        If (LecturaBD.Read) Then
            Count = Count + 1
            rC_Embalaje = "" & LecturaBD(0)
            rD_Embalaje = "" & LecturaBD(1)
            rC_Tipo_Emp = "" & LecturaBD(2)
            rPieza = "" & LecturaBD(3)
            rPeso = "" & LecturaBD(4)
        Else
            rPieza = "0"
            rPeso = "0"
        End If

        Return rC_Embalaje & "|" & rD_Embalaje & "|" & rC_Tipo_Emp & "|" & rPieza & "|" & rPeso

    End Function

    Public Shared Function ABC_PTE()

    End Function

    Public Shared Function Alta_PT(ByVal Usuario As String, OrdenProduccion As String, Centro As String, Fecha_Pesaje As String, _
                                   Hora_Pesaje As String, Bascula As String, Rack As String, PB As String, PT As String, PN As String, _
                                   Empaques As String, Unidades As String, UsrReg As String, Fecha_Turno As String, Turno As String, _
                                   Supervisor As String, SobrePeso As String, Causa As String, PuestoTrabajo As String, Peso_teorico As String, _
                                   Estus_SP As String, Compuesto1 As String, Porcentaje1 As String, Cantidad1 As String, Compuesto2 As String, _
                                   Porcentaje2 As String, Cantidad2 As String, Version As String, FolioVale As String)
        Dim Q As String
        Dim rFolio As Integer = 0

        Q = ""
        Q = "PA_Extrusion_1 '" & OrdenProduccion & "','" & Centro.Trim & "','" & Fecha_Pesaje & _
                   "','" & Hora_Pesaje & "','" & Bascula & "','" & Rack.Trim & "'," & PB & "," & PT & "," & PN & _
                   "," & Empaques & "," & Unidades & ",'" & UsrReg & "','" & Fecha_Turno & "','" & Turno & _
                   "','" & Supervisor & "','" & SobrePeso & "','" & Causa.Trim & "','" & PuestoTrabajo.Trim & _
                   "'," & Peso_teorico & ",'E','" & Estus_SP & "','" & Compuesto1.Trim & "','" & Porcentaje1 & "','" & Cantidad1 & _
                   "','" & Compuesto2.Trim & "','" & Porcentaje2 & "','" & Cantidad2 & "','" & Version.Trim & "','" & FolioVale.Trim & "', 1"
        LecturaQry(Q)

        If (LecturaBD.Read) Then
            rFolio = "" & LecturaBD(0)
        End If

        Return rFolio

    End Function

    Public Shared Function Alta_SC(ByVal Usuario As String, OrdenProduccion As String, Centro As String, Fecha_Pesaje As String, _
                               Hora_Pesaje As String, Bascula As String, TipoScrap As String, PB As String, PT As String, PN As String, _
                               UsrReg As String, Turno As String, Causa As String, Defecto As String, Fecha_Turno As String, _
                               PuestoTrabajo As String, RepGenerado As String, OperadorLine As String, Rack As String, Compuesto1 As String, _
                               Porcentaje1 As String, Cantidad1 As String, Compuesto2 As String, Porcentaje2 As String, Cantidad2 As String, _
                               LtCompuestos As String, Version As String)

        Dim Q As String
        Dim rFolio As Integer = 0

        Q = ""
        Q = "PA_Extrusion_SC '" & Centro.Trim & "','" & OrdenProduccion.Trim & "','" & Fecha_Pesaje & _
                       "', '" & Hora_Pesaje & "','" & Bascula & "','" & TipoScrap & "'," & PB & "," & PT & "," & PN & _
                       ",'" & UsrReg & "','" & Turno & "','" & Causa.Trim & "','" & Defecto.Trim & _
                       "','" & Fecha_Turno & "','" & PuestoTrabajo.Trim & "','" & RepGenerado & "','E','" & OperadorLine.Trim & _
                       "','Supervisor','" & Rack & "','" & Compuesto1 & "'," & Porcentaje1 & "," & Cantidad1 & _
                       ",'" & Compuesto2 & "'," & Porcentaje2 & "," & Cantidad2 & ",'" & LtCompuestos.Trim & "','" & Version.Trim & "', 1"
        LecturaQry(Q)

        If (LecturaBD.Read) Then
            rFolio = "" & LecturaBD(0)
        End If

        Return rFolio

    End Function

    Public Shared Function Modifica(ByVal Usuario As String)
        Dim Q As String
        Dim idGenerado As Integer = 0

        Q = ""
        Q = Q & "PA_Modifica_Pesaje '" & ObjetosSeleccionados._modCentro & "','" & ObjetosSeleccionados._modOrden & "', "
        Q = Q & "'" & ObjetosSeleccionados._modFolio & "', '" & ObjetosSeleccionados._modTramos & "', '" & ObjetosSeleccionados._modPB & "',"
        Q = Q & "'" & ObjetosSeleccionados._modPT & "', '" & ObjetosSeleccionados._modPN & "', '" & ObjetosSeleccionados._modComp1.Trim & "',"
        Q = Q & "'" & ObjetosSeleccionados._modPorc1 & "', '" & ObjetosSeleccionados._modCant1 & "', '" & ObjetosSeleccionados._modComp2.Trim & "',"
        Q = Q & "'" & ObjetosSeleccionados._modPorc2 & "', '" & ObjetosSeleccionados._modCant2 & "', '" & ObjetosSeleccionados._modArea & "'"

        LecturaQry(Q)

        Return idGenerado = 1

    End Function

End Class
