using System.Collections.Generic;

namespace OrderOrganizer.Models
{
  public class Vendor
  {
    private static List<Vendor> _instances = new List<Vendor> {};
    public string Description { get; set; }
    public string VendorName { get; set; }
    public int Id { get; }

    public Vendor(string vendor, string description)
    {
      Description = description;
      VendorName = vendor;
      _instances.Add(this);
      Id = _instances.Count;

    }

  }
}