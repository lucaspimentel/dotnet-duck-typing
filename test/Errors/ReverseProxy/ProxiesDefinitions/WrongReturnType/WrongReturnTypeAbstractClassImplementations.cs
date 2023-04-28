// <copyright file="WrongReturnTypeAbstractClassImplementations.cs" company="Datadog">
// Unless explicitly stated otherwise all files in this repository are licensed under the Apache 2 License.
// This product includes software developed at Datadog (https://www.datadoghq.com/). Copyright 2017 Datadog, Inc.
// </copyright>

namespace Datadog.Trace.DuckTyping.Tests.Errors.ReverseProxy.ProxiesDefinitions.WrongReturnType
{
    // These types implicitly implement various classes
    public class WrongReturnTypeAbstractClassImplementations
    {
        [ReverseTypeToTest("Datadog.DuckTyping.Tests.Errors.ReverseProxy.OriginalTypeDefinitions.AbstractClasses+AbstractMethod")]
        public class AbstractMethod
        {
            [DuckReverseMethod]
            public string TryGetValue(string value) => value;
        }

        [ReverseTypeToTest("Datadog.DuckTyping.Tests.Errors.ReverseProxy.OriginalTypeDefinitions.AbstractClasses+AbstractMethodWithOutParam")]
        public class AbstractMethodWithOutParam
        {
            [DuckReverseMethod]
            public void TryGetValue(out string value)
            {
                value = "woop";
            }
        }

        [ReverseTypeToTest("Datadog.DuckTyping.Tests.Errors.ReverseProxy.OriginalTypeDefinitions.AbstractClasses+AbstractMethodWithRefParam")]
        public class AbstractMethodWithRefParam
        {
            [DuckReverseMethod]
            public string TryGetValue(ref string value)
            {
                value = "woop";
                return string.Empty;
            }
        }

        [ReverseTypeToTest("Datadog.DuckTyping.Tests.Errors.ReverseProxy.OriginalTypeDefinitions.AbstractClasses+AbstractGenericMethod")]
        public class AbstractGenericMethod
        {
            [DuckReverseMethod]
            public int Echo<T>(T value) => 100;
        }

        [ReverseTypeToTest("Datadog.DuckTyping.Tests.Errors.ReverseProxy.OriginalTypeDefinitions.AbstractClasses+AbstractGetOnlyProperty")]
        public class AbstractGetOnlyProperty
        {
            [DuckReverseMethod]
            public int Value { get; }
        }

        [ReverseTypeToTest("Datadog.DuckTyping.Tests.Errors.ReverseProxy.OriginalTypeDefinitions.AbstractClasses+AbstractProperty")]
        public class AbstractProperty
        {
            [DuckReverseMethod]
            public int Value { get; set; }
        }

        [ReverseTypeToTest("Datadog.DuckTyping.Tests.Errors.ReverseProxy.OriginalTypeDefinitions.AbstractClasses+AbstractMethodWithVirtualMethod")]
        public class AbstractMethodWithVirtualMethod
        {
            [DuckReverseMethod]
            public string TryGetValue(string value) => value;
        }

        [ReverseTypeToTest("Datadog.DuckTyping.Tests.Errors.ReverseProxy.OriginalTypeDefinitions.AbstractClasses+AbstractMethodWithOutParamWithVirtualMethod")]
        public class AbstractMethodWithOutParamWithVirtualMethod
        {
            [DuckReverseMethod]
            public void TryGetValue(out string value)
            {
                value = "woop";
            }
        }

        [ReverseTypeToTest("Datadog.DuckTyping.Tests.Errors.ReverseProxy.OriginalTypeDefinitions.AbstractClasses+AbstractMethodWithRefParamWithVirtualMethod")]
        public class AbstractMethodWithRefParamWithVirtualMethod
        {
            [DuckReverseMethod]
            public string TryGetValue(ref string value)
            {
                value = "woop";
                return value;
            }
        }

        [ReverseTypeToTest("Datadog.DuckTyping.Tests.Errors.ReverseProxy.OriginalTypeDefinitions.AbstractClasses+AbstractGenericMethodWithVirtualMethod")]
        public class AbstractGenericMethodWithVirtualMethod
        {
            [DuckReverseMethod]
            public int Echo<T>(T value) => 100;
        }

        [ReverseTypeToTest("Datadog.DuckTyping.Tests.Errors.ReverseProxy.OriginalTypeDefinitions.AbstractClasses+AbstractGetOnlyPropertyWithVirtualMethod")]
        public class AbstractGetOnlyPropertyWithVirtualMethod
        {
            [DuckReverseMethod]
            public int Value { get; }
        }

        [ReverseTypeToTest("Datadog.DuckTyping.Tests.Errors.ReverseProxy.OriginalTypeDefinitions.AbstractClasses+AbstractPropertyWithVirtualMethod")]
        public class AbstractPropertyWithVirtualMethod
        {
            [DuckReverseMethod]
            public int Value { get; set; }
        }

        [ReverseTypeToTest("Datadog.DuckTyping.Tests.Errors.ReverseProxy.OriginalTypeDefinitions.AbstractClasses+AbstractMethodWithVirtualProperty")]
        public class AbstractMethodWithVirtualProperty
        {
            [DuckReverseMethod]
            public string TryGetValue(string value) => value;
        }

        [ReverseTypeToTest("Datadog.DuckTyping.Tests.Errors.ReverseProxy.OriginalTypeDefinitions.AbstractClasses+AbstractMethodWithOutParamWithVirtualProperty")]
        public class AbstractMethodWithOutParamWithVirtualProperty
        {
            [DuckReverseMethod]
            public void TryGetValue(out string value)
            {
                value = "woop";
            }
        }

        [ReverseTypeToTest("Datadog.DuckTyping.Tests.Errors.ReverseProxy.OriginalTypeDefinitions.AbstractClasses+AbstractMethodWithRefParamWithVirtualProperty")]
        public class AbstractMethodWithRefParamWithVirtualProperty
        {
            [DuckReverseMethod]
            public string TryGetValue(ref string value)
            {
                value = "woop";
                return value;
            }
        }

        [ReverseTypeToTest("Datadog.DuckTyping.Tests.Errors.ReverseProxy.OriginalTypeDefinitions.AbstractClasses+AbstractGenericMethodWithVirtualProperty")]
        public class AbstractGenericMethodWithVirtualProperty
        {
            [DuckReverseMethod]
            public int Echo<T>(T value) => 100;
        }

        [ReverseTypeToTest("Datadog.DuckTyping.Tests.Errors.ReverseProxy.OriginalTypeDefinitions.AbstractClasses+AbstractGetOnlyPropertyWithVirtualProperty")]
        public class AbstractGetOnlyPropertyWithVirtualProperty
        {
            [DuckReverseMethod]
            public int Value { get; }
        }

        [ReverseTypeToTest("Datadog.DuckTyping.Tests.Errors.ReverseProxy.OriginalTypeDefinitions.AbstractClasses+AbstractPropertyWithVirtualProperty")]
        public class AbstractPropertyWithVirtualProperty
        {
            [DuckReverseMethod]
            public int Value { get; set; }
        }
    }
}
