Public Class Form1
    Dim Xpos As New Integer
    Dim Ypos As New Integer
    Dim pos As New Point

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown, Label1.MouseDown, PictureBox1.MouseDown
        Xpos = Cursor.Position.X - Me.Location.X
        Ypos = Cursor.Position.Y - Me.Location.Y
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove, Label1.MouseMove, PictureBox1.MouseMove
        If e.Button = MouseButtons.Left Then
            pos = MousePosition
            pos.X = pos.X - Xpos
            pos.Y = pos.Y - Ypos
            Me.Location = pos
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
End Class
