open System

//Arbol es la definicion de un tipo recursivo 
type Arbol<'a> = Hoja of 'a | Rama of 'a * Arbol<'a> * Arbol<'a>

//La funcion recursiva preorder visita al arbol y retorna una lista con el preorder
let rec preorder (arbol : Arbol<'a>) =
    match arbol with
    | Hoja (valor : 'a) -> [valor]
    | Rama (valor, hijoIzquierdo, hijoDerecho) -> 
      let i = preorder hijoIzquierdo
      let d = preorder hijoDerecho
      valor :: i @ d

//La funcion recursiva postorder visita al arbol y retorna una lista con el postorder
let rec postorder (arbol : Arbol<'a>) =
    match arbol with
    | Hoja (valor : 'a) -> [valor]
    | Rama (valor : 'a, hijoIzquierdo, hijoDerecho) -> 
      let i = postorder hijoIzquierdo
      let d = postorder hijoDerecho
      i @ d @ [valor]

//La funcion esMaxHeapSimetrico retorna true si el orden del preorder y postorder son iguales y false si no.
let esMaxHeapSimetrico (arbol : Arbol<'a>) =
    match postorder arbol = preorder arbol with
    | true -> true
    | _ -> false

//Esta variable define el arbol que se evalua en la funcion main
//Las ramas son nodos con hijos y los nodos sin hijos son hojas
let arbolito = Rama (1, Rama (2, Hoja(4),Hoja(5)), Hoja(3))

//La funcion main llama a la funcion esMaxHeapSimetrico y para llamar al arbol deseado, debe escribirse manualmente en arbolito
let main = esMaxHeapSimetrico arbolito |> printf "%A"
