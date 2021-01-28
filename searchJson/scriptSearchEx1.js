function SearchLabel(){
    
    let searchLabel = document.getElementById('inputLabel').value;
    let resultSearchLabelId = document.getElementById('resultSearchLabelId');
    let index = 0;
    
    TableSelected();
    while(data[index].label !== searchLabel && index < data.length)
    {
        index++;
    }

    if(index <= data.length)
    {
        console.log(`the first object with label=${searchLabel} is:`);
        console.log(data[index]);
        resultSearchLabelId.textContent=`the first object with label ${searchLabel} is: ${JSON.stringify(data[index])}` ;
    }
}

function SearchNumberWeight() {

    let searchNumber = parseInt(document.getElementById('inputNumber').value);
    let searchWeight = parseInt(document.getElementById('inputWeight').value);
    let resultLastWeightSearchId = document.getElementById('resultLastWeightSearchId');
    let index=0;
    let flag=0;
    
    TableSelected();
    while(index < data.length && flag < searchNumber-1)
    {
        index++;
        if(data[index].weight === searchWeight)
        {
            flag++;
        }
    }
    
    if(flag === searchNumber-1)
    {
        console.log(`You search ${searchNumber} the object with weight = ${searchWeight}`);
        console.log(data[index]);
        resultLastWeightSearchId.textContent=`You search ${searchNumber}e object with weight = ${searchWeight} : ${JSON.stringify((data[index]))}`
    }
}

function SearchWeightLast(){
    
    let searchWeight = document.getElementById('inputWeightLast').value;
    let resultAllLabelsId = document.getElementById('resultAllLabelsId');
    let index=0;
    let flag;
    TableSelected();
    while(index < data.length)
    {
        if(data[index].weight == searchWeight)
        {
            flag=index;
        }
        index++;
    }
    if(flag!==null)
    {
        console.log(`the last object with weight=${searchWeight} is:`);
        console.log(data[flag]);
        resultAllLabelsId.textContent = `the last object with weight=${searchWeight} is: ${JSON.stringify(data[flag])}`
    }
    
}

function SearchAllLabel(){
    
    let searchAllLabel = document.getElementById('inputAllLabel').value;
    let resultSearchElementId = document.getElementById('resultSearchElementId');
    let arrayAllLabel = new Array();
    
    TableSelected();
    for(let element of data)
    {
        if(element.label === searchAllLabel)
        {
            arrayAllLabel.push(element);

        }
    }
    
    console.log(`there is ${arrayAllLabel.length} values`);
    console.log(arrayAllLabel);
    resultSearchElementId.textContent=`there is ${arrayAllLabel.length} values: ${JSON.stringify(arrayAllLabel)}`;
}

function SearchSelectElement(){
    
    let resultSearchElementId=document.getElementById('resultSearchElementId');
    let searchSelectElement = parseInt(document.getElementById('inputSelectElement').value);
    
    TableSelected();
    let searchElementResult=JSON.stringify(data[searchSelectElement]);

    console.log(`this is the ${searchSelectElement}e element: `);
    console.log(data[searchSelectElement-1]);
    resultSearchElementId.textContent=`this is the ${searchSelectElement}e element: ${searchElementResult}`
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
    
    console.log(`search in table: ${tableSelect}`);
    
}