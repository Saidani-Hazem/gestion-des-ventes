<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.pb_user = New System.Windows.Forms.PictureBox()
        Me.pb_login = New System.Windows.Forms.PictureBox()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.txt_pwd = New System.Windows.Forms.TextBox()
        Me.btn_connexion = New System.Windows.Forms.Button()
        Me.btn_fermer = New System.Windows.Forms.Button()
        Me.lbl_user = New System.Windows.Forms.Label()
        Me.lbl_pwd = New System.Windows.Forms.Label()
        CType(Me.pb_user, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_login, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pb_user
        '
        Me.pb_user.Image = CType(resources.GetObject("pb_user.Image"), System.Drawing.Image)
        Me.pb_user.Location = New System.Drawing.Point(49, 64)
        Me.pb_user.Name = "pb_user"
        Me.pb_user.Size = New System.Drawing.Size(358, 344)
        Me.pb_user.TabIndex = 0
        Me.pb_user.TabStop = False
        '
        'pb_login
        '
        Me.pb_login.Image = CType(resources.GetObject("pb_login.Image"), System.Drawing.Image)
        Me.pb_login.Location = New System.Drawing.Point(669, 74)
        Me.pb_login.Name = "pb_login"
        Me.pb_login.Size = New System.Drawing.Size(104, 68)
        Me.pb_login.TabIndex = 1
        Me.pb_login.TabStop = False
        '
        'txt_username
        '
        Me.txt_username.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_username.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_username.Location = New System.Drawing.Point(578, 171)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(264, 31)
        Me.txt_username.TabIndex = 2
        '
        'txt_pwd
        '
        Me.txt_pwd.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pwd.Location = New System.Drawing.Point(578, 236)
        Me.txt_pwd.MaximumSize = New System.Drawing.Size(500, 200)
        Me.txt_pwd.MaxLength = 4
        Me.txt_pwd.Name = "txt_pwd"
        Me.txt_pwd.Size = New System.Drawing.Size(264, 31)
        Me.txt_pwd.TabIndex = 3
        Me.txt_pwd.UseSystemPasswordChar = True
        '
        'btn_connexion
        '
        Me.btn_connexion.Image = CType(resources.GetObject("btn_connexion.Image"), System.Drawing.Image)
        Me.btn_connexion.Location = New System.Drawing.Point(780, 303)
        Me.btn_connexion.Name = "btn_connexion"
        Me.btn_connexion.Size = New System.Drawing.Size(62, 51)
        Me.btn_connexion.TabIndex = 4
        Me.btn_connexion.UseVisualStyleBackColor = True
        '
        'btn_fermer
        '
        Me.btn_fermer.Image = CType(resources.GetObject("btn_fermer.Image"), System.Drawing.Image)
        Me.btn_fermer.Location = New System.Drawing.Point(698, 303)
        Me.btn_fermer.Name = "btn_fermer"
        Me.btn_fermer.Size = New System.Drawing.Size(62, 51)
        Me.btn_fermer.TabIndex = 5
        Me.btn_fermer.UseVisualStyleBackColor = True
        '
        'lbl_user
        '
        Me.lbl_user.AutoSize = True
        Me.lbl_user.Font = New System.Drawing.Font("Microsoft Tai Le", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_user.Location = New System.Drawing.Point(436, 174)
        Me.lbl_user.Name = "lbl_user"
        Me.lbl_user.Size = New System.Drawing.Size(109, 22)
        Me.lbl_user.TabIndex = 6
        Me.lbl_user.Text = "User name : "
        '
        'lbl_pwd
        '
        Me.lbl_pwd.AutoSize = True
        Me.lbl_pwd.Font = New System.Drawing.Font("Microsoft Tai Le", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pwd.Location = New System.Drawing.Point(436, 242)
        Me.lbl_pwd.Name = "lbl_pwd"
        Me.lbl_pwd.Size = New System.Drawing.Size(95, 22)
        Me.lbl_pwd.TabIndex = 7
        Me.lbl_pwd.Text = "Password :"
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(946, 441)
        Me.Controls.Add(Me.lbl_pwd)
        Me.Controls.Add(Me.lbl_user)
        Me.Controls.Add(Me.btn_fermer)
        Me.Controls.Add(Me.btn_connexion)
        Me.Controls.Add(Me.txt_pwd)
        Me.Controls.Add(Me.txt_username)
        Me.Controls.Add(Me.pb_login)
        Me.Controls.Add(Me.pb_user)
        Me.Name = "login"
        Me.Text = "login"
        CType(Me.pb_user, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_login, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pb_user As PictureBox
    Friend WithEvents pb_login As PictureBox
    Friend WithEvents txt_username As TextBox
    Friend WithEvents btn_connexion As Button
    Friend WithEvents btn_fermer As Button
    Friend WithEvents lbl_user As Label
    Friend WithEvents lbl_pwd As Label
    Friend WithEvents txt_pwd As TextBox
End Class
