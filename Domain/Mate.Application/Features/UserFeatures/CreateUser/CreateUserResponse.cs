using System;
namespace Mate.Application.Features.UserFeatures.CreateUser
{
	public sealed record CreateUserResponse
	{
		public Guid Id { get; set; }
		public string Email { get; set; }
		public string DisplayName { get; set; }
        public bool IsEmailVerified { get; set; }
        public string FirebasePhotoURL { get; set; }
        public string ProfileURL { get; set; }
        public string BannerURL { get; set; }
    }
}

