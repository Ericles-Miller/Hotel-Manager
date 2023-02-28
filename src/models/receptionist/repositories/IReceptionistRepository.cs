
namespace IReceptionistRepository {
    
    public interface IReceptionistRepository {
        void ListReceptionist();
        List<Receptionist> createReceptionist(string address, string name,int number);
        bool findByNumber(int number);
    }
}