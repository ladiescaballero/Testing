
🧵 < Paginas


🧵 <Paginas 25 


🧵 <Paginas 24 >

    -- 4 Fundamentos de SQL
    -- Habilidades y conceptos clave
    -- Entienda las bases de datos relacionales


🧵 <Paginas 23 >

    -- Capítulo 1
    -- Introducción a las 
    -- bases de datos 
    -- relacionales y a SQL

🧵 <Paginas 21 >

    -- Parte I
    -- Bases de datos 
    -- relacionales y SQL

🧵 <Paginas 18 >

    -- Contenido de cada capítulo
    -- Pregunte al experto
    -- Autoexamen
    -- Sintaxis SQL

🧵 <Paginas 17 >

    -- Capítulo 13: Crear rutinas invocadas por SQL
    -- Capítulo 14: Crear activadores SQL
    -- Capítulo 15: Utilizar cursores SQL
    -- Capítulo 16: Manejar transacciones SQL 
    -- Capítulo 17: Acceder a datos SQL desde un programa host 
    -- Capítulo 18: Trabajar con datos XML
    -- PARTE IV Apéndices
    -- Apéndice A: Respuestas a los autoexámenes
    -- Apéndice B: Palabras clave de SQL:2006
    -- Apéndice C: Código SQL utilizado en los ejercicios Pruebe esto

🧵 <Paginas 16 >

-- Capítulo 6: Gestión de seguridad en la base de datos
-- PARTE II Acceso y modificación de datos
-- Capítulo 7: Consulta de datos de SQL
-- Capítulo 8: Modificar datos SQL
-- Capítulo 9: Utilizar predicados
-- Capítulo 10: Trabajar con funciones y expresiones de valor
-- Capítulo 11: Acceder a múltiples tablas
-- Capítulo 12: Utilizar subconsultas para acceder y modificar datos
-- PARTE III Acceso avanzado a los datos


🧵 <Paginas 15 >

    -- PARTE I: Bases de datos relacionales y SQL 
    -- Capítulo 1: Introducción a las bases de datos relacionales y a SQL
    -- Capítulo 2: Trabajo con el entorno SQL
    -- Capítulo 3: Creación y modificación de tablas
    -- Capítulo 4: Implementación de la integridad de datos 
    -- Capítulo 5: Creación de vistas en SQL

🧵 <Paginas 7 >

    -- Contenido

🧵 <Paginas 1 >
fundamentos_de_sql_3edi_oppel.pdf

I N C O M P L E T O


🧨 <Paginas 57 >

	-- Diseño de bases de datos distribuidas
	-- Diseño físico de bases de datos
	-- Diseño conceptual robusto en grandes proyectos

🧨 <Paginas 56 >

	-- FIGURA 2.4 
	-- ERD parcial del sistema de préstamos a 
	-- estudiantes

	-- Diseño lógico de bases de datos

	-- FIGURA 2.5 
	-- Conversión 
	-- de la figura 2.4


Create table Students(
Stdno Interger NOT NULL,
StdName Char(50),
....
Primary key(StdNo))

Create table Loan(
LoanNo integer not null , 
loanAmt decimal(10,2),
StdNo integer Not null,
.....
primary Key(LoanNo),
foreign key(StdNo) REFERENCES Students)

🧨 <Paginas 55 >

	-- FIGURA 2.3 
	-- Fases del desarrollo 
	-- de bases de datos

	-- 2.3.1 Fases del desarrollo de base de datos

🧨 <Paginas 54 >

	-- TABLA 2.1 
	-- Características comunes de la calidad de 
	-- datos
	-- 2.2.4 En busca de la implementación eficiente
	-- 2.3 Proceso de desarrollo de la base de datos

❗🧨 <Paginas 53 >
	
	❗ "Agregar Comentarios" en lector PDF en cada parte del Encabezado. Para copiar tanto en el visual studio , Como en el PDF. De esta forma se hace mas practico. sin tener que cambiar las pestañas......
	-- 2.2.1 Desarrollar un vocabulario común 
	-- 2.2.2 Definición del significado de los datos
	-- 2.2.3 Asegurar la calidad de los datos

🧨 <Paginas 52 >

    -- 2.2 Objetivos del desarrollo de base de datos

🧨 <Paginas 51 >

    -- FIGURA 2.2 
    -- Ciclo de vida tradicional del desarrollo 
    -- de sistemas

    -- 2.1.2 Proceso del desarrollo de sistemas de información

🧨 <Paginas 50 >

    -- 2.1.1 Componentes de los sistemas de información 
    -- FIGURA 2.1 Panorama del sistema de procesamiento de préstamos a estudiantes

🧨 <Paginas 49 >

    -- Introducción al desarrollo 
    -- de bases de datos

    -- Panorama general
    -- 2.1 Sistemas de información


🧨 <Paginas 48 > 
🧨 <Paginas 47 > 


🧨 <Paginas 46 > 

    -- Reflexión 
    -- final

    -- Revisión de 
    -- conceptos

🧨 <Paginas 45 > 

    -- 1.5.2 Administración de recursos de información
    -- administrador de 
    -- datos 
    -- una posición gerencial 
    -- que realiza la planeación 
    -- y establece las políticas 
    -- para los recursos de 
    -- información de una organización.

    -- FIGURA 1.15 Ubicación en el organigrama de los administradores de datos y de bases de datos

