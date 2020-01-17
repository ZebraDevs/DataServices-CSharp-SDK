using Newtonsoft.Json;
using System.Collections.Generic;

namespace Zebra.Savanna.Models
{
    /// <summary>
    /// Information about a recalled medical device.
    /// </summary>
    public class OpenFDADevice
    {
        /// <summary>
        /// A risk based classification system for all medical devices (Federal Food, Drug, and Cosmetic Act, section 513).
        /// </summary>
        [JsonProperty(PropertyName = "device_class")]
        [JsonConverter(typeof(APIEnumConverter))]
        public DeviceClass DeviceClass { get; set; }

        /// <summary>
        /// This is the proprietary name, or trade name, of the cleared device.
        /// </summary>
        [JsonProperty(PropertyName = "device_name")]
        public string DeviceName { get; set; }

        /// <summary>
        /// Facility identifier assigned to facility by the FDA Office of Regulatory Affairs.
        /// </summary>
        [JsonProperty(PropertyName = "fei_number")]
        public string FEINumber { get; set; }

        /// <summary>
        /// FDA-assigned premarket notification number, including leading letters. Leading letters "BK" indicates
        /// 510(k) clearance, or Premarket Notification, cleared by Center for Biologics Evaluation and Research.
        /// Leading letters "DEN" indicates De Novo, or Evaluation of Automatic Class III Designation. Leading letter
        /// "K" indicates 510(k) clearance, or Premarket Notification. `Source`: 510(k)
        /// </summary>
        [JsonProperty(PropertyName = "k_number")]
        public List<string> KNumber { get; set; }

        /// <summary>
        /// Regulation Medical Specialty is assigned based on the regulation (e.g. 21 CFR Part 888 is Orthopedic
        /// Devices) which is why Class 3 devices lack the "Regulation Medical Specialty" field.
        /// </summary>
        [JsonProperty(PropertyName = "medical_specialty_description")]
        public string MedicalSpecialtyDescription { get; set; }

        /// <summary>
        /// Facility identifier assigned to facility by the FDA Office of Regulatory Affairs.
        /// </summary>
        [JsonProperty(PropertyName = "registration_number")]
        public string RegistrationNumber { get; set; }

        /// <summary>
        /// The classification regulation in the Code of Federal Regulations (CFR) under which the device is
        /// identified, described, and formally classified (Code of Federal regulations Title 21, 862.00 through
        /// 892.00). The classification regulation covers various aspects of design, clinical evaluation,
        /// manufacturing, packaging, labeling, and postmarket surveillance of the specific medical device.
        /// </summary>
        [JsonProperty(PropertyName = "regulation_number")]
        public string RegulationNumber { get; set; }
    }
}