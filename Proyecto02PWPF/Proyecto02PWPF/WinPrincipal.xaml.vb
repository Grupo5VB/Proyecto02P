Imports System.Data

Class WinPrincipal

    Public dbPath As String = "C:\Users\Galo\Desktop\Proy Visual 29-01\VotoElectronico\BDVotacion.mdb"
    ''Public dbPath As String = "F:\completoVB\VotoElectronico\BDVotacion.mdb"
    Public strConexion As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & dbPath
    Public dsPersonas As DataSet

    Public Sub button_Click(sender As Object, e As RoutedEventArgs) Handles button.Click
        Dim venLogVot As New WinLogVotante
        venLogVot.Owner = Me
        venLogVot.Show()
        Me.Hide()
    End Sub

    Private Sub WinPrincipal_Closing(sender As Object, e As ComponentModel.CancelEventArgs) Handles MyBase.Closing, MyBase.Closing
        End
    End Sub

    Public Sub btnCandidato_Click(sender As Object, e As RoutedEventArgs) Handles btnCandidato.Click
        Dim venLogCand As New WinLogUsuario
        venLogCand.tipoUser = "candidato"
        venLogCand.Owner = Me
        venLogCand.Show()
        Me.Hide()
    End Sub

    Public Sub btnAdmin_Click(sender As Object, e As RoutedEventArgs) Handles btnAdmin.Click
        Dim venLogAdmin As New WinLogUsuario
        venLogAdmin.tipoUser = "administrador"
        venLogAdmin.Owner = Me
        venLogAdmin.Show()
        Me.Hide()
    End Sub
End Class
