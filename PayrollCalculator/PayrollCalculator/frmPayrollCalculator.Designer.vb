<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayrollCalculator
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstEmployees = New System.Windows.Forms.ListView()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.btnStats = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.ofdOpen = New System.Windows.Forms.OpenFileDialog()
        Me.sfdSave = New System.Windows.Forms.SaveFileDialog()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(316, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(197, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "West End Tax Service"
        '
        'lstEmployees
        '
        Me.lstEmployees.HideSelection = False
        Me.lstEmployees.Location = New System.Drawing.Point(30, 81)
        Me.lstEmployees.Name = "lstEmployees"
        Me.lstEmployees.Size = New System.Drawing.Size(862, 337)
        Me.lstEmployees.TabIndex = 1
        Me.lstEmployees.UseCompatibleStateImageBehavior = False
        Me.lstEmployees.View = System.Windows.Forms.View.Details
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(211, 442)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(110, 23)
        Me.btnLoad.TabIndex = 2
        Me.btnLoad.Text = "Load Data"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'btnStats
        '
        Me.btnStats.Location = New System.Drawing.Point(353, 442)
        Me.btnStats.Name = "btnStats"
        Me.btnStats.Size = New System.Drawing.Size(110, 23)
        Me.btnStats.TabIndex = 3
        Me.btnStats.Text = "View Statistcs"
        Me.btnStats.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(495, 442)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(110, 23)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "Save Data"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(637, 442)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(110, 23)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(782, 442)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(110, 23)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'ofdOpen
        '
        Me.ofdOpen.FileName = "OpenFileDialog1"
        '
        'frmPayrollCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(922, 496)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnStats)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.lstEmployees)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmPayrollCalculator"
        Me.Text = "West End Tax Service"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lstEmployees As ListView
    Friend WithEvents btnLoad As Button
    Friend WithEvents btnStats As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents ofdOpen As OpenFileDialog
    Friend WithEvents sfdSave As SaveFileDialog
End Class
