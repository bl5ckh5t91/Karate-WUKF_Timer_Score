Public Class Form1

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Label17.Text += 1
        Form2.Label17.Text += 1
        If Convert.ToInt32(Label17.Text.Trim()) < 10 Then
            Label17.Text = "0" + Label17.Text
            Form2.Label17.Text = "0" + Form2.Label17.Text
        End If

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If Convert.ToInt32(Label8.Text.Trim()) > 0 Then

            Label8.Text = Label8.Text - 1
            Form2.Label8.Text = Form2.Label8.Text - 1
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If Convert.ToInt32(Label11.Text.Trim()) > 0 Then

            Label11.Text = Label11.Text - 1
            Form2.Label12.Text = Form2.Label12.Text - 1
        End If
   
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Convert.ToInt32(Label20.Text.Trim()) > 0 Then

            Label20.Text = Label20.Text - 1
            Form2.Label2.Text = Form2.Label2.Text - 1
        End If

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If Convert.ToInt32(Label2.Text.Trim()) > 0 Then

            Label2.Text = Label2.Text - 1
            Form2.Label7.Text = Form2.Label7.Text - 1
        End If

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Label11.Text = Label11.Text + 1
        Form2.Label12.Text = Form2.Label12.Text + 1
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If Convert.ToInt32(Label8.Text.Trim()) < Convert.ToInt32(TextBox1.Text.Trim()) Then
            Label8.Text = Label8.Text + 1
            Form2.Label8.Text = Form2.Label8.Text + 1
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Label20.Text = Label20.Text + 1
        Form2.Label2.Text = Form2.Label2.Text + 1



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Convert.ToInt32(Label2.Text.Trim()) < Convert.ToInt32(TextBox1.Text.Trim()) Then
            Label2.Text = Label2.Text + 1
            Form2.Label7.Text = Form2.Label7.Text + 1
        End If


    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        If Convert.ToInt32(Label17.Text.Trim()) > 0 Then
            Label17.Text -= 1
            Form2.Label17.Text -= 1
            If Convert.ToInt32(Label17.Text.Trim()) < 10 Then
                Label17.Text = "0" + Label17.Text
                Form2.Label17.Text = "0" + Form2.Label17.Text
            End If
        End If
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Timer1.Start()
        Form2.Timer1.Start()
        Button22.Visible = True

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
     
    End Sub

   

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label15.Text = TextBox5.Text
        Label17.Text = TextBox6.Text
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Timer1.Stop()
        Form2.Timer1.Stop()
        Button22.Visible = False
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs)


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

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click

        Timer1.Stop()
        Label15.Text = TextBox5.Text
        Label17.Text = TextBox6.Text
        Form2.Label15.Text = TextBox5.Text
        Form2.Label17.Text = TextBox6.Text
        Label2.Text = "0 "
        Label20.Text = "0 "
        Label8.Text = "0 "
        Label11.Text = "0 "
        Form2.Label2.Text = "0 "
        Form2.Label7.Text = "0 "
        Form2.Label8.Text = "0 "
        Form2.Label12.Text = "0 "
        CheckBox23.Checked = False
        CheckBox22.Checked = False
        CheckBox17.Checked = False
        CheckBox21.Checked = False
        CheckBox20.Checked = False
        CheckBox19.Checked = False
        CheckBox1.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False
        CheckBox6.Checked = False
        CheckBox7.Checked = False
        CheckBox8.Checked = False
        CheckBox9.Checked = False
        CheckBox10.Checked = False
        CheckBox11.Checked = False
        CheckBox12.Checked = False
        CheckBox13.Checked = False
        CheckBox14.Checked = False
        CheckBox15.Checked = False
        CheckBox16.Checked = False
        CheckBox17.Checked = False
        CheckBox18.Checked = False
        Form2.PictureBox40.Visible = False
        Form2.PictureBox39.Visible = False
        Form2.PictureBox38.Visible = False
        Form2.PictureBox25.Visible = False
        Form2.PictureBox24.Visible = False
        Form2.PictureBox23.Visible = False
        Form2.PictureBox22.Visible = False
        Form2.PictureBox21.Visible = False
        Form2.PictureBox20.Visible = False
        Form2.PictureBox19.Visible = False
        Form2.PictureBox44.Visible = False
        Form2.PictureBox43.Visible = False
        Form2.PictureBox42.Visible = False
        Form2.PictureBox33.Visible = False
        Form2.PictureBox32.Visible = False
        Form2.PictureBox31.Visible = False
        Form2.PictureBox30.Visible = False
        Form2.PictureBox29.Visible = False
        Form2.PictureBox28.Visible = False
        Form2.PictureBox27.Visible = False















    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Label15.Text = TextBox5.Text
        Label17.Text = TextBox6.Text
        Form2.Label15.Text = TextBox5.Text
        Form2.Label17.Text = TextBox6.Text
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Form2.Show()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Form2.Hide()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Form2.Label5.Visible = True
        Else
            Form2.Label5.Visible = False
        End If
    End Sub

    Private Sub CheckBox18_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox18.CheckedChanged
        If CheckBox18.Checked = True Then
            Form2.Label4.Visible = True
        Else
            Form2.Label4.Visible = False
        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked = True Then
            Form2.PictureBox23.Visible = True
        Else
            Form2.PictureBox23.Visible = False
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            Form2.PictureBox24.Visible = True
        Else
            Form2.PictureBox24.Visible = False
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            Form2.PictureBox25.Visible = True
        Else
            Form2.PictureBox25.Visible = False
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs)
  
    End Sub

    Private Sub CheckBox9_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox9.CheckedChanged
        If CheckBox9.Checked = True Then
            Form2.PictureBox19.Visible = True
        Else
            Form2.PictureBox19.Visible = False
        End If
    End Sub

    Private Sub CheckBox8_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox8.CheckedChanged
        If CheckBox8.Checked = True Then
            Form2.PictureBox20.Visible = True
        Else
            Form2.PictureBox20.Visible = False
        End If
    End Sub

    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox7.CheckedChanged
        If CheckBox7.Checked = True Then
            Form2.PictureBox21.Visible = True
        Else
            Form2.PictureBox21.Visible = False
        End If
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        If CheckBox6.Checked = True Then
            Form2.PictureBox22.Visible = True
        Else
            Form2.PictureBox22.Visible = False
        End If
    End Sub

    Private Sub CheckBox10_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox10.CheckedChanged
        If CheckBox10.Checked = True Then
            Form2.PictureBox27.Visible = True
        Else
            Form2.PictureBox27.Visible = False
        End If
    End Sub

    Private Sub CheckBox11_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox11.CheckedChanged
        If CheckBox11.Checked = True Then
            Form2.PictureBox28.Visible = True
        Else
            Form2.PictureBox28.Visible = False
        End If
    End Sub

    Private Sub CheckBox12_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox12.CheckedChanged
        If CheckBox12.Checked = True Then
            Form2.PictureBox29.Visible = True
        Else
            Form2.PictureBox29.Visible = False
        End If
    End Sub

    Private Sub CheckBox13_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox13.CheckedChanged
        If CheckBox13.Checked = True Then
            Form2.PictureBox30.Visible = True
        Else
            Form2.PictureBox30.Visible = False
        End If
    End Sub

    Private Sub CheckBox14_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox14.CheckedChanged
        If CheckBox14.Checked = True Then
            Form2.PictureBox31.Visible = True
        Else
            Form2.PictureBox31.Visible = False
        End If
    End Sub

    Private Sub CheckBox15_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox15.CheckedChanged
        If CheckBox15.Checked = True Then
            Form2.PictureBox32.Visible = True
        Else
            Form2.PictureBox32.Visible = False
        End If
    End Sub

    Private Sub CheckBox16_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox16.CheckedChanged
        If CheckBox16.Checked = True Then
            Form2.PictureBox33.Visible = True
        Else
            Form2.PictureBox33.Visible = False
        End If
    End Sub

    Private Sub CheckBox17_CheckedChanged(sender As Object, e As EventArgs)
        'If CheckBox17.Checked = True Then
        '    Form2.PictureBox34.Visible = True
        'Else
        '    Form2.PictureBox34.Visible = False
        'End If
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub CheckBox23_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox23.CheckedChanged
        If CheckBox23.Checked = True Then
            Form2.PictureBox40.Visible = True
        Else
            Form2.PictureBox40.Visible = False
        End If
    End Sub

    Private Sub CheckBox20_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox20.CheckedChanged
        If CheckBox20.Checked = True Then
            Form2.PictureBox43.Visible = True
        Else
            Form2.PictureBox43.Visible = False
        End If
    End Sub

    Private Sub CheckBox19_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox19.CheckedChanged
        If CheckBox19.Checked = True Then
            Form2.PictureBox42.Visible = True
        Else
            Form2.PictureBox42.Visible = False
        End If
    End Sub

    Private Sub CheckBox22_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox22.CheckedChanged
        If CheckBox22.Checked = True Then
            Form2.PictureBox39.Visible = True
        Else
            Form2.PictureBox39.Visible = False
        End If
    End Sub

    Private Sub CheckBox17_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox17.CheckedChanged
        If CheckBox17.Checked = True Then
            Form2.PictureBox38.Visible = True
        Else
            Form2.PictureBox38.Visible = False
        End If
    End Sub

    Private Sub CheckBox21_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox21.CheckedChanged
        If CheckBox21.Checked = True Then
            Form2.PictureBox44.Visible = True
        Else
            Form2.PictureBox44.Visible = False
        End If
    End Sub
End Class
