using System;

public class ChatBot
{
    
   public void  Respond(string name)
   {
       
       Console.WriteLine("Hi, How are you " + name +"!!!!");
       
   }
   public void Respond (string question,bool formal )
   {
       Console.WriteLine("*Give me the question* : "+ question+" *The answer is* :- "+formal);
   }
    
  public void Respond (int num){
      Console.WriteLine("*How many states in India  * :- " + " "+num);
      
  }
    public static void Main(string[] args)
    {
       ChatBot ob = new ChatBot();
       ob.Respond("Janani");
       ob.Respond("Is a cat a mammal ? " , true);
       ob.Respond(27);
    }
}