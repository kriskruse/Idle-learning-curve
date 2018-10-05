Public Class Form1
    Dim EXP As Integer = 0              'experience, used as currency for leveling up
    Dim LVL As Integer = 1              'Levels, used to increase amount of experience gained per click/autoclick
    Dim LVLUpCost As Integer = 0        'Cost for leveling up, calculated based on this calculation: 1 + LVL^(0,25 * LVL)
    Dim AutoClick1_cost As Integer = 50 'Cost of autoclicker, going to be based on some mathemagics
    Dim AutoclickExp = 0                'Unknown, Kris can probably explain what it's going to be used for

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnMain_Click(sender As Object, e As EventArgs) Handles btnMain.Click   'activates set functions when a button is clicked
        clickF()
        UpdateLabels()
    End Sub

    Sub clickF()    'Calculates and adds the amount of EXP added per click
        EXP += 1 + Math.Pow(LVL, 0.2 * LVL) 'the gotten EXP is based on this calculation: 1 + LVL^(0,2 * LVL)
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
        LVLUpCost = 1 + Math.Pow(LVL, 0.25 * LVL)
    End Sub

    Sub UpdateLabels()
        LblEXP.Text = EXP
        LblLVL.Text = LVL
        lblLVLCost.Text = LVLUpCost
    End Sub


    Sub Loop1()
        While AutoclickExp >= 1
            EXP += AutoclickExp
        End While
    End Sub

    Private Sub AutoClickBuy_Click(sender As Object, e As EventArgs) Handles AutoClickBuy.Click
        If EXP >= AutoClick1_cost Then
            AutoclickExp += 1
        End If
    End Sub
End Class
