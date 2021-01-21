function SearchLabel(){
    let searchLabel = document.getElementById('inputLabel').value;
    let resultSearchLabelId = document.getElementById('resultSearchLabelId');
    TableSelected();
    let index = 0;
    while(data[index].label !== searchLabel && index < data.length)
    {
        index++;
    }
    if(index <= data.length)
    {
        console.log("the first object with label="+searchLabel+" is:");
        console.log(data[index]);
        resultSearchLabelId.textContent='the first object with label "' + searchLabel+ '" is: '+ JSON.stringify(data[index]) ;
    }
}

function SearchNumberWeight() {
    let searchNumber = document.getElementById('inputNumber').value;
    let searchWeight = document.getElementById('inputWeight').value;
    let resultLastWeightSearchId = document.getElementById('resultLastWeightSearchId');
    TableSelected();
    let index=0;
    let flag=0;
    while(index < data.length && flag < parseInt(searchNumber)-1)
    {
        index++;
        if(data[index].weight === parseInt(searchWeight))
        {
            flag++;
        }
    }
    if(flag === parseInt(searchNumber)-1)
    {
        console.log("You search " + searchNumber + "the object with weight = " + searchWeight);
        console.log(data[index]);
        resultLastWeightSearchId.textContent='You search "' + searchNumber + '"eme object with weight = "' + searchWeight +'" : ' + JSON.stringify((data[index]))
    }
}

function SearchWeightLast(){
    let searchWeight = document.getElementById('inputWeightLast').value;
    let resultAllLabelsId = document.getElementById('resultAllLabelsId');
    TableSelected();
    data.reverse()
    let index=0;
    while(data[index].weight !== searchWeight && index < data.length)
    {
        index++;
    }
    if(index < data.length)
    {
        console.log("the last object with weight="+searchWeight+" is:");
        console.log(data[index]);
        resultAllLabelsId.textContent = 'the last object with weight="'+searchWeight+'" is: ' + JSON.stringify(data[index])
    }
}

function SearchAllLabel(){
    let searchAllLabel = document.getElementById('inputAllLabel').value;
    let resultSearchElementId = document.getElementById('resultSearchElementId');
    TableSelected();
    let arrayAllLabel = new Array();
    for(let key in data)
    {
        if(data[key].label === searchAllLabel)
        {
            arrayAllLabel.push(data[key]);
            i++;
        }
    }
    console.log("there is "+arrayAllLabel.length+" values");
    console.log(arrayAllLabel);
    resultSearchElementId.textContent="there is "+arrayAllLabel.length+" values: " + JSON.stringify(arrayAllLabel);
}

function SearchSelectElement(){
    let resultSearchElementId=document.getElementById('resultSearchElementId');
    let searchSelectElement = document.getElementById('inputSelectElement').value;
    TableSelected();
    console.log("this is the "+searchSelectElement+"e element: ");
    console.log(data[searchSelectElement-1]);
    resultSearchElementId.textContent="this is the "+searchSelectElement+"e element: "+ JSON.stringify(data[searchSelectElement])
}

function TableSelected(){
    let tableSelect = document.getElementById('tableSelect').value;
    if(tableSelect === "1K")
    {
        data = data1K;
    }
    else if(tableSelect === "1M")
    {
        data = data1M;
    }
    else if(tableSelect === "50K")
    {
        data = data1M;
    }
    else
    {
        alert("please choose a table!");
    }    
    console.log("search in table: " + tableSelect);
    
}