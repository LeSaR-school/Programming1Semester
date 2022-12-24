List<Student> students = new List<Student>();

while(true){

	Console.Write("Enter student name: ");
	string? name = Console.ReadLine();

	Console.Write("Enter student age: ");
	int age = Int32.Parse(Console.ReadLine() ?? "18");

	Console.Write("Enter student weight (kg): ");	
	float weight = float.Parse(Console.ReadLine() ?? "50");

	Console.Write("Enter student makrs (seperated by spaces): ");
	string[] marks = (Console.ReadLine() ?? "").Split(" ");



	Student newStudent;
	if(name != null)
		newStudent = new Student(name);
	else
		newStudent = new Student();

	newStudent.Age = age;
	newStudent.WeightKG = weight;
	foreach(string mark in marks) newStudent.AddMark(Int32.Parse(mark));

	Console.WriteLine($"Created student {newStudent.Name}, {newStudent.Age} years old, {newStudent.WeightKG} kg, average mark {newStudent.AverageMark}");

	students.Add(newStudent);

	Console.WriteLine("Create another (Y/n)? ");
	if((Console.ReadLine() ?? "Y").ToLower() == "n") break;

}

Student? bestStudent = null;

foreach(Student student in students) if(student.BetterThan(bestStudent)) bestStudent = student;

if(bestStudent != null)
	Console.WriteLine($"Best student is {bestStudent.Name}, {bestStudent.Age} years old, {bestStudent.WeightKG} kg, average mark {bestStudent.AverageMark}");
