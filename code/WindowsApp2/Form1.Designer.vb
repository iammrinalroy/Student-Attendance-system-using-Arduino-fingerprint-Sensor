<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.chkteacher = New System.Windows.Forms.CheckBox()
        Me.Chkstu1 = New System.Windows.Forms.CheckBox()
        Me.chkstu2 = New System.Windows.Forms.CheckBox()
        Me.chkstu4 = New System.Windows.Forms.CheckBox()
        Me.chkstu5 = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblsecs = New System.Windows.Forms.Label()
        Me.lblmins = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.chkstu3 = New System.Windows.Forms.CheckBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer3
        '
        Me.Timer3.Interval = 1000
        '
        'chkteacher
        '
        Me.chkteacher.AutoSize = True
        Me.chkteacher.Location = New System.Drawing.Point(538, 26)
        Me.chkteacher.Name = "chkteacher"
        Me.chkteacher.Size = New System.Drawing.Size(77, 17)
        Me.chkteacher.TabIndex = 0
        Me.chkteacher.Text = "TEACHER"
        Me.chkteacher.UseVisualStyleBackColor = True
        '
        'Chkstu1
        '
        Me.Chkstu1.AutoSize = True
        Me.Chkstu1.Location = New System.Drawing.Point(554, 131)
        Me.Chkstu1.Name = "Chkstu1"
        Me.Chkstu1.Size = New System.Drawing.Size(69, 17)
        Me.Chkstu1.TabIndex = 1
        Me.Chkstu1.Text = "Student1"
        Me.Chkstu1.UseVisualStyleBackColor = True
        '
        'chkstu2
        '
        Me.chkstu2.AutoSize = True
        Me.chkstu2.Location = New System.Drawing.Point(554, 170)
        Me.chkstu2.Name = "chkstu2"
        Me.chkstu2.Size = New System.Drawing.Size(69, 17)
        Me.chkstu2.TabIndex = 2
        Me.chkstu2.Text = "Student2"
        Me.chkstu2.UseVisualStyleBackColor = True
        '
        'chkstu4
        '
        Me.chkstu4.AutoSize = True
        Me.chkstu4.Location = New System.Drawing.Point(554, 247)
        Me.chkstu4.Name = "chkstu4"
        Me.chkstu4.Size = New System.Drawing.Size(69, 17)
        Me.chkstu4.TabIndex = 4
        Me.chkstu4.Text = "Student4"
        Me.chkstu4.UseVisualStyleBackColor = True
        '
        'chkstu5
        '
        Me.chkstu5.AutoSize = True
        Me.chkstu5.Location = New System.Drawing.Point(554, 283)
        Me.chkstu5.Name = "chkstu5"
        Me.chkstu5.Size = New System.Drawing.Size(69, 17)
        Me.chkstu5.TabIndex = 5
        Me.chkstu5.Text = "Student5"
        Me.chkstu5.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 24)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = " Time :"
        '
        'lblsecs
        '
        Me.lblsecs.AutoSize = True
        Me.lblsecs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsecs.Location = New System.Drawing.Point(168, 45)
        Me.lblsecs.Name = "lblsecs"
        Me.lblsecs.Size = New System.Drawing.Size(14, 13)
        Me.lblsecs.TabIndex = 8
        Me.lblsecs.Text = "0"
        '
        'lblmins
        '
        Me.lblmins.AutoSize = True
        Me.lblmins.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmins.Location = New System.Drawing.Point(166, 9)
        Me.lblmins.Name = "lblmins"
        Me.lblmins.Size = New System.Drawing.Size(16, 16)
        Me.lblmins.TabIndex = 9
        Me.lblmins.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(95, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Mins"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(93, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Secs"
        '
        'SerialPort1
        '
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 2000
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 70)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(961, 43)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(724, 14)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 16)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Subject"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(792, 11)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(544, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 16)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Attendance"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(181, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Roll-no."
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(327, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Student Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(621, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 35)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "SAVE"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'chkstu3
        '
        Me.chkstu3.AutoSize = True
        Me.chkstu3.Location = New System.Drawing.Point(554, 209)
        Me.chkstu3.Name = "chkstu3"
        Me.chkstu3.Size = New System.Drawing.Size(69, 17)
        Me.chkstu3.TabIndex = 3
        Me.chkstu3.Text = "Student3"
        Me.chkstu3.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Location = New System.Drawing.Point(246, 10)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(256, 39)
        Me.TextBox1.TabIndex = 26
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(846, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 13)
        Me.Label7.TabIndex = 27
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(763, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(175, 48)
        Me.Label9.TabIndex = 28
        '
        'Timer4
        '
        '
        'DataGridView1
        '
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1})
        Me.DataGridView1.Location = New System.Drawing.Point(3, 112)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(531, 205)
        Me.DataGridView1.TabIndex = 29
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(27, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 16)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Attendance"
        '
        'Column1
        '
        Me.Column1.HeaderText = "Attendance"
        Me.Column1.Name = "Column1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(1013, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblmins)
        Me.Controls.Add(Me.lblsecs)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkstu5)
        Me.Controls.Add(Me.chkstu4)
        Me.Controls.Add(Me.chkstu3)
        Me.Controls.Add(Me.chkstu2)
        Me.Controls.Add(Me.Chkstu1)
        Me.Controls.Add(Me.chkteacher)
        Me.Name = "Form1"
        Me.Text = "Biometric Attendance Syten"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkteacher As CheckBox
    Friend WithEvents Chkstu1 As CheckBox
    Friend WithEvents chkstu2 As CheckBox
    Friend WithEvents chkstu4 As CheckBox
    Friend WithEvents chkstu5 As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblsecs As Label
    Friend WithEvents lblmins As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents chkstu3 As CheckBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Timer4 As Timer
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label10 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
End Class
