/**
 * @param {number} n
 * @return {number[]}
 */
var sumZero = function(n) {
    let arr=[];
    for(i=1;i<=Math.floor(n/2);i++){
            arr.push(-i);
            arr.push(i);
    }

        if(n%2!==0){
            arr.push(0);
        }
    return arr;
    
};