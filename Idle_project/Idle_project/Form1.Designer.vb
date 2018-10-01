<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnMain = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblEXP = New System.Windows.Forms.Label()
        Me.LblLVL = New System.Windows.Forms.Label()
        Me.BtnLVLUp = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblLVLCost = New System.Windows.Forms.Label()
        Me.AutoClickBuy = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnMain
        '
        Me.btnMain.Location = New System.Drawing.Point(12, 12)
        Me.btnMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnMain.Name = "btnMain"
        Me.btnMain.Size = New System.Drawing.Size(335, 426)
        Me.btnMain.TabIndex = 0
        Me.btnMain.Text = "CLICK"
        Me.btnMain.UseVisualStyleBackColor = True
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
        Me.Label2.Location = New System.Drawing.Point(353, 28)
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
        Me.LblEXP.Location = New System.Drawing.Point(405, 11)
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
        Me.LblLVL.Location = New System.Drawing.Point(405, 28)
        Me.LblLVL.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblLVL.Name = "LblLVL"
        Me.LblLVL.Size = New System.Drawing.Size(16, 17)
        Me.LblLVL.TabIndex = 4
        Me.LblLVL.Text = "1"
        '
        'BtnLVLUp
        '
        Me.BtnLVLUp.Location = New System.Drawing.Point(357, 176)
        Me.BtnLVLUp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnLVLUp.Name = "BtnLVLUp"
        Me.BtnLVLUp.Size = New System.Drawing.Size(100, 28)
        Me.BtnLVLUp.TabIndex = 5
        Me.BtnLVLUp.Text = "Level up"
        Me.BtnLVLUp.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(353, 208)
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
        Me.lblLVLCost.Location = New System.Drawing.Point(353, 224)
        Me.lblLVLCost.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLVLCost.Name = "lblLVLCost"
        Me.lblLVLCost.Size = New System.Drawing.Size(16, 17)
        Me.lblLVLCost.TabIndex = 7
        Me.lblLVLCost.Text = "0"
        '
        'AutoClickBuy
        '
        Me.AutoClickBuy.Location = New System.Drawing.Point(356, 288)
        Me.AutoClickBuy.Name = "AutoClickBuy"
        Me.AutoClickBuy.Size = New System.Drawing.Size(108, 28)
        Me.AutoClickBuy.TabIndex = 8
        Me.AutoClickBuy.Text = "Auto Click"
        Me.AutoClickBuy.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.AutoClickBuy)
        Me.Controls.Add(Me.lblLVLCost)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnLVLUp)
        Me.Controls.Add(Me.LblLVL)
        Me.Controls.Add(Me.LblEXP)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnMain)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnMain As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LblEXP As Label
    Friend WithEvents LblLVL As Label
    Friend WithEvents BtnLVLUp As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lblLVLCost As Label
    Friend WithEvents AutoClickBuy As Button
End Class
