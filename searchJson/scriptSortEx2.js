
function insertionSortWeight()
{
    tableSelected();
    let iteration = 0;
    let comparaison = 0;

    for(let i = 0; i < data.length; i++)
    {
        let flag = data[i];
        let flagLabel = data[i].label;
        let j = i;
        iteration++;
        while(j>0 && isMinusOrEqual(flag.weight, data[j-1].weight))
        {
            iteration++;
            if(isMinusStrictThan(flag.weight , data[j-1].weight))
            {
                comparaison++;
                data[j] = data[j-1];
            }
            else if (isEqual(data[j-1].weight, flag.weight) && isMinusStrictThan(flagLabel, data[j-1].label))
            {
                comparaison+=2;
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
            let labelJ = data[j].label;
            let labeljPlus1 = data[j+1].label;
       
            if(isMinusStrictThan(data[j+1].weight, data[j].weight))
            {
                comparaison++;
                swap(data, j+1, j);
            }
            else if(isEqual(data[j+1].weight, data[j].weight) && isMinusStrictThan(labeljPlus1, labelJ))
            {
                comparaison+=2;
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
            if(isMinusStrictThan(data[j+1].weight, data[j].weight))
            {
                comparaison++;
                swap(data, j+1, j);
                tableIsSort=false;
            }
            else if(isEqual(data[j+1].weight, data[j].weight) && isMinusStrictThan(data[j+1].label, data[j].label))
            {
                comparaison+=2;
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

function isMinusOrEqual(weightLeft, weightRight)
{
    return weightLeft <= weightRight;
    
}

function isEqual(weightLeft, weightRight) 
{
   return weightLeft === weightRight;
}
function isMinusStrictThan(left, right)
{
    return left < right;
}
    