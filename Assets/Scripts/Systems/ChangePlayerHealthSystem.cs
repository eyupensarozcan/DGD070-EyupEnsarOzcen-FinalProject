using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;

public class ChangePlayerHealthSystem : IExecuteSystem
{
    
    private Contexts _contexts;

    public ChangePlayerHealthSystem(Contexts contexts)
    {
        
        _contexts = contexts;
        
    }

    public void Execute()
    {
        GameEntity[] npc = _contexts.game.GetEntities();

        foreach (GameEntity i in npc)
        {
            if(i.hasPlayerHealth)
            {
                if (Input.GetKeyDown(KeyCode.D))  i.isPlayerDamaged = true;
                

                if (Input.GetKeyDown(KeyCode.H))  i.isPlayerHealed = true;
                
            }
        }
    }
}