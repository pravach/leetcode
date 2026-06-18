/**
 * @param {string} s
 * @return {number}
 */
var lengthOfLastWord = function(s) {
    let lengthOfLastWord = s.trim().split(" ").pop().length;
    return lengthOfLastWord;


    
};