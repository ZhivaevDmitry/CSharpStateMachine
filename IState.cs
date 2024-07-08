/*
 * File: IState.cs
 * Description: Main State Interface
 * Author: Dmitry Zhivaev
 * Date: 2024-Jul-08
 * License: Apache License 2.0
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0
 */

#nullable enable

using System;

namespace Cuwan.StateMachine
{
    public interface IStateMachineCallback
    {
        void HandleLeft(IState sender_, IState nextState_);
        void HandleLeftWithException(IState sender_, Exception e_);
        Exception? OptCaughtException { get; }
    }

    public interface IState
    {
        void Enter(IStateMachineCallback stateMachineCallback_); // No throw

        void Leave(bool immediately_); // No throw
    }    
}

#nullable restore