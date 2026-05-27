# Sistema de Gestión de Notas Académicas

Aplicación de escritorio desarrollada en C# para la gestión de notas académicas de estudiantes
El sistema permite registrar estudiantes, profesores, materias y notas, facilitando el control y consulta de información académica dentro de una institución educativo

# 📝 Descripción del problema

Muchas instituciones educativas necesitan llevar un control organizado de las notas, materias y estudiantes
Realizar este proceso manualmente puede generar errores, pérdida de información y dificultad al momento de consultar promedios o reportes académicos

Este proyecto busca solucionar ese problema mediante una aplicación de escritorio que permita administrar la información académica de forma sencilla, organizada y validada

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




# :brain: Arquitectura del sistema

El proyecto fue desarrollado utilizando una arquitectura modular basada en separación de responsabilidades, permitiendo una mejor organización del código y facilitando el mantenimiento del sistema

Cada carpeta cumple una función específica dentro de la aplicación

## :bar_chart: Diagramas

Almacena diagramas UML y recursos visuales del proyecto

- ·aqui ponga la imagen

## :file_folder: Estructura del proyecto

```text
Poyecto_Notas_Academicas/
│
├── Datos/
│   ├── Notas.json
│   └── Usuarios.json
│
├── documentos/
│   └── git.keep
│
├── modelo/
│   ├── Persona.cs
│   ├── Estudiante.cs
│   ├── Profesor.cs
│   ├── Materia.cs
│   └── Nota.cs
│
├── servicios/
│   ├── LoginServicio.cs
│   ├── NotasServicio.cs
│   ├── ProfesorServicio.cs
│   └── ServicioPersonas.cs
│
├── utilidades/
│   └── Normalizador.cs
│
├── vista/
│   # Formularios e interfaz gráfica
│
├── Programa.cs
│   # Punto de entrada principal del sistema
│
├── Notas_Academicas.csproj
│   # Configuración principal del proyecto
│
└── README.md
    # Documentación principal
```
---

# :gear: Responsabilidades de los módulos

## :floppy_disk: Datos

Contiene archivos relacionados con almacenamiento de información del sistema

Responsabilidades:
- Guardar información
- Administrar archivos de datos
- Manejar persistencia local

---

## :wastebasket: papelera

Contiene elementos descartados o archivos temporales utilizados durante el desarrollo

Responsabilidades:
- Almacenar recursos no utilizados
- Mantener respaldo temporal de archivos

---

## :page_facing_up: documentos

Contiene documentación relacionada con el proyecto

Responsabilidades:
- Manuales
- Archivos PDF
- Recursos documentales
- Evidencias del proyecto

---

## :card_index: modelo

Contiene las clases principales del sistema

Ejemplos:
- Persona
- Estudiante
- Profesor
- Materia
- Nota

Responsabilidades:
- Representar entidades académicas
- Definir atributos y métodos
- Aplicar herencia y encapsulamiento

---

## :package: objeto

Contiene objetos auxiliares y estructuras utilizadas por el sistema

Responsabilidades:
- Manejo de objetos personalizados
- Apoyo a la lógica del sistema

---

## :hammer_and_wrench: servicios

Contiene la lógica de negocio de la aplicación

Responsabilidades:
- Registrar información
- Buscar datos
- Calcular promedios
- Procesar operaciones académicas
- Validar procesos

---

## :toolbox: utilidades

Contiene funciones auxiliares reutilizables.

Responsabilidades:
- Validaciones
- Conversión de datos
- Métodos de apoyo
- Mensajes y formatos

---

# :memo: Ejemplo de uso

1. Abrir la aplicación desde Visual Studio Code o ejecutando el proyecto con `dotnet run`
2. Ingresar al módulo de estudiantes
3. Registrar un nuevo estudiante con sus datos personales
4. Registrar una materia académica
5. Asignar una nota al estudiante
6. Consultar las notas registradas en la lista del sistema
7. Buscar estudiantes por nombre o documento
8. Calcular automáticamente el promedio del estudiante
9. Eliminar o modificar registros cuando sea necesario

---

# :white_check_mark: Validaciones implementadas

- Validación de campos obligatorios
- Validación de números y caracteres inválidos
- Validación de rango permitido para notas
- Verificación de datos vacíos
- Mensajes de error comprensibles
- Confirmación antes de eliminar registros
- Restricción de entradas inválidas
- Validación de usuarios en inicio de sesión

---

# :brain: Conceptos de POO aplicados

## :package: Clases y objetos

El sistema utiliza clases para representar las entidades principales:

- Persona
- Estudiante
- Profesor
- Materia
- Nota

Cada entidad es utilizada mediante objetos dentro del sistema

---

## :lock: Encapsulamiento

Los atributos de las clases son protegidos mediante propiedades y métodos controlados para evitar modificaciones incorrectas de la información

---

## :left_right_arrow: Herencia

Las clases `Estudiante` y `Profesor` heredan características comunes de la clase `Persona`

---

## :twisted_rightwards_arrows: Polimorfismo

Se implementan métodos con comportamientos diferentes dependiendo del tipo de objeto utilizado dentro del sistema

---

## :repeat: Sobrescritura de métodos

Se utilizan métodos redefinidos para personalizar funcionalidades específicas en las clases derivadas

---

## :books: Uso de colecciones genéricas

El sistema utiliza colecciones genéricas como `List<T>` para almacenar estudiantes, profesores y notas en memoria

## :desktop_computer: vista

Contiene la interfaz gráfica desarrollada en Windows Forms

Responsabilidades:
- Formularios
- Ventanas del sistema
- Interacción con el usuario
- Captura y visualización de datos

  

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

- No utiliza base de datos
- No guarda datos al cerrar
- Solo funciona en Windows
- No tiene autenticación

# :crystal_ball: Mejoras futuras

- Implementar SQL Server
- Exportar reportes PDF
- Agregar inicio de sesión
- Mejorar la interfaz gráfica
- Generar estadísticas académicas

Herramienta utilizada: ChatGPT.

Uso principal: apoyo para la organización de la estructura general del proyecto y creación del archivo de normalización.

Solicitudes realizadas: se pidió ayuda para organizar las carpetas del proyecto, estructurar el README, mejorar la presentación del repositorio y apoyar la implementación del archivo Normalizador.cs.

Aplicación en el proyecto: se aplicaron sugerencias en README.md, estructura de carpetas y archivo Normalizador.cs.

Cambios realizados por el equipo: se ajustaron nombres de carpetas, se modificaron validaciones y se adaptó la estructura al sistema de notas académicas.

Validación: el equipo revisó manualmente el código, probó el funcionamiento de la aplicación y verificó que las validaciones y módulos funcionaran correctamente.

Responsables de revisión: integrante 1 revisó la lógica, integrante 2 verificó la interfaz gráfica e integrante 3 ajustó la documentación.

Declaración final: el equipo comprende completamente el código y la documentación entregada y puede explicar las decisiones implementadas durante la sustentación.

