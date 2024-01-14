string name = "Sophia Johnson";
string[] course = {"English 101", "Algebra 101", "Biology 101", "Computer Science I", "Psycology 101"};
int[] grade = {3, 4};
int[] creditHours = {3, 4};

int[] gradePoint = {(grade[1]*creditHours[0]), (grade[0]*creditHours[0]), (grade[0]*creditHours[1]), (grade[0]*creditHours[1]), (grade[1]*creditHours[0])};
int totalGradePoint = gradePoint[0] + gradePoint[1] + gradePoint[2] + gradePoint[3] + gradePoint[4];
int totalCreditHours = creditHours[0] + creditHours[0] + creditHours[1] + creditHours[1] + creditHours[0];
decimal gpa = (decimal) totalGradePoint/totalCreditHours;

Console.WriteLine($"Student: {name}");
Console.Write("\n");
Console.WriteLine("Course\t\t\t\t   Grade  Credit Hours");
Console.WriteLine(course[0] + "\t\t\t\t" + grade[1] + "\t\t" + creditHours[0]);
Console.WriteLine(course[1] + "\t\t\t\t" + grade[0] + "\t\t" + creditHours[0]);
Console.WriteLine(course[2] + "\t\t\t\t" + grade[0] + "\t\t" + creditHours[1]);
Console.WriteLine(course[3] + "\t\t" + grade[0] + "\t\t" + creditHours[1]);
Console.WriteLine(course[4] + "\t\t\t" + grade[1] + "\t\t" + creditHours[0]);
Console.Write("\n");
Console.WriteLine($"Final GPA: {gpa:0.##}");