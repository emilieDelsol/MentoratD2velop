function addOnSortTable()
{
    tableSelected();
    let jsonAdd = createJsonObj();
    let initialLenght = data.length;
    let =0;
    for(i = initialLenght; i >= 0; i--) 
    {
        data[i + 1] = data[i];
        if(islower(data[i+1],jsonAdd))
        {
            data[i+1]=jsonAdd;
            break;
        }
    }
}

function islower(leftArrayElement, rightArrayElement)
 {
    return (leftArrayElement.weight < rightArrayElement.weight) || (leftArrayElement.weight === rightArrayElement.weight && leftArrayElement.label < rightArrayElement.label);
 }

 function createJsonObj()
{
    let weight = document.getElementById('weightId').value;
    let label = document.getElementById('labelId').value;
    let itemAdd=`{"weight": ${weight}, "label":"${label}"}`;
    let jsonAdd = JSON.parse(itemAdd);
    return jsonAdd;
}