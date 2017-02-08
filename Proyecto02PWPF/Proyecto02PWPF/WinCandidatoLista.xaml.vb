Public Class WinCandidatoLista



    Private Sub btnSalir_Click(sender As Object, e As RoutedEventArgs) Handles btnSalir.Click
        Dim inicio As New WinMenuCandidato
        inicio.Owner = Me
        inicio.Show()

        Dim padre As WinCandidatoLista
        padre = Me
        padre.Hide()
    End Sub

    Private Sub btnVerificar_Click(sender As Object, e As RoutedEventArgs) Handles btnVerificar.Click

    End Sub
End Class
