Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        conect()

    End Sub

    Private Sub conect()

        Try
            sptInput.PortName = TextBox1.Text
            sptInput.Open()
            tmrDetect.Start()
            Label2.Text = "conected"
            Label2.ForeColor = Color.Green
        Catch ex As Exception
            Label2.Text = "disconected"
            Label2.ForeColor = Color.Red
            MsgBox(ex.ToString)
        End Try


    End Sub

    Private Sub tmrDetect_Tick(sender As Object, e As EventArgs) Handles tmrDetect.Tick
        Dim file
        Dim PortRead As String
        Try
            PortRead = sptInput.ReadExisting

            If Not PortRead = "" Then

                Select Case PortRead
                    Case "pressed1"
                        file = 1
                    Case "pressed2"
                        file = 2
                    Case "pressed3"
                        file = 3
                    Case "pressed4"
                        file = 4
                    Case "pressed5"
                        file = 5
                    Case "pressed6"
                        file = 6
                    Case "pressed7"
                        file = 7
                    Case "pressed8"
                        file = 8
                End Select



                Try
                    My.Computer.Audio.Play("./sounds/button" & file & ".wav") 'button.wav
                    Label1.Text = "playing button" & file & ".wav"
                Catch
                    Label1.Text = "error playing button" & file & ".wav"
                End Try

            End If
        Catch ex As Exception
            Label2.Text = "disconected"
            Label2.ForeColor = Color.Red
            tmrDetect.Stop()
            MsgBox("Disconected")
        End Try

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Label2.Text = "disconected"
        Label2.ForeColor = Color.Red

    End Sub
End Class
