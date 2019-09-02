Imports MySql.Data.MySqlClient



Public Class MyDB

    Private con As New MySqlConnection("Server=localhost; port=3306;username=root;password=;database=student")

    ReadOnly Property getConmnection() As MySqlConnection
        Get
            Return con

        End Get

    End Property

    Sub openConnection()

        If con.State = ConnectionState.Closed Then
            con.Open()

        End If

    End Sub
    Sub closeConnection()

        If con.State = ConnectionState.Open Then
            con.Close()


        End If

    End Sub
End Class
