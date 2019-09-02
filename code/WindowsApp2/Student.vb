Imports MySql.Data.MySqlClient

Public Class Student
    Dim con As MySqlConnection
    Dim Command As MySqlCommand
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Student_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Dim table As New DataTable()
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Buttonsave.Click
        con = New MySqlConnection
        con.ConnectionString = "server=localhost;port=3306;user=root;password=; database=student"
        Dim reader As MySqlDataReader
        Dim adapter As New MySqlDataAdapter()

        Try
            con.Open()
            Dim Query As String
            Query = "insert ignore into student.student (name,course,addr,phno,dob) values('" & TextBoxfname.Text & "','" & TextBoxcourse.Text & "','" & TextBoxadd.Text & "','" & TextBoxph.Text & "','" & TextBoxdob.Text & "')"
            Command = New MySqlCommand(Query, con)
            reader = Command.ExecuteReader
            MessageBox.Show("Data Saved")
            Dim fingr As New finger()
            finger.Show()
            con.Close()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            con.Dispose()
        End Try


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBoxfname.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Buttonclr.Click
        table.clear()

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBoxdob_TextChanged(sender As Object, e As EventArgs) Handles TextBoxdob.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBoxcourse_TextChanged(sender As Object, e As EventArgs) Handles TextBoxcourse.TextChanged

    End Sub

    Private Sub Buttonback_Click(sender As Object, e As EventArgs) Handles Buttonback.Click
        Main.Show()
    End Sub

    Private Sub TextBoxadd_TextChanged(sender As Object, e As EventArgs) Handles TextBoxadd.TextChanged

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)

    End Sub
End Class