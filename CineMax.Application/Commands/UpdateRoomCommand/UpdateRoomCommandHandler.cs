﻿using CineMax.Core.Repositories;
using MediatR;

namespace CineMax.Application.Commands.UpdateRoomCommand
{
    public class UpdateRoomCommandHandler : IRequestHandler<UpdateRoomCommand, Unit>
    {
        private readonly IRoomRepository _roomRepository;

        public UpdateRoomCommandHandler(IRoomRepository roomRepository)
        {
            _roomRepository = roomRepository;
        }

        public async Task<Unit> Handle(UpdateRoomCommand request, CancellationToken cancellationToken)
        {
            var room = await _roomRepository.GetByIdRoomAndSectionsAsync(request.Id);

            room.Update(request.Name, request.IsRoomOcuped);

            _roomRepository.UpdateRoom(room);
            
            await _roomRepository.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
