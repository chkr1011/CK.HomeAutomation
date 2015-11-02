﻿using System;

namespace HA4IoT.Contracts.Actuators
{
    public interface IButton : IActuatorBase
    {
        event EventHandler PressedShort;

        event EventHandler PressedLong;
    }
}