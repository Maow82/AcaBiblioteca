
# ACA -- Programación Avanzada

# Sistema de Gestión de Biblioteca

------------------------------------------------------------------------

## PORTADA

**\[Corporación Unificada Nacional de Educación Superior CUN\]**

**\[Facultad de Ingeniería / PROGRAMACION AVANZADA 54463\]**

### ACA -- Programación Avanzada

### Sistema de Gestión de Biblioteca

**Presentado por:**\
\[Mauricio Zarate Saavedra\]

**Docente:**\
\[Veronica Castro Munar\]

**Fecha:**\
\[Bogota, 08, Noviembre 2026\]

------------------------------------------------------------------------
# CONTRAPORTADA

**Sistema de Gestión de Biblioteca**

Proyecto desarrollado como evidencia del curso de **Programación
Avanzada**, aplicando Programación Orientada a Objetos, base de datos
relacional, arquitectura por capas, operaciones CRUD, validaciones,
manejo de excepciones y conexión con SQL Server.

**Estudiante(s):** \[Mauricio Zarate Saavedra\]\
**Programa:** \[Facultad de Ingeniería PROGRAMACION AVANZADA\]\
**Grupo:** \[54463\]\
**Docente:** \[Veronica Castro Munar\]\
**Institución:** \[Corporación Unificada Nacional de Educación Superior CUN\]\
**Año:** \[2026\]

------------------------------------------------------------------------

# TABLA DE CONTENIDO

> **Nota:** Actualizar esta sección al finalizar el documento, de
> acuerdo con la numeración real de las páginas.

1.  Introducción
2.  Objetivos
    -   2.1 Objetivo general
    -   2.2 Objetivos específicos
3.  Planteamiento del problema
4.  Análisis de requerimientos
5.  Casos de uso
6.  Diagrama de clases
7.  Modelo entidad-relación
8.  Diccionario de datos
9.  Arquitectura del sistema
10. Explicación de los módulos desarrollados
11. Capturas de pantalla del sistema
12. Pruebas de funcionamiento
13. Conclusiones
14. Recomendaciones
15. Referencias bibliográficas

------------------------------------------------------------------------

 1. INTRODUCCIÓN

 El presente documento describe el desarrollo de **AcaBiblioteca**, un sistema de gestión para una biblioteca universitaria, cuyo propósito es facilitar la organización y administración de la información relacionada con los libros y los recursos bibliográficos.

El sistema se desarrolla utilizando **Python**, aplicando principios de Programación Orientada a Objetos (POO) para estructurar el código y facilitar el mantenimiento de la aplicación. Actualmente, la base de datos cuenta con sus tablas creadas y se avanza en la configuración de la interfaz gráfica que permitirá la interacción entre el usuario y el sistema.

El proyecto busca integrar la interfaz gráfica con la base de datos para facilitar la consulta y administración de la información bibliográfica, de acuerdo con las funcionalidades definidas e implementadas durante su desarrollo.

------------------------------------------------------------------------
# 2. OBJETIVOS

## 2.1 Objetivo general

Desarrollar AcaBiblioteca, un sistema de gestión de biblioteca universitaria utilizando Python y Programación Orientada a Objetos (POO), que permita organizar y administrar la información bibliográfica mediante una interfaz gráfica integrada con una base de datos relacional, facilitando la consulta y gestión de la información.

## 2.2 Objetivos específicos

- Diseñar y desarrollar una interfaz gráfica que facilite la interacción del usuario con el sistema AcaBiblioteca.
- Aplicar los principios de Programación Orientada a Objetos para organizar el código y estructurar los componentes de la aplicación.
- Diseñar y utilizar una base de datos relacional para almacenar y organizar la información del sistema.
- Integrar la interfaz gráfica con la base de datos para permitir la gestión de la información bibliográfica.
- Implementar operaciones de creación, consulta, actualización y eliminación de registros (CRUD), de acuerdo con las funcionalidades        definidas para el proyecto.
- Incorporar validaciones de datos y manejo de excepciones para contribuir al funcionamiento adecuado de la aplicación.
- Utilizar Git y GitHub para llevar el control de versiones y registrar los avances del desarrollo.
- Documentar el proceso de desarrollo, las herramientas utilizadas y las funcionalidades implementadas en el proyecto.

# 3. PLANTEAMIENTO DEL PROBLEMA

