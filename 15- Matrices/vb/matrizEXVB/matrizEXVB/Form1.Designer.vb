<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMatricesVB
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
        Me.btnSolve = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbC2 = New System.Windows.Forms.ComboBox()
        Me.cmbR2 = New System.Windows.Forms.ComboBox()
        Me.cmbC1 = New System.Windows.Forms.ComboBox()
        Me.cmbR1 = New System.Windows.Forms.ComboBox()
        Me.cmbOperacion = New System.Windows.Forms.ComboBox()
        Me.txtMatriz2 = New System.Windows.Forms.TextBox()
        Me.txtMatriz1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSolve
        '
        Me.btnSolve.Location = New System.Drawing.Point(269, 192)
        Me.btnSolve.Name = "btnSolve"
        Me.btnSolve.Size = New System.Drawing.Size(75, 23)
        Me.btnSolve.TabIndex = 27
        Me.btnSolve.Text = "Solve"
        Me.btnSolve.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(474, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(14, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "C"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(147, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(14, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "C"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(363, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(15, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "R"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(15, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "R"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(419, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 31)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Matriz 2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(92, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 31)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Matriz 1"
        '
        'cmbC2
        '
        Me.cmbC2.FormattingEnabled = True
        Me.cmbC2.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.cmbC2.Location = New System.Drawing.Point(494, 61)
        Me.cmbC2.Name = "cmbC2"
        Me.cmbC2.Size = New System.Drawing.Size(70, 21)
        Me.cmbC2.TabIndex = 20
        '
        'cmbR2
        '
        Me.cmbR2.FormattingEnabled = True
        Me.cmbR2.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.cmbR2.Location = New System.Drawing.Point(384, 61)
        Me.cmbR2.Name = "cmbR2"
        Me.cmbR2.Size = New System.Drawing.Size(70, 21)
        Me.cmbR2.TabIndex = 19
        '
        'cmbC1
        '
        Me.cmbC1.FormattingEnabled = True
        Me.cmbC1.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.cmbC1.Location = New System.Drawing.Point(168, 61)
        Me.cmbC1.Name = "cmbC1"
        Me.cmbC1.Size = New System.Drawing.Size(70, 21)
        Me.cmbC1.TabIndex = 18
        '
        'cmbR1
        '
        Me.cmbR1.FormattingEnabled = True
        Me.cmbR1.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.cmbR1.Location = New System.Drawing.Point(58, 61)
        Me.cmbR1.Name = "cmbR1"
        Me.cmbR1.Size = New System.Drawing.Size(70, 21)
        Me.cmbR1.TabIndex = 17
        '
        'cmbOperacion
        '
        Me.cmbOperacion.FormattingEnabled = True
        Me.cmbOperacion.Items.AddRange(New Object() {"+", "-", "*", "T"})
        Me.cmbOperacion.Location = New System.Drawing.Point(264, 165)
        Me.cmbOperacion.Name = "cmbOperacion"
        Me.cmbOperacion.Size = New System.Drawing.Size(88, 21)
        Me.cmbOperacion.TabIndex = 16
        '
        'txtMatriz2
        '
        Me.txtMatriz2.Location = New System.Drawing.Point(384, 88)
        Me.txtMatriz2.Multiline = True
        Me.txtMatriz2.Name = "txtMatriz2"
        Me.txtMatriz2.Size = New System.Drawing.Size(180, 174)
        Me.txtMatriz2.TabIndex = 15
        '
        'txtMatriz1
        '
        Me.txtMatriz1.Location = New System.Drawing.Point(58, 88)
        Me.txtMatriz1.Multiline = True
        Me.txtMatriz1.Name = "txtMatriz1"
        Me.txtMatriz1.Size = New System.Drawing.Size(180, 174)
        Me.txtMatriz1.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(224, 291)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(189, 13)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Ingresar datos separados por espacios"
        '
        'frmMatricesVB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(620, 331)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnSolve)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbC2)
        Me.Controls.Add(Me.cmbR2)
        Me.Controls.Add(Me.cmbC1)
        Me.Controls.Add(Me.cmbR1)
        Me.Controls.Add(Me.cmbOperacion)
        Me.Controls.Add(Me.txtMatriz2)
        Me.Controls.Add(Me.txtMatriz1)
        Me.Name = "frmMatricesVB"
        Me.Text = "Matrices"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSolve As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbC2 As ComboBox
    Friend WithEvents cmbR2 As ComboBox
    Friend WithEvents cmbC1 As ComboBox
    Friend WithEvents cmbR1 As ComboBox
    Friend WithEvents cmbOperacion As ComboBox
    Friend WithEvents txtMatriz2 As TextBox
    Friend WithEvents txtMatriz1 As TextBox
    Friend WithEvents Label7 As Label
End Class
