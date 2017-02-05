
Imports System.Data
Imports System.Data.OleDb
Imports Proyecto02PWPF

Public Class WinSeleccionDignidad
    Private dsContVotos As DataSet
    Dim winPrincipal As New WinPrincipal
    Dim encontrado As Boolean = False
    Dim numVotosBinomio As Integer = 0
    Public resultBinomio As Integer = 0

    Private Sub cmbDignidad_SelectionChanged(sender As Object, e As SelectionChangedEventArgs) Handles cmbDignidad.SelectionChanged
        If cmbDignidad.SelectedItem = "Binomio" Then

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
                        Next

                    End If
                Next

                Dim resultado As New WinResultadoCandidato
                resultado.Owner = Me
                resultado.Show()
                Dim padre As WinSeleccionDignidad
                padre = Me
                padre.Hide()

            End Using

        ElseIf cmbDignidad.SelectedItem = "Concejal" Then
            Dim resultado As New WinResultadoConcejal
            resultado.Owner = Me
            resultado.Show()
            Dim padre As WinSeleccionDignidad
            padre = Me
            padre.Hide()
        ElseIf cmbDignidad.SelectedItem = "Alcalde" Then
            Dim resultado As New WinResultadoAlcalde
            resultado.Owner = Me
            resultado.Show()
            Dim padre As WinSeleccionDignidad
            padre = Me
            padre.Hide()

        End If





    End Sub

    Private Sub btnSalir_Click(sender As Object, e As RoutedEventArgs) Handles btnSalir.Click
        Dim inicio As New WinMenuCandidato
        inicio.Owner = Me
        inicio.Show()

        Dim padre As WinSeleccionDignidad
        padre = Me
        padre.Hide()
    End Sub

    Public Shared Widening Operator CType(v As WinResultadoCandidato) As WinSeleccionDignidad
        Throw New NotImplementedException()
    End Operator
End Class
