Public Class Form1
    Dim units As Integer
    Dim adders As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnMain_Click(sender As Object, e As EventArgs) Handles btnMain.Click
        clickF()
    End Sub

    Sub clickF()
        units += 1 + adders
    End Sub


End Class
