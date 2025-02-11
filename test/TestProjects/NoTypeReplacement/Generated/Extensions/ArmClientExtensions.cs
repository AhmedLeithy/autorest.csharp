// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager;

namespace NoTypeReplacement
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public static partial class ArmClientExtensions
    {
        #region NoTypeReplacementModel1
        /// <summary> Gets an object representing a NoTypeReplacementModel1 along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="NoTypeReplacementModel1" /> object. </returns>
        public static NoTypeReplacementModel1 GetNoTypeReplacementModel1(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new NoTypeReplacementModel1(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region NoTypeReplacementModel2
        /// <summary> Gets an object representing a NoTypeReplacementModel2 along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="NoTypeReplacementModel2" /> object. </returns>
        public static NoTypeReplacementModel2 GetNoTypeReplacementModel2(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new NoTypeReplacementModel2(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region NoTypeReplacementModel3
        /// <summary> Gets an object representing a NoTypeReplacementModel3 along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="NoTypeReplacementModel3" /> object. </returns>
        public static NoTypeReplacementModel3 GetNoTypeReplacementModel3(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new NoTypeReplacementModel3(clientOptions, credential, uri, pipeline, id));
        }
        #endregion
    }
}
