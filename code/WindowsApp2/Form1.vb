Imports System.Globalization
Imports System.IO
Imports System.IO.Ports
Imports System.Data
Imports MySql.Data.MySqlClient

Public Class Form1

    Dim secs As Integer
    Dim mins As Integer

    ' teacher flag 
    Dim tflag As Integer

    'flags for students 
    Dim sflag1 As Integer ' student1 flag
    Dim sflag2 As Integer 'student2 flag 
    Dim sflag3 As Integer
    Dim sflag4 As Integer
    Dim sflag5 As Integer






    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loaddata()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;port=3306;user=root;password=; database=student"
        Dim reader As MySqlDataReader
        Dim bsource As New BindingSource
        Try
            MysqlConn.Open()
            Dim query As String
            query = "select sname from student.subject"
            cd = New MySqlCommand(query, MysqlConn)
            reader = cd.ExecuteReader

            While reader.Read
                Dim snm = reader.GetString("sname")
                ComboBox1.Items.Add(snm)
            End While

            MysqlConn.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()

        End Try

        tflag = 0
        sflag1 = 0
        sflag2 = 0
        sflag3 = 0
        sflag4 = 0
        sflag5 = 0

        SerialPort1.Close()
        SerialPort1.PortName = "com3"
        SerialPort1.BaudRate = "9600" 'use same baud rate as used in Arduino
        SerialPort1.DataBits = 8
        SerialPort1.Parity = Parity.None
        SerialPort1.StopBits = StopBits.One
        SerialPort1.Handshake = Handshake.None
        SerialPort1.Encoding = System.Text.Encoding.Default
        SerialPort1.Open()
    End Sub



    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick






        ' if the students comes in time, within 2 mints then the students will be marked present. 
        If InStr(TextBox1.Text, "stu1") And (sflag1 = 0) And tflag = 1 And mins <= 2 Then
            Chkstu1.Checked = True
            sflag1 = 1
            Chkstu1.Text = Chkstu1.Text + " Present"
            DataGridView1.Rows(0).Cells(0).Value = "Present"
        End If

        If InStr(TextBox1.Text, "stu2") And (sflag2 = 0) And tflag = 1 And mins <= 2 Then
            chkstu2.Checked = True
            sflag2 = 1
            chkstu2.Text = chkstu2.Text + " Present"
            DataGridView1.Rows(1).Cells(0).Value = "Present"
        End If

        If InStr(TextBox1.Text, "stu3") And (sflag3 = 0) And tflag = 1 And mins <= 2 Then
            chkstu3.Checked = True
            sflag3 = 1
            chkstu3.Text = chkstu3.Text + " Present"
            DataGridView1.Rows(2).Cells(0).Value = "Present"
        End If

        If InStr(TextBox1.Text, "stu4") And (sflag4 = 0) And tflag = 1 And mins <= 2 Then
            chkstu4.Checked = True
            sflag4 = 1
            chkstu4.Text = chkstu4.Text + " Present"
            DataGridView1.Rows(3).Cells(0).Value = "Present"
        End If

        If InStr(TextBox1.Text, "stu5") And (sflag5 = 0) And tflag = 1 And mins <= 2 Then
            chkstu5.Checked = True
            sflag5 = 1
            chkstu5.Text = chkstu5.Text + " Present"
            DataGridView1.Rows(4).Cells(0).Value = "Present"
        End If


        ' the following conditions will be used to check if the students are late.

        If InStr(TextBox1.Text, "stu1") And (sflag1 = 0) And tflag = 1 And mins > 2 And mins < 5 Then
            Chkstu1.Checked = True
            sflag1 = 1
            Chkstu1.Text = Chkstu1.Text + " is late"
            DataGridView1.Rows(0).Cells(0).Value = "Present"
        End If

        If InStr(TextBox1.Text, "stu2") And (sflag2 = 0) And tflag = 1 And mins > 1 And mins < 2 Then
            chkstu2.Checked = True
            sflag2 = 1
            chkstu2.Text = chkstu2.Text + " is late"
            DataGridView1.Rows(1).Cells(0).Value = "Present"

        End If

        If InStr(TextBox1.Text, "stu3") And (sflag3 = 0) And tflag = 1 And mins > 1 And mins < 2 Then
            chkstu3.Checked = True
            sflag3 = 1
            chkstu3.Text = chkstu3.Text + " is late"
            DataGridView1.Rows(2).Cells(0).Value = "Present"
        End If

        If InStr(TextBox1.Text, "stu4") And (sflag4 = 0) And tflag = 1 And mins > 1 And mins < 2 Then
            chkstu4.Checked = True
            sflag4 = 1
            chkstu4.Text = chkstu4.Text + " is late"
            DataGridView1.Rows(3).Cells(0).Value = "Present"
        End If

        If InStr(TextBox1.Text, "stu5") And (sflag5 = 0) And tflag = 1 And mins > 1 And mins < 2 Then
            chkstu5.Checked = True
            sflag5 = 1
            chkstu5.Text = chkstu5.Text + " is late"
            DataGridView1.Rows(4).Cells(0).Value = "Present"
        End If

        ' the following conditions will be used to check if the students are absent.

        If (sflag1 = 0) And tflag = 1 And mins >= 2 Then
            Chkstu1.Checked = True
            sflag1 = 1
            Chkstu1.Text = Chkstu1.Text + " is absent"
            DataGridView1.Rows(0).Cells(0).Value = "Absent"
        End If

        If (sflag2 = 0) And tflag = 1 And mins >= 2 Then
            chkstu2.Checked = True
            sflag2 = 1
            chkstu2.Text = chkstu2.Text + " is absent"
            DataGridView1.Rows(1).Cells(0).Value = "Absent"
        End If

        If (sflag3 = 0) And tflag = 1 And mins >= 2 Then
            chkstu3.Checked = True
            sflag3 = 1
            chkstu3.Text = chkstu3.Text + " is absent"
            DataGridView1.Rows(2).Cells(0).Value = "Absent"
        End If

        If (sflag4 = 0) And tflag = 1 And mins >= 2 Then
            chkstu4.Checked = True
            sflag4 = 1
            chkstu4.Text = chkstu4.Text + " is absent"
            DataGridView1.Rows(3).Cells(0).Value = "Absent"
        End If

        If (sflag5 = 0) And tflag = 1 And mins >= 2 Then
            chkstu5.Checked = True
            sflag5 = 1
            chkstu5.Text = chkstu5.Text + " is absent"
            DataGridView1.Rows(4).Cells(0).Value = "Absent"
        End If

    End Sub

    Private Sub DataReceived(ByVal sender As Object, ByVal e As SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived


        Try

            Dim mydata As String = ""
            mydata = SerialPort1.ReadExisting()

            If TextBox1.InvokeRequired Then
                TextBox1.Invoke(DirectCast(Sub() TextBox1.Text &= mydata, MethodInvoker))
            Else
                TextBox1.Text &= mydata
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        'timer2 will be used to empty the textbox1 for the new data. the timer interval is set to 1 second. 
        TextBox1.Text = ""
    End Sub

    Private Sub Timer3_Tick(sender As System.Object, e As System.EventArgs) Handles Timer3.Tick
        ' timer3 will be used for the elapsed time. and this timer will be activated only when the teacher will check the box.
        secs = secs + 1
        lblsecs.Text = secs
        lblmins.Text = mins
        If secs = 60 Then
            secs = 0
            mins = mins + 1
        End If

        If mins = 2 & secs = 1 Then
            mins = 0
            secs = 0
            Button1.PerformClick()
            Timer3.Stop()



        End If

    End Sub

    Private Sub chkteacher_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkteacher.CheckedChanged
        If chkteacher.Enabled = True Then
            tflag = 1
            Timer3.Enabled = True
        End If
    End Sub

    Private Sub Lblmins_Click(sender As Object, e As EventArgs) Handles lblmins.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Lblsecs_Click(sender As Object, e As EventArgs) Handles lblsecs.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Chkstu5_CheckedChanged(sender As Object, e As EventArgs) Handles chkstu5.CheckedChanged

    End Sub

    Private Sub Chkstu4_CheckedChanged(sender As Object, e As EventArgs) Handles chkstu4.CheckedChanged

    End Sub

    Private Sub Chkstu2_CheckedChanged(sender As Object, e As EventArgs) Handles chkstu2.CheckedChanged

    End Sub

    Private Sub Chkstu1_CheckedChanged(sender As Object, e As EventArgs) Handles Chkstu1.CheckedChanged

    End Sub

    Private Sub Chkstu3_CheckedChanged(sender As Object, e As EventArgs) Handles chkstu3.CheckedChanged

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label19_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Label7_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Label7.Click
        Dim dt As String = ""
        Dim dtInfo As DateTimeFormatInfo
        Dim dtStyle As String = "ddd,dd MMMM yyyy"
        dtInfo = DateTimeFormatInfo.InvariantInfo
        dt = DateTime.Now.ToString(dtStyle, dtfInfo)
        Label7.Text = dt

    End Sub

    Private Function dtfInfo() As IFormatProvider
        Throw New NotImplementedException()
    End Function

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub
    Private Function myZero(ByVal value As Integer) As String
        Return value.ToString().PadLeft(2, "0")
    End Function

    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As EventArgs) Handles Timer4.Tick
        Dim txt As String = ""
        txt &= myZero(DateTime.Now.Hour)
        txt &= ":" & myZero(DateTime.Now.Minute)
        txt &= ":" & myZero(DateTime.Now.Second)
        Label9.Text = DateTime.Now.ToString("MMMM dd, yyyy h:mm:ss tt")


    End Sub
    Private Sub Form1_Shown(ByVal sender As Object,
                           ByVal e As System.EventArgs) Handles Me.Shown
        Timer4.Interval = 250
        Timer4.Start()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick




    End Sub

    Dim MysqlConn As MySqlConnection
    Dim table As New DataTable
    Dim cd As MySqlCommand
    Dim bsource As New BindingSource
    Dim sda As New MySqlDataAdapter
    Private Sub loaddata()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;port=3306;user=root;password=; database=student"


        Try
            'table.Columns.Add("Attendance")
            MysqlConn.Open()
            Dim query As String
            query = "select id,name from student.student"
            cd = New MySqlCommand(query, MysqlConn)
            sda.SelectCommand = cd
            sda.Fill(table)
            bsource.DataSource = table
            DataGridView1.DataSource = bsource
            sda.Update(table)

            MysqlConn.Close()






        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()

        End Try


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim writer As TextWriter = New StreamWriter("C:\folder\export1.csv ")
        For i As Integer = 0 To DataGridView1.Rows.Count - 2 Step +1


            For j As Integer = 0 To DataGridView1.Columns.Count - 1 Step +1
                writer.Write(vbTab & DataGridView1.Rows(i).Cells(j).Value.ToString() & vbTab & "|")

            Next
            writer.WriteLine("")
            writer.WriteLine("....................")
        Next
        writer.Close()
        MessageBox.Show("Data Exported")
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class