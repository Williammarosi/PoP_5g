open System
let lst1 = [[1; 2; 3]; [4; 5; 6]]

let isTable (lst : int list list) =
    if List.forall (fun (x : int list) -> x.IsEmpty = true) lst then
        false
    else
        if List.forall (fun (x : int list) -> x.Length = (lst.Item 0).Length) lst then 
            true
        else false
    
printfn "%A\n" (isTable lst1)

let firstColumn (lst: int list list) =
    let mutable listeny = []
    if isTable lst = false then
        listeny <- listeny
    else 
        for elm in lst do
            listeny <- listeny @ [elm.Head]
    listeny

printfn "firstColumn\n%A\n" (firstColumn lst1)

let dropFirstColumn (lst: int list list) =
    let mutable listeny = []
    if isTable lst = false then
        listeny <- listeny
    else 
        for elm in lst do
            listeny <- listeny @ [elm.Tail]
    listeny


printfn "dropFirstColumn:\n%A\n" (dropFirstColumn lst1)

let transposeLstLst (lst: int list list) =
    let mutable a = lst
    let mutable b = []
    while isTable a = true do
        b <- b @ [firstColumn a]
        a <- dropFirstColumn a
    b

printfn "transposeList:\n%A\n" (transposeLstLst lst1)

let lst2 = [[1; 2; 3; 4]; [5; 6; 7; 8]]
let lst3 = [[1; 2; 3]; [4; 5; 6]; [7; 8; 9]]
