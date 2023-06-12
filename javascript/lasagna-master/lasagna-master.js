/// <reference path="./global.d.ts" />
// @ts-check

/**
 * Implement the functions needed to solve the exercise here.
 * Do not forget to export them so they are available for the
 * tests. Here an example of the syntax as reminder:
 *
 * export function yourFunction(...) {
 *   ...
 * }
 */

export function cookingStatus(remainingTime)
{
    if(remainingTime === 0) {return "Lasagna is done."}
    if(typeof remainingTime === 'number') {return "Not done, please wait."}
    else{ return "You forgot to set the timer."}
}

export function preparationTime(layers, timePerLayer = 2)
{
    const length = layers.length; 
    return length * timePerLayer; 
}

export function quantities(layers)
{   
    let noodlesGrams = 0; 
    let sauceLiters = 0; 

    for(let layer of layers)
    {
        if(layer.toLowerCase() === 'noodles') { noodlesGrams += 50; }
        if(layer.toLowerCase() === 'sauce') { sauceLiters += .2; }
        console.log(layer.toLowerCase)

    }

    return {noodles : noodlesGrams,
            sauce: sauceLiters}
}

export function addSecretIngredient(friendsList, myList)
{
    myList.push(friendsList[friendsList.length - 1])
}

export function scaleRecipe(recipe, numberOfPortions)
{
    const newRecipe = {}

    for(const key in recipe)
    {
        newRecipe[key] = recipe[key] * numberOfPortions / 2;
    }

    return newRecipe;
}
    