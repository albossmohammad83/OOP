using System;
public class WebDeveloper : Developer, SelfDeveloping
{   
     public WebDeveloper(string mainDevLanguage) : base(mainDevLanguage)
   {

   }

     public void Develop()
    {
        Console.WriteLine("I develop my self watching udemy web Development courses.");
    }
}