
function InsertionSortWeight()
{
    TableSelected();
    let iteration = 0;
    let comparaison = 0;

    for(let i = 0; i < data.length; i++)
    {
        let flag = data[i];
        let flagLabel = data[i].label;
        let j = i;
        iteration++;
        
        while(j>0 && (data[j-1].weight > flag.weight || (data[j-1].weight === flag.weight && data[j-1].label > flagLabel) ))
        {
            comparaison++;
            data[j] = data[j-1];
            j = j - 1;
        }
        data[j] = flag;
        
    }

    console.log(`iteration: ${iteration} comparaison: ${comparaison}`);
    console.log(data);
}

function BubbleSortWeight()
{
    TableSelected();
    let iteration = 0;
    let comparaison = 0;
    
    for (let j = 0 ; j < data.length-2; j++)
    {
        iteration++;
        for (let i = 0 ; i < data.length-2; i++)
        {
            iteration++;
            let labeli = data[i].label;
            let labeliPlus1 = data[i+1].label;

            if (data[i].weight > data[i + 1].weight || (data[i].weight === data[i+1].weight && labeli > labeliPlus1))
            {
                comparaison++;

                let temp = data[i + 1];
                data[i + 1] = data[i];
                data[i] = temp;
            }
        }
    }

    console.log(data);
    console.log(`iteration: ${iteration} comparaison: ${comparaison}`);
}




function CocktailSortWeight()
{
    TableSelected();
    let iteration = 0;
    let comparaison = 0;
    
    for (let i = 1; i < data.length; i++)
    {
        let val = data[i];
        let flag = 0;
        for (let j = i - 1; j >= 0 && flag != 1;)
        {
            iteration++;
            
            let valLabel = val.label;
            let dataJlabel = data[j].label;
            
            if (val.weight < data[j].weight || (val.weight === data[j].weight && valLabel < dataJlabel))
            {
                comparaison++;
                data[j + 1] = data[j];
                j--;
                data[j + 1] = val;
            }
            else
            {
                flag = 1;
            }
        }
        
    }
    
    console.log(`iteration: ${iteration} comparaison: ${comparaison}`);
    console.log(data);
}



function BubbleSortLabel()
{
    TableSelected();
    let iteration = 0;
    let comparaison = 0;

    for (let j = 0 ; j < data.length-2; j++)
    {
        iteration++;
        for (let i = 0 ; i < data.length-2; i++)
        {
            iteration++;
            let labeli = data[i].label;
            let labeliPlus1 = data[i+1].label;

            if(labeli > labeliPlus1)            
            {
                comparaison++;
                let temp = data[i + 1];
                data[i + 1] = data[i];
                data[i] = temp;
            }
        }
    }

    console.log(data);
    console.log(`iteration: ${iteration} comparaison: ${comparaison}`);
}

