﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.user_picture = New System.Windows.Forms.PictureBox()
        Me.passwordPic = New System.Windows.Forms.PictureBox()
        Me.username = New System.Windows.Forms.Label()
        Me.password = New System.Windows.Forms.Label()
        Me.CirclePicturBox1 = New Fast_Food_Restaurant.CirclePicturBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.user_picture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.passwordPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CirclePicturBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_username
        '
        Me.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_username.Location = New System.Drawing.Point(125, 243)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(471, 34)
        Me.txt_username.TabIndex = 5
        Me.txt_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_password
        '
        Me.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_password.Location = New System.Drawing.Point(125, 341)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.Size = New System.Drawing.Size(471, 34)
        Me.txt_password.TabIndex = 6
        Me.txt_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_password.UseSystemPasswordChar = True
        '
        'btn_login
        '
        Me.btn_login.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.btn_login.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_login.ForeColor = System.Drawing.Color.Black
        Me.btn_login.Location = New System.Drawing.Point(125, 439)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(196, 48)
        Me.btn_login.TabIndex = 7
        Me.btn_login.Text = "Login"
        Me.btn_login.UseVisualStyleBackColor = False
        '
        'btn_exit
        '
        Me.btn_exit.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.btn_exit.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exit.ForeColor = System.Drawing.Color.Black
        Me.btn_exit.Location = New System.Drawing.Point(386, 437)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(210, 48)
        Me.btn_exit.TabIndex = 11
        Me.btn_exit.Text = "Exit "
        Me.btn_exit.UseVisualStyleBackColor = False
        '
        'user_picture
        '
        Me.user_picture.BackColor = System.Drawing.Color.Transparent
        Me.user_picture.Image = CType(resources.GetObject("user_picture.Image"), System.Drawing.Image)
        Me.user_picture.Location = New System.Drawing.Point(73, 226)
        Me.user_picture.Name = "user_picture"
        Me.user_picture.Size = New System.Drawing.Size(46, 51)
        Me.user_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.user_picture.TabIndex = 12
        Me.user_picture.TabStop = False
        '
        'passwordPic
        '
        Me.passwordPic.BackColor = System.Drawing.Color.Transparent
        Me.passwordPic.Image = CType(resources.GetObject("passwordPic.Image"), System.Drawing.Image)
        Me.passwordPic.Location = New System.Drawing.Point(72, 320)
        Me.passwordPic.Margin = New System.Windows.Forms.Padding(0)
        Me.passwordPic.Name = "passwordPic"
        Me.passwordPic.Size = New System.Drawing.Size(47, 55)
        Me.passwordPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.passwordPic.TabIndex = 13
        Me.passwordPic.TabStop = False
        '
        'username
        '
        Me.username.AutoSize = True
        Me.username.BackColor = System.Drawing.Color.Transparent
        Me.username.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username.ForeColor = System.Drawing.Color.Black
        Me.username.Location = New System.Drawing.Point(119, 208)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(124, 29)
        Me.username.TabIndex = 15
        Me.username.Text = "Username"
        '
        'password
        '
        Me.password.AutoSize = True
        Me.password.BackColor = System.Drawing.Color.Transparent
        Me.password.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password.ForeColor = System.Drawing.Color.Black
        Me.password.Location = New System.Drawing.Point(119, 306)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(120, 29)
        Me.password.TabIndex = 17
        Me.password.Text = "Password"
        '
        'CirclePicturBox1
        '
        Me.CirclePicturBox1.Image = CType(resources.GetObject("CirclePicturBox1.Image"), System.Drawing.Image)
        Me.CirclePicturBox1.Location = New System.Drawing.Point(101, 57)
        Me.CirclePicturBox1.Name = "CirclePicturBox1"
        Me.CirclePicturBox1.Size = New System.Drawing.Size(107, 96)
        Me.CirclePicturBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.CirclePicturBox1.TabIndex = 18
        Me.CirclePicturBox1.TabStop = False
        Me.CirclePicturBox1.UseWaitCursor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(214, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(344, 81)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Restaurant"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label1.UseWaitCursor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 25.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(257, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(321, 60)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Billing System"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label2.UseWaitCursor = True
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(18.0!, 36.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(657, 552)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CirclePicturBox1)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.username)
        Me.Controls.Add(Me.passwordPic)
        Me.Controls.Add(Me.user_picture)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.txt_username)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.Name = "login"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "login"
        CType(Me.user_picture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.passwordPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CirclePicturBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_username As TextBox
    Friend WithEvents txt_password As TextBox
    Friend WithEvents btn_login As Button
    Friend WithEvents btn_exit As Button
    Friend WithEvents user_picture As PictureBox
    Friend WithEvents passwordPic As PictureBox
    Friend WithEvents username As Label
    Friend WithEvents password As Label
    Friend WithEvents CirclePicturBox1 As CirclePicturBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
