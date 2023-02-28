namespace  Receptionist {
    public class Receptionist {
    public Guid Id { get; private set; }
    public string Name { get; set; }
    public int Number { get; set; }
    public string Address { get; set; }
    public Receptionist( string address, string name, int number) {
        Id = Guid.NewGuid();
        Address = address;
        Name = name;
        Number = number;
    }
  }
}
