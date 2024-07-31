<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.txtPsw = New System.Windows.Forms.TextBox()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.lbcontrasena = New System.Windows.Forms.Label()
        Me.lbUsuario = New System.Windows.Forms.Label()
        Me.lbPsw = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbApellidoNombre = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.White
        Me.btnSalir.Location = New System.Drawing.Point(27, 661)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(223, 65)
        Me.btnSalir.TabIndex = 12
        Me.btnSalir.Text = "salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'txtPsw
        '
        Me.txtPsw.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPsw.Location = New System.Drawing.Point(201, 572)
        Me.txtPsw.Name = "txtPsw"
        Me.txtPsw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPsw.Size = New System.Drawing.Size(329, 30)
        Me.txtPsw.TabIndex = 11
        '
        'btnIngresar
        '
        Me.btnIngresar.BackColor = System.Drawing.Color.DarkGreen
        Me.btnIngresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngresar.ForeColor = System.Drawing.Color.White
        Me.btnIngresar.Location = New System.Drawing.Point(307, 661)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(223, 65)
        Me.btnIngresar.TabIndex = 10
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = False
        '
        'txtUsuario
        '
        Me.txtUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.Location = New System.Drawing.Point(201, 469)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(329, 30)
        Me.txtUsuario.TabIndex = 9
        '
        'lbcontrasena
        '
        Me.lbcontrasena.AutoSize = True
        Me.lbcontrasena.BackColor = System.Drawing.Color.DarkGreen
        Me.lbcontrasena.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbcontrasena.ForeColor = System.Drawing.Color.White
        Me.lbcontrasena.Location = New System.Drawing.Point(32, 578)
        Me.lbcontrasena.Name = "lbcontrasena"
        Me.lbcontrasena.Size = New System.Drawing.Size(141, 26)
        Me.lbcontrasena.TabIndex = 5
        Me.lbcontrasena.Text = "Contraseña:"
        '
        'lbUsuario
        '
        Me.lbUsuario.AutoSize = True
        Me.lbUsuario.BackColor = System.Drawing.Color.DarkGreen
        Me.lbUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbUsuario.ForeColor = System.Drawing.Color.White
        Me.lbUsuario.Location = New System.Drawing.Point(72, 473)
        Me.lbUsuario.Name = "lbUsuario"
        Me.lbUsuario.Size = New System.Drawing.Size(101, 26)
        Me.lbUsuario.TabIndex = 4
        Me.lbUsuario.Text = "Usuario:"
        '
        'lbPsw
        '
        Me.lbPsw.AutoSize = True
        Me.lbPsw.BackColor = System.Drawing.Color.DarkGreen
        Me.lbPsw.ForeColor = System.Drawing.Color.White
        Me.lbPsw.Location = New System.Drawing.Point(202, 605)
        Me.lbPsw.Name = "lbPsw"
        Me.lbPsw.Size = New System.Drawing.Size(38, 20)
        Me.lbPsw.TabIndex = 2
        Me.lbPsw.Text = "Psw"
        Me.lbPsw.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.btnSalir)
        Me.Panel2.Controls.Add(Me.txtPsw)
        Me.Panel2.Controls.Add(Me.btnIngresar)
        Me.Panel2.Controls.Add(Me.txtUsuario)
        Me.Panel2.Controls.Add(Me.lbcontrasena)
        Me.Panel2.Controls.Add(Me.lbUsuario)
        Me.Panel2.Controls.Add(Me.lbPsw)
        Me.Panel2.Controls.Add(Me.lbApellidoNombre)
        Me.Panel2.ForeColor = System.Drawing.Color.DarkGreen
        Me.Panel2.Location = New System.Drawing.Point(618, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(552, 752)
        Me.Panel2.TabIndex = 6
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PictureBox1.Image = Global.sys_gestion_inventario.My.Resources.Resources.icons8_usuario_80
        Me.PictureBox1.Location = New System.Drawing.Point(89, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(371, 375)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'lbApellidoNombre
        '
        Me.lbApellidoNombre.AutoSize = True
        Me.lbApellidoNombre.BackColor = System.Drawing.Color.DarkGreen
        Me.lbApellidoNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbApellidoNombre.ForeColor = System.Drawing.Color.White
        Me.lbApellidoNombre.Location = New System.Drawing.Point(200, 441)
        Me.lbApellidoNombre.Name = "lbApellidoNombre"
        Me.lbApellidoNombre.Size = New System.Drawing.Size(153, 20)
        Me.lbApellidoNombre.TabIndex = 1
        Me.lbApellidoNombre.Text = "Apellido y Nombre"
        Me.lbApellidoNombre.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(169, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(223, 53)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "SISTEMA"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkGreen
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(622, 752)
        Me.Panel1.TabIndex = 5
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.sys_gestion_inventario.My.Resources.Resources.logo_de_express_7__1_
        Me.PictureBox2.Location = New System.Drawing.Point(3, 286)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(610, 437)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 14
        Me.PictureBox2.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(122, 209)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(313, 53)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "INVENTARIO"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(235, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 53)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "DE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(165, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(227, 53)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "GESTIÓN"
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1158, 784)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmLogin"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSalir As Button
    Friend WithEvents txtPsw As TextBox
    Friend WithEvents btnIngresar As Button
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents lbcontrasena As Label
    Friend WithEvents lbUsuario As Label
    Friend WithEvents lbPsw As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lbApellidoNombre As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
