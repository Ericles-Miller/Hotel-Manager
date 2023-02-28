 namespace Controller
{
  public class CreateReceptionistController{
    CreateReceptionistUseCase createReceptionistUseCase;
    public CreateReceptionistController(CreateReceptionistUseCase createReceptionistUseCase){
      this.createReceptionistUseCase = createReceptionistUseCase;
    }
    
    public void handle(string address, string name, int number) {
                  
      var receptionists = createReceptionistUseCase.execute( address, name, number);
      Console.Clear();

    //   Console.WriteLine("Data insert with success!");
    //   Console.WriteLine(receptionists.Count);
    //   foreach(var receptionist in receptionists){
    //     Console.WriteLine(receptionist.Id);
    //     Console.WriteLine(receptionist.Address);
    //     Console.WriteLine(receptionist.Name);
    //     Console.WriteLine(receptionist.Number);
        
      }
    }
  }
