Public Class Form1
    Dim EXP As Integer = 0
    Dim LVL As Integer = 1
    Dim LVLUpCost As Integer = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnMain_Click(sender As Object, e As EventArgs) Handles btnMain.Click
        clickF()
        UpdateLabels()
    End Sub

    Sub clickF()
        EXP += 1 + Math.Pow(LVL, 0.2 * LVL)
    End Sub

    Private Sub BtnLVLUp_Click(sender As Object, e As EventArgs) Handles BtnLVLUp.Click
        If EXP >= LVLUpCost Then
            EXP -= LVLUpCost
            LVL += 1
            LblLVL.Text = LVL
            LVLUpCostCalc()
            UpdateLabels()
        End If
    End Sub

    Sub LVLUpCostCalc()
        LVLUpCost = Math.Round(LVL * Math.Pow(LVL, 0.25 * LVL))
    End Sub

    Sub UpdateLabels()
        LblEXP.Text = EXP
        LblLVL.Text = LVL
        lblLVLCost.Text = LVLUpCost
    End Sub

End Class
