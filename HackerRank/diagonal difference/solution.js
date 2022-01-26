function diagonalDifference(arr) {
    var n = (arr.length - 1)
    var dlr=0, drl=0
    //'dlr' stands for 'diagonal left-to-right'
    //'drl' stands for 'diagonal right-to-left'
        for(let i = 0; i <= n; i++){
            dlr += arr[i][i]  
            drl += arr[i][n-i]
        }
    return Math.abs(dlr-drl)
}