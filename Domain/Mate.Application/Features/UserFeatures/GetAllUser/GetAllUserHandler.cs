using AutoMapper;
using Mate.Application.Repositories;
using MediatR;

namespace Mate.Application.Features.UserFeatures.GetAllUser;

public sealed class GetAllUserHandler : IRequestHandler<GetAllUserRequest, List<GetAllUserResponse>>
{
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;

    public GetAllUserHandler(IUserRepository userRepository, IMapper mapper)
    {
        _userRepository = userRepository;
        _mapper = mapper;
    }

    public async Task<List<GetAllUserResponse>> Handle(GetAllUserRequest request, CancellationToken cancellationToken)
    {
        var users = await _userRepository.GetAllAsync(null,null, cancellationToken);
        return _mapper.Map<List<GetAllUserResponse>>(users);
    }
}

