

namespace ReceptionistRepository
{
    public class ReceptionistRepository : IReceptionistRepository
    {
      private List<Receptionist> receptionists = new List<Receptionist>();

      public List<Receptionist> createReceptionist(string address, string name, int number)
      {   
         // add condiction to verify if exists receptionist add
         receptionists.Add(new Receptionist(address, name, number));
         return receptionists;
      }

      public bool findByNumber(int number)
      {
         var searchNumber = receptionists.Exists(item => item.Number == number);
         return searchNumber;
      }

      public void ListReceptionist()
      {
         throw new NotImplementedException();
      }
   }
}