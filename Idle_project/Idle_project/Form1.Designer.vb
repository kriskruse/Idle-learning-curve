<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.BtnMain = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblEXP = New System.Windows.Forms.Label()
        Me.LblLVL = New System.Windows.Forms.Label()
        Me.BtnLVLUp = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblLVLCost = New System.Windows.Forms.Label()
        Me.AutoClickBuy = New System.Windows.Forms.Button()
        Me.BtnPerUp = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LblSkillPoints = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TimerAutoclick = New System.Windows.Forms.Timer(Me.components)
        Me.lblAutoClickcost = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.LblStatSTR = New System.Windows.Forms.Label()
        Me.LblStatPER = New System.Windows.Forms.Label()
        Me.LblStatEND = New System.Windows.Forms.Label()
        Me.LblStatINT = New System.Windows.Forms.Label()
        Me.LblStatRES = New System.Windows.Forms.Label()
        Me.LblStatAGI = New System.Windows.Forms.Label()
        Me.LblStatVIT = New System.Windows.Forms.Label()
        Me.LblStatWIS = New System.Windows.Forms.Label()
        Me.lblAutoLVL = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TTAuto = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.LblMobName = New System.Windows.Forms.Label()
        Me.LblMobMod = New System.Windows.Forms.Label()
        Me.BtnStartFight = New System.Windows.Forms.Button()
        Me.LblMobHealth = New System.Windows.Forms.Label()
        Me.LblMobDamage = New System.Windows.Forms.Label()
        Me.TestKillAmount = New System.Windows.Forms.Label()
        Me.BtnSTRup = New System.Windows.Forms.Button()
        Me.BtnENDup = New System.Windows.Forms.Button()
        Me.BtnINTup = New System.Windows.Forms.Button()
        Me.BtnRESup = New System.Windows.Forms.Button()
        Me.BtnAGIup = New System.Windows.Forms.Button()
        Me.BtnVITup = New System.Windows.Forms.Button()
        Me.BtnWISup = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnMain
        '
        Me.BtnMain.Location = New System.Drawing.Point(7, 8)
        Me.BtnMain.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnMain.Name = "BtnMain"
        Me.BtnMain.Size = New System.Drawing.Size(251, 449)
        Me.BtnMain.TabIndex = 0
        Me.BtnMain.Text = "CLICK ME TO GRIND FOR EXP"
        Me.BtnMain.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(265, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "EXP"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(339, 335)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "LVL"
        '
        'LblEXP
        '
        Me.LblEXP.AutoSize = True
        Me.LblEXP.ForeColor = System.Drawing.Color.White
        Me.LblEXP.Location = New System.Drawing.Point(299, 10)
        Me.LblEXP.Name = "LblEXP"
        Me.LblEXP.Size = New System.Drawing.Size(13, 13)
        Me.LblEXP.TabIndex = 3
        Me.LblEXP.Text = "0"
        '
        'LblLVL
        '
        Me.LblLVL.AutoSize = True
        Me.LblLVL.ForeColor = System.Drawing.Color.White
        Me.LblLVL.Location = New System.Drawing.Point(339, 349)
        Me.LblLVL.Name = "LblLVL"
        Me.LblLVL.Size = New System.Drawing.Size(13, 13)
        Me.LblLVL.TabIndex = 4
        Me.LblLVL.Text = "1"
        '
        'BtnLVLUp
        '
        Me.BtnLVLUp.Location = New System.Drawing.Point(264, 365)
        Me.BtnLVLUp.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnLVLUp.Name = "BtnLVLUp"
        Me.BtnLVLUp.Size = New System.Drawing.Size(143, 57)
        Me.BtnLVLUp.TabIndex = 5
        Me.BtnLVLUp.Text = "Level up"
        Me.BtnLVLUp.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(265, 336)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Cost"
        '
        'lblLVLCost
        '
        Me.lblLVLCost.AutoSize = True
        Me.lblLVLCost.ForeColor = System.Drawing.Color.White
        Me.lblLVLCost.Location = New System.Drawing.Point(265, 349)
        Me.lblLVLCost.Name = "lblLVLCost"
        Me.lblLVLCost.Size = New System.Drawing.Size(13, 13)
        Me.lblLVLCost.TabIndex = 7
        Me.lblLVLCost.Text = "0"
        '
        'AutoClickBuy
        '
        Me.AutoClickBuy.Location = New System.Drawing.Point(262, 461)
        Me.AutoClickBuy.Margin = New System.Windows.Forms.Padding(2)
        Me.AutoClickBuy.Name = "AutoClickBuy"
        Me.AutoClickBuy.Size = New System.Drawing.Size(144, 57)
        Me.AutoClickBuy.TabIndex = 8
        Me.AutoClickBuy.Text = "Auto Grinder"
        Me.AutoClickBuy.UseVisualStyleBackColor = True
        '
        'BtnPerUp
        '
        Me.BtnPerUp.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnPerUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPerUp.Location = New System.Drawing.Point(470, 397)
        Me.BtnPerUp.Name = "BtnPerUp"
        Me.BtnPerUp.Size = New System.Drawing.Size(30, 30)
        Me.BtnPerUp.TabIndex = 10
        Me.BtnPerUp.Text = "+"
        Me.BtnPerUp.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(486, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Skill Points"
        '
        'LblSkillPoints
        '
        Me.LblSkillPoints.AutoSize = True
        Me.LblSkillPoints.ForeColor = System.Drawing.Color.White
        Me.LblSkillPoints.Location = New System.Drawing.Point(545, 10)
        Me.LblSkillPoints.Name = "LblSkillPoints"
        Me.LblSkillPoints.Size = New System.Drawing.Size(13, 13)
        Me.LblSkillPoints.TabIndex = 12
        Me.LblSkillPoints.Text = "0"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(494, 26)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(219, 306)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "*TEMP* Fighting area"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(267, 26)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(219, 306)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "*TEMP* Story area"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(7, 461)
        Me.Button4.Margin = New System.Windows.Forms.Padding(2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(251, 57)
        Me.Button4.TabIndex = 18
        Me.Button4.Text = "*TEMP* Rebirth"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TimerAutoclick
        '
        Me.TimerAutoclick.Interval = 1
        '
        'lblAutoClickcost
        '
        Me.lblAutoClickcost.AutoSize = True
        Me.lblAutoClickcost.ForeColor = System.Drawing.Color.White
        Me.lblAutoClickcost.Location = New System.Drawing.Point(265, 444)
        Me.lblAutoClickcost.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAutoClickcost.Name = "lblAutoClickcost"
        Me.lblAutoClickcost.Size = New System.Drawing.Size(13, 13)
        Me.lblAutoClickcost.TabIndex = 19
        Me.lblAutoClickcost.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(413, 365)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "STR."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(413, 405)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "PER."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(413, 449)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(33, 13)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "END."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(413, 492)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(28, 13)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "INT."
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(545, 365)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(32, 13)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "RES."
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(545, 405)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(28, 13)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "AGI."
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(545, 449)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(27, 13)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "VIT."
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(545, 492)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(31, 13)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "WIS."
        '
        'LblStatSTR
        '
        Me.LblStatSTR.AutoSize = True
        Me.LblStatSTR.ForeColor = System.Drawing.Color.White
        Me.LblStatSTR.Location = New System.Drawing.Point(451, 365)
        Me.LblStatSTR.Name = "LblStatSTR"
        Me.LblStatSTR.Size = New System.Drawing.Size(13, 13)
        Me.LblStatSTR.TabIndex = 29
        Me.LblStatSTR.Text = "0"
        '
        'LblStatPER
        '
        Me.LblStatPER.AutoSize = True
        Me.LblStatPER.ForeColor = System.Drawing.Color.White
        Me.LblStatPER.Location = New System.Drawing.Point(451, 405)
        Me.LblStatPER.Name = "LblStatPER"
        Me.LblStatPER.Size = New System.Drawing.Size(13, 13)
        Me.LblStatPER.TabIndex = 30
        Me.LblStatPER.Text = "0"
        '
        'LblStatEND
        '
        Me.LblStatEND.AutoSize = True
        Me.LblStatEND.ForeColor = System.Drawing.Color.White
        Me.LblStatEND.Location = New System.Drawing.Point(452, 449)
        Me.LblStatEND.Name = "LblStatEND"
        Me.LblStatEND.Size = New System.Drawing.Size(13, 13)
        Me.LblStatEND.TabIndex = 31
        Me.LblStatEND.Text = "0"
        '
        'LblStatINT
        '
        Me.LblStatINT.AutoSize = True
        Me.LblStatINT.ForeColor = System.Drawing.Color.White
        Me.LblStatINT.Location = New System.Drawing.Point(452, 492)
        Me.LblStatINT.Name = "LblStatINT"
        Me.LblStatINT.Size = New System.Drawing.Size(13, 13)
        Me.LblStatINT.TabIndex = 32
        Me.LblStatINT.Text = "0"
        '
        'LblStatRES
        '
        Me.LblStatRES.AutoSize = True
        Me.LblStatRES.ForeColor = System.Drawing.Color.White
        Me.LblStatRES.Location = New System.Drawing.Point(583, 365)
        Me.LblStatRES.Name = "LblStatRES"
        Me.LblStatRES.Size = New System.Drawing.Size(13, 13)
        Me.LblStatRES.TabIndex = 33
        Me.LblStatRES.Text = "0"
        '
        'LblStatAGI
        '
        Me.LblStatAGI.AutoSize = True
        Me.LblStatAGI.ForeColor = System.Drawing.Color.White
        Me.LblStatAGI.Location = New System.Drawing.Point(583, 405)
        Me.LblStatAGI.Name = "LblStatAGI"
        Me.LblStatAGI.Size = New System.Drawing.Size(13, 13)
        Me.LblStatAGI.TabIndex = 34
        Me.LblStatAGI.Text = "0"
        '
        'LblStatVIT
        '
        Me.LblStatVIT.AutoSize = True
        Me.LblStatVIT.ForeColor = System.Drawing.Color.White
        Me.LblStatVIT.Location = New System.Drawing.Point(583, 449)
        Me.LblStatVIT.Name = "LblStatVIT"
        Me.LblStatVIT.Size = New System.Drawing.Size(13, 13)
        Me.LblStatVIT.TabIndex = 35
        Me.LblStatVIT.Text = "0"
        '
        'LblStatWIS
        '
        Me.LblStatWIS.AutoSize = True
        Me.LblStatWIS.ForeColor = System.Drawing.Color.White
        Me.LblStatWIS.Location = New System.Drawing.Point(583, 492)
        Me.LblStatWIS.Name = "LblStatWIS"
        Me.LblStatWIS.Size = New System.Drawing.Size(13, 13)
        Me.LblStatWIS.TabIndex = 36
        Me.LblStatWIS.Text = "0"
        '
        'lblAutoLVL
        '
        Me.lblAutoLVL.AutoSize = True
        Me.lblAutoLVL.ForeColor = System.Drawing.Color.White
        Me.lblAutoLVL.Location = New System.Drawing.Point(339, 444)
        Me.lblAutoLVL.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAutoLVL.Name = "lblAutoLVL"
        Me.lblAutoLVL.Size = New System.Drawing.Size(13, 13)
        Me.lblAutoLVL.TabIndex = 41
        Me.lblAutoLVL.Text = "0"
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(0, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(100, 23)
        Me.Label17.TabIndex = 0
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(0, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(100, 23)
        Me.Label18.TabIndex = 0
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(265, 426)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(28, 13)
        Me.Label19.TabIndex = 44
        Me.Label19.Text = "Cost"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(339, 426)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(26, 13)
        Me.Label20.TabIndex = 45
        Me.Label20.Text = "LVL"
        '
        'LblMobName
        '
        Me.LblMobName.AutoSize = True
        Me.LblMobName.ForeColor = System.Drawing.Color.White
        Me.LblMobName.Location = New System.Drawing.Point(689, 336)
        Me.LblMobName.Name = "LblMobName"
        Me.LblMobName.Size = New System.Drawing.Size(24, 13)
        Me.LblMobName.TabIndex = 46
        Me.LblMobName.Text = "test"
        '
        'LblMobMod
        '
        Me.LblMobMod.AutoSize = True
        Me.LblMobMod.ForeColor = System.Drawing.Color.White
        Me.LblMobMod.Location = New System.Drawing.Point(634, 336)
        Me.LblMobMod.Name = "LblMobMod"
        Me.LblMobMod.Size = New System.Drawing.Size(24, 13)
        Me.LblMobMod.TabIndex = 47
        Me.LblMobMod.Text = "test"
        '
        'BtnStartFight
        '
        Me.BtnStartFight.Location = New System.Drawing.Point(637, 395)
        Me.BtnStartFight.Name = "BtnStartFight"
        Me.BtnStartFight.Size = New System.Drawing.Size(135, 23)
        Me.BtnStartFight.TabIndex = 48
        Me.BtnStartFight.Text = "Test mob stuff"
        Me.BtnStartFight.UseVisualStyleBackColor = True
        '
        'LblMobHealth
        '
        Me.LblMobHealth.AutoSize = True
        Me.LblMobHealth.ForeColor = System.Drawing.Color.White
        Me.LblMobHealth.Location = New System.Drawing.Point(634, 365)
        Me.LblMobHealth.Name = "LblMobHealth"
        Me.LblMobHealth.Size = New System.Drawing.Size(24, 13)
        Me.LblMobHealth.TabIndex = 49
        Me.LblMobHealth.Text = "test"
        '
        'LblMobDamage
        '
        Me.LblMobDamage.AutoSize = True
        Me.LblMobDamage.ForeColor = System.Drawing.Color.White
        Me.LblMobDamage.Location = New System.Drawing.Point(689, 365)
        Me.LblMobDamage.Name = "LblMobDamage"
        Me.LblMobDamage.Size = New System.Drawing.Size(24, 13)
        Me.LblMobDamage.TabIndex = 50
        Me.LblMobDamage.Text = "test"
        '
        'TestKillAmount
        '
        Me.TestKillAmount.AutoSize = True
        Me.TestKillAmount.ForeColor = System.Drawing.Color.White
        Me.TestKillAmount.Location = New System.Drawing.Point(634, 426)
        Me.TestKillAmount.Name = "TestKillAmount"
        Me.TestKillAmount.Size = New System.Drawing.Size(24, 13)
        Me.TestKillAmount.TabIndex = 51
        Me.TestKillAmount.Text = "test"
        '
        'BtnSTRup
        '
        Me.BtnSTRup.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnSTRup.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSTRup.Location = New System.Drawing.Point(470, 355)
        Me.BtnSTRup.Name = "BtnSTRup"
        Me.BtnSTRup.Size = New System.Drawing.Size(30, 30)
        Me.BtnSTRup.TabIndex = 52
        Me.BtnSTRup.Text = "+"
        Me.BtnSTRup.UseVisualStyleBackColor = True
        '
        'BtnENDup
        '
        Me.BtnENDup.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnENDup.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnENDup.Location = New System.Drawing.Point(470, 439)
        Me.BtnENDup.Name = "BtnENDup"
        Me.BtnENDup.Size = New System.Drawing.Size(30, 30)
        Me.BtnENDup.TabIndex = 53
        Me.BtnENDup.Text = "+"
        Me.BtnENDup.UseVisualStyleBackColor = True
        '
        'BtnINTup
        '
        Me.BtnINTup.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnINTup.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnINTup.Location = New System.Drawing.Point(470, 482)
        Me.BtnINTup.Name = "BtnINTup"
        Me.BtnINTup.Size = New System.Drawing.Size(30, 30)
        Me.BtnINTup.TabIndex = 54
        Me.BtnINTup.Text = "+"
        Me.BtnINTup.UseVisualStyleBackColor = True
        '
        'BtnRESup
        '
        Me.BtnRESup.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnRESup.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRESup.Location = New System.Drawing.Point(598, 355)
        Me.BtnRESup.Name = "BtnRESup"
        Me.BtnRESup.Size = New System.Drawing.Size(30, 30)
        Me.BtnRESup.TabIndex = 55
        Me.BtnRESup.Text = "+"
        Me.BtnRESup.UseVisualStyleBackColor = True
        '
        'BtnAGIup
        '
        Me.BtnAGIup.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnAGIup.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAGIup.Location = New System.Drawing.Point(598, 397)
        Me.BtnAGIup.Name = "BtnAGIup"
        Me.BtnAGIup.Size = New System.Drawing.Size(30, 30)
        Me.BtnAGIup.TabIndex = 56
        Me.BtnAGIup.Text = "+"
        Me.BtnAGIup.UseVisualStyleBackColor = True
        '
        'BtnVITup
        '
        Me.BtnVITup.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnVITup.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVITup.Location = New System.Drawing.Point(598, 439)
        Me.BtnVITup.Name = "BtnVITup"
        Me.BtnVITup.Size = New System.Drawing.Size(30, 30)
        Me.BtnVITup.TabIndex = 57
        Me.BtnVITup.Text = "+"
        Me.BtnVITup.UseVisualStyleBackColor = True
        '
        'BtnWISup
        '
        Me.BtnWISup.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnWISup.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnWISup.Location = New System.Drawing.Point(598, 482)
        Me.BtnWISup.Name = "BtnWISup"
        Me.BtnWISup.Size = New System.Drawing.Size(30, 30)
        Me.BtnWISup.TabIndex = 58
        Me.BtnWISup.Text = "+"
        Me.BtnWISup.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(792, 524)
        Me.Controls.Add(Me.BtnWISup)
        Me.Controls.Add(Me.BtnVITup)
        Me.Controls.Add(Me.BtnAGIup)
        Me.Controls.Add(Me.BtnRESup)
        Me.Controls.Add(Me.BtnINTup)
        Me.Controls.Add(Me.BtnENDup)
        Me.Controls.Add(Me.BtnSTRup)
        Me.Controls.Add(Me.TestKillAmount)
        Me.Controls.Add(Me.LblMobDamage)
        Me.Controls.Add(Me.LblMobHealth)
        Me.Controls.Add(Me.BtnStartFight)
        Me.Controls.Add(Me.LblMobMod)
        Me.Controls.Add(Me.LblMobName)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.lblAutoLVL)
        Me.Controls.Add(Me.LblStatWIS)
        Me.Controls.Add(Me.LblStatVIT)
        Me.Controls.Add(Me.LblStatAGI)
        Me.Controls.Add(Me.LblStatRES)
        Me.Controls.Add(Me.LblStatINT)
        Me.Controls.Add(Me.LblStatEND)
        Me.Controls.Add(Me.LblStatPER)
        Me.Controls.Add(Me.LblStatSTR)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblAutoClickcost)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LblSkillPoints)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BtnPerUp)
        Me.Controls.Add(Me.AutoClickBuy)
        Me.Controls.Add(Me.lblLVLCost)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnLVLUp)
        Me.Controls.Add(Me.LblLVL)
        Me.Controls.Add(Me.LblEXP)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnMain)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "An Idle Clicker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnMain As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LblEXP As Label
    Friend WithEvents LblLVL As Label
    Friend WithEvents BtnLVLUp As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lblLVLCost As Label
    Friend WithEvents AutoClickBuy As Button
    Friend WithEvents BtnPerUp As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents LblSkillPoints As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents TimerAutoclick As Timer
    Friend WithEvents lblAutoClickcost As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents LblStatSTR As Label
    Friend WithEvents LblStatPER As Label
    Friend WithEvents LblStatEND As Label
    Friend WithEvents LblStatINT As Label
    Friend WithEvents LblStatRES As Label
    Friend WithEvents LblStatAGI As Label
    Friend WithEvents LblStatVIT As Label
    Friend WithEvents LblStatWIS As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents lblAutoLVL As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents TTAuto As ToolTip
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents LblMobName As Label
    Friend WithEvents LblMobMod As Label
    Friend WithEvents BtnStartFight As Button
    Friend WithEvents LblMobHealth As Label
    Friend WithEvents LblMobDamage As Label
    Friend WithEvents TestKillAmount As Label
    Friend WithEvents BtnSTRup As Button
    Friend WithEvents BtnENDup As Button
    Friend WithEvents BtnINTup As Button
    Friend WithEvents BtnRESup As Button
    Friend WithEvents BtnAGIup As Button
    Friend WithEvents BtnVITup As Button
    Friend WithEvents BtnWISup As Button
End Class
