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
    let pivotlabel = data[Math.floor((right+left)/2)].label;

    while(left <= right)
    {
        while(data[left].weight < pivotWeight || (data[left].weight===pivotWeight && data[left].label < pivotlabel) )
        {
            left++;
        }
        while(data[right].weight > pivotWeight || (data[right].weight===pivotWeight && data[right].label > pivotlabel))
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

function IsEqual(left, right) 
{
    if(left === right)
    {
        return true;
    }
    else
    {
        return false;
    }

}
function IsMinusStrictThan(left, right)
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
function IsGreaterStrictThan(left, right)
{
    if(left > right)
    {
        return true;
    }
    else
    {
        return false;
    }
}