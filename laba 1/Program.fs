open System 

let rec sum_of_numberr num : int =
    if num > 0 then
        (num%10) + sum_of_numberr (num/10)
    else
        0

let rec sum_of_number_2 num = 
    if num > 0 then
        let res = sum_of_number_2 (num/10)
        num%10 + res
    else
        0


printfn "enter number"
let number = int (Console.ReadLine())
if (number <=0) then
    printfn "Wrong number"
else
    printfn "sum of nums in number = %d" (sum_of_numberr number)
    printfn "sum of nums in number = %d" (sum_of_number_2 number)
