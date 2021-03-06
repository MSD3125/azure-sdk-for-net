// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Container level access token for CRR
    /// </summary>
    public partial class CrrAccessToken
    {
        /// <summary>
        /// Initializes a new instance of the CrrAccessToken class.
        /// </summary>
        public CrrAccessToken()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CrrAccessToken class.
        /// </summary>
        /// <param name="accessTokenString">Access token used for
        /// authentication</param>
        /// <param name="subscriptionId">Subscription Id of the source
        /// vault</param>
        /// <param name="resourceGroupName">Resource Group name of the source
        /// vault</param>
        /// <param name="resourceName">Resource Name of the source
        /// vault</param>
        /// <param name="resourceId">Resource Id of the source vault</param>
        /// <param name="recoveryPointId">Recovery Point Id</param>
        /// <param name="recoveryPointTime">Recovery Point Time</param>
        /// <param name="containerName">Container Unique name</param>
        /// <param name="containerType">Container Type</param>
        /// <param name="backupManagementType">Backup Management Type</param>
        /// <param name="datasourceType">Datasource Type</param>
        /// <param name="datasourceName">Datasource Friendly Name</param>
        /// <param name="datasourceId">Datasource Id</param>
        /// <param name="datasourceContainerName">Datasource Container Unique
        /// Name</param>
        /// <param name="coordinatorServiceStampId">CoordinatorServiceStampId
        /// to be used by BCM in restore call</param>
        /// <param name="coordinatorServiceStampUri">CoordinatorServiceStampUri
        /// to be used by BCM in restore call</param>
        /// <param name="protectionServiceStampId">ProtectionServiceStampId to
        /// be used by BCM in restore call</param>
        /// <param name="protectionServiceStampUri">ProtectionServiceStampUri
        /// to be used by BCM in restore call</param>
        /// <param name="tokenExtendedInformation">Extended Information about
        /// the token like FileSpec etc.</param>
        public CrrAccessToken(string accessTokenString = default(string), string subscriptionId = default(string), string resourceGroupName = default(string), string resourceName = default(string), string resourceId = default(string), string recoveryPointId = default(string), string recoveryPointTime = default(string), string containerName = default(string), string containerType = default(string), string backupManagementType = default(string), string datasourceType = default(string), string datasourceName = default(string), string datasourceId = default(string), string datasourceContainerName = default(string), string coordinatorServiceStampId = default(string), string coordinatorServiceStampUri = default(string), string protectionServiceStampId = default(string), string protectionServiceStampUri = default(string), string tokenExtendedInformation = default(string))
        {
            AccessTokenString = accessTokenString;
            SubscriptionId = subscriptionId;
            ResourceGroupName = resourceGroupName;
            ResourceName = resourceName;
            ResourceId = resourceId;
            RecoveryPointId = recoveryPointId;
            RecoveryPointTime = recoveryPointTime;
            ContainerName = containerName;
            ContainerType = containerType;
            BackupManagementType = backupManagementType;
            DatasourceType = datasourceType;
            DatasourceName = datasourceName;
            DatasourceId = datasourceId;
            DatasourceContainerName = datasourceContainerName;
            CoordinatorServiceStampId = coordinatorServiceStampId;
            CoordinatorServiceStampUri = coordinatorServiceStampUri;
            ProtectionServiceStampId = protectionServiceStampId;
            ProtectionServiceStampUri = protectionServiceStampUri;
            TokenExtendedInformation = tokenExtendedInformation;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets access token used for authentication
        /// </summary>
        [JsonProperty(PropertyName = "accessTokenString")]
        public string AccessTokenString { get; set; }

        /// <summary>
        /// Gets or sets subscription Id of the source vault
        /// </summary>
        [JsonProperty(PropertyName = "subscriptionId")]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// Gets or sets resource Group name of the source vault
        /// </summary>
        [JsonProperty(PropertyName = "resourceGroupName")]
        public string ResourceGroupName { get; set; }

        /// <summary>
        /// Gets or sets resource Name of the source vault
        /// </summary>
        [JsonProperty(PropertyName = "resourceName")]
        public string ResourceName { get; set; }

        /// <summary>
        /// Gets or sets resource Id of the source vault
        /// </summary>
        [JsonProperty(PropertyName = "resourceId")]
        public string ResourceId { get; set; }

        /// <summary>
        /// Gets or sets recovery Point Id
        /// </summary>
        [JsonProperty(PropertyName = "recoveryPointId")]
        public string RecoveryPointId { get; set; }

        /// <summary>
        /// Gets or sets recovery Point Time
        /// </summary>
        [JsonProperty(PropertyName = "recoveryPointTime")]
        public string RecoveryPointTime { get; set; }

        /// <summary>
        /// Gets or sets container Unique name
        /// </summary>
        [JsonProperty(PropertyName = "containerName")]
        public string ContainerName { get; set; }

        /// <summary>
        /// Gets or sets container Type
        /// </summary>
        [JsonProperty(PropertyName = "containerType")]
        public string ContainerType { get; set; }

        /// <summary>
        /// Gets or sets backup Management Type
        /// </summary>
        [JsonProperty(PropertyName = "backupManagementType")]
        public string BackupManagementType { get; set; }

        /// <summary>
        /// Gets or sets datasource Type
        /// </summary>
        [JsonProperty(PropertyName = "datasourceType")]
        public string DatasourceType { get; set; }

        /// <summary>
        /// Gets or sets datasource Friendly Name
        /// </summary>
        [JsonProperty(PropertyName = "datasourceName")]
        public string DatasourceName { get; set; }

        /// <summary>
        /// Gets or sets datasource Id
        /// </summary>
        [JsonProperty(PropertyName = "datasourceId")]
        public string DatasourceId { get; set; }

        /// <summary>
        /// Gets or sets datasource Container Unique Name
        /// </summary>
        [JsonProperty(PropertyName = "datasourceContainerName")]
        public string DatasourceContainerName { get; set; }

        /// <summary>
        /// Gets or sets coordinatorServiceStampId to be used by BCM in restore
        /// call
        /// </summary>
        [JsonProperty(PropertyName = "coordinatorServiceStampId")]
        public string CoordinatorServiceStampId { get; set; }

        /// <summary>
        /// Gets or sets coordinatorServiceStampUri to be used by BCM in
        /// restore call
        /// </summary>
        [JsonProperty(PropertyName = "coordinatorServiceStampUri")]
        public string CoordinatorServiceStampUri { get; set; }

        /// <summary>
        /// Gets or sets protectionServiceStampId to be used by BCM in restore
        /// call
        /// </summary>
        [JsonProperty(PropertyName = "protectionServiceStampId")]
        public string ProtectionServiceStampId { get; set; }

        /// <summary>
        /// Gets or sets protectionServiceStampUri to be used by BCM in restore
        /// call
        /// </summary>
        [JsonProperty(PropertyName = "protectionServiceStampUri")]
        public string ProtectionServiceStampUri { get; set; }

        /// <summary>
        /// Gets or sets extended Information about the token like FileSpec
        /// etc.
        /// </summary>
        [JsonProperty(PropertyName = "tokenExtendedInformation")]
        public string TokenExtendedInformation { get; set; }

    }
}
