Imports System.Data.SqlClient
Imports Utili_Generales

Public Class frmChangePassword
	Friend Property Email As String
	Friend Property idUsuario As Integer

	Private Sub btnGuardarPass_Click(sender As Object, e As EventArgs) Handles btnGuardarPass.Click
		If txtPass1.Text.Trim = "" Then
			MensajeBox.Mostrar("El campo Contraseña no debe ir vacio ", "Campo Vacio", MensajeBox.TipoMensaje.Exclamation)
			txtPass1.Focus()
			Return
		End If

		If txtPass2.Text.Trim = "" Then
			MensajeBox.Mostrar("Repita la contraseña ", "Campo Vacio", MensajeBox.TipoMensaje.Exclamation)
			txtPass2.Focus()
			Return
		End If

		If txtPass1.Text <> txtPass2.Text Then
			MensajeBox.Mostrar("La contraseña no coincide", "Contraseña no Coincide", MensajeBox.TipoMensaje.Exclamation)
			Return
		Else
			Dim pass As String = Crypto.MD5Calculate(txtPass1.Text.Trim)

			Dim con As SqlConnection = Usuarios()

			Using cmd As New SqlCommand("UPDATE dbo.ADM_Usuarios SET Password_md5 = @pass WHERE Correo_Electronico = @email)", con)
				cmd.CommandType = CommandType.Text
				cmd.Parameters.AddWithValue("@pass", pass)
				cmd.Parameters.AddWithValue("@email", Email)


				If con.State <> ConnectionState.Open Then
					con.Open()
				End If

				cmd.ExecuteNonQuery()
				con.Close()
			End Using

		End If



	End Sub

	Public Function Usuarios() As SqlConnection
		Dim varString As String
		'varString = "Data Source=10.1.2.30;Initial Catalog=USUARIOS;Persist Security Info=True;User ID=Fluentatlas;Password=flu3nt4tl4s;Trusted_Connection=False"
		varString = "Data Source=167.86.92.160;Initial Catalog=USUARIOS;Persist Security Info=True;User ID=sa;Password=Domo2018!$;Trusted_Connection=False"
		objCnn = New SqlConnection
		objCnn.ConnectionString = varString
		objCnn.Open()
		Return objCnn
	End Function
End Class