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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_arsenal = New System.Windows.Forms.Button()
        Me.btn_chelsea = New System.Windows.Forms.Button()
        Me.btn_liverpool = New System.Windows.Forms.Button()
        Me.btn_mancity = New System.Windows.Forms.Button()
        Me.btn_man_utd = New System.Windows.Forms.Button()
        Me.lnk_arsenal_next_match = New System.Windows.Forms.LinkLabel()
        Me.btn_chelsea_next_match = New System.Windows.Forms.LinkLabel()
        Me.lnk_liverpool_next_match = New System.Windows.Forms.LinkLabel()
        Me.lnk_mancity_next_match = New System.Windows.Forms.LinkLabel()
        Me.lnk_manutd_next_match = New System.Windows.Forms.LinkLabel()
        Me.btn_tottenham = New System.Windows.Forms.Button()
        Me.lnk_tottenham_next_match = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(27, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(625, 48)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PREMIER LEAGUE TOP TEAMS"
        '
        'btn_arsenal
        '
        Me.btn_arsenal.BackColor = System.Drawing.Color.MistyRose
        Me.btn_arsenal.BackgroundImage = CType(resources.GetObject("btn_arsenal.BackgroundImage"), System.Drawing.Image)
        Me.btn_arsenal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_arsenal.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.btn_arsenal.Location = New System.Drawing.Point(64, 87)
        Me.btn_arsenal.Name = "btn_arsenal"
        Me.btn_arsenal.Size = New System.Drawing.Size(215, 254)
        Me.btn_arsenal.TabIndex = 1
        Me.btn_arsenal.UseVisualStyleBackColor = False
        '
        'btn_chelsea
        '
        Me.btn_chelsea.BackColor = System.Drawing.SystemColors.Highlight
        Me.btn_chelsea.BackgroundImage = CType(resources.GetObject("btn_chelsea.BackgroundImage"), System.Drawing.Image)
        Me.btn_chelsea.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.btn_chelsea.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_chelsea.Location = New System.Drawing.Point(345, 87)
        Me.btn_chelsea.Name = "btn_chelsea"
        Me.btn_chelsea.Size = New System.Drawing.Size(224, 243)
        Me.btn_chelsea.TabIndex = 2
        Me.btn_chelsea.UseVisualStyleBackColor = False
        '
        'btn_liverpool
        '
        Me.btn_liverpool.BackColor = System.Drawing.Color.OrangeRed
        Me.btn_liverpool.BackgroundImage = CType(resources.GetObject("btn_liverpool.BackgroundImage"), System.Drawing.Image)
        Me.btn_liverpool.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.btn_liverpool.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_liverpool.Location = New System.Drawing.Point(629, 83)
        Me.btn_liverpool.Name = "btn_liverpool"
        Me.btn_liverpool.Size = New System.Drawing.Size(224, 258)
        Me.btn_liverpool.TabIndex = 3
        Me.btn_liverpool.UseVisualStyleBackColor = False
        '
        'btn_mancity
        '
        Me.btn_mancity.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_mancity.BackgroundImage = CType(resources.GetObject("btn_mancity.BackgroundImage"), System.Drawing.Image)
        Me.btn_mancity.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.btn_mancity.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_mancity.Location = New System.Drawing.Point(64, 409)
        Me.btn_mancity.Name = "btn_mancity"
        Me.btn_mancity.Size = New System.Drawing.Size(224, 248)
        Me.btn_mancity.TabIndex = 4
        Me.btn_mancity.UseVisualStyleBackColor = False
        '
        'btn_man_utd
        '
        Me.btn_man_utd.BackColor = System.Drawing.Color.Red
        Me.btn_man_utd.BackgroundImage = CType(resources.GetObject("btn_man_utd.BackgroundImage"), System.Drawing.Image)
        Me.btn_man_utd.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.btn_man_utd.Location = New System.Drawing.Point(640, 409)
        Me.btn_man_utd.Name = "btn_man_utd"
        Me.btn_man_utd.Size = New System.Drawing.Size(224, 248)
        Me.btn_man_utd.TabIndex = 5
        Me.btn_man_utd.UseVisualStyleBackColor = False
        '
        'lnk_arsenal_next_match
        '
        Me.lnk_arsenal_next_match.AutoSize = True
        Me.lnk_arsenal_next_match.LinkColor = System.Drawing.Color.Blue
        Me.lnk_arsenal_next_match.Location = New System.Drawing.Point(64, 309)
        Me.lnk_arsenal_next_match.Name = "lnk_arsenal_next_match"
        Me.lnk_arsenal_next_match.Size = New System.Drawing.Size(224, 32)
        Me.lnk_arsenal_next_match.TabIndex = 6
        Me.lnk_arsenal_next_match.TabStop = True
        Me.lnk_arsenal_next_match.Text = "get next match info"
        '
        'btn_chelsea_next_match
        '
        Me.btn_chelsea_next_match.AutoSize = True
        Me.btn_chelsea_next_match.LinkColor = System.Drawing.Color.Blue
        Me.btn_chelsea_next_match.Location = New System.Drawing.Point(345, 298)
        Me.btn_chelsea_next_match.Name = "btn_chelsea_next_match"
        Me.btn_chelsea_next_match.Size = New System.Drawing.Size(224, 32)
        Me.btn_chelsea_next_match.TabIndex = 7
        Me.btn_chelsea_next_match.TabStop = True
        Me.btn_chelsea_next_match.Text = "get next match info"
        '
        'lnk_liverpool_next_match
        '
        Me.lnk_liverpool_next_match.AutoSize = True
        Me.lnk_liverpool_next_match.LinkColor = System.Drawing.Color.Blue
        Me.lnk_liverpool_next_match.Location = New System.Drawing.Point(629, 309)
        Me.lnk_liverpool_next_match.Name = "lnk_liverpool_next_match"
        Me.lnk_liverpool_next_match.Size = New System.Drawing.Size(224, 32)
        Me.lnk_liverpool_next_match.TabIndex = 8
        Me.lnk_liverpool_next_match.TabStop = True
        Me.lnk_liverpool_next_match.Text = "get next match info"
        '
        'lnk_mancity_next_match
        '
        Me.lnk_mancity_next_match.AutoSize = True
        Me.lnk_mancity_next_match.Location = New System.Drawing.Point(64, 625)
        Me.lnk_mancity_next_match.Name = "lnk_mancity_next_match"
        Me.lnk_mancity_next_match.Size = New System.Drawing.Size(224, 32)
        Me.lnk_mancity_next_match.TabIndex = 9
        Me.lnk_mancity_next_match.TabStop = True
        Me.lnk_mancity_next_match.Text = "get next match info"
        '
        'lnk_manutd_next_match
        '
        Me.lnk_manutd_next_match.AutoSize = True
        Me.lnk_manutd_next_match.Location = New System.Drawing.Point(640, 625)
        Me.lnk_manutd_next_match.Name = "lnk_manutd_next_match"
        Me.lnk_manutd_next_match.Size = New System.Drawing.Size(224, 32)
        Me.lnk_manutd_next_match.TabIndex = 10
        Me.lnk_manutd_next_match.TabStop = True
        Me.lnk_manutd_next_match.Text = "get next match info"
        '
        'btn_tottenham
        '
        Me.btn_tottenham.BackgroundImage = CType(resources.GetObject("btn_tottenham.BackgroundImage"), System.Drawing.Image)
        Me.btn_tottenham.Location = New System.Drawing.Point(345, 409)
        Me.btn_tottenham.Name = "btn_tottenham"
        Me.btn_tottenham.Size = New System.Drawing.Size(224, 248)
        Me.btn_tottenham.TabIndex = 11
        Me.btn_tottenham.UseVisualStyleBackColor = True
        '
        'lnk_tottenham_next_match
        '
        Me.lnk_tottenham_next_match.AutoSize = True
        Me.lnk_tottenham_next_match.Location = New System.Drawing.Point(345, 625)
        Me.lnk_tottenham_next_match.Name = "lnk_tottenham_next_match"
        Me.lnk_tottenham_next_match.Size = New System.Drawing.Size(224, 32)
        Me.lnk_tottenham_next_match.TabIndex = 12
        Me.lnk_tottenham_next_match.TabStop = True
        Me.lnk_tottenham_next_match.Text = "get next match info"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1061, 684)
        Me.Controls.Add(Me.lnk_tottenham_next_match)
        Me.Controls.Add(Me.btn_tottenham)
        Me.Controls.Add(Me.lnk_manutd_next_match)
        Me.Controls.Add(Me.lnk_mancity_next_match)
        Me.Controls.Add(Me.lnk_liverpool_next_match)
        Me.Controls.Add(Me.btn_chelsea_next_match)
        Me.Controls.Add(Me.lnk_arsenal_next_match)
        Me.Controls.Add(Me.btn_man_utd)
        Me.Controls.Add(Me.btn_mancity)
        Me.Controls.Add(Me.btn_liverpool)
        Me.Controls.Add(Me.btn_chelsea)
        Me.Controls.Add(Me.btn_arsenal)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "PFL Dream Team"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btn_arsenal As Button
    Friend WithEvents btn_chelsea As Button
    Friend WithEvents btn_liverpool As Button
    Friend WithEvents btn_mancity As Button
    Friend WithEvents btn_man_utd As Button
    Friend WithEvents lnk_arsenal_next_match As LinkLabel
    Friend WithEvents btn_chelsea_next_match As LinkLabel
    Friend WithEvents lnk_liverpool_next_match As LinkLabel
    Friend WithEvents lnk_mancity_next_match As LinkLabel
    Friend WithEvents lnk_manutd_next_match As LinkLabel
    Friend WithEvents btn_tottenham As Button
    Friend WithEvents lnk_tottenham_next_match As LinkLabel
End Class
