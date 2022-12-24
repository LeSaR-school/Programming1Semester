using System.Collections.ObjectModel;

public class Student : Human{

	private List<int> _marks = new List<int>();
	public ReadOnlyCollection<int> Marks{ get => _marks.AsReadOnly(); }

	public Student() : base(){}
	public Student(string name) : base(name){}
	public Student(string name, List<int> marks) : base(name){

		foreach(int mark in marks)
			if(mark >= 0 && mark <= 5) _marks.Add(mark);

	}

	public void AddMark(int mark){

		if(mark >= 0 && mark <= 5) _marks.Add(mark);

	}

	public int CountMarks(int target){

		if(target < 0 || target > 5) return 0;

		int c = 0;
		foreach(int mark in _marks) if(mark == target) c++;
		return c;

	}

	public float AverageMark{
		get{

			int sum = 0;
			foreach(int mark in _marks) sum += mark;
			return MathF.Round((float) sum / _marks.Count * 100) / 100f;

		}
	}

	public bool BetterThan(Student? other){

		if(other == null) return true;

		// compare mark averages
		float averageMarkDiff = this.AverageMark - other.AverageMark;

		if(averageMarkDiff > 0) return true;
		else if(averageMarkDiff < 0) return false;

		// if averages are same, compare number of individual marks, from 5 to 1
		for(int i = 5; i > 1; i--){
			
			int diff = this.CountMarks(i) - other.CountMarks(i);

			if(diff > 0) return true;
			else if(diff < 0) return false;

		}
		
		// if marks are same, compare age
		if(this.Age > other.Age) return true;
		if(this.Age < other.Age) return false;

		// if age is same, comapre weight
		if(this.WeightKG > other.WeightKG) return true;
		if(this.WeightKG < other.WeightKG) return false;

		return false;

	}

}