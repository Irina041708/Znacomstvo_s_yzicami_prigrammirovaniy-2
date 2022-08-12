int a1 = 15;
int b1 = 25;
int c1 = 35;

int a2 = 45;
int b2 = 163;
int c2 = 65;

int a3 = 75;
int b3 = 85;
int c3 = 3;

int max = a1;

if (max < b1) max = b1;
if (max < c1) max = c1;

if (max < a2) max = a2;
if (max < b2) max = b2;
if (max < c2) max = c2;

if (max < a3) max = a3;
if (max < b3) max = b3;
if (max < c3) max = c3;

Console.WriteLine (max);
