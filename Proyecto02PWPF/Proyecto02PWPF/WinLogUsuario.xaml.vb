﻿Imports System.Data
Imports System.Data.OleDb

Public Class WinLogUsuario
    Private dsUsuarios As DataSet
    Public arrayUsuarios As ArrayList
    Dim winPrincipal As New WinPrincipal
    Dim encontrado As Boolean = False
    Public tipoUser As String = ""

    Public idDignidad As String


    Private Sub WinLogAdministrador1_Loaded(sender As Object, e As RoutedEventArgs) Handles MyBase.Loaded, MyBase.Loaded

    End Sub


    Public Sub btn_Ingresar_Click(sender As Object, e As RoutedEventArgs) Handles btn_Ingresar.Click
        Using conexion As New OleDbConnection(winPrincipal.strConexion)
            Dim consulta As String = "Select * FROM Usuarios;"
            Dim adapter As New OleDbDataAdapter(New OleDbCommand(consulta, conexion))
            dsUsuarios = New DataSet("Base")
            adapter.Fill(dsUsuarios, "Usuarios")
            For Each u As DataRow In dsUsuarios.Tables("Usuarios").Rows
                If tipoUser = "administrador" Then
                    If u("Usuario") = "admin" And passwordAdm.Password = u("Contraseña") Then
                        encontrado = True
                        Dim winV_Administrador As New WinMenuAdm()
                        winV_Administrador.Owner = Me
                        winV_Administrador.DataContext = winPrincipal.dbPath
                        winV_Administrador.Show()
                        Me.Hide()
                        Exit For
                    Else
                        Continue For
                    End If

                ElseIf tipoUser = "candidato" Then
                    If u("Usuario") <> "admin" Then
                        If txt_usuario.Text = u("Usuario") And passwordAdm.Password = u("Contraseña") Then
                            encontrado = True
                            idDignidad = u(3) 'Coloco en la variable idDignidad el campo del idDignidad del candidato.
                            mostrarResultadoDig()

                            Dim winV_Candidato As New WinMenuCandidato()
                            winV_Candidato.Owner = Me
                                winV_Candidato.DataContext = winPrincipal.dbPath
                                winV_Candidato.Show()
                                Me.Hide()
                                Exit For
                            Else
                                Continue For
                        End If

                    End If
                End If
            Next
            If encontrado = False Then
                MessageBox.Show("Usuario no registrado")
                txt_usuario.Text = ""
                passwordAdm.Password = ""
            End If
        End Using
    End Sub

    Private Sub mostrarResultadoDig()
        If idDignidad = 1 Then
            Dim winMostrarResultadoDig As New WinResultadoCandidato()
            winMostrarResultadoDig.Owner = Me
            winMostrarResultadoDig.DataContext = winPrincipal.dbPath
            winMostrarResultadoDig.Show()
            Me.Hide()
        ElseIf idDignidad = 2 Then
            Dim winMostrarResultadoDig As New WinResultadoCandidato()
            winMostrarResultadoDig.Owner = Me
            winMostrarResultadoDig.DataContext = winPrincipal.dbPath
            winMostrarResultadoDig.Show()

            Me.Hide()
        ElseIf idDignidad = 3 Then
            Dim winMostrarResultadoDig As New WinResultadoCandidato()
            winMostrarResultadoDig.Owner = Me
            winMostrarResultadoDig.DataContext = winPrincipal.dbPath
            winMostrarResultadoDig.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As RoutedEventArgs) Handles btn_salir.Click
        Dim inicio As New WinPrincipal
        inicio.Owner = Me
        inicio.Show()

        Dim padre As WinLogUsuario
        padre = Me
        padre.Hide()
    End Sub

    Private Sub Window_Closing(sender As Object, e As ComponentModel.CancelEventArgs)
        winPrincipal.Show()
    End Sub
End Class