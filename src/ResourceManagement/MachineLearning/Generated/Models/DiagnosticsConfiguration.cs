// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.MachineLearning.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.MachineLearning;
    using Microsoft.Azure.Management.MachineLearning.Fluent;
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Diagnostics settings for an Azure ML web service.
    /// </summary>
    public partial class DiagnosticsConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the DiagnosticsConfiguration class.
        /// </summary>
        public DiagnosticsConfiguration()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DiagnosticsConfiguration class.
        /// </summary>
        /// <param name="level">Specifies the verbosity of the diagnostic
        /// output. Valid values are: None - disables tracing; Error - collects
        /// only error (stderr) traces; All - collects all traces (stdout and
        /// stderr). Possible values include: 'None', 'Error', 'All'</param>
        /// <param name="expiry">Specifies the date and time when the logging
        /// will cease. If null, diagnostic collection is not time
        /// limited.</param>
        public DiagnosticsConfiguration(string level, System.DateTime? expiry = default(System.DateTime?))
        {
            Level = level;
            Expiry = expiry;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets specifies the verbosity of the diagnostic output.
        /// Valid values are: None - disables tracing; Error - collects only
        /// error (stderr) traces; All - collects all traces (stdout and
        /// stderr). Possible values include: 'None', 'Error', 'All'
        /// </summary>
        [JsonProperty(PropertyName = "level")]
        public string Level { get; set; }

        /// <summary>
        /// Gets or sets specifies the date and time when the logging will
        /// cease. If null, diagnostic collection is not time limited.
        /// </summary>
        [JsonProperty(PropertyName = "expiry")]
        public System.DateTime? Expiry { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Level == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Level");
            }
        }
    }
}