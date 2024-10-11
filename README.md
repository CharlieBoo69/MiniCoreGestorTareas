# Gestor de Tareas

## Descripción

**Gestor de Tareas** es una aplicación web desarrollada con **ASP.NET Core** y **Entity Framework Core** que permite gestionar tareas diarias de forma eficiente. La aplicación permite a los usuarios listar tareas, filtrar tareas por rango de fechas, y calcula automáticamente si una tarea está retrasada en base a su fecha de inicio y el tiempo estimado para completarla.

Este proyecto ha sido desplegado en **Azure App Service** con una base de datos en **Azure SQL Database**.

## Características

- **Listado de Tareas:** Visualiza todas las tareas con su nombre, fecha de inicio, tiempo estimado, estado, proyecto y empleado asignado.
- **Filtrado por Fecha:** Filtra las tareas por fecha de inicio y fin.
- **Cálculo Automático de Retrasos:** Si una tarea está en progreso pero ha excedido su tiempo estimado, se muestra cuántos días de retraso tiene.
- **Interfaz Simple y Funcional:** Una interfaz fácil de usar basada en Bootstrap para una experiencia de usuario intuitiva.

## Tecnologías Utilizadas

- **Backend:**
  - ASP.NET Core (MVC)
  - Entity Framework Core (ORM)
  - SQL Server

- **Frontend:**
  - HTML5
  - CSS3
  - Bootstrap

- **Despliegue en la Nube:**
  - Azure App Service
  - Azure SQL Database

## Requisitos Previos

Para ejecutar este proyecto de forma local, necesitarás:

- **Visual Studio 2022** o superior.
- **.NET 6.0 SDK** o superior.
- **SQL Server LocalDB** o acceso a una instancia de **SQL Server**.
- **Azure CLI** si deseas realizar el despliegue en Azure.

## Configuración del Proyecto

### 1. Clona el Repositorio

```bash
git clone https://github.com/tu_usuario/gestor-de-tareas.git
```

## Recursos de referencia 
- https://youtu.be/jpshj-LiRig?si=Er9fzmCpVuOos5cQ
- https://youtu.be/dhguXv3vRIk?si=aFPw58zFihUApldx
- https://youtu.be/z1SIMSQVXGM?si=QgRYhsfEU3qh1OXy
- https://youtu.be/uNqlBNSGlRQ?si=HJKZ096N_ZElkZEQ

## Informacion de contacto
- carlos.larco.escobar@udla.edu.ec
