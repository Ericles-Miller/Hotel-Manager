namespace CreateReceptionistUseCase
{
    public interface IRepositoryReceptionistDTO
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public int number { get; set; }
    }

    public class CreateReceptionistUseCase
    {
        ReceptionistRepository receptionistRepository;
        public CreateReceptionistUseCase(ReceptionistRepository receptionistRepository)
        {
            this.receptionistRepository = receptionistRepository;
        }
        public List<Receptionist> execute(string address, string name, int number)
        {
            var receptionistAlreadyExists = receptionistRepository.findByNumber(number);

            if (receptionistAlreadyExists)
            {
                Console.WriteLine("Receptionist already exists! Insert other number to the receptionist");
                number = int.Parse(Console.ReadLine());
            }
            var receptionist = receptionistRepository.createReceptionist(address, name, number);
            return receptionist;
        }
    }
}
