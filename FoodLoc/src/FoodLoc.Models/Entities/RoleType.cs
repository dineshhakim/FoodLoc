namespace FoodLoc.Models.Entities
{
    public class RoleType : IEntity
    {
        public int Id { get; set; }
        public string RoleName { get; set; }
        public string Description { get; set; }
    }
}
