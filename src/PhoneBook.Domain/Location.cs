using Remotion.Data.DomainObjects;
using Remotion.Data.DomainObjects.ObjectBinding;

namespace PhoneBook.Domain
{
  [DBTable]
  public class Location : BindableDomainObject
  {
    [StringProperty(IsNullable = false, MaximumLength = 60)]
    public virtual string Street { get; set; }

    [StringProperty(IsNullable = true, MaximumLength = 12)]
    public virtual string Number { get; set; }

    [StringProperty(MaximumLength = 60)]
    public virtual string City { get; set; }

    public virtual int ZipCode { get; set; }

    public static Location NewObject()
    {
      return DomainObject.NewObject<Location>();
    }

    public static Location GetObject(ObjectID objid)
    {
      return DomainObject.GetObject<Location>(objid);
    }

    public override string DisplayName
    {
      get { return Street; }
    }
  }
}
