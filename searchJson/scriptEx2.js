
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
            iteration++;
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
    
    for (let i = data.length ; i > 1; i--)
    {
        iteration++;
        for (let j = 0 ; j < i-1; j++)
        {
            iteration++;
            let labelJ = data[j].label;
            let labeljPlus1 = data[j+1].label;

            if (data[j+1].weight < data[j].weight || (data[j+1].weight === data[j].weight && labeljPlus1 < labelJ))
            {
                comparaison++;
                Swap(data, data[j + 1], data[j])
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
                j--;
                Swap(data, data[j + 1], data[j])
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


function Swap(data, leftIndex, rightIndex)
{
    let temp = data[leftIndex];
    data[leftIndex] = data[rightIndex];
    data[rightIndex] = temp;
}

