Imports System.Drawing
Imports System.IO
Imports System.Net
Imports MySql.Data.MySqlClient
Imports System.Web.Script.Serialization

Public Class Scan
    Public user_id As String
    Public user_fname As String
    Public uer_lname As String
    Public Sub Scan_load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        btncancle.Visible = False
    End Sub
    Public Sub addUser()
        If user_md.n1 = "" Then
            user_md.n1 = "1"
        ElseIf user_md.n2 = "" Then
            user_md.n2 = "1"
        ElseIf user_md.n3 = "" Then
            user_md.n3 = "1"
        ElseIf user_md.n4 = "" Then
            user_md.n4 = "1"
        End If
    End Sub
    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub
    Private Sub btncancle_Click(sender As Object, e As EventArgs) Handles btncancle.Click
        Me.Hide()
    End Sub

    Private Sub logIncode_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs) Handles logIncode.KeyDown
        Select Case e.KeyCode
            Case Windows.Forms.Keys.Enter
                user_id = logIncode.Text

                Dim DateTimes As String = ""

                '' Login User1
                Dim api = New Api()
                Dim insert_data As String = ""
                Dim user_data As String = api.Load_data("http://192.168.161.77/FA-MN1/get_data/getUserRegisted?user_emp=" & logIncode.Text)
                If user_data <> "0" Then
                    Dim tclient As New WebClient
                    If Trim(AddingUser.userId1.Text) = "" Then
                        Dim url As String = "http://192.168.161.207/tbkk_shopfloor/asset/img_emp/" & logIncode.Text & ".jpg"
                        For i = 0 To 3 Step 1
                            If user_md.num_user(i) = logIncode.Text Then
                                MsgBox("ซ้ำ")
                                logIncode.Text = Nothing
                                Exit Sub
                            End If
                        Next
                        If Trim(logIncode.Text) <> "" Then
                            num_user(0) = logIncode.Text
                            ctUser = ctUser + 1

                        End If
                        'แสดงรูปภาพ
                        Dim tImage As Bitmap = Bitmap.FromStream(New MemoryStream(tclient.DownloadData(url)))
                        AddingUser.picEmp1.Image = tImage
                        homeMenu.showpic1.Image = tImage
                        'แสดงชื่อ
                        Dim dict2 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(user_data)
                        For Each item As Object In dict2
                            user_md.user_fname = item("user_fname").ToString()
                            user_md.user_lname = item("user_lname").ToString()
                        Next
                        addUser()
                        user_md.n1Datetime = DateTime.Now.ToString("yyyy-MM-dd HH:mm")
                        insert_data = api.Load_data("http://192.168.161.77/FA-MN1/insert_data/insertUserLogin?user_emp=" & logIncode.Text & "&created_date=" & user_md.n1Datetime)
                        homeMenu.showid1.Text = user_id.ToString
                        AddingUser.userId1.Text = user_id.ToString
                        AddingUser.userName1.Text = user_md.user_fname & " " & user_md.user_lname
                        user_md.userPack(1)
                        homeMenu.Show()
                        Me.Hide()
                        logIncode.Text = Nothing
                        btncancle.Visible = True
                        btnclose.Visible = False

                        'Login User2
                    ElseIf Trim(AddingUser.userId2.Text) = "" Then
                        Dim url As String = "http://192.168.161.207/tbkk_shopfloor/asset/img_emp/" & logIncode.Text & ".jpg"
                        For i = 0 To 3 Step 1
                            If num_user(i) = logIncode.Text Then
                                MsgBox("ซ้ำ")
                                logIncode.Text = Nothing
                                Exit Sub
                            End If
                        Next
                        If Trim(logIncode.Text) <> "" Then
                            num_user(1) = logIncode.Text
                            ctUser = ctUser + 1
                        End If
                        Dim tImage As Bitmap = Bitmap.FromStream(New MemoryStream(tclient.DownloadData(url)))
                        AddingUser.picEmp2.Image = tImage
                        homeMenu.showpic2.Image = tImage
                        Dim dict2 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(user_data)
                        For Each item As Object In dict2

                            user_md.user_fname = item("user_fname").ToString()
                            user_md.user_lname = item("user_lname").ToString()
                        Next
                        addUser()
                        user_md.n2Datetime = DateTime.Now.ToString("yyyy-MM-dd HH:mm")
                        insert_data = api.Load_data("http://192.168.161.77/FA-MN1/insert_data/insertUserLogin?user_emp=" & logIncode.Text & "&created_date=" & user_md.n2Datetime)
                        homeMenu.showid2.Text = user_id.ToString
                        AddingUser.userId2.Text = user_id.ToString
                        AddingUser.userName2.Text = user_md.user_fname & " " & user_md.user_lname
                        logIncode.Text = Nothing
                        user_md.userPack(2)


                        'Login User3
                    ElseIf Trim(AddingUser.userId3.Text) = "" Then
                        Dim url As String = "http://192.168.161.207/tbkk_shopfloor/asset/img_emp/" & logIncode.Text & ".jpg"
                        For i = 0 To 3 Step 1
                            If num_user(i) = logIncode.Text Then
                                MsgBox("ซ้ำ")
                                logIncode.Text = Nothing
                                Exit Sub
                            End If
                        Next
                        If Trim(logIncode.Text) <> "" Then
                            num_user(2) = logIncode.Text
                            ctUser = ctUser + 1
                        End If
                        Dim tImage As Bitmap = Bitmap.FromStream(New MemoryStream(tclient.DownloadData(url)))
                        AddingUser.picEmp3.Image = tImage
                        homeMenu.showpic3.Image = tImage
                        Dim dict2 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(user_data)
                        For Each item As Object In dict2
                            user_md.user_fname = item("user_fname").ToString()
                            user_md.user_lname = item("user_lname").ToString()
                        Next
                        addUser()
                        user_md.n3Datetime = DateTime.Now.ToString("yyyy-MM-dd HH:mm")
                        insert_data = api.Load_data("http://192.168.161.77/FA-MN1/insert_data/insertUserLogin?user_emp=" & logIncode.Text & "&created_date=" & user_md.n3Datetime)
                        homeMenu.showid3.Text = user_id.ToString
                        AddingUser.userId3.Text = user_id.ToString
                        AddingUser.userName3.Text = user_md.user_fname & " " & user_md.user_lname
                        logIncode.Text = Nothing
                        user_md.userPack(3)

                        'Login User4
                    ElseIf Trim(AddingUser.userId4.Text) = "" Then
                        Dim url As String = "http://192.168.161.207/tbkk_shopfloor/asset/img_emp/" & logIncode.Text & ".jpg"
                        Dim tImage As Bitmap = Bitmap.FromStream(New MemoryStream(tclient.DownloadData(url)))
                        For i = 0 To 3 Step 1
                            If num_user(i) = logIncode.Text Then
                                MsgBox("ซ้ำ")
                                logIncode.Text = Nothing
                                Exit Sub
                            End If
                        Next
                        If Trim(logIncode.Text) <> "" Then
                            num_user(3) = logIncode.Text
                            ctUser = ctUser + 1
                        End If
                        AddingUser.picEmp4.Image = tImage
                        homeMenu.showpic4.Image = tImage
                        Dim dict2 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(user_data)
                        For Each item As Object In dict2

                            user_md.user_fname = item("user_fname").ToString()
                            user_md.user_lname = item("user_lname").ToString()
                        Next
                        addUser()
                        user_md.n4Datetime = DateTime.Now.ToString("yyyy-MM-dd HH:mm")
                        insert_data = api.Load_data("http://192.168.161.77/FA-MN1/insert_data/insertUserLogin?user_emp=" & logIncode.Text & "&created_date=" & user_md.n4Datetime)
                        homeMenu.showid4.Text = user_id.ToString
                        AddingUser.userId4.Text = user_id.ToString
                        AddingUser.userName4.Text = user_md.user_fname & " " & user_md.user_lname
                        logIncode.Text = Nothing
                        user_md.userPack(4)
                        Me.Hide()
                    Else
                        MsgBox("จำนวนผู้ใช้เต็มแล้ว")
                    End If
                Else
                    MsgBox("ไม่พบข้อมูลพนักงาน")
                    logIncode.Text = Nothing
                End If
        End Select
    End Sub
End Class



