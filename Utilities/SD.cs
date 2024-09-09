namespace ZingCRM_Demo.Utilities
{
    public static class SD
    {
        public const string Role_Admin = "Admin";
        public const string Role_Manager = "Manager";
        public const string Role_Accountant = "Accountant";
        public const string Role_OperationManager = "Operation Manager";
        public const string Role_ClientService = "Client Service";

        public const string Status_Pending = "Pending";
        public const string Status_Approved = "Approved";
        public const string Status_Rejected = "Rejected";
        public const string Status_Waiting = "Waiting For Client";
        public const string Status_Completed = "Completed";
        public const string Status_Transferred = "Transferred";

        public const string LockoutPeriod_FiveMinutes = "5 Minutes";
        public const string LockoutPeriod_HalfHour = "30 Minutes";
        public const string LockoutPeriod_OneHour = "1 Hour";
        public const string LockoutPeriod_OneDay = "1 Day";
        public const string LockoutPeriod_OneWeek = "1 Week";
        public const string LockoutPeriod_OneMonth = "1 Month";
        public const string LockoutPeriod_Forever = "Forever";

        //-- Phases
        public enum PhasesEnum
        {
            Initiation,
            CostEstimation,
            Quotation,
            Confirmation,
            PurchaseRequisition,
            Closure
        }

        public static readonly Dictionary<PhasesEnum, string> PhaseDictionary = new Dictionary<PhasesEnum, string>
        {
            { PhasesEnum.Initiation, "Project Initiation" },
            { PhasesEnum.CostEstimation, "Cost Estimation" },
            { PhasesEnum.Quotation, "Price Quotation" },
            { PhasesEnum.Confirmation, "Project Confirmation" },
            { PhasesEnum.PurchaseRequisition, "Purchase Requisition" },
            { PhasesEnum.Closure, "Project Closure" }
        };
        // Method to retrieve the value by enum
        public static string GetPhaseInfo(PhasesEnum phase)
        {
            return PhaseDictionary.TryGetValue(phase, out var description)
                ? description
                : "Unknown Phase"; // Fallback if the phase is not found
        }
    }
}