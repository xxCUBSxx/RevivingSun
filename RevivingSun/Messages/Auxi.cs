﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RevivingSun.Messages
{
    public class Auxi : AbstractMessage
    {
        public override string _Name { get => "auxi"; }

        public string TEXT { get; set; } = "";

        public override void Process(AbstractEAServer context, EAClient client)
        {
            var mc = context as MatchmakerServer;
            if (mc == null) return;

            var user = client.User;
            if (user == null) return;

            user.Auxiliary = TEXT;
            client.SendMessage(this);
        }
    }
}
