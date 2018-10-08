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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LblDarkVisionCost = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TimerAutoclick = New System.Windows.Forms.Timer(Me.components)
        Me.lblAutoClickcost = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnMain
        '
        Me.BtnMain.Location = New System.Drawing.Point(12, 12)
        Me.BtnMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnMain.Name = "BtnMain"
        Me.BtnMain.Size = New System.Drawing.Size(335, 553)
        Me.BtnMain.TabIndex = 0
        Me.BtnMain.Text = "CLICK ME TO GRIND FOR EXP"
        Me.BtnMain.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(353, 12)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "EXP"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(452, 412)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "LVL"
        '
        'LblEXP
        '
        Me.LblEXP.AutoSize = True
        Me.LblEXP.ForeColor = System.Drawing.Color.White
        Me.LblEXP.Location = New System.Drawing.Point(399, 12)
        Me.LblEXP.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblEXP.Name = "LblEXP"
        Me.LblEXP.Size = New System.Drawing.Size(16, 17)
        Me.LblEXP.TabIndex = 3
        Me.LblEXP.Text = "0"
        '
        'LblLVL
        '
        Me.LblLVL.AutoSize = True
        Me.LblLVL.ForeColor = System.Drawing.Color.White
        Me.LblLVL.Location = New System.Drawing.Point(452, 430)
        Me.LblLVL.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblLVL.Name = "LblLVL"
        Me.LblLVL.Size = New System.Drawing.Size(16, 17)
        Me.LblLVL.TabIndex = 4
        Me.LblLVL.Text = "1"
        '
        'BtnLVLUp
        '
        Me.BtnLVLUp.Location = New System.Drawing.Point(352, 449)
        Me.BtnLVLUp.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnLVLUp.Name = "BtnLVLUp"
        Me.BtnLVLUp.Size = New System.Drawing.Size(191, 70)
        Me.BtnLVLUp.TabIndex = 5
        Me.BtnLVLUp.Text = "Level up"
        Me.BtnLVLUp.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(353, 414)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Cost"
        '
        'lblLVLCost
        '
        Me.lblLVLCost.AutoSize = True
        Me.lblLVLCost.ForeColor = System.Drawing.Color.White
        Me.lblLVLCost.Location = New System.Drawing.Point(353, 430)
        Me.lblLVLCost.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLVLCost.Name = "lblLVLCost"
        Me.lblLVLCost.Size = New System.Drawing.Size(16, 17)
        Me.lblLVLCost.TabIndex = 7
        Me.lblLVLCost.Text = "0"
        '
        'AutoClickBuy
        '
        Me.AutoClickBuy.Location = New System.Drawing.Point(352, 570)
        Me.AutoClickBuy.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.AutoClickBuy.Name = "AutoClickBuy"
        Me.AutoClickBuy.Size = New System.Drawing.Size(192, 70)
        Me.AutoClickBuy.TabIndex = 8
        Me.AutoClickBuy.Text = "Auto Grinder"
        Me.AutoClickBuy.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(839, 12)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(208, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "What skill do you want to grind?"
        '
        'BtnDarkVision
        '
        Me.BtnDarkVision.Location = New System.Drawing.Point(952, 52)
        Me.BtnDarkVision.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnDarkVision.Name = "BtnDarkVision"
        Me.BtnDarkVision.Size = New System.Drawing.Size(100, 28)
        Me.BtnDarkVision.TabIndex = 10
        Me.BtnDarkVision.Text = "Dark Vision"
        Me.BtnDarkVision.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(648, 12)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 17)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Skill Points"
        '
        'LblSkillPoints
        '
        Me.LblSkillPoints.AutoSize = True
        Me.LblSkillPoints.ForeColor = System.Drawing.Color.White
        Me.LblSkillPoints.Location = New System.Drawing.Point(727, 12)
        Me.LblSkillPoints.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblSkillPoints.Name = "LblSkillPoints"
        Me.LblSkillPoints.Size = New System.Drawing.Size(16, 17)
        Me.LblSkillPoints.TabIndex = 12
        Me.LblSkillPoints.Text = "0"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(652, 32)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(292, 377)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "*TEMP* Fighting area"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(551, 414)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(393, 226)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "*TEMP* STAT OVERLAY"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(352, 32)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(292, 377)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "*TEMP* Story area"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(948, 32)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 17)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = " Vision cost"
        '
        'LblDarkVisionCost
        '
        Me.LblDarkVisionCost.AutoSize = True
        Me.LblDarkVisionCost.ForeColor = System.Drawing.Color.White
        Me.LblDarkVisionCost.Location = New System.Drawing.Point(1032, 32)
        Me.LblDarkVisionCost.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblDarkVisionCost.Name = "LblDarkVisionCost"
        Me.LblDarkVisionCost.Size = New System.Drawing.Size(16, 17)
        Me.LblDarkVisionCost.TabIndex = 17
        Me.LblDarkVisionCost.Text = "0"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(12, 570)
        Me.Button4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(335, 70)
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
        Me.lblAutoClickcost.Location = New System.Drawing.Point(353, 548)
        Me.lblAutoClickcost.Name = "lblAutoClickcost"
        Me.lblAutoClickcost.Size = New System.Drawing.Size(51, 17)
        Me.lblAutoClickcost.TabIndex = 19
        Me.lblAutoClickcost.Text = "Label7"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1065, 654)
        Me.Controls.Add(Me.lblAutoClickcost)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.LblDarkVisionCost)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
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
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
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
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents LblDarkVisionCost As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents TimerAutoclick As Timer
    Friend WithEvents lblAutoClickcost As Label
End Class
