Imports System.IO.Ports

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False

        Dim listport As String() = IO.Ports.SerialPort.GetPortNames()

        For i = 0 To listport.Count - 1
            ComboBoxListPort.Items.Add(listport(i))
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonConnect.Click
        If ComboBoxListPort.SelectedItem = "" Then Return

        If SerialPort1.IsOpen Then
            SerialPort1.Close()

            ButtonConnect.Text = "เชื่อมต่อ"
            ComboBoxListPort.Enabled = True
        Else
            SerialPort1.BaudRate = 9600
            SerialPort1.PortName = ComboBoxListPort.SelectedItem

            Try
                SerialPort1.Open()
                ComboBoxListPort.Enabled = False

                ButtonConnect.Text = "ยกเลิก"
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub SerialPort1_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        LabelWeight.Text = Val(SerialPort1.ReadLine()).ToString("0.00")
        LabelWeight.TextAlign = ContentAlignment.MiddleCenter

        If Val(LabelSetWeight.Text) > 0 Then
            LabelOutput.Text = Math.Round(Val(LabelWeight.Text) / Val(LabelSetWeight.Text))
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonSetWeight.Click
        LabelSetWeight.Text = LabelWeight.Text
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        LabelSetWeight.Text = "0.00"
        LabelOutput.Text = "0"
    End Sub
End Class
