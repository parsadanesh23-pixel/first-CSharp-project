string name="parsa";
string name1="";
string quest="";

string pass="1234";
string pass1="";
string word="exit";
static void done()
{
    Console.WriteLine("everything done, welcome !");
}

Console.WriteLine("gave anything, if you want to exit, type exit: ");
quest=Console.ReadLine();
if (quest==word)
{
    Console.WriteLine("ok");
}
else
{
    Console.WriteLine("enter your name: ");
    name1=Console.ReadLine();
    if (name1!=name)
    {
        while (name1!=name)
        {
            Console.WriteLine("try again: ");
            name1=Console.ReadLine();
        }
        Console.WriteLine("now gave your password: ");
        pass1=Console.ReadLine();
        if (pass1==pass)
        {
            done();
        }
        else
        {
            while (pass1!=pass)
            {
                Console.WriteLine("try again: ");
                pass1=Console.ReadLine();
            }
            done();
        }
    }
    else
    {
        Console.WriteLine("name has done");
        Console.WriteLine("now enter your password: ");
        pass1=Console.ReadLine();
        
        if (pass1==pass)
        {
            done();
        }
        else
        {
            while (pass1!=pass)
            {
                Console.WriteLine("try again");
                pass1=Console.ReadLine();
            }
            done();
        }
    }
}
    