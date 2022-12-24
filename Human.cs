public class Human{

	public string Name { get; private set; } = "Lyceum Student";

	private int _age = 0;
	public int Age{
		get => _age;
		set{
			if(value >= 0) _age = value;
		}
	}

	private float _weight = 0f;
	public float WeightKG{
		get => _weight;
		set{
			if(value >= 0f) _weight = value;
		}
	}

	public Human(){}

	public Human(string name){

		Name = name;

	}

}