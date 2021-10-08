using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Stylist
  {
    public Stylist()
    {
      this.Clients = new HashSet<Client>();
    }
    public int CuisineId { get; set; }
    public string Name { get; set; }
    public virtual ICollections<Client> Clients { get; set; }
  }
}