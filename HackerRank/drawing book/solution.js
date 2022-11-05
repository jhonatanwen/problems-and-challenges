function pagesFacesToArray(n) {
    const pageFaces = [1]
    let k = 1
    
    if(n % 2 === 0) {
        for(let i = 1; i <= Math.floor(n / 2); i++) {
            if((2*k + 1) === (n - 1)) {
                pageFaces[i] = [2*k, (2*k + 1)]
                pageFaces.push(n)
                break
            }
            pageFaces[i] = [2*k, (2*k + 1)]
            k++
        }
    } else {
        for(let i = 1; i <= Math.floor(n / 2); i++) {
            pageFaces[i] = [2*k, (2*k + 1)]
            k++
        }
    }
    
    
    return pageFaces
}

function pageCount(n, p) {
    if(p === 1 || (p === n && n % 2 === 0)) {
        return 0
    }
    
    let pages = pagesFacesToArray(n)
    
    if((p - 1) >= (n - p)) pages = pages.reverse()
    
    for(let i = 0; i < pages.length; i++) {
        console.log(pages[i])
        if(pages[i] === 1 || pages[i] === n) {
            continue
        } else if(pages[i].find(page => page === p)){
            return i
        }
    }
}
