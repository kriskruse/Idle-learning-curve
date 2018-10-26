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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnDarkVision = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LblSkillPoints = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LblDarkVisionCost = New System.Windows.Forms.Label()
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
        Me.LblMobMod = New System.Windows.Forms.Label()
        Me.LblMobName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnMain
        '
        Me.BtnMain.Location = New System.Drawing.Point(7, 8)
        Me.BtnMain.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
        Me.BtnLVLUp.Location = New System.Drawing.Point(352, 449)
        Me.BtnLVLUp.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnLVLUp.Location = New System.Drawing.Point(264, 365)
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
        Me.AutoClickBuy.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.AutoClickBuy.Name = "AutoClickBuy"
        Me.AutoClickBuy.Size = New System.Drawing.Size(144, 57)
        Me.AutoClickBuy.TabIndex = 8
        Me.AutoClickBuy.Text = "Auto Grinder"
        Me.AutoClickBuy.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(629, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(158, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "What skill do you want to grind?"
        '
        'BtnDarkVision
        '
        Me.BtnDarkVision.Location = New System.Drawing.Point(714, 42)
        Me.BtnDarkVision.Name = "BtnDarkVision"
        Me.BtnDarkVision.Size = New System.Drawing.Size(75, 23)
        Me.BtnDarkVision.TabIndex = 10
        Me.BtnDarkVision.Text = "Dark Vision"
        Me.BtnDarkVision.UseVisualStyleBackColor = True
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
        Me.Button1.Location = New System.Drawing.Point(652, 32)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(219, 306)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "*TEMP* Fighting area"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(352, 32)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(219, 306)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "*TEMP* Story area"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(711, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = " Vision cost"
        '
        'LblDarkVisionCost
        '
        Me.LblDarkVisionCost.AutoSize = True
        Me.LblDarkVisionCost.ForeColor = System.Drawing.Color.White
        Me.LblDarkVisionCost.Location = New System.Drawing.Point(774, 26)
        Me.LblDarkVisionCost.Name = "LblDarkVisionCost"
        Me.LblDarkVisionCost.Size = New System.Drawing.Size(13, 13)
        Me.LblDarkVisionCost.TabIndex = 17
        Me.LblDarkVisionCost.Text = "0"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(7, 461)
        Me.Button4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
        Me.lblAutoLVL.Location = New System.Drawing.Point(254, 361)
        Me.lblAutoLVL.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAutoLVL.Name = "lblAutoLVL"
        Me.lblAutoLVL.Size = New System.Drawing.Size(13, 13)
        Me.lblAutoLVL.TabIndex = 41
        Me.lblAutoLVL.Text = "0"
        '
        'LblMobMod
        '
        Me.LblMobMod.AutoSize = True
        Me.LblMobMod.ForeColor = System.Drawing.Color.White
        Me.LblMobMod.Location = New System.Drawing.Point(614, 336)
        Me.LblMobMod.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblMobMod.Name = "LblMobMod"
        Me.LblMobMod.Size = New System.Drawing.Size(45, 13)
        Me.LblMobMod.TabIndex = 42
        Me.LblMobMod.Text = "Label17"
        '
        'LblMobName
        '
        Me.LblMobName.AutoSize = True
        Me.LblMobName.ForeColor = System.Drawing.Color.White
        Me.LblMobName.Location = New System.Drawing.Point(663, 336)
        Me.LblMobName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblMobName.Name = "LblMobName"
        Me.LblMobName.Size = New System.Drawing.Size(45, 13)
        Me.LblMobName.TabIndex = 43
        Me.LblMobName.Text = "Label17"
        '
        'TTAuto
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(792, 524)
        Me.Controls.Add(Me.LblMobName)
        Me.Controls.Add(Me.LblMobMod)
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
        Me.Controls.Add(Me.LblDarkVisionCost)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LblSkillPoints)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BtnDarkVision)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.AutoClickBuy)
        Me.Controls.Add(Me.lblLVLCost)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnLVLUp)
        Me.Controls.Add(Me.LblLVL)
        Me.Controls.Add(Me.LblEXP)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnMain)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form1"
        Me.Text = "You find yourself in a dark cave"
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
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnDarkVision As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents LblSkillPoints As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents LblDarkVisionCost As Label
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
    Friend WithEvents LblMobMod As Label
    Friend WithEvents LblMobName As Label
End Class
