namespace index {

    public class {
        
        var receptionistRepository = new ReceptionistRepository();
        var createdReceptionistUseCase = new CreateReceptionistUseCase(receptionistRepository);
        var createReceptionistController = new CreateReceptionistController(createdReceptionistUseCase);
    }
}