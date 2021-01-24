
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


