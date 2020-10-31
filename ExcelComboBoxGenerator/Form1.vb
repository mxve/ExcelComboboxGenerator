Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox3.Text = ""

        Dim inputArr As String()
        inputArr = TextBox1.Text.Split(",")


        Dim valueArr As String()
        valueArr = TextBox2.Text.Split(",")

        TextBox3.Text += "="

        For Each s As String In inputArr
            Dim _s As String
            If s.StartsWith(" ") Then
                _s = s.Remove(0, 1)
            Else
                _s = s
            End If

            TextBox3.Text += getIf() + "(" + TextBox4.Text + "=""" + _s + """; " + valueArr(Array.IndexOf(inputArr, s))

            If Not Array.IndexOf(inputArr, s) + 1 = inputArr.Length Then
                TextBox3.Text += ";"
            End If
        Next
        For i As Integer = 1 To inputArr.Length
            TextBox3.Text += ")"
        Next
    End Sub

    Function getIf()
        Select Case ComboBox1.Text
            Case "Deutsch"
                Return "WENN"
            Case "English"
                Return "IF"
            Case "Français"
                Return "SI"
            Case "русском"
                Return "ЕСЛИ"
            Case "Nederlands"
                Return "ALS"
        End Select
        Return "IF"
    End Function
End Class
