Public Class homeMenu

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnExitactive.Visible = False
        Timer1.Enabled = True
    End Sub

    Private Sub PictureBox3_Click_1(sender As Object, e As EventArgs) Handles btnWorkSheet.Click
        Worksheet.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) Handles btnAddUser.Click
        AddingUser.Show()
        AddingUser.GroupBox1.Show()
        Me.Hide()
    End Sub

    Private Sub btnWorkSheet_MouseEnter(sender As Object, e As EventArgs)
        btnWorkSheet.BorderStyle = Windows.Forms.BorderStyle.Fixed3D
    End Sub

    Private Sub btnWorkSheet_MouseLeave(sender As Object, e As EventArgs)
        btnWorkSheet.BorderStyle = Windows.Forms.BorderStyle.None
    End Sub

    Private Sub btnAddUser_MouseEnter(sender As Object, e As EventArgs)
        btnAddUser.BorderStyle = Windows.Forms.BorderStyle.Fixed3D
    End Sub

    Private Sub btnAddUser_MouseLeave(sender As Object, e As EventArgs)
        btnAddUser.BorderStyle = Windows.Forms.BorderStyle.None
    End Sub
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles btnExitnormal.Click
        Me.Close()
        ctUser = Nothing
        clearData
        Scan.Close()
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles btnExitactive.Click
        Me.Close()
        ctUser = Nothing
        cleardata()
        Scan.Close()
    End Sub
    Private Sub btnExitnormal_MouseHover(sender As Object, e As EventArgs) Handles btnExitnormal.MouseHover
        btnExitactive.Visible = True
    End Sub

    Private Sub btnExitactive_MouseLeave(sender As Object, e As EventArgs) Handles btnExitactive.MouseLeave
        btnExitactive.Visible = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = DateTime.Now.ToString("H:mm:ss")
        'Dim insert_wkTime As String = Api.Load.data() 
    End Sub

End Class