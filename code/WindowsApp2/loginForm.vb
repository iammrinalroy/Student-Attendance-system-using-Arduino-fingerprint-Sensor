Imports MySql.Data.MySqlClient


Public Class loginForm
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBoxUsername.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBoxPassword.TextChanged

    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If TextBoxPassword.UseSystemPasswordChar Then
            TextBoxPassword.UseSystemPasswordChar = False
        Else
            TextBoxPassword.UseSystemPasswordChar = True


        End If



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim db As New MyDB()
        Dim adapter As New MySqlDataAdapter()
        Dim table As New DataTable()
        Dim command As New MySqlCommand("SELECT * FROM `user` WHERE `username` = @user AND `password` = @pass", db.getConmnection)


        command.Parameters.Add("@user", MySqlDbType.VarChar).Value = TextBoxUsername.Text
        command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = TextBoxPassword.Text

        adapter.SelectCommand = command
        adapter.Fill(table)
        If table.Rows.Count > 0 Then
            Dim fmain As New Main()
            fmain.Show()
            Me.Close()
        Else
            MsgBox("Invalid Username OR Password!!", MsgBoxStyle.Critical, "Login Error")

        End If


    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class