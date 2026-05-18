using System;
using System.Collections.Generic;
using System.Text;

namespace RemnantLib.code.abstracts
{
    //spell class that will eventually become a virtual or abstract class

    //functions within this spell should be able to be overriden in order to determine custom spell behaviour, but should also have a host of default behaviours for easy spell creation
    public class Spell
    {



        /*
        Example pseudocode of an override function that can be changed to give custom behaviour
        
        override FlightPath flightPath(float DeltaTime)
        {
            FlightPath path = new FlightPath();
            path.velocity.forward += 20 * DeltaTime;
            path.velocity.up += 10 * DeltaTime;
            return path
        }
        This behaviour would cause the flight path of the spell to accelerate forward, and then accelerate upwards at half the rate its going forward

        This behaviour would then be accessed by the spell builder like this and used in the instancing of the spell

        SpellEntity.flightPath = Spell.flightPath(dt);

        we want as many of these generic behaviours to be modify-able as possible to ensure the spell class is as abstract as possible and spells are as custom as possible
        */
    }
}
