﻿Public Class WinResultadoConcejal
    Private Sub btnSalir_Click(sender As Object, e As RoutedEventArgs) Handles btnSalir.Click
        'Dim inicio As New WinSeleccionDignidad
        'inicio.Owner = Me
        'inicio.Show()


        Dim padre As WinResultadoConcejal
        padre = Me
        padre.Hide()
    End Sub
End Class
