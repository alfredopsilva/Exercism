// @ts-check
//
// ☝🏽 The line above enables type checking for this file. Various IDEs interpret
// the @ts-check directive. It will give you helpful autocompletion on the web
// and supported IDEs when implementing this exercise. You don't need to
// understand types, JSDoc, or TypeScript in order to complete this JavaScript
// exercise, and can completely ignore this comment block and directive.

// 👋🏽 Hi again!
//
// A quick reminder about exercise stubs:
//
// 💡 You're allowed to completely clear any stub before you get started. Often
// we recommend using the stub, because they are already set-up correctly to
// work with the tests, which you can find in ./freelancer-rates.spec.js.
//
// 💡 You don't need to write JSDoc comment blocks yourself; it is not expected
// in idiomatic JavaScript, but some companies and style-guides do enforce them.
//
// Get those rates calculated!

/**
 * The day rate, given a rate per hour
 *
 * @param {number} ratePerHour
 * @returns {number} the rate per day
 */


/**
 * Calculates the number of days in a budget, rounded down
 *
 * @param {number} budget: the total budget
 * @param {number} ratePerHour: the rate per hour
 * @returns {number} the number of days
 */


/**
 * Calculates the discounted rate for large projects, rounded up
 *
 * @param {number} ratePerHour
 * @param {number} numDays: number of days the project spans
 * @param {number} discount: for example 20% written as 0.2
 * @returns {number} the rounded up discounted rate
 */
export const dayRate = hourlyRate => {
  return hourlyRate * 8;
};

export const daysInBudget = (fixedBudget, hourlyRate) => {
  return Math.floor((fixedBudget / hourlyRate) / 8) ;
};

export const priceWithMonthlyDiscount = (hourlyRate, daysOfProject, monthlyDiscount) => {
    //Every Month has 22 billing days
    // daysOfProject / billingDays = mes

    let billingDays = 22; 
    let dailyHours = 8;

    // Calculate how many months this project will be.
    let monthOfProject = Math.floor((daysOfProject / billingDays));

    //Calculate How Many hours this project will be
    let howManyHoursInAProject = ((billingDays * monthOfProject) * dailyHours);

    // Calculate the hourly rate with the discount applied 
    let hourlyRateWithDiscount = (hourlyRate - (hourlyRate * monthlyDiscount))


    if(monthlyDiscount){
      let monthlyCost = (howManyHoursInAProject * hourlyRateWithDiscount );
      let dailyCost = (((daysOfProject - (billingDays * monthOfProject) ) * 8) * hourlyRate )

      let totalCost = (monthlyCost + dailyCost);
      return Math.ceil(totalCost);
       
      
    } else {
      let monthlyCost = (howManyHoursInAProject * hourlyRate );
      let dailyCost = (((daysOfProject - (billingDays * monthOfProject) ) * 8) * hourlyRate )
    
      let totalCost = (monthlyCost + dailyCost);
      return Math.ceil(totalCost);
      
    }
}

