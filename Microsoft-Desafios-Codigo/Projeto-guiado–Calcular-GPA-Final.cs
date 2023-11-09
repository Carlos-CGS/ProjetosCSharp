string studentName = "Sophia Johnson";
string course1Name = "English 101";
string course2Name = "Algebra 101";
string course3Name = "Biology 101";
string course4Name = "Computer Science I";
string course5Name = "Psychology 101";

int course1Credit = 3;
int course2Credit = 3;
int course3Credit = 4;
int course4Credit = 4;
int course5Credit = 3;

int gradeA = 4;
int gradeB = 3;

int course1Grade = gradeA;
int course2Grade = gradeB;
int course3Grade = gradeB;
int course4Grade = gradeB;
int course5Grade = gradeA;

decimal course1 = course1Grade * course1Credit; 
decimal course2 = course2Grade * course2Credit; 
decimal course3 = course3Grade * course3Credit; 
decimal course4 = course4Grade * course4Credit; 
decimal course5 = course5Grade * course5Credit; 
decimal total = course1 + course2 + course3 + course4 + course5;
decimal totalCreditos = course1Credit + course2Credit + course3Credit + course4Credit + course5Credit;
decimal valorGPA = total / totalCreditos;

Console.WriteLine("Student: "+ studentName);

Console.WriteLine("\nCourse\t\t"+ "\tGrade\t" + "Credit Hours");
Console.WriteLine(course1Name + "\t\t\t" + course1Grade + "\t\t" + course1Credit);
Console.WriteLine(course2Name + "\t\t\t" + course2Grade + "\t\t" + course2Credit);
Console.WriteLine(course3Name + "\t\t\t" + course3Grade + "\t\t" + course3Credit);
Console.WriteLine(course4Name + "\t" + course4Grade + "\t\t" + course4Credit);
Console.WriteLine(course5Name + "\t\t" + course5Grade + "\t\t" + course5Credit);

Console.WriteLine($"\nFinal GPA:\t\t\t{valorGPA:F2}");