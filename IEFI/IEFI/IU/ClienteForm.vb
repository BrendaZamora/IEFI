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

        IdProvincias.DisplayMember = "Nombre"

        IdProvincias.ValueMember = "Id"

        IdProvincias.SelectedValue = IdProvincia_
    End Sub
End Class