int[] sophia = {93, 87, 98, 95, 100};
int[] nicholas = {80, 83, 82, 88, 85};
int[] zahirah = {84, 96, 73, 85, 79};
int[] jeong = { 90, 92, 98, 100, 97};
int i;
decimal gradeS = 0.0m;
decimal avgS = 0.0m;
decimal gradeN = 0.0m;
decimal avgN = 0.0m;
decimal gradeZ = 0.0m;
decimal avgZ = 0.0m;
decimal gradeJ = 0.0m;
decimal avgJ = 0.0m;
for (i= 0; i <= 4; i++){
    gradeS = (sophia[i] + gradeS);
}
avgS = gradeS / 5;
for (i= 0; i <= 4; i++){
    gradeN = nicholas[i] + gradeN;
}
avgN = gradeN / 5;
for (i= 0; i <= 4; i++){
    gradeZ = zahirah[i] + gradeZ;
}
avgZ = gradeZ / 5;
for (i= 0; i <= 4; i++){
    gradeJ = jeong[i] + gradeJ;
}
avgJ = gradeJ / 5;

Console.WriteLine("Student    Grade");
Console.WriteLine($"Sophia:    {avgS}\tA");
Console.WriteLine($"Nicholas:  {avgN}\tB");
Console.WriteLine($"Zahirah:   {avgZ}\tB");
Console.WriteLine($"Jeong:     {avgJ}\tA");