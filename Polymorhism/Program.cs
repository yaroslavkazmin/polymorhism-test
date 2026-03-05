public class UniversityRegistry
{
	public static void Main()
	{
	private List<uni_member> members = new List<uni_member>();
	public void add_member(uni_member m)
	{
		members.Add(m);}
	public void execute()
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
		int total_acts = 0
			foreach(var member in members)
			{}
			return total_acts;
	}
	}
}