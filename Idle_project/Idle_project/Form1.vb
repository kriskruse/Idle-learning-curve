Public Class Form1
    Dim EXP As Integer = 0
    Dim LVL As Integer = LblLVL.Text
    Dim LVLUpCost As Integer = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnMain_Click(sender As Object, e As EventArgs) Handles btnMain.Click
        clickF()
    End Sub

    Sub clickF()
        EXP += 1 + LVL
    End Sub

    Private Sub BtnLVLUp_Click(sender As Object, e As EventArgs) Handles BtnLVLUp.Click
        If EXP >= LVLUpCost Then
            EXP = EXP - LVLUpCost
            LVL += 1
            LVLUpCostCalc()
        End If
    End Sub

    Sub LVLUpCostCalc()
        LVLUpCost = Math.Ceiling(LVL * Math.Log10(5 * LVL))
    End Sub

End Class
