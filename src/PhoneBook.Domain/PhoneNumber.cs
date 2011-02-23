using Remotion.Data.DomainObjects;
using Remotion.Data.DomainObjects.ObjectBinding;


namespace PhoneBook.Domain
{
  [DBTable]
  public class PhoneNumber : BindableDomainObject
  {
    [StringProperty(MaximumLength = 8)]
    public virtual string CountryCode { get; set; }

    [StringProperty(MaximumLength = 8)]
    public virtual string AreaCode { get; set; }

    [StringProperty(MaximumLength = 12, IsNullable = false)]
    public virtual string Number { get; set; }

    [StringProperty(MaximumLength = 8)]
    public virtual string Extension { get; set; }

    public static PhoneNumber NewObject()
    {
      return DomainObject.NewObject<PhoneNumber>();
    }

    public static PhoneNumber GetObject(ObjectID objid)
    {
      return DomainObject.GetObject<PhoneNumber>(objid);
    }

    public override string DisplayName
    {
      get { return Number; }
    }

    [DBBidirectionalRelation("PhoneNumbers")]
    public virtual Person Person { get; set; }

  }
}
