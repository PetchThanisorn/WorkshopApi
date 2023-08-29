namespace ReactAspWorkShop.BackEnd.Model.Request
{
    public class ManagedUserRequest
    {
    }

    public class InsertManagedUserRequest
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string? Email{ get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public DateTime Birthday { get; set; }

    }

    public class UpdateManagedUserRequest
    {
        public int Id { get; set; }
        public string? FirstName { get; set; } = string.Empty;
        public string? LastName { get; set; } = string.Empty;
        public string? Email { get; set; } = string.Empty;
        public DateTime Birthday { get; set; }

    }

    public class DeleteManagedUserRequest
    {
        public int Id { get; set; }
    }

    public class SelectManagedUserRequest
    {
        public int? Id { get; set; }
    }

}
