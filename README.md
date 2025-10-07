# Practica-6-Parcial-DESARROLLO-ARQUITECTURA-SOFTWARE-

# 🏭 Sistema de Producción y Stock  
**Parcial de Desarrollo y Arquitectura de Software**  

Este proyecto consiste en desarrollar una **aplicación de escritorio en C# Windows Forms** conectada a **SQL Server**, aplicando **arquitectura en capas (DAL, BLL, UI)** y trabajando con **DataSet** en modo desconectado.  

El objetivo es gestionar **materias primas**, **productos terminados**, **órdenes de producción** y **proveedores**, con validaciones de stock, transacciones y reportes dinámicos.

---

## 📋 Requisitos Funcionales

### 1. Base de Datos
Se deben crear las siguientes tablas:

**TABLA: PROVEEDOR**  
| Campo           | Tipo de dato         | Descripción                   |
|----------------|-------------------|-----------------------------|
| ID_PROVEEDOR   | INT PK IDENTITY   | Identificador del proveedor |
| NOMBRE         | VARCHAR(100)      | Nombre del proveedor        |
| TELEFONO       | VARCHAR(20)       | Teléfono de contacto        |
| EMAIL          | VARCHAR(100)      | Email de contacto           |

**TABLA: MATERIA_PRIMA**  
| Campo           | Tipo de dato         | Descripción                                |
|----------------|-------------------|------------------------------------------|
| ID_MATERIA     | INT PK IDENTITY   | Identificador de la materia prima        |
| NOMBRE         | VARCHAR(100)      | Nombre de la materia prima               |
| STOCK_ACTUAL   | INT               | Cantidad en almacén                      |
| COSTO_UNITARIO | DECIMAL(18,2)     | Costo por unidad                         |
| ID_PROVEEDOR   | INT FK           | Referencia al proveedor principal        |

**TABLA: PRODUCTO**  
| Campo           | Tipo de dato         | Descripción                              |
|----------------|-------------------|----------------------------------------|
| CODIGO_PROD    | VARCHAR(50) PK   | Código único del producto              |
| NOMBRE         | VARCHAR(100)    | Nombre del producto                    |
| PRECIO_VENTA   | DECIMAL(18,2)   | Precio de venta                        |
| STOCK_ACTUAL   | INT             | Stock actual en almacén                |

**TABLA: ORDEN_PRODUCCION**  
| Campo           | Tipo de dato         | Descripción                              |
|----------------|-------------------|----------------------------------------|
| ID_ORDEN       | INT PK IDENTITY   | Identificador de la orden              |
| FECHA_ORDEN    | DATETIME         | Fecha de creación de la orden          |
| CODIGO_PROD    | VARCHAR(50) FK   | Producto a fabricar                    |
| CANTIDAD_PROD  | INT             | Cantidad a producir                    |

**TABLA: ORDEN_DETALLE**  
| Campo           | Tipo de dato       | Descripción                                     |
|----------------|-----------------|-----------------------------------------------|
| ID_DETALLE     | INT PK IDENTITY | Identificador único del detalle                |
| ID_ORDEN       | INT FK         | Referencia a la orden de producción           |
| ID_MATERIA     | INT FK         | Materia prima utilizada                        |
| CANTIDAD_USADA | INT           | Cantidad de materia prima consumida en la orden|

---

### 2. Reglas de Negocio

1. **Validación de Stock:**  
   - Antes de crear una orden, verificar que haya stock suficiente de todas las materias primas necesarias.  
   - Si alguna no alcanza, cancelar la operación y mostrar un mensaje de error.

2. **Transacción de Producción:**  
   - Al confirmar la orden:  
     - Descontar el stock de materias primas.  
     - Aumentar el stock del producto terminado.  
   - Si alguna operación falla, hacer `ROLLBACK`.

3. **Cálculos en Memoria:**  
   - `COSTO_TOTAL_ORDEN` = ∑ (CANTIDAD_USADA × COSTO_UNITARIO)  
   - `GANANCIA_ESTIMADA` = (PRECIO_VENTA × CANTIDAD_PROD) – COSTO_TOTAL_ORDEN  
   - Mostrar estas columnas calculadas en el **DataGridView** sin guardarlas en la BD.

4. **CRUD Completo:**  
   - **Proveedores** (crear, editar, eliminar, listar).  
   - **Materias primas** (CRUD + filtro por proveedor + filtro por stock bajo).  
   - **Productos terminados** (CRUD + margen de ganancia estimado en %).  

---

### 3. Funcionalidades de la Aplicación

#### 🟢 Pantalla de Materias Primas
- CRUD completo.
- Filtrar por nombre (LIKE) o stock menor a X.
- Mostrar el nombre del proveedor asociado.

#### 🟢 Pantalla de Productos Terminados
- CRUD completo.
- Mostrar en una columna calculada el margen de ganancia promedio.
- Ordenar por precio de venta ascendente/descendente.

#### 🟢 Pantalla de Órdenes de Producción
- Crear orden seleccionando:
  - Producto a fabricar.
  - Cantidad.
  - Materias primas requeridas (con validación de stock).
- Mostrar en grilla:
  - FECHA_ORDEN
  - PRODUCTO
  - CANTIDAD_PROD
  - COSTO_TOTAL_ORDEN (calculado en memoria)
  - GANANCIA_ESTIMADA (calculada en memoria)

#### 🟢 Reportes
- Filtro por rango de fechas.
- Filtro por producto específico.
- Exportar resultados a **Excel o CSV**.

---

### 4. Procedimientos Almacenados

- **SP_PROVEEDOR_CRUD** → Inserta, actualiza o elimina proveedor (según parámetro `@ACCION`).  
- **SP_MATERIA_CRUD** → Inserta/actualiza/elimina materias primas con validación de proveedor.  
- **SP_PRODUCTO_CRUD** → Inserta/actualiza/elimina productos terminados.  
- **SP_CREAR_ORDEN_PRODUCCION** → Inserta orden, detalles y actualiza stock en transacción.  
- **SP_LISTAR_ORDENES** → Devuelve todas las órdenes y sus detalles.

---

### 5. Casos de Prueba Iniciales

**Proveedores:**  

| ID_PROVEEDOR | NOMBRE       | TELEFONO  | EMAIL                |
|-------------|-------------|----------|--------------------|
| 1           | Aceros SRL  | 123456   | ventas@aceros.com |
| 2           | PinturColor | 654321   | info@pcolor.com   |

**Materias Primas:**  

| ID_MATERIA | NOMBRE        | STOCK_ACTUAL | COSTO_UNITARIO | ID_PROVEEDOR |
|-----------|--------------|-------------|--------------|-------------|
| 1         | Acero        | 100         | 50.00        | 1           |
| 2         | Tornillos    | 500         | 0.50         | 1           |
| 3         | Pintura Azul | 20          | 15.00        | 2           |

**Productos:**  

| CODIGO_PROD | NOMBRE       | PRECIO_VENTA | STOCK_ACTUAL |
|-------------|-------------|-------------|-------------|
| P-100       | Bicicleta   | 250.00      | 10          |
| P-200       | Silla Metal | 120.00      | 5           |

---

### 🚀 Extras (Opcional)

- Sistema de **alertas visuales** (ej. pintar filas en rojo si el stock < 10).
- Registro de **log de auditoría** (qué usuario creó/modificó cada orden).

---

## 🎯 Objetivo
Implementar este sistema aplicando buenas prácticas de arquitectura en capas, validaciones en la **BLL**, acceso a datos seguro en la **DAL** y una interfaz de usuario intuitiva en **WinForms**, con reportes dinámicos y cálculos en memoria.

---
