# Sistema de Gestión de Notas Académicas

Aplicación de escritorio desarrollada en C# para la gestión de notas académicas de estudiantes.
El sistema permite registrar estudiantes, profesores, materias y notas, facilitando el control y consulta de información académica dentro de una institución educativa.

# 📝 Descripción del problema

Muchas instituciones educativas necesitan llevar un control organizado de las notas, materias y estudiantes.
Realizar este proceso manualmente puede generar errores, pérdida de información y dificultad al momento de consultar promedios o reportes académicos.

Este proyecto busca solucionar ese problema mediante una aplicación de escritorio que permita administrar la información académica de forma sencilla, organizada y validada.

# Integrantes del equipo
| :bust_in_silhouette: Nombre | :briefcase: Rol | :pushpin: Responsabilidades |
|---|---|---|
| Jean Pierre Valencia Velez | Líder técnico | Arquitectura, modelo de clases y lógica |
| Alejandro Rodriguez Ochoa | Desarrollo GUI | Formularios, interfaz gráfica y eventos |
| Valentina Mosquera  | Documentación | README, UML y pruebas |

# :gear: Tecnologías y versiones utilizadas

- C#
- .NET 10.0.300 
- Windows Forms
- Visual Studio code 2022
- GitHub
- Draw.io

# :computer: Requisitos previos para ejecutar el proyecto

Antes de ejecutar el proyecto se necesita:

- Tener instalado Visual Studio 2022
- Tener instalado .NET SDK 10.0.300
- Tener Git instalado
- Sistema operativo Windows

# :rocket: Instalación y ejecución

## Clonar el repositorio

```bash
git clone https://github.com/Krawelld/Poyecto_Notas_Academicas.git
```

## Entrar a la carpeta del proyecto

```bash
cd Poyecto_Notas_Academicas
```

## Restaurar dependencias

```bash
dotnet restore
```

---

# :arrow_forward: Ejecutar el proyecto

## Opción 1: Visual Studio

1. Abrir el archivo `.sln`
2. Presionar el botón **Start** o **Iniciar**

## Opción 2: Terminal

```bash
dotnet run
```
# :framed_picture: Capturas de pantalla

## :house: Menú principal



---

## :student: Registro de estudiantes



---

## :memo: Registro de notas




# :brain: Arquitectura y diagramas UML

## Arquitectura del sistema

- Modelo
- Vista
- Servicios
- Utilidades

---

## :chart_with_upwards_trend: Diagrama UML

<p align="center">
  <img src="Diagramas/UML.png" width="900">
</p>


# :white_check_mark: Funcionalidades implementadas

-  Registro de estudiantes
-  Registro de profesores
-  Registro de materias
-  Registro de notas
-  Cálculo de promedios
-  Validaciones
-  Búsqueda de estudiantes
-  Eliminación de registros

# :lock: Limitaciones conocidas

- No utiliza base de datos.
- No guarda datos al cerrar.
- Solo funciona en Windows.
- No tiene autenticación.

# :crystal_ball: Mejoras futuras

- Implementar SQL Server.
- Exportar reportes PDF.
- Agregar inicio de sesión.
- Mejorar la interfaz gráfica.
- Generar estadísticas académicas.

