
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

### Actor :    
Bibliotecario / Administrador   
  
### Descripción:

Es el responsable de utilizar el sistema para registrar, consultar, actualizar y eliminar información  de libros, autores, editoriales y usuarios. También gestiona los préstamos y devoluciones, consulta el estado de los préstamos y genera los reportes disponibles.

## 4.3 Requerimientos funcionales

### RF01. Gestionar libros

El sistema permitirá registrar, consultar, actualizar, eliminar y buscar libros, incluyendo su información bibliográfica y las relaciones con autores y editoriales.

### RF02. Gestionar autores

El sistema permitirá registrar, consultar, actualizar y eliminar autores, respetando las relaciones existentes con los libros.

### RF03. Gestionar editoriales

El sistema permitirá registrar, consultar, actualizar y eliminar editoriales, respetando las restricciones de integridad de la base de datos.

### RF04. Gestionar usuarios

El sistema permitirá registrar, consultar, actualizar y eliminar usuarios de la biblioteca, almacenando sus datos personales y de contacto.

### RF05. Registrar préstamos

El sistema permitirá registrar préstamos asociando un libro con un usuario, almacenar la fecha del préstamo y consultar los registros realizados.

### RF06. Registrar devoluciones

El sistema permitirá registrar la devolución de un libro, actualizar la fecha de devolución y cambiar el estado del préstamo a "Devuelto".

### RF07. Realizar consultas y reportes

El sistema permitirá consultar libros, autores, editoriales, usuarios y préstamos, incluyendo préstamos activos, devueltos e historial de préstamos.

### RF08. Navegación del sistema

El sistema contará con un formulario principal que permitirá acceder de manera organizada a los módulos de inicio, libros, usuarios, autores, editoriales, préstamos y reportes.

## 4.4 Requerimientos no funcionales

### RNF01. Usabilidad

La interfaz gráfica debe ser clara, organizada y fácil de utilizar, facilitando la navegación entre los diferentes módulos del sistema.

### RNF02. Validación

El sistema debe validar la información ingresada por el usuario, verificando los campos obligatorios, formatos y tipos de datos antes de almacenar los registros.

### RNF03. Mantenibilidad

El código fuente debe estar organizado y utilizar nombres descriptivos para clases, métodos, variables y controles, facilitando su comprensión y mantenimiento.

### RNF04. Organización del código

El sistema debe mantener una separación entre los formularios de presentación y las operaciones de conexión y acceso a la base de datos.

### RNF05. Manejo de excepciones

Las operaciones deben manejar los errores de forma controlada, mostrando mensajes claros al usuario y evitando interrupciones inesperadas.

### RNF06. Integridad de datos

La información debe mantenerse consistente en la base de datos mediante claves primarias, claves foráneas y restricciones de integridad.

### RNF07. Consultas parametrizadas

Las consultas y operaciones de acceso a SQL Server deben utilizar parámetros para enviar los valores ingresados por el usuario de manera segura.

### RNF08. Conexión con SQL Server

La aplicación debe establecer una conexión adecuada con SQL Server para realizar las operaciones de registro, consulta, actualización y eliminación de información.

# 4.5 Reglas de negocio

### RN01 -- Código único del libro

No se permitirá registrar dos libros con el mismo código o ISBN, garantizando la identificación única de cada libro.

### RN02 -- Datos obligatorios

No se permitirá almacenar registros con campos obligatorios vacíos.

### RN03 -- Usuario existente

No se podrá registrar un préstamo para un usuario que no exista en la base de datos.

### RN04 -- Libro existente

No se podrá registrar un préstamo para un libro que no exista en la base de datos.

### RN05 -- Disponibilidad

No se podrá prestar un libro cuando no existan ejemplares disponibles, si el sistema implementa el control de existencias.

### RN06 -- Actualización de disponibilidad

Al registrar un préstamo, las existencias o disponibilidad del libro deberán actualizarse, si esta funcionalidad está implementada.

### RN07 -- Devolución

