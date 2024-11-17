Imports Microsoft.Data.Sqlite

Public Class DatabaseHelper
    Private Shared ReadOnly DbPath As String = "RestaurantDB.db"
    Private Shared ReadOnly ConnectionString As String = $"Data Source ={DbPath}"

    Public Shared Function GetConnection() As SqliteConnection
        Return New SqliteConnection(ConnectionString)
    End Function

    Public Shared Sub InitializeDatabase()
        If Not System.IO.File.Exists(DbPath) Then
            CreateDatabase()
        End If
    End Sub

    Private Shared Sub CreateDatabase()
        Using connection As SqliteConnection = GetConnection()
            connection.Open()

            CreateProductosTable(connection)
            CreateProveedoresTable(connection)
            CreateComprasTable(connection)
            CreateVentasTable(connection)
            CreateMermasTable(connection)
        End Using
    End Sub

    Private Shared Sub CreateProductosTable(connection As SqliteConnection)
        Dim sql = "
            CREATE TABLE IF NOT EXISTS Productos (
            Id INTEGER PRIMARY KEY AUTOINCREMENT,
            Nombre TEXT NOT NULL,
            Precio DECIMAL(10,2) NOT NULL,
            Stock INTEGER NOT NULL DEFAULT 0,
            UnidadMedida TEXT,
            StockMinimo INTEGER DEFAULT 0
            )"
        ExecuteNonQuery(connection, sql)
    End Sub

    Private Shared Sub CreateProveedoresTable(connection As SqliteConnection)
        Dim sql = "
            CREATE TABLE IF NOT EXISTS Proveedores (
            Id INTEGER PRIMARY KEY AUTOINCREMENT,
            Nombre TEXT NOT NULL,
            Telefono TEXT,
            Direccion TEXT,
            Email TEXT
            )"
        ExecuteNonQuery(connection, sql)
    End Sub

    Private Shared Sub CreateComprasTable(connection As SqliteConnection)
        Dim sql = "
            CREATE TABLE IF NOT EXISTS Compras (
                Id INTEGER PRIMARY KEY AUTOINCREMENT, 
                Fecha TEXT NOT NULL,
                ProveedorId INTEGER,
                ProductoId INTEGER,
                Cantidad DECIMAL(10,2) NOT NULL, 
                PrecioUnitario DECIMAL(10,2) NOT NULL,
                Total DECIMAL(10,2) NOT NULL,
                FOREIGN KEY (ProveedorId) REFERENCES Proveedores(Id), 
                FOREIGN KEY (ProductoId) REFERENCES Productos(Id)
            )"
        ExecuteNonQuery(connection, sql)
    End Sub

    Private Shared Sub CreateVentasTable(connection As SqliteConnection)
        Dim sql = "
            CREATE TABLE IF NOT EXISTS Ventas(
                Id INTERGER PRIMARY KEY AUTOINCREMENT, 
                Fecha TEXT NOT NULL,
                Mesa TEXT,
                ProductoId INTEGER, 
                Cantidad DECIMAL(10,2) NOT NULL, 
                PrecioUnitario DECIMAL(10,2) NOT NULL, 
                Total DECIMAL(10,2) NOT NULL,
                FOREIGN KEY (ProductoId) REFERENCES Productos(Id)
            )"
        ExecuteNonQuery(connection, sql)
    End Sub

    Private Shared Sub CreateMermasTable(connection As SqliteConnection)
        Dim sql = "
            CREATE TABLE IF NOT EXISTS Mermas (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                Fecha TEXT NOT NULL,
                ProductoId INTEGER,
                Cantidad DECIMAL(10,2) NOT NULL, 
                Motivo TEXT, 
                FOREIGN KEY (ProductoId) REFERENCES Productos(Id)
            )"
        ExecuteNonQuery(connection, sql)
    End Sub

    Private Shared Sub ExecuteNonQuery(conneciton As SqliteConnection, sql As String)
        Using command As New SqliteCommand(sql, conneciton)
            command.ExecuteNonQuery()
        End Using
    End Sub
End Class
