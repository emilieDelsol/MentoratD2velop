function fusionSort()
{
    
    tableSelected();
    sort(data, 0, data.length-1, );
    console.log(data);

}

function merge(array, left, middle, right )
{

  let n1 = middle - left + 1;
  let n2 = right - middle;

  let leftArray = new Array(n1);
  let rightArray = new Array(n2);

  partitionArray(array, leftArray, rightArray, n1, n2, left, middle);

  compareArray(array, leftArray, rightArray, n1, n2, left);
  

}

function  compareArray(array, leftArray, rightArray,n1, n2, left)
{
  let i= 0;
  let j = 0;
  let k= left;
  while(i<n1 && j<n2)
  {
    if(leftArray[i].weight < rightArray[j].weight)
    {
      array[k]=leftArray[i];
      i++;
    }
    else if(leftArray[i].weight === rightArray[j].weight && isMinusStrictThan(leftArray[i].label , rightArray[j].label))
    {
      array[k]=leftArray[i];
      i++;
    }
    else
    {
      array[k]=rightArray[j];
      j++;
    }
    k++;
  }
  while(i<n1)
  {
    array[k]=leftArray[i];
    i++;
    k++;
  }
  while(j<n2)
  {
    array[k]=rightArray[j];
    j++;
    k++;
  }

}
function partitionArray(array, leftArray, rightArray, n1, n2, left, middle)
{
  for(let i=0; i<n1; i++)
  {
    leftArray[i]=array[left+i];
  }
  for(let j=0; j<n2 ; j++)
  {
    rightArray[j]=array[middle + 1 + j];
  }
}

function sort(array, left, right)
{
  if(left<right)
  {
    let middle=Math.floor((left+right)/2);

    sort(array, left, middle );
    sort(array, middle+1, right );

    merge(array, left, middle, right );
  }

}


function isEqual(weightLeft, weightRight) 
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