Al registrar una devolución, el sistema deberá actualizar la fecha de devolución y cambiar el estado del préstamo a "Devuelto". La disponibilidad del libro deberá actualizarse cuando se implemente el control de existencias.

### RN08 -- Multa

El cálculo de multas por retraso en la devolución no forma parte de los requerimientos obligatorios establecidos en la guía y solo se contemplará si se implementa esta funcionalidad.

### RN09 -- Integridad de los registros

No se permitirá eliminar libros, autores, editoriales o usuarios cuando existan relaciones o préstamos asociados que impidan su eliminación según las restricciones de integridad de la base de datos.

# 5. CASOS DE USO

## 5.1 Descripción

Los casos de uso permiten representar las diferentes interacciones entre el Bibliotecario / Administrador y las funcionalidades principales del Sistema de Gestión de Biblioteca.

A través de la aplicación, el usuario podrá gestionar la información de los libros, registrar préstamos, controlar las devoluciones y consultar los registros almacenados en la base de datos.

Cada caso de uso describe las actividades que realiza el usuario, las respuestas del sistema y las condiciones necesarias para ejecutar correctamente cada operación.

## 5.2 Diagrama de casos de uso

A continuación, se presenta el diagrama de casos de uso del Sistema de Gestión de Biblioteca, donde se representan las funcionalidades principales y la interacción del Bibliotecario / Administrador con los diferentes módulos de la aplicación.

**Archivo sugerido:**

![Diagrama de casos de uso](ruta/al/diagrama-casos-uso.png)

## 5.3 Descripción de casos de uso

### CU01 -- Gestionar libros

**Actor principal:** Bibliotecario / Administrador.

**Descripción:** Permite registrar, consultar, actualizar, eliminar y buscar libros, administrando su información bibliográfica y las relaciones con autores y editoriales.

**Precondiciones:**

- El usuario debe tener acceso al sistema.
- La aplicación debe estar conectada a la base de datos SQL Server.
- Los autores y editoriales asociados deben estar registrados previamente.

**Flujo principal:**

1. El actor ingresa al módulo de libros.
2. El sistema muestra el formulario de gestión de libros.
3. El actor selecciona la operación que desea realizar.
4. El actor ingresa o selecciona la información correspondiente.
5. El sistema valida los datos ingresados.
6. El sistema ejecuta la operación solicitada.
7. El sistema muestra un mensaje con el resultado de la operación.

**Flujos alternativos:**

- Si existen campos obligatorios vacíos, el sistema solicita completar la información.
- Si el ISBN ya se encuentra registrado, el sistema informa que el libro existe.
- Si los datos ingresados no cumplen las validaciones, el sistema muestra un mensaje de error.
- Si ocurre un problema de conexión con SQL Server, el sistema informa que no fue posible completar la operación.

**Postcondiciones:**

- El libro queda registrado, actualizado o eliminado según la operación realizada.
- La información puede consultarse posteriormente en el módulo de libros.
- Se mantienen las relaciones correspondientes con autores y editoriales.

---

### CU02 -- Registrar préstamo

**Actor principal:** Bibliotecario / Administrador.

**Descripción:** Permite registrar el préstamo de un libro a un usuario de la biblioteca, almacenando la información correspondiente y controlando el estado del préstamo.

**Precondiciones:**

- El usuario debe estar registrado en la base de datos.
- El libro debe estar registrado en la base de datos.
- Debe existir disponibilidad del libro, si el sistema controla las existencias.
- La aplicación debe tener conexión con SQL Server.

**Flujo principal:**

1. El actor ingresa al módulo de préstamos.
2. El sistema muestra el formulario de registro de préstamos.
3. El actor selecciona el usuario correspondiente.
4. El actor selecciona el libro que desea prestar.
5. El sistema verifica que el usuario y el libro existan.
6. El sistema verifica la disponibilidad del libro, si corresponde.
7. El actor confirma el registro del préstamo.
8. El sistema almacena la información del préstamo.
9. El sistema muestra un mensaje de confirmación.

**Flujos alternativos:**

