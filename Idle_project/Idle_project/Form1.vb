Public Class Form1
    Dim EXP As Integer = 0              'experience, used as currency for leveling up, modifiers for EXP gained include: perception, monsters and (special bonus for endgame)
    Dim LVL As Integer = 1              'Levels, used to increase amount of experience gained per click/autoclick
    Dim DarkVisionLVL As Integer = 0    'Levels in skill: Darkvision, Used to increase EXP gained and to unlock next part of the story.
    Dim DarkVisionCost As Integer = 1   'Cost to level up the skill darkvision. (Might make this an overall skill EXP thing)
    Dim SkillPoints As Integer = 0      'Skill points, used to level up all skills.
    Dim LVLUpCost As Integer = 5        'Cost for leveling up, calculated based on this calculation: 1 + LVL^(0,25 * LVL)
    Dim AutoClick1_cost As Integer = 50 'Cost of autoclicker, going to be based on some mathemagics
    Dim AutoclickExp = 0                'Unknown, Kris can probably explain what it's going to be used for

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LVLUpCostCalc()                 'calculates the cost of every levelup button at startup
        UpdateLabels()                  'updates every label on startup.
    End Sub

    Private Sub btnMain_Click(sender As Object, e As EventArgs) Handles btnMain.Click   'activates set functions when a button is clicked
        clickF()
        UpdateLabels()
    End Sub

    Sub clickF()                        'Calculates and adds the amount of EXP added per click
        EXP += DarkVisionLVL + Math.Pow(LVL, 0.1 * LVL) 'the gotten EXP is based on this calculation: 1 + LVL^(0,1 * LVL)
        '*FIXME* Need to find out what makes players gain skill points.
        '*POSSIBLE SOLUTION*: could be based on pressing the levelup button, and in the future maybe kills. 
        'SkillPoints += Math.Pow(DarkVisionLVL, 0.05 * DarkVisionLVL)
    End Sub

    Private Sub BtnLVLUp_Click(sender As Object, e As EventArgs) Handles BtnLVLUp.Click 'Button to activate different functions and calculations for leveling up
        If EXP >= LVLUpCost Then        'checks whether or not the player has enough EXP
            EXP -= LVLUpCost            'starts the levelup process by lowering EXP by the cost of leveling
            LVL += 1                    'Increases the level.
            LVLUpCostCalc()             'Calculates what the next level costs.
            UpdateLabels()              'Updates all the labels visible to player.
        End If
    End Sub

    Sub LVLUpCostCalc()                 'Calculates what the next level costs.
        LVLUpCost = 1 + Math.Pow(LVL, 0.15 * LVL)   'sets the levelcost, based on the calculation: 1 + LVL^(0,15 * LVL)
        DarkVisionCost = Math.Pow(DarkVisionLVL, 0.1 * DarkVisionLVL)
    End Sub

    Sub UpdateLabels()                  'Updates the Labels by setting the text of them equal to the actual values.
        LblEXP.Text = EXP
        LblLVL.Text = LVL
        lblLVLCost.Text = LVLUpCost
        LblDarkVisionCost.Text = DarkVisionCost
        LblSkillPoints.Text = SkillPoints
    End Sub

    Private Sub BtnDarkVision_Click(sender As Object, e As EventArgs) Handles BtnDarkVision.Click   'starts the level up procedure for darkvision skill.
        If SkillPoints >= DarkVisionCost Then
            DarkVisionLVL += 1
            SkillPoints -= DarkVisionCost
            LVLUpCostCalc()
            UpdateLabels()
        End If
    End Sub

    ' I have no Idea past this point
    ' I have no Idea past this point
    ' I have no Idea past this point
    ' I have no Idea past this point
    ' I have no Idea past this point

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
