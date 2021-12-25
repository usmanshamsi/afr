<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbout
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
        Me.bttnOK = New System.Windows.Forms.Button()
        Me.lbl_program_description = New System.Windows.Forms.Label()
        Me.lbl_program_title = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'bttnOK
        '
        Me.bttnOK.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttnOK.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bttnOK.Location = New System.Drawing.Point(249, 224)
        Me.bttnOK.Margin = New System.Windows.Forms.Padding(2)
        Me.bttnOK.Name = "bttnOK"
        Me.bttnOK.Size = New System.Drawing.Size(134, 30)
        Me.bttnOK.TabIndex = 18
        Me.bttnOK.Text = "OK"
        Me.bttnOK.UseVisualStyleBackColor = True
        '
        'lbl_program_description
        '
        Me.lbl_program_description.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_program_description.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_program_description.ForeColor = System.Drawing.Color.Green
        Me.lbl_program_description.Location = New System.Drawing.Point(13, 40)
        Me.lbl_program_description.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_program_description.Name = "lbl_program_description"
        Me.lbl_program_description.Size = New System.Drawing.Size(612, 102)
        Me.lbl_program_description.TabIndex = 21
        Me.lbl_program_description.Text = "<Program_Description>"
        Me.lbl_program_description.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_program_title
        '
        Me.lbl_program_title.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_program_title.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_program_title.ForeColor = System.Drawing.Color.Blue
        Me.lbl_program_title.Location = New System.Drawing.Point(12, 9)
        Me.lbl_program_title.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_program_title.Name = "lbl_program_title"
        Me.lbl_program_title.Size = New System.Drawing.Size(612, 31)
        Me.lbl_program_title.TabIndex = 19
        Me.lbl_program_title.Text = "<Program Title>"
        Me.lbl_program_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(639, 268)
        Me.Controls.Add(Me.lbl_program_description)
        Me.Controls.Add(Me.lbl_program_title)
        Me.Controls.Add(Me.bttnOK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAbout"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About..."
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents bttnOK As System.Windows.Forms.Button
    Private WithEvents lbl_program_description As System.Windows.Forms.Label
    Private WithEvents lbl_program_title As System.Windows.Forms.Label
End Class
