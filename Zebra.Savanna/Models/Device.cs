using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Zebra.Savanna.Models
{
    /// <summary>
    /// Device recall report.
    /// </summary>
    public class Device
    {
        /// <summary>
        /// Date that FDA determined recall actions were completed and terminated the recall. For details about
        /// termination of a recall see http://www.accessdata.fda.gov/scripts/cdrh/cfdocs/cfcfr/cfrsearch.cfm?fr=7.55
        /// </summary>
        [JsonProperty(PropertyName = "event_date_terminated")]
        public DateTime EventDateTerminated { get; set; }

        /// <summary>
        /// Facility identifier assigned to facility by the FDA Office of Regulatory Affairs.
        /// </summary>
        [JsonProperty(PropertyName = "firm_fei_number")]
        public string FirmFEINumber { get; set; }

        /// <summary>
        /// FDA-assigned premarket notification number, including leading letters. Leading letters "BK" indicates
        /// 510(k) clearance, or Premarket Notification, cleared by Center for Biologics Evaluation and Research.
        /// Leading letters "DEN" indicates De Novo, or Evaluation of Automatic Class III Designation. Leading letter
        /// "K" indicates 510(k) clearance, or Premarket Notification. `Source`: 510(k)
        /// </summary>
        [JsonProperty(PropertyName = "k_numbers")]
        public List<string> KNumbers { get; set; }

        /// <summary>
        /// Information about the recalled medical device.
        /// </summary>
        public OpenFDADevice OpenFDA { get; set; }

        /// <summary>
        /// If 510(k) or PMA numbers are not applicable to the device recalled, the recall may contain other regulatory
        /// descriptions, such as `exempt`.
        /// </summary>
        [JsonProperty(PropertyName = "other_submission_description")]
        public string OtherSubmissionDescription { get; set; }

        /// <summary>
        /// FDA-assigned premarket application number, including leading letters. Leading letter "D" indicates Product
        /// Development Protocol type of Premarket Approval. Leading letters "BP" indicates Premarket Approval by
        /// Center for Biologics Evaluation and Research. Leading letter "H" indicates Humanitarian Device Exemption
        /// approval. Leading letter "N" indicates New Drug Application. Early PMAs were approved as NDAs. Leading
        /// letter "P" indicates Premarket Approval.
        /// </summary>
        [JsonProperty(PropertyName = "pma_numbers")]
        public List<string> PMANumbers { get; set; }

        /// <summary>
        /// A three-letter identifier assigned to a device category. Assignment is based upon the medical device
        /// classification designated under 21 CFR Parts 862-892, and the technology and intended use of the device.
        /// Occasionally these codes are changed over time.
        /// </summary>
        [JsonProperty(PropertyName = "product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// The product's number in the Recall Enterprise System.
        /// </summary>
        [JsonProperty(PropertyName = "product_res_number")]
        public string ProductResNumber { get; set; }

        /// <summary>
        /// A five digit, numerical designation assigned by FDA to a specific recall event used for tracking purposes.
        /// </summary>
        [JsonProperty(PropertyName = "res_event_number")]
        public string ResEventNumber { get; set; }

        /// <summary>
        /// FDA determined general type of recall cause. Per FDA policy, recall cause determinations are subject to
        /// modification up to the point of termination of the recall.
        /// </summary>
        [JsonProperty(PropertyName = "root_cause_description")]
        public string RootCauseDescription { get; set; }
    }
}