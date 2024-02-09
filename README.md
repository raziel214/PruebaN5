# PruebaN5
 ChallengeN5

 # ApiProducerN5

Descripción breve del proyecto, por ejemplo: "API para la gestión de permisos de losempleados, que permite registrar, actualizar, y consultar información de los diferentes modelos de datos. Integrado con Kafka para procesamiento de eventos, Elasticsearch para búsquedas optimizadas y SQL Server para almacenamiento de datos."

## Tabla de Contenidos

* [Desarrollo](#desarrollo)
* [Integraciones](#integraciones)
  * [Servicios](#servicios)
  * [Base de Datos](#base-de-datos)
  * [Elasticsearch](#elasticsearch)
  * [Kafka](#kafka)
  * [Serilog](#serilog)


## Desarrollo

Para configurar el entorno de desarrollo local para este proyecto, necesitarás instalar y configurar varias herramientas y servicios. A continuación se proporciona una guía paso a paso junto con enlaces a recursos adicionales.

### Requisitos Previos

Antes de comenzar, asegúrate de tener instaladas las siguientes herramientas y tecnologías:

- **.NET Core SDK**: Necesario para desarrollar aplicaciones .NET Core. [Descargar .NET Core SDK](https://dotnet.microsoft.com/download)

- **Docker Desktop**: Utilizado para ejecutar SQL Server, Kafka y Elasticsearch en contenedores Docker. [Instalar Docker Desktop](https://www.docker.com/products/docker-desktop)

- **Visual Studio**: IDE recomendado para el desarrollo de aplicaciones .NET Core. [Descargar Visual Studio](https://visualstudio.microsoft.com/downloads/)

- **SQL Server Express**: Se utilizará como base de datos principal del proyecto. [SQL Server en Docker](https://hub.docker.com/_/microsoft-mssql-server)

- **Elasticsearch**: Motor de búsqueda y análisis. [Ejecutar Elasticsearch con Docker](https://www.elastic.co/guide/en/elasticsearch/reference/current/docker.html), [Guía de NEST](https://www.elastic.co/guide/en/elasticsearch/client/net-api/7.x/nest.html)

- **Kafka**: Sistema de mensajería para el procesamiento de eventos. [Guía para Kafka](https://www.notion.so/n5now/Kafka-242a5fd883bf49ffa77190fb16eb4ecf#74a1076feed24ea482c804f54483773d)

- **Serilog**: Biblioteca de logging para .NET. [Documentación de Serilog](https://serilog.net/)

- **CQRS**: Patrón de arquitectura. [CQRS en Azure](https://docs.microsoft.com/en-us/azure/architecture/patterns/cqrs)

- **Entity Framework Core (EF Core)**: ORM para acceder y manipular datos. [Documentación de EF Core](https://docs.microsoft.com/en-us/ef/core/)


### Configuración del Proyecto

1. Clona el repositorio del proyecto en tu máquina local.

2. Abre la solución en Visual Studio o en tu editor de código preferido.

3. Asegúrate de tener Docker Desktop en ejecución y haber iniciado los contenedores necesarios para SQL Server, Kafka y Elasticsearch siguiendo las guías proporcionadas en los enlaces anteriores.

4. Configura las cadenas de conexión y cualquier configuración específica del entorno en los archivos `appsettings.json` o a través de variables de entorno.

5. Ejecuta el proyecto desde Visual Studio o utilizando el comando `dotnet run` desde la terminal en el directorio del proyecto.



## Integraciones

### Sqlserver
### Kafka
### ElasticSearch
### Docker


## Base de Datos

Este proyecto utiliza SQL Server para el almacenamiento de datos. Hemos incluido una serie de scripts SQL en la carpeta `/scripts` de este repositorio para ayudarte a configurar tu base de datos localmente.

### Configuración Inicial

Para configurar tu base de datos:

1. Navega a la carpeta `/scripts`.
2. Ejecuta los scripts en el siguiente orden recomendado:
   - `01-CreateDatabase.sql`: Crea la base de datos.
   - `02-TipoPermisossql.sql`: Crea la tabla TipoPermisos.
   - `03-Permisos.sql`: Crea la tabla Permisos.
   - `04-Empleados.sql`: Crea la tabla Empleados.
   - Continúa con cualquier otro script necesario para tu entorno.



### Elasticsearch

Elasticsearch es un motor de búsqueda y análisis distribuido que utilizamos para indexar y buscar datos de manera eficiente en nuestra aplicación. Para una integración exitosa, es necesario configurar Elasticsearch localmente y asegurarse de que la configuración en la aplicación .NET (especificada en Program.cs) coincida con la configuración de tu instancia de Elasticsearch.

Accede a Elasticsearch: Una vez que Elasticsearch esté ejecutando, puedes acceder a él a través de http://localhost:9200. Utiliza el usuario elastic y la contraseña que estableciste para autenticarte o tu usuario de configuración para la insercion de los datos.

### Kafka

En este proyecto, utilizamos Apache Kafka como sistema de mensajería para el procesamiento y manejo de eventos. La integración con Kafka se realiza principalmente desde el lado del productor (producer) en nuestra aplicación, lo que nos permite enviar información de eventos relacionados con las operaciones CRUD de entidades de empleados a un tópico específico.

## Configuración del Producer
La configuración para enviar mensajes al tópico crudN5 se realiza en la aplicación .NET, donde especificamos la dirección del servidor de Kafka, el nombre del tópico y otras configuraciones relevantes. Aquí se muestra un ejemplo simplificado de cómo se configura y envía un mensaje al tópico crudN5 desde nuestra aplicación.
#### Creación de Tópico para Eventos CRUD
Para manejar los eventos generados por las acciones CRUD en nuestra aplicación, se ha creado un tópico específico en Kafka denominado crudN5. Para crear este tópico en tu entorno local de Kafka, puedes utilizar el siguiente comando en la terminal de Kafka:
.\bin\windows\kafka-topics.bat --create --topic crudN5 --bootstrap-server localhost:9092


### Serilog

En este proyecto, utilizamos Serilog como nuestra biblioteca de registro para capturar y registrar eventos importantes durante la ejecución de la aplicación, incluidos los eventos de inicio y fin de consumo de las APIs. Serilog nos permite configurar fácilmente múltiples destinos de salida (sinks) para los registros, asegurando que tengamos acceso a información detallada sobre el comportamiento y cualquier posible error en nuestra aplicación se dejo como repositorio de los log la ruta @"C:\Logs\log-.txt" se puede modificar al gusto.




