<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Student
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxfname = New System.Windows.Forms.TextBox()
        Me.TextBoxcourse = New System.Windows.Forms.TextBox()
        Me.TextBoxadd = New System.Windows.Forms.TextBox()
        Me.TextBoxph = New System.Windows.Forms.TextBox()
        Me.TextBoxdob = New System.Windows.Forms.TextBox()
        Me.Buttonsave = New System.Windows.Forms.Button()
        Me.Buttonclr = New System.Windows.Forms.Button()
        Me.Buttonback = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(122, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Course"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(120, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Full Name"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(123, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Address"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(122, 229)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Phone no."
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(125, 284)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "DoB"
        '
        'TextBoxfname
        '
        Me.TextBoxfname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxfname.Location = New System.Drawing.Point(285, 36)
        Me.TextBoxfname.Multiline = True
        Me.TextBoxfname.Name = "TextBoxfname"
        Me.TextBoxfname.Size = New System.Drawing.Size(251, 46)
        Me.TextBoxfname.TabIndex = 5
        '
        'TextBoxcourse
        '
        Me.TextBoxcourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxcourse.Location = New System.Drawing.Point(287, 97)
        Me.TextBoxcourse.Multiline = True
        Me.TextBoxcourse.Name = "TextBoxcourse"
        Me.TextBoxcourse.Size = New System.Drawing.Size(251, 39)
        Me.TextBoxcourse.TabIndex = 6
        '
        'TextBoxadd
        '
        Me.TextBoxadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxadd.Location = New System.Drawing.Point(287, 152)
        Me.TextBoxadd.Multiline = True
        Me.TextBoxadd.Name = "TextBoxadd"
        Me.TextBoxadd.Size = New System.Drawing.Size(251, 46)
        Me.TextBoxadd.TabIndex = 7
        '
        'TextBoxph
        '
        Me.TextBoxph.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxph.Location = New System.Drawing.Point(287, 213)
        Me.TextBoxph.Multiline = True
        Me.TextBoxph.Name = "TextBoxph"
        Me.TextBoxph.Size = New System.Drawing.Size(251, 39)
        Me.TextBoxph.TabIndex = 8
        '
        'TextBoxdob
        '
        Me.TextBoxdob.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxdob.Location = New System.Drawing.Point(288, 272)
        Me.TextBoxdob.Multiline = True
        Me.TextBoxdob.Name = "TextBoxdob"
        Me.TextBoxdob.Size = New System.Drawing.Size(251, 46)
        Me.TextBoxdob.TabIndex = 9
        '
        'Buttonsave
        '
        Me.Buttonsave.BackColor = System.Drawing.Color.DodgerBlue
        Me.Buttonsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buttonsave.Location = New System.Drawing.Point(275, 368)
        Me.Buttonsave.Name = "Buttonsave"
        Me.Buttonsave.Size = New System.Drawing.Size(133, 40)
        Me.Buttonsave.TabIndex = 12
        Me.Buttonsave.Text = "Save"
        Me.Buttonsave.UseVisualStyleBackColor = False
        '
        'Buttonclr
        '
        Me.Buttonclr.BackColor = System.Drawing.Color.DodgerBlue
        Me.Buttonclr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buttonclr.Location = New System.Drawing.Point(427, 368)
        Me.Buttonclr.Name = "Buttonclr"
        Me.Buttonclr.Size = New System.Drawing.Size(133, 40)
        Me.Buttonclr.TabIndex = 13
        Me.Buttonclr.Text = "Clear"
        Me.Buttonclr.UseVisualStyleBackColor = False
        '
        'Buttonback
        '
        Me.Buttonback.Location = New System.Drawing.Point(0, 1)
        Me.Buttonback.Name = "Buttonback"
        Me.Buttonback.Size = New System.Drawing.Size(69, 28)
        Me.Buttonback.TabIndex = 14
        Me.Buttonback.Text = "Back"
        Me.Buttonback.UseVisualStyleBackColor = True
        '
        'Student
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Buttonback)
        Me.Controls.Add(Me.Buttonclr)
        Me.Controls.Add(Me.Buttonsave)
        Me.Controls.Add(Me.TextBoxdob)
        Me.Controls.Add(Me.TextBoxph)
        Me.Controls.Add(Me.TextBoxadd)
        Me.Controls.Add(Me.TextBoxcourse)
        Me.Controls.Add(Me.TextBoxfname)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Student"
        Me.Text = "Student"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxfname As TextBox
    Friend WithEvents TextBoxcourse As TextBox
    Friend WithEvents TextBoxadd As TextBox
    Friend WithEvents TextBoxph As TextBox
    Friend WithEvents TextBoxdob As TextBox
    Friend WithEvents Buttonsave As Button
    Friend WithEvents Buttonclr As Button
    Friend WithEvents Buttonback As Button
End Class
