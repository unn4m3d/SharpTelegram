﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SharpTelegram.Schema.MethodsImpl.Ex.cs">
//   Copyright (c) 2013-2014 Alexander Logger. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using Catel.Reflection;
using SharpMTProto;

namespace SharpTelegram.Schema.Layer18
{
    public partial class TelegramAsyncMethods
    {
        partial void SetupRemoteProcedureCaller(IRemoteProcedureCaller remoteProcedureCaller)
        {
            remoteProcedureCaller.PrepareSerializersForAllTLObjectsInAssembly(
                typeof (ITelegramAsyncMethods).GetAssemblyEx());
        }
    }
}