- Si el usuario no está registrado, el sistema informa que no existe.
- Si el libro no está registrado, el sistema informa que no existe.
- Si no hay ejemplares disponibles, el sistema impide realizar el préstamo, cuando se controla la disponibilidad.
- Si ocurre un error durante el registro, el sistema muestra un mensaje indicando que la operación no pudo completarse.

**Postcondiciones:**

- El préstamo queda registrado en la base de datos.
- El préstamo queda asociado al usuario y al libro correspondiente.
- La disponibilidad del libro se actualiza si esta funcionalidad está implementada.

---

### CU03 -- Registrar devolución

**Actor principal:** Bibliotecario / Administrador.

**Descripción:** Permite registrar la devolución de un libro previamente prestado, actualizar la información del préstamo y modificar su estado a devuelto.

**Precondiciones:**

- El usuario debe tener acceso al sistema.
- Debe existir un préstamo registrado.
- El préstamo debe encontrarse en estado activo o pendiente de devolución.
- La aplicación debe tener conexión con SQL Server.

**Flujo principal:**

1. El actor ingresa al módulo de préstamos o devoluciones.
2. El sistema muestra los préstamos registrados.
3. El actor identifica y selecciona el préstamo que desea gestionar.
4. El sistema verifica que el préstamo se encuentre pendiente de devolución.
5. El actor confirma el registro de la devolución.
6. El sistema actualiza la fecha de devolución.
7. El sistema cambia el estado del préstamo a "Devuelto".
8. El sistema actualiza la disponibilidad del libro, si corresponde.
9. El sistema muestra un mensaje de confirmación.

**Flujos alternativos:**

- Si el préstamo no existe, el sistema informa que no se encontró el registro.
- Si el préstamo ya fue devuelto, el sistema informa que no es posible registrar nuevamente la devolución.
- Si ocurre un error durante la operación, el sistema muestra un mensaje indicando que no fue posible completar el proceso.

**Postcondiciones:**

- La devolución queda registrada en la base de datos.
- La fecha de devolución queda actualizada.
- El estado del préstamo cambia a "Devuelto".
- La disponibilidad del libro se actualiza cuando el sistema controla las existencias.

# 6. DIAGRAMA DE CLASES

## 6.1 Descripción

El diagrama de clases representa la estructura del Sistema de Gestión de Biblioteca mediante las principales clases que permiten organizar y administrar la información del sistema.

Cada clase contiene atributos y métodos que representan sus características y responsabilidades dentro de la aplicación. Estas clases permiten gestionar los libros, autores, editoriales, usuarios y préstamos, manteniendo relaciones entre las diferentes entidades.

El diseño está basado en los principios de Programación Orientada a Objetos, facilitando la organización, comprensión y mantenimiento del código fuente.

## 6.2 Diagrama de clases

A continuación, se presenta el diagrama de clases del Sistema de Gestión de Biblioteca, donde se representan las principales clases, sus atributos, métodos y relaciones dentro de la aplicación.

**Archivo sugerido:**

![Diagrama de clases](ruta/al/diagrama-clases.png)

## 6.3 Principales clases

### Libro

Representa la información bibliográfica de los libros, incluyendo ISBN, título, autor, editorial, categoría, año y existencias.

### Autor

Representa los datos de los autores relacionados con los libros registrados en la biblioteca.

### Editorial

Representa la información de las editoriales responsables de las publicaciones.

### Usuario

Representa la información personal y de contacto de los usuarios que utilizan los servicios de la biblioteca.

### Prestamo

Gestiona la información relacionada con los préstamos de libros a los usuarios, incluyendo las fechas y el estado del préstamo.

### Conexion

Permite establecer y administrar la conexión entre la aplicación y la base de datos SQL Server.

### FrmLibros

Gestiona la interfaz gráfica y las operaciones disponibles para registrar, consultar, actualizar y eliminar libros.

### FrmAutores

Gestiona la interfaz gráfica para administrar la información de los autores.

### FrmEditoriales

Gestiona la interfaz gráfica para administrar la información de las editoriales.

### FrmUsuarios

Gestiona la interfaz gráfica para administrar la información de los usuarios.

### FrmPrestamos

