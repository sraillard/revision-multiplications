<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EcranPrincipal
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
        Me.components = New System.ComponentModel.Container()
        Me.lQuestion = New System.Windows.Forms.Label()
        Me.tbReponse = New System.Windows.Forms.TextBox()
        Me.lInfos = New System.Windows.Forms.Label()
        Me.tTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lQuestion
        '
        Me.lQuestion.Font = New System.Drawing.Font("Consolas", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lQuestion.Location = New System.Drawing.Point(24, 23)
        Me.lQuestion.Name = "lQuestion"
        Me.lQuestion.Size = New System.Drawing.Size(258, 61)
        Me.lQuestion.TabIndex = 0
        Me.lQuestion.Text = "99 x 99 ="
        Me.lQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbReponse
        '
        Me.tbReponse.Font = New System.Drawing.Font("Consolas", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbReponse.Location = New System.Drawing.Point(288, 20)
        Me.tbReponse.Name = "tbReponse"
        Me.tbReponse.Size = New System.Drawing.Size(100, 64)
        Me.tbReponse.TabIndex = 1
        Me.tbReponse.Text = "999"
        Me.tbReponse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lInfos
        '
        Me.lInfos.Location = New System.Drawing.Point(12, 103)
        Me.lInfos.Name = "lInfos"
        Me.lInfos.Size = New System.Drawing.Size(412, 22)
        Me.lInfos.TabIndex = 2
        Me.lInfos.Text = "Infos"
        Me.lInfos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tTimer
        '
        Me.tTimer.Enabled = True
        '
        'EcranPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(436, 134)
        Me.Controls.Add(Me.lInfos)
        Me.Controls.Add(Me.tbReponse)
        Me.Controls.Add(Me.lQuestion)
        Me.Name = "EcranPrincipal"
        Me.Text = "Test Multiplication"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lQuestion As Windows.Forms.Label
    Friend WithEvents tbReponse As Windows.Forms.TextBox
    Friend WithEvents lInfos As Windows.Forms.Label
    Friend WithEvents tTimer As Windows.Forms.Timer
End Class
