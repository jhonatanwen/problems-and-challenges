function countingValleys(steps, path) {
    const pathArray = path.split('')
    let seaLevel = 0
    let actStep = 0
    let lastStep = 0
    let valleys = 0
    
    for(let i = 0; i < steps; i++) {
        switch(pathArray[i]) {
            case 'U':
                lastStep = actStep
                actStep++
                break
            case 'D':
                lastStep = actStep
                actStep--
                break
        }
        
        if(i > 0) {
            if(actStep > lastStep && actStep === seaLevel) {
                valleys++
            }
        }
    }

    return valleys
}
