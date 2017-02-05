Imports System.Data
Imports System.Data.OleDb

Public Class WinPapeletasVotos
    Private dsCandidatos As DataSet
    Dim winPrincipal As New WinPrincipal

    Dim LabelsBi As New List(Of Label)
    Dim LabelsConc As New List(Of Label)
    Dim LabelsAlc As New List(Of Label)

    Dim i As Integer = 0
    Dim j As Integer = 0
    Dim x As Integer = 0

    Dim votoBin As Integer
    Dim votoConc As Integer
    Dim votoAlc As Integer

    Public Sub Window_Loaded(sender As Object, e As RoutedEventArgs)

        LabelsBi.Add(lblBin1)
        LabelsBi.Add(lblBin2)
        LabelsBi.Add(lblBin3)
        LabelsBi.Add(lblBin4)

        LabelsConc.Add(lblConc1)
        LabelsConc.Add(lblConc2)
        LabelsConc.Add(lblConc3)
        LabelsConc.Add(lblConc4)

        LabelsAlc.Add(lblAlc1)
        LabelsAlc.Add(lblAlc2)
        LabelsAlc.Add(lblAlc3)
        LabelsAlc.Add(lblAlc4)


        Using conexion As New OleDbConnection(winPrincipal.strConexion)
            Dim consulta As String = "Select * FROM Usuarios;"
            Dim adapter As New OleDbDataAdapter(New OleDbCommand(consulta, conexion))
            dsCandidatos = New DataSet("Base")
            adapter.Fill(dsCandidatos, "Usuarios")
            For Each u As DataRow In dsCandidatos.Tables("Usuarios").Rows
                If u("Usuario") = "binom" Then
                    LabelsBi(i).Content = u("Nombre")
                    i += 1
                ElseIf u("Usuario") = "concejal" Then
                    LabelsConc(j).Content = u("Nombre")
                    j += 1
                ElseIf u("Usuario") = "alcalde" Then
                    LabelsAlc(x).Content = u("Nombre")
                    x += 1
                End If
            Next
        End Using
    End Sub

    Private Sub btnVotar1_Click(sender As Object, e As RoutedEventArgs) Handles btnVotar1.Click
        votoBin = 1
        btnVotar2.IsEnabled = False
        btnVotar3.IsEnabled = False
        btnVotar4.IsEnabled = False
        btnVotar5.IsEnabled = False
        btnVotar6.IsEnabled = False
    End Sub

    Private Sub btnVotar2_Click(sender As Object, e As RoutedEventArgs) Handles btnVotar2.Click
        votoBin = 2
        btnVotar1.IsEnabled = False
        btnVotar3.IsEnabled = False
        btnVotar4.IsEnabled = False
        btnVotar5.IsEnabled = False
        btnVotar6.IsEnabled = False
    End Sub

    Private Sub btnVotar3_Click(sender As Object, e As RoutedEventArgs) Handles btnVotar3.Click
        votoBin = 3
        btnVotar2.IsEnabled = False
        btnVotar1.IsEnabled = False
        btnVotar4.IsEnabled = False
        btnVotar5.IsEnabled = False
        btnVotar6.IsEnabled = False
    End Sub

    Private Sub btnVotar4_Click(sender As Object, e As RoutedEventArgs) Handles btnVotar4.Click
        votoBin = 4
        btnVotar2.IsEnabled = False
        btnVotar3.IsEnabled = False
        btnVotar1.IsEnabled = False
        btnVotar5.IsEnabled = False
        btnVotar6.IsEnabled = False
    End Sub

    Private Sub btnVotar5_Click(sender As Object, e As RoutedEventArgs) Handles btnVotar5.Click
        votoBin = 5
        btnVotar2.IsEnabled = False
        btnVotar3.IsEnabled = False
        btnVotar4.IsEnabled = False
        btnVotar1.IsEnabled = False
        btnVotar6.IsEnabled = False
    End Sub

    Private Sub btnVotar6_Click(sender As Object, e As RoutedEventArgs) Handles btnVotar6.Click
        votoBin = 6
        btnVotar2.IsEnabled = False
        btnVotar3.IsEnabled = False
        btnVotar4.IsEnabled = False
        btnVotar5.IsEnabled = False
        btnVotar1.IsEnabled = False
    End Sub

    Private Sub btnCancelar1_Click(sender As Object, e As RoutedEventArgs) Handles btnCancelar1.Click
        HabilitarBtnBim()
    End Sub

    Private Sub btnSiguiente1_Click(sender As Object, e As RoutedEventArgs) Handles btnSiguiente1.Click
        TabConcejal.IsSelected = True
    End Sub

    Private Sub btnVotarC1_Click(sender As Object, e As RoutedEventArgs) Handles btnVotarC1.Click
        votoConc = 1
        btnVotarC2.IsEnabled = False
        btnVotarC3.IsEnabled = False
        btnVotarC4.IsEnabled = False
        btnVotarC5.IsEnabled = False
        btnVotarC6.IsEnabled = False
    End Sub

    Private Sub btnVotarC2_Click(sender As Object, e As RoutedEventArgs) Handles btnVotarC2.Click
        votoConc = 2
        btnVotarC1.IsEnabled = False
        btnVotarC3.IsEnabled = False
        btnVotarC4.IsEnabled = False
        btnVotarC5.IsEnabled = False
        btnVotarC6.IsEnabled = False
    End Sub

    Private Sub btnVotarC3_Click(sender As Object, e As RoutedEventArgs) Handles btnVotarC3.Click
        votoConc = 3
        btnVotarC2.IsEnabled = False
        btnVotarC1.IsEnabled = False
        btnVotarC4.IsEnabled = False
        btnVotarC5.IsEnabled = False
        btnVotarC6.IsEnabled = False
    End Sub

    Private Sub btnVotarC4_Click(sender As Object, e As RoutedEventArgs) Handles btnVotarC4.Click
        votoConc = 4
        btnVotarC2.IsEnabled = False
        btnVotarC3.IsEnabled = False
        btnVotarC1.IsEnabled = False
        btnVotarC5.IsEnabled = False
        btnVotarC6.IsEnabled = False
    End Sub

    Private Sub btnVotarC5_Click(sender As Object, e As RoutedEventArgs) Handles btnVotarC5.Click
        votoConc = 5
        btnVotarC2.IsEnabled = False
        btnVotarC3.IsEnabled = False
        btnVotarC4.IsEnabled = False
        btnVotarC1.IsEnabled = False
        btnVotarC6.IsEnabled = False
    End Sub

    Private Sub btnVotarC6_Click(sender As Object, e As RoutedEventArgs) Handles btnVotarC6.Click
        votoConc = 6
        btnVotarC2.IsEnabled = False
        btnVotarC3.IsEnabled = False
        btnVotarC4.IsEnabled = False
        btnVotarC5.IsEnabled = False
        btnVotarC1.IsEnabled = False
    End Sub

    Private Sub btnCancelar2_Click(sender As Object, e As RoutedEventArgs) Handles btnCancelar2.Click
        HabilitarBtnConc()
    End Sub

    Private Sub btnSiguiente2_Click(sender As Object, e As RoutedEventArgs) Handles btnSiguiente2.Click
        TabAlcalde.IsSelected = True
    End Sub

    Private Sub btnVotarA1_Click(sender As Object, e As RoutedEventArgs) Handles btnVotarA1.Click
        votoAlc = 1
        btnVotarA2.IsEnabled = False
        btnVotarA3.IsEnabled = False
        btnVotarA4.IsEnabled = False
        btnVotarA5.IsEnabled = False
        btnVotarA6.IsEnabled = False
    End Sub

    Private Sub btnVotarA2_Click(sender As Object, e As RoutedEventArgs) Handles btnVotarA2.Click
        votoAlc = 2
        btnVotarA1.IsEnabled = False
        btnVotarA3.IsEnabled = False
        btnVotarA4.IsEnabled = False
        btnVotarA5.IsEnabled = False
        btnVotarA6.IsEnabled = False
    End Sub

    Private Sub btnVotarA3_Click(sender As Object, e As RoutedEventArgs) Handles btnVotarA3.Click
        votoAlc = 3
        btnVotarA2.IsEnabled = False
        btnVotarA1.IsEnabled = False
        btnVotarA4.IsEnabled = False
        btnVotarA5.IsEnabled = False
        btnVotarA6.IsEnabled = False
    End Sub

    Private Sub btnVotarA4_Click(sender As Object, e As RoutedEventArgs) Handles btnVotarA4.Click
        votoAlc = 4
        btnVotarA2.IsEnabled = False
        btnVotarA3.IsEnabled = False
        btnVotarA1.IsEnabled = False
        btnVotarA5.IsEnabled = False
        btnVotarA6.IsEnabled = False
    End Sub

    Private Sub btnVotarA5_Click(sender As Object, e As RoutedEventArgs) Handles btnVotarA5.Click
        votoAlc = 5
        btnVotarA2.IsEnabled = False
        btnVotarA3.IsEnabled = False
        btnVotarA4.IsEnabled = False
        btnVotarA1.IsEnabled = False
        btnVotarA6.IsEnabled = False
    End Sub

    Private Sub btnVotarA6_Click(sender As Object, e As RoutedEventArgs) Handles btnVotarA6.Click
        votoAlc = 6
        btnVotarA2.IsEnabled = False
        btnVotarA3.IsEnabled = False
        btnVotarA4.IsEnabled = False
        btnVotarA5.IsEnabled = False
        btnVotarA1.IsEnabled = False
    End Sub

    Private Sub btnCancelar3_Click(sender As Object, e As RoutedEventArgs) Handles btnCancelar3.Click
        HabilitarBtnAlc()
    End Sub

    Private Sub btnFinalizar_Click(sender As Object, e As RoutedEventArgs) Handles btnFinalizar.Click
        Dim Pregunta As Integer
        Pregunta = MsgBox("Se procederá a guardar sus votos." & vbCrLf & vbCrLf & "¿SUS VOTOS SON CORRECTOS?.", vbYesNo, "Mensaje de Confirmación")

        If Pregunta = vbYes Then
            Using conexion As New OleDbConnection(winPrincipal.strConexion)
                Dim consulta As String = "Select * FROM ContadorVotos;"
                Dim adapter As New OleDbDataAdapter(New OleDbCommand(consulta, conexion))
                dsCandidatos = New DataSet("Votos")
                adapter.Fill(dsCandidatos, "ContadorVotos")
                For Each v As DataRow In dsCandidatos.Tables("ContadorVotos").Rows
                    Select Case v("IdDignidad")
                        Case "1"
                            If v("IdLista") = CStr(votoBin) Then
                                v("TotalVotos") += 1
                            End If
                        Case "2"
                            If v("IdLista") = CStr(votoConc) Then
                                v("TotalVotos") += 1
                            End If
                        Case "3"
                            If v("IdLista") = CStr(votoAlc) Then
                                v("TotalVotos") += 1
                            End If
                    End Select
                Next
                Dim personaCmdBuilder = New OleDbCommandBuilder(adapter)
                Try
                    adapter.Update(dsCandidatos.Tables("ContadorVotos"))
                Catch ex As Exception
                    MessageBox.Show("Error al guardar")
                End Try
            End Using
            MessageBox.Show("Sus votos han sido guardados exitosamente." & vbCrLf & vbCrLf & "Gracias por cumplir con su deber ciudadano!!", "Mensaje de Salida")
            Me.Close()
            winPrincipal.Show()
        Else
            votoBin = 0
            votoConc = 0
            votoAlc = 0
            HabilitarBtnBim()
            HabilitarBtnConc()
            HabilitarBtnAlc()
            TabBinomio.IsSelected = True
        End If
    End Sub

    Public Sub HabilitarBtnBim()
        btnVotar1.IsEnabled = True
        btnVotar2.IsEnabled = True
        btnVotar3.IsEnabled = True
        btnVotar4.IsEnabled = True
        btnVotar5.IsEnabled = True
        btnVotar6.IsEnabled = True
    End Sub

    Public Sub HabilitarBtnConc()
        btnVotarC1.IsEnabled = True
        btnVotarC2.IsEnabled = True
        btnVotarC3.IsEnabled = True
        btnVotarC4.IsEnabled = True
        btnVotarC5.IsEnabled = True
        btnVotarC6.IsEnabled = True
    End Sub

    Public Sub HabilitarBtnAlc()
        btnVotarA1.IsEnabled = True
        btnVotarA2.IsEnabled = True
        btnVotarA3.IsEnabled = True
        btnVotarA4.IsEnabled = True
        btnVotarA5.IsEnabled = True
        btnVotarA6.IsEnabled = True
    End Sub
End Class
