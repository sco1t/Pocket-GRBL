Public Class Form3

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Form1.SerialPort1.IsOpen = True Then
            Form1.SerialPort1.Write("G91 G1 y" & ComboBox3.Text & " f" & ComboBox4.Text & vbCrLf)
            Form1.Text = "Jog foward" & vbCrLf & Form1.TextBox1.Text
        Else
            Form1.TextBox1.Text = "not connected" & vbCrLf & Form1.TextBox1.Text
            Hide()
            Form1.Focus()
            Form1.Show()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Form1.SerialPort1.IsOpen = True Then
            Form1.SerialPort1.Write("G91 G1 y-" & ComboBox3.Text & " f" & ComboBox4.Text & vbCrLf)
            Form1.TextBox1.Text = "Jog back" & vbCrLf & Form1.TextBox1.Text
        Else
            Form1.TextBox1.Text = "not connected" & vbCrLf & Form1.TextBox1.Text
            Hide()
            Form1.Focus()
            Form1.Show()
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If Form1.SerialPort1.IsOpen = True Then
            Form1.SerialPort1.Write("G91 G1 Z-" & ComboBox3.Text & " f" & ComboBox4.Text & vbCrLf)
            Form1.TextBox1.Text = "Jog Z down" & vbCrLf & Form1.TextBox1.Text
        Else
            Form1.TextBox1.Text = "not connected" & vbCrLf & Form1.TextBox1.Text
            Hide()
            Form1.Focus()
            Form1.Show()
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If Form1.SerialPort1.IsOpen = True Then
            Form1.SerialPort1.Write("G91 G1 z" & ComboBox3.Text & " f" & ComboBox4.Text & vbCrLf)
            Form1.TextBox1.Text = "Jog Z up" & vbCrLf & Form1.TextBox1.Text
        Else
            Form1.TextBox1.Text = "not connected" & vbCrLf & Form1.TextBox1.Text
            Hide()
            Form1.Focus()
            Form1.Show()
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If Form1.SerialPort1.IsOpen = True Then
            Form1.SerialPort1.Write("M5 " & vbCrLf)
            Form1.TextBox1.Text = "Motor off" & vbCrLf & Form1.TextBox1.Text
        Else
            Form1.TextBox1.Text = "not connected" & vbCrLf & Form1.TextBox1.Text
            Hide()
            Form1.Focus()
            Form1.Show()
        End If
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        If Form1.SerialPort1.IsOpen = True Then
            Form1.SerialPort1.Write("M3 S1000 " & vbCrLf)
            Form1.TextBox1.Text = "Motor on" & vbCrLf & Form1.TextBox1.Text
        Else
            Form1.TextBox1.Text = "not connected" & vbCrLf & Form1.TextBox1.Text
            Hide()
            Form1.Focus()
            Form1.Show()
        End If
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If Form1.SerialPort1.IsOpen = True Then
            Form1.SerialPort1.Write("G92Z0" & vbCrLf)
            Form1.TextBox1.Text = "Set new Z zero point" & vbCrLf & Form1.TextBox1.Text
        Else
            Form1.TextBox1.Text = "not connected" & vbCrLf & Form1.TextBox1.Text
            Hide()
            Form1.Focus()
            Form1.Show()
        End If
    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Hide()
        Form2.Show()
        Form2.ComboBox1.Items.Clear()

        For Each sp As String In IO.Ports.SerialPort.GetPortNames
            Form2.ComboBox1.Items.Add(sp)
        Next
    End Sub

    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        Hide()
        Form1.Focus()
        Form1.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If Form1.SerialPort1.IsOpen = True Then
            Form1.SerialPort1.Write("G91 G1 x" & ComboBox3.Text & " f" & ComboBox4.Text & vbCrLf)
            Form1.TextBox1.Text = "Jog +X" & vbCrLf & Form1.TextBox1.Text
        Else
            Form1.TextBox1.Text = "not connected" & vbCrLf & Form1.TextBox1.Text
            Hide()
            Form1.Focus()
            Form1.Show()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Form1.SerialPort1.IsOpen = True Then
            Form1.SerialPort1.Write("G91 G1 x-" & ComboBox3.Text & " f" & ComboBox4.Text & vbCrLf)
            Form1.TextBox1.Text = "Jog -X" & vbCrLf & Form1.TextBox1.Text
        Else
            Form1.TextBox1.Text = "not connected" & vbCrLf & Form1.TextBox1.Text
            Hide()
            Form1.Focus()
            Form1.Show()
        End If
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        If Form1.SerialPort1.IsOpen = True Then
            Form1.SerialPort1.Write("G90 G0X0Y0Z0" & vbCrLf)
            Form1.TextBox1.Text = "Go to Z zero point" & vbCrLf & Form1.TextBox1.Text
        Else
            Form1.TextBox1.Text = "not connected" & vbCrLf & Form1.TextBox1.Text
            Hide()
            Form1.Focus()
            Form1.Show()
        End If
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        If Form1.SerialPort1.IsOpen = True Then
            Form1.SerialPort1.Write("G92X0Y0" & vbCrLf)
            Form1.TextBox1.Text = "Set new XY zero point" & vbCrLf & Form1.TextBox1.Text
        Else
            Form1.TextBox1.Text = "not connected" & vbCrLf & Form1.TextBox1.Text
            Hide()
            Form1.Focus()
            Form1.Show()
        End If
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        If Form1.SerialPort1.IsOpen = True Then
            Form1.SerialPort1.Write("$X " & vbCrLf)
            Form1.TextBox1.Text = "Unlock" & vbCrLf & Form1.TextBox1.Text
        Else
            Form1.TextBox1.Text = "not connected" & vbCrLf & Form1.TextBox1.Text
            Hide()
            Form1.Focus()
            Form1.Show()
        End If
    End Sub
End Class