    internal class Class3
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Work started");
            await Task.Delay(500);

            await DoAsyncWork();

            Console.WriteLine("Work completed..");
        }
        static async Task DoAsyncWork()
        {
            Console.WriteLine("Working...");
           await Task.Delay(2000);
            Console.WriteLine("Async work done");
            await Task.Delay(1000);
        }
    }

//he await keyword tells C#:

//“Pause here until the asynchronous operation completes, and then continue with the rest of the method.”

//So when you write:


//await DoSomethingAsync();
//You're saying:

//Run DoSomethingAsync()

//Wait for it to finish (non-blocking)

//Then continue with the next line of code


//You think the 2-second delay is working, but it's not. This line:


//Task.Delay(2000); // ❌ No await!
//Just starts a delay task, but it doesn’t wait for it to complete. So Console.WriteLine("Async work done"); executes immediately after "Working...".

//✅ What You Should Write
//To actually pause for 2 seconds:


//await Task.Delay(2000); // ✅ Proper delay