Imports System.Web.Script.Serialization
Public Class storage1
    Dim api = New Api()
    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        btnback.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        btnenter.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Hide()
    End Sub
    Private Sub btnenter_Click_1(sender As Object, e As EventArgs) Handles btnenter.Click
        btnenter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        btnback.BorderStyle = System.Windows.Forms.BorderStyle.None

    End Sub
    'sends the selected items to the list box
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles listbtn.Click
        If ComboBox1.SelectedIndex > -1 Then
            Dim check
            For Each check In ListBox1.Items
            Next
            If check = ComboBox1.SelectedItem Then
                MsgBox("ซ้ำไหม >>" & check)
                Exit Sub
            End If
            Dim sindex As Integer
            sindex = ComboBox1.SelectedIndex
            Dim sitem As Object
            sitem = ComboBox1.SelectedItem
            ListBox1.Items.Add(sitem)
        End If
    End Sub

    Public Sub location_load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim result_data4 As String = api.Load_data("http://192.168.161.77/FA-MN1/get_data/Get_parts_location?lo_id=")
        If result_data4 <> "0" Then
            Dim dict2 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(result_data4)
            For Each item As Object In dict2
                btnlocation.Items.Add(item("location").ToString())
            Next
            btnlocation.SelectedIndex = 0
        End If
        btnlocation.SelectedItem = ""
    End Sub

    Public Sub stock_load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim result_data5 As String = api.Load_data("http://192.168.161.77/FA-MN1/get_data/Get_stock/STOCK_QTY=")
        If result_data5 <> "0" Then
            Dim dict2 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(result_data5)
            For Each item As Object In dict2
                ComboBox1.Items.Add(item("CODE_MODEL").ToString() & "          " & item("CODE_NAME").ToString())
            Next
            ComboBox1.SelectedIndex = 0
        End If
        ComboBox1.SelectedItem = ""
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        ComboBox1.Sorted = True
        MsgBox(btnlocation.ToString)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    'Public Sub qty_load()
    '    Dim api = New Api()
    '    Dim result_data6 As Integer = api.Load_data()
    '    If result_data6 <> "0" Then
    '        Dim dict As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(result_data6)
    '        For Each item As Object In dict
    '    End If
    'End Sub




    'populates the list
    'Public Sub Button2_Click(sender As Object, e As EventArgs) Handles fillbtn.Click
    '    ComboBox1.Items.Clear()
    '    ComboBox1.Items.Add("BMS-0001   | BEARING : AEHDW-BE5S-IH-C16 : NSK")
    '    ComboBox1.Items.Add("BMS-0002   | BEARING : 6210-2rS1 : SKF")
    '    ComboBox1.Items.Add("BMS-0003   | BEARING NN3007-AS-K-M-SP")
    '    ComboBox1.Items.Add("BMS-0004   | SPLIT NUT # H38236g01 BASE # N028751")
    '    ComboBox1.Items.Add("BMS-0005   | BEARING : KC-5016 : KC")
    '    ComboBox1.Items.Add("BMS-0006   | BEARING : FL204J : NSK")
    '    ComboBox1.Items.Add("BMS-0009   | BEARING l : P204 : SWC")
    '    ComboBox1.Items.Add("BMS-0011   | BEARING : F207J : NSK")
    '    ComboBox1.Items.Add("BMS-0012   | BEARING : F207J : MS")
    '    ComboBox1.Items.Add("BMS-0013   | BEARING : F205 : MS")
    '    ComboBox1.Items.Add("BMS-0014   | BEARING : CS0435247911 : MISIIMI")
    '    ComboBox1.Items.Add("BMS-0018   | BEARING : H-TK-ZBR-0051 : SKF")
    '    ComboBox1.Items.Add("BMS-0019   | BEARING : N1012BTVVG10P4 : SKF")
    '    ComboBox1.Items.Add("BMS-0021   | BEARING : 6303-2Z : SKF")
    '    ComboBox1.Items.Add("BMS-0022   | BEARING : YSFT-M30X1.5P : GLOYSh")
    '    ComboBox1.Text = "Select from..."
    'End Sub

End Class