Gestiona la interfaz gráfica para registrar y consultar los préstamos de libros.

## 6.4 Aplicación de POO

En el desarrollo del Sistema de Gestión de Biblioteca se aplican conceptos fundamentales de Programación Orientada a Objetos:

**Clases:** permiten organizar el código mediante estructuras que representan las entidades y componentes del sistema, como libros, autores, usuarios y préstamos.

**Objetos:** son las instancias de las clases que permiten trabajar con la información y ejecutar las operaciones de la aplicación.

**Constructores:** permiten inicializar los objetos y establecer sus valores iniciales cuando se crean instancias de las clases.

**Métodos:** representan las operaciones que realizan las clases, como registrar, consultar, actualizar y eliminar información.

**Propiedades:** permiten definir y acceder a los atributos de las clases, facilitando la administración de los datos.

**Encapsulamiento:** permite proteger y controlar el acceso a los atributos y métodos de las clases mediante los modificadores de acceso correspondientes.

**Colecciones:** permiten almacenar y administrar conjuntos de registros, facilitando la consulta y visualización de información dentro de la aplicación.

**Herencia:** se contempla como un mecanismo de reutilización de código cuando existe una relación entre clases que justifique su utilización.

**Polimorfismo:** se considera un concepto de profundización que permite utilizar diferentes implementaciones de métodos mediante una misma estructura de referencia.

**Sobrecarga:** permite definir varios métodos o constructores con el mismo nombre, pero con diferentes parámetros, cuando las necesidades del sistema lo requieren.

# 7. MODELO ENTIDAD-RELACIÓN

## 7.1 Descripción

El modelo entidad-relación representa la estructura de la base de datos del Sistema de Gestión de Biblioteca. Su propósito es organizar la información de manera lógica, facilitar el almacenamiento y la consulta de los datos, y establecer las relaciones entre las diferentes entidades del sistema.

La base de datos está compuesta por las entidades Libros, Autores, Editoriales, Usuarios y Préstamos. Cada entidad almacena información específica y utiliza claves primarias para identificar sus registros. Además, se emplean claves foráneas para establecer relaciones entre las tablas y mantener la integridad de la información.

## 7.2 Diagrama entidad-relación

En este apartado se presenta el diagrama entidad-relación diseñado para representar la estructura de la base de datos del sistema.

![Modelo entidad-relación](ruta/al/modelo-entidad-relacion.png)

## 7.3 Relaciones principales

Las principales relaciones entre las entidades del sistema son:

- Un autor puede estar asociado a varios libros.
- Una editorial puede publicar varios libros.
- Un usuario puede tener varios préstamos registrados.
- Un libro puede aparecer en diferentes registros de préstamos a lo largo del tiempo.
- Cada préstamo relaciona un usuario con el libro solicitado.

Estas relaciones permiten organizar la información de la biblioteca y mantener la trazabilidad de los préstamos y las devoluciones.

# 8. DICCIONARIO DE DATOS

## 8.1 Convenciones

- PK: Clave primaria.
- FK: Clave foránea.
- UQ: Campo con valor único.
- NULL: Campo que puede estar vacío.
- NOT NULL: Campo obligatorio.

## 8.2 Tabla: Autores

Descripción de los campos que componen la tabla de autores.

## 8.3 Tabla: Editoriales

Descripción de los campos que componen la tabla de editoriales.

## 8.4 Tabla: Libros

Descripción de los campos que componen la tabla de libros.

## 8.5 Tabla: Usuarios

Descripción de los campos que componen la tabla de usuarios.

## 8.6 Tabla: Prestamos

Descripción de los campos que componen la tabla de préstamos.

# 9. ARQUITECTURA DEL SISTEMA

## 9.1 Descripción general

El Sistema de Gestión de Biblioteca se desarrolla mediante una aplicación de escritorio utilizando C# y Windows Forms, conectada a una base de datos SQL Server.

El sistema organiza sus componentes para permitir la interacción del usuario, la ejecución de operaciones y el almacenamiento de la información.

Se identifican los siguientes componentes:

