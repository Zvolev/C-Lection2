// нахождение максимума из 9ти чисел

int a1 = 76;
int b1 = 67;
int c1 = 23;
int a2 = 89;
int b2 = 67;
int c2 = 45;
int a3 = 44;
int b3 = 567;
int c3 = 24;

int max = a1;

if(max<b1) max=b1;
if(max<c1) max=c1;
if(max<a2) max=a2;
if(max<b2) max=b2;
if(max<c2) max=c2;
if(max<a3) max=a3;
if(max<b3) max=b3;
if(max<c3) max=c3;

Console.WriteLine(max);