🧨 <Paginas 44 > 

    -- FIGURA 1.14 
    -- Clasificación de roles

    -- TABLA 1.5 
    -- Responsabilidades 
    -- del administrador 
    -- de base de datos

    -- administrador de 
    -- base de datos 
    -- una posición de apoyo 
    -- que se especializa en la 
    -- administración de bases 
    -- de datos individuales y 
    -- DBMS.

🧨 <Paginas 43 > 

	--  FIGURA 1.13 
	--  Arreglos típicos de 
	--  cliente-servidor entre 
	--  una base de datos y el 
	--  software  
	 
    -- 1.5 Impactos organizacionales de la tecnología de base de datos

    -- 1.5.1 Interactuando con las bases de datos


🧨 <Paginas 42 > 

	--  TABLA 1.4 
	--  Ejemplo de la base 
	--  de datos de la universidad que ilustra las 
	--  diferencias entre los 
	--  niveles de esquema  

	--  1.4.2 Procesamiento distribuido y la arquitectura 
	--  cliente-servidor

	--  arquitectura 
	--  cliente-servidor
	--  un arreglo de componentes (clientes y 
	--  servidores) y datos 
	--  entre computadoras 
	--  conectadas a una red. 
	--  La arquitectura clienteservidor soporta el procesamiento eficiente de 
	--  mensajes (solicitudes de 
	--  servicio) entre los clientes y los servidores.

🧨 <Paginas 41 > 

	--  FIGURA 1.12 
	--  Arquitectura de los 
	--  tres esquemas  

	--  independencia 
	--  de datos

	--  arquitectura de los 
	--  tres esquemas  

🧨 <Paginas 40 > 

	-- 1.4 Arquitecturas de los sistemas de administración 
	-- de bases de datos

	-- 1.4.1 Independencia de datos y la arquitectura 
	-- de los tres esquemas

🧨 <Paginas 39 > 
 
	1.3.2 El mercado actual del software de base de datos

 🧨 <Paginas 38 >

	-- TABLA 1.2
	-- Breve evolución de la 
	-- tecnología de base de 
	-- datos

	-- 1.3.1 Evolución de la tecnología de bases de datos

 🧨 <Paginas 37 >

	-- 1.2.5 Funciones de terceros
	-- Desarrollo de la tecnología de base de datos 
	-- y la estructura de mercado

 🧨 <Paginas 36 >

	--   FIGURA 1.9
	-- Forma de Microsoft 
	-- Access para asignar 
	-- cursos a un profesor 
	
	-- FIGURA 1.10 
	-- Reporte de Microsoft 
	-- Access de la carga de 
	-- trabajo de un profesor

	-- 1.2.4 Funciones de soporte para las operaciones 
	-- de base de datos
 
 🧨 <Paginas 35 >
	--   FIGURA 1.7 
	-- Ventana de diseño de 
	-- consultas de Microsoft Access   

	-- FIGURA 1.8 
	-- Resultado de ejecutar 
	-- la consulta de la 
	-- figura 1.7

	-- 1.2.3 Desarrollo de aplicaciones e interfase 
	-- del lenguaje procedural

 🧨 <Paginas 34 >
 
	 -- FIGURA 1.6 
	 -- Ventana de definición 
	 -- Entidad Relación de 
	 -- Microsoft Access

	 -- 1.2.2 Acceso no procedural
 
 🧨 <Paginas 33 >

	 -- TABLA 1.1 
	 -- Resumen de las funciones generales de 
	 -- los DBMS

	 -- FIGURA 1.4 Visualización de la Tabla Estudiante desde Microsoft Access

	 -- FIGURA 1.5
	 -- Ventana Definición 
	 -- de Tabla en Microsoft 
	 -- Access

	 -- SQL 
	 -- lenguaje estándar de 
	 -- base de datos que incluye sentencias para la 
	 -- definición, la manipulación y el control de la 
	 -- base de datos
 
 🧨 <Paginas 32 > 
	 -- FIGURA 1.3 
	 -- Ilustración de la base 
	 -- de datos simplificada 
	 -- de un hospital    
	 ....
	 -- 1.2 Características de los sistemas de administración 
	 -- de bases de datos  
	 ...
	 -- 1.2.1 Definición de base de datos    

 🧨 <Paginas 31>    
	 -- FIGURA 1.1
	 -- Ilustración simplificada de la base de 
	 -- datos universitaria
	 ....
	 -- FIGURA 1.2 
	 -- Ilustración de la base 
	 -- de datos simplificada 
	 -- del departamento de 
	 -- distribución de agua
		 ........
		 ........ 

 🧨 <Paginas 30>
	 -- 1.1 Características de la base de datos
	 ....

 🧨 <Paginas 29>
	 -- Panorama general

 🧨 <Paginas 28>
	 -- Introducción a la 
	 -- administración de base 
	 -- de datos
 🧨 <Paginas 27>
	 -- Vacio

 🧨 <Paginas 26>
	 -- Introducción 
	 -- a los ambientes 
	 -- de base de datos

 🧨 <Paginas 25> 
	 -- Glosario

 🧨 <Paginas 24> 
	 -- Glosario

 🧨 <Paginas 23> 
	 -- Glosario

 🧨 <Paginas 22>
	 -- Glosario

 🧨 <Paginas 21>
	 -- Glosario

 🧨 <Paginas 20>
	 -- Contenido breve
	 -- Glosario














