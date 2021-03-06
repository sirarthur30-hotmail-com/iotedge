// Copyright (c) Microsoft. All rights reserved.
namespace Microsoft.Azure.Devices.Edge.Util.Test
{
    using System.Threading.Tasks;
    using Microsoft.Azure.Devices.Edge.Util.Test.Common;
    using Xunit;

    public class KeyVaultHelperTest
    {
        [Fact]
        [Integration]
        public async Task GetSecretTest()
        {
            string secret = await SecretsHelper.GetSecret(/* Dummy secret I added for testing */ "DummySecret1");
            Assert.False(string.IsNullOrWhiteSpace(secret));
        }
    }
}
