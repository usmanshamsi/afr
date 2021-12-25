<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_disclaimer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_disclaimer))
        Me.bttnOK = New System.Windows.Forms.Button()
        Me.lbl_program_title = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'bttnOK
        '
        Me.bttnOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.bttnOK.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bttnOK.Location = New System.Drawing.Point(299, 516)
        Me.bttnOK.Margin = New System.Windows.Forms.Padding(2)
        Me.bttnOK.Name = "bttnOK"
        Me.bttnOK.Size = New System.Drawing.Size(151, 30)
        Me.bttnOK.TabIndex = 12
        Me.bttnOK.Text = "OK"
        Me.bttnOK.UseVisualStyleBackColor = True
        '
        'lbl_program_title
        '
        Me.lbl_program_title.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_program_title.Font = New System.Drawing.Font("Century Gothic", 15.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_program_title.ForeColor = System.Drawing.Color.Blue
        Me.lbl_program_title.Location = New System.Drawing.Point(24, 18)
        Me.lbl_program_title.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_program_title.Name = "lbl_program_title"
        Me.lbl_program_title.Size = New System.Drawing.Size(704, 31)
        Me.lbl_program_title.TabIndex = 14
        Me.lbl_program_title.Text = "DISCLAIMER"
        Me.lbl_program_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(24, 66)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(704, 426)
        Me.TextBox1.TabIndex = 15
        Me.TextBox1.Text = resources.GetString("TextBox1.Text")
        '
        'frm_disclaimer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(755, 569)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lbl_program_title)
        Me.Controls.Add(Me.bttnOK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_disclaimer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Disclaimer..."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents bttnOK As System.Windows.Forms.Button
    Private WithEvents lbl_program_title As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
