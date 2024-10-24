using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ENUM_AgentsTag : MonoBehaviour
{
    public enum AgentsType
    {
        CONQUEROR, HOPLITE, ARTILLERY, MERCENARY, PALADIN, INVOKER, OUTLANDER, NAVIGATOR, SENTINEL
        /*
         * C.H.A.M.P.I.O.N.S. roles for agents
         * Conqueror -> Attacker/DMG - short range damaging (if death can revives)
         * Hoplite -> half tank half attacker role with skills of parrying (if death can revives)
         * Artillery -> ranger/archer , long range (if death can revives)
         * Mercenary -> random type of agents but with condition that you need to think a lot (if death CANNOT revives)
         * Paladin -> guardians tank roles with max power of defenses (if death CANNOT revives)
         * Invoker -> buffer and debuffer (if death CANNOT revives)
         * Outlander -> [not in the map] special agents that we can connect with (shop, special interactions) // can't pick but can increase the chances
         * Navigator -> [not in the map] supporter you can call supporting skill by using points
         * Sentinel -> [not in the map] builder but there are special buildings that you can build differently each agent
         * 
         * 
         * Conqueror/Hoplite/Artillery are main roles that need to be revive if they died
         * Mercenary/Paladin/Invoker are support roles that can be used to combine with first three roles
         * Outlander/Navigator/Sentinel are other roles
         */
    }


    //EXTRAIDEAS - We may not need this
    private enum AgentsAttackType
    {
        NONE, PHYSIC, FLAME, FROZEN, HURRICANE, CRYSTAL, STARLIGHT, SHOCK, NEON, BLAST
        /*
         * Aillments that enemies can take if they weaken to and got armor break
         * Physic - Multiply damage that coming
         * Flame - Take a damage and Make enemies create path of fire in the way that they came
         * Frozen - Make enemies dont move for a while
         * Hurricane - push enemies away with others nearby too
         * Crystal - Make enemies freeze and block the path of enemies
         * Starlight - turn into star that come to our skill charge gauge
         * Shock - Make enemies stunned and have a chance to do extra critical damage
         * Glitch - 
         * Blast - if break bomb aoe damage to the nearby enemies and itself
         */
    }
}
