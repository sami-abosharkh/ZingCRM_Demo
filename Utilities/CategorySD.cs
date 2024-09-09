namespace ZingCRM_Demo.Utilities
{
    public static class CategorySD
    {
        public enum CategoryEnum
        {
            Design,
            Electronics,
            Gifting,
            Manpower,
            OfficeLaunches,
            Documents,
            Photography,
            POSM,
            PromotingMaterial,
            Rental,
            ShippingInternational,
            ShippingLocal,
            Storage,
            TravelExpenses,
            Programming
        }

        public static readonly Dictionary<CategoryEnum, (string Name, string Description)> CategoryDictionary = new Dictionary<CategoryEnum, (string Name, string Description)>
        {
            { CategoryEnum.Design, ("Designs", "Everything that has to do with 2D and 3d designs.") },
            { CategoryEnum.Electronics, ("Electronics & Appliances", "All Electronic and Appliances which include batteries and tablets.") },
            { CategoryEnum.Gifting, ("Gifting", "All items designated for gifting in an activity that is gifting related, which includes notebooks and vouchers.") },
            { CategoryEnum.Manpower, ("Manpower", "All promoters and supervisors.") },
            { CategoryEnum.OfficeLaunches, ("Office Launches", "All items that are required for an office launch, this includes the gifts and danglers and other production elements that were created for the office launch.") },
            { CategoryEnum.Documents, ("Official Documents", "Anything that needed to be attested fora specific project.") },
            { CategoryEnum.Photography, ("Photography & Videography", "All recruited photographers and videographers.") },
            { CategoryEnum.POSM, ("POSM Productions", "All production elements within a project not including a giveaway and office launch project.") },
            { CategoryEnum.PromotingMaterial, ("Promoting Material", "Anything required to run a promotion activity which includes tables and uniforms.") },
            { CategoryEnum.Rental, ("Rental", "All location rental costs.") },
            { CategoryEnum.ShippingInternational, ("Shipping International", "All international shipments.") },
            { CategoryEnum.ShippingLocal, ("Shipping Local", "All local shipments including store deployment.") },
            { CategoryEnum.Storage, ("Storage & Warehousing", "All costs related to renting a temporary warehouse.") },
            { CategoryEnum.TravelExpenses, ("Travel Expenses", "All travels and lodging for specifc project.") },
            { CategoryEnum.Programming, ("Programming", "All VR and App Programming related costs.") }
        };
        
        // Method to retrieve the name and description by enum
        public static (string Name, string Description) GetCategoryInfo(CategoryEnum category)
        {
            return CategoryDictionary.TryGetValue(category, out var info)
                ? info
                : ("Unknown Category", "No description available."); // Fallback if the category is not found
        }
        
        public static string GetCategoryName(CategoryEnum category) => GetCategoryInfo(category).Name; // Method to retrieve the name by enum
        public static string GetCategoryDescription(CategoryEnum category) => GetCategoryInfo(category).Description; // Method to retrieve the description by enum

    }
}
