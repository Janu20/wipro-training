interface ISupportTicket
{
   public void CreateTicket(string issue);
    public void ResolveTicket(int ticketId);
}
internal class EmailSupport : ISupportTicket
{
    public void CreateTicket(string issue)
    {
        Console.WriteLine("Creating ticket via Email " + issue);
    }
    public void ResolveTicket(int ticketId)
    {
        Console.WriteLine("Resolving ticket "+ticketId+" via Email " );
    }
}
internal class PhoneSupport : ISupportTicket
{
    public void CreateTicket(string issue)
    {
        Console.WriteLine("Creating ticket via Phone" + issue);
    }
    public void ResolveTicket(int ticketId)
    {
        Console.WriteLine("Resolving ticket " + ticketId + " via Phone ");
    }
}
    class Program
    {

        public static void Main()
        {
            ISupportTicket IS;
            IS = new EmailSupport();
            IS.CreateTicket("Incorrect data submission");
            IS.ResolveTicket(876390);
            IS = new PhoneSupport();
            IS.CreateTicket("Incorrect data submission");
            IS.ResolveTicket(9978690);


        }
    }
