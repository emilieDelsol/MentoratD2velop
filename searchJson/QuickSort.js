function fastSortWeight()
{
    tableSelected();
    let left = 0;
    let right = data.length-1;
    quickSort(data,left,right);
    console.log(data);
}

function quickSort(data, left, right)
{
    if(data.length > 1)
    {
        index = partition(data, left, right);
        if(left < index-1)
        {
            quickSort(data, left, index-1);
        }
        if(index < right)
        {
            quickSort(data, index, right);
        }
    }
    
    return (data);
}

function partition(data, left, right)
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
            swap(data, left, right);
            left++;
            right--;
        }
    }
    return left;
}



function swap(data, leftIndex, rightIndex)
{
    let temp = data[leftIndex];
    data[leftIndex] = data[rightIndex];
    data[rightIndex] = temp;
}

function isEqual(left, right) 
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
function isMinusStrictThan(left, right)
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
function isGreaterStrictThan(left, right)
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