
function insertionSortWeight()
{
    tableSelected();
    let iteration = 0;
    let comparaison = 0;

    for(let i = 0; i < data.length; i++)
    {
        let flag = data[i];
        let j = i;
        iteration++;
        while(j>0 && flag.weight <= data[j-1].weight)
        {
            iteration++;
            if(isSuperior(data[j-1], flag))
            {
                comparaison++;
                data[j] = data[j-1];
            }
           
            j = j - 1;
        }
        data[j] = flag;
        
    }

    console.log(`iteration: ${iteration} comparaison: ${comparaison}`);
    console.log(data);
}

function bubbleSortWeight()
{
    tableSelected();
    let iteration = 0;
    let comparaison = 0;
    
    for (let i = data.length ; i > 1; i--)
    {
        iteration++;
        for (let j = 0 ; j < i-1; j++)
        {
            iteration++;
            if(islower(data[j+1], data[j]))
            {
                comparaison ++;
                swap(data, j+1, j);
            }
        }
    }

    console.log(data);
    console.log(`iteration: ${iteration} comparaison: ${comparaison}`);
}



function bubbleSortOptimize()
{
    tableSelected();
    let iteration = 0;
    let comparaison = 0;
    let tableIsSort=true;

    for(let i = data.length-1 ; i > 1; i--)
    {
        iteration++;
        tableIsSort = true;

        for(let j = 0; j < i-1; j++)
        {
            iteration++;
            if(islower(data[j+1], data[j]))
            {
                comparaison++;
                swap(data, j+1, j);
                tableIsSort=false;
            }
        }
        if(tableIsSort)
        {
            break;
        }
    }
    console.log(`iteration: ${iteration} comparaison: ${comparaison}`);
    console.log(data);
}


function swap(data, leftIndex, rightIndex)
{
    let temp = data[leftIndex];
    data[leftIndex] = data[rightIndex];
    data[rightIndex] = temp;
}

function isMinusOrEqual(flag, dataElement)
{
    return flag <= dataElement;
    
}


function isSuperior(dataElement, flag)
{
    return (dataElement.weight > flag.weight || (dataElement.weight === flag.weight) && (dataElement.label >= flag.label));
}