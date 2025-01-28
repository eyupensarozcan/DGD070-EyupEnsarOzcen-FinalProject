using System.Collections;
using System.Collections.Generic;
using Entitas;
using UnityEngine;

public class CheckPlayerHealthSystem : IExecuteSystem
{
    private Contexts _contexts;

    public CheckPlayerHealthSystem(Contexts contexts)
    {
        _contexts = contexts;
    }

    public void Execute()
    {
        GameEntity[] npc = _contexts.game.GetEntities();

        foreach (GameEntity i in npc)
        {
            if (i.hasPlayerHealth)
            {
                if (i.isPlayerDamaged)
                {
                    float entityHealth = i.playerHealth.Value - 10;

                    if (entityHealth < 0)
                    {
                        entityHealth = 0;
                    }

                    i.ReplacePlayerHealth(entityHealth);
                    i.isPlayerDamaged = false;
                }

                if (i.isPlayerHealed)
                {
                    float npcHealth = i.playerHealth.Value + 10;

                    if (npcHealth > 100) npcHealth = 100;
                    

                    i.ReplacePlayerHealth(npcHealth);
                    i.isPlayerHealed = false;
                }
            }
        }
    }
}