# CRUD_NET_8
 ASP NET CORE 8

# RUN PROJECT MAC

# CREA DATABASE "Empleado"  SQL SERVER

CREATE DATABASE Empleado


# CREA LAS TABLAS
# Por temas de pruebas se comentan relaciones entre tablas.
CREATE TABLE Empresas (
    EmpresaId INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(255) NOT NULL,
    Pais NVARCHAR(255) NOT NULL
);

CREATE TABLE Sucursales (
    SucursalId INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(255) NOT NULL,
    Direccion NVARCHAR(255) NOT NULL,
    Telefono NVARCHAR(50) NOT NULL,
    EmpresaId INT,
    --FOREIGN KEY (EmpresaId) REFERENCES Empresa(EmpresaId) ON DELETE CASCADE
);

CREATE TABLE Empleados (
    EmpleadoId INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(255) NOT NULL,
    CUI NVARCHAR(50) NOT NULL,
    SucursalId INT,
    --FOREIGN KEY (SucursalId) REFERENCES Sucursal(SucursalId) ON DELETE CASCADE
);
