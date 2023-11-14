namespace C__proje2{
public class TeamMember
	{
        public int ID { get; set; }
		public string MemberName { get; set; }	
		public TeamMember(int id, string membername)
		{
			this.ID = id;
			this.MemberName = membername;
		}
    }}