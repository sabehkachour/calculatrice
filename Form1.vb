Public Class Form1.vb
    Dim A As String
    Dim B As String
    Dim op = ""

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If op = "" Then
            A = A + "0"
        Else
            B = B + "0"
        End If
        TextBox1.Text = A + " " + op + " " + B
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If op = "" Then
            A = A + "1"
        Else
            B = B + "1"
        End If
        TextBox1.Text = A + " " + op + " " + B
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If op = "" Then
            A = A + "2"
        Else
            B = B + "2"
        End If
        TextBox1.Text = A + " " + op + " " + B
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If op = "" Then
            A = A + "3"
        Else
            B = B + "3"
        End If
        TextBox1.Text = A + " " + op + " " + B
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If op = "" Then
            A = A + "4"
        Else
            B = B + "4"
        End If
        TextBox1.Text = A + " " + op + " " + B
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If op = "" Then
            A = A + "5"
        Else
            B = B + "5"
        End If
        TextBox1.Text = A + " " + op + " " + B
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If op = "" Then
            A = A + "6"
        Else
            B = B + "6"
        End If
        TextBox1.Text = A + " " + op + " " + B
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If op = "" Then
            A = A + "7"
        Else
            B = B + "7"
        End If
        TextBox1.Text = A + " " + op + " " + B
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If op = "" Then
            A = A + "8"
        Else
            B = B + "8"
        End If
        TextBox1.Text = A + " " + op + " " + B
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If op = "" Then
            A = A + "9"
        Else
            B = B + "9"
        End If
        TextBox1.Text = A + " " + op + " " + B
    End Sub

    Private Sub Buttonpluss_Click(sender As Object, e As EventArgs) Handles Buttonpluss.Click
        If Not A = "" Then
            op = "+"
        End If
        TextBox1.Text = A + " " + op + " " + B
    End Sub

    Private Sub Buttonmins_Click(sender As Object, e As EventArgs) Handles Buttonmins.Click
        If Not A = "" Then
            op = "-"
        End If
        TextBox1.Text = A + " " + op + " " + B
    End Sub

    Private Sub Buttonmult_Click(sender As Object, e As EventArgs) Handles Buttonmult.Click
        If Not A = "" Then
            op = "*"
        End If
        TextBox1.Text = A + " " + op + " " + B
    End Sub

    Private Sub Buttondiv_Click(sender As Object, e As EventArgs) Handles Buttondiv.Click
        If Not A = "" Then
            op = "/"
        End If
        TextBox1.Text = A + " " + op + " " + B
    End Sub


    Private Sub Buttonegale_Click(sender As Object, e As EventArgs) Handles Buttonegale.Click
        Dim Test = True
        Dim res As Double
        If IsNumeric(A) And IsNumeric(B) And Not op = "" Then
            Dim va = Integer.Parse(A)
            Dim vb = Integer.Parse(B)

            If op = "+" Then
                res = va + vb
            ElseIf op = "-" Then
                res = va - vb
            ElseIf op = "*" Then
                res = va * vb
            ElseIf op = "/" And Not op = "" Then
                res = va / vb
            Else
                MessageBox.Show("Division par 0")
                Test = False
            End If
        Else
            MessageBox.Show("A et B doivent etre des entiers")
            Test = False
        End If
        If Test Then
            TextBox1.Text = TextBox1.Text + "=" + res.ToString
        End If

    End Sub

    Private Sub Buttonclear_Click(sender As Object, e As EventArgs) Handles Buttonclear.Click
        TextBox1.Text = " "

    End Sub
End Class


