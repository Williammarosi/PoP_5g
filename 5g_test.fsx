open System
let llst = [[1; 2; 3]; [4; 5; 6]]
let lst2 = [[1; 2; 3; 4]; [5; 6; 7; 8]]
let lst3 = [[1; 2; 3]; [4; 5; 6]; [7; 8; 9]]

let isTable (lst : int list list) =
    let mutable a = 0
    for elm in lst do
        a <- a + elm.Length
    printfn "%A" ((lst.Item 0).Length = a / lst.Length)

isTable llst

let firstColumn (lst: int list list) =
    let mutable listeny = []
    if List.contains [] lst then
        listeny <- listeny
    else 
        for elm in lst do
            listeny <- listeny @ [elm.Head]
    listeny

printfn "firstColumn\n%A\n" (firstColumn llst)

let dropFirstColumn (lst: int list list) =
    let mutable listeny = []
    if List.contains [] lst then
        listeny <- listeny
    else 
        for elm in lst do
            listeny <- listeny @ [elm.Tail]
    listeny


printfn "dropFirstColumn:\n%A\n" (dropFirstColumn llst)

let transposeLstLst (lst: int list list) =
    let mutable a = lst
    let mutable b = []
    while firstColumn a <> [] do
        b <- b @ [firstColumn a]
        a <- dropFirstColumn a
    b

printfn "list1:\n%A\n" (transposeLstLst llst)
printfn "list2:\n%A\n" (transposeLstLst lst2)
printfn "list3:\n%A\n" (transposeLstLst lst3)


let arr = Array2D.create 2 3 0 in
    for i = 0 to (Array2D.length1 arr) - 1 do
        for j = 0 to (Array2D.length2 arr) - 1 do
            arr.[i,j] <- j + 1 + (i*2 + i*1)

let arr2 = Array2D.init 2 3 (fun i j -> j + 1 + (i*2 + i*1))

printfn "Original Array:\n%A\n\n%A\n" arr arr2


let transposeArray arra =
    Array2D.init (Array2D.length2 arra) (Array2D.length1 arra) (fun i j -> arra.[j,i])

printfn "Transposed Array:\n%A\n\n%A\n" (transposeArray arr) (transposeArray arr2)
