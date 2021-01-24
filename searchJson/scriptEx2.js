
function InsertionSortWeight()
{
    TableSelected();
    let iteration = 0;
    let comparaison = 0;
    for(let i = 0; i < data.length; i++)
    {
        let flag = data[i];
        let flagLabel = ConvertLabel(data[i].label);
        let j = i;
        iteration++;
        
        while(j>0 && (data[j-1].weight > flag.weight || (data[j-1].weight === flag.weight && ConvertLabel(data[j-1].label) > flagLabel) ))
        {
            comparaison++;
            data[j] = data[j-1];
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
    for (let j = 0 ; j < data.length-2; j++)
    {
        iteration++;
        for (let i = 0 ; i < data.length-2; i++)
        {
            iteration++;
            let labeli = ConvertLabel(data[i].label);
            let labeliPlus1 = ConvertLabel(data[i+1].label);

            if (data[i].weight > data[i + 1].weight || (data[i].weight === data[i+1].weight && labeli > labeliPlus1))
            {
                comparaison++;
                let temp = data[i + 1];
                data[i + 1] = data[i];
                data[i] = temp;
            }
        }
    }
    console.log(data);
    console.log(`iteration: ${iteration} comparaison: ${comparaison}`);
}


function BubbleSortLabel()
{
    TableSelected();
    let iteration = 0;
    let comparaison = 0;
    for (let j = 0 ; j < data.length-2; j++)
    {
        iteration++;
        for (let i = 0 ; i < data.length-2; i++)
        {
            iteration++;
            let labeli = ConvertLabel(data[i].label);
            let labeliPlus1 = ConvertLabel(data[i+1].label);

            if(labeli > labeliPlus1)            
            {
                comparaison++;
                let temp = data[i + 1];
                data[i + 1] = data[i];
                data[i] = temp;
            }
        }
    }
    console.log(data);
    console.log(`iteration: ${iteration} comparaison: ${comparaison}`);
}



function CocktailSortWeight()
{
    TableSelected();
    let iteration = 0;
    let comparaison = 0;
    for (let i = 1; i < data.length; i++)
    {
        let val = data[i];
        let flag = 0;
        for (let j = i - 1; j >= 0 && flag != 1;)
        {
            iteration++;
            
            let valLabel = ConvertLabel(val.label);
            let dataJlabel = ConvertLabel(data[j].label);

            if (val.weight < data[j].weight || (val.weight === data[j].weight && valLabel < dataJlabel))
            {
                comparaison++;
                data[j + 1] = data[j];
                j--;
                data[j + 1] = val;
            }
            else
            {
                flag = 1;
            }
        }
        
    }
    console.log(`iteration: ${iteration} comparaison: ${comparaison}`);
    console.log(data);
}

function FastSortWeight()
{
    TableSelected();
    let left = 0;
    let right = data.length-1;
    QuickSort(data,left,right);
    console.log(data);
}

function QuickSort(data, left, right)
{
    if(data.length > 1)
    {
        index = Partition(data, left, right);
        if(left < index-1)
        {
            QuickSort(data, left, index-1);
        }
        if(index < right)
        {
            QuickSort(data, index, right);
        }
    }
    
    return (data);
}
function Partition(data, left, right)
{
    let pivotWeight = data[Math.floor((right+left)/2)].weight;
    dataLeftLabel = ConvertLabel(data[left].label);
    dataRightLabel = ConvertLabel(data[right].label);
    pivotLabel = ConvertLabel(data[Math.floor((right+left)/2)].label);

    while(left <= right)
    {
        while(data[left].weight < pivotWeight )
        {
            left++;
        }
        while(data[right].weight > pivotWeight )
        {
            right--;
        }
        if(left <= right)
        {
            Swap(data, left, right);
            left++;
            right--;
        }
    }
    return left;
}

function Swap(data, leftIndex, rightIndex)
{
    let temp = data[leftIndex];
    data[leftIndex] = data[rightIndex];
    data[rightIndex] = temp;
}




function ConvertLabel(label)
{
    if(label=="one")
    {
        return 1;
    }
    else if(label=="two")
    {
        return 2;
    }
    else if(label=="three")
    {
        return 3;
    }
    else if(label=="four")
    {
        return 4;
    }
    else if(label=="five")
    {
        return 5;
    }
    else if(label=="six")
    {
        return 6;
    }
    else if(label=="seven")
    {
        return  7;
    }
    else if(label=="heigth")
    {
        return  8;
    }
    else if(label=="nine")
    {
        return  9;
    }
    else if(label=="ten")
    {
        return  10;
    }
}