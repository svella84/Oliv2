<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Oliv
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Oliv))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Fornitori = New System.Windows.Forms.TabPage()
        Me.btnRefreshFornitore = New System.Windows.Forms.Button()
        Me.btnSearchFornitori = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSearchFornitori = New System.Windows.Forms.TextBox()
        Me.btnPrintFornitori = New System.Windows.Forms.Button()
        Me.btnReturnFornitore = New System.Windows.Forms.Button()
        Me.btnDeleteFornitore = New System.Windows.Forms.Button()
        Me.btnModFornitore = New System.Windows.Forms.Button()
        Me.btnInsertFornitore = New System.Windows.Forms.Button()
        Me.DataGridFornitori = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.txtCap = New System.Windows.Forms.TextBox()
        Me.txtProvincia = New System.Windows.Forms.TextBox()
        Me.txtIndirizzo = New System.Windows.Forms.TextBox()
        Me.txtCitta = New System.Windows.Forms.TextBox()
        Me.txtIntestazione = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Silos = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.lbSilosC = New System.Windows.Forms.Label()
        Me.lbSilosV = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Carico = New System.Windows.Forms.TabPage()
        Me.Conf = New System.Windows.Forms.TabPage()
        Me.Trasf = New System.Windows.Forms.TabPage()
        Me.Inter = New System.Windows.Forms.TabPage()
        Me.btn_about = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.Fornitori.SuspendLayout()
        CType(Me.DataGridFornitori, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Silos.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.Fornitori)
        Me.TabControl1.Controls.Add(Me.Silos)
        Me.TabControl1.Controls.Add(Me.Carico)
        Me.TabControl1.Controls.Add(Me.Conf)
        Me.TabControl1.Controls.Add(Me.Trasf)
        Me.TabControl1.Controls.Add(Me.Inter)
        Me.TabControl1.ItemSize = New System.Drawing.Size(135, 40)
        Me.TabControl1.Location = New System.Drawing.Point(15, 15)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1558, 758)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl1.TabIndex = 0
        '
        'Fornitori
        '
        Me.Fornitori.Controls.Add(Me.btnRefreshFornitore)
        Me.Fornitori.Controls.Add(Me.btnSearchFornitori)
        Me.Fornitori.Controls.Add(Me.Label8)
        Me.Fornitori.Controls.Add(Me.txtSearchFornitori)
        Me.Fornitori.Controls.Add(Me.btnPrintFornitori)
        Me.Fornitori.Controls.Add(Me.btnReturnFornitore)
        Me.Fornitori.Controls.Add(Me.btnDeleteFornitore)
        Me.Fornitori.Controls.Add(Me.btnModFornitore)
        Me.Fornitori.Controls.Add(Me.btnInsertFornitore)
        Me.Fornitori.Controls.Add(Me.DataGridFornitori)
        Me.Fornitori.Controls.Add(Me.GroupBox1)
        Me.Fornitori.Controls.Add(Me.PictureBox1)
        Me.Fornitori.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fornitori.Location = New System.Drawing.Point(4, 44)
        Me.Fornitori.Margin = New System.Windows.Forms.Padding(4)
        Me.Fornitori.Name = "Fornitori"
        Me.Fornitori.Padding = New System.Windows.Forms.Padding(4)
        Me.Fornitori.Size = New System.Drawing.Size(1550, 710)
        Me.Fornitori.TabIndex = 0
        Me.Fornitori.Text = "FORNITORI"
        Me.Fornitori.UseVisualStyleBackColor = True
        '
        'btnRefreshFornitore
        '
        Me.btnRefreshFornitore.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRefreshFornitore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen
        Me.btnRefreshFornitore.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefreshFornitore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefreshFornitore.Image = CType(resources.GetObject("btnRefreshFornitore.Image"), System.Drawing.Image)
        Me.btnRefreshFornitore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRefreshFornitore.Location = New System.Drawing.Point(551, 606)
        Me.btnRefreshFornitore.Margin = New System.Windows.Forms.Padding(6, 12, 25, 25)
        Me.btnRefreshFornitore.Name = "btnRefreshFornitore"
        Me.btnRefreshFornitore.Padding = New System.Windows.Forms.Padding(38, 0, 38, 0)
        Me.btnRefreshFornitore.Size = New System.Drawing.Size(674, 62)
        Me.btnRefreshFornitore.TabIndex = 16
        Me.btnRefreshFornitore.Text = "Refresh"
        Me.btnRefreshFornitore.UseVisualStyleBackColor = True
        '
        'btnSearchFornitori
        '
        Me.btnSearchFornitori.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearchFornitori.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen
        Me.btnSearchFornitori.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchFornitori.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchFornitori.Image = CType(resources.GetObject("btnSearchFornitori.Image"), System.Drawing.Image)
        Me.btnSearchFornitori.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearchFornitori.Location = New System.Drawing.Point(1104, 34)
        Me.btnSearchFornitori.Margin = New System.Windows.Forms.Padding(6, 25, 25, 25)
        Me.btnSearchFornitori.Name = "btnSearchFornitori"
        Me.btnSearchFornitori.Padding = New System.Windows.Forms.Padding(16, 0, 16, 0)
        Me.btnSearchFornitori.Size = New System.Drawing.Size(121, 39)
        Me.btnSearchFornitori.TabIndex = 15
        Me.btnSearchFornitori.Text = "Cerca"
        Me.btnSearchFornitori.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSearchFornitori.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(546, 38)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(162, 31)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Intestazione"
        '
        'txtSearchFornitori
        '
        Me.txtSearchFornitori.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearchFornitori.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtSearchFornitori.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchFornitori.Location = New System.Drawing.Point(719, 34)
        Me.txtSearchFornitori.Margin = New System.Windows.Forms.Padding(9, 6, 9, 25)
        Me.txtSearchFornitori.Name = "txtSearchFornitori"
        Me.txtSearchFornitori.Size = New System.Drawing.Size(369, 37)
        Me.txtSearchFornitori.TabIndex = 14
        '
        'btnPrintFornitori
        '
        Me.btnPrintFornitori.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnPrintFornitori.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen
        Me.btnPrintFornitori.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrintFornitori.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintFornitori.Image = CType(resources.GetObject("btnPrintFornitori.Image"), System.Drawing.Image)
        Me.btnPrintFornitori.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrintFornitori.Location = New System.Drawing.Point(16, 606)
        Me.btnPrintFornitori.Margin = New System.Windows.Forms.Padding(6, 12, 25, 25)
        Me.btnPrintFornitori.Name = "btnPrintFornitori"
        Me.btnPrintFornitori.Padding = New System.Windows.Forms.Padding(38, 0, 38, 0)
        Me.btnPrintFornitori.Size = New System.Drawing.Size(510, 62)
        Me.btnPrintFornitori.TabIndex = 17
        Me.btnPrintFornitori.Text = "STAMPA"
        Me.btnPrintFornitori.UseVisualStyleBackColor = True
        '
        'btnReturnFornitore
        '
        Me.btnReturnFornitore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturnFornitore.Location = New System.Drawing.Point(16, 514)
        Me.btnReturnFornitore.Margin = New System.Windows.Forms.Padding(5, 6, 5, 12)
        Me.btnReturnFornitore.Name = "btnReturnFornitore"
        Me.btnReturnFornitore.Padding = New System.Windows.Forms.Padding(12, 0, 12, 0)
        Me.btnReturnFornitore.Size = New System.Drawing.Size(156, 62)
        Me.btnReturnFornitore.TabIndex = 11
        Me.btnReturnFornitore.Text = "Torna"
        Me.btnReturnFornitore.UseVisualStyleBackColor = True
        Me.btnReturnFornitore.Visible = False
        '
        'btnDeleteFornitore
        '
        Me.btnDeleteFornitore.Enabled = False
        Me.btnDeleteFornitore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteFornitore.Image = CType(resources.GetObject("btnDeleteFornitore.Image"), System.Drawing.Image)
        Me.btnDeleteFornitore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDeleteFornitore.Location = New System.Drawing.Point(370, 514)
        Me.btnDeleteFornitore.Margin = New System.Windows.Forms.Padding(5, 6, 5, 12)
        Me.btnDeleteFornitore.Name = "btnDeleteFornitore"
        Me.btnDeleteFornitore.Padding = New System.Windows.Forms.Padding(12, 0, 12, 0)
        Me.btnDeleteFornitore.Size = New System.Drawing.Size(156, 62)
        Me.btnDeleteFornitore.TabIndex = 13
        Me.btnDeleteFornitore.Text = "Elimina"
        Me.btnDeleteFornitore.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDeleteFornitore.UseVisualStyleBackColor = True
        '
        'btnModFornitore
        '
        Me.btnModFornitore.Enabled = False
        Me.btnModFornitore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModFornitore.Location = New System.Drawing.Point(193, 514)
        Me.btnModFornitore.Margin = New System.Windows.Forms.Padding(5, 6, 5, 12)
        Me.btnModFornitore.Name = "btnModFornitore"
        Me.btnModFornitore.Padding = New System.Windows.Forms.Padding(12, 0, 12, 0)
        Me.btnModFornitore.Size = New System.Drawing.Size(156, 62)
        Me.btnModFornitore.TabIndex = 12
        Me.btnModFornitore.Text = "Modifica"
        Me.btnModFornitore.UseVisualStyleBackColor = True
        '
        'btnInsertFornitore
        '
        Me.btnInsertFornitore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsertFornitore.Location = New System.Drawing.Point(16, 514)
        Me.btnInsertFornitore.Margin = New System.Windows.Forms.Padding(5, 6, 5, 12)
        Me.btnInsertFornitore.Name = "btnInsertFornitore"
        Me.btnInsertFornitore.Padding = New System.Windows.Forms.Padding(12, 0, 12, 0)
        Me.btnInsertFornitore.Size = New System.Drawing.Size(156, 62)
        Me.btnInsertFornitore.TabIndex = 10
        Me.btnInsertFornitore.Text = "Inserisci"
        Me.btnInsertFornitore.UseVisualStyleBackColor = True
        '
        'DataGridFornitori
        '
        Me.DataGridFornitori.AllowUserToAddRows = False
        Me.DataGridFornitori.AllowUserToDeleteRows = False
        Me.DataGridFornitori.AllowUserToResizeColumns = False
        Me.DataGridFornitori.AllowUserToResizeRows = False
        Me.DataGridFornitori.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridFornitori.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridFornitori.ColumnHeadersHeight = 24
        Me.DataGridFornitori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridFornitori.Cursor = System.Windows.Forms.Cursors.Default
        Me.DataGridFornitori.EnableHeadersVisualStyles = False
        Me.DataGridFornitori.Location = New System.Drawing.Point(551, 89)
        Me.DataGridFornitori.Margin = New System.Windows.Forms.Padding(12, 25, 12, 12)
        Me.DataGridFornitori.Name = "DataGridFornitori"
        Me.DataGridFornitori.ReadOnly = True
        Me.DataGridFornitori.RowHeadersVisible = False
        Me.DataGridFornitori.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridFornitori.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridFornitori.Size = New System.Drawing.Size(674, 500)
        Me.DataGridFornitori.StandardTab = True
        Me.DataGridFornitori.TabIndex = 2
        Me.DataGridFornitori.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtId)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtTel)
        Me.GroupBox1.Controls.Add(Me.txtCap)
        Me.GroupBox1.Controls.Add(Me.txtProvincia)
        Me.GroupBox1.Controls.Add(Me.txtIndirizzo)
        Me.GroupBox1.Controls.Add(Me.txtCitta)
        Me.GroupBox1.Controls.Add(Me.txtIntestazione)
        Me.GroupBox1.Font = New System.Drawing.Font("Modern No. 20", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(16, 29)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(12, 25, 12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(12)
        Me.GroupBox1.Size = New System.Drawing.Size(510, 467)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "FORNITORI"
        '
        'txtId
        '
        Me.txtId.Enabled = False
        Me.txtId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.Location = New System.Drawing.Point(405, 52)
        Me.txtId.Margin = New System.Windows.Forms.Padding(4)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(83, 32)
        Me.txtId.TabIndex = 1
        Me.txtId.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(69, 409)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 26)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "E-Mail"
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(152, 405)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(9)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(335, 32)
        Me.txtEmail.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(49, 359)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 26)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Telefono"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(86, 309)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 26)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "CAP"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(42, 259)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 26)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Provincia"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(50, 209)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 26)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Indirizzo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(85, 159)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 26)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Città"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 109)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 26)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Intestazione"
        '
        'txtTel
        '
        Me.txtTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTel.Location = New System.Drawing.Point(152, 355)
        Me.txtTel.Margin = New System.Windows.Forms.Padding(9)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(335, 32)
        Me.txtTel.TabIndex = 8
        '
        'txtCap
        '
        Me.txtCap.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCap.Location = New System.Drawing.Point(152, 305)
        Me.txtCap.Margin = New System.Windows.Forms.Padding(9)
        Me.txtCap.Name = "txtCap"
        Me.txtCap.Size = New System.Drawing.Size(335, 32)
        Me.txtCap.TabIndex = 7
        '
        'txtProvincia
        '
        Me.txtProvincia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProvincia.Location = New System.Drawing.Point(152, 255)
        Me.txtProvincia.Margin = New System.Windows.Forms.Padding(9)
        Me.txtProvincia.Name = "txtProvincia"
        Me.txtProvincia.Size = New System.Drawing.Size(335, 32)
        Me.txtProvincia.TabIndex = 6
        '
        'txtIndirizzo
        '
        Me.txtIndirizzo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIndirizzo.Location = New System.Drawing.Point(152, 205)
        Me.txtIndirizzo.Margin = New System.Windows.Forms.Padding(9)
        Me.txtIndirizzo.Name = "txtIndirizzo"
        Me.txtIndirizzo.Size = New System.Drawing.Size(335, 32)
        Me.txtIndirizzo.TabIndex = 5
        '
        'txtCitta
        '
        Me.txtCitta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCitta.Location = New System.Drawing.Point(152, 155)
        Me.txtCitta.Margin = New System.Windows.Forms.Padding(9)
        Me.txtCitta.Name = "txtCitta"
        Me.txtCitta.Size = New System.Drawing.Size(335, 32)
        Me.txtCitta.TabIndex = 4
        '
        'txtIntestazione
        '
        Me.txtIntestazione.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIntestazione.Location = New System.Drawing.Point(152, 105)
        Me.txtIntestazione.Margin = New System.Windows.Forms.Padding(9)
        Me.txtIntestazione.Name = "txtIntestazione"
        Me.txtIntestazione.Size = New System.Drawing.Size(335, 32)
        Me.txtIntestazione.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1249, 34)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(12, 25, 12, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(285, 634)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Silos
        '
        Me.Silos.Controls.Add(Me.GroupBox3)
        Me.Silos.Controls.Add(Me.GroupBox2)
        Me.Silos.Location = New System.Drawing.Point(4, 44)
        Me.Silos.Margin = New System.Windows.Forms.Padding(4)
        Me.Silos.Name = "Silos"
        Me.Silos.Padding = New System.Windows.Forms.Padding(4)
        Me.Silos.Size = New System.Drawing.Size(1550, 710)
        Me.Silos.TabIndex = 1
        Me.Silos.Text = "SILOS"
        Me.Silos.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.ComboBox1)
        Me.GroupBox3.Controls.Add(Me.Button5)
        Me.GroupBox3.Controls.Add(Me.lbSilosC)
        Me.GroupBox3.Controls.Add(Me.lbSilosV)
        Me.GroupBox3.Controls.Add(Me.Label26)
        Me.GroupBox3.Controls.Add(Me.DataGridView1)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Font = New System.Drawing.Font("Modern No. 20", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(29, 29)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(25, 25, 12, 25)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(12)
        Me.GroupBox3.Size = New System.Drawing.Size(720, 640)
        Me.GroupBox3.TabIndex = 26
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "SILOS"
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label12.Location = New System.Drawing.Point(38, 551)
        Me.Label12.Margin = New System.Windows.Forms.Padding(25)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(127, 55)
        Me.Label12.TabIndex = 73
        Me.Label12.Text = "Silos"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(104, 418)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(509, 42)
        Me.ComboBox1.TabIndex = 72
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.Enabled = False
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(104, 480)
        Me.Button5.Margin = New System.Windows.Forms.Padding(5, 12, 25, 25)
        Me.Button5.Name = "Button5"
        Me.Button5.Padding = New System.Windows.Forms.Padding(12, 0, 12, 0)
        Me.Button5.Size = New System.Drawing.Size(510, 46)
        Me.Button5.TabIndex = 71
        Me.Button5.Text = "Modifica"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'lbSilosC
        '
        Me.lbSilosC.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbSilosC.AutoSize = True
        Me.lbSilosC.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSilosC.Location = New System.Drawing.Point(555, 564)
        Me.lbSilosC.Margin = New System.Windows.Forms.Padding(6, 25, 25, 25)
        Me.lbSilosC.Name = "lbSilosC"
        Me.lbSilosC.Size = New System.Drawing.Size(126, 39)
        Me.lbSilosC.TabIndex = 70
        Me.lbSilosC.Text = "Portata"
        '
        'lbSilosV
        '
        Me.lbSilosV.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbSilosV.AutoSize = True
        Me.lbSilosV.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSilosV.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbSilosV.Location = New System.Drawing.Point(341, 564)
        Me.lbSilosV.Margin = New System.Windows.Forms.Padding(25, 25, 6, 25)
        Me.lbSilosV.Name = "lbSilosV"
        Me.lbSilosV.Size = New System.Drawing.Size(162, 39)
        Me.lbSilosV.TabIndex = 68
        Me.lbSilosV.Text = "Capienza"
        Me.lbSilosV.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label26
        '
        Me.Label26.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(515, 564)
        Me.Label26.Margin = New System.Windows.Forms.Padding(6, 25, 6, 25)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(26, 39)
        Me.Label26.TabIndex = 69
        Me.Label26.Text = "/"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.ColumnHeadersHeight = 24
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Default
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(104, 80)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(91, 31, 91, 6)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(510, 228)
        Me.DataGridView1.StandardTab = True
        Me.DataGridView1.TabIndex = 3
        Me.DataGridView1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(104, 326)
        Me.Button1.Margin = New System.Windows.Forms.Padding(6, 12, 25, 25)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(38, 0, 38, 0)
        Me.Button1.Size = New System.Drawing.Size(510, 62)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "STAMPA"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.DataGridView2)
        Me.GroupBox2.Font = New System.Drawing.Font("Modern No. 20", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(774, 29)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(12, 25, 25, 25)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(12)
        Me.GroupBox2.Size = New System.Drawing.Size(749, 640)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "FORNITORI"
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(124, 36)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 31)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "NDA"
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.BackColor = System.Drawing.Color.LemonChiffon
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(38, 74)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(9, 6, 9, 6)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(256, 37)
        Me.TextBox2.TabIndex = 24
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(590, 74)
        Me.Button4.Margin = New System.Windows.Forms.Padding(6, 25, 25, 6)
        Me.Button4.Name = "Button4"
        Me.Button4.Padding = New System.Windows.Forms.Padding(16, 0, 16, 0)
        Me.Button4.Size = New System.Drawing.Size(121, 39)
        Me.Button4.TabIndex = 22
        Me.Button4.Text = "Cerca"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(371, 36)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(162, 31)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Intestazione"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.Color.LemonChiffon
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(318, 74)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(9, 6, 9, 6)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(256, 37)
        Me.TextBox1.TabIndex = 21
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(386, 540)
        Me.Button3.Margin = New System.Windows.Forms.Padding(6, 12, 25, 25)
        Me.Button3.Name = "Button3"
        Me.Button3.Padding = New System.Windows.Forms.Padding(38, 0, 38, 0)
        Me.Button3.Size = New System.Drawing.Size(325, 62)
        Me.Button3.TabIndex = 20
        Me.Button3.Text = "Refresh"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(38, 540)
        Me.Button2.Margin = New System.Windows.Forms.Padding(6, 12, 25, 25)
        Me.Button2.Name = "Button2"
        Me.Button2.Padding = New System.Windows.Forms.Padding(38, 0, 38, 0)
        Me.Button2.Size = New System.Drawing.Size(325, 62)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "STAMPA"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToResizeColumns = False
        Me.DataGridView2.AllowUserToResizeRows = False
        Me.DataGridView2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView2.ColumnHeadersHeight = 24
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView2.Cursor = System.Windows.Forms.Cursors.Default
        Me.DataGridView2.EnableHeadersVisualStyles = False
        Me.DataGridView2.Location = New System.Drawing.Point(38, 125)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(25, 6, 25, 6)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(674, 396)
        Me.DataGridView2.StandardTab = True
        Me.DataGridView2.TabIndex = 3
        Me.DataGridView2.TabStop = False
        '
        'Carico
        '
        Me.Carico.Location = New System.Drawing.Point(4, 44)
        Me.Carico.Margin = New System.Windows.Forms.Padding(4)
        Me.Carico.Name = "Carico"
        Me.Carico.Size = New System.Drawing.Size(1550, 710)
        Me.Carico.TabIndex = 2
        Me.Carico.Text = "CARICO"
        Me.Carico.UseVisualStyleBackColor = True
        '
        'Conf
        '
        Me.Conf.Location = New System.Drawing.Point(4, 44)
        Me.Conf.Margin = New System.Windows.Forms.Padding(4)
        Me.Conf.Name = "Conf"
        Me.Conf.Size = New System.Drawing.Size(1550, 710)
        Me.Conf.TabIndex = 3
        Me.Conf.Text = "CONFEZIONAMENTO"
        Me.Conf.UseVisualStyleBackColor = True
        '
        'Trasf
        '
        Me.Trasf.Location = New System.Drawing.Point(4, 44)
        Me.Trasf.Margin = New System.Windows.Forms.Padding(4)
        Me.Trasf.Name = "Trasf"
        Me.Trasf.Size = New System.Drawing.Size(1550, 710)
        Me.Trasf.TabIndex = 4
        Me.Trasf.Text = "TASFERIMENTO"
        Me.Trasf.UseVisualStyleBackColor = True
        '
        'Inter
        '
        Me.Inter.Location = New System.Drawing.Point(4, 44)
        Me.Inter.Margin = New System.Windows.Forms.Padding(4)
        Me.Inter.Name = "Inter"
        Me.Inter.Size = New System.Drawing.Size(1550, 710)
        Me.Inter.TabIndex = 5
        Me.Inter.Text = "INTERROGAZIONI"
        Me.Inter.UseVisualStyleBackColor = True
        '
        'btn_about
        '
        Me.btn_about.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_about.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_about.Location = New System.Drawing.Point(36, 782)
        Me.btn_about.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.btn_about.Name = "btn_about"
        Me.btn_about.Padding = New System.Windows.Forms.Padding(12, 0, 12, 0)
        Me.btn_about.Size = New System.Drawing.Size(510, 62)
        Me.btn_about.TabIndex = 100
        Me.btn_about.Text = "About"
        Me.btn_about.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.Font = New System.Drawing.Font("Arial Narrow", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(1225, 776)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(348, 80)
        Me.Label9.TabIndex = 78
        Me.Label9.Text = "Software realizzato da: SALVATORE VELLA" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "e-mail: svella84@gmail.com" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Tel: (+39) 3" & _
    "283245709" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Oliv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1588, 860)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btn_about)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Oliv"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OLIVER"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabControl1.ResumeLayout(False)
        Me.Fornitori.ResumeLayout(False)
        Me.Fornitori.PerformLayout()
        CType(Me.DataGridFornitori, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Silos.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents Fornitori As System.Windows.Forms.TabPage
    Friend WithEvents Silos As System.Windows.Forms.TabPage
    Friend WithEvents Carico As System.Windows.Forms.TabPage
    Friend WithEvents Conf As System.Windows.Forms.TabPage
    Friend WithEvents Trasf As System.Windows.Forms.TabPage
    Friend WithEvents Inter As System.Windows.Forms.TabPage
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTel As System.Windows.Forms.TextBox
    Friend WithEvents txtCap As System.Windows.Forms.TextBox
    Friend WithEvents txtProvincia As System.Windows.Forms.TextBox
    Friend WithEvents txtIndirizzo As System.Windows.Forms.TextBox
    Friend WithEvents txtCitta As System.Windows.Forms.TextBox
    Friend WithEvents txtIntestazione As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents DataGridFornitori As System.Windows.Forms.DataGridView
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents btnInsertFornitore As System.Windows.Forms.Button
    Friend WithEvents btnDeleteFornitore As System.Windows.Forms.Button
    Friend WithEvents btnModFornitore As System.Windows.Forms.Button
    Friend WithEvents btnReturnFornitore As System.Windows.Forms.Button
    Friend WithEvents btnSearchFornitori As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtSearchFornitori As System.Windows.Forms.TextBox
    Friend WithEvents btnPrintFornitori As System.Windows.Forms.Button
    Friend WithEvents btnRefreshFornitore As System.Windows.Forms.Button
    Friend WithEvents btn_about As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents lbSilosC As System.Windows.Forms.Label
    Friend WithEvents lbSilosV As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label

End Class
