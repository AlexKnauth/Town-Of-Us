using System.Collections.Generic;
using UnityEngine;

namespace TownOfUs.Roles
{
    public class VoteBouncer : Role
    {

        public readonly List<bool> ListOfActives = new List<bool>();
        public readonly List<GameObject> Buttons = new List<GameObject>();


        public VoteBouncer(PlayerControl player) : base(player)
        {
            Name = "Vote-Bouncer";
            ImpostorText = () => "Shield a crewmate from being voted out";
            TaskText = () => "Shield a crewmate from being voted out";
            // hex #33A633 = rgb 20% 65% 20%
            Color = new Color(0.2f, 0.65f, 0.2f, 1f);
            RoleType = RoleEnum.VoteBouncer;
        }
    }
}
