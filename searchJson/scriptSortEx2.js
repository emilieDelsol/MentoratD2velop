
function InsertionSortWeight()
{
    TableSelected();
    let iteration = 0;
    let comparaison = 0;

    for(let i = 0; i < data.length; i++)
    {
        let flag = data[i];
        let flagLabel = data[i].label;
        let j = i;
        iteration++;
        while(j>0 && IsMinusOrEqual(flag.weight, data[j-1].weight))
        {
            iteration++;
            if(LeftIsMinusStrictRight(flag.weight , data[j-1].weight))
            {
                comparaison++;
                data[j] = data[j-1];
            }
            else if (IsEqual(data[j-1].weight, flag.weight) && LeftIsMinusStrictRight(flagLabel, data[j-1].label))
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

function BubbleSortWeight()
{
    TableSelected();
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
       
            if(LeftIsMinusStrictRight(data[j+1].weight, data[j].weight))
            {
                comparaison++;
                Swap(data, j+1, j);
            }
            else if(IsEqual(data[j+1].weight, data[j].weight) && LeftIsMinusStrictRight(labeljPlus1, labelJ))
            {
                comparaison+=2;
                Swap(data, j+1, j);
            }
        }
    }

    console.log(data);
    console.log(`iteration: ${iteration} comparaison: ${comparaison}`);
}



function BubbleSortOptimize()
{
    TableSelected();
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
            if(LeftIsMinusStrictRight(data[j+1].weight, data[j].weight))
            {
                comparaison++;
                Swap(data, j+1, j);
                tableIsSort=false;
            }
            else if(IsEqual(data[j+1].weight, data[j].weight) && LeftIsMinusStrictRight(data[j+1].label, data[j].label))
            {
                comparaison+=2;
                Swap(data, j+1, j);
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


function Swap(data, leftIndex, rightIndex)
{
    let temp = data[leftIndex];
    data[leftIndex] = data[rightIndex];
    data[rightIndex] = temp;
}

function IsMinusOrEqual(weightLeft, weightRight)
{
    if(weightLeft <= weightRight)
    {
        return true;
    }
    else 
    {
        return false;
    }
}

function IsEqual(weightLeft, weightRight) 
{
    if(weightLeft === weightRight)
    {
        return true;
    }
    else
    {
        return false;
    }

}
function LeftIsMinusStrictRight(left, right)
{
    if(left < right)
    {
        return true;
    }
    else
    {
        return false;
    }
}