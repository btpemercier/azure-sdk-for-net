// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary>
    /// Base definition for endpoint deployment.
    /// Serialized Name: EndpointDeploymentPropertiesBase
    /// </summary>
    public partial class MachineLearningEndpointDeploymentProperties
    {
        /// <summary> Initializes a new instance of MachineLearningEndpointDeploymentProperties. </summary>
        public MachineLearningEndpointDeploymentProperties()
        {
            EnvironmentVariables = new ChangeTrackingDictionary<string, string>();
            Properties = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of MachineLearningEndpointDeploymentProperties. </summary>
        /// <param name="codeConfiguration">
        /// Code configuration for the endpoint deployment.
        /// Serialized Name: EndpointDeploymentPropertiesBase.codeConfiguration
        /// </param>
        /// <param name="description">
        /// Description of the endpoint deployment.
        /// Serialized Name: EndpointDeploymentPropertiesBase.description
        /// </param>
        /// <param name="environmentId">
        /// ARM resource ID or AssetId of the environment specification for the endpoint deployment.
        /// Serialized Name: EndpointDeploymentPropertiesBase.environmentId
        /// </param>
        /// <param name="environmentVariables">
        /// Environment variables configuration for the deployment.
        /// Serialized Name: EndpointDeploymentPropertiesBase.environmentVariables
        /// </param>
        /// <param name="properties">
        /// Property dictionary. Properties can be added, but not removed or altered.
        /// Serialized Name: EndpointDeploymentPropertiesBase.properties
        /// </param>
        internal MachineLearningEndpointDeploymentProperties(MachineLearningCodeConfiguration codeConfiguration, string description, string environmentId, IDictionary<string, string> environmentVariables, IDictionary<string, string> properties)
        {
            CodeConfiguration = codeConfiguration;
            Description = description;
            EnvironmentId = environmentId;
            EnvironmentVariables = environmentVariables;
            Properties = properties;
        }

        /// <summary>
        /// Code configuration for the endpoint deployment.
        /// Serialized Name: EndpointDeploymentPropertiesBase.codeConfiguration
        /// </summary>
        public MachineLearningCodeConfiguration CodeConfiguration { get; set; }
        /// <summary>
        /// Description of the endpoint deployment.
        /// Serialized Name: EndpointDeploymentPropertiesBase.description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// ARM resource ID or AssetId of the environment specification for the endpoint deployment.
        /// Serialized Name: EndpointDeploymentPropertiesBase.environmentId
        /// </summary>
        public string EnvironmentId { get; set; }
        /// <summary>
        /// Environment variables configuration for the deployment.
        /// Serialized Name: EndpointDeploymentPropertiesBase.environmentVariables
        /// </summary>
        public IDictionary<string, string> EnvironmentVariables { get; set; }
        /// <summary>
        /// Property dictionary. Properties can be added, but not removed or altered.
        /// Serialized Name: EndpointDeploymentPropertiesBase.properties
        /// </summary>
        public IDictionary<string, string> Properties { get; set; }
    }
}
