<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
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
        Me.components = New System.ComponentModel.Container
        Me.PanelBrowser = New System.Windows.Forms.Panel
        Me.ButtonHTML = New System.Windows.Forms.Button
        Me.TimerLoad = New System.Windows.Forms.Timer(Me.components)
        Me.ButtonURL = New System.Windows.Forms.Button
        Me.TextBoxURL = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'PanelBrowser
        '
        Me.PanelBrowser.Location = New System.Drawing.Point(0, 40)
        Me.PanelBrowser.Name = "PanelBrowser"
        Me.PanelBrowser.Size = New System.Drawing.Size(419, 327)
        Me.PanelBrowser.TabIndex = 0
        '
        'ButtonHTML
        '
        Me.ButtonHTML.Location = New System.Drawing.Point(5, 5)
        Me.ButtonHTML.Name = "ButtonHTML"
        Me.ButtonHTML.Size = New System.Drawing.Size(86, 29)
        Me.ButtonHTML.TabIndex = 1
        Me.ButtonHTML.Text = "Load HTML"
        Me.ButtonHTML.UseVisualStyleBackColor = True
        '
        'TimerLoad
        '
        Me.TimerLoad.Enabled = True
        '
        'ButtonURL
        '
        Me.ButtonURL.Location = New System.Drawing.Point(97, 5)
        Me.ButtonURL.Name = "ButtonURL"
        Me.ButtonURL.Size = New System.Drawing.Size(86, 29)
        Me.ButtonURL.TabIndex = 2
        Me.ButtonURL.Text = "Load URL"
        Me.ButtonURL.UseVisualStyleBackColor = True
        '
        'TextBoxURL
        '
        Me.TextBoxURL.Location = New System.Drawing.Point(189, 10)
        Me.TextBoxURL.Name = "TextBoxURL"
        Me.TextBoxURL.Size = New System.Drawing.Size(230, 20)
        Me.TextBoxURL.TabIndex = 3
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(725, 399)
        Me.Controls.Add(Me.TextBoxURL)
        Me.Controls.Add(Me.ButtonURL)
        Me.Controls.Add(Me.ButtonHTML)
        Me.Controls.Add(Me.PanelBrowser)
        Me.Name = "FormMain"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PanelBrowser As System.Windows.Forms.Panel
    Friend WithEvents ButtonHTML As System.Windows.Forms.Button
    Friend WithEvents TimerLoad As System.Windows.Forms.Timer
    Friend WithEvents ButtonURL As System.Windows.Forms.Button
    Friend WithEvents TextBoxURL As System.Windows.Forms.TextBox

End Class
