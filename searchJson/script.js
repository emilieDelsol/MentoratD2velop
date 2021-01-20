var data = new JSONObject();
function TableSearch(){
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

function SearchLabel(){
    var searchLabel = document.getElementById('inputLabel').value;
    TableSearch();
    for(var key in data)
    {
        if(data[key].label==searchLabel)
        {
            console.log("the first object with label="+searchLabel+" is:");
            console.log(data[key]);
            break;
        }
    }
}

function SearchNumberWeight() {
    var searchNumber = document.getElementById('inputNumber').value;
    var searchWeight = document.getElementById('inputWeight').value;
    TableSearch();
    var sortArray =  new Array();
    for(var key in data)
    {
        if(data[key].weight==searchWeight)
        {
            sortArray.push(data[key]);
        }
    }
    var searchIndex = parseInt(searchNumber)+1;
    console.log("You search " + searchNumber + "th object with weight = " + searchWeight );
    console.log(sortArray[searchIndex]);
}

function SearchWeightLast(){
    var searchWeight = document.getElementById('inputWeightLast').value;
    TableSearch();
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
}

function SearchAllLabel(){
    var searchAllLabel = document.getElementById('inputAllLabel').value;
    TableSearch();
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
}