// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Request parameters for tiering cost info for vault. </summary>
    public partial class FetchTieringCostSavingsInfoForVaultContent : FetchTieringCostInfoContent
    {
        /// <summary> Initializes a new instance of <see cref="FetchTieringCostSavingsInfoForVaultContent"/>. </summary>
        /// <param name="sourceTierType"> Source tier for the request. </param>
        /// <param name="targetTierType"> target tier for the request. </param>
        public FetchTieringCostSavingsInfoForVaultContent(RecoveryPointTierType sourceTierType, RecoveryPointTierType targetTierType) : base(sourceTierType, targetTierType)
        {
            ObjectType = "FetchTieringCostSavingsInfoForVaultRequest";
        }

        /// <summary> Initializes a new instance of <see cref="FetchTieringCostSavingsInfoForVaultContent"/>. </summary>
        /// <param name="sourceTierType"> Source tier for the request. </param>
        /// <param name="targetTierType"> target tier for the request. </param>
        /// <param name="objectType"> This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types. </param>
        internal FetchTieringCostSavingsInfoForVaultContent(RecoveryPointTierType sourceTierType, RecoveryPointTierType targetTierType, string objectType) : base(sourceTierType, targetTierType, objectType)
        {
            ObjectType = objectType ?? "FetchTieringCostSavingsInfoForVaultRequest";
        }
    }
}
