Public Class Form1
    Dim EXP As Double = 0              'experience, used as currency for leveling up, modifiers for EXP gained include: perception, monsters and (special bonus for endgame)
    Dim LVL As ULong = 1              'Levels, used to increase amount of experience gained per click/autoclick
    Dim DarkVisionLVL As ULong = 0    'Levels in skill: Darkvision, Used to increase EXP gained and to unlock next part of the story.
    Dim DarkVisionCost As ULong = 1   'Cost to level up the skill darkvision. (Might make this an overall skill EXP thing)
    Dim SkillPoints As ULong = 0      'Skill points, used to level up all skills.
    Dim LVLUpCost As ULong = 5        'Cost for leveling up, calculated based on this calculation: 1 + LVL^(0,25 * LVL)
    Dim AutoClick1_cost As Double = 50  'Cost of autoclicker, going to be based on some mathemagics
    Dim AutoclickExp As Double = 0      'Unknown, Kris can probably explain what it's going to be used for, "no i cant" -kris
    Dim KillAmount As ULong = 0       'Amount of Monsters killed

    'Under this point is the 8 stats the character can have
    Dim StatAGI As ULong = 1          'Agility, increases dodge chance.
    Dim StatEND As ULong = 1          'Endurance, Increases health a lot and HP regen a little.
    Dim StatINT As ULong = 1          'Intelligence, Increases Mana a lot and Mana Regen a little
    Dim StatPER As ULong = 1          'Perception, Increases EXP gotten and chance of critical hits
    Dim StatRES As ULong = 1          'Resistance, increases damage reduction
    Dim StatSTR As ULong = 1          'Strength, increases base damage
    Dim StatVIT As ULong = 1          'Vitality, increases HP regen a lot and health a little
    Dim StatWIS As ULong = 1          'Wisdom, increases mana regen a lot and mana a little
    'Above this point is the 8 stats the character can have.

    'Below this point is all stats a monster can have
    Dim MobHealth As Double = 0
    Dim MobDmg As Double = 0
    Dim MobName As String = "test"
    'Above this point is all stats a monster can have



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LVLUpCostCalc()                 'calculates the cost of every levelup button at startup.
        UpdateLabels()                  'updates every label on startup.
        TimerAutoclick.Enabled = False  'stops the timer on startup.
    End Sub

    Private Sub BtnMain_Click(sender As Object, e As EventArgs) Handles BtnMain.Click   'activates set functions when a button is clicked
        ClickF()
        UpdateLabels()
    End Sub

    Sub ClickF()                        'Calculates and adds the amount of EXP added per click
        '*FIXME* Find out how stats and kills should have an effect on EXP gained.
        EXP += LVL + Math.Pow(StatPER, (0.1 * StatPER) + (0.0001 * KillAmount)) 'the gotten EXP is based on this calculation: 1 + LVL^(0,1 * LVL)
        StartFight()
    End Sub

    Private Sub BtnLVLUp_Click(sender As Object, e As EventArgs) Handles BtnLVLUp.Click 'Button to activate different functions and calculations for leveling up
        If EXP >= LVLUpCost Then        'checks whether or not the player has enough EXP
            EXP -= LVLUpCost            'starts the levelup process by lowering EXP by the cost of leveling
            LVL += 1                    'Increases the level.
            SkillPoints += Math.Pow(2, 0.05 * LVL) 'Increases amount of skillpoints
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
        LblMobName.Text = MobName
        LblStatAGI.Text = StatAGI
        LblStatEND.Text = StatEND
        LblStatINT.Text = StatINT
        LblStatPER.Text = StatPER
        LblStatRES.Text = StatRES
        LblStatSTR.Text = StatSTR
        LblStatVIT.Text = StatVIT
        LblStatWIS.Text = StatWIS
    End Sub

    Private Sub BtnDarkVision_Click(sender As Object, e As EventArgs) Handles BtnDarkVision.Click   'starts the level up procedure for darkvision skill.
        If SkillPoints >= DarkVisionCost Then
            DarkVisionLVL += 1
            SkillPoints -= DarkVisionCost
            StatPER += 1
            LVLUpCostCalc()
            UpdateLabels()
        End If
    End Sub

    Sub StartFight()
        MobHealth = Rnd() * 360
        MobDmg = Rnd() * 360
        test3.Text = "Blin"
        test1.Text = MobHealth
        test2.Text = MobDmg
        '*FIXME* Find a way to change name of Mob depending on stats
        '*POSSIBLE SOLUTION* [ENTER POSSIBLE SOLUTION HERE]
        'Select Case MobHealth And MobDmg
        'Case MobHealth < 100 & MobHealth > MobDmg
        'LblMobName.Text = "Enduring Rat"
        'Case MobHealth < 100 & MobHealth < MobDmg
        'LblMobName.Text = "Strong Rat"
        'Case MobHealth > 100 & MobHealth <= 200 & MobDmg > MobHealth
        'LblMobName.Text = "Strong Slime"
        'Case MobHealth > 100 & MobHealth <= 200 & MobHealth > MobDmg
        'LblMobName.Text = "Enduring Slime"
        'Case MobHealth > 200 & MobHealth > MobDmg
        'LblMobName.Text = "Enduring Kobold"
        'Case MobHealth > 200 & MobDmg > MobHealth
        'LblMobName.Text = "Strong Kobold"
        'End Select
        UpdateLabels()
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

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class
