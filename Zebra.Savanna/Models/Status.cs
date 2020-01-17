namespace Zebra.Savanna.Models
{
    /// <summary>
    /// The status of a recall (pending, ongoing, completed, or terminated).
    /// </summary>
    public enum Status
    {
        /// <summary>
        /// A recall which is currently in progress.
        /// </summary>
        Ongoing,

        /// <summary>
        /// The recall action reaches the point at which the firm has actually retrieved and impounded all outstanding
        /// product that could reasonably be expected to be recovered, or has completed all product corrections.
        /// </summary>
        Completed,

        /// <summary>
        /// FDA has determined that all reasonable efforts have been made to remove or correct the violative product in
        /// accordance with the recall strategy, and proper disposition has been made according to the degree of
        /// hazard.
        /// </summary>
        Terminated,

        /// <summary>
        /// Actions that have been determined to be recalls, but that remain in the process of being classified.
        /// </summary>
        Pending,
    }
}