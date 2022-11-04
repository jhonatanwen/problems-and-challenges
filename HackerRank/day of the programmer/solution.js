function leapDay(value, y) {
    if(value){
        return `12.09.${y}`
    } else {
        return `13.09.${y}`
    }
}

function dayOfProgrammer(year) {
    if(year >= 1700 && year <= 1917) {
        if(year % 4 === 0) {
            return leapDay(true, year)
        } else {
            return leapDay(false, year)
        }
    }
    
    if(year === 1918) {
        return '26.09.1918'
    }
    
    if((year % 400 === 0) 
    ^ 
    (((year % 4 === 0) && (year % 100 !== 0)))) {
        return leapDay(true, year)
    } else {
        return leapDay(false, year)
    }
}