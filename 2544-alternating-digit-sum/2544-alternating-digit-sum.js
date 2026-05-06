/**
 * @param {number} n
 * @return {number}
 */
var alternateDigitSum = function(n) {
    let str = n.toString();
  let sum = 0;
  let sign = 1;

  for (let i = 0; i < str.length; i++) {
    sum += sign * Number(str[i]);
    sign *= -1;
  }

  return sum;
    
};