Public Class WinMenuCandidato
    Private Sub btnMostrar_Click(sender As Object, e As RoutedEventArgs) Handles btnMostrar.Click
        Dim resultado As New WinResultadoCandidato

        resultado.Owner = Me
        resultado.Show()

        Dim padre As WinMenuCandidato
        padre = Me
        padre.Hide()
    End Sub

    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As RoutedEventArgs) Handles btnSalir.Click
        Dim inicio As New WinPrincipal
        inicio.Owner = Me
        inicio.Show()

        Dim padre As WinMenuCandidato
        padre = Me
        padre.Hide()
    End Sub
End Class
