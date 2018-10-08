Public Class Form1
    Dim EXP As Double = 0              'experience, used as currency for leveling up, modifiers for EXP gained include: perception, monsters and (special bonus for endgame)
    Dim LVL As Integer = 1              'Levels, used to increase amount of experience gained per click/autoclick
    Dim DarkVisionLVL As Integer = 0    'Levels in skill: Darkvision, Used to increase EXP gained and to unlock next part of the story.
    Dim DarkVisionCost As Integer = 1   'Cost to level up the skill darkvision. (Might make this an overall skill EXP thing)
    Dim SkillPoints As Integer = 0      'Skill points, used to level up all skills.
    Dim LVLUpCost As Integer = 5        'Cost for leveling up, calculated based on this calculation: 1 + LVL^(0,25 * LVL)
    Dim AutoClick1_cost As Double = 50  'Cost of autoclicker, going to be based on some mathemagics
    Dim AutoclickExp As Double = 0      'Unknown, Kris can probably explain what it's going to be used for, "no i cant" -kris


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LVLUpCostCalc()                 'calculates the cost of every levelup button at startup
        UpdateLabels()                  'updates every label on startup.
        TimerAutoclick.Enabled = False
    End Sub

    Private Sub BtnMain_Click(sender As Object, e As EventArgs) Handles BtnMain.Click   'activates set functions when a button is clicked
        ClickF()
        UpdateLabels()
    End Sub

    Sub ClickF()                        'Calculates and adds the amount of EXP added per click
        '*FIXME* Find out how stats should have an effect on EXP gained.
        EXP += DarkVisionLVL + Math.Pow(LVL, 0.1 * LVL) 'the gotten EXP is based on this calculation: 1 + LVL^(0,1 * LVL)
        '*FIXME* Need to find out what makes players gain skill points.
        '*POSSIBLE SOLUTION*: could be based on pressing the levelup button, and in the future maybe kills. 
        SkillPoints += Math.Pow(DarkVisionLVL, 0.05 * DarkVisionLVL)
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
        LblEXP.Text = Math.Round(EXP)
        LblLVL.Text = LVL
        lblLVLCost.Text = LVLUpCost
        LblDarkVisionCost.Text = DarkVisionCost
        LblSkillPoints.Text = SkillPoints
        lblAutoClickcost.Text = Math.Round(AutoClick1_cost)
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
    ' Niether has Kris

    Private Sub AutoClickBuy_Click(sender As Object, e As EventArgs) Handles AutoClickBuy.Click 'This is autoclicker Buch no cross
        If EXP >= AutoClick1_cost Then
            EXP -= AutoClick1_cost
            TimerAutoclick.Start()
            AutoclickExp += 0.01
            AutoClick1_cost += Math.Pow(AutoclickExp * 100.2, 1.2 * AutoclickExp * 10)
        End If
    End Sub

    Private Sub TimerAutoclick_Tick(sender As Object, e As EventArgs) Handles TimerAutoclick.Tick
        EXP += AutoclickExp
        UpdateLabels()
    End Sub
End Class
