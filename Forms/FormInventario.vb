Imports Microsoft.Data.Sqlite

Public Class FormInventario
    Private currentProductId As Integer = 0
    Private isEditing As Boolean = False

    Private Sub FormInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConfigureDataGridView()
        LoadProducts()
        ClearForm()
    End Sub

    Private Sub ConfigureDataGridView()
        With DataGridViewInventario
            .AutoGenerateColumns = False
            .Columns.Clear()
            .Columns.Add("Id", "ID")
            .Columns.Add("Nombre", "Nombre")
            .Columns.Add("Precio", "Precio")
            .Columns.Add("Stock", "Stock")
            .Columns.Add("UnidadMedida", "Unidad")
            .Columns.Add("StockMinimo", "Stock Mínimo")

            ' Configurar columnas
            .Columns("Id").Visible = False
            .Columns("Nombre").Width = 200
            .Columns("Precio").Width = 100
            .Columns("Stock").Width = 100
            .Columns("UnidadMedida").Width = 100
            .Columns("StockMinimo").Width = 100

            ' Formato de precio
            .Columns("Precio").DefaultCellStyle.Format = "C2"
        End With
    End Sub

    Private Sub LoadProducts()
        Using conn As SqliteConnection = DatabaseHelper.GetConnection()
            conn.Open()
            Dim cmd As New SqliteCommand("SELECT * FROM Productos ORDER BY Nombre", conn)
            Dim reader As SqliteDataReader = cmd.ExecuteReader()

            DataGridViewInventario.Rows.Clear()

            While reader.Read()
                DataGridViewInventario.Rows.Add(
                    reader("Id"),
                    reader("Nombre"),
                    reader("Precio"),
                    reader("Stock"),
                    reader("UnidadMedida"),
                    reader("StockMinimo")
                )
            End While
        End Using
    End Sub

    Private Sub ClearForm()
        TextBoxNombre.Clear()
        TextBoxPrecio.Clear()
        TextBoxStock.Clear()
        TextBoxStockMinimo.Clear()
        ComboBoxUnidad.SelectedIndex = -1
        currentProductId = 0
        isEditing = False
        TextBoxNombre.Focus()
    End Sub

    Private Sub ButtonNuevo_Click(sender As Object, e As EventArgs) Handles ButtonNuevo.Click
        ClearForm()
    End Sub

    Private Sub ButtonGuardar_Click(sender As Object, e As EventArgs) Handles ButtonGuardar.Click
        If Not ValidateForm() Then
            Return
        End If

        Try
            Using conn As SqliteConnection = DatabaseHelper.GetConnection()
                conn.Open()
                Dim cmd As SqliteCommand

                If isEditing Then
                    ' Actualizar producto existente
                    cmd = New SqliteCommand("UPDATE Productos SET Nombre = @nombre, Precio = @precio, " &
                                          "Stock = @stock, UnidadMedida = @unidad, StockMinimo = @stockMinimo " &
                                          "WHERE Id = @id", conn)
                    cmd.Parameters.AddWithValue("@id", currentProductId)
                Else
                    ' Insertar nuevo producto
                    cmd = New SqliteCommand("INSERT INTO Productos (Nombre, Precio, Stock, UnidadMedida, StockMinimo) " &
                                          "VALUES (@nombre, @precio, @stock, @unidad, @stockMinimo)", conn)
                End If

                ' Agregar parámetros
                cmd.Parameters.AddWithValue("@nombre", TextBoxNombre.Text.Trim())
                cmd.Parameters.AddWithValue("@precio", Decimal.Parse(TextBoxPrecio.Text))
                cmd.Parameters.AddWithValue("@stock", Integer.Parse(TextBoxStock.Text))
                cmd.Parameters.AddWithValue("@unidad", ComboBoxUnidad.Text)
                cmd.Parameters.AddWithValue("@stockMinimo", Integer.Parse(TextBoxStockMinimo.Text))

                cmd.ExecuteNonQuery()

                MessageBox.Show("Producto guardado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadProducts()
                ClearForm()
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al guardar el producto: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function ValidateForm() As Boolean
        If String.IsNullOrWhiteSpace(TextBoxNombre.Text) Then
            MessageBox.Show("Debe ingresar un nombre", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBoxNombre.Focus()
            Return False
        End If

        If Not Decimal.TryParse(TextBoxPrecio.Text, Nothing) Then
            MessageBox.Show("El precio debe ser un número válido", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBoxPrecio.Focus()
            Return False
        End If

        If Not Integer.TryParse(TextBoxStock.Text, Nothing) Then
            MessageBox.Show("El stock debe ser un número entero", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBoxStock.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(ComboBoxUnidad.Text) Then
            MessageBox.Show("Debe seleccionar una unidad de medida", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ComboBoxUnidad.Focus()
            Return False
        End If

        If Not Integer.TryParse(TextBoxStockMinimo.Text, Nothing) Then
            MessageBox.Show("El stock mínimo debe ser un número entero", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBoxStockMinimo.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub ButtonCancelar_Click(sender As Object, e As EventArgs) Handles ButtonCancelar.Click
        ClearForm()
    End Sub

    Private Sub DataGridViewInventario_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewInventario.CellDoubleClick
        If e.RowIndex < 0 Then Return

        Dim row = DataGridViewInventario.Rows(e.RowIndex)
        currentProductId = Convert.ToInt32(row.Cells("Id").Value)
        TextBoxNombre.Text = row.Cells("Nombre").Value.ToString()
        TextBoxPrecio.Text = row.Cells("Precio").Value.ToString()
        TextBoxStock.Text = row.Cells("Stock").Value.ToString()
        ComboBoxUnidad.Text = row.Cells("UnidadMedida").Value.ToString()
        TextBoxStockMinimo.Text = row.Cells("StockMinimo").Value.ToString()
        isEditing = True
    End Sub

    Private Sub FormInventario_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        TextBoxNombre.Focus()
    End Sub

    ' Agregar estas funciones de formato para los TextBox numéricos
    Private Sub TextBoxPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxPrecio.KeyPress
        ' Permitir solo números, punto decimal y tecla de retroceso
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "."c Then
            e.Handled = True
        End If

        ' Permitir solo un punto decimal
        If e.KeyChar = "."c AndAlso DirectCast(sender, TextBox).Text.Contains(".") Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBoxStock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxStock.KeyPress
        ' Permitir solo números y tecla de retroceso
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBoxStockMinimo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxStockMinimo.KeyPress
        ' Permitir solo números y tecla de retroceso
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class