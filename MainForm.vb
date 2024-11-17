Imports System.Windows.Forms
Imports System.Drawing

Public Class MainForm
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Inicializar base de datos
        DatabaseHelper.InitializeDatabase()

        ' Agregar efectos hover a todos los botones
        For Each btn As Button In {ButtonCompras, ButtonVentas, ButtonInventario, ButtonMermas}
            ' Cambiamos los nombres de las variables en los eventos lambda
            AddHandler btn.MouseEnter, Sub(sender1, args1) btn.BackColor = Color.FromArgb(0, 102, 184)
            AddHandler btn.MouseLeave, Sub(sender1, args1) btn.BackColor = Color.FromArgb(0, 122, 204)
        Next
    End Sub

    Private Sub ButtonInventario_Click(sender As Object, e As EventArgs) Handles ButtonInventario.Click
        Using formInventario As New FormInventario
            ' Deshabilitamos temporalmente el botón para evitar múltiples clicks
            ButtonInventario.Enabled = False

            ' Mostramos el formulario de inventario
            formInventario.ShowDialog()

            ' Rehabilitamos el botón cuando se cierra el formulario
            ButtonInventario.Enabled = True
        End Using
    End Sub

    Private Sub ButtonCompras_Click(sender As Object, e As EventArgs) Handles ButtonCompras.Click
        MessageBox.Show("Módulo de Compras - En desarrollo")
    End Sub

    Private Sub ButtonVentas_Click(sender As Object, e As EventArgs) Handles ButtonVentas.Click
        MessageBox.Show("Módulo de Ventas - En desarrollo")
    End Sub

    Private Sub ButtonMermas_Click(sender As Object, e As EventArgs) Handles ButtonMermas.Click
        MessageBox.Show("Módulo de Mermas - En desarrollo")
    End Sub
End Class