Public Class ClientesGrid
    Private Sub Agregar_Click(sender As Object, e As EventArgs) Handles Agregar.Click
        ClienteForm.operacion = "Agregar"
        ClienteForm.Text = "Agregar "


        ClienteForm.Show()
    End Sub

    Private Sub Modificar_Click(sender As Object, e As EventArgs) Handles Modificar.Click
        If DataGridView1.Rows.Count = 0 Then
            MsgBox("No hay filas para modificar.")
            Exit Sub
        End If

        ClienteForm.operacion = "Modificar"
        ClienteForm.Text = "Modificar"
        ClienteForm.indice = DataGridView1.CurrentRow.Index

        llenarform()
        ClienteForm.Show()

        Dim fila As Integer = DataGridView1.CurrentRow.Index

        DataGridView1.Rows.Item(fila).Selected = False
        DataGridView1.Rows.Item(fila).Selected = True
    End Sub

    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles Eliminar.Click
        If DataGridView1.Rows.Count = 0 Then
            MsgBox("No hay filas para eliminar.")
            Exit Sub
        End If

        ClienteForm.operacion = "Eliminar"
        ClienteForm.Text = "Eliminar"
        ClienteForm.indice = DataGridView1.CurrentRow.Index

        llenarform()
        ClienteForm.Show()


        Dim fila As Integer = DataGridView1.CurrentRow.Index

        DataGridView1.Rows.Item(fila).Selected = False
        DataGridView1.Rows.Item(fila).Selected = True

    End Sub

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click

        Me.Dispose()
    End Sub

    Private Sub llenarform()
        Dim fila As Integer = DataGridView1.CurrentRow.Index

        ClienteForm.IdTextBox1.Text = clientesList.Item(fila).Id
        ClienteForm.NombreTextBox2.Text = clientesList.Item(fila).Nombre
        ClienteForm.IdProvincias.Text = clientesList.Item(fila).IdProvincia
    End Sub

    Private Sub ClientesGrid_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If DataGridView1.Rows.Count > 0 Then
            DataGridView1.Rows(0).Selected = True
        End If

        'IdProvincias.ComboBox.DataSource = provinciasList.TraerProvincia

        'IdProvincias.ComboBox.DisplayMember = "Nombre"

        'IdProvincias.ComboBox.ValueMember = "Id"

        'IdProvincias.ComboBox.SelectedValue = 1


    End Sub
End Class