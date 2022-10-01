Public Class Form2

    Private Sub Button18_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim numofMon As Integer = Screen.AllScreens.Length
        If numofMon > 1 Then
            Me.Bounds = Screen.AllScreens(1).Bounds
        End If
        Me.Location = New Point(0, 0)
        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
        Label15.Text = Form1.Label15.Text
        Label17.Text = Form1.Label17.Text
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Interval = 1000
        If Label17.Text = 0 Then
            Label17.Text = 60
            Label15.Text -= 1
        End If
        Label17.Text -= 1

        If Label17.Text = 0 Then

            Label17.Text = 0
        End If
    End Sub
End Class