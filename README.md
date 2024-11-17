# Sistema de Gestión de Restaurant
[![MIT License](https://img.shields.io/badge/License-MIT-green.svg)](https://choosealicense.com/licenses/mit/)

```markdown
# Sistema de Gestión de Restaurant
Un sistema de gestión integral para restaurantes desarrollado en VB.NET con .NET 8 y SQLite.

## 🚀 Características
- Gestión de inventario
- Control de compras
- Registro de ventas
- Control de mermas
- Base de datos SQLite (portable y sin instalación)

## 📋 Estructura del Proyecto

RestaurantManager/
├── Data/
│   └── DatabaseHelper.vb      # Gestión de conexión y operaciones SQLite
│
├── Forms/
│   ├── MainForm.vb           # Menú principal
│   ├── FormInventario.vb     # Gestión de productos
│   ├── FormCompras.vb        # Registro de compras
│   ├── FormVentas.vb         # Registro de ventas
│   └── FormMermas.vb         # Control de mermas
│
└── Models/
├── Producto.vb           # Modelo de productos
├── Proveedor.vb          # Modelo de proveedores
├── Compra.vb             # Modelo de compras
├── Venta.vb             # Modelo de ventas
└── Merma.vb             # Modelo de mermas


## 🔧 Requisitos
- Visual Studio 2022
- .NET 8.0 SDK
- SQLite

## 📥 Instalación
1. Clonar el repositorio
```bash
git clone https://github.com/JavierHEM/RestaurantManager.git
```

2. Abrir el proyecto en Visual Studio 2022
3. Restaurar los paquetes NuGet:
   - Microsoft.Data.Sqlite
   - Microsoft.Data.Sqlite.Core

4. Compilar y ejecutar el proyecto

## 📦 Base de Datos
El sistema utiliza SQLite, que se crea automáticamente al iniciar la aplicación por primera vez. La base de datos incluye las siguientes tablas:

### Productos
| Campo | Tipo | Descripción |
|-------|------|-------------|
| ID | INTEGER | Primary Key |
| Nombre | TEXT | Nombre del producto |
| Precio | DECIMAL | Precio unitario |
| Stock | INTEGER | Cantidad disponible |
| UnidadMedida | TEXT | Unidad de medida |
| StockMinimo | INTEGER | Nivel mínimo de stock |

### Proveedores
| Campo | Tipo | Descripción |
|-------|------|-------------|
| ID | INTEGER | Primary Key |
| Nombre | TEXT | Nombre del proveedor |
| Telefono | TEXT | Teléfono de contacto |
| Direccion | TEXT | Dirección física |
| Email | TEXT | Correo electrónico |

### Compras
| Campo | Tipo | Descripción |
|-------|------|-------------|
| ID | INTEGER | Primary Key |
| Fecha | TEXT | Fecha de compra |
| ProveedorID | INTEGER | Foreign Key |
| ProductoID | INTEGER | Foreign Key |
| Cantidad | DECIMAL | Cantidad comprada |
| PrecioUnitario | DECIMAL | Precio por unidad |
| Total | DECIMAL | Total de la compra |

### Ventas
| Campo | Tipo | Descripción |
|-------|------|-------------|
| ID | INTEGER | Primary Key |
| Fecha | TEXT | Fecha de venta |
| Mesa | TEXT | Número de mesa |
| ProductoID | INTEGER | Foreign Key |
| Cantidad | DECIMAL | Cantidad vendida |
| PrecioUnitario | DECIMAL | Precio de venta |
| Total | DECIMAL | Total de la venta |

### Mermas
| Campo | Tipo | Descripción |
|-------|------|-------------|
| ID | INTEGER | Primary Key |
| Fecha | TEXT | Fecha de registro |
| ProductoID | INTEGER | Foreign Key |
| Cantidad | DECIMAL | Cantidad perdida |
| Motivo | TEXT | Razón de la merma |

## 🎯 Estado del Proyecto
- ✅ Menú principal
- ✅ Gestión de inventario
- ⏳ Gestión de compras (en desarrollo)
- ⏳ Gestión de ventas (en desarrollo)
- ⏳ Control de mermas (en desarrollo)

## 🔜 Próximas Características
- [ ] Módulo de compras
- [ ] Módulo de ventas
- [ ] Control de mermas
- [ ] Reportes y estadísticas
- [ ] Dashboard con indicadores clave
- [ ] Sistema de alertas de stock bajo
- [ ] Gestión de usuarios y permisos

## 🛡️ Seguridad
- Validación de datos en todos los formularios
- Manejo de transacciones para operaciones críticas
- Control de errores y excepciones

## 🤝 Contribución
Si deseas contribuir al proyecto:
1. Haz un Fork del repositorio
2. Crea una nueva rama (`git checkout -b feature/NuevaCaracteristica`)
3. Commit tus cambios (`git commit -m 'Agregada nueva característica'`)
4. Push a la rama (`git push origin feature/NuevaCaracteristica`)
5. Abre un Pull Request

## 📝 Licencia
Este proyecto está bajo la licencia MIT. Ver el archivo `LICENSE` para más detalles.

## ✍️ Autor
- Javier Elgueta
- Email: javier.elgueta.masias@gmail.com

## 📞 Soporte
Para soporte y consultas:
- Email: javier.elgueta.masias@gmail.com
- Issues: https://github.com/JavierHEM/RestaurantManager/issues

---
⌨️ con ❤️ por Javier Elgueta
```

