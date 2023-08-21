using AutoMapper;
using Mate.Application.Features.UserFeatures.CreateUser;
using Mate.Application.Repositories;
using Mate.Domain.Entities;
using MediatR;

namespace Mate.Application.Features.PostFeatures.CreatePost;

public sealed class CreatePostHandler : IRequestHandler<CreatePostRequest, CreatePostResponse>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public CreatePostHandler(IUnitOfWork unitOfWork, IMapper mapper)
    { 
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<CreatePostResponse> Handle(CreatePostRequest request, CancellationToken cancellationToken)
    {
        var post = _mapper.Map<Post>(request);
        _unitOfWork.Post.Create(post);
        await _unitOfWork.Save(cancellationToken);

        return _mapper.Map<CreatePostResponse>(post);
    }
}

