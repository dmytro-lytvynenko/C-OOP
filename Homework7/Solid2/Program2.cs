using System;
using System.Collections.Generic;

//Який принцип S.O.L.I.D. порушено? Виправте!

/*Зверніть увагу на клас EmailSender. Крім того, що за допомогою методу Send, він відправляє повідомлення, 
він ще і вирішує як буде вестися лог. В даному прикладі лог ведеться через консоль.
Якщо трапиться так, що нам доведеться міняти спосіб логування, то ми будемо змушені внести правки в клас EmailSender.
Хоча, здавалося б, ці правки не стосуються відправки повідомлень. Очевидно, EmailSender виконує кілька обов'язків і, 
щоб клас ні прив'язаний тільки до одного способу вести лог, потрібно винести вибір балки з цього класу.*/
class Email
{
    public String Theme { get; set; }
    public String From { get; set; }
    public String To { get; set; }
}

class EmailSender
{
    public void Send(Email email)
    {
        // ... sending...
    }
}

interface IEmailFormatter
{
    void FormatReport(Email email);
}

class ShortFormFormatter : IEmailFormatter
{
    public void FormatReport(Email email) { 
        Console.WriteLine("Email was sent");
    }
}

class ToFormFormatter : IEmailFormatter
{
    public void FormatReport(Email email) { 
        Console.WriteLine("Email to '" + email.To + "' was sent");
    }
}

class FromFormFormatter : IEmailFormatter
{
    public void FormatReport(Email email) { 
        Console.WriteLine("Email from '" + email.From + "' was sent");
    }
}

class UniversalFormFormatter : IEmailFormatter
{
    public void FormatReport(Email email) { 
        Console.WriteLine("Email from '" + email.From + "' to '" + email.To + "' was sent");
    }
}


class EmailPrinter
{
    public void Print(Email email, IEmailFormatter formatter) { 
        formatter.FormatReport(email);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Email e1 = new Email() { From = "Me", To = "Vasya", Theme = "Who are you?" };
        Email e2 = new Email() { From = "Vasya", To = "Me", Theme = "vacuum cleaners!" };
        Email e3 = new Email() { From = "Kolya", To = "Vasya", Theme = "No! Thanks!" };
        Email e4 = new Email() { From = "Vasya", To = "Me", Theme = "washing machines!" };
        Email e5 = new Email() { From = "Me", To = "Vasya", Theme = "Yes" };
        Email e6 = new Email() { From = "Vasya", To = "Petya", Theme = "+2" };

        EmailSender es = new EmailSender();
        EmailPrinter ep = new EmailPrinter();

        ShortFormFormatter sf = new ShortFormFormatter();
        ToFormFormatter tf = new ToFormFormatter();
        FromFormFormatter ff = new FromFormFormatter();
        UniversalFormFormatter uf = new UniversalFormFormatter();

        es.Send(e1); ep.Print(e1,sf);
        es.Send(e2); ep.Print(e2,tf);
        es.Send(e3); ep.Print(e3,ff);
        es.Send(e4); ep.Print(e4,uf);
        es.Send(e5); ep.Print(e5,uf);
        es.Send(e6); ep.Print(e6,uf);

        Console.ReadKey();
    }
}