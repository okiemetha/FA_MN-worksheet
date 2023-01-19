Imports System
Imports System.Net
Imports System.IO
Imports System.Windows.Forms.Form
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.Web.Script.Serialization
Public Class Api

    Public Function Load_data(ByVal _URL As String) As String
        'Dim _tmpImage As Image = Nothing
        Dim re_data = "NO_DATA"
        Try
            Dim _HttpWebRequest As System.Net.HttpWebRequest = CType(System.Net.HttpWebRequest.Create(_URL), System.Net.HttpWebRequest)

            _HttpWebRequest.AllowWriteStreamBuffering = True
            _HttpWebRequest.Timeout = 20000

            Dim _WebResponse As System.Net.WebResponse = _HttpWebRequest.GetResponse()
            Using data As New StreamReader(_WebResponse.GetResponseStream())
                re_data = data.ReadToEnd
                Dim JSONString As String = ""
                JSONString = JsonConvert.SerializeObject(re_data)
                'MsgBox("re_data" & re_data)
                'MsgBox(data.ReadToEnd)
                '  For Each key In data.ReadToEnd
                're_data &= key
                ' Next 'return to json '
            End Using

            _WebResponse.Close()
        Catch _Exception As Exception
            'MsgBox("FALL WOW")
            Return Nothing
        End Try
        Return re_data
    End Function

End Class
