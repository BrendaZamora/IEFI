<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClienteForm
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
        Me.Id = New System.Windows.Forms.Label()
        Me.Nombre = New System.Windows.Forms.Label()
        Me.Provincias = New System.Windows.Forms.Label()
        Me.IdTextBox1 = New System.Windows.Forms.TextBox()
        Me.NombreTextBox2 = New System.Windows.Forms.TextBox()
        Me.IdProvincias = New System.Windows.Forms.ComboBox()
        Me.Aceptar = New System.Windows.Forms.Button()
        Me.Cancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Id
        '
        Me.Id.AutoSize = True
        Me.Id.Enabled = False
        Me.Id.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Id.Location = New System.Drawing.Point(92, 59)
        Me.Id.Name = "Id"
        Me.Id.Size = New System.Drawing.Size(23, 20)
        Me.Id.TabIndex = 0
        Me.Id.Text = "Id"
        '
        'Nombre
        '
        Me.Nombre.AutoSize = True
        Me.Nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nombre.Location = New System.Drawing.Point(50, 109)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Size = New System.Drawing.Size(65, 20)
        Me.Nombre.TabIndex = 1
        Me.Nombre.Text = "Nombre"
        '
        'Provincias
        '
        Me.Provincias.AutoSize = True
        Me.Provincias.Enabled = False
        Me.Provincias.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Provincias.Location = New System.Drawing.Point(35, 154)
        Me.Provincias.Name = "Provincias"
        Me.Provincias.Size = New System.Drawing.Size(80, 20)
        Me.Provincias.TabIndex = 2
        Me.Provincias.Text = "Provincias"
        '
        'IdTextBox1
        '
        Me.IdTextBox1.Enabled = False
        Me.IdTextBox1.Location = New System.Drawing.Point(144, 59)
        Me.IdTextBox1.Name = "IdTextBox1"
        Me.IdTextBox1.Size = New System.Drawing.Size(76, 20)
        Me.IdTextBox1.TabIndex = 3
        '
        'NombreTextBox2
        '
        Me.NombreTextBox2.Location = New System.Drawing.Point(144, 106)
        Me.NombreTextBox2.Name = "NombreTextBox2"
        Me.NombreTextBox2.Size = New System.Drawing.Size(300, 20)
        Me.NombreTextBox2.TabIndex = 4
        '
        'IdProvincias
        '
        Me.IdProvincias.FormattingEnabled = True
        Me.IdProvincias.Location = New System.Drawing.Point(144, 153)
        Me.IdProvincias.Name = "IdProvincias"
        Me.IdProvincias.Size = New System.Drawing.Size(300, 21)
        Me.IdProvincias.TabIndex = 5
        '
        'Aceptar
        '
        Me.Aceptar.Location = New System.Drawing.Point(144, 213)
        Me.Aceptar.Name = "Aceptar"
        Me.Aceptar.Size = New System.Drawing.Size(88, 36)
        Me.Aceptar.TabIndex = 6
        Me.Aceptar.Text = "Aceptar"
        Me.Aceptar.UseVisualStyleBackColor = True
        '
        'Cancelar
        '
        Me.Cancelar.Location = New System.Drawing.Point(306, 213)
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.Size = New System.Drawing.Size(84, 36)
        Me.Cancelar.TabIndex = 7
        Me.Cancelar.Text = "Cancelar"
        Me.Cancelar.UseVisualStyleBackColor = True
        '
        'ClienteForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 265)
        Me.Controls.Add(Me.Cancelar)
        Me.Controls.Add(Me.Aceptar)
        Me.Controls.Add(Me.IdProvincias)
        Me.Controls.Add(Me.NombreTextBox2)
        Me.Controls.Add(Me.IdTextBox1)
        Me.Controls.Add(Me.Provincias)
        Me.Controls.Add(Me.Nombre)
        Me.Controls.Add(Me.Id)
        Me.Name = "ClienteForm"
        Me.Text = "ClienteForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Id As Label
    Friend WithEvents Nombre As Label
    Friend WithEvents Provincias As Label
    Friend WithEvents IdTextBox1 As TextBox
    Friend WithEvents NombreTextBox2 As TextBox
    Friend WithEvents IdProvincias As ComboBox
    Friend WithEvents Aceptar As Button
    Friend WithEvents Cancelar As Button
End Class
