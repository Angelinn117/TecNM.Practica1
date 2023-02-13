using TecNM.Practica1.Core.Entities;
using TecNM.Practica1.Core.Managers.Interfaces;
using TecNM.Practica1.Core.Services.Interfaces;

namespace TecNM.Practica1.Core.Managers;

public class MarsManager : IMarsManager{

    private readonly IMarsService _service;

    public MarsManager(IMarsService service){
        _service = service;
    }

    public Mars GetMars(Person person){
        return _service.ProcessMars(person);
    }

}