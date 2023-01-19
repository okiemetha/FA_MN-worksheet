Imports System.Windows.Forms
Imports System.Drawing
Imports System.IO
Imports System.Net
Imports MySql.Data.MySqlClient
Imports System.Web.Script.Serialization
Imports System.Data.SqlClient

Public Class AddingUser
    Dim check_pic As Integer = 0
    Dim user_rotate As Integer
    Dim cleararray As Integer
    Dim api = New Api()

    Private Sub AddingUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        userName1.Text = user_md.user_fname & " " & user_md.user_lname
        btnplusActive.Visible = False
        btndelActive.Visible = False
        btnhomeActive.Visible = False
    End Sub
    Private Sub HomeBut_Click(sender As Object, e As EventArgs) Handles btnhomeNormal.Click
        Me.Hide()
        homeMenu.Show()
    End Sub
    Private Sub PlusUser_Click(sender As Object, e As EventArgs) Handles btnplusNormal.Click
        Scan.Show()
    End Sub
    Private Sub Employee1_Click(sender As Object, e As EventArgs) Handles picEmp1.Click
        check_pic = 1
        picEmp1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        picEmp2.BorderStyle = System.Windows.Forms.BorderStyle.None
        picEmp3.BorderStyle = System.Windows.Forms.BorderStyle.None
        picEmp4.BorderStyle = System.Windows.Forms.BorderStyle.None
    End Sub
    Private Sub Employee2_Click(sender As Object, e As EventArgs) Handles picEmp2.Click
        check_pic = 2
        picEmp2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        picEmp1.BorderStyle = System.Windows.Forms.BorderStyle.None
        picEmp3.BorderStyle = System.Windows.Forms.BorderStyle.None
        picEmp4.BorderStyle = System.Windows.Forms.BorderStyle.None
    End Sub
    Private Sub Employee3_Click(sender As Object, e As EventArgs) Handles picEmp3.Click
        check_pic = 3
        picEmp3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        picEmp2.BorderStyle = System.Windows.Forms.BorderStyle.None
        picEmp1.BorderStyle = System.Windows.Forms.BorderStyle.None
        picEmp4.BorderStyle = System.Windows.Forms.BorderStyle.None
    End Sub
    Private Sub Employee4_Click(sender As Object, e As EventArgs) Handles picEmp4.Click
        check_pic = 4
        picEmp4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        picEmp2.BorderStyle = System.Windows.Forms.BorderStyle.None
        picEmp3.BorderStyle = System.Windows.Forms.BorderStyle.None
        picEmp1.BorderStyle = System.Windows.Forms.BorderStyle.None
    End Sub

    Private Sub btnplusNormal_MouseHover(sender As Object, e As EventArgs) Handles btnplusNormal.MouseHover
        btnplusActive.Visible = True
    End Sub

    Private Sub btnplusActive_MouseLeave(sender As Object, e As EventArgs) Handles btnplusActive.MouseLeave
        btnplusActive.Visible = False
    End Sub

    Private Sub btndelNormal_MouseEnter(sender As Object, e As EventArgs) Handles btndelNormal.MouseEnter
        btndelActive.Visible = True
    End Sub

    Private Sub btndelActive_MouseLeave(sender As Object, e As EventArgs) Handles btndelActive.MouseLeave
        btndelActive.Visible = False
    End Sub

    Private Sub btnhomeNormal_MouseEnter(sender As Object, e As EventArgs) Handles btnhomeNormal.MouseEnter
        btnhomeActive.Visible = True
    End Sub

    Private Sub btnhomeActive_MouseLeave(sender As Object, e As EventArgs) Handles btnhomeActive.MouseLeave
        btnhomeActive.Visible = False
    End Sub

    Private Sub btnplusActive_Click(sender As Object, e As EventArgs) Handles btnplusActive.Click
        Scan.Show()
    End Sub

    Public Sub btndelActive_Click(sender As Object, e As EventArgs) Handles btndelActive.Click

        If ctUser = 1 Then
            MsgBox("ไม่สามารถลบได้")
            Return
        Else
            Try
                'MsgBox("check_pic===>" & check_pic)
                'MsgBox("ctUser = " & ctUser)
                If check_pic = 1 Then
                    'MsgBox(userId1.Text)
                    Dim delete_user As String = api.Load_data("http://192.168.161.77/FA-MN1/update_data/updatelogoutDuringRepair?emp_code=" & userId1.Text & "&created_date=" & user_md.n1Datetime)
                    user_md.num_user(0) = ""
                    user_md.n1 = ""
                    ctUser = ctUser - 1

                ElseIf check_pic = 2 Then
                    'MsgBox(userId2.Text)
                    Dim delete_user As String = api.Load_data("http://192.168.161.77/FA-MN1/update_data/updatelogoutDuringRepair?emp_code=" & userId2.Text & "&created_date=" & user_md.n2Datetime)
                    user_md.num_user(1) = ""
                    user_md.n2 = ""
                    ctUser = ctUser - 1

                ElseIf check_pic = 3 Then
                    'MsgBox(userId3.Text)
                    Dim delete_user As String = api.Load_data("http://192.168.161.77/FA-MN1/update_data/updatelogoutDuringRepair?emp_code=" & userId3.Text & "&created_date=" & user_md.n3Datetime)
                    user_md.num_user(2) = ""
                    user_md.n3 = ""
                    ctUser = ctUser - 1

                ElseIf check_pic = 4 Then
                    'MsgBox(userId4.Text)
                    Dim delete_user As String = api.Load_data("http://192.168.161.77/FA-MN1/update_data/updatelogoutDuringRepair?emp_code=" & userId4.Text & "&created_date=" & user_md.n4Datetime)
                    user_md.num_user(3) = ""
                    user_md.n4 = ""
                    ctUser = ctUser - 1
                End If
            Catch ex As Exception

            End Try
        End If
        user_md.Moveuser()
    End Sub


    Private Sub btnhomeActive_Click(sender As Object, e As EventArgs) Handles btnhomeActive.Click
        homeMenu.Show()
    End Sub
End Class