open System
//Church es el tipo que define a los numeros de Church de manera recursiva
type Church = Cero | Suc of Church
//La funcion recursiva numeralesDeChurch retorna un numeral de Church
//solo se utiliza para evitar tipear los numerales a mano al utilizar
//las funcinoes de suma y multiplicacion
let rec numeralesDeChurch (y:int) (last:Church) : Church =
    let next = Suc(last)
    match y=0 with
    | false -> numeralesDeChurch (y-1) next
    | true -> last
//La funcion churchOf llama a la funcion numeralesDeChurch y retorna
//un numeral de Church
let churchOf (x:int) = numeralesDeChurch x Cero
//La funcion suma retorna un numeral de Church y genera de manera 
//recursiva la suma de dos numerales de Church
let rec suma (x:Church) (y:Church) =
    match x with
    | Suc x -> suma x (Suc y)
    | Cero -> y
//La funcion multiplicacion retorna un numeral de Church y genera de 
//manera recursiva el resultado basandose en la definicion de los 
//numerales de Church
let rec multiplicacion (x:Church)(y:Church) =
    match y with
    | Suc y -> suma x (multiplicacion x y)
    | Cero -> Cero
//La funcion main es la funcion principal del programa y desde aqui se 
//llaman a las funciones de suma, multiplicacion y churchOf
let main = multiplicacion (churchOf 2)(churchOf 2) |> printf "%A"
//Se deben ingresar manualmente los valores:
//Para multiplicar n*m se debe colocar:
//multiplicacion (churchOf n)(churchOf m) |> printf "%A"
//Para sumar n+m se debe colocar:
//suma (churchOf n)(churchOf m) |> printf "%A"
// |> printf "%A" garantiza que se muestre en consola el resultado

