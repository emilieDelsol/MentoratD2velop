console.log("\n\n**********************************" +
"\nThe INSERTION SORT:" +
"\n**********************************");
let tableToSortInsertion = [ 99, 10, 50, 520, 30, 5, 9, 4, 1, 0 ];
console.log("first sort: ");
insertionSort(tableToSortInsertion);
console.log("second sort: ");
insertionSort(tableToSortInsertion);

console.log("\n**********************************" +
"\nThe BUBBLE SORT:" +
"\n**********************************");
let tableToSortBubble = [ 99, 10, 50, 520, 30, 5, 9, 4, 1, 0 ];
console.log("first sort: ");
bubbleSort(tableToSortBubble);
console.log("second sort: ");
bubbleSort(tableToSortBubble);

console.log("\n**********************************" +
"\nThe COCKTAIL SORT:" +
"\n**********************************");
let tableToSortCoktail = [ 99, 10, 50, 520, 30, 5, 9, 4, 1, 0 ];
console.log("first sort: ");
cocktailSort(tableToSortCoktail);
console.log("second sort: ");
cocktailSort(tableToSortCoktail);



function insertionSort(table)
{
    let iteration = 0;
    let comparaison = 0;
    for (let i in table)
    {
        let val = table[i];
        let j = i;
        iteration++;
        while (j>0 && table[j - 1] > val)
        {
            comparaison++;
            table[j] = table[j - 1];
            j = j - 1;
        }
        table[j] = val;
    }
    console.log(`iteration: ${iteration} comparaison: ${comparaison}`);
    return table;
}

function bubbleSort(integerTable)
{
    let iteration = 0;
    let comparaison = 0;
    for (let j =0 ; j<integerTable.length-2; j++)
    {
        iteration++;
        for (let i=0 ; i<integerTable.length-2; i++)
        {
            iteration++;
            if (integerTable[i] > integerTable[i + 1])
            {
                comparaison++;
                let temp = integerTable[i + 1];
                integerTable[i + 1] = integerTable[i];
                integerTable[i] = temp;
            }

        }
    }
    console.log(`iteration: ${iteration} comparaison: ${comparaison}`);
    
    return integerTable;
}

function cocktailSort(integerTable)
{
    let iteration = 0;
    let comparaison = 0;
    for (let i = 1; i < integerTable.length; i++)
    {
        let val = integerTable[i];
        let flag = 0;
        for (let j = i - 1; j >= 0 && flag != 1;)
        {
            iteration++;
            if (val < integerTable[j])
            {
                comparaison++;
                integerTable[j + 1] = integerTable[j];
                j--;
                integerTable[j + 1] = val;
            }
            else
            {
                flag = 1;
            }
        }
        
    }
    console.log(`iteration: ${iteration} comparaison: ${comparaison}`);
    return integerTable;
}