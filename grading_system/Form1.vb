Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dp As Integer
        Dim oop As Integer
        Dim wd As Integer
        Dim ict As Integer
        Dim oob As Integer
        Dim result As Integer

        dp = TextBox1.Text
        oop = TextBox2.Text
        wd = TextBox3.Text
        ict = TextBox4.Text
        oob = TextBox5.Text


        If dp > 10 Then
            Label8.Text = "E"

            If dp > 30 Then
                Label8.Text = "D"
            End If

            If dp > 50 Then
                Label8.Text = "C"
            End If

            If dp > 70 Then
                Label8.Text = "B"
            End If

            If dp > 90 Then
                Label8.Text = "A"
            End If
        End If

        If oop > 10 Then
            Label9.Text = "E"

            If oop > 30 Then
                Label9.Text = "D"
            End If

            If oop > 50 Then
                Label9.Text = "C"
            End If

            If oop > 70 Then
                Label9.Text = "B"
            End If

            If oop > 90 Then
                Label9.Text = "A"
            End If
        End If

        If wd > 10 Then
            Label11.Text = "E"

            If wd > 30 Then
                Label11.Text = "D"
            End If

            If wd > 50 Then
                Label11.Text = "C"
            End If

            If wd > 70 Then
                Label11.Text = "B"
            End If

            If wd > 90 Then
                Label11.Text = "A"
            End If
        End If

        If ict > 10 Then
            Label15.Text = "E"

            If ict > 30 Then
                Label15.Text = "D"
            End If

            If ict > 50 Then
                Label15.Text = "C"
            End If

            If ict > 70 Then
                Label15.Text = "B"
            End If

            If ict > 90 Then
                Label15.Text = "A"
            End If
        End If

        If oob > 10 Then
            Label13.Text = "E"

            If oob > 30 Then
                Label13.Text = "D"
            End If

            If oob > 50 Then
                Label13.Text = "C"
            End If

            If oob > 70 Then
                Label13.Text = "B"
            End If

            If oob > 90 Then
                Label13.Text = "A"
            End If
        End If


        result = (dp + oop + wd + ict + oob) / 5
        If result > 10 Then
            Label17.Text = "E"

            If result > 30 Then
                Label17.Text = "D"
            End If

            If result > 50 Then
                Label17.Text = "C"
            End If

            If result > 70 Then
                Label17.Text = "B"
            End If

            If result > 90 Then
                Label17.Text = "A"
            End If
        End If
    End Sub
End Class
