open System
let llst = [[1; 2; 3]; [4; 5; 6;]]

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

printfn "%A" (firstColumn llst)

let dropFirstColumn (lst: int list list) =
    let mutable listeny = []
    if List.contains [] lst then
        listeny <- listeny
    else 
        for elm in lst do
            listeny <- listeny @ [elm.Tail]
    listeny


printfn "%A" (dropFirstColumn llst)

let transposeLstLst (lst: int list list) =
    let mutable a = lst
    let mutable b = []
    while (a.IsEmpty = false) do
        b <- b @ [firstColumn a]
        a <- dropFirstColumn a
    b

printfn "%A" (transposeLstLst llst)
