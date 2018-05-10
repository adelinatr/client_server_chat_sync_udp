using System.Data.Entity;

namespace ClientChatWF
{
	public class UserContext : DbContext
	{
		public UserContext() :
			base()
		{

		}
		public DbSet<User> Users { set; get; }
	}
}