using TecNM.Practica1.Core.Entities;
using TecNM.Practica1.Core.Services.Interfaces;

namespace TecNM.Practica1.Core.Services;

public class MarsService: IMarsService{

    public Mars ProcessMars(Person person){

        var mars = new Mars();
        var marsGravity = 3.721;
        var earthGravity = 9.81;
        var massPerson = person.Weight/earthGravity;
        mars.Weight = (float)((person.Weight / earthGravity)*(marsGravity));

        return mars;

    }

}