1. Capa de Presentación.
2. Componente de conexión y acceso a datos.
3. Capa de Base de Datos.

## 9.2 Diagrama de arquitectura

En este apartado se presenta el diagrama de arquitectura del sistema, donde se representa la interacción entre la interfaz de usuario, la conexión a datos y SQL Server.

![Arquitectura del sistema](ruta/al/diagrama-arquitectura.png)

## 9.3 Capa de Presentación

Responsabilidad:

Permite al usuario interactuar con el sistema mediante formularios, desde los cuales puede administrar la información de la biblioteca.

Componentes:

- frmInicio
- frmLibros
- frmAutores
- frmEditoriales
- frmUsuarios
- frmPrestamos

Tecnologías utilizadas:

- C#.
- Windows Forms.
- .NET.

## 9.4 Lógica de las operaciones

Responsabilidad:

Comprende las operaciones y validaciones que permiten administrar la información de la biblioteca, como registrar, consultar, modificar y eliminar registros, además de gestionar los préstamos y las devoluciones.

Estas operaciones se ejecutan desde los formularios de la aplicación.

Ejemplos de operaciones:

- Validar los campos obligatorios.
- Verificar la información ingresada.
- Registrar y actualizar libros.
- Administrar autores y editoriales.
- Registrar préstamos.
- Gestionar devoluciones.

## 9.5 Componente de Acceso a Datos

Responsabilidad:

Gestiona la conexión entre la aplicación y la base de datos SQL Server, permitiendo ejecutar las operaciones necesarias para consultar y almacenar información.

Componentes:

- Conexion.cs

Tecnologías utilizadas:

- SQL Server.
- ADO.NET.
- Consultas SQL parametrizadas.

## 9.6 Capa de Base de Datos

La información del sistema se almacena en una base de datos SQL Server, encargada de conservar los registros y las relaciones entre las entidades.

Tablas principales:

- Autores.
- Editoriales.
- Libros.
- Usuarios.
- Prestamos.

## 9.7 Flujo de información

El funcionamiento general del sistema sigue el siguiente flujo:

Usuario
  ↓
Formularios de Windows Forms
  ↓
Operaciones y validaciones
  ↓
Conexion.cs
  ↓
Base de datos SQL Server

Las respuestas de la base de datos regresan a los formularios para mostrar al usuario los resultados de las operaciones realizadas.

# 10. EXPLICACIÓN DE CADA MÓDULO DESARROLLADO

## 10.1 Módulo de libros

Objetivo:

Permitir la administración de la información bibliográfica de los libros registrados en el sistema.

Funcionalidades:

- Registrar nuevos libros.
- Consultar los libros registrados.
- Actualizar la información de los libros.
- Eliminar registros.
- Buscar libros.
- Asociar los libros con sus respectivos autores y editoriales.

Validaciones:

- Verificar que los campos obligatorios estén diligenciados.
- Validar que el ISBN y los datos ingresados cumplan con los requisitos establecidos.
- Verificar que el autor y la editorial seleccionados existan en el sistema.

## 10.2 Módulo de autores

Objetivo:

Administrar la información de los autores relacionados con los libros de la biblioteca.

Funcionalidades:

- Registrar autores.
- Consultar autores registrados.
- Actualizar información.
- Eliminar registros.

## 10.3 Módulo de editoriales

Objetivo:

Administrar la información de las editoriales asociadas a los libros registrados en la biblioteca.

Funcionalidades:

- Registrar editoriales.
- Consultar editoriales.
- Actualizar información.
- Eliminar registros.

## 10.4 Módulo de usuarios

Objetivo:

Gestionar la información personal y de contacto de los usuarios que utilizan los servicios de la biblioteca.

Funcionalidades:

- Registrar usuarios.
- Consultar usuarios registrados.
- Actualizar información.
- Eliminar registros.

## 10.5 Módulo de préstamos

Objetivo:

Gestionar el registro y seguimiento de los préstamos de libros realizados por los usuarios de la biblioteca.

Funcionalidades:

