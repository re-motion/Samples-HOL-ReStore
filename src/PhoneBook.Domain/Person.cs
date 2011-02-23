using Remotion.Data.DomainObjects;
using Remotion.Data.DomainObjects.ObjectBinding;
// using Remotion.Globalization;

namespace PhoneBook.Domain
{
  [DBTable]
  // [MultiLingualResourcesAttribute("PhoneBook.Domain.Globalization.Person")]
  public class Person : BindableDomainObject
  {
    [StringProperty(MaximumLength = 60)]
    public virtual string FirstName { get; set; }

    [StringProperty(IsNullable = false, MaximumLength = 60)]
    public virtual string Surname { get; set; }

    public virtual Location Location { get; set; }

    [DBBidirectionalRelation("Person", SortExpression = "CountryCode,AreaCode,Number,Extension")]
    public virtual ObjectList<PhoneNumber> PhoneNumbers { get; set; }

    public static Person NewObject()
    {
      return DomainObject.NewObject<Person>();
    }

    public static Person GetObject(ObjectID objid)
    {
      return DomainObject.GetObject<Person>(objid);
    }

    public override string DisplayName
    {
      get { return Surname; }
    }

  }
}