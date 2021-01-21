function SearchLabel(){
    var searchLabel = document.getElementById('inputLabel').value;
    var resultSearchLabelId=document.getElementById('resultSearchLabelId');
    TableSelected();
    for(var key in data)
    {
        if(data[key].label==searchLabel)
        {
            console.log("the first object with label="+searchLabel+" is:");
            console.log(data[key]);
            resultSearchLabelId.textContent='the first object with label "' + searchLabel+ '" is: '+ JSON.stringify(data[key]) ;
            break;
        }
    }
}

function SearchNumberWeight() {
    var searchNumber = document.getElementById('inputNumber').value;
    var searchWeight = document.getElementById('inputWeight').value;
    var resultLastWeightSearchId=document.getElementById('resultLastWeightSearchId');
    TableSelected();
    var sortArray =  new Array();
    for(var key in data)
    {
        if(data[key].weight==searchWeight)
        {
            sortArray.push(data[key]);
        }
    }
    var searchIndex = parseInt(searchNumber)+1;
    console.log("You search " + searchNumber + "the object with weight = " + searchWeight );
    console.log(sortArray[searchIndex]);
    resultLastWeightSearchId.textContent='You search "' + searchNumber + '"eme object with weight = "' + searchWeight +'" : ' + JSON.stringify((sortArray[searchIndex]))
}

function SearchWeightLast(){
    var searchWeight = document.getElementById('inputWeightLast').value;
    var resultAllLabelsId = document.getElementById('resultAllLabelsId');
    TableSelected();
    var sortArray =  new Array();
    for(var key in data)
    {
        if(data[key].weight==searchWeight)
        {
            sortArray.push(data[key]);
        }
    }
    console.log("the last object with weight="+searchWeight+" is:");
    console.log(sortArray.pop());
    resultAllLabelsId.textContent='the last object with weight="'+searchWeight+'" is: ' + JSON.stringify(sortArray.pop())
}

function SearchAllLabel(){
    var searchAllLabel = document.getElementById('inputAllLabel').value;
    var resultSearchElementId = document.getElementById('resultSearchElementId');
    TableSelected();
    var arrayAllLabel = new Array();
    let i =0;
    for(var key in data)
    {
        if(data[key].label==searchAllLabel)
        {
            arrayAllLabel.push(data[key]);
            i++;
        }
    }
    console.log("there is "+i+" values");
    console.log(arrayAllLabel);
    resultSearchElementId.textContent="there is "+i+" values: " + JSON.stringify(arrayAllLabel);
}
function SearchSelectElement(){
    var resultSearchElementId=document.getElementById('resultSearchElementId');
    var searchSelectElement = document.getElementById('inputSelectElement').value;
    TableSelected();

    console.log("this is the "+searchSelectElement+"e element: ");
    console.log(data[searchSelectElement+1]);
    resultSearchElementId.textContent="this is the "+searchSelectElement+"e element: "+ JSON.stringify(data[searchSelectElement])
}

function TableSelected(){
    var tableSelect = document.getElementById('tableSelect').value;
    if(tableSelect=="1K")
    {
        data=data1K;
    }
    else if(tableSelect=="1M")
    {
        data=data1M;
    }
    else if(tableSelect=="50K")
    {
        data=data1M;
    }
    else
    {
        alert("please choose a table!");
    }    
    console.log("search in table: "+tableSelect);
    
}