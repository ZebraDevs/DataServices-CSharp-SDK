using Newtonsoft.Json;
using System.Collections.Generic;

namespace Zebra.Savanna.Models
{
    /// <summary>
    /// Information about a recalled food or drug.
    /// </summary>
    public class OpenFDAProduct
    {
        /// <summary>
        /// This corresponds to the NDA, ANDA, or BLA number reported by the labeler for products which have the
        /// corresponding Marketing Category designated. If the designated Marketing Category is OTC Monograph Final or
        /// OTC Monograph Not Final, then the application number will be the CFR citation corresponding to the
        /// appropriate Monograph (e.g. "part 341"). For unapproved drugs, this field will be null.
        /// </summary>
        [JsonProperty(PropertyName = "application_number")]
        public List<string> ApplicationNumber { get; set; }

        /// <summary>
        /// Brand or trade name of the drug product.
        /// </summary>
        [JsonProperty(PropertyName = "brand_name")]
        public List<string> BrandName { get; set; }

        /// <summary>
        /// Generic name(s) of the drug product.
        /// </summary>
        [JsonProperty(PropertyName = "generic_name")]
        public List<string> GenericName { get; set; }

        /// <summary>
        /// Whether or not the drug has been repackaged for distribution.
        /// </summary>
        [JsonProperty(PropertyName = "is_original_packager")]
        public bool IsOriginalPackager { get; set; }

        /// <summary>
        /// Name of manufacturer or company that makes this drug product, corresponding to the labeler code segment of
        /// the NDC.
        /// </summary>
        [JsonProperty(PropertyName = "manufacturer_name")]
        public List<string> ManufacturerName { get; set; }

        /// <summary>
        /// Unique identifier applied to a drug concept within the National Drug File Reference Terminology (NDF-RT).
        /// https://www.nlm.nih.gov/research/umls/sourcereleasedocs/current/NDFRT/
        /// </summary>
        [JsonProperty(PropertyName = "nui")]
        public List<string> NUI { get; set; }

        /// <summary>
        /// This NDC identifies the original packager.
        /// </summary>
        [JsonProperty(PropertyName = "original_packager_product_ndc")]
        public List<string> OriginalPackagerProductNDC { get; set; }

        /// <summary>
        /// This number, known as the NDC, identifies the labeler, product, and trade package size. The first segment,
        /// the labeler code, is assigned by the FDA. A labeler is any firm that manufactures (including repackers or
        /// relabelers), or distributes (under its own name) the drug.
        /// </summary>
        [JsonProperty(PropertyName = "package_ndc")]
        public List<string> PackageNDC { get; set; }

        /// <summary>
        /// Chemical structure classification of the drug product’s pharmacologic class. Takes the form of the
        /// classification, followed by `[Chemical/Ingredient]` (such as `Thiazides [Chemical/Ingredient]` or
        /// `Antibodies, Monoclonal [Chemical/Ingredient].
        /// </summary>
        [JsonProperty(PropertyName = "pharm_class_cs")]
        public List<string> PharmClassCS { get; set; }

        /// <summary>
        /// Established pharmacologic class associated with an approved indication of an active moiety (generic drug)
        /// that the FDA has determined to be scientifically valid and clinically meaningful. Takes the form of the
        /// pharmacologic class, followed by `[EPC]` (such as `Thiazide Diuretic [EPC]` or `Tumor Necrosis Factor
        /// Blocker [EPC]`.
        /// </summary>
        [JsonProperty(PropertyName = "pharm_class_epc")]
        public List<string> PharmClassEPC { get; set; }

        /// <summary>
        /// Physiologic effect or pharmacodynamic effect—tissue, organ, or organ system level functional activity of
        /// the drug’s established pharmacologic class. Takes the form of the effect, followed by `[PE]` (such as
        /// `Increased Diuresis [PE]` or `Decreased Cytokine Activity [PE]`.
        /// </summary>
        [JsonProperty(PropertyName = "pharm_class_pe")]
        public List<string> PharmClassPE { get; set; }

        /// <summary>
        /// Mechanism of action of the drug—molecular, subcellular, or cellular functional activity—of the drug’s
        /// established pharmacologic class. Takes the form of the mechanism of action, followed by `[MoA]` (such as
        /// `Calcium Channel Antagonists [MoA]` or `Tumor Necrosis Factor Receptor Blocking Activity [MoA]`.
        /// </summary>
        [JsonProperty(PropertyName = "pharm_class_moa")]
        public List<string> pharm_class_moa { get; set; }

        /// <summary>
        /// The labeler manufacturer code and product code segments of the NDC number, separated by a hyphen.
        /// </summary>
        [JsonProperty(PropertyName = "product_ndc")]
        public List<string> ProductNDC { get; set; }

        /// <summary>
        /// Type of drug product.
        /// http://www.fda.gov/ForIndustry/DataStandards/StructuredProductLabeling/ucm162063.htm
        /// </summary>
        [JsonProperty(PropertyName = "product_type")]
        public List<string> ProductType { get; set; }

        /// <summary>
        /// The route of administration of the drug product.
        /// http://www.fda.gov/ForIndustry/DataStandards/StructuredProductLabeling/ucm162034.htm
        /// </summary>
        [JsonProperty(PropertyName = "route")]
        public List<string> Route { get; set; }

        /// <summary>
        /// The RxNorm Concept Unique Identifier. RxCUI is a unique number that describes a semantic concept about the
        /// drug product, including its ingredients, strength, and dose forms.
        /// https://www.nlm.nih.gov/research/umls/rxnorm/docs/2012/rxnorm_doco_full_2012-3.html
        /// </summary>
        [JsonProperty(PropertyName = "rxcui")]
        public List<string> RxCUI { get; set; }

        /// <summary>
        /// Unique identifier for a particular version of a Structured Product Label for a product. Also referred to as
        /// the document ID.
        /// </summary>
        [JsonProperty(PropertyName = "spl_id")]
        public List<string> SPLId { get; set; }

        /// <summary>
        /// Unique identifier for the Structured Product Label for a product, which is stable across versions of the
        /// label. Also referred to as the set ID.
        /// </summary>
        [JsonProperty(PropertyName = "spl_set_id")]
        public List<string> SPLSetId { get; set; }

        /// <summary>
        /// The list of active ingredients of a drug product.
        /// </summary>
        [JsonProperty(PropertyName = "substance_name")]
        public List<string> SubstanceName { get; set; }

        /// <summary>
        /// Unique Ingredient Identifier, which is a non-proprietary, free, unique, unambiguous, non-semantic,
        /// alphanumeric identifier based on a substance’s molecular structure and/or descriptive information.
        /// http://fdasis.nlm.nih.gov/srs/srs.jsp
        /// </summary>
        [JsonProperty(PropertyName = "unii")]
        public List<string> UnII { get; set; }

        /// <summary>
        /// Universal Product Code
        /// https://en.wikipedia.org/wiki/Universal_Product_Code
        /// </summary>
        [JsonProperty(PropertyName = "upc")]
        public List<string> UPC { get; set; }
    }
}