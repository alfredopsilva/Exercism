// @ts-check
//
// The line above enables type checking for this file. Various IDEs interpret
// the @ts-check directive. It will give you helpful autocompletion when
// implementing this exercise.

/**
 * Determines how long it takes to prepare a certain juice.
 *
 * @param {string} name
 * @returns {number} time in minutes
 */
export function timeToMixJuice(name) {
  
  let preparationTime = null; 

  switch(name){
    case "Pure Strawberry Joy":
      preparationTime = 0.5; 
      break;
    case "Energizer":
    case "Green Garden":
      preparationTime = 1.5; 
      break; 
    case "Tropical Island":
      preparationTime = 3; 
      break; 
    case "All or Nothing":
      preparationTime = 5; 
      break;
    default: 
      preparationTime = 2.5; 
      break; 
  }

  return preparationTime;

}

/**
 * Calculates the number of limes that need to be cut
 * to reach a certain supply.
 *
 * @param {number} wedgesNeeded
 * @param {string[]} limes
 * @returns {number} number of limes cut
 */
export function limesToCut(wedgesNeeded, limes) {
  
  let numberOfWedges = 0; 
  let counter = 0;

  for(let lime of limes)
  {
    if(numberOfWedges  < wedgesNeeded){
      if(lime === 'small')
      {
        numberOfWedges += 6; 
        counter ++
      }
      if(lime === 'medium')
      {
        numberOfWedges += 8;
        counter ++
      }
      if(lime === 'large')
      {
        numberOfWedges += 10;
        counter ++
      }
    }
  }

  return counter; 
}

/**
 * Determines which juices still need to be prepared after the end of the shift.
 *
 * @param {number} timeLeft
 * @param {string[]} orders
 * @returns {string[]} remaining orders after the time is up
 */
export function remainingOrders(timeLeft, orders) {

  let count = 0;
  let timeToMakeDrinks = 0;


  for (let drinks of orders) {
      if (timeToMakeDrinks < timeLeft) {
          timeToMakeDrinks += timeToMixJuice(drinks);
          count++;
          console.log(drinks)
      }
  }
  for (let i = 0; i <= count - 1; i++) {
      orders.shift(); 
  }

  return orders;

}