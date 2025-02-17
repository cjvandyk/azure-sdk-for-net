// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> Describes the properties of a secret object value. </summary>
    public partial class ContainerRegistrySecretObject
    {
        /// <summary> Initializes a new instance of <see cref="ContainerRegistrySecretObject"/>. </summary>
        public ContainerRegistrySecretObject()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContainerRegistrySecretObject"/>. </summary>
        /// <param name="value">
        /// The value of the secret. The format of this value will be determined
        /// based on the type of the secret object. If the type is Opaque, the value will be
        /// used as is without any modification.
        /// </param>
        /// <param name="objectType">
        /// The type of the secret object which determines how the value of the secret object has to be
        /// interpreted.
        /// </param>
        internal ContainerRegistrySecretObject(string value, ContainerRegistrySecretObjectType? objectType)
        {
            Value = value;
            ObjectType = objectType;
        }

        /// <summary>
        /// The value of the secret. The format of this value will be determined
        /// based on the type of the secret object. If the type is Opaque, the value will be
        /// used as is without any modification.
        /// </summary>
        public string Value { get; set; }
        /// <summary>
        /// The type of the secret object which determines how the value of the secret object has to be
        /// interpreted.
        /// </summary>
        public ContainerRegistrySecretObjectType? ObjectType { get; set; }
    }
}
