function addAtStartTable()
{
    tableSelected();
    let jsonAdd = createJsonObj();
    data.unshift(jsonAdd);
    console.log(data);

}

function addAtEndTable()
{
    tableSelected();
    let json = createJsonObj();
    data.push(json);
    console.log(data);
}

function addAtChooseId()
{
    tableSelected();
    let json = createJsonObj();
    data.splice(chooseId, 0, json);
    console.log(data);
}

function addElementAtStartTable()
{
    tableSelected();
    let jsonAdd = createJsonObj();
    let newEndId = data.length;
    let i=0;

    for(i=newEndId-1; i>0; i--)
    {
        data[i+1]=data[i];
    }
    data[0] = jsonAdd;

    console.log(data);
}

function addElementEndTable()
{
    tableSelected();
    let jsonAdd = createJsonObj();
    let endIndex = data.length-1;
    let newEndId = data.length;
    let i=0;

    for(i=newEndId-1; i>=endIndex+1; i--)
    {
        data[i+1]= data[i];
    }
    data[endIndex+1] = jsonAdd;

    console.log(data);

}

function addElementAfterChooseId()
{
    tableSelected();
    let jsonAdd = createJsonObj();
    let indexChoose = parseInt(document.getElementById('chooseId2').value)-1;
    let initialLenght = data.length;
    let i=0;
    for(i = initialLenght; i >= indexChoose + 1; i--) 
    {
        data[i + 1] = data[i];
     }
     data[indexChoose + 1] = jsonAdd;
     
    console.log(data);
}

function createJsonObj()
{
    let weight = document.getElementById('weightId').value;
    let label = document.getElementById('labelId').value;
    let itemAdd=`{"weight": ${weight}, "label":"${label}"}`;
    let jsonAdd = JSON.parse(itemAdd);
    return jsonAdd;
}