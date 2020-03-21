<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonConnect = New System.Windows.Forms.Button()
        Me.ComboBoxListPort = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabelWeight = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LabelSetWeight = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LabelOutput = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ButtonSetWeight = New System.Windows.Forms.Button()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ButtonConnect)
        Me.GroupBox1.Controls.Add(Me.ComboBoxListPort)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(358, 109)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "การเชื่อมต่อ"
        '
        'ButtonConnect
        '
        Me.ButtonConnect.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ButtonConnect.Location = New System.Drawing.Point(200, 21)
        Me.ButtonConnect.Name = "ButtonConnect"
        Me.ButtonConnect.Size = New System.Drawing.Size(149, 73)
        Me.ButtonConnect.TabIndex = 2
        Me.ButtonConnect.Text = "เชื่อมต่อ"
        Me.ButtonConnect.UseVisualStyleBackColor = True
        '
        'ComboBoxListPort
        '
        Me.ComboBoxListPort.FormattingEnabled = True
        Me.ComboBoxListPort.Location = New System.Drawing.Point(29, 51)
        Me.ComboBoxListPort.Name = "ComboBoxListPort"
        Me.ComboBoxListPort.Size = New System.Drawing.Size(148, 24)
        Me.ComboBoxListPort.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "COM Port"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 55)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "น้ำหนัก"
        '
        'LabelWeight
        '
        Me.LabelWeight.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelWeight.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LabelWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelWeight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelWeight.Font = New System.Drawing.Font("DF11seg", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelWeight.ForeColor = System.Drawing.Color.White
        Me.LabelWeight.Location = New System.Drawing.Point(203, 17)
        Me.LabelWeight.Name = "LabelWeight"
        Me.LabelWeight.Size = New System.Drawing.Size(170, 81)
        Me.LabelWeight.TabIndex = 2
        Me.LabelWeight.Text = "0.00"
        Me.LabelWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(393, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 36)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "กิโลกรัม"
        '
        'SerialPort1
        '
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.LabelWeight)
        Me.GroupBox2.Location = New System.Drawing.Point(393, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(519, 109)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ค่าที่อ่านได้"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 148)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(281, 59)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "ของ 1 ชิ้น หนัก"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelSetWeight
        '
        Me.LabelSetWeight.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelSetWeight.BackColor = System.Drawing.Color.Blue
        Me.LabelSetWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelSetWeight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelSetWeight.Font = New System.Drawing.Font("DF11seg", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSetWeight.ForeColor = System.Drawing.Color.White
        Me.LabelSetWeight.Location = New System.Drawing.Point(12, 218)
        Me.LabelSetWeight.Name = "LabelSetWeight"
        Me.LabelSetWeight.Size = New System.Drawing.Size(281, 78)
        Me.LabelSetWeight.TabIndex = 6
        Me.LabelSetWeight.Text = "0.00"
        Me.LabelSetWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 314)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(281, 36)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "กิโลกรัม"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(349, 314)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(281, 36)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "ชิ้น"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelOutput
        '
        Me.LabelOutput.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelOutput.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LabelOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelOutput.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelOutput.Font = New System.Drawing.Font("DF11seg", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelOutput.ForeColor = System.Drawing.Color.White
        Me.LabelOutput.Location = New System.Drawing.Point(349, 218)
        Me.LabelOutput.Name = "LabelOutput"
        Me.LabelOutput.Size = New System.Drawing.Size(281, 78)
        Me.LabelOutput.TabIndex = 9
        Me.LabelOutput.Text = "0"
        Me.LabelOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.Location = New System.Drawing.Point(349, 148)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(281, 59)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "มีของทั้งหมด"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ButtonSetWeight
        '
        Me.ButtonSetWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ButtonSetWeight.Location = New System.Drawing.Point(679, 167)
        Me.ButtonSetWeight.Name = "ButtonSetWeight"
        Me.ButtonSetWeight.Size = New System.Drawing.Size(233, 83)
        Me.ButtonSetWeight.TabIndex = 10
        Me.ButtonSetWeight.Text = "ตั้งน้ำหนัก 1 ชิ้น"
        Me.ButtonSetWeight.UseVisualStyleBackColor = True
        '
        'ButtonClear
        '
        Me.ButtonClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ButtonClear.Location = New System.Drawing.Point(679, 267)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(233, 83)
        Me.ButtonClear.TabIndex = 11
        Me.ButtonClear.Text = "ล้างค่า"
        Me.ButtonClear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(925, 373)
        Me.Controls.Add(Me.ButtonClear)
        Me.Controls.Add(Me.ButtonSetWeight)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.LabelOutput)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.LabelSetWeight)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "เครื่องชั่งน้ำหนัก"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ButtonConnect As Button
    Friend WithEvents ComboBoxListPort As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LabelWeight As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents LabelSetWeight As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents LabelOutput As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents ButtonSetWeight As Button
    Friend WithEvents ButtonClear As Button
End Class
