function fusionSort()
{
    tableSelected();
    sort(data, 0, data.length-1 );
    console.log(data);
}


function sort(array, left, right)
{
  if(left < right)
  {
    let middle=Math.floor((left+right)/2);

    sort(array, left, middle );
    sort(array, middle+1, right );

    merge(array, left, middle, right );
  }

}
function merge(array, left, middle, right )
{
  let n1 = middle - left + 1;
  let n2 = right - middle;
  let leftArray = new Array(n1);
  let rightArray = new Array(n2);

  partitionArray(array, leftArray, rightArray, left, middle);

  compareArray(array, leftArray, rightArray, left);
}


function partitionArray(array, leftArray, rightArray, left, middle)
{
  for(let i = 0; i < leftArray.length; i++)
  {
    leftArray[i] = array[left+i];
  }

  for(let j = 0; j < rightArray.length ; j++)
  {
    rightArray[j] = array[middle + 1 + j];
  }
}


function compareArray(array, leftArray, rightArray, left)
{
  let i= 0;
  let j = 0;
  let k= left;

  while(indexesLower(i, leftArray, j, rightArray))
  {
    if(islower(leftArray[i], rightArray[j]))
    {
      array[k] = leftArray[i];
      i++;
    }
    else
    {
      array[k] = rightArray[j];
      j++;
    }
    k++;
  }
  while(i < leftArray.length)
  {
    array[k] = leftArray[i];
    i++;
    k++;
  }
  while(j < rightArray.length)
  {
    array[k] = rightArray[j];
    j++;
    k++;
  }

}



function indexesLower(i, leftArray, j, rightArray)
{
  return i < leftArray.length && j < rightArray.length;
}

function islower(leftArray, rightArray)
 {
    return (leftArray.weight < rightArray.weight) || (leftArray.weight === rightArray.weight && leftArray.label < rightArray.label);
 }