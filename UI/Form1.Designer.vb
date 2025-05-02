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
        Me.menuStripMain = New System.Windows.Forms.MenuStrip()
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuStripMain
        '
        Me.menuStripMain.Location = New System.Drawing.Point(0, 0)
        Me.menuStripMain.Name = "menuStripMain"
        Me.menuStripMain.Size = New System.Drawing.Size(800, 24)
        Me.menuStripMain.TabIndex = 0
        Me.menuStripMain.Text = "MenuStripMain"
        '
        'BtnLogin
        '
        Me.BtnLogin.Location = New System.Drawing.Point(713, 3)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(75, 23)
        Me.BtnLogin.TabIndex = 1
        Me.BtnLogin.Text = "Button1"
        Me.BtnLogin.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BtnLogin)
        Me.Panel1.Location = New System.Drawing.Point(0, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 31)
        Me.Panel1.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.menuStripMain)
        Me.MainMenuStrip = Me.menuStripMain
        Me.Name = "Form1"
        Me.Text = "პროსპერო Scheduler_v8.4a"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents menuStripMain As MenuStrip
    Friend WithEvents BtnLogin As Button
    Friend WithEvents Panel1 As Panel
End Class
