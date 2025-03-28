// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> Preferences related to the shipment logistics of the sku. </summary>
    internal partial class TransportPreferences
    {
        /// <summary> Initializes a new instance of TransportPreferences. </summary>
        /// <param name="preferredShipmentType"> Indicates Shipment Logistics type that the customer preferred. </param>
        public TransportPreferences(TransportShipmentType preferredShipmentType)
        {
            PreferredShipmentType = preferredShipmentType;
        }

        /// <summary> Indicates Shipment Logistics type that the customer preferred. </summary>
        public TransportShipmentType PreferredShipmentType { get; set; }
    }
}
