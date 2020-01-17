using System;
using Newtonsoft.Json;

namespace Zebra.Savanna.Models
{
    /// <summary>
    /// Product recall report.
    /// </summary>
    public class Product
    {
        /// <summary>
        /// The first address line of the recalling firm.
        /// </summary>
        [JsonProperty(PropertyName = "address_1")]
        public string Address1 { get; set; }

        /// <summary>
        /// The second address line of the recalling firm.
        /// </summary>
        [JsonProperty(PropertyName = "address_2")]
        public string Address2 { get; set; }

        /// <summary>
        /// The date that FDA classified the recalled products as Class I, II, or III.
        /// </summary>
        [JsonProperty(PropertyName = "center_classification_date")]
        public DateTime CenterClassificationDate { get; set; }

        /// <summary>
        /// The city in which the recalling firm is located.
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Numerical designation (I, II, or III) that is assigned by FDA to a particular product recall that indicates
        /// the relative degree of health hazard.
        /// </summary>
        [JsonConverter(typeof(APIEnumConverter))]
        public Classification Classification { get; set; }

        /// <summary>
        /// A list of all lot and/or serial numbers, product numbers, packer or manufacturer numbers, sell or use by
        /// dates, etc., which appear on the product or its labeling.
        /// </summary>
        [JsonProperty(PropertyName = "code_info")]
        public string CodeInfo { get; set; }

        /// <summary>
        /// The country in which the recalling firm is located.
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// General area of initial distribution such as, "Distributors in 6 states: NY, VA, TX, GA, FL and MA; the
        /// Virgin Islands; Canada and Japan". The term "nationwide" is defined to mean the fifty states or a
        /// significant portion. Note that subsequent distribution by the consignees to other parties may not be
        /// included.
        /// </summary>
        [JsonProperty(PropertyName = "distribution_pattern")]
        public string DistributionPattern { get; set; }

        /// <summary>
        /// A numerical designation assigned by FDA to a specific recall event used for tracking purposes.
        /// </summary>
        [JsonProperty(PropertyName = "event_id")]
        public string EventID { get; set; }

        /// <summary>
        /// The method(s) by which the firm initially notified the public or their consignees of a recall. A consignee
        /// is a person or firm named in a bill of lading to whom or to whose order the product has or will be
        /// delivered.
        /// </summary>
        [JsonProperty(PropertyName = "initial_firm_notification")]
        public string InitialFirmNotification { get; set; }

        /// <summary>
        /// A list of additional lot and/or serial numbers, product numbers, expiration dates, sell or use by dates,
        /// etc., which appear on the product or its labeling.
        /// </summary>
        [JsonProperty(PropertyName = "more_code_info")]
        public string MoreCodeInfo { get; set; }

        /// <summary>
        /// Information about the recalled product.
        /// </summary>
        public OpenFDAProduct OpenFDA { get; set; }

        /// <summary>
        /// The postal code in which the recalling firm is located.
        /// </summary>
        [JsonProperty(PropertyName = "postal_code")]
        public string PostalCode { get; set; }

        /// <summary>
        /// A three-letter identifier assigned to a product category. Assignment is based upon the product
        /// classification designated under 21 CFR Parts 862-892, and the technology and intended use of the product.
        /// Occasionally these codes are changed over time.
        /// </summary>
        [JsonProperty(PropertyName = "product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// Brief description of the product being recalled.
        /// </summary>
        [JsonProperty(PropertyName = "product_description")]
        public string ProductDescription { get; set; }

        /// <summary>
        /// The amount of defective product subject to recall.
        /// </summary>
        [JsonProperty(PropertyName = "product_quantity")]
        public string ProductQuantity { get; set; }

        /// <summary>
        /// The type of product being recalled. For drug queries, this will always be `Drugs`.
        /// </summary>
        [JsonProperty(PropertyName = "product_type")]
        [JsonConverter(typeof(APIEnumConverter))]
        public ProductType ProductType { get; set; }

        /// <summary>
        /// Information describing how the product is defective and violates the FD&amp;C Act or related statutes.
        /// </summary>
        [JsonProperty(PropertyName = "reason_for_recall")]
        public string ReasonForRecall { get; set; }

        /// <summary>
        /// Date that the firm first began notifying the public or their consignees of the recall.
        /// </summary>
        [JsonProperty(PropertyName = "recall_initiation_date")]
        public DateTime RecallInitiationDate { get; set; }

        /// <summary>
        /// A numerical designation assigned by FDA to a specific recall event used for tracking purposes.
        /// </summary>
        [JsonProperty(PropertyName = "recall_number")]
        public string RecallNumber { get; set; }

        /// <summary>
        /// The firm that initiates a recall or, in the case of an FDA requested recall or FDA mandated recall, the
        /// firm that has primary responsibility for the manufacture and (or) marketing of the product to be recalled.
        /// </summary>
        [JsonProperty(PropertyName = "recalling_firm")]
        public string RecallingFirm { get; set; }

        /// <summary>
        /// Date that the FDA issued the enforcement report for the product recall.
        /// </summary>
        [JsonProperty(PropertyName = "report_date")]
        public DateTime ReportDate { get; set; }

        /// <summary>
        /// The U.S. state in which the recalling firm is located.
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// The status of a recall  (pending, ongoing, completed, or terminated).
        /// </summary>
        [JsonConverter(typeof(APIEnumConverter))]
        public Status Status { get; set; }

        /// <summary>
        /// Date that the FDA terminated the enforcement report for the product recall.
        /// </summary>
        [JsonProperty(PropertyName = "termination_date")]
        public DateTime TerminationDate { get; set; }

        /// <summary>
        /// Describes who initiated the recall. Recalls are almost always voluntary, meaning initiated by a firm. A
        /// recall is deemed voluntary when the firm voluntarily removes or corrects marketed products or the FDA
        /// requests the marketed products be removed or corrected. A recall is mandated when the firm was ordered by
        /// the FDA to remove or correct the marketed products, under section 518(e) of the FD&amp;C Act, National
        /// Childhood Vaccine Injury Act of 1986, 21 CFR 1271.440, Infant Formula Act of 1980 and its 1986 amendments,
        /// or the Food Safety Modernization Act (FSMA).
        /// </summary>
        [JsonProperty(PropertyName = "voluntary_mandated")]
        public string VoluntaryMandated { get; set; }
    }
}