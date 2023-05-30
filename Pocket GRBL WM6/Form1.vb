
Public Class Form1

    Public fine As String
    Public filelen, lin As Integer
    Public objReader As System.IO.StreamReader
    Dim RXbyte As String

    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
     

        Form2.Show()
        Form2.ComboBox1.Items.Clear()
        Form2.ComboBox1.Items.Add("Auto")
        For Each sp As String In IO.Ports.SerialPort.GetPortNames
           

            Form2.ComboBox1.Items.Add(sp)



        Next
    End Sub

    Private Sub SerialPort1_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        Dim Incoming As String
        Incoming = ""
        Do
            Try

                If SerialPort1.IsOpen Then Incoming = SerialPort1.ReadLine()
            Catch ex As TimeoutException
                Incoming = "Error: Serial Port read timed out."
                Exit Do
            Catch ex As Exception
                Exit Do
                MsgBox(ex.ToString)
            End Try

            If Incoming Is Nothing Then
                Exit Do
            Else

                If TextBox1.InvokeRequired Then

                    RXbyte = Incoming
                    Me.Invoke(New Action(AddressOf Display))

                Else
                    If TextBox1.TextLength > 1000 Then TextBox1.Text = ""
                    TextBox1.SelectionStart = 0 'TextBox1.TextLength
                    TextBox1.SelectedText = Incoming & vbCrLf


                    If InStr(UCase(Incoming), "ERROR") Then
                        If SerialPort1.IsOpen = True Then
                            TextBox1.Text = "Error detected, Press Resume to continue. " & TextBox1.Text + vbCrLf
                            Button3.Text = "Resume"
                            SerialPort1.Write("!" & vbCrLf)
                            Show()
                            Form2.Hide()
                            Form3.Hide()

                        End If
                    End If
                    If InStr(UCase(Incoming), "OK") Then
                        fine = "yes"

                    End If

                    End If

                End If
        Loop


    End Sub

    Private Sub Display()
        If TextBox1.TextLength > 1000 Then TextBox1.Text = ""

        TextBox1.SelectionStart = 0 'TextBox1.TextLength
        TextBox1.SelectedText = RXbyte & vbCrLf
        If InStr(UCase(RXbyte), "ERROR") Then
            If SerialPort1.IsOpen = True Then
                TextBox1.Text = "Error detected, Press Resume to continue. " & TextBox1.Text + vbCrLf
                Button3.Text = "Resume"
                SerialPort1.Write("!" & vbCrLf)
                Show()
                Form2.Hide()
                Form3.Hide()


            End If
        End If
            If InStr(UCase(RXbyte), "OK") Then
                fine = "yes"

            End If

    End Sub

    Private Sub Form1_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If SerialPort1.IsOpen Then
            SerialPort1.Close()
        End If


    End Sub

    Private Sub Form1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.GotFocus
        Label1.Text = SerialPort1.PortName & " " & SerialPort1.BaudRate
        TextBox2.Focus()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Form3.ComboBox3.Text = "10"
        Form3.ComboBox4.Text = "1000"

        

        If SerialPort1.IsOpen Then
            'SerialPort1.DiscardInBuffer()
            'SerialPort1.DiscardOutBuffer()
            SerialPort1.Close()
        End If

        Label1.Text = SerialPort1.PortName & " " & SerialPort1.BaudRate
        TextBox2.Focus()
    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Form3.Show()
    End Sub


    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If fine = "yes" And Not objReader.EndOfStream Then


            If SerialPort1.IsOpen = True Then
                lin += 1
                If Form3.CheckBox1.Checked Then
                    TextBox2.Text = Replace(UCase(objReader.ReadLine), "G53", " ")
                Else
                    TextBox2.Text = objReader.ReadLine
                End If

                SerialPort1.WriteLine(TextBox2.Text)
                TextBox1.Text = TextBox2.Text & vbCrLf & TextBox1.Text
                ProgressBar1.Value = lin / filelen * 100
                Label3.Text = lin '/ filelen * 100

            Else
                TextBox1.Text = "Not connected, Go to settings" & vbCrLf & TextBox1.Text
                Timer1.Enabled = False
            End If

            fine = "no"
        End If




        If objReader.EndOfStream Then
            objReader.Close()
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If SerialPort1.IsOpen = True Then
            SerialPort1.Write(TextBox2.Text & vbCrLf)
            TextBox1.Text = TextBox2.Text & "Sent " & vbCrLf & TextBox1.Text
        Else
            TextBox1.Text = "Not connected, Go to settings" & vbCrLf & TextBox1.Text
            
        End If
    End Sub

 

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Button3.Text = "Stop" Then

            If SerialPort1.IsOpen = True Then
                SerialPort1.Write("!" & vbCrLf)
                TextBox1.Text = "Stop " & vbCrLf & TextBox1.Text
                Button3.Text = "Resume"
            Else
                TextBox1.Text = "Not connected, Go to settings" & vbCrLf & TextBox1.Text

            End If
        Else
            If SerialPort1.IsOpen = True Then
                SerialPort1.Write("~" & vbCrLf)
                TextBox1.Text = "Resume " & vbCrLf & TextBox1.Text
                Button3.Text = "Stop"
            Else
                TextBox1.Text = "Not connected, Go to settings" & vbCrLf & TextBox1.Text

            End If

        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Not TextBox3.Text = "" Then

            Dim FILE_NAME As String = TextBox3.Text

            objReader = New System.IO.StreamReader(FILE_NAME)

            Timer1.Interval = 10
            Timer1.Enabled = True
            fine = "yes"


            lin = 0
            Do While objReader.Peek() <> -1

                filelen += 1
                objReader.ReadLine()

            Loop
            objReader = New System.IO.StreamReader(FILE_NAME)

            TextBox1.Text = "File leanth " & filelen & vbCrLf & TextBox1.Text
        Else
            TextBox1.Text = "No file selected" & vbCrLf & TextBox1.Text

        End If
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        OpenFileDialog1.Filter = "Gcode (*.nc)|*.nc|(*.txt)|*.txt|All files (*.*)|*.*"
        'OpenFileDialog1.FilterIndex("nc")
        'OpenFileDialog1.DialogTitle = "Select File"
        OpenFileDialog1.ShowDialog()

        TextBox3.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If SerialPort1.IsOpen = True Then
            SerialPort1.WriteLine(Chr(24))
            Button3.Text = "Stop"
            TextBox1.Text = "Reset " & vbCrLf & TextBox1.Text
            lin = 0
        Else
            TextBox1.Text = "Not connected, Go to settings" & vbCrLf & TextBox1.Text

        End If

        If Not TextBox3.Text = "" Then

            Dim FILE_NAME As String = TextBox3.Text

            objReader = New System.IO.StreamReader(FILE_NAME)


            Timer1.Enabled = False


        End If

    End Sub

   
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form4.Show()
    End Sub
End Class
