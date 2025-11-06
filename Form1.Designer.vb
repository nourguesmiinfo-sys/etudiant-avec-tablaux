<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtnom = New System.Windows.Forms.TextBox()
        Me.txtnote = New System.Windows.Forms.TextBox()
        Me.btnAnnuler = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAfficher = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAjouter = New System.Windows.Forms.Button()
        Me.txtprenom = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.millieur = New System.Windows.Forms.Label()
        Me.moyen = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.GroupBox1.BackgroundImage = Global.etudiant_avec_tablaux.My.Resources.Resources._4574037114378836
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtnom)
        Me.GroupBox1.Controls.Add(Me.txtnote)
        Me.GroupBox1.Controls.Add(Me.btnAnnuler)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btnAfficher)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnAjouter)
        Me.GroupBox1.Controls.Add(Me.txtprenom)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 81)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(753, 357)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ajouter etudiant"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Fuchsia
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(39, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 36)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "nom"
        '
        'txtnom
        '
        Me.txtnom.Location = New System.Drawing.Point(183, 42)
        Me.txtnom.Name = "txtnom"
        Me.txtnom.Size = New System.Drawing.Size(537, 22)
        Me.txtnom.TabIndex = 7
        '
        'txtnote
        '
        Me.txtnote.Location = New System.Drawing.Point(189, 198)
        Me.txtnote.Name = "txtnote"
        Me.txtnote.Size = New System.Drawing.Size(531, 22)
        Me.txtnote.TabIndex = 9
        '
        'btnAnnuler
        '
        Me.btnAnnuler.BackColor = System.Drawing.Color.Red
        Me.btnAnnuler.Location = New System.Drawing.Point(283, 296)
        Me.btnAnnuler.Name = "btnAnnuler"
        Me.btnAnnuler.Size = New System.Drawing.Size(118, 50)
        Me.btnAnnuler.TabIndex = 2
        Me.btnAnnuler.Text = "annuler"
        Me.btnAnnuler.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Fuchsia
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(39, 185)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 36)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "note"
        '
        'btnAfficher
        '
        Me.btnAfficher.BackColor = System.Drawing.Color.Red
        Me.btnAfficher.Location = New System.Drawing.Point(144, 296)
        Me.btnAfficher.Name = "btnAfficher"
        Me.btnAfficher.Size = New System.Drawing.Size(113, 50)
        Me.btnAfficher.TabIndex = 1
        Me.btnAfficher.Text = "affich"
        Me.btnAfficher.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Fuchsia
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(-6, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 36)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "prenom"
        '
        'btnAjouter
        '
        Me.btnAjouter.BackColor = System.Drawing.Color.Red
        Me.btnAjouter.Location = New System.Drawing.Point(12, 296)
        Me.btnAjouter.Name = "btnAjouter"
        Me.btnAjouter.Size = New System.Drawing.Size(102, 50)
        Me.btnAjouter.TabIndex = 0
        Me.btnAjouter.Text = "ajouter"
        Me.btnAjouter.UseVisualStyleBackColor = False
        '
        'txtprenom
        '
        Me.txtprenom.Location = New System.Drawing.Point(183, 114)
        Me.txtprenom.Name = "txtprenom"
        Me.txtprenom.Size = New System.Drawing.Size(537, 22)
        Me.txtprenom.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Lime
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(289, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(169, 46)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "etudiant"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Gray
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(38, 461)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(452, 29)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "le nom et la note du meilleur étudiant:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Gray
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(18, 607)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(419, 29)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "la moyenne générale de la classe :"
        '
        'millieur
        '
        Me.millieur.AutoSize = True
        Me.millieur.Location = New System.Drawing.Point(92, 523)
        Me.millieur.Name = "millieur"
        Me.millieur.Size = New System.Drawing.Size(0, 16)
        Me.millieur.TabIndex = 16
        '
        'moyen
        '
        Me.moyen.AutoSize = True
        Me.moyen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.moyen.Location = New System.Drawing.Point(91, 668)
        Me.moyen.Name = "moyen"
        Me.moyen.Size = New System.Drawing.Size(0, 25)
        Me.moyen.TabIndex = 17
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(692, 668)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 70)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "exite"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 750)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.moyen)
        Me.Controls.Add(Me.millieur)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtnom As TextBox
    Friend WithEvents txtnote As TextBox
    Friend WithEvents btnAnnuler As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btnAfficher As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAjouter As Button
    Friend WithEvents txtprenom As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents millieur As Label
    Friend WithEvents moyen As Label
    Friend WithEvents Button1 As Button
End Class
