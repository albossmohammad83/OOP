using System;

public class Developer
{
    private string _mainDevLanguage;
 
    public Developer(string mainDevLanguage)
    {
        this._mainDevLanguage = mainDevLanguage;   
    }
    public virtual void Code()
    {
        Console.WriteLine("I'm Coding using my main dev language {0}", this._mainDevLanguage);
    }
     public virtual void Code(string extraLanguage)
    {
        Console.WriteLine("I'm Coding using my main dev language {0}. Additionally, I am using {1} as extra dev language", 
        this._mainDevLanguage, extraLanguage);
    }
    public virtual void Code(string firstDevLanguage, string secondDevLanguage)
    {
        Console.WriteLine("I'm Coding using my main dev language {0}. Additionally, I am using {1} and {2} as extra dev languages", 
        this._mainDevLanguage, firstDevLanguage, secondDevLanguage);
    }
}
    