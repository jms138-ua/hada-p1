Javier Mellado Sanchez 48800386k
Práctica 1 – Uso de git.pdf

P1. ¿Qué crees que significa la opción -n en el comando revert?
-n, --no-commit       don't automatically commit
Con revert se crea un nuevo commit con el commit anterior al commit especificado,
con -n evita crear ese nuevo commit, se deja en el staging area las modificaciones

P2. Vuelve a eliminar el archivo e intenta solucionar el problema anterior con el comando git reset --hard.
¿Qué cambios se han producido al ejecutar el comando reset?
Supongo que con lo de vuelve a eliminar el archivo no se refiera que ademas debemos hacer un nuevo commit, si fuera asi no ocurriría nada. 
En caso de no hacer el commit lo que pasaría es que se volvería al estado inicial del commit HEAD.

P3. ¿Qué diferencias observas entre revert y reset?
Revert es menos destructivo y peligroso que reset.
Revert crea un nuevo commit para el commit especificado.
Reset elimina todos los commits que se han producido despues del commit especificado,
(incluso los cambios en working directory y staging area como nos ha sucedido)

P4. ¿Qué diferencias observas entre merge y rebase?
En este caso en concreto no ha habido ninguna diferencia.
Merge con la tecnica fast-forward hace que si la rama especificada deriva del commit de la rama actual, ahora la master sera la derivada
Rebase coge el commit del que derivan de la rama actual, elimina todos los commits despues de ese, y le aplica commits siguiendo el orden de las fechas de ambas ramas