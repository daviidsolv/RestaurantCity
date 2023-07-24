# RestaurantCity Remake

Este proyecto es un remake del popular juego de Facebook, Restaurant City. El objetivo es crear un juego de simulación en el que los jugadores puedan administrar su propio restaurante, diseñar su espacio, atender a los clientes, expandir su menú y competir con amigos en rankings.

## Colaboradores
|Nombre |Github|
|-----|--------|
|David Argente|[@crafian](https://github.com/crafian)|
|Eric Lopez|[@ericlopezsegui](https://github.com/ericlopezsegui)|
|Joan Bonell  |[@JoanBonell](https://github.com/JoanBonell)|

## Descripción general de la lógica básica del juego

1. Inicio del juego
El jugador crea su restaurante y elige un nombre.
El jugador selecciona la ubicación de su restaurante en un mapa o en un espacio de cuadrícula.
Se crea un menú básico con algunos platos y bebidas predeterminados.
Se contratan empleados predeterminados, como cocineros y meseros.

2. Gestión del restaurante
Diseño del espacio: El jugador puede comprar y colocar objetos (mesas, sillas, decoraciones) para diseñar y personalizar el restaurante.
Menú: El jugador puede agregar o eliminar platos y bebidas del menú, ajustar precios y, si se implementa la funcionalidad de ingredientes, modificar recetas.
Empleados: El jugador puede contratar, despedir y promocionar empleados, así como asignarles roles específicos (cocinero, mesero, limpiador).
Economía del juego: El jugador debe equilibrar los ingresos de los clientes con los costos de los empleados, los ingredientes y los objetos.

3. Interacción con clientes
Los clientes llegan al restaurante de forma aleatoria y son atendidos por los meseros.
Los clientes realizan pedidos en función del menú del restaurante.
Los cocineros preparan los platos y bebidas pedidos por los clientes.
Los meseros llevan los pedidos a las mesas de los clientes.
Los clientes consumen sus pedidos y pagan antes de irse.
El nivel de satisfacción de los clientes se ve afectado por la calidad de la comida, el tiempo de espera, el ambiente del restaurante y la atención de los empleados.

4. Progreso y desafíos
A medida que el jugador progresa, puede desbloquear nuevos platos, bebidas, objetos y características.
El jugador puede completar misiones y desafíos para obtener recompensas y avanzar en el juego.
Los eventos especiales pueden proporcionar oportunidades de tiempo limitado para ganar objetos exclusivos y recompensas.

5. Interacción social
Los jugadores pueden visitar los restaurantes de sus amigos y ayudarse mutuamente, como proporcionar ingredientes o acelerar la preparación de los pedidos.
Los jugadores pueden competir en rankings o desafíos para ver quién tiene el mejor restaurante.

## Estructura del proyecto
Este proyecto se desarrolla utilizando Unity y C#. A continuación, se presenta un diagrama de clases simplificado que muestra la estructura básica del juego:

- Clase Restaurant
- Clase Menu
- Clase Empleado
- Clase Cliente
- Clase Plato
- Clase Bebida
- Clase Objeto (para representar mesas, sillas,
- Clase Misiones
- Clase EventoEspecial
- Clase NPC : Objeto (personaje no jugable que puede moverse por el restaurante)
## Instalación y configuración

- Requisitos previos
Unity (versión recomendada: 2020.3.2f1 o superior)
Visual Studio, Visual Studio Code u otro editor compatible con Unity
- Pasos para configurar el proyecto
Clona este repositorio en tu máquina local: git clone https://github.com/daviidsolv/RestaurantCity
Abre Unity Hub y haz clic en "Add".
Navega hasta la carpeta del proyecto clonado y selecciónala para agregarla a Unity Hub.
Abre el proyecto en Unity.
Una vez abierto el proyecto, abre la escena principal en la carpeta "Scenes" (por ejemplo, "MainScene.unity").

## Contribuciones

Agradecemos y valoramos tus contribuciones. Si deseas contribuir al proyecto, sigue estos pasos:

Haz un "fork" del repositorio.
Crea una rama con un nombre descriptivo para la característica que deseas agregar o el problema que deseas solucionar: git checkout -b new-feature
Realiza tus cambios y "commits" con mensajes claros y concisos.
Haz "push" de tus cambios a la rama en tu repositorio "fork": git push origin new-feature
Crea una "pull request" desde la rama en tu repositorio "fork" al repositorio original.
Antes de enviar tus cambios, asegúrate de que estén alineados con el diseño del juego y que sigan las mejores prácticas de programación y estilo de código.

## Licencia

Este proyecto se distribuye bajo la licencia MIT. Consulta el archivo LICENSE para obtener más detalles.

## Créditos y agradecimientos

Este proyecto está inspirado en el juego original de Restaurant City desarrollado por Playfish. Agradecemos a la comunidad de Restaurant City por su apoyo y entusiasmo por revivir este juego clásico
