function FusionSort()
{
    TableSelected();
    Sort(data, 0, data.length-1);
    console.log(data);
}

function Merge(array, left, middle, right)
{

  let n1 = middle - left + 1;
  let n2 = right - middle;

  let leftArray = new Array(n1);
  let rightArray = new Array(n2);

  for(let i=0; i<n1; i++)
  {
    leftArray[i]=array[left+i];
  }
  for(let j=0; j<n2 ; j++)
  {
    rightArray[j]=array[middle + 1 + j];
  }
  let k= left;
  let i= 0;
  let j = 0;
  while(i<n1 && j<n2)
  {
    if(leftArray[i].weight < rightArray[j].weight)
    {
      array[k]=leftArray[i];
      i++;
    }
    else if(leftArray[i].weight === rightArray[j].weight && leftArray[i].label < rightArray[j].label)
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
function Sort(array, left, right)
{
  if(left<right)
  {
    let middle=Math.floor((left+right)/2);

    Sort(array, left, middle);
    Sort(array, middle+1, right);

    Merge(array, left, middle, right);
  }

}


