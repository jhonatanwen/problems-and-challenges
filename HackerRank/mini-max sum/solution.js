function miniMaxSum(arr) {
    let min = 0, max = 0;
    /*I don't know why, but that thing in "array.sort()" works, I saw this in MDN Web Docs. 
    Basically, if you write a function like this:
    Function functionName(a,b){
        return a - b
    };
    Or this one:
    (a,b) => a - b;
    Inside the "array.sort()" it will make the array be organized numerically.
    It is different from the normal ".sort()" that is organized by the unicode value.
    You can see the MDN documentation here: encurtador.com.br/agsJY.
    */
    let ar = arr.sort((a,b) => a - b), n = arr.length - 1;
    //for loops everyday
    for(i = 0; i <= n; i++){
        //I think that the constraints can be improved in the condition settings of the "if" command bellow, BUT, for the resolution of the tests in HackerRank, it went perfectly fine.
        if(1<=ar[0] && ar[n]<=10**9){
            if(i <= (n-1)){
                min += ar[i];
            }
            if(i > 0){
                max += ar[i];
            }
        }
    }
    console.log(min, max);

}
