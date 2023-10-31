<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Tab
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tab))
        Me.lst_produit = New System.Windows.Forms.ListBox()
        Me.lst_pu = New System.Windows.Forms.ListBox()
        Me.lst_mtht = New System.Windows.Forms.ListBox()
        Me.lst_qte = New System.Windows.Forms.ListBox()
        Me.cb_produit = New System.Windows.Forms.ComboBox()
        Me.txt_pu = New System.Windows.Forms.TextBox()
        Me.lbl_produit = New System.Windows.Forms.Label()
        Me.lbl_pu = New System.Windows.Forms.Label()
        Me.lbl_qte = New System.Windows.Forms.Label()
        Me.lbl_mtht = New System.Windows.Forms.Label()
        Me.btn_ajouter = New System.Windows.Forms.Button()
        Me.btn_upprimer = New System.Windows.Forms.Button()
        Me.btn_modifier = New System.Windows.Forms.Button()
        Me.btn_vider = New System.Windows.Forms.Button()
        Me.btn_calculer = New System.Windows.Forms.Button()
        Me.btn_Quitter = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txt_mtht1 = New System.Windows.Forms.TextBox()
        Me.txt_tva = New System.Windows.Forms.TextBox()
        Me.txt_remise = New System.Windows.Forms.TextBox()
        Me.txt_apayer = New System.Windows.Forms.TextBox()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.txt_totmtht = New System.Windows.Forms.TextBox()
        Me.txt_totqte = New System.Windows.Forms.TextBox()
        Me.txt_totpu = New System.Windows.Forms.TextBox()
        Me.lbl_mtht1 = New System.Windows.Forms.Label()
        Me.lbl_tva = New System.Windows.Forms.Label()
        Me.lbl_remise = New System.Windows.Forms.Label()
        Me.lbl_Apaye = New System.Windows.Forms.Label()
        Me.lbl_caisse = New System.Windows.Forms.Label()
        Me.lbl_Mr = New System.Windows.Forms.Label()
        Me.lbl_produit1 = New System.Windows.Forms.Label()
        Me.lbl_pu1 = New System.Windows.Forms.Label()
        Me.lbl_qte1 = New System.Windows.Forms.Label()
        Me.lbl_mtht2 = New System.Windows.Forms.Label()
        Me.lbl_tnd = New System.Windows.Forms.Label()
        Me.lbl_heure = New System.Windows.Forms.Label()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.txt_mtht = New System.Windows.Forms.TextBox()
        Me.cb_qte = New System.Windows.Forms.ComboBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lst_produit
        '
        Me.lst_produit.Font = New System.Drawing.Font("Myanmar Text", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_produit.FormattingEnabled = True
        Me.lst_produit.ItemHeight = 30
        Me.lst_produit.Location = New System.Drawing.Point(79, 396)
        Me.lst_produit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lst_produit.Name = "lst_produit"
        Me.lst_produit.Size = New System.Drawing.Size(177, 424)
        Me.lst_produit.TabIndex = 4
        '
        'lst_pu
        '
        Me.lst_pu.Font = New System.Drawing.Font("Myanmar Text", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_pu.FormatString = "N3"
        Me.lst_pu.FormattingEnabled = True
        Me.lst_pu.ItemHeight = 30
        Me.lst_pu.Location = New System.Drawing.Point(303, 396)
        Me.lst_pu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lst_pu.Name = "lst_pu"
        Me.lst_pu.Size = New System.Drawing.Size(177, 424)
        Me.lst_pu.TabIndex = 5
        '
        'lst_mtht
        '
        Me.lst_mtht.Font = New System.Drawing.Font("Myanmar Text", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_mtht.FormatString = "N3"
        Me.lst_mtht.FormattingEnabled = True
        Me.lst_mtht.ItemHeight = 30
        Me.lst_mtht.Location = New System.Drawing.Point(751, 396)
        Me.lst_mtht.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lst_mtht.Name = "lst_mtht"
        Me.lst_mtht.Size = New System.Drawing.Size(177, 424)
        Me.lst_mtht.TabIndex = 7
        '
        'lst_qte
        '
        Me.lst_qte.Font = New System.Drawing.Font("Myanmar Text", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_qte.FormattingEnabled = True
        Me.lst_qte.ItemHeight = 30
        Me.lst_qte.Location = New System.Drawing.Point(528, 396)
        Me.lst_qte.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lst_qte.Name = "lst_qte"
        Me.lst_qte.Size = New System.Drawing.Size(177, 424)
        Me.lst_qte.TabIndex = 12
        '
        'cb_produit
        '
        Me.cb_produit.BackColor = System.Drawing.Color.White
        Me.cb_produit.Font = New System.Drawing.Font("Myanmar Text", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_produit.FormattingEnabled = True
        Me.cb_produit.Items.AddRange(New Object() {"Clavier", "Souris", "Web-Cam", "Casque", "Pc"})
        Me.cb_produit.Location = New System.Drawing.Point(195, 251)
        Me.cb_produit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cb_produit.Name = "cb_produit"
        Me.cb_produit.Size = New System.Drawing.Size(179, 38)
        Me.cb_produit.TabIndex = 0
        '
        'txt_pu
        '
        Me.txt_pu.BackColor = System.Drawing.Color.White
        Me.txt_pu.Font = New System.Drawing.Font("Myanmar Text", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pu.Location = New System.Drawing.Point(793, 251)
        Me.txt_pu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_pu.Name = "txt_pu"
        Me.txt_pu.ReadOnly = True
        Me.txt_pu.Size = New System.Drawing.Size(179, 40)
        Me.txt_pu.TabIndex = 2
        '
        'lbl_produit
        '
        Me.lbl_produit.AutoSize = True
        Me.lbl_produit.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_produit.Location = New System.Drawing.Point(73, 255)
        Me.lbl_produit.Name = "lbl_produit"
        Me.lbl_produit.Size = New System.Drawing.Size(100, 29)
        Me.lbl_produit.TabIndex = 8
        Me.lbl_produit.Text = "Produit :"
        '
        'lbl_pu
        '
        Me.lbl_pu.AutoSize = True
        Me.lbl_pu.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pu.Location = New System.Drawing.Point(614, 255)
        Me.lbl_pu.Name = "lbl_pu"
        Me.lbl_pu.Size = New System.Drawing.Size(156, 29)
        Me.lbl_pu.TabIndex = 9
        Me.lbl_pu.Text = "Prix Unitaire : "
        '
        'lbl_qte
        '
        Me.lbl_qte.AutoSize = True
        Me.lbl_qte.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_qte.Location = New System.Drawing.Point(1159, 255)
        Me.lbl_qte.Name = "lbl_qte"
        Me.lbl_qte.Size = New System.Drawing.Size(113, 29)
        Me.lbl_qte.TabIndex = 10
        Me.lbl_qte.Text = "Quantite :"
        '
        'lbl_mtht
        '
        Me.lbl_mtht.AutoSize = True
        Me.lbl_mtht.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mtht.Location = New System.Drawing.Point(1627, 255)
        Me.lbl_mtht.Name = "lbl_mtht"
        Me.lbl_mtht.Size = New System.Drawing.Size(145, 29)
        Me.lbl_mtht.TabIndex = 11
        Me.lbl_mtht.Text = "Montant HT :"
        '
        'btn_ajouter
        '
        Me.btn_ajouter.Image = CType(resources.GetObject("btn_ajouter.Image"), System.Drawing.Image)
        Me.btn_ajouter.Location = New System.Drawing.Point(1838, 358)
        Me.btn_ajouter.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_ajouter.Name = "btn_ajouter"
        Me.btn_ajouter.Size = New System.Drawing.Size(129, 46)
        Me.btn_ajouter.TabIndex = 13
        Me.btn_ajouter.UseVisualStyleBackColor = True
        '
        'btn_upprimer
        '
        Me.btn_upprimer.Image = CType(resources.GetObject("btn_upprimer.Image"), System.Drawing.Image)
        Me.btn_upprimer.Location = New System.Drawing.Point(849, 902)
        Me.btn_upprimer.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_upprimer.Name = "btn_upprimer"
        Me.btn_upprimer.Size = New System.Drawing.Size(80, 47)
        Me.btn_upprimer.TabIndex = 14
        Me.btn_upprimer.UseVisualStyleBackColor = True
        '
        'btn_modifier
        '
        Me.btn_modifier.Image = CType(resources.GetObject("btn_modifier.Image"), System.Drawing.Image)
        Me.btn_modifier.Location = New System.Drawing.Point(720, 902)
        Me.btn_modifier.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_modifier.Name = "btn_modifier"
        Me.btn_modifier.Size = New System.Drawing.Size(80, 47)
        Me.btn_modifier.TabIndex = 15
        Me.btn_modifier.UseVisualStyleBackColor = True
        '
        'btn_vider
        '
        Me.btn_vider.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_vider.Image = CType(resources.GetObject("btn_vider.Image"), System.Drawing.Image)
        Me.btn_vider.Location = New System.Drawing.Point(1681, 358)
        Me.btn_vider.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_vider.Name = "btn_vider"
        Me.btn_vider.Size = New System.Drawing.Size(129, 47)
        Me.btn_vider.TabIndex = 16
        Me.btn_vider.UseVisualStyleBackColor = True
        '
        'btn_calculer
        '
        Me.btn_calculer.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_calculer.Image = CType(resources.GetObject("btn_calculer.Image"), System.Drawing.Image)
        Me.btn_calculer.Location = New System.Drawing.Point(1715, 816)
        Me.btn_calculer.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_calculer.Name = "btn_calculer"
        Me.btn_calculer.Size = New System.Drawing.Size(129, 47)
        Me.btn_calculer.TabIndex = 17
        Me.btn_calculer.UseVisualStyleBackColor = True
        '
        'btn_Quitter
        '
        Me.btn_Quitter.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Quitter.Image = CType(resources.GetObject("btn_Quitter.Image"), System.Drawing.Image)
        Me.btn_Quitter.Location = New System.Drawing.Point(1715, 881)
        Me.btn_Quitter.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_Quitter.Name = "btn_Quitter"
        Me.btn_Quitter.Size = New System.Drawing.Size(129, 47)
        Me.btn_Quitter.TabIndex = 18
        Me.btn_Quitter.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(929, 30)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(183, 174)
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'txt_mtht1
        '
        Me.txt_mtht1.BackColor = System.Drawing.Color.White
        Me.txt_mtht1.Font = New System.Drawing.Font("Myanmar Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_mtht1.Location = New System.Drawing.Point(1345, 494)
        Me.txt_mtht1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_mtht1.Name = "txt_mtht1"
        Me.txt_mtht1.ReadOnly = True
        Me.txt_mtht1.Size = New System.Drawing.Size(264, 46)
        Me.txt_mtht1.TabIndex = 20
        '
        'txt_tva
        '
        Me.txt_tva.BackColor = System.Drawing.Color.White
        Me.txt_tva.Font = New System.Drawing.Font("Myanmar Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tva.Location = New System.Drawing.Point(1345, 558)
        Me.txt_tva.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_tva.Name = "txt_tva"
        Me.txt_tva.ReadOnly = True
        Me.txt_tva.Size = New System.Drawing.Size(264, 46)
        Me.txt_tva.TabIndex = 21
        '
        'txt_remise
        '
        Me.txt_remise.BackColor = System.Drawing.Color.White
        Me.txt_remise.Font = New System.Drawing.Font("Myanmar Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_remise.Location = New System.Drawing.Point(1345, 619)
        Me.txt_remise.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_remise.Name = "txt_remise"
        Me.txt_remise.ReadOnly = True
        Me.txt_remise.Size = New System.Drawing.Size(264, 46)
        Me.txt_remise.TabIndex = 22
        '
        'txt_apayer
        '
        Me.txt_apayer.BackColor = System.Drawing.Color.White
        Me.txt_apayer.Font = New System.Drawing.Font("Myanmar Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_apayer.Location = New System.Drawing.Point(1345, 707)
        Me.txt_apayer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_apayer.Name = "txt_apayer"
        Me.txt_apayer.ReadOnly = True
        Me.txt_apayer.Size = New System.Drawing.Size(264, 46)
        Me.txt_apayer.TabIndex = 23
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.Location = New System.Drawing.Point(90, 830)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(135, 35)
        Me.lbl_total.TabIndex = 24
        Me.lbl_total.Text = "T O T A L  :"
        '
        'txt_totmtht
        '
        Me.txt_totmtht.BackColor = System.Drawing.Color.White
        Me.txt_totmtht.Font = New System.Drawing.Font("Myanmar Text", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_totmtht.Location = New System.Drawing.Point(750, 830)
        Me.txt_totmtht.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_totmtht.Name = "txt_totmtht"
        Me.txt_totmtht.ReadOnly = True
        Me.txt_totmtht.Size = New System.Drawing.Size(179, 42)
        Me.txt_totmtht.TabIndex = 25
        '
        'txt_totqte
        '
        Me.txt_totqte.BackColor = System.Drawing.Color.White
        Me.txt_totqte.Font = New System.Drawing.Font("Myanmar Text", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_totqte.Location = New System.Drawing.Point(527, 830)
        Me.txt_totqte.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_totqte.Name = "txt_totqte"
        Me.txt_totqte.ReadOnly = True
        Me.txt_totqte.Size = New System.Drawing.Size(179, 42)
        Me.txt_totqte.TabIndex = 26
        '
        'txt_totpu
        '
        Me.txt_totpu.BackColor = System.Drawing.Color.White
        Me.txt_totpu.Font = New System.Drawing.Font("Myanmar Text", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_totpu.Location = New System.Drawing.Point(300, 830)
        Me.txt_totpu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_totpu.Name = "txt_totpu"
        Me.txt_totpu.ReadOnly = True
        Me.txt_totpu.Size = New System.Drawing.Size(179, 42)
        Me.txt_totpu.TabIndex = 27
        '
        'lbl_mtht1
        '
        Me.lbl_mtht1.AutoSize = True
        Me.lbl_mtht1.Font = New System.Drawing.Font("Yu Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mtht1.Location = New System.Drawing.Point(1189, 503)
        Me.lbl_mtht1.Name = "lbl_mtht1"
        Me.lbl_mtht1.Size = New System.Drawing.Size(142, 26)
        Me.lbl_mtht1.TabIndex = 28
        Me.lbl_mtht1.Text = "Montant HT :"
        '
        'lbl_tva
        '
        Me.lbl_tva.AutoSize = True
        Me.lbl_tva.Font = New System.Drawing.Font("Yu Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tva.Location = New System.Drawing.Point(1194, 567)
        Me.lbl_tva.Name = "lbl_tva"
        Me.lbl_tva.Size = New System.Drawing.Size(137, 26)
        Me.lbl_tva.TabIndex = 29
        Me.lbl_tva.Text = "TVA  (20%)  :"
        '
        'lbl_remise
        '
        Me.lbl_remise.AutoSize = True
        Me.lbl_remise.Font = New System.Drawing.Font("Yu Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_remise.Location = New System.Drawing.Point(1200, 628)
        Me.lbl_remise.Name = "lbl_remise"
        Me.lbl_remise.Size = New System.Drawing.Size(103, 26)
        Me.lbl_remise.TabIndex = 30
        Me.lbl_remise.Text = "Remise : "
        '
        'lbl_Apaye
        '
        Me.lbl_Apaye.AutoSize = True
        Me.lbl_Apaye.Font = New System.Drawing.Font("Yu Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Apaye.Location = New System.Drawing.Point(1204, 717)
        Me.lbl_Apaye.Name = "lbl_Apaye"
        Me.lbl_Apaye.Size = New System.Drawing.Size(99, 26)
        Me.lbl_Apaye.TabIndex = 31
        Me.lbl_Apaye.Text = "A payer :"
        '
        'lbl_caisse
        '
        Me.lbl_caisse.AutoSize = True
        Me.lbl_caisse.Font = New System.Drawing.Font("Andalus", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_caisse.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lbl_caisse.Location = New System.Drawing.Point(1768, 64)
        Me.lbl_caisse.Name = "lbl_caisse"
        Me.lbl_caisse.Size = New System.Drawing.Size(191, 43)
        Me.lbl_caisse.TabIndex = 32
        Me.lbl_caisse.Text = "Caisse N° 003"
        '
        'lbl_Mr
        '
        Me.lbl_Mr.AutoSize = True
        Me.lbl_Mr.Font = New System.Drawing.Font("Andalus", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Mr.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lbl_Mr.Location = New System.Drawing.Point(1783, 100)
        Me.lbl_Mr.Name = "lbl_Mr"
        Me.lbl_Mr.Size = New System.Drawing.Size(163, 43)
        Me.lbl_Mr.TabIndex = 33
        Me.lbl_Mr.Text = "Mr -------"
        '
        'lbl_produit1
        '
        Me.lbl_produit1.AutoSize = True
        Me.lbl_produit1.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_produit1.Location = New System.Drawing.Point(115, 362)
        Me.lbl_produit1.Name = "lbl_produit1"
        Me.lbl_produit1.Size = New System.Drawing.Size(93, 29)
        Me.lbl_produit1.TabIndex = 35
        Me.lbl_produit1.Text = "Produit "
        '
        'lbl_pu1
        '
        Me.lbl_pu1.AutoSize = True
        Me.lbl_pu1.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pu1.Location = New System.Drawing.Point(320, 362)
        Me.lbl_pu1.Name = "lbl_pu1"
        Me.lbl_pu1.Size = New System.Drawing.Size(137, 29)
        Me.lbl_pu1.TabIndex = 36
        Me.lbl_pu1.Text = "prix-unitaire"
        '
        'lbl_qte1
        '
        Me.lbl_qte1.AutoSize = True
        Me.lbl_qte1.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_qte1.Location = New System.Drawing.Point(566, 362)
        Me.lbl_qte1.Name = "lbl_qte1"
        Me.lbl_qte1.Size = New System.Drawing.Size(101, 29)
        Me.lbl_qte1.TabIndex = 37
        Me.lbl_qte1.Text = "Quantite"
        '
        'lbl_mtht2
        '
        Me.lbl_mtht2.AutoSize = True
        Me.lbl_mtht2.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mtht2.Location = New System.Drawing.Point(771, 362)
        Me.lbl_mtht2.Name = "lbl_mtht2"
        Me.lbl_mtht2.Size = New System.Drawing.Size(134, 29)
        Me.lbl_mtht2.TabIndex = 38
        Me.lbl_mtht2.Text = "Montant-HT"
        '
        'lbl_tnd
        '
        Me.lbl_tnd.AutoSize = True
        Me.lbl_tnd.Font = New System.Drawing.Font("Yu Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tnd.Location = New System.Drawing.Point(1615, 726)
        Me.lbl_tnd.Name = "lbl_tnd"
        Me.lbl_tnd.Size = New System.Drawing.Size(56, 26)
        Me.lbl_tnd.TabIndex = 39
        Me.lbl_tnd.Text = "TND"
        '
        'lbl_heure
        '
        Me.lbl_heure.AutoSize = True
        Me.lbl_heure.Font = New System.Drawing.Font("Andalus", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_heure.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lbl_heure.Location = New System.Drawing.Point(96, 100)
        Me.lbl_heure.Name = "lbl_heure"
        Me.lbl_heure.Size = New System.Drawing.Size(0, 43)
        Me.lbl_heure.TabIndex = 43
        '
        'lbl_date
        '
        Me.lbl_date.AutoSize = True
        Me.lbl_date.Font = New System.Drawing.Font("Andalus", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_date.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lbl_date.Location = New System.Drawing.Point(96, 42)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(0, 43)
        Me.lbl_date.TabIndex = 42
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(96, 63)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(309, 22)
        Me.DateTimePicker1.TabIndex = 44
        '
        'txt_mtht
        '
        Me.txt_mtht.BackColor = System.Drawing.Color.White
        Me.txt_mtht.Font = New System.Drawing.Font("Myanmar Text", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_mtht.Location = New System.Drawing.Point(1776, 251)
        Me.txt_mtht.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_mtht.Name = "txt_mtht"
        Me.txt_mtht.ReadOnly = True
        Me.txt_mtht.Size = New System.Drawing.Size(179, 40)
        Me.txt_mtht.TabIndex = 46
        '
        'cb_qte
        '
        Me.cb_qte.BackColor = System.Drawing.Color.White
        Me.cb_qte.Font = New System.Drawing.Font("Myanmar Text", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_qte.FormattingEnabled = True
        Me.cb_qte.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.cb_qte.Location = New System.Drawing.Point(1278, 251)
        Me.cb_qte.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cb_qte.Name = "cb_qte"
        Me.cb_qte.Size = New System.Drawing.Size(179, 38)
        Me.cb_qte.TabIndex = 47
        '
        'Tab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1924, 1055)
        Me.Controls.Add(Me.cb_qte)
        Me.Controls.Add(Me.txt_mtht)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.lbl_heure)
        Me.Controls.Add(Me.lbl_date)
        Me.Controls.Add(Me.lbl_tnd)
        Me.Controls.Add(Me.lbl_mtht2)
        Me.Controls.Add(Me.lbl_qte1)
        Me.Controls.Add(Me.lbl_pu1)
        Me.Controls.Add(Me.lbl_produit1)
        Me.Controls.Add(Me.lbl_Mr)
        Me.Controls.Add(Me.lbl_caisse)
        Me.Controls.Add(Me.lbl_Apaye)
        Me.Controls.Add(Me.lbl_remise)
        Me.Controls.Add(Me.lbl_tva)
        Me.Controls.Add(Me.lbl_mtht1)
        Me.Controls.Add(Me.txt_totpu)
        Me.Controls.Add(Me.txt_totqte)
        Me.Controls.Add(Me.txt_totmtht)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.txt_apayer)
        Me.Controls.Add(Me.txt_remise)
        Me.Controls.Add(Me.txt_tva)
        Me.Controls.Add(Me.txt_mtht1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_Quitter)
        Me.Controls.Add(Me.btn_calculer)
        Me.Controls.Add(Me.btn_vider)
        Me.Controls.Add(Me.btn_modifier)
        Me.Controls.Add(Me.btn_upprimer)
        Me.Controls.Add(Me.btn_ajouter)
        Me.Controls.Add(Me.lbl_mtht)
        Me.Controls.Add(Me.lbl_qte)
        Me.Controls.Add(Me.lst_qte)
        Me.Controls.Add(Me.lbl_pu)
        Me.Controls.Add(Me.lst_mtht)
        Me.Controls.Add(Me.lbl_produit)
        Me.Controls.Add(Me.lst_pu)
        Me.Controls.Add(Me.lst_produit)
        Me.Controls.Add(Me.txt_pu)
        Me.Controls.Add(Me.cb_produit)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Tab"
        Me.Text = "Tableux des ventes"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lst_produit As ListBox
    Friend WithEvents lst_pu As ListBox
    Friend WithEvents lst_mtht As ListBox
    Friend WithEvents lst_qte As ListBox
    Friend WithEvents cb_produit As ComboBox
    Friend WithEvents txt_pu As TextBox
    Friend WithEvents lbl_produit As Label
    Friend WithEvents lbl_pu As Label
    Friend WithEvents lbl_qte As Label
    Friend WithEvents lbl_mtht As Label
    Friend WithEvents btn_ajouter As Button
    Friend WithEvents btn_upprimer As Button
    Friend WithEvents btn_modifier As Button
    Friend WithEvents btn_vider As Button
    Friend WithEvents btn_calculer As Button
    Friend WithEvents btn_Quitter As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txt_mtht1 As TextBox
    Friend WithEvents txt_tva As TextBox
    Friend WithEvents txt_remise As TextBox
    Friend WithEvents txt_apayer As TextBox
    Friend WithEvents lbl_total As Label
    Friend WithEvents txt_totmtht As TextBox
    Friend WithEvents txt_totqte As TextBox
    Friend WithEvents txt_totpu As TextBox
    Friend WithEvents lbl_mtht1 As Label
    Friend WithEvents lbl_tva As Label
    Friend WithEvents lbl_remise As Label
    Friend WithEvents lbl_Apaye As Label
    Friend WithEvents lbl_caisse As Label
    Friend WithEvents lbl_Mr As Label
    Friend WithEvents lbl_produit1 As Label
    Friend WithEvents lbl_pu1 As Label
    Friend WithEvents lbl_qte1 As Label
    Friend WithEvents lbl_mtht2 As Label
    Friend WithEvents lbl_tnd As Label
    Friend WithEvents lbl_heure As Label
    Friend WithEvents lbl_date As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents txt_mtht As TextBox
    Friend WithEvents cb_qte As ComboBox
End Class
