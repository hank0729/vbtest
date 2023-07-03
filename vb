Public Class Form1
    Private Sub btn_01_Click(sender As Object, e As EventArgs) Handles btn_01.Click
        Dim m0, m1, m2, m3, m4
        FileOpen(1, "C:\Users\user\test\1060301.SM", OpenMode.Input)
        Input(1, m0)
        FileClose(1)
        m1 = m0
        While m1 <> 0
            m3 = m1 Mod 10
            m1 = (m1 - m3) / 10
            m4 = m4 & m3

        End While
        If m0 = m4 Then
            txt_01.Text = "第一題結果 : " & m0 & " is a palindrome."
        Else
            txt_01.Text = "第一題結果 : " & m0 & " is not a palindrome."
        End If
    End Sub

    Private Sub btn_02_Click(sender As Object, e As EventArgs) Handles btn_02.Click
        Dim m0, m1, m2, m3, m4
        FileOpen(1, "C:\Users\user\test\1060301.SM", OpenMode.Input)
        Input(1, m0)
        FileClose(1)
        m1 = m0
        For i = 1 To m0
            m3 = m1 Mod 10
            m1 = (m1 - m3) / 10
            m4 = m4 & m3

        Next
        If m0 = m4 Then
            txt_02.Text = "第一題結果 : " & m0 & " is a palindrome."
        Else
            txt_02.Text = "第一題結果 : " & m0 & " is not a palindrome."
        End If

    End Sub

    Private Sub btn_03_Click(sender As Object, e As EventArgs) Handles btn_03.Click
        Dim m0, m1, m2, m3, m4
        FileOpen(1, "C:\Users\user\test\1060301.SM", OpenMode.Input)
        Input(1, m0)
        FileClose(1)
        m1 = m0
        Do
            m3 = m1 Mod 10
            m1 = (m1 - m3) / 10
            m4 = m4 & m3
            If m3 = 0 Then
                Exit Do
            End If
        Loop
        If m0 = m4 Then
            txt_03.Text = "第一題結果 : " & m0 & " is a palindrome."
        Else
            txt_03.Text = "第一題結果 : " & m0 & " is not a palindrome."
        End If
    End Sub
End Class
