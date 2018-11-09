# Evaluacion GameControler

 - Modificar la escena implementada para que se ajuste a los siguientes requisitos:

- Debe incluir varias instancias de 3 tipos de objetos A(dinámico), B (estáticos) y C (cinemáticos) (pueden ser primitivas 3d)
 - Cuando el jugador colisiona con cualquier objeto A, se debe aumentar el poder de los objetos B y cambiar su color.
- Cuando el jugador colisiona con objetos de tipo B se deben mover los objetos de tipo C de forma proporcional a su poder.
 - El jugador puede aumentar la masa de los objetos de tipo A en la UI.

----

### Proyecto
- En este juego, los objetos dinamicos son los obstaculos de color rojo/negro, los estaticos los obstaculos grises y los cinematicos los obstaculos que aparecen delante del jugador cada cierto tiempo.

- Cuando el jugador colisiona con los cubos de color rojo, aumenta su velocidad pero, aumenta el poder de los obstaculos grises, los cuales frenaran con mayor fuerza a la bola, ademas de cambiar su color.

- Cuando la bola colisiona con los obstaculos grises, los obstaculos que aparecen durante la ejecucion, son movidos en el eje X sobre el plano segun el poder del player.

- Mediane un boton situado en la interfaz, se puede aumentar la masa de los obstaculos rojos/negros.