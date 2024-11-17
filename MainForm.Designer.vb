<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        LabelTitle = New Label()
        ButtonCompras = New Button()
        ButtonVentas = New Button()
        ButtonInventario = New Button()
        ButtonMermas = New Button()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel1.Controls.Add(LabelTitle, 0, 0)
        TableLayoutPanel1.Controls.Add(ButtonCompras, 0, 1)
        TableLayoutPanel1.Controls.Add(ButtonVentas, 1, 1)
        TableLayoutPanel1.Controls.Add(ButtonInventario, 0, 2)
        TableLayoutPanel1.Controls.Add(ButtonMermas, 1, 2)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.Padding = New Padding(20)
        TableLayoutPanel1.RowCount = 3
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 60.0F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel1.Size = New Size(800, 450)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' LabelTitle
        ' 
        TableLayoutPanel1.SetColumnSpan(LabelTitle, 2)
        LabelTitle.Dock = DockStyle.Fill
        LabelTitle.Font = New Font("Segoe UI", 24.0F, FontStyle.Bold)
        LabelTitle.Location = New Point(23, 20)
        LabelTitle.Name = "LabelTitle"
        LabelTitle.Size = New Size(754, 60)
        LabelTitle.TabIndex = 0
        LabelTitle.Text = "Sistema de Gestión de Restaurant"
        LabelTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ButtonCompras
        ' 
        ButtonCompras.BackColor = Color.FromArgb(CByte(0), CByte(122), CByte(204))
        ButtonCompras.Dock = DockStyle.Fill
        ButtonCompras.FlatStyle = FlatStyle.Flat
        ButtonCompras.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        ButtonCompras.ForeColor = Color.White
        ButtonCompras.Location = New Point(30, 90)
        ButtonCompras.Margin = New Padding(10)
        ButtonCompras.Name = "ButtonCompras"
        ButtonCompras.Size = New Size(360, 155)
        ButtonCompras.TabIndex = 1
        ButtonCompras.Text = "Compras"
        ButtonCompras.UseVisualStyleBackColor = False
        ' 
        ' ButtonVentas
        ' 
        ButtonVentas.BackColor = Color.FromArgb(CByte(0), CByte(122), CByte(204))
        ButtonVentas.Dock = DockStyle.Fill
        ButtonVentas.FlatStyle = FlatStyle.Flat
        ButtonVentas.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        ButtonVentas.ForeColor = Color.White
        ButtonVentas.Location = New Point(410, 90)
        ButtonVentas.Margin = New Padding(10)
        ButtonVentas.Name = "ButtonVentas"
        ButtonVentas.Size = New Size(360, 155)
        ButtonVentas.TabIndex = 2
        ButtonVentas.Text = "Ventas"
        ButtonVentas.UseVisualStyleBackColor = False
        ' 
        ' ButtonInventario
        ' 
        ButtonInventario.BackColor = Color.FromArgb(CByte(0), CByte(122), CByte(204))
        ButtonInventario.Dock = DockStyle.Fill
        ButtonInventario.FlatStyle = FlatStyle.Flat
        ButtonInventario.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        ButtonInventario.ForeColor = Color.White
        ButtonInventario.Location = New Point(30, 265)
        ButtonInventario.Margin = New Padding(10)
        ButtonInventario.Name = "ButtonInventario"
        ButtonInventario.Size = New Size(360, 155)
        ButtonInventario.TabIndex = 3
        ButtonInventario.Text = "Inventario"
        ButtonInventario.UseVisualStyleBackColor = False
        ' 
        ' ButtonMermas
        ' 
        ButtonMermas.BackColor = Color.FromArgb(CByte(0), CByte(122), CByte(204))
        ButtonMermas.Dock = DockStyle.Fill
        ButtonMermas.FlatStyle = FlatStyle.Flat
        ButtonMermas.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        ButtonMermas.ForeColor = Color.White
        ButtonMermas.Location = New Point(410, 265)
        ButtonMermas.Margin = New Padding(10)
        ButtonMermas.Name = "ButtonMermas"
        ButtonMermas.Size = New Size(360, 155)
        ButtonMermas.TabIndex = 4
        ButtonMermas.Text = "Mermas"
        ButtonMermas.UseVisualStyleBackColor = False
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TableLayoutPanel1)
        Name = "MainForm"
        Text = "Restaurant Manager"
        WindowState = FormWindowState.Maximized
        TableLayoutPanel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents LabelTitle As Label
    Friend WithEvents ButtonCompras As Button
    Friend WithEvents ButtonVentas As Button
    Friend WithEvents ButtonInventario As Button
    Friend WithEvents ButtonMermas As Button
End Class