Imports System.Web.Script.Serialization
Public Class Worksheet

    Private Sub btnOk_load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnOk.BackColor = BackColor.FromArgb(255, 153, 51)
    End Sub
    Private Sub btnCancle_load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnCancle.BackColor = BackColor.FromArgb(255, 153, 51)
    End Sub

    Public Sub worksheet_load() Handles MyBase.Load
        Timer1.Enabled = True
        ruSure.Visible = False
        btnCancle.Visible = False
        btnOk.Visible = False
    End Sub
    Public Sub loadJobtypeDetail(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim api = New Api()
        Dim result_data4 As String = api.Load_data("http://192.168.161.77/FA-MN1/get_data/getCatJobtype?job_id=")
        If result_data4 <> "0" Then
            Dim dict As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(result_data4)
            For Each item As Object In dict
                detail_Jobtype.Items.Add(item("job_type_th") & "  " & item("job_type_eng").ToString())
            Next
            detail_Jobtype.Text = ""
        End If
    End Sub
    Public Sub Worksheet_Details(sender As Object, e As EventArgs) Handles MyBase.Load
        problem.SelectedItem = "0"
        Dim Api = New Api()
        Dim result_data As String = Api.Load_data("http://192.168.161.77/FA-MN1/get_data")
        If result_data <> "0" Then
            Dim dict2 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(result_data)
            For Each item As Object In dict2
                problem.Items.Add(item("cat_problem_detail").ToString())
            Next
            inspection.SelectedItem = "0"
        End If
        loadInspecDetail()
    End Sub
    Public Sub loadInspecDetail()
        Dim api = New Api()
        Dim result_data2 As String = api.Load_data("http://192.168.161.77/FA-MN1/get_data/getCatInspection?cat_name=" & problem.Text)
        If result_data2 <> "0" Then
            Dim dict2 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(result_data2)
            For Each item As Object In dict2
                inspection.Items.Add(item("cat_inspec_detail").ToString())
            Next
            troubleshooting.SelectedItem = "0"
        End If
        loadTroubledetail()
    End Sub

    Public Sub loadTroubledetail()
        Dim api = New Api()
        Dim result_data3 As String = api.Load_data("http://192.168.161.77/FA-MN1/get_data/getCatTroubleshooting?sub_name=" & inspection.Text)
        If result_data3 <> "0" Then
            Dim dict2 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(result_data3)
            For Each item As Object In dict2
                troubleshooting.Items.Add(item("item_name_th") & "    " & item("item_name_eng").ToString())
            Next
        End If
    End Sub
    Private Sub problem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles problem.SelectedIndexChanged
        loadInspecDetail()
    End Sub

    Private Sub inspection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles inspection.SelectedIndexChanged
        loadTroubledetail()
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        homeMenu.Show()
        Me.Hide()
    End Sub
    Private Sub btnnext_Click(sender As Object, e As EventArgs) Handles btnnext.Click
        ruSure.Visible = True
        btnCancle.Visible = True
        btnOk.Visible = True
    End Sub
    Private Sub btnback_MouseEnter(sender As Object, e As EventArgs) Handles btnback.MouseEnter
        btnback.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    End Sub
    Private Sub btnback_MouseLeave(sender As Object, e As EventArgs) Handles btnback.MouseLeave
        btnback.BorderStyle = System.Windows.Forms.BorderStyle.None
    End Sub
    Private Sub btnnext_MouseEnter(sender As Object, e As EventArgs) Handles btnnext.MouseEnter
        btnnext.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    End Sub
    Private Sub btnnext_MouseLeave(sender As Object, e As EventArgs) Handles btnnext.MouseLeave
        btnnext.BorderStyle = System.Windows.Forms.BorderStyle.None
    End Sub
    Private Sub btnCancle_Click(sender As Object, e As EventArgs) Handles btnCancle.Click
        ruSure.Visible = False
        btnCancle.Visible = False
        btnOk.Visible = False
    End Sub

    Public Sub updateActiveted_logout()
        Dim api As New Api
        Dim udSubmitFinishTime As String = ""
        Dim udSubmitRepairTime As String = ""
        'http://192.168.161.77/FA-MN1/update_data/updateFinishTimeRepair?emp_code=
        If ctUser >= 1 Then
            udSubmitRepairTime = api.Load_data("http://192.168.161.77/FA-MN1/update_data/updateFinishTimeRepair?emp_code=" & AddingUser.userId1.Text & "&created_date=" & user_md.n1Datetime & "&jobtype=" & detail_Jobtype.Text & "&problem=" & problem.Text & "&inspection=" & inspection.Text & "&troubleshooting=" & troubleshooting.Text)
            udSubmitRepairTime = api.Load_data("http://192.168.161.77/FA-MN1/update_data/updateFinishTimeRepair?emp_code=" & AddingUser.userId2.Text & "&created_date=" & user_md.n2Datetime & "&jobtype=" & detail_Jobtype.Text & "&problem=" & problem.Text & "&inspection=" & inspection.Text & "&troubleshooting=" & troubleshooting.Text)
            udSubmitRepairTime = api.Load_data("http://192.168.161.77/FA-MN1/update_data/updateFinishTimeRepair?emp_code=" & AddingUser.userId3.Text & "&created_date=" & user_md.n3Datetime & "&jobtype=" & detail_Jobtype.Text & "&problem=" & problem.Text & "&inspection=" & inspection.Text & "&troubleshooting=" & troubleshooting.Text)
            udSubmitRepairTime = api.Load_data("http://192.168.161.77/FA-MN1/update_data/updateFinishTimeRepair?emp_code=" & AddingUser.userId4.Text & "&created_date=" & user_md.n4Datetime & "&jobtype=" & detail_Jobtype.Text & "&problem=" & problem.Text & "&inspection=" & inspection.Text & "&troubleshooting=" & troubleshooting.Text)
        End If
    End Sub
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If detail_Jobtype.Text = "" OrElse problem.Text = "" OrElse inspection.Text = "" OrElse troubleshooting.Text = "" Then
            MsgBox("กรูณากรอกข้อมูลให้ครบถ้วน")
            Exit Sub
        Else
            updateActiveted_logout()
            homeMenu.Close()
            AddingUser.Close()
            Scan.Close()
            Me.Close()
        End If
    End Sub
End Class

