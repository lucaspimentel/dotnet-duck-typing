// <copyright file="WrongArgumentTypeAbstractClassImplementations.cs" company="Datadog">
// Unless explicitly stated otherwise all files in this repository are licensed under the Apache 2 License.
// This product includes software developed at Datadog (https://www.datadoghq.com/). Copyright 2017 Datadog, Inc.
// </copyright>

namespace Datadog.Trace.DuckTyping.Tests.Errors.ReverseProxy.ProxiesDefinitions.WrongArgumentType
{
    // These types implicitly implement various classes
    public class WrongArgumentTypeAbstractClassImplementations
    {
        [ReverseTypeToTest("Datadog.DuckTyping.Tests.Errors.ReverseProxy.OriginalTypeDefinitions.AbstractClasses+AbstractMethod")]
        public class AbstractMethod
        {
            [DuckReverseMethod]
            public bool TryGetValue(int value) => true;
        }

        [ReverseTypeToTest("Datadog.DuckTyping.Tests.Errors.ReverseProxy.OriginalTypeDefinitions.AbstractClasses+AbstractMethodWithOutParam")]
        public class AbstractMethodWithOutParam
        {
            [DuckReverseMethod]
            public bool TryGetValue(out int value)
            {
                value = 100;
                return true;
            }
        }

        [ReverseTypeToTest("Datadog.DuckTyping.Tests.Errors.ReverseProxy.OriginalTypeDefinitions.AbstractClasses+AbstractMethodWithRefParam")]
        public class AbstractMethodWithRefParam
        {
            [DuckReverseMethod]
            public bool TryGetValue(ref int value)
            {
                value = 100;
                return true;
            }
        }

        [ReverseTypeToTest("Datadog.DuckTyping.Tests.Errors.ReverseProxy.OriginalTypeDefinitions.AbstractClasses+AbstractGenericMethod")]
        public class AbstractGenericMethod
        {
            [DuckReverseMethod]
            public T Echo<T>(int value) => default;
        }

        [ReverseTypeToTest("Datadog.DuckTyping.Tests.Errors.ReverseProxy.OriginalTypeDefinitions.AbstractClasses+AbstractMethodWithVirtualMethod")]
        public class AbstractMethodWithVirtualMethod
        {
            [DuckReverseMethod]
            public bool TryGetValue(int value) => true;
        }

        [ReverseTypeToTest("Datadog.DuckTyping.Tests.Errors.ReverseProxy.OriginalTypeDefinitions.AbstractClasses+AbstractMethodWithOutParamWithVirtualMethod")]
        public class AbstractMethodWithOutParamWithVirtualMethod
        {
            [DuckReverseMethod]
            public bool TryGetValue(out int value)
            {
                value = 100;
                return true;
            }
        }

        [ReverseTypeToTest("Datadog.DuckTyping.Tests.Errors.ReverseProxy.OriginalTypeDefinitions.AbstractClasses+AbstractMethodWithRefParamWithVirtualMethod")]
        public class AbstractMethodWithRefParamWithVirtualMethod
        {
            [DuckReverseMethod]
            public bool TryGetValue(ref int value)
            {
                value = 100;
                return true;
            }
        }

        [ReverseTypeToTest("Datadog.DuckTyping.Tests.Errors.ReverseProxy.OriginalTypeDefinitions.AbstractClasses+AbstractGenericMethodWithVirtualMethod")]
        public class AbstractGenericMethodWithVirtualMethod
        {
            [DuckReverseMethod]
            public T Echo<T>(int value) => default;
        }

        [ReverseTypeToTest("Datadog.DuckTyping.Tests.Errors.ReverseProxy.OriginalTypeDefinitions.AbstractClasses+AbstractMethodWithVirtualProperty")]
        public class AbstractMethodWithVirtualProperty
        {
            [DuckReverseMethod]
            public bool TryGetValue(int value) => true;
        }

        [ReverseTypeToTest("Datadog.DuckTyping.Tests.Errors.ReverseProxy.OriginalTypeDefinitions.AbstractClasses+AbstractMethodWithOutParamWithVirtualProperty")]
        public class AbstractMethodWithOutParamWithVirtualProperty
        {
            [DuckReverseMethod]
            public bool TryGetValue(out int value)
            {
                value = 100;
                return true;
            }
        }

        [ReverseTypeToTest("Datadog.DuckTyping.Tests.Errors.ReverseProxy.OriginalTypeDefinitions.AbstractClasses+AbstractMethodWithRefParamWithVirtualProperty")]
        public class AbstractMethodWithRefParamWithVirtualProperty
        {
            [DuckReverseMethod]
            public bool TryGetValue(ref int value)
            {
                value = 100;
                return true;
            }
        }

        [ReverseTypeToTest("Datadog.DuckTyping.Tests.Errors.ReverseProxy.OriginalTypeDefinitions.AbstractClasses+AbstractGenericMethodWithVirtualProperty")]
        public class AbstractGenericMethodWithVirtualProperty
        {
            [DuckReverseMethod]
            public T Echo<T>(int value) => default;
        }
    }
}
