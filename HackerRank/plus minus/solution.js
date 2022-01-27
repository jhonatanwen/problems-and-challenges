function plusMinus(arr) {
    let m = arr.length
    let pos=0, neg=0, zro=0
    if(0 < m && m <= 100){
        for(let i = 0;i < m; i++){
            if(-100 <= arr[i] && arr[i] <= 100){
                if(arr[i]>0){
                    pos++
                }else if(arr[i]<0){
                    neg++
                }else{
                    zro++
                }
            }else{
                continue
            }
        }
        let posr = pos/m
        let negr = neg/m
        let zror = zro/m
        console.log(posr.toFixed(6))
        console.log(negr.toFixed(6))
        console.log(zror.toFixed(6))
    }
}
//yup, very messy.
