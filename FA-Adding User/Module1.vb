Imports System.Runtime.CompilerServices
Module user_md
    Public user_code As String = ""
    Public user_fname As String = ""
    Public user_lname As String = ""
    Public user_code1 As String = ""
    Public num_user(3) As String

    Public ct As Integer
    Public ctUser As String = 0

    Public n1 As String = ""
    Public n2 As String = ""
    Public n3 As String = ""
    Public n4 As String = ""

    Public sDatetime As String = ""

    Public n1Datetime As String = ""
    Public n2Datetime As String = ""
    Public n3Datetime As String = ""
    Public n4Datetime As String = ""

    Public Function userPack(ByVal Log As Integer)  'ขยับ BoxGroup ตามลำดับ เมื่อพนักงานทำการล็อคอิน
        If Log = 1 Then
            AddingUser.GroupBox1.Location = New Drawing.Point(470, 175)
            AddingUser.GroupBox2.Hide()
            AddingUser.GroupBox3.Hide()
            AddingUser.GroupBox4.Hide()
        ElseIf Log = 2 Then
            AddingUser.GroupBox1.Location = New Drawing.Point(376, 60)
            AddingUser.GroupBox2.Show()
            AddingUser.GroupBox2.Location = New Drawing.Point(565, 60)
        ElseIf Log = 3 Then
            AddingUser.GroupBox3.Show()
            AddingUser.GroupBox3.Location = New Drawing.Point(376, 308)
        ElseIf Log = 4 Then
            AddingUser.GroupBox4.Show()
            AddingUser.GroupBox4.Location = New Drawing.Point(564, 308)
        End If
    End Function

    Public Function Moveuser() 'ขยับข้อมูลบุคคล
        Try
            If n1 = "" Then
                setN1()
                setN2()
                setN3()
                setNullN4()
            ElseIf n2 = "" Then
                setN2()
                setN3()
                setNullN4()
            ElseIf n3 = "" Then
                setN3()
                setNullN4()
            ElseIf n4 = "" Then
                setNullN4()
            End If
            flg_control_pic()
        Catch ex As Exception
            MsgBox("ERROR ===>" & ex.Message)
        End Try
    End Function

    Public Sub flg_control_pic() 'ซ่อนบล็อคที่ไม่มีข้อมูล
        If AddingUser.userId1.Text = Nothing Then
            AddingUser.GroupBox1.Visible = False
        End If
        If AddingUser.userId2.Text = Nothing Then
            AddingUser.GroupBox2.Visible = False
        End If
        If AddingUser.userId3.Text = Nothing Then
            AddingUser.GroupBox3.Visible = False
        End If
        If AddingUser.userId4.Text = Nothing Then

            AddingUser.GroupBox4.Visible = False
        End If
    End Sub

    Public Sub setN1() 'ย้ายข้อมูลบุคคลตำแหน่ง 2 ไป 1
        num_user(0) = num_user(1)
        AddingUser.picEmp1.Image = AddingUser.picEmp2.Image
        AddingUser.userId1.Text = AddingUser.userId2.Text
        AddingUser.userName1.Text = AddingUser.userName2.Text
        n1Datetime = n2Datetime

        'ย้ายข้อมูลบุคคลตำแหน่ง 2 ไป 1 ให้หน้า MENU
        homeMenu.showid1.Text = homeMenu.showid2.Text
        homeMenu.showpic1.Image = homeMenu.showpic2.Image
    End Sub
    Public Sub setN2() 'ย้ายข้อมูลบุคคลตำแหน่ง 3 ไป 2 
        num_user(1) = num_user(2)
        AddingUser.picEmp2.Image = AddingUser.picEmp3.Image
        AddingUser.userId2.Text = AddingUser.userId3.Text
        AddingUser.userName2.Text = AddingUser.userName3.Text

        n2Datetime = n3Datetime
        'ย้ายข้อมูลบุคคลตำแหน่ง 3 ไป 2 ให้หน้า MENU
        homeMenu.showid2.Text = homeMenu.showid3.Text
        homeMenu.showpic2.Image = homeMenu.showpic3.Image
    End Sub
    Public Sub setN3() 'ย้ายข้อมูลบุคคลตำแหน่ง 4 ไป 
        num_user(2) = num_user(3)
        AddingUser.picEmp3.Image = AddingUser.picEmp4.Image
        AddingUser.userId3.Text = AddingUser.userId4.Text
        AddingUser.userName3.Text = AddingUser.userName4.Text

        n3Datetime = n4Datetime
        'ย้ายข้อมูลบุคคลตำแหน่ง 4 ไป 3 ให้หน้า MENU
        homeMenu.showid3.Text = homeMenu.showid4.Text
        homeMenu.showpic3.Image = homeMenu.showpic4.Image
    End Sub
    Public Sub setNullN4() 'ล้างข้อมูลบุคคลที่ 4
        n4Datetime = ""
        num_user(3) = Nothing
        AddingUser.picEmp4.Image = Nothing
        AddingUser.userId4.Text = Nothing
        AddingUser.userName4.Text = Nothing
        homeMenu.showid4.Text = Nothing
        homeMenu.showpic4.Image = Nothing
    End Sub
    Public Sub setNullN3() 'ล้างข้อมูลบุคคลที่ 3
        n3Datetime = ""
        num_user(2) = Nothing
        AddingUser.picEmp3.Image = Nothing
        AddingUser.userId3.Text = Nothing
        AddingUser.userName3.Text = Nothing
        homeMenu.showid3.Text = Nothing
        homeMenu.showpic3.Image = Nothing
    End Sub
    Public Sub setNullN2() 'ล้างข้อมูลบุคคลที่ 2
        n2Datetime = ""
        num_user(1) = Nothing
        AddingUser.picEmp2.Image = Nothing
        AddingUser.userId2.Text = Nothing
        AddingUser.userName2.Text = Nothing
        homeMenu.showid2.Text = Nothing
        homeMenu.showpic2.Image = Nothing
    End Sub
    Public Sub setNullN1() 'ล้างข้อมูลบุคคลที่ 1
        n1Datetime = ""
        num_user(0) = Nothing
        AddingUser.picEmp1.Image = Nothing
        AddingUser.userId1.Text = Nothing
        AddingUser.userName1.Text = Nothing
        homeMenu.showid1.Text = Nothing
        homeMenu.showpic1.Image = Nothing
    End Sub
End Module

Module dbActive
    Public Function cleardata()
        Dim api = New Api
        Dim delete_user As String = api.Load_data("http://192.168.161.77/FA-MN1/clear_data/Clear_user_data")
        Return delete_user
    End Function
End Module

