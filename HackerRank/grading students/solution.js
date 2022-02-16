function gradingStudents(grades) {
    let n = grades.length, k = n - 1, cond, newGrades = [];
    if(1 <= n <= 60){
        for(let i = 0; i <= k; i++){
            cond = Math.ceil(grades[i]/5)*5
            if(0 <= grades[i] <= 100){
                if(grades[i] >= 38 && (Math.abs(grades[i] - cond) < 3)){
                    newGrades.push(cond)
                } else {
                    newGrades.push(grades[i])
                }
            }
        }
    }
    return newGrades
    
}