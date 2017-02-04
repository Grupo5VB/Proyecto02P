Public Class WinResultadoCandidato

    Private Sub btnSalir_Click(sender As Object, e As RoutedEventArgs) Handles btnSalir.Click
        Dim inicio As New WinMenuCandidato
        inicio.Owner = Me
        inicio.Show()


        Dim padre As WinResultadoCandidato
        padre = Me
        padre.Hide()
    End Sub
End Class
