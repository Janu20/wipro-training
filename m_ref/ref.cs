class Program
{
    public static void Main()
    {
        Dictionary<string, string> contacts = new Dictionary<string, string>();

        contacts.Add("9940199368", "Govin");
        contacts.Add("8754465098", "Padma");
        contacts.Add("7398665258", "Janani");
        contacts.Add("9847477966", "Deepak");
        contacts.Add("9765488745", "Tom");

        contacts.Remove("Padma");
        contacts.Add("875445074", "Padma");

        if (contacts.ContainsValue("Janani"))
        {
            Console.WriteLine("'Janani' is present");
        }
        else
        {

            Console.WriteLine("'Janani' is present");            
        }
        
        foreach (KeyValuePair<string,string> item in contacts){

            Console.WriteLine("Number : " + item.Key + " Names : " + item.Value);

        }
    }
}
