Public Class WinResultadoCandidato

    Private Sub btnSalir_Click(sender As Object, e As RoutedEventArgs) Handles btnSalir.Click
        Dim inicio As New WinSeleccionDignidad
        inicio.Owner = Me
        inicio.Show()


        Dim padre As WinResultadoCandidato
        padre = Me
        padre.Hide()
    End Sub

    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)
        'progbarBin21.Value = resultBinomio  'Se carga el valor de los resultados de los votos

    End Sub
End Class
