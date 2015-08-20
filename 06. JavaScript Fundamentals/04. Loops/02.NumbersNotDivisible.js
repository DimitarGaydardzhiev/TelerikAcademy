//Write a script that prints all the numbers from  1  to  N , that are not divisible by  3  and  7  at the same time

var i,
    N = 100;

for (i = 1; i < N; i++) {
    if (i%21){
        console.log(i);
    }
}