namespace ZingCRM_Demo.Utilities
{
    public static class PhaseSD
    {
        public enum PhasesEnum
        {
            Created,
            Costed,
            Priced,
            Confirmed,
            Requested,
            Transferred,
            Closed
        }

        public static readonly Dictionary<PhasesEnum, string> PhaseDictionary = new Dictionary<PhasesEnum, string>
        {
            { PhasesEnum.Created, "Project Initiated" },
            { PhasesEnum.Costed, "Cost Estimated" },
            { PhasesEnum.Priced, "Price Quoted" },
            { PhasesEnum.Confirmed, "Project Approved" },
            { PhasesEnum.Requested, "Payment Requested" },
            { PhasesEnum.Transferred, "Funds Transferred" },
            { PhasesEnum.Closed, "Project Completed" }
        };

        // Method to retrieve the value by enum
        public static string GetValue(PhasesEnum phase)
        {
            return PhaseDictionary.TryGetValue(phase, out var description)
                ? description
                : "Unknown Phase"; // Fallback if the phase is not found
        }

        public static bool IsDone(string currentPhase, PhasesEnum phaseToCheck)
        {
            foreach (var kvp in PhaseDictionary)
            {
                if (kvp.Value.Equals(currentPhase, StringComparison.OrdinalIgnoreCase))
                {
                    return phaseToCheck <= kvp.Key;
                }
            }

            return false;
        }
    }
}
