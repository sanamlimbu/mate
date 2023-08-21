namespace Mate.Application.Features.UserFeatures.GetAllUser;

public sealed record GetAllUserResponse
{
    public Guid Id { get; set; }
    public string FirebaseID { get; set; }
}

