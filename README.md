# hada-p1

P1. ¿Qué rama se ha subido exactamente?
La rama master

P2. ¿Qué pasa al utilizar la opción Comparar con la versión no modificada?
Muestra las diferencias en el archivo, lo que se ha modificado en el working directory.
En este caso todo esta en verde porque solo hemos agregado lineas, no eliminado.

P3. ¿Y ahora ves algún cambio en el repositorio remoto? ¿Por qué?
No, nos aparece una aletar de vs, nos advierte de que ha sucedido un conflicto.
"No se pueden enviar cambios con "push" al repositorio remoto porque la rama local esta detras de la rama remota".
Nos pregunta si queremos resolverlo con un pull y push

P4. ¿Qué significa “Confirmar todo” y cuál sería el comando git equivalente?
Hacer nuevo commit.
Equivalente a (git add .) + (git commit -m <msg>)

P5. ¿Qué significa “Confirmar todo e insertar” y cuál sería el comando git equivalente?
Hacer nuevo commit y push a github.
Equivalente a (git add .) + (git commit -m <msg>) + (git push origin master)

P6. ¿Qué significa “Confirmar todo y sincronizar” cuál sería el comando git equivalente?
Hacer nuevo commit, pull y push.
De esta forma solucionamos el problema presentado en la pregunta P3.
Equivalente a (git add .) + (git commit -m <msg>) + (git pull origin master) + (git push origin master)

P7  ¿Cuál  es  la  diferencia  entre  pulsar Sincronizar o Extraer? ¿Cuáles serían los comandos git equivalentes?
Sincronizar baja los cambios del repositorio remoto al repositorio local
Equivalente a (git fetch origin) 
Extraer es una combinacion de: (git fetch origin + git checkout master + git merge origin/master)
Equivalente a (git pull origin master)