- Registrar préstamos.
- Consultar los préstamos registrados.
- Consultar el estado de los préstamos.
- Identificar los usuarios y libros asociados a cada préstamo.

## 10.6 Módulo de devoluciones

Objetivo:

Gestionar la devolución de los libros prestados y actualizar la información correspondiente al préstamo.

Funcionalidades:

- Registrar la devolución de un libro.
- Actualizar el estado del préstamo.
- Registrar la fecha de devolución.

## 10.7 Módulo de consultas

Objetivo:

Facilitar la consulta de la información almacenada en el sistema para apoyar la administración de la biblioteca.

Consultas:

- Consultar los libros registrados.
- Consultar los autores.
- Consultar las editoriales.
- Consultar los usuarios.
- Consultar los préstamos registrados.
- Consultar el estado de los préstamos.

# 11. CAPTURAS DE PANTALLA DEL SISTEMA

En esta sección se presentan las evidencias visuales del Sistema de Gestión de Biblioteca, mostrando las principales interfaces y funcionalidades desarrolladas en la aplicación.

## 11.1 Menú principal

![Menú principal](ruta/captura-menu.png)

Descripción:

Presenta la pantalla inicial del sistema y permite acceder a los diferentes módulos de gestión de la biblioteca.

## 11.2 Gestión de libros

![Gestión de libros](ruta/captura-libros.png)

Descripción:

Permite registrar, consultar, actualizar, eliminar y buscar libros, además de visualizar su información bibliográfica.

## 11.3 Gestión de autores

![Gestión de autores](ruta/captura-autores.png)

Descripción:

Permite administrar la información de los autores mediante las opciones de registro, consulta, actualización y eliminación.

## 11.4 Gestión de editoriales

![Gestión de editoriales](ruta/captura-editoriales.png)

Descripción:

Permite registrar y administrar la información de las editoriales relacionadas con los libros de la biblioteca.

## 11.5 Gestión de usuarios

![Gestión de usuarios](ruta/captura-usuarios.png)

Descripción:

Permite registrar, consultar, actualizar y eliminar la información de los usuarios de la biblioteca.

## 11.6 Registro de préstamos

![Registro de préstamos](ruta/captura-prestamos.png)

Descripción:

Permite registrar los préstamos de libros, relacionando la información del usuario con el libro solicitado.

## 11.7 Registro de devoluciones

![Registro de devoluciones](ruta/captura-devoluciones.png)

Descripción:

Permite gestionar la devolución de los libros prestados y actualizar el estado correspondiente al préstamo.

## 11.8 Consultas

![Consultas](ruta/captura-consultas.png)

Descripción:

Presenta las opciones de consulta disponibles para visualizar la información registrada en el sistema.

# 12. PRUEBAS DE FUNCIONAMIENTO

## 12.1 Estrategia de pruebas

Se realizaron pruebas funcionales en los diferentes módulos del Sistema de Gestión de Biblioteca para verificar el correcto funcionamiento de las operaciones de registro, consulta, actualización y eliminación de información.

También se comprobaron las validaciones de los formularios, la conexión con la base de datos SQL Server y las operaciones relacionadas con los préstamos y las devoluciones.

Todas las pruebas realizadas fueron exitosas, obteniendo los resultados esperados y confirmando el correcto funcionamiento del sistema.

## 12.2 Casos de prueba

Durante las pruebas se verificaron las siguientes funcionalidades:

- CP01. Registro de libros: exitoso.
- CP02. Validación de registros duplicados: exitosa.
- CP03. Registro de usuarios: exitoso.
- CP04. Registro de préstamos: exitoso.
- CP05. Validación de campos obligatorios: exitosa.
- CP06. Registro de devoluciones: exitoso.
- CP07. Consulta de libros: exitosa.
- CP08. Consulta de usuarios: exitosa.

**Resultado general:** Todos los casos de prueba fueron aprobados. Las funcionalidades evaluadas respondieron correctamente y no se presentaron inconvenientes durante las pruebas.

## 12.3 Evidencias de pruebas

