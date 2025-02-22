// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary>
    /// Forecasting Training related configuration.
    /// Serialized Name: ForecastingTrainingSettings
    /// </summary>
    public partial class ForecastingTrainingSettings : MachineLearningTrainingSettings
    {
        /// <summary> Initializes a new instance of ForecastingTrainingSettings. </summary>
        public ForecastingTrainingSettings()
        {
            AllowedTrainingAlgorithms = new ChangeTrackingList<ForecastingModel>();
            BlockedTrainingAlgorithms = new ChangeTrackingList<ForecastingModel>();
        }

        /// <summary> Initializes a new instance of ForecastingTrainingSettings. </summary>
        /// <param name="isDnnTrainingEnabled">
        /// Enable recommendation of DNN models.
        /// Serialized Name: TrainingSettings.enableDnnTraining
        /// </param>
        /// <param name="isModelExplainabilityEnabled">
        /// Flag to turn on explainability on best model.
        /// Serialized Name: TrainingSettings.enableModelExplainability
        /// </param>
        /// <param name="isOnnxCompatibleModelsEnabled">
        /// Flag for enabling onnx compatible models.
        /// Serialized Name: TrainingSettings.enableOnnxCompatibleModels
        /// </param>
        /// <param name="isStackEnsembleEnabled">
        /// Enable stack ensemble run.
        /// Serialized Name: TrainingSettings.enableStackEnsemble
        /// </param>
        /// <param name="isVoteEnsembleEnabled">
        /// Enable voting ensemble run.
        /// Serialized Name: TrainingSettings.enableVoteEnsemble
        /// </param>
        /// <param name="ensembleModelDownloadTimeout">
        /// During VotingEnsemble and StackEnsemble model generation, multiple fitted models from the previous child runs are downloaded.
        /// Configure this parameter with a higher value than 300 secs, if more time is needed.
        /// Serialized Name: TrainingSettings.ensembleModelDownloadTimeout
        /// </param>
        /// <param name="stackEnsembleSettings">
        /// Stack ensemble settings for stack ensemble run.
        /// Serialized Name: TrainingSettings.stackEnsembleSettings
        /// </param>
        /// <param name="allowedTrainingAlgorithms">
        /// Allowed models for forecasting task.
        /// Serialized Name: ForecastingTrainingSettings.allowedTrainingAlgorithms
        /// </param>
        /// <param name="blockedTrainingAlgorithms">
        /// Blocked models for forecasting task.
        /// Serialized Name: ForecastingTrainingSettings.blockedTrainingAlgorithms
        /// </param>
        internal ForecastingTrainingSettings(bool? isDnnTrainingEnabled, bool? isModelExplainabilityEnabled, bool? isOnnxCompatibleModelsEnabled, bool? isStackEnsembleEnabled, bool? isVoteEnsembleEnabled, TimeSpan? ensembleModelDownloadTimeout, MachineLearningStackEnsembleSettings stackEnsembleSettings, IList<ForecastingModel> allowedTrainingAlgorithms, IList<ForecastingModel> blockedTrainingAlgorithms) : base(isDnnTrainingEnabled, isModelExplainabilityEnabled, isOnnxCompatibleModelsEnabled, isStackEnsembleEnabled, isVoteEnsembleEnabled, ensembleModelDownloadTimeout, stackEnsembleSettings)
        {
            AllowedTrainingAlgorithms = allowedTrainingAlgorithms;
            BlockedTrainingAlgorithms = blockedTrainingAlgorithms;
        }

        /// <summary>
        /// Allowed models for forecasting task.
        /// Serialized Name: ForecastingTrainingSettings.allowedTrainingAlgorithms
        /// </summary>
        public IList<ForecastingModel> AllowedTrainingAlgorithms { get; set; }
        /// <summary>
        /// Blocked models for forecasting task.
        /// Serialized Name: ForecastingTrainingSettings.blockedTrainingAlgorithms
        /// </summary>
        public IList<ForecastingModel> BlockedTrainingAlgorithms { get; set; }
    }
}
