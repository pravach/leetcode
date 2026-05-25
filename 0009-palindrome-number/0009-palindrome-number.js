/**
 * @param {number} x
 * @return {boolean}
 */
 function isPalindrome(num) {

    let str = num.toString();
    let rev = "";

    for (let i = str.length - 1; i >= 0; i--) {
        rev += str[i];
    }

    return str === rev;
}


 


