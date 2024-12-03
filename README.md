# PeliculasAPI

Este es un proyecto Web API desarrollado con .NET 8. Está enfocado en la gestión de películas y utiliza varias tecnologías y extensiones que facilitan la construcción de la API. A continuación se detalla la información relevante del proyecto.

## Tecnologías y Herramientas Utilizadas

- **.NET 8** con **Web API**.
- **Entity Framework Core** para la interacción con la base de datos.
- **AutoMapper** para el mapeo de entidades.
- **Swagger** para la documentación interactiva de la API.
- **JWT (Json Web Token)** para la autenticación segura de la API.

## Paquetes y Dependencias

El proyecto cuenta con las siguientes dependencias:

1. **AutoMapper (13.0.1)**: Se utiliza para mapear entre las entidades del dominio y los modelos DTO de una manera fácil y mantenible.
2. **Microsoft.AspNetCore.Authentication.JwtBearer (8.0.11)**: Este paquete facilita la autenticación utilizando JWT (Json Web Token).
3. **Microsoft.AspNetCore.Identity.EntityFrameworkCore (8.0.11)**: Integración de Identity con Entity Framework Core para manejar la autenticación y autorización de usuarios.
4. **Microsoft.EntityFrameworkCore.SqlServer (8.0.11)**: Proveedor de Entity Framework Core para la base de datos SQL Server.
5. **Microsoft.EntityFrameworkCore.SqlServer.NetTopologySuite (8.0.11)**: Herramienta para soportar tipos espaciales (geográficos) en SQL Server.
6. **Microsoft.EntityFrameworkCore.Tools (8.0.11)**: Herramienta para la creación y manejo de migraciones de la base de datos desde la línea de comandos.
7. **Swashbuckle.AspNetCore (6.6.2)**: Se usa para generar la documentación de la API usando Swagger.

## Migraciones y Base de Datos

El proyecto tiene las migraciones necesarias para poder crear la base de datos desde cero. Si deseas crear la base de datos, asegúrate de tener configurada la cadena de conexión correcta en el archivo `appsettings.json` y luego ejecuta los siguientes comandos:

1. **Añadir migración**:

    ```bash
    Add-Migration "NombreTabla"
    ```

2. **Aplicar la migración a la base de datos**:

    ```bash
    Update-Database
    ```

Estos comandos crearán la base de datos con las tablas necesarias en base al modelo definido en el proyecto.

## Requisitos Previos

- **.NET SDK 8**: Asegúrate de tener instalada la versión 8 del SDK de .NET.
- **SQL Server**: El proyecto está configurado para utilizar SQL Server como sistema de gestión de base de datos.

## Ejecución del Proyecto

Para ejecutar el proyecto localmente, sigue estos pasos:

1. Clona el repositorio:

    ```bash
    git clone https://github.com/tuusuario/peliculasapi.git
    ```

2. Navega al directorio del proyecto:

    ```bash
    cd peliculasapi
    ```

3. Restaura las dependencias:

    ```bash
    dotnet restore
    ```

4. Aplica las migraciones a la base de datos:

    ```bash
    Update-Database
    ```

Una vez hecho esto, la API estará disponible y se podrá acceder a la documentación de Swagger en el puerto que habilites desde Program.cs

