abstract class TicketBooking
{
    public abstract void BookTicket(int seat);

    public void ShowBookingInfo()
    {
        Console.WriteLine("Booking tickets");
    }
}
    internal class BusBooking : TicketBooking
    {
        public override void BookTicket(int seat)
        {
            Console.WriteLine("BUS :");
            Console.WriteLine("The ticket fair is 500");
            Console.WriteLine("No of seats you booked is " + seat);
            Console.WriteLine("No of seats x bus tickets fair");
            

            int amount = seat * 500;
            Console.WriteLine("Total amount = " + amount);
        }
    }
internal class FlightBooking : TicketBooking
{
    public override void BookTicket(int seat)
    {
        Console.WriteLine("FLIGHT :");
        Console.WriteLine("The ticket fair is 10000");
        Console.WriteLine("No of seats you booked is " + seat);
        Console.WriteLine("No of seats x bus tickets fair");

        int amount = seat * 10000;
        Console.WriteLine("Total amount = " + amount);
    }
}
class Program
{
 
    static void Main()
    {
        TicketBooking tb;

        tb = new BusBooking();
        tb.BookTicket(2);

        tb = new FlightBooking();
        tb.BookTicket(5);
;


    }
}
