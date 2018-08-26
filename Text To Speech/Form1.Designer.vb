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
        Me.rtxtData = New System.Windows.Forms.RichTextBox()
        Me.btnSpeak = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'rtxtData
        '
        Me.rtxtData.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtxtData.Location = New System.Drawing.Point(1, 3)
        Me.rtxtData.Name = "rtxtData"
        Me.rtxtData.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.rtxtData.Size = New System.Drawing.Size(828, 609)
        Me.rtxtData.TabIndex = 0
        Me.rtxtData.Text = ""
        '
        'btnSpeak
        '
        Me.btnSpeak.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSpeak.Location = New System.Drawing.Point(288, 609)
        Me.btnSpeak.Name = "btnSpeak"
        Me.btnSpeak.Size = New System.Drawing.Size(263, 52)
        Me.btnSpeak.TabIndex = 1
        Me.btnSpeak.Text = "Start"
        Me.btnSpeak.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(831, 661)
        Me.Controls.Add(Me.btnSpeak)
        Me.Controls.Add(Me.rtxtData)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(847, 699)
        Me.MinimumSize = New System.Drawing.Size(847, 699)
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Text = "Text To Speech"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rtxtData As System.Windows.Forms.RichTextBox
    Friend WithEvents btnSpeak As System.Windows.Forms.Button

End Class
