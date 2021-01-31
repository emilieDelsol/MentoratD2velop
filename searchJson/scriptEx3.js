function addAtStartTable()
{
    tableSelected();
    let weightToAddStart = document.getElementById('weightId').value;
    let labelToAddStart = document.getElementById('labelId').value;
    let itemAdd=`{"weight": ${weightToAddStart}, "label":"${labelToAddStart}"}`;
    let jsonAdd = JSON.parse(itemAdd);
    data.unshift(jsonAdd);
    console.log(data);

}

function addAtEndTable()
{
    tableSelected();
    let weightToAddEnd = document.getElementById('weightId').value;
    let labelToAddEnd = document.getElementById('labelId').value;
    let item=`{"weight": ${weightToAddEnd}, "label":"${labelToAddEnd}"}`;
    let json = JSON.parse(item);
    data.push(json);
    console.log(data);
}

function addAtChooseId()
{
    tableSelected();
    let weightToAddAtId = document.getElementById('weightId').value;
    let labelToAddAtId = document.getElementById('labelId').value;
    let chooseId = document.getElementById('chooseId').value;
    let item=`{"weight": ${weightToAddAtId}, "label":"${labelToAddAtId}"}`;
    let json = JSON.parse(item);
    data.splice(chooseId, 0, json);
    console.log(data);
}