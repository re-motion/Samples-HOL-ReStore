using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PhoneBook.Domain;
using Remotion.Data.DomainObjects;

namespace PhoneBook.Sample
{
  class Program
  {
    static void EnterBenita()
    {
      using (ClientTransaction.CreateRootTransaction().EnterDiscardingScope())
      {
        var loc = Location.NewObject();
        loc.Street = "Brahmsplatz";
        loc.Number = "4";
        loc.City = "Vienna";
        loc.ZipCode = 1040;

        var p = Person.NewObject();
        p.FirstName = "Benita";
        p.Surname = "Ferrero-Waldner";
        p.Location = loc;

        var pn = PhoneNumber.NewObject();
        pn.CountryCode = "0043";
        pn.AreaCode = "664";
        pn.Number = "13";

        pn.Person = p;

        ClientTransaction.Current.Commit();
      }
    }

    static void EnterMausi()
    {
      using (ClientTransaction.CreateRootTransaction().EnterDiscardingScope())
      {
        var loc = Location.NewObject();
        loc.Street = "Gablenzgasse";
        loc.Number = "5 - 13";
        loc.City = "Vienna";
        loc.ZipCode = 1150;

        var p = Person.NewObject();
        p.FirstName = "Mausi";
        p.Surname = "Lugner";
        p.Location = loc;

        var pn = PhoneNumber.NewObject();
        pn.CountryCode = "0043";
        pn.AreaCode = "676";
        pn.Number = "888-7777";

        pn.Person = p;

        ClientTransaction.Current.Commit();
      }
    }

    static void EnterJeannine()
    {
      using (ClientTransaction.CreateRootTransaction().EnterDiscardingScope())
      {
        var loc = Location.NewObject();
        loc.Street = "Hietzinger Hauptstraße";
        loc.Number = "133";
        loc.City = "Vienna";
        loc.ZipCode = 1130;

        var p = Person.NewObject();
        p.FirstName = "Jeannine";
        p.Surname = "Schiller";
        p.Location = loc;

        var pn = PhoneNumber.NewObject();
        pn.CountryCode = "0043";
        pn.AreaCode = "650";
        pn.Number = "555-6729";

        pn.Person = p;

        ClientTransaction.Current.Commit();
      }
    }

    static void EnterElvisAndOsama()
    {
      using (ClientTransaction.CreateRootTransaction().EnterDiscardingScope())
      {
        var loc = Location.NewObject();
        loc.Street = "Hasenleitengasse";
        loc.Number = "4";
        loc.City = "Vienna";
        loc.ZipCode = 1110;

        var p1 = Person.NewObject();
        p1.FirstName = "Elvis";
        p1.Surname = "Presley";
        p1.Location = loc;

        var pn1 = PhoneNumber.NewObject();
        pn1.CountryCode = "0043";
        pn1.AreaCode = "1";
        pn1.Number = "555-4780";
        pn1.Person = p1;

        var p2 = Person.NewObject();
        p2.FirstName = "Osama";
        p2.Surname = "bin Laden";
        p2.Location = loc;

        var pn2 = PhoneNumber.NewObject();
        pn2.CountryCode = "0043";
        pn2.AreaCode = "1";
        pn2.Number = "555-4781";
        pn2.Person = p2;

        ClientTransaction.Current.Commit();
      }
    }

    static void EnterGünter()
    {
      using (ClientTransaction.CreateRootTransaction().EnterDiscardingScope())
      {
        var loc = Location.NewObject();
        loc.Street = "Aspangstr";
        loc.Number = "53";
        loc.City = "Vienna";

        var p = Person.NewObject();
        p.FirstName = "Günther";
        p.Surname = "Tolar";
        p.Location = loc;

        var pn = PhoneNumber.NewObject();
        pn.CountryCode = "0043";
        pn.AreaCode = "0664";
        pn.Number = "101 6666";

        pn.Person = p;

        ClientTransaction.Current.Commit();
      }
    }

    static void EnterProminente()
    {
      EnterBenita();
      EnterGünter();
      EnterJeannine();
      EnterMausi();
      EnterElvisAndOsama();
    }
    static void EnterFreud()
    {
      using (ClientTransaction.CreateRootTransaction().EnterDiscardingScope())
      {
        var location = Location.NewObject();
        location.City = "Vienna";
        location.Street = "Berggassse";
        location.Number = "19";
        location.ZipCode = 1090;

        Person person = Person.NewObject();
        person.FirstName = "Sigmund";
        person.Surname = "Freud";
        person.Location = location;

        var pn = PhoneNumber.NewObject();
        pn.CountryCode = "0043";
        pn.AreaCode = "1";
        pn.Number = "3286386";
        pn.Extension = "";
        pn.Person = person;

        ClientTransaction.Current.Commit();
      }
    }

    static void EnterBalint()
    {
      using (ClientTransaction.CreateRootTransaction().EnterDiscardingScope())
      {
        var location = Location.NewObject();
        location.City = "Vienna";
        location.Street = "Schiffamtsgasse";
        location.Number = "5";
        location.ZipCode = 1020;

        Person person = Person.NewObject();
        person.FirstName = "Balint";
        person.Surname = "Hegedüs";
        person.Location = location;

        var pn = PhoneNumber.NewObject();
        pn.CountryCode = "0043";
        pn.AreaCode = "676";
        pn.Number = "7244199";
        pn.Extension = "";
        pn.Person = person;

        ClientTransaction.Current.Commit();
      }
    }

    //static void Report()
    //{
    //  using (ClientTransaction.CreateRootTransaction().EnterDiscardingScope())
    //  {
    //    foreach (var l in Location.GetLocations())
    //    {
    //      Console.WriteLine("Location: {0}", l.DisplayName);
    //      foreach (var p in l.FindPersons())
    //      {
    //        Console.WriteLine(" ---> Person: {0} ", p.DisplayName);
    //        foreach (var pn in p.PhoneNumbers)
    //        {
    //          Console.WriteLine(" -----------------> Tel: {0}", pn.DisplayName);
    //        }
    //      }
    //    }
    //  }
    //}

    //static void DeleteMakeHomeless()
    //{
    //  while (true)
    //  {
    //    using (ClientTransaction.CreateRootTransaction().EnterDiscardingScope())
    //    {
    //      int index = 0;
    //      var locations = Location.GetLocations();
    //      foreach (var l in locations)
    //      {
    //        Console.WriteLine("{3} -> Country: {1} City: {0} Street; {2}", l.City, l.Country, l.Street, ++index);
    //      }
    //      Console.WriteLine("Bitte geben Sie den Index des zu löschenden Locations-Objektes an ( 0 für exit )");
    //      string inp = Console.ReadLine();
    //      int delInd;
    //      if (!int.TryParse(inp, out delInd) || delInd < 0 || delInd > locations.Length)
    //      {
    //        Console.WriteLine("Ungültige Eingabe !");
    //        continue;
    //      }
    //      if (delInd == 0)
    //      {
    //        break;
    //      }
    //      locations[delInd - 1].DeleteMakeHomelesse();
    //      ClientTransaction.Current.Commit();
    //    }
    //  }

    //}


    static void Main(string[] args)
    {
      EnterFreud();
      EnterBalint();
      EnterProminente();
      // Report();
      //DeleteMakeHomeless();
    }
  }
}
