﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using Xunit;

namespace Microsoft.Azure.WebJobs.Host.UnitTests
{
    public class RetryAttributeTests
    {
        [Fact]
        public void FixedDelay_Constructor_Expected()
        {
            var retry = new FixedDelayRetryAttribute(5, "01:02:25");
            Assert.Equal(5, retry.MaxRetryCount);

            retry = new FixedDelayRetryAttribute(-1, "00:00:10");
            Assert.Equal(-1, retry.MaxRetryCount);
        }
    }
}
