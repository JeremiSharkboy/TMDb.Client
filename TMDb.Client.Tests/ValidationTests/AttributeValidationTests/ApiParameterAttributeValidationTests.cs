﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using TMDB.Core.Api;
using TMDB.Core.Attributes;
using Xunit;

namespace TMDB.Core.Tests.ValidationTests.AttributeTests
{
    public class ApiParameterAttributeValidationTests
    {
        private readonly IEnumerable<Type> _requestTypes;

        public ApiParameterAttributeValidationTests()
        {
            _requestTypes = Assembly
                .GetAssembly(typeof(RequestBase))
                .GetTypes()
                .Where(t => t.IsSubclassOf(typeof(RequestBase)));
        }

        [Fact]
        public void ApiParameterAttribute_HaveNameTest()
        {
            var props = _requestTypes
                .Select(type => type.GetProperties())
                .SelectMany(propInfo => propInfo)
                .Where(propInfo => 
                {
                    var attr = propInfo.GetCustomAttribute<ApiParameterAttribute>();
                    return attr != null ? string.IsNullOrEmpty(attr.Name) : false;
                })
                .Select(propInfo => propInfo.Name);

            Assert.True(props.Count() == 0, "Bad properties: " + string.Join(", ", props));
        }

        [Fact]
        public void ApiParameterAttribute_HaveParameterTypeTest()
        {
            var message = "Bad properties: ";
            var badPropertyCount = 0;
            foreach (var type in _requestTypes)
            {
                foreach (var propInfo in type.GetProperties())
                {
                    if (propInfo.GetCustomAttribute<ApiParameterAttribute>()?.ParameterType == ParameterType.NotSet)
                    {
                        message += $"{type.Name}.{propInfo.Name}, ";
                        badPropertyCount++;
                    }
                }
            }

            Assert.True(badPropertyCount == 0, message);
        }
    }
}