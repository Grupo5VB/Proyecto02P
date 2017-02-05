Imports System.Data
Imports System.Data.OleDb

Public Class WinMenuCandidato

    Dim winPrincipal As New WinPrincipal
    Public idDignidad As String

    Private Sub btnSalir_Click(sender As Object, e As RoutedEventArgs) Handles btnSalir.Click
        Dim inicio As New WinPrincipal
        inicio.Owner = Me
        inicio.Show()

        Dim padre As WinMenuCandidato
        padre = Me
        padre.Hide()
    End Sub

    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)

    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As RoutedEventArgs) Handles btnMostrar.Click
        'Dim inicio As New WinResultadoCandidato
        'inicio.Owner = Me
        'inicio.Show()

        'Dim padre As WinMenuCandidato
        'padre = Me
        'padre.Hide()

        If idDignidad = "binom" Then
            Dim inicio As New WinResultadoCandidato
            inicio.Owner = Me
            inicio.Show()

            Dim padre As WinMenuCandidato
            padre = Me
            padre.Hide()
        ElseIf idDignidad = "concejal" Then
            Dim winMostrarResultadoDig As New WinResultadoConcejal
            winMostrarResultadoDig.Owner = Me
            winMostrarResultadoDig.DataContext = winPrincipal.dbPath
            winMostrarResultadoDig.Show()

            Me.Hide()
        ElseIf idDignidad = "alcalde" Then
            Dim winMostrarResultadoDig As New WinResultadoAlcalde
            winMostrarResultadoDig.Owner = Me
            winMostrarResultadoDig.DataContext = winPrincipal.dbPath
            winMostrarResultadoDig.Show()
            Me.Hide()
        End If
    End Sub
End Class
