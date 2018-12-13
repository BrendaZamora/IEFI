Public Class ClienteForm


    Dim operacion_ As String
    Dim MiCliente As New ClienteClass

    Public Property operacion() As String
        Get
            Return operacion_
        End Get
        Set(ByVal value As String)
            operacion_ = value
        End Set
    End Property

    Dim indice_ As Byte

    Public Property indice() As Byte
        Get
            Return indice_
        End Get
        Set(ByVal value As Byte)
            indice_ = value
        End Set
    End Property

    Dim IdProvincia_ As Integer


    Public Property IdProvincia() As Integer
        Get
            Return IdProvincia_
        End Get
        Set(ByVal value As Integer)
            IdProvincia_ = value
        End Set
    End Property

    Private Sub Aceptar_Click(sender As Object, e As EventArgs) Handles Aceptar.Click
        If operacion <> "Agregar" Then
            MiCliente.Id = CInt(IdTextBox1.Text)
        End If

        MiCliente.Nombre = NombreTextBox2.Text
        MiCliente.IdProvincia = IdProvincias.SelectedValue

        Select Case operacion_
            Case "Agregar"
                If IdProvincias.SelectedValue = -1 Then Exit Sub

                clientesList.InsertarCliente(MiCliente)

            Case "Eliminar"
                clientesList.EliminarCliente(MiCliente)

            Case "Modificar"
                clientesList.ActualizarCliente(MiCliente)

        End Select

        Me.Close()
    End Sub

    Private Sub Cancelar_Click(sender As Object, e As EventArgs) Handles Cancelar.Click

        Me.Close()
    End Sub

    Private Sub ClienteForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        IdProvincias.DataSource = provinciasList.TraerProvincia()

        'IdProvincias.DisplayMember = "Nombre"
        'La columna para mostrar de provincias se llama Provincia
        IdProvincias.DisplayMember = "Provincia"

        IdProvincias.ValueMember = "Id"

        IdProvincias.SelectedValue = IdProvincia_
    End Sub

    Private Sub NombreTextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NombreTextBox2.KeyPress

        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If


    End Sub

    Private Sub NombreTextBox2_LostFocus(sender As Object, e As EventArgs) Handles NombreTextBox2.LostFocus
        Dim nom() As String
        NombreTextBox2.Text = NombreTextBox2.Text.TrimStart
        NombreTextBox2.Text = NombreTextBox2.Text.TrimEnd

        nom = NombreTextBox2.Text.Split(" ")
        NombreTextBox2.Clear()
        Dim x As Integer
        For x = 0 To nom.Length - 1
            nom(x) = nom(x).Substring(0, 1).ToUpper + nom(x).Substring(1).ToLower
            NombreTextBox2.Text = NombreTextBox2.Text + " " + nom(x)
        Next
    End Sub

    Private Sub TextBoxFecha_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxFecha.KeyPress

        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "/" And Not e.KeyChar = "," And Not e.KeyChar = "." And Not e.KeyChar = "-" Then
            e.Handled = True

            Exit Sub

        End If
        If Char.IsControl(e.KeyChar) Then

        End If

        Dim pos As Integer = TextBoxFecha.SelectionStart



        If e.KeyChar = "/" And pos <> 2 And pos <> 5 Then
            e.Handled = True
            Exit Sub


        End If


        If Char.IsNumber(e.KeyChar) And (pos = 2 Or pos = 5) Then
            e.Handled = True
            Exit Sub

        End If

        If e.KeyChar = "." Then
            SendKeys.Send("/")
            e.Handled = True
        End If
        If e.KeyChar = "," Then
            SendKeys.Send("/")
            e.Handled = True
        End If
        If e.KeyChar = "-" Then
            SendKeys.Send("/")
            e.Handled = True
        End If

    End Sub

    Private Sub TextBoxFecha_LostFocus(sender As Object, e As EventArgs) Handles TextBoxFecha.LostFocus
        Dim fec() As String
        fec = TextBoxFecha.Text.Split("/")

        Dim dia As Integer = CInt(fec(0))
        Dim mes As Integer = CInt(fec(1))
        Dim año As Integer = CInt(fec(2))

        If año < 1900 Or año > 2100 Then
        End If
    End Sub

    Private Sub TextBoxSaldo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxSaldo.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = "/" And Not e.KeyChar = "," And Not e.KeyChar = "." And Not e.KeyChar = "-" Then
            e.Handled = True

            Exit Sub

        End If
    End Sub
End Class