## 3.1 Descripción del problema

La administración de una biblioteca requiere mantener organizada y actualizada la información relacionada con los libros, autores, editoriales, usuarios y préstamos. Cuando estos procesos se realizan de manera manual o mediante herramientas que no están integradas, pueden presentarse dificultades para consultar los registros, controlar los préstamos y devoluciones, identificar la disponibilidad de los libros y mantener la integridad de la información.

Por esta razón, se propone desarrollar un Sistema de Gestión de Biblioteca mediante C#, Windows Forms y SQL Server, que permita centralizar la información, facilitar las operaciones de registro, consulta, actualización y eliminación de datos, gestionar los préstamos y devoluciones, y generar reportes que contribuyan a una administración más organizada y eficiente de la biblioteca.

## 3.2 Justificación

El desarrollo del Sistema de Gestión de Biblioteca es importante porque permitirá mejorar la organización, administración y consulta de la información bibliográfica y de los usuarios. Mediante una aplicación de escritorio conectada a una base de datos SQL Server, se busca facilitar el control de los libros, autores, editoriales, usuarios, préstamos y devoluciones.

La implementación del sistema proporcionará beneficios como la reducción de errores en el registro de información, la consulta más rápida de los datos, el seguimiento del estado de los préstamos y la generación de reportes que apoyen la toma de decisiones. Asimismo, permitirá mantener la integridad y consistencia de la información mediante validaciones y relaciones entre las entidades de la base de datos.

Desde el ámbito académico, este proyecto permitirá aplicar los conocimientos adquiridos en Programación Avanzada, especialmente en Programación Orientada a Objetos, diseño de bases de datos relacionales, arquitectura por capas, manejo de excepciones y control de versiones con Git y GitHub.

## 3.3 Alcance

El Sistema de Gestión de Biblioteca permitirá administrar de manera organizada la información bibliográfica, los usuarios y los procesos de préstamos y devoluciones, mediante una aplicación de escritorio desarrollada en C# con Windows Forms y SQL Server.

El sistema permitirá:

- Gestionar libros mediante operaciones de registro, consulta, actualización y eliminación.

- Gestionar autores y consultar su información.

- Gestionar editoriales y administrar sus registros.

- Gestionar usuarios de la biblioteca.

- Relacionar los libros con sus respectivos autores y editoriales.

- Registrar y consultar préstamos asociados a libros y usuarios.

- Registrar devoluciones y actualizar el estado de los préstamos.

- Consultar la disponibilidad de los libros, si se implementa el control de existencias.

- Consultar el historial de préstamos y los estados de los registros.

- Generar reportes con información de libros, autores, editoriales, usuarios y préstamos, según las funcionalidades implementadas.

- Validar la información ingresada y mantener la integridad de los datos.

- Facilitar la navegación entre los módulos mediante un formulario principal.

### Fuera del alcance

Para esta versión del Sistema de Gestión de Biblioteca, no se contempla el desarrollo de las siguientes funcionalidades:

- Desarrollo de una aplicación móvil para consultar o administrar la biblioteca.
- Desarrollo de una plataforma web para acceder al sistema de manera remota.

## 4. ANÁLISIS DE REQUERIMIENTOS

## 4.1 Descripción general

El Sistema de Gestión de Biblioteca permitirá administrar la información relacionada con los libros, autores, editoriales y usuarios de la biblioteca, así como controlar los procesos de registro y consulta de préstamos, devoluciones y disponibilidad de los libros.

La aplicación permitirá registrar, consultar, actualizar y eliminar información de acuerdo con las funcionalidades disponibles y las restricciones de integridad de la base de datos. Asimismo, facilitará la consulta del historial y del estado de los préstamos, y la generación de reportes para apoyar la administración de la biblioteca.

El sistema será desarrollado como una aplicación de escritorio utilizando C#, Windows Forms y SQL Server, aplicando principios de Programación Orientada a Objetos y una organización que diferencie la presentación, la lógica de negocio y el acceso a datos.

## 4.2 Actores del sistema

# Actor :    
Bibliotecario / Administrador   
  
# Descripción:

Es el responsable de utilizar el sistema para registrar, consultar, actualizar y eliminar información  de libros, autores, editoriales y usuarios. También gestiona los préstamos y devoluciones, consulta el estado de los préstamos y genera los reportes disponibles.

> 