# Problemas de F#
### Pregunta 1

### Los programas pueden correrse en el compilador online: https://onecompiler.com/fsharp/

## 1.b.i  Tipo de dato Church
Este problema se encuentra en el archivo church.fs. El tipo de dato Church se creó con el discriminated union de F#. Este tipo de dato puede ser utilizado en las funciones suma y multiplicación, que aceptan dos numerales de Church de tipo Church como entrada. 
La función suma opera de manera recursiva y va añadiendo un nuevo Suc de tipo Church dependiendo de los valores proporcionados a la función. Por otro lado, la función multiplicación opera igualmente de manera recursiva con ayuda de la función suma y se utiliza la definición de multiplicación como un conjunto de sumas.
Para correr este programa se debe modificar el código en la función main e incluir los números que forman los numerales de Church para obtener su suma o multiplicación. Como existe una función llamada churchOf no es necesario escribir manualmente el número de Church, solo se debe colocar el número natural que lo representa. 
Algunos ejemplos de llamadas en main son:

    let main = multiplicacion (churchOf 2)(churchOf 2) |> printf "%A"


    let main = suma (churchOf 4)(churchOf 6) |> printf "%A"

##### Nota: No se debe eliminar "|> printf "%A"" debido a que esto permite la impresión en pantalla del resultado de la operación.

## 1.b.i Max Heap Simétrico 
Este problema se encuentra en arbol.fs

