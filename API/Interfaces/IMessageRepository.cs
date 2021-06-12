using System.Collections.Generic;
using System.Threading.Tasks;
using API.DTOs;
using API.Entities;

namespace API.Interfaces
{
    public interface IMessageRepository
    {
        void AddMessage(Message message);
        void DeleteMessage(Message message);
        Task<Message> GetMessage(int id);
        Task<IEnumerable<MessageDto>> GetMessageThread(int currentUserId, int recipientId);
        Task<bool> SaveAllAsync();
    }
}