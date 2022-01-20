﻿// <copyright file="IWrongFieldObject.cs" company="Datadog">
// Unless explicitly stated otherwise all files in this repository are licensed under the Apache 2 License.
// This product includes software developed at Datadog (https://www.datadoghq.com/). Copyright 2017 Datadog, Inc.
// </copyright>

namespace Datadog.Trace.DuckTyping.Tests.Errors.Properties.TypeChaining.ProxiesDefinitions
{
    public interface IWrongFieldObject
    {
        [DuckField]
        int WrongNumber { get; set; }

        ITypesTuple this[ITypesTuple index] { get; set; }
    }
}
