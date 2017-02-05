
Imports System.Data
Imports System.Data.OleDb


Public Class WinResultadoCandidato
    Private dsContVotos As DataSet
    Dim winPrincipal As New WinPrincipal
    Dim encontrado As Boolean = False
    Dim numVotosBinomio As Integer = 0
    Public resultBinomio As Integer = 0
    Private Sub btnSalir_Click(sender As Object, e As RoutedEventArgs) Handles btnSalir.Click
        Dim inicio As New WinMenuCandidato
        inicio.Owner = Me
        inicio.Show()

        Dim padre As WinResultadoCandidato
        padre = Me
        padre.Hide()
    End Sub

    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)
        Using conexion As New OleDbConnection(winPrincipal.strConexion)
            Dim consulta As String = "Select * FROM ContadorVotos;"
            Dim adapter As New OleDbDataAdapter(New OleDbCommand(consulta, conexion))
            dsContVotos = New DataSet("Base")
            adapter.Fill(dsContVotos, "ContadorVotos")
            For Each u As DataRow In dsContVotos.Tables("ContadorVotos").Rows
                If u("idDignidad") = "1" Then
                    encontrado = True
                    For Each totalV As DataRow In dsContVotos.Tables("ContadorVotos").Columns
                        numVotosBinomio += totalV("TotalVotos")
                        resultBinomio = numVotosBinomio / 100
                        progbarBin21.Value = resultBinomio  'Se carga el valor de los resultados de los votos
                        progbarBin35.Value = resultBinomio
                        progbarBin10.Value = resultBinomio
                        progbarBinB.Value = resultBinomio
                        progbarBinN.Value = resultBinomio
                    Next
                End If
            Next
        End Using

    End Sub
End Class
