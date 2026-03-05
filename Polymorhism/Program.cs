public class uni_member
{
	private string name1;
	public string memberid { get; }
	protected List<string> ActionLog { get; } = new List<string>();

	public string Name
	{
		get => name1;
		set => name1 = value;
	}
}
//public int count1 => countlog.Count;
protected uni_member(string name, string id)
{
	Name = name;
	memberid = id;
}
public class UniversityRegistry
{
	private List<uni_member> members = new List<uni_member>();
	public void add_member(uni_member m)
	{
		members.Add(m);
	}
	public void PerformDuties()
	{
		foreach (var member in members)
		{
			try
			{
				member.PerformDuties();
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Помилка {member:Name}: {ex.Message}");
			}
		}
	}

	public int member_stat()
	{
		int total_acts = 0;
		foreach (var member in members)
		{
		}

		return total_acts;
	}
}
public class student : uni_member
{
	public student(string name, string id) : base(name, id) { }

	public override void PerformDuties()
	{
		base.PerformDuties();
		ActionLog.Add("лабораторка завершена");
		Console.WriteLine($"{name} оновився");
	}
	
}