Las pruebas realizadas permitieron comprobar el funcionamiento de los diferentes módulos del sistema. Todos los resultados fueron satisfactorios, confirmando que las operaciones implementadas cumplen con el comportamiento esperado.

## 12.3 Resultados de las pruebas

Las pruebas funcionales realizadas en el Sistema de Gestión de Biblioteca fueron satisfactorias. Se verificó el correcto funcionamiento de los módulos de libros, autores, editoriales, usuarios y préstamos.

Se comprobó que las operaciones de registro, consulta, actualización y eliminación funcionan correctamente, así como las validaciones de los campos obligatorios y la conexión con la base de datos SQL Server.

También se verificó el registro de préstamos y devoluciones, obteniendo los resultados esperados durante su ejecución.

En conclusión, todas las pruebas realizadas fueron aprobadas, confirmando el correcto funcionamiento de las funcionalidades desarrolladas.

# 14. RECOMENDACIONES

- Incorporar nuevas funcionalidades que permitan generar reportes estadísticos sobre los libros registrados, los préstamos realizados y las actividades de la biblioteca.

- Fortalecer la seguridad del sistema mediante la implementación de usuarios y contraseñas de acceso, así como mecanismos de protección de la información almacenada.

- Realizar mantenimiento periódico al código fuente y a la base de datos para corregir posibles errores, optimizar las consultas y garantizar el buen funcionamiento de la aplicación.

- Ampliar las funcionalidades del módulo de préstamos para incluir notificaciones de fechas de devolución próximas y seguimiento de préstamos pendientes.

- Implementar copias de seguridad periódicas de la base de datos para prevenir la pérdida de información ante posibles fallos técnicos.

# ANEXOS


## Anexo A. Repositorio GitHub

**Repositorio:** https://github.com/Maow82/AcaBiblioteca

## Anexo B. Script de base de datos

**Archivo:** AcaBiblioteca.sql

### C. Evidencia de Git y GitHub

Durante el desarrollo del proyecto AcaBiblioteca se utilizó Git para el control de versiones y GitHub para almacenar y publicar el código fuente.

### C.1 Creación del repositorio

Se creó un repositorio público en GitHub denominado AcaBiblioteca para almacenar los archivos y recursos relacionados con el proyecto.

### C.2 Commits realizados

Se realizaron diferentes commits para registrar los cambios y actualizaciones efectuados durante el desarrollo del sistema.

### C.3 Organización del proyecto

El repositorio contiene los archivos de código fuente, formularios, recursos gráficos, diagramas, documentación y archivos relacionados con la base de datos.

### C.4 Publicación del código

El código fuente y los recursos del proyecto fueron publicados en el repositorio público de GitHub, permitiendo consultar su contenido.

### C.5 Archivo README.md

Se incorporó el archivo README.md con información general del proyecto, su objetivo, las tecnologías utilizadas y los principales módulos del sistema.

# Anexo D. Otras evidencias

Se incluyen evidencias complementarias del desarrollo y funcionamiento del Sistema de Gestión de Biblioteca.

- Capturas de las interfaces principales de la aplicación.
- Evidencias de las pruebas funcionales realizadas.
- Diagrama entidad-relación y diagrama de clases.
- Diagrama de arquitectura del sistema.






# 15. REFERENCIAS BIBLIOGRÁFICAS

Microsoft. (s. f.). *Documentación de C#*. Microsoft Learn. https://learn.microsoft.com/es-es/dotnet/csharp/

Microsoft. (s. f.). *Windows Forms para .NET*. Microsoft Learn. https://learn.microsoft.com/es-es/dotnet/desktop/winforms/

Microsoft. (s. f.). *Documentación de SQL Server*. Microsoft Learn. https://learn.microsoft.com/es-es/sql/sql-server/

Microsoft. (s. f.). *Información general sobre ADO.NET*. Microsoft Learn. https://learn.microsoft.com/es-es/dotnet/framework/data/adonet/ado-net-overview

Microsoft. (s. f.). *Programación orientada a objetos (C#)*. Microsoft Learn. https://learn.microsoft.com/es-es/dotnet/csharp/fundamentals/tutorials/oop