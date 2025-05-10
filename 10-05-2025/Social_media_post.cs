using System;

 class SocialMedia
{
    public virtual void Post(){
        Console.WriteLine("Posting on social media");
    }
}

class FacebookPost:SocialMedia
{
    public override void Post(){
        Console.WriteLine("Posting on Facebook");
    }
}

class InstagramPost : SocialMedia
{
    public override void Post(){
    Console.WriteLine("Posting on Instagram");
}
}
class TwitterPost:SocialMedia
{
    public override void Post(){
        
    Console.WriteLine("Posting on Twitter");
}
}
class Program{
    public static void Main(string[] args)
    {
      FacebookPost FP = new FacebookPost(); 
      
      TwitterPost TP = new TwitterPost();
      
      InstagramPost IP = new InstagramPost();
      
      Console.WriteLine("---Object of FacebookPost---");
      FP.Post();
      
      Console.WriteLine(" ");
      
      Console.WriteLine("---Object of TwitterPost---");
      TP.Post();
      
     Console.WriteLine(" ");
     
      Console.WriteLine("---Object of InstagramPost---");
      IP.Post();
      
      SocialMedia SMF = new FacebookPost();
      SocialMedia SMT = new TwitterPost();
      SocialMedia SMI = new InstagramPost();
      
     Console.WriteLine(" ");
        
      Console.WriteLine("---Object of InstagramPost using SocialMedia reference---");
      SMI.Post();
      
      Console.WriteLine(" ");
      
      Console.WriteLine("---Object of TwitterPost using SocialMedia reference---");
      SMT.Post();
      
        Console.WriteLine(" ");
      
      Console.WriteLine("---Object of FacebookPost using SocialMedia reference---");
      SMF.Post();
    }
}