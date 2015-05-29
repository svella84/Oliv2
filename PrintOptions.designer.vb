<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrintOptions
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PrintOptions))
        Me.chkFitToPageWidth = New System.Windows.Forms.CheckBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.gboxRowsToPrint = New System.Windows.Forms.GroupBox()
        Me.rdoSelectedRows = New System.Windows.Forms.RadioButton()
        Me.rdoAllRows = New System.Windows.Forms.RadioButton()
        Me.lblColumnsToPrint = New System.Windows.Forms.Label()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.chklst = New System.Windows.Forms.CheckedListBox()
        Me.chkPageLandscape = New System.Windows.Forms.CheckBox()
        Me.gboxRowsToPrint.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkFitToPageWidth
        '
        Me.chkFitToPageWidth.AutoSize = True
        Me.chkFitToPageWidth.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkFitToPageWidth.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.chkFitToPageWidth.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkFitToPageWidth.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFitToPageWidth.Location = New System.Drawing.Point(249, 75)
        Me.chkFitToPageWidth.Name = "chkFitToPageWidth"
        Me.chkFitToPageWidth.Size = New System.Drawing.Size(117, 18)
        Me.chkFitToPageWidth.TabIndex = 21
        Me.chkFitToPageWidth.Text = "Adatta alla pagina"
        Me.chkFitToPageWidth.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(188, 127)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(104, 13)
        Me.lblTitle.TabIndex = 20
        Me.lblTitle.Text = "Titolo per la Stampa "
        '
        'txtTitle
        '
        Me.txtTitle.AcceptsReturn = True
        Me.txtTitle.Location = New System.Drawing.Point(188, 145)
        Me.txtTitle.Multiline = True
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtTitle.Size = New System.Drawing.Size(178, 86)
        Me.txtTitle.TabIndex = 19
        '
        'gboxRowsToPrint
        '
        Me.gboxRowsToPrint.Controls.Add(Me.rdoSelectedRows)
        Me.gboxRowsToPrint.Controls.Add(Me.rdoAllRows)
        Me.gboxRowsToPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboxRowsToPrint.Location = New System.Drawing.Point(188, 22)
        Me.gboxRowsToPrint.Name = "gboxRowsToPrint"
        Me.gboxRowsToPrint.Size = New System.Drawing.Size(178, 42)
        Me.gboxRowsToPrint.TabIndex = 18
        Me.gboxRowsToPrint.TabStop = False
        Me.gboxRowsToPrint.Text = "Righe da Stampare"
        '
        'rdoSelectedRows
        '
        Me.rdoSelectedRows.AutoSize = True
        Me.rdoSelectedRows.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoSelectedRows.Location = New System.Drawing.Point(92, 19)
        Me.rdoSelectedRows.Name = "rdoSelectedRows"
        Me.rdoSelectedRows.Size = New System.Drawing.Size(80, 17)
        Me.rdoSelectedRows.TabIndex = 1
        Me.rdoSelectedRows.TabStop = True
        Me.rdoSelectedRows.Text = "Selezionate"
        Me.rdoSelectedRows.UseVisualStyleBackColor = True
        '
        'rdoAllRows
        '
        Me.rdoAllRows.AutoSize = True
        Me.rdoAllRows.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoAllRows.Location = New System.Drawing.Point(15, 19)
        Me.rdoAllRows.Name = "rdoAllRows"
        Me.rdoAllRows.Size = New System.Drawing.Size(50, 17)
        Me.rdoAllRows.TabIndex = 0
        Me.rdoAllRows.TabStop = True
        Me.rdoAllRows.Text = "Tutte"
        Me.rdoAllRows.UseVisualStyleBackColor = True
        '
        'lblColumnsToPrint
        '
        Me.lblColumnsToPrint.AutoSize = True
        Me.lblColumnsToPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColumnsToPrint.Location = New System.Drawing.Point(12, 9)
        Me.lblColumnsToPrint.Name = "lblColumnsToPrint"
        Me.lblColumnsToPrint.Size = New System.Drawing.Size(109, 13)
        Me.lblColumnsToPrint.TabIndex = 17
        Me.lblColumnsToPrint.Text = "Colonne da Stampare"
        '
        'btnOK
        '
        Me.btnOK.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnOK.BackColor = System.Drawing.SystemColors.Control
        Me.btnOK.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnOK.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnOK.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnOK.Image = CType(resources.GetObject("btnOK.Image"), System.Drawing.Image)
        Me.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnOK.Location = New System.Drawing.Point(188, 247)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnOK.Size = New System.Drawing.Size(91, 25)
        Me.btnOK.TabIndex = 14
        Me.btnOK.Text = "&OK"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCancel.BackColor = System.Drawing.SystemColors.Control
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnCancel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(285, 247)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnCancel.Size = New System.Drawing.Size(81, 25)
        Me.btnCancel.TabIndex = 15
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'chklst
        '
        Me.chklst.CheckOnClick = True
        Me.chklst.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chklst.FormattingEnabled = True
        Me.chklst.Location = New System.Drawing.Point(12, 28)
        Me.chklst.Name = "chklst"
        Me.chklst.Size = New System.Drawing.Size(170, 244)
        Me.chklst.TabIndex = 13
        '
        'chkPageLandscape
        '
        Me.chkPageLandscape.AutoSize = True
        Me.chkPageLandscape.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkPageLandscape.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkPageLandscape.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPageLandscape.Location = New System.Drawing.Point(232, 99)
        Me.chkPageLandscape.Name = "chkPageLandscape"
        Me.chkPageLandscape.Size = New System.Drawing.Size(134, 18)
        Me.chkPageLandscape.TabIndex = 22
        Me.chkPageLandscape.Text = "Stampa in Orizzontale"
        Me.chkPageLandscape.UseVisualStyleBackColor = True
        '
        'PrintOptions
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(378, 305)
        Me.ControlBox = False
        Me.Controls.Add(Me.chkPageLandscape)
        Me.Controls.Add(Me.chkFitToPageWidth)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.gboxRowsToPrint)
        Me.Controls.Add(Me.lblColumnsToPrint)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.chklst)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(394, 321)
        Me.Name = "PrintOptions"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Print Options"
        Me.gboxRowsToPrint.ResumeLayout(False)
        Me.gboxRowsToPrint.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkFitToPageWidth As System.Windows.Forms.CheckBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents gboxRowsToPrint As System.Windows.Forms.GroupBox
    Friend WithEvents rdoSelectedRows As System.Windows.Forms.RadioButton
    Friend WithEvents rdoAllRows As System.Windows.Forms.RadioButton
    Friend WithEvents lblColumnsToPrint As System.Windows.Forms.Label
    Protected WithEvents btnOK As System.Windows.Forms.Button
    Protected WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents chklst As System.Windows.Forms.CheckedListBox
    Friend WithEvents chkPageLandscape As System.Windows.Forms.CheckBox
End Class
