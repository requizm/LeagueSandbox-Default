﻿using GameServerCore.Enums;
using static LeagueSandbox.GameServer.API.ApiFunctionManager;
using LeagueSandbox.GameServer.GameObjects.AttackableUnits.AI;
using LeagueSandbox.GameServer.GameObjects.Spells;
using LeagueSandbox.GameServer.Scripting.CSharp;

namespace HealCheck
{
    internal class HealCheck : IBuffGameScript
    {
        private Buff _healBuff;

        public void OnActivate(ObjAiBase unit, Spell ownerSpell)
        {
            _healBuff = AddBuffHudVisual("SummonerHealCheck", 35.0f, 1, BuffType.COMBAT_DEHANCER, unit);
        }

        public void OnDeactivate(ObjAiBase unit)
        {
            RemoveBuffHudVisual(_healBuff);
        }

        public void OnUpdate(double diff)
        {

        }
    }
}
