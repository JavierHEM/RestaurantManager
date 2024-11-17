<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormInventario
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
        TableLayoutPanel1 = New TableLayoutPanel()
        PanelTop = New Panel()
        LabelTitle = New Label()
        ButtonNuevo = New Button()
        DataGridViewInventario = New DataGridView()
        PanelDetails = New Panel()
        GroupBoxProducto = New GroupBox()
        ButtonCancelar = New Button()
        ButtonGuardar = New Button()
        TextBoxStockMinimo = New TextBox()
        LabelStockMinimo = New Label()
        TextBoxStock = New TextBox()
        LabelStock = New Label()
        ComboBoxUnidad = New ComboBox()
        LabelUnidad = New Label()
        TextBoxPrecio = New TextBox()
        LabelPrecio = New Label()
        TextBoxNombre = New TextBox()
        LabelNombre = New Label()
        TableLayoutPanel1.SuspendLayout()
        PanelTop.SuspendLayout()
        CType(DataGridViewInventario, ComponentModel.ISupportInitialize).BeginInit()
        PanelDetails.SuspendLayout()
        GroupBoxProducto.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 70.0F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 30.0F))
        TableLayoutPanel1.Controls.Add(PanelTop, 0, 0)
        TableLayoutPanel1.Controls.Add(DataGridViewInventario, 0, 1)
        TableLayoutPanel1.Controls.Add(PanelDetails, 1, 1)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 60.0F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100.0F))
        TableLayoutPanel1.Size = New Size(1024, 768)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' PanelTop
        ' 
        TableLayoutPanel1.SetColumnSpan(PanelTop, 2)
        PanelTop.Controls.Add(LabelTitle)
        PanelTop.Controls.Add(ButtonNuevo)
        PanelTop.Dock = DockStyle.Fill
        PanelTop.Location = New Point(3, 3)
        PanelTop.Name = "PanelTop"
        PanelTop.Size = New Size(1018, 54)
        PanelTop.TabIndex = 0
        ' 
        ' LabelTitle
        ' 
        LabelTitle.AutoSize = True
        LabelTitle.Font = New Font("Segoe UI", 16.0F, FontStyle.Bold)
        LabelTitle.Location = New Point(12, 12)
        LabelTitle.Name = "LabelTitle"
        LabelTitle.Size = New Size(204, 30)
        LabelTitle.TabIndex = 0
        LabelTitle.Text = "Gestión Inventario"
        ' 
        ' ButtonNuevo
        ' 
        ButtonNuevo.BackColor = Color.FromArgb(CByte(0), CByte(122), CByte(204))
        ButtonNuevo.FlatStyle = FlatStyle.Flat
        ButtonNuevo.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        ButtonNuevo.ForeColor = Color.White
        ButtonNuevo.Location = New Point(890, 12)
        ButtonNuevo.Name = "ButtonNuevo"
        ButtonNuevo.Size = New Size(120, 35)
        ButtonNuevo.TabIndex = 1
        ButtonNuevo.Text = "Nuevo Producto"
        ButtonNuevo.UseVisualStyleBackColor = False
        ' 
        ' DataGridViewInventario
        ' 
        DataGridViewInventario.AllowUserToAddRows = False
        DataGridViewInventario.AllowUserToDeleteRows = False
        DataGridViewInventario.BackgroundColor = Color.White
        DataGridViewInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewInventario.Dock = DockStyle.Fill
        DataGridViewInventario.Location = New Point(3, 63)
        DataGridViewInventario.Name = "DataGridViewInventario"
        DataGridViewInventario.ReadOnly = True
        DataGridViewInventario.Size = New Size(710, 702)
        DataGridViewInventario.TabIndex = 1
        ' 
        ' PanelDetails
        ' 
        PanelDetails.Controls.Add(GroupBoxProducto)
        PanelDetails.Dock = DockStyle.Fill
        PanelDetails.Location = New Point(719, 63)
        PanelDetails.Name = "PanelDetails"
        PanelDetails.Padding = New Padding(10)
        PanelDetails.Size = New Size(302, 702)
        PanelDetails.TabIndex = 2
        ' 
        ' GroupBoxProducto
        ' 
        GroupBoxProducto.Controls.Add(ButtonCancelar)
        GroupBoxProducto.Controls.Add(ButtonGuardar)
        GroupBoxProducto.Controls.Add(TextBoxStockMinimo)
        GroupBoxProducto.Controls.Add(LabelStockMinimo)
        GroupBoxProducto.Controls.Add(TextBoxStock)
        GroupBoxProducto.Controls.Add(LabelStock)
        GroupBoxProducto.Controls.Add(ComboBoxUnidad)
        GroupBoxProducto.Controls.Add(LabelUnidad)
        GroupBoxProducto.Controls.Add(TextBoxPrecio)
        GroupBoxProducto.Controls.Add(LabelPrecio)
        GroupBoxProducto.Controls.Add(TextBoxNombre)
        GroupBoxProducto.Controls.Add(LabelNombre)
        GroupBoxProducto.Dock = DockStyle.Fill
        GroupBoxProducto.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        GroupBoxProducto.Location = New Point(10, 10)
        GroupBoxProducto.Name = "GroupBoxProducto"
        GroupBoxProducto.Size = New Size(282, 682)
        GroupBoxProducto.TabIndex = 0
        GroupBoxProducto.TabStop = False
        GroupBoxProducto.Text = "Detalles del Producto"
        ' 
        ' ButtonCancelar
        ' 
        ButtonCancelar.BackColor = Color.FromArgb(CByte(204), CByte(0), CByte(0))
        ButtonCancelar.FlatStyle = FlatStyle.Flat
        ButtonCancelar.ForeColor = Color.White
        ButtonCancelar.Location = New Point(144, 308)
        ButtonCancelar.Name = "ButtonCancelar"
        ButtonCancelar.Size = New Size(120, 35)
        ButtonCancelar.TabIndex = 11
        ButtonCancelar.Text = "Cancelar"
        ButtonCancelar.UseVisualStyleBackColor = False
        ' 
        ' ButtonGuardar
        ' 
        ButtonGuardar.BackColor = Color.FromArgb(CByte(0), CByte(122), CByte(204))
        ButtonGuardar.FlatStyle = FlatStyle.Flat
        ButtonGuardar.ForeColor = Color.White
        ButtonGuardar.Location = New Point(18, 308)
        ButtonGuardar.Name = "ButtonGuardar"
        ButtonGuardar.Size = New Size(120, 35)
        ButtonGuardar.TabIndex = 10
        ButtonGuardar.Text = "Guardar"
        ButtonGuardar.UseVisualStyleBackColor = False
        ' 
        ' TextBoxStockMinimo
        ' 
        TextBoxStockMinimo.Location = New Point(18, 268)
        TextBoxStockMinimo.Name = "TextBoxStockMinimo"
        TextBoxStockMinimo.Size = New Size(246, 23)
        TextBoxStockMinimo.TabIndex = 9
        ' 
        ' LabelStockMinimo
        ' 
        LabelStockMinimo.AutoSize = True
        LabelStockMinimo.Location = New Point(18, 250)
        LabelStockMinimo.Name = "LabelStockMinimo"
        LabelStockMinimo.Size = New Size(84, 15)
        LabelStockMinimo.TabIndex = 8
        LabelStockMinimo.Text = "Stock Mínimo"
        ' 
        ' TextBoxStock
        ' 
        TextBoxStock.Location = New Point(18, 214)
        TextBoxStock.Name = "TextBoxStock"
        TextBoxStock.Size = New Size(246, 23)
        TextBoxStock.TabIndex = 7
        ' 
        ' LabelStock
        ' 
        LabelStock.AutoSize = True
        LabelStock.Location = New Point(18, 196)
        LabelStock.Name = "LabelStock"
        LabelStock.Size = New Size(39, 15)
        LabelStock.TabIndex = 6
        LabelStock.Text = "Stock"
        ' 
        ' ComboBoxUnidad
        ' 
        ComboBoxUnidad.FormattingEnabled = True
        ComboBoxUnidad.Items.AddRange(New Object() {"Unidad", "Kg", "Litro", "Gramo", "Paquete"})
        ComboBoxUnidad.Location = New Point(18, 160)
        ComboBoxUnidad.Name = "ComboBoxUnidad"
        ComboBoxUnidad.Size = New Size(246, 23)
        ComboBoxUnidad.TabIndex = 5
        ' 
        ' LabelUnidad
        ' 
        LabelUnidad.AutoSize = True
        LabelUnidad.Location = New Point(18, 142)
        LabelUnidad.Name = "LabelUnidad"
        LabelUnidad.Size = New Size(107, 15)
        LabelUnidad.TabIndex = 4
        LabelUnidad.Text = "Unidad de Medida"
        ' 
        ' TextBoxPrecio
        ' 
        TextBoxPrecio.Location = New Point(18, 106)
        TextBoxPrecio.Name = "TextBoxPrecio"
        TextBoxPrecio.Size = New Size(246, 23)
        TextBoxPrecio.TabIndex = 3
        ' 
        ' LabelPrecio
        ' 
        LabelPrecio.AutoSize = True
        LabelPrecio.Location = New Point(18, 88)
        LabelPrecio.Name = "LabelPrecio"
        LabelPrecio.Size = New Size(42, 15)
        LabelPrecio.TabIndex = 2
        LabelPrecio.Text = "Precio"
        ' 
        ' TextBoxNombre
        ' 
        TextBoxNombre.Location = New Point(18, 52)
        TextBoxNombre.Name = "TextBoxNombre"
        TextBoxNombre.Size = New Size(246, 23)
        TextBoxNombre.TabIndex = 1
        ' 
        ' LabelNombre
        ' 
        LabelNombre.AutoSize = True
        LabelNombre.Location = New Point(18, 34)
        LabelNombre.Name = "LabelNombre"
        LabelNombre.Size = New Size(53, 15)
        LabelNombre.TabIndex = 0
        LabelNombre.Text = "Nombre"
        ' 
        ' FormInventario
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1024, 768)
        Controls.Add(TableLayoutPanel1)
        Name = "FormInventario"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Inventario"
        WindowState = FormWindowState.Maximized
        TableLayoutPanel1.ResumeLayout(False)
        PanelTop.ResumeLayout(False)
        PanelTop.PerformLayout()
        CType(DataGridViewInventario, ComponentModel.ISupportInitialize).EndInit()
        PanelDetails.ResumeLayout(False)
        GroupBoxProducto.ResumeLayout(False)
        GroupBoxProducto.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PanelTop As Panel
    Friend WithEvents LabelTitle As Label
    Friend WithEvents ButtonNuevo As Button
    Friend WithEvents DataGridViewInventario As DataGridView
    Friend WithEvents PanelDetails As Panel
    Friend WithEvents GroupBoxProducto As GroupBox
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents LabelNombre As Label
    Friend WithEvents TextBoxPrecio As TextBox
    Friend WithEvents LabelPrecio As Label
    Friend WithEvents ComboBoxUnidad As ComboBox
    Friend WithEvents LabelUnidad As Label
    Friend WithEvents TextBoxStock As TextBox
    Friend WithEvents LabelStock As Label
    Friend WithEvents TextBoxStockMinimo As TextBox
    Friend WithEvents LabelStockMinimo As Label
    Friend WithEvents ButtonCancelar As Button
    Friend WithEvents ButtonGuardar As Button
End Class