// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Monitor.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Specify action need to be taken when rule type is converting log to
    /// metric
    /// </summary>
    [Newtonsoft.Json.JsonObject("Microsoft.WindowsAzure.Management.Monitoring.Alerts.Models.Microsoft.AppInsights.Nexus.DataContracts.Resources.ScheduledQueryRules.LogToMetricAction")]
    public partial class LogToMetricAction : Action
    {
        /// <summary>
        /// Initializes a new instance of the LogToMetricAction class.
        /// </summary>
        public LogToMetricAction()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LogToMetricAction class.
        /// </summary>
        /// <param name="criteria">Criteria of Metric</param>
        public LogToMetricAction(IList<Criteria> criteria)
        {
            Criteria = criteria;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets criteria of Metric
        /// </summary>
        [JsonProperty(PropertyName = "criteria")]
        public IList<Criteria> Criteria { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Criteria == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Criteria");
            }
            if (Criteria != null)
            {
                foreach (var element in Criteria)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
