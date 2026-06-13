/**
 * @param {number[]} nums
 * @return {number[]}
 */
var getConcatenation = function(nums) {
    let ans=nums.concat(nums);
    return ans;
    
};
let nums = [1,2,1];
console.log(getConcatenation(nums));