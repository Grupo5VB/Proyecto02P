Public Class WinAsigCandidatos
    Private Sub btn_guardar_Click(sender As Object, e As RoutedEventArgs) Handles btn_guardar.Click

    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As RoutedEventArgs) Handles btn_cancelar.Click
        txt_codigo.Text = ""
        txt_nombre.Text = ""
        txt_usuario.Text = ""
        txt_contraseña.Text = ""
    End Sub

    Private Sub Window_Closing(sender As Object, e As ComponentModel.CancelEventArgs)
        Dim mainWin As New WinPrincipal
        mainWin.Show()
    End Sub

    Private Sub btn_regresar_Click(sender As Object, e As RoutedEventArgs) Handles btn_regresar.Click
        Dim venMenuAdm As New WinMenuAdm
        venMenuAdm.Owner = Me
        venMenuAdm.Show()
        Me.Hide()
    End Sub

    Private Sub cbx_dignidad_SelectionChanged(sender As Object, e As SelectionChangedEventArgs) Handles cbx_dignidad.SelectionChanged

    End Sub
End Class
