Imports MySql.Data.MySqlClient
Public Class finger
    Dim myDB As MySqlConnection
    Dim WithEvents FpReg As FlexCodeSDK.FinFPReg
    Dim WithEvents FpVer As FlexCodeSDK.FinFPVer
    Dim Template As String

    Private Sub finger_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        myDB = New MySqlConnection
        myDB.ConnectionString = "server=localhost;port=3306;user=root;password=;database=student"
        myDB.Open()
        If myDB.State = ConnectionState.Open Then
            Button1.Enabled = True
            Button2.Enabled = True
        Else
            Button1.Enabled = False
            Button2.Enabled = False
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FpReg = New FlexCodeSDK.FinFPReg
        FpReg.AddDeviceInfo("C700F001339", "1SX-J98-067-81L-40X", "VLT1-FF2F-6C40-5A20-4058-62GV")
        FpReg.FPRegistrationStart("YourSecretKey")
    End Sub

    Private Sub FpReg_FPRegistrationStatus(ByVal Status As FlexCodeSDK.RegistrationStatus) Handles FpReg.FPRegistrationStatus
        If Status = FlexCodeSDK.RegistrationStatus.r_OK Then
            Dim sqlCommand As New MySqlCommand
            sqlCommand.Connection = myDB
            sqlCommand.CommandText = "INSERT IGNORE INTO student.student(st_temp) VALUES('" & Template & "')"
            sqlCommand.ExecuteNonQuery()
            MsgBox("OK!")
        End If
    End Sub
    Private Sub FpReg_FPRegistrationTemplate(ByVal FPTemplate As String) Handles FpReg.FPRegistrationTemplate
        Template = FPTemplate
    End Sub

    Private Sub FpReg_FPSamplesNeeded(ByVal Samples As Short) Handles FpReg.FPSamplesNeeded
        Label2.Text = Str(Samples) & "x"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub
End Class