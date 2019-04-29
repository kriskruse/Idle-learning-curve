Public Class Form1
    Dim EXP As Double = 0               'experience, used as currency for leveling up, modifiers for EXP gained include: perception, monsters and (special bonus for endgame)
    Dim LVL As ULong = 1                'Levels, used to increase amount of experience gained per click/autoclick
    Dim SkillPoints As ULong = 0        'Skill points, used to level up all skills.
    Dim LVLUpCost As ULong = 5          'Cost for leveling up, calculated based on this calculation: 1 + LVL^(0,25 * LVL)
    Dim AutoClick1_cost As Double = 50  'Cost of autoclicker, going to be based on some mathemagics
    Dim AutoclickExp As Double = 0      'Amount of EXP given per Autoclick tick
    Dim AutoClickLVL As ULong = 0       'The level shown to the player, reffers to the amount of times the autoclicker has been upgraded
    Dim KillAmount As ULong = 0         'Amount of killed mobs
    Dim MobLvl As ULong = 0             'Level of difficulty of mobs. Based on amount of mobs killed.
    Dim BaseHealth As ULong = 100       'Base amount of health that mobs have.
    Dim AreaModifier As Double = 1      'Modifies health and damage of mobs based on the area
    Dim y As Double = 0

    'Under this point is the 8 stats the character can have
    Dim StatAGI As Integer = 1          'Agility, increases dodge chance.
    Dim StatEND As Integer = 1          'Endurance, Increases health a lot and HP regen a little.
    Dim StatINT As Integer = 1          'Intelligence, Increases Mana a lot and Mana Regen a little
    Dim StatPER As Integer = 1          'Perception, Increases EXP gotten and chance of critical hits
    Dim StatRES As Integer = 1          'Resistance, increases damage reduction
    Dim StatSTR As Integer = 1          'Strength, increases base damage
    Dim StatVIT As Integer = 1          'Vitality, increases HP regen a lot and health a little
    Dim StatWIS As Integer = 1          'Wisdom, increases mana regen a lot and mana a little
    'Above this point is the 8 stats the character can have.

    'All of the costs for those stats
    Dim PerUpCost As ULong = 1

    'Price calculations
    Dim p As Double = 0

    'Mob Stats
    Dim MobHealth As Double = 0
    Dim MobDamage As Double = 0

    'Tooltips handler
    Dim CPS = 0
    Dim AutoTTip = "Current CPS:  0"



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
        EXP += LVL + Math.Pow(StatPER, (0.1 * StatPER) + (0.001 * KillAmount)) 'the gotten EXP is based on a tenth of the perception stat and a thousandth of the amount of kills
    End Sub

    Private Sub BtnLVLUp_Click(sender As Object, e As EventArgs) Handles BtnLVLUp.Click 'Button to activate different functions and calculations for leveling up
        If EXP >= LVLUpCost Then                    'checks whether or not the player has enough EXP
            EXP -= LVLUpCost                        'starts the levelup process by lowering EXP by the cost of leveling
            LVL += 1                                'Increases the level.
            SkillPoints += Math.Pow(2, 0.05 * LVL)  'Increases amount of skillpoints
            LVLUpCostCalc()                         'Calculates what the next level costs.
            UpdateLabels()                          'Updates all the labels visible to player.
        End If
    End Sub

    Sub LVLUpCostCalc()                 'Calculates what the next level costs.
        LVLUpCost = 1 + Math.Pow(LVL, 0.15 * LVL)   'sets the levelcost, based on the calculation: 1 + LVL^(0,15 * LVL)
        PerUpCost = Math.Pow(StatPER, 0.1 * StatPER)
    End Sub

    Sub UpdateLabels()                  'Updates the Labels by setting the text of them equal to the actual values.
        LblEXP.Text = Math.Round(EXP)
        LblLVL.Text = LVL
        lblLVLCost.Text = LVLUpCost
        LblSkillPoints.Text = SkillPoints
        lblAutoClickcost.Text = Math.Round(AutoClick1_cost)
        LblStatAGI.Text = StatAGI
        LblStatEND.Text = StatEND
        LblStatINT.Text = StatINT
        LblStatPER.Text = StatPER
        LblStatRES.Text = StatRES
        LblStatSTR.Text = StatSTR
        LblStatVIT.Text = StatVIT
        LblStatWIS.Text = StatWIS
    End Sub

    Private Sub BtnPerUp_Click(sender As Object, e As EventArgs) Handles BtnPerUp.Click   'starts the level up procedure for darkvision skill.
        If SkillPoints >= PerUpCost Then
            StatPER += 1
            SkillPoints -= PerUpCost
            LVLUpCostCalc()
            UpdateLabels()
        End If
    End Sub

    Private Sub BtnSTRup_Click(sender As Object, e As EventArgs) Handles BtnSTRup.Click

    End Sub

    Private Sub BtnENDup_Click(sender As Object, e As EventArgs) Handles BtnENDup.Click

    End Sub

    Private Sub BtnINTup_Click(sender As Object, e As EventArgs) Handles BtnINTup.Click

    End Sub

    Private Sub BtnWISup_Click(sender As Object, e As EventArgs) Handles BtnWISup.Click

    End Sub

    Private Sub BtnVITup_Click(sender As Object, e As EventArgs) Handles BtnVITup.Click

    End Sub

    Private Sub BtnAGIup_Click(sender As Object, e As EventArgs) Handles BtnAGIup.Click

    End Sub

    Private Sub BtnRESup_Click(sender As Object, e As EventArgs) Handles BtnRESup.Click

    End Sub

    'Mob handling
    Public Sub Mobs()
        Dim MobName(2) As String
        Dim MobModifier(2) As String

        'Calculates the health and damage of mobs
        MobLvlCalc(KillAmount)
        MobHealth = (Math.Ceiling(Rnd() * MobLvl))
        MobDamage = (Math.Ceiling(Rnd() * MobLvl))

        'assigning values to each element
        MobModifier(0) = "Healthy"
        MobModifier(1) = "Tough"
        MobModifier(2) = "Average"

        MobName(0) = "Slime"
        MobName(1) = "Rat"
        MobName(2) = "Kobold"










        Select Case MobDamage
            Case Is < MobHealth
                LblMobMod.Text = MobModifier(0) 'sets the modifier for mobs to Healthy if the dammage is lower than health
            Case Is > MobHealth
                LblMobMod.Text = MobModifier(1) 'sets the modifier for mobs to Tough if the damage is higher than health
            Case Else
                LblMobMod.Text = MobModifier(2) 'sets the modifier for mobs to average if the damage is equal to health
        End Select

        Select Case MobHealth
            Case Is < BaseHealth / AreaModifier
                LblMobName.Text = MobName(0) 'sets the mobs name to slime if the mob health is lower than 100
            Case Is <= (BaseHealth * 1.5) / AreaModifier
                LblMobName.Text = MobName(1) 'sets the mobs name to rat if the mob health is lower than or equal to 200
            Case Is <= (BaseHealth * 2) / AreaModifier
                LblMobName.Text = MobName(2) 'sets the mobs name to kobold if the mob health is lower than or equal to 360











            Case Else
                LblMobName.Text = "ERROR" 'if the calculation fucks up somehow, throw an error.
        End Select

        'Test component, Shows the damage and health of mobs on test labels
        LblMobDamage.Text = MobDamage
        LblMobHealth.Text = MobHealth

    End Sub

    'Calculates the mob level based on mob kills.
    Function MobLvlCalc(x As Integer)
        '*FIXME* Add stuff that properly calculates the level of mobs.
        MobLvl = (x) + BaseHealth
        Return MobLvl
    End Function

    'Calculates cost and return new value, Basic mathemagicks
    Function Costcal(x, y, z) 'calculates the cost of different upgrades based on what values are entered into the function
        If x > 0 & y = 0 & z = 0 Then 'If x is the only value to be used
            p = Math.Pow(x * 100, 0.95 * Math.Log(5)) 'Creates an exponential graph used to calculate the cost of stuff using one value

        ElseIf x > 0 & y > 0 & z = 0 Then 'If there are 2 values to be used
            p = Math.Pow(x + y * 100, 0.95 * Math.Log(5)) 'uses the two values by adding the value of y to the previous calculation

        ElseIf x > 0 & y > 0 & z > 0 Then 'If there are 3 values to be used
            p = Math.Pow(x + y + z * 100, 0.95 * Math.Log(5)) 'uses the third value z by adding z to the previous calculation.

        End If
        Return (p)
    End Function


    'Autoclclicker 
    Private Sub AutoClickBuy_Click(sender As Object, e As EventArgs) Handles AutoClickBuy.Click
        If EXP >= AutoClick1_cost Then 'Matches prize and currency amount
            EXP -= AutoClick1_cost      'Removes the cost from the current currency amount
            TimerAutoclick.Start()      'Starts the Timer/Clock that activates the clicks
            AutoclickExp += 0.01        'EXP gain per click, updates per lvl
            AutoClick1_cost = 50 + Costcal(AutoclickExp, 0, 0)
            AutoClickLVL += 1           'Level shown to player
            lblAutoLVL.Text = AutoClickLVL  'Updates Label 

            'ToolTips for buttons.
            CPS = AutoclickExp * 100
            AutoTTip = "Current CPS:  " & CPS & " EXP/s"
            TTAuto.SetToolTip(AutoClickBuy, AutoTTip)

        End If
    End Sub

    'Autoclick timer, Ticks ones every 1ms
    Private Sub TimerAutoclick_Tick(sender As Object, e As EventArgs) Handles TimerAutoclick.Tick
        EXP += AutoclickExp
        UpdateLabels()
    End Sub

    Private Sub BtnStartFight_Click(sender As Object, e As EventArgs) Handles BtnStartFight.Click
        Mobs()
        KillAmount += 1
        TestKillAmount.Text = KillAmount
    End Sub

